use std::ffi::{c_char, CStr};
use std::slice::from_raw_parts_mut;

#[repr(C)]
pub struct Raw {
    src: *const c_char,
    ptr: usize,
    len: i32,
}

impl Raw {
    pub fn to_rusty<F, T>(&self, fun: F) -> T
    where
        F: FnOnce(&'static str, &'static mut [u8]) -> T,
        T: Default,
    {
        let src = self.src;
        let ptr = self.ptr as *mut u8;
        let len = self.len as usize;

        let src = if src.is_null() {
            Ok("")
        } else {
            unsafe { CStr::from_ptr(src) }.to_str()
        };

        let buf = if ptr.is_null() {
            &mut []
        } else {
            unsafe { from_raw_parts_mut(ptr, len) }
        };

        src.map(|x| fun(x, buf)).unwrap_or_default()
    }
}
