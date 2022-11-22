use crate::{Id, IdMutex, Map, MapMutex};
use rhai::packages::Package;
use rhai::Engine;
use rhai::OptimizationLevel;
use rhai_fs::FilesystemPackage;
use rhai_rand::RandomPackage;
use rhai_sci::SciPackage;
use std::collections::HashMap;
use std::num::Wrapping;
use std::ops::DerefMut;

thread_local! {
    static ASTS: MapMutex = HashMap::new().into();

    static ID: IdMutex = Wrapping(u64::MIN).into();

    static ENGINE: Engine = {
        let mut engine = Engine::new();

        RandomPackage::new().register_into_engine(&mut engine);
        SciPackage::new().register_into_engine(&mut engine);
        FilesystemPackage::new().register_into_engine(&mut engine);

        engine.set_optimization_level(OptimizationLevel::Full);

        engine
    }
}

pub fn ast<F, T>(fun: F) -> T
where
    F: FnOnce(&mut Map) -> T,
{
    ASTS.with(|a| {
        let mut a = a.lock().unwrap();
        let a = a.deref_mut();

        fun(a)
    })
}

pub fn engine<F, T>(fun: F) -> T
where
    F: FnOnce(&Engine) -> T,
{
    ENGINE.with(fun)
}

pub fn id<F, T>(fun: F) -> T
where
    F: FnOnce(&mut Id) -> T,
{
    ID.with(|i| {
        let mut i = i.lock().unwrap();
        let i = i.deref_mut();

        fun(i)
    })
}

pub fn with<F, T>(fun: F) -> T
where
    F: FnOnce(&mut Map, &Engine, &mut Id) -> T,
{
    ast(|a| engine(|e| id(|i| fun(a, e, i))))
}
