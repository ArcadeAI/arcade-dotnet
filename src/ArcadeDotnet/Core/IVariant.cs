namespace ArcadeDotnet.Core;

/// <summary>
/// Interface for creating variant types that wrap values.
/// </summary>
/// <typeparam name="TVariant">The variant type implementing this interface.</typeparam>
/// <typeparam name="TValue">The type of value being wrapped by the variant.</typeparam>
/// <remarks>
/// This interface enables the creation of strongly-typed wrappers around values,
/// useful for implementing the variant pattern in API models.
/// </remarks>
internal interface IVariant<TVariant, TValue>
    where TVariant : IVariant<TVariant, TValue>
{
    /// <summary>
    /// Creates a variant instance from a value.
    /// </summary>
    /// <param name="value">The value to wrap in the variant.</param>
    /// <returns>A new variant instance containing the specified value.</returns>
    static abstract TVariant From(TValue value);

    /// <summary>
    /// Gets the wrapped value.
    /// </summary>
    /// <value>The value contained in this variant.</value>
    TValue Value { get; }
}
