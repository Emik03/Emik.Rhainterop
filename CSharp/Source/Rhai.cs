// SPDX-License-Identifier: MPL-2.0

// ReSharper disable LambdaShouldNotCaptureContext
namespace Emik.Rhainterop;

/// <summary>Allows access to evaluation methods.</summary>
public static class Rhai
{
    /// <summary><c>eval</c> Function.</summary>
    /// <remarks><para>Or "How to Shoot Yourself in the Foot even Easier".</para></remarks>
    /// <param name="script">The script to execute.</param>
    /// <param name="length">The size of the internally allocated buffer.</param>
    /// <returns>The resulting type from the expression given, or a runtime error from Rhai.</returns>
    [Pure]
    public static Result<AST, Exception> Compile(string? script, [NonNegativeValue] int length = Span.Stackalloc) =>
        script is null ? RhaiException.Null : Span.Allocate(length, script, Compile);

    /// <summary><c>eval</c> Function.</summary>
    /// <remarks><para>Or "How to Shoot Yourself in the Foot even Easier".</para></remarks>
    /// <param name="buffer">The buffer to mutate.</param>
    /// <param name="script">The script to execute.</param>
    /// <returns>The resulting type from the expression given, or a runtime error from Rhai.</returns>
    [Pure]
    public static Result<AST, Exception> Compile(Span<byte> buffer, string? script) => script.CompileInner(buffer);

    /// <summary><c>eval</c> Function.</summary>
    /// <remarks><para>Or "How to Shoot Yourself in the Foot even Easier".</para></remarks>
    /// <param name="path">The path containing the script to execute.</param>
    /// <param name="length">The size of the internally allocated buffer.</param>
    /// <returns>The resulting type from the expression given, or a runtime error from Rhai.</returns>
    [MustUseReturnValue]
    public static Result<AST, Exception> CompileFile(
        [PathReference, UriString] string? path,
        [NonNegativeValue] int length = Span.Stackalloc
    ) =>
        path is null ? RhaiException.Null : Span.Allocate(length, path, CompileFile);

    /// <summary><c>eval</c> Function.</summary>
    /// <remarks><para>Or "How to Shoot Yourself in the Foot even Easier".</para></remarks>
    /// <param name="buffer">The buffer to mutate.</param>
    /// <param name="path">The path containing the script to execute.</param>
    /// <returns>The resulting type from the expression given, or a runtime error from Rhai.</returns>
    [MustUseReturnValue]
    public static Result<AST, Exception> CompileFile(Span<byte> buffer, [PathReference, UriString] string? path) =>
        path.CompileInner(buffer, true);

    /// <summary><c>eval</c> Function.</summary>
    /// <remarks><para>Or "How to Shoot Yourself in the Foot even Easier".</para></remarks>
    /// <typeparam name="T">
    /// The type of the resulting type, <see cref="object"/> can be used much like <c>rhai::Dynamic</c> in Rust.
    /// </typeparam>
    /// <param name="script">The script to execute.</param>
    /// <param name="length">The size of the internally allocated buffer.</param>
    /// <returns>The resulting type from the expression given, or a runtime error from Rhai.</returns>
    [MustUseReturnValue]
    public static Result<T, Exception> Eval<T>(string? script, [NonNegativeValue] int length = Span.Stackalloc) =>
        script is null ? RhaiException.Null : Span.Allocate(length, script, Eval<T>);

    /// <summary><c>eval</c> Function.</summary>
    /// <remarks><para>Or "How to Shoot Yourself in the Foot even Easier".</para></remarks>
    /// <typeparam name="T">
    /// The type of the resulting type, <see cref="object"/> can be used much like <c>rhai::Dynamic</c> in Rust.
    /// </typeparam>
    /// <param name="buffer">The buffer to mutate.</param>
    /// <param name="script">The script to execute.</param>
    /// <returns>The resulting type from the expression given, or a runtime error from Rhai.</returns>
    [MustUseReturnValue]
    public static Result<T, Exception> Eval<T>(Span<byte> buffer, string? script) => script.EvalInner<T>(buffer);

