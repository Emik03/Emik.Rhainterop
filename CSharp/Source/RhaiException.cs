// SPDX-License-Identifier: MPL-2.0
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
    public static RhaiException Buffer { get; } = new("Insufficient size of buffer.");

    /// <summary>Gets the <see cref="Exception"/> representing that one of the parameters was null.</summary>
    [Pure]
    public static RhaiException Parameter { get; } = new("The parameter 'source' was a null reference.");

    /// <summary>Gets the <see cref="Exception"/> representing that one of the parameters was null.</summary>
    [Pure]
    public static RhaiException Return { get; } = new("The return value of 'Rhai.Eval' was a null reference.");

    /// <summary>Factory method.</summary>
    /// <param name="message">The message to pass.</param>
    /// <returns>
    /// The new <see cref="RhaiException"/> instance containing the parameter <paramref name="message"/>.
    /// </returns>
    public static RhaiException From(string message) => new(message);

    /// <summary>Factory method.</summary>
    /// <param name="exception">The <see cref="Exception"/> to pass.</param>
    /// <returns>
    /// The new <see cref="RhaiException"/>, or <paramref name="exception"/> if already a <see cref="RhaiException"/>.
    /// </returns>
    public static RhaiException From(Exception exception) =>
        exception as RhaiException ?? new("A runtime error occured.", exception);
}
