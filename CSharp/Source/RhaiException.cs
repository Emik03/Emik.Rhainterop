// <copyright file="RhaiException.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
namespace Emik.Rhainterop;

/// <summary>An <see cref="Exception"/> for Rhai compiler or runtime errors.</summary>
public sealed class RhaiException : Exception
{
    /// <inheritdoc />
    public RhaiException(string message)
        : base(message) { }

    /// <inheritdoc />
    public RhaiException(string message, Exception innerException)
        : base(message, innerException) { }

    /// <inheritdoc />
    public RhaiException(SerializationInfo info, StreamingContext context)
        : base(info, context) { }

    /// <summary>Gets the <see cref="Exception"/> given when the buffer is too small to fit the value.</summary>
    [Pure]
    public static RhaiException Buffer { get; } =
        new("Script ran successfully, but couldn't write to buffer because the resulting value was larger than it.");

    /// <summary>Gets the <see cref="Exception"/> representing that one of the parameters was null.</summary>
    [Pure]
    public static RhaiException Null { get; } =
        new("The parameter 'source' in 'Rhai.Eval' contained a null reference.");

    /// <summary>Factory method.</summary>
    /// <param name="message">The message to pass.</param>
    /// <returns>A new <see cref="RhaiException"/>.</returns>
    public static RhaiException From(string message) => new(message);
}
