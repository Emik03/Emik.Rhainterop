#region Emik.MPL

// <copyright file="Raw.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>

#endregion

namespace Emik.Rhainterop;

#pragma warning disable SA1300
/// <summary>Stores two buffers to transmit via FFI. Internal use only, and very <see langword="unsafe"/>.</summary>
[StructLayout(LayoutKind.Sequential)]
readonly struct Raw
{
    /// <summary>The library name.</summary>
    internal const string Lib = "rhainterop";

    // Fields are implicitly used via FFI.
    // ReSharper disable PrivateFieldCanBeConvertedToLocalVariable
    [UsedImplicitly]
    readonly string? _source;

    [UsedImplicitly, NonNegativeValue]
    readonly nuint _pointer;

    [UsedImplicitly, NonNegativeValue]
    readonly int _length;

    /// <summary>Initializes a new instance of the <see cref="Raw"/> struct. Assumes the pointer is pinned.</summary>
    /// <param name="source">The source to store. Can be null.</param>
    /// <param name="pointer">The pointer to the mutable buffer. Can be null.</param>
    /// <param name="length">The length to the mutable buffer.</param>
    internal unsafe Raw(in string? source, in byte* pointer, [NonNegativeValue] in int length)
    {
        _source = source;
        _pointer = (nuint)pointer;
        _length = length;
    }

    /// <summary>Initializes a new instance of the <see cref="Raw"/> struct. Assumes the pointer is pinned.</summary>
    /// <param name="pointer">The pointer to the mutable buffer. Can be null.</param>
    /// <param name="length">The length to the mutable buffer.</param>
    internal unsafe Raw(in byte* pointer, [NonNegativeValue] in int length)
        : this(null, pointer, length) { }

    /// <summary>Sends this instance to Rust.</summary>
    /// <param name="isFile">Whether <see cref="_source"/> is source code, or a <see cref="Uri"/> to one.</param>
    /// <returns>
    /// A success <see see="bool"/> which has the value of whether it succeeded,
    /// or a possible <see cref="Exception"/> from the FFI boundary; e.g. a panic.
    /// Theoretically, this shouldn't ever happen, but this cannot be verifiable.
    /// </returns>
    [MustUseReturnValue]
    internal Result<bool, Exception> Eval(in bool isFile) => Try<Raw, bool>(isFile ? eval_file : eval, this);

    /// <summary>Sends this instance to Rust.</summary>
    /// <param name="ast">The abstract syntax tree to use as a key value.</param>
    /// <returns>
    /// A success <see see="bool"/> which has the value of whether it succeeded,
    /// or a possible <see cref="Exception"/> from the FFI boundary; e.g. a panic.
    /// Theoretically, this shouldn't ever happen, but this cannot be verifiable.
    /// </returns>
    [MustUseReturnValue]
    internal Result<bool, Exception> Eval(in AST ast) => Try(eval_ast, this, ast.Id);

    /// <summary>Sends this instance to Rust.</summary>
    /// <param name="isFile">Whether <see cref="_source"/> is source code, or a <see cref="Uri"/> to one.</param>
    /// <returns>
    /// A success <see see="AST"/> which has the returned abstract syntax tree,
    /// or a possible <see cref="Exception"/> from the FFI boundary; e.g. a panic.
    /// Theoretically, this shouldn't ever happen, but this cannot be verifiable.
    /// </returns>
    [MustUseReturnValue]
    internal Result<AST, Exception> Compile(in bool isFile) =>
        Try<Raw, ulong>(isFile ? compile_file : compile, this).Map(AST.New);

    [DllImport(Lib), Pure]
    static extern ulong compile(Raw raw);

    [DllImport(Lib), MustUseReturnValue]
    static extern ulong compile_file(Raw raw);

    [DllImport(Lib), MustUseReturnValue]
    static extern bool eval(Raw raw);

    [DllImport(Lib), MustUseReturnValue]
    static extern bool eval_ast(Raw raw, ulong id);

    [DllImport(Lib), MustUseReturnValue]
    static extern bool eval_file(Raw raw);
}
