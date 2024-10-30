// SPDX-License-Identifier: MPL-2.0
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
    /// It is assumed that <paramref name="pointer"/> is already unmanaged or externally pinned.
    /// </para></remarks>
    /// <param name="pointer">The pointer to the mutable buffer.</param>
    /// <param name="length">The length of the mutable buffer.</param>
    internal unsafe SpanManager(byte* pointer, int length)
    {
        _pointer = pointer;
        _length = length;
    }

    /// <inheritdoc />
    public override void Unpin() { }

    /// <inheritdoc />
    [Pure]
    public override unsafe MemoryHandle Pin(int elementIndex = 0) =>
        (uint)elementIndex < _length
            ? new(_pointer + elementIndex)
            : throw new ArgumentOutOfRangeException(nameof(elementIndex));

    /// <inheritdoc />
    [Pure]
    public override unsafe Span<byte> GetSpan() => new(_pointer, _length);

    /// <inheritdoc />
#pragma warning disable IDISP010
    protected override void Dispose(bool disposing) { }
#pragma warning restore IDISP010
}
