mod engines;
mod pointers;

use crate::engines::{ast, engine, with};
use crate::pointers::Raw;
use rhai::plugin::RhaiResult;
use rhai::{Engine, AST};
use rmp_serde::Serializer;
use serde::Serialize;
use std::collections::HashMap;
use std::num::Wrapping;
use std::sync::Mutex;

pub type ASTResult<E> = Result<AST, E>;
pub type Id = Wrapping<u64>;
pub type IdMutex = Mutex<Id>;
pub type Map = HashMap<u64, AST>;
pub type MapMutex = Mutex<Map>;

#[no_mangle]
pub extern "C" fn compile(raw: Raw) -> u64 {
    raw.to_rusty(|src, buf| save::<_, _, &str>(src, buf, Engine::compile))
}

#[no_mangle]
pub extern "C" fn compile_file(raw: Raw) -> u64 {
    raw.to_rusty(|src, buf| save(src, buf, Engine::compile_file))
}

#[no_mangle]
pub extern "C" fn drop(id: u64) -> bool {
    ast(|a| a.remove(&id).is_some())
}

#[no_mangle]
pub extern "C" fn eval(raw: Raw) -> bool {
    raw.to_rusty(|src, buf| run(src, buf, Engine::eval))
}

#[no_mangle]
pub extern "C" fn eval_ast(raw: Raw, id: u64) -> bool {
    raw.to_rusty(|_, buf| {
        ast(|a| {
            a.get(&id)
                .map(|x| run(x, buf, Engine::eval_ast))
                .unwrap_or_default()
        })
    })
}

#[no_mangle]
pub extern "C" fn eval_file(raw: Raw) -> bool {
    raw.to_rusty(|src, buf| run(src, buf, Engine::eval_file))
}

fn run<S, T, P>(src: S, buf: &'static mut [u8], fun: T) -> bool
where
    T: FnOnce(&Engine, P) -> RhaiResult,
    S: Into<P>,
{
    engine(|e| {
        let src = src.into();
        let res = fun(e, src);
        write(buf, res)
    })
}

fn write<E, T>(buf: &'static mut [u8], res: Result<T, E>) -> bool
where
    E: ToString,
    T: Serialize,
{
    let serializer = &mut Serializer::new(buf);
    let ok = res.is_ok();

    match res {
        Ok(x) => x.serialize(serializer).ok(),
        Err(x) => x.to_string().serialize(serializer).ok(),
    };

    ok
}

fn save<E, F, P>(src: &'static str, buf: &'static mut [u8], fun: F) -> u64
where
    E: ToString,
    F: FnOnce(&Engine, P) -> ASTResult<E>,
    P: From<&'static str>,
{
    with(|a, e, i| {
        let src = src.into();
        let res = fun(e, src);
        *i += 1;

        let ser = res.map(|x| {
            a.insert(i.0, x);
        });

        write(buf, ser);

        i.0
    })
}