    /// <summary><c>eval</c> Function.</summary>
    /// <remarks><para>Or "How to Shoot Yourself in the Foot even Easier".</para></remarks>
    /// <typeparam name="T">
    /// The type of the resulting type, <see cref="object"/> can be used much like <c>rhai::Dynamic</c> in Rust.
    /// </typeparam>
    /// <param name="path">The path containing the script to execute.</param>
    /// <param name="length">The size of the internally allocated buffer.</param>
    /// <returns>The resulting type from the expression given, or a runtime error from Rhai.</returns>
    [MustUseReturnValue]
    public static Result<T, Exception> EvalFile<T>(
        [PathReference, UriString] string? path,
        [NonNegativeValue] int length = Span.Stackalloc
    ) =>
        path is null ? RhaiException.Null : Span.Allocate(length, path, EvalFile<T>);

    /// <summary><c>eval</c> Function.</summary>
    /// <remarks><para>Or "How to Shoot Yourself in the Foot even Easier".</para></remarks>
    /// <typeparam name="T">
    /// The type of the resulting type, <see cref="object"/> can be used much like <c>rhai::Dynamic</c> in Rust.
    /// </typeparam>
    /// <param name="buffer">The buffer to mutate.</param>
    /// <param name="path">The path containing the script to execute.</param>
    /// <returns>The resulting type from the expression given, or a runtime error from Rhai.</returns>
    [MustUseReturnValue]
    public static Result<T, Exception> EvalFile<T>(Span<byte> buffer, [PathReference, UriString] string? path) =>
        path.EvalInner<T>(buffer, true);

    /// <summary>Determines if a <see cref="string"/> is <see langword="null"/>.</summary>
    /// <param name="script">The script to do a <see langword="null"/> check on.</param>
    /// <param name="buffer">The buffer to clear and get the length from.</param>
    /// <param name="length">The length of the buffer.</param>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="script"/> is <see langword="null"/>,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [MustUseReturnValue]
    internal static bool IsNull(this string? script, in Span<byte> buffer, out int length)
    {
        length = 0;

        if (script is null)
            return true;

        buffer.Clear();
        length = buffer.Length;
        return false;
    }

    /// <summary>Writes to the buffer and deserializes it from <see cref="MessagePackSerializer"/>.</summary>
    /// <typeparam name="T">The destination type to deserialize to.</typeparam>
    /// <param name="result">The result obtained from the FFI call.</param>
    /// <param name="buffer">The buffer to write to.</param>
    /// <returns>A success <typeparamref name="T"/> if it can be deserialized, or an <see cref="Exception"/>.</returns>
    [MustUseReturnValue]
    internal static Result<T, Exception> Deserialize<T>(this in Result<bool, Exception> result, in Span<byte> buffer)
    {
        static TInner Get<TInner>(Memory<byte> x) => MessagePackSerializer.Deserialize<TInner>(x);

        static Result<TInner, Exception> TryGet<TInner>(Memory<byte> memory) => Try(Get<TInner>, memory);

        if (result.OutErr(out var err))
            return err;

        if (buffer.IsEmpty)
            return RhaiException.Buffer;

        using SpanManager manager = new(buffer);

        var mem = manager.Memory;

        return result.Ok
            ? TryGet<T>(mem)
            : TryGet<string>(mem).Map(RhaiException.From).ErrOrCast();
    }

    [MustUseReturnValue]
    static unsafe Result<AST, Exception> CompileInner(this string? script, in Span<byte> buffer, in bool isFile = false)
    {
        if (script.IsNull(buffer, out var length))
            return RhaiException.Null;

        fixed (byte* pointer = buffer)
            return new Raw(script, pointer, length).Compile(isFile);
    }

    [MustUseReturnValue]
    static unsafe Result<T, Exception> EvalInner<T>(this string? script, in Span<byte> buffer, in bool isFile = false)
    {
        if (script.IsNull(buffer, out var length))
            return RhaiException.Null;

        fixed (byte* pointer = buffer)
            return new Raw(script, pointer, length).Eval(isFile).Deserialize<T>(buffer);
    }
}
