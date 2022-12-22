#region Emik.MPL

// <copyright file="SpanManager.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>

#endregion

namespace Emik.Rhainterop;

/// <summary>Allows a span into managed memory.</summary>
sealed class SpanManager : MemoryManager<byte>
{
    [NonNegativeValue]
    readonly int _length;

    [NonNegativeValue]
    readonly unsafe byte* _pointer;

    /// <summary>Initializes a new instance of the <see cref="SpanManager"/> class.</summary>
    /// <remarks><para>
    /// It is assumed that <paramref name="span"/> is already unmanaged or externally pinned.
    /// </para></remarks>
    /// <param name="span">The <see cref="Span{T}"/> to expose into a <see cref="Memory{T}"/>.</param>
    internal unsafe SpanManager(Span<byte> span)
    {
        _length = span.Length;

        fixed (byte* ptr = span)
            _pointer = ptr;
    }

    /// <inheritdoc />
    public override void Unpin() { }

    /// <inheritdoc />
    [Pure]
    public override unsafe MemoryHandle Pin(int elementIndex = 0)
    {
        if (elementIndex < 0 || elementIndex >= _length)
            throw new ArgumentOutOfRangeException(nameof(elementIndex));

        return new(_pointer + elementIndex);
    }

    /// <inheritdoc />
    [Pure]
    public override unsafe Span<byte> GetSpan() => new(_pointer, _length);

    /// <inheritdoc />
    protected override void Dispose(bool disposing) { }
}
