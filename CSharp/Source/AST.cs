// SPDX-License-Identifier: MPL-2.0

// ReSharper disable AssignNullToNotNullAttribute
namespace Emik.Rhainterop;
#pragma warning disable CA5392, MA0055, SA1300, SYSLIB1054
/// <summary>Represents a key for a previously computed abstract syntax tree.</summary>
/// <remarks><para>
/// This type implements <see cref="IDisposable"/> to dispose the syntax tree when it is out of use.
/// If this type isn't disposed, the abstract syntax tree will remain in memory for the rest of the session.
/// </para></remarks>
public sealed class AST : ICloneable,
    IComparable,
    IComparable<AST>,
    IComparer,
    IComparer<AST>,
#if NET7_0_OR_GREATER
    IComparisonOperators<AST, AST, bool>,
#endif
    IConvertible,
    IDisposable,
    IEquatable<AST>,
    IEqualityComparer,
    IEqualityComparer<AST>
{
    /// <summary>Initializes a new instance of the <see cref="AST"/> class.</summary>
    /// <param name="id">The <see cref="Id"/> to store.</param>
    internal AST(ulong id) => Id = id;

    /// <summary>Gets the key value used to get the <see cref="AST"/> that represents this in Rust.</summary>
    [CLSCompliant(false), Pure]
    public ulong Id { get; }

    /// <inheritdoc />
    [Pure]
    public object Clone() => new AST(Id);

    /// <inheritdoc />
    [Pure]
    public int CompareTo(object? obj) => CompareTo(obj as AST);

    /// <inheritdoc />
    [Pure]
    public int CompareTo(AST? other) => other is null ? int.MaxValue : Id.CompareTo(other.Id);

    /// <inheritdoc />
    [Pure]
    public int Compare(object? x, object? y) => Compare(x as AST, y as AST);

    /// <inheritdoc />
    [Pure]
    public int Compare(AST? x, AST? y) => x?.CompareTo(y) ?? int.MinValue;

    /// <summary>Determines if two <see cref="AST"/> instances are equal.</summary>
    /// <param name="x">The left-hand side.</param>
    /// <param name="y">The right-hand side.</param>
    /// <returns>They are both <see langword="null"/>, or share the same <see cref="Id"/>.</returns>
    [Pure]
    public static bool operator ==(AST? x, AST? y) => x is null ? y is null : y is not null && x.Id == y.Id;

    /// <summary>Determines if two <see cref="AST"/> instances are unequal.</summary>
    /// <param name="x">The left-hand side.</param>
    /// <param name="y">The right-hand side.</param>
    /// <returns>One of them is <see langword="null"/>, or have different values for <see cref="Id"/>.</returns>
    [Pure]
    public static bool operator !=(AST? x, AST? y) => !(x == y);

    /// <summary>Determines if one <see cref="AST"/> is greater than another.</summary>
    /// <param name="x">The left-hand side.</param>
    /// <param name="y">The right-hand side.</param>
    /// <returns>The parameter <paramref name="x"/> has a greater <see cref="Id"/> than <paramref name="y"/>.</returns>
    [Pure]
    public static bool operator >(AST? x, AST? y) => x is null ? y is null : y is not null && x.Id > y.Id;

    /// <summary>Determines if one <see cref="AST"/> is greater or equal than another.</summary>
    /// <param name="x">The left-hand side.</param>
    /// <param name="y">The right-hand side.</param>
    /// <returns>
    /// The parameter <paramref name="x"/> has a greater or equal <see cref="Id"/> than <paramref name="y"/>.
    /// </returns>
    [Pure]
    public static bool operator >=(AST? x, AST? y) => x == y || x > y;

    /// <summary>Determines if one <see cref="AST"/> is less than another.</summary>
    /// <param name="x">The left-hand side.</param>
    /// <param name="y">The right-hand side.</param>
    /// <returns>The parameter <paramref name="x"/> has a lesser <see cref="Id"/> than <paramref name="y"/>.</returns>
    [Pure]
    public static bool operator <(AST? x, AST? y) => y > x;

    /// <summary>Determines if one <see cref="AST"/> is less or equal than another.</summary>
    /// <param name="x">The left-hand side.</param>
    /// <param name="y">The right-hand side.</param>
    /// <returns>
    /// The parameter <paramref name="x"/> has a lesser or equal <see cref="Id"/> than <paramref name="y"/>.
    /// </returns>
    [Pure]
    public static bool operator <=(AST? x, AST? y) => x == y || x < y;

    /// <inheritdoc />
    [Pure]
    bool IConvertible.ToBoolean(IFormatProvider? provider) => ((IConvertible)Id).ToBoolean(provider);

    /// <inheritdoc />
    [Pure]
    byte IConvertible.ToByte(IFormatProvider? provider) => ((IConvertible)Id).ToByte(provider);

    /// <inheritdoc />
    [Pure]
    char IConvertible.ToChar(IFormatProvider? provider) => ((IConvertible)Id).ToChar(provider);

    /// <inheritdoc />
    [NonNegativeValue, Pure]
    decimal IConvertible.ToDecimal(IFormatProvider? provider) => ((IConvertible)Id).ToDecimal(provider);

    /// <inheritdoc />
    [NonNegativeValue, Pure]
    double IConvertible.ToDouble(IFormatProvider? provider) => ((IConvertible)Id).ToDouble(provider);

    /// <inheritdoc />
    [NonNegativeValue, Pure]
    float IConvertible.ToSingle(IFormatProvider? provider) => ((IConvertible)Id).ToSingle(provider);

    /// <inheritdoc />
    [NonNegativeValue, Pure]
    int IConvertible.ToInt32(IFormatProvider? provider) => ((IConvertible)Id).ToInt32(provider);

    /// <inheritdoc />
    [NonNegativeValue, Pure]
    long IConvertible.ToInt64(IFormatProvider? provider) => ((IConvertible)Id).ToInt64(provider);

    /// <inheritdoc />
    [NonNegativeValue, Pure]
    sbyte IConvertible.ToSByte(IFormatProvider? provider) => ((IConvertible)Id).ToSByte(provider);

    /// <inheritdoc />
    [NonNegativeValue, Pure]
    short IConvertible.ToInt16(IFormatProvider? provider) => ((IConvertible)Id).ToInt16(provider);

    /// <inheritdoc />
    [Pure]
    string IConvertible.ToString(IFormatProvider? provider) => Id.ToString(provider);

    /// <inheritdoc />
    [Pure]
    object IConvertible.ToType(Type? conversionType, IFormatProvider? provider) =>
        conversionType is null ? Id : ((IConvertible)Id).ToType(conversionType, provider);

    /// <inheritdoc />
    [Pure]
    uint IConvertible.ToUInt32(IFormatProvider? provider) => ((IConvertible)Id).ToUInt32(provider);

    /// <inheritdoc />
    [Pure]
    ulong IConvertible.ToUInt64(IFormatProvider? provider) => ((IConvertible)Id).ToUInt64(provider);

    /// <inheritdoc />
    [Pure]
    ushort IConvertible.ToUInt16(IFormatProvider? provider) => ((IConvertible)Id).ToUInt16(provider);

    /// <inheritdoc />
    [Pure]
    DateTime IConvertible.ToDateTime(IFormatProvider? provider) => ((IConvertible)Id).ToDateTime(provider);

    /// <inheritdoc />
    [Pure]
    TypeCode IConvertible.GetTypeCode() => Id.GetTypeCode();

    /// <inheritdoc />
    public void Dispose()
    {
        GC.SuppressFinalize(this);
        Trace.WriteLineIf(Id is 0 || !drop(Id), "Failed to drop AST.");
    }

    /// <inheritdoc />
    [Pure]
    public new bool Equals(object? x, object? y) => Equals(x as AST, y as AST);

    /// <inheritdoc />
    [Pure]
    public int GetHashCode(object? obj) => GetHashCode(obj as AST);

    /// <inheritdoc />
    [Pure]
    public bool Equals(AST? x, AST? y) => x == y;

    /// <inheritdoc />
    [Pure]
    public int GetHashCode(AST? obj) => obj?.GetHashCode() ?? 0;

    /// <inheritdoc />
    [Pure]
    public bool Equals(AST? other) => other is not null && Id == other.Id;

    /// <summary>Finalizes an instance of the <see cref="AST"/> class.</summary>
    ~AST() => Dispose();

    /// <summary>Implicitly calls <see cref="Id"/>.</summary>
    /// <param name="ast">The <see cref="AST"/> to grab <see cref="Id"/>.</param>
    /// <returns>The value <see cref="Id"/>, or 0 if <see langword="null"/>.</returns>
    [CLSCompliant(false), Pure]
    public static implicit operator ulong(AST? ast) => ast?.Id ?? 0;

    /// <inheritdoc />
    [Pure]
    public override bool Equals(object? obj) => Equals(obj as AST);

    /// <inheritdoc />
    [Pure]
    public override int GetHashCode() => Id.GetHashCode();

    /// <inheritdoc />
    [Pure]
    public override string ToString() => $"{nameof(AST)} {nameof(Id)} = {Id}";

    /// <summary><c>eval</c> Function.</summary>
    /// <remarks><para>Or "How to Shoot Yourself in the Foot even Easier".</para></remarks>
    /// <typeparam name="T">
    /// The type of the resulting type, <see cref="object"/> can be used much like <c>rhai::Dynamic</c> in Rust.
    /// </typeparam>
    /// <param name="length">The size of the internally allocated buffer.</param>
    /// <returns>The resulting type from the expression given, or a runtime error from Rhai.</returns>
    [MustUseReturnValue]

    // ReSharper disable once LambdaShouldNotCaptureContext
    public Result<T, RhaiException> Eval<T>(int length = Span.Stackalloc)
        where T : notnull => // ReSharper disable once LambdaShouldNotCaptureContext
        Span.Allocate(length, Eval<T>);

    /// <summary><c>eval</c> Function.</summary>
    /// <remarks><para>Or "How to Shoot Yourself in the Foot even Easier".</para></remarks>
    /// <typeparam name="T">
    /// The type of the resulting type, <see cref="object"/> can be used much like <c>rhai::Dynamic</c> in Rust.
    /// </typeparam>
    /// <param name="buffer">The buffer to mutate.</param>
    /// <returns>The resulting type from the expression given, or a runtime error from Rhai.</returns>
    [MustUseReturnValue]
    public Result<T, RhaiException> Eval<T>(Span<byte> buffer)
        where T : notnull =>
        EvalInner<T>(buffer);

    /// <summary>Calls the constructor.</summary>
    /// <param name="id">The <see cref="Id"/> to store.</param>
    /// <returns>A new instance of <see cref="AST"/> with the inner <see cref="Id"/> set.</returns>
    [Pure]
    internal static AST New(ulong id) => new(id);

    [DllImport(Raw.Lib)]
    static extern bool drop(ulong id);

    [MustUseReturnValue]
    unsafe Result<T, RhaiException> EvalInner<T>(Span<byte> buffer)
        where T : notnull
    {
        var length = buffer.Length;

        fixed (byte* pointer = buffer)
            return new Raw(pointer, length).Eval(this).Deserialize<T>(buffer);
    }
}
