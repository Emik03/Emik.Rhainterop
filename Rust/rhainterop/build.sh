rustup target add --toolchain nightly aarch64-unknown-linux-gnu i686-pc-windows-gnu i686-pc-windows-msvc i686-unknown-linux-gnu x86_64-apple-darwin x86_64-pc-windows-gnu x86_64-pc-windows-msvc x86_64-unknown-linux-gnu
cargo build --target=aarch64-unknown-linux-gnu --release
cargo build --target=i686-pc-windows-gnu --release
cargo build --target=i686-pc-windows-msvc --release
cargo build --target=i686-unknown-linux-gnu --release
cargo build --target=x86_64-apple-darwin --release
cargo build --target=x86_64-pc-windows-gnu --release
cargo build --target=x86_64-pc-windows-msvc --release
cargo build --target=x86_64-unknown-linux-gnu --release
