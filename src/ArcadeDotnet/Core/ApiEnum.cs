using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Exceptions;

namespace ArcadeDotnet.Core;

/// <summary>
/// Represents an enumeration value that can be serialized to and from both raw and enum types.
/// </summary>
/// <typeparam name="TRaw">The raw type used for serialization (typically <see cref="string"/> or <see cref="int"/>).</typeparam>
/// <typeparam name="TEnum">The enumeration type that represents the strongly-typed values.</typeparam>
/// <param name="Json">The JSON element containing the serialized value.</param>
/// <remarks>
/// This record struct provides a bridge between raw API values and strongly-typed enums,
/// allowing for both type-safe access and handling of unknown values.
/// It supports implicit conversions to both raw and enum types for convenient usage.
/// </remarks>
public record struct ApiEnum<TRaw, TEnum>(JsonElement Json)
    where TEnum : struct, Enum
{
    /// <summary>
    /// Gets the raw value of the enumeration.
    /// </summary>
    /// <returns>The raw value as type <typeparamref name="TRaw"/>.</returns>
    /// <exception cref="ArcadeInvalidDataException">Thrown when the JSON element cannot be deserialized to the raw type.</exception>
    public readonly TRaw Raw() =>
        JsonSerializer.Deserialize<TRaw>(Json, ModelBase.SerializerOptions)
        ?? throw new ArcadeInvalidDataException($"Failed to deserialize {nameof(Json)} to {typeof(TRaw).Name}");

    /// <summary>
    /// Gets the strongly-typed enum value.
    /// </summary>
    /// <returns>The enum value as type <typeparamref name="TEnum"/>.</returns>
    public readonly TEnum Value() =>
        JsonSerializer.Deserialize<TEnum>(Json, ModelBase.SerializerOptions);

    /// <summary>
    /// Validates that the enum value is defined in the enumeration type.
    /// </summary>
    /// <exception cref="ArcadeInvalidDataException">Thrown when the value is not a defined member of the enumeration.</exception>
    /// <remarks>
    /// Use this method to ensure the API returned a known enum value rather than an undefined value.
    /// </remarks>
    public readonly void Validate()
    {
        var value = Value();
        if (!Enum.IsDefined(typeof(TEnum), value))
        {
            throw new ArcadeInvalidDataException(
                $"Value '{value}' is not a valid member of enum type {typeof(TEnum).Name}"
            );
        }
    }

    /// <summary>
    /// Implicitly converts the <see cref="ApiEnum{TRaw,TEnum}"/> to its raw value.
    /// </summary>
    /// <param name="value">The enum wrapper to convert.</param>
    public static implicit operator TRaw(ApiEnum<TRaw, TEnum> value) => value.Raw();

    /// <summary>
    /// Implicitly converts the <see cref="ApiEnum{TRaw,TEnum}"/> to its enum value.
    /// </summary>
    /// <param name="value">The enum wrapper to convert.</param>
    public static implicit operator TEnum(ApiEnum<TRaw, TEnum> value) => value.Value();

    /// <summary>
    /// Implicitly converts a raw value to an <see cref="ApiEnum{TRaw,TEnum}"/>.
    /// </summary>
    /// <param name="value">The raw value to convert.</param>
    public static implicit operator ApiEnum<TRaw, TEnum>(TRaw value) =>
        new(JsonSerializer.SerializeToElement(value, ModelBase.SerializerOptions));

    /// <summary>
    /// Implicitly converts an enum value to an <see cref="ApiEnum{TRaw,TEnum}"/>.
    /// </summary>
    /// <param name="value">The enum value to convert.</param>
    public static implicit operator ApiEnum<TRaw, TEnum>(TEnum value) =>
        new(JsonSerializer.SerializeToElement(value, ModelBase.SerializerOptions));
}

/// <summary>
/// JSON converter for <see cref="ApiEnum{TRaw,TEnum}"/> types.
/// </summary>
/// <typeparam name="TRaw">The raw type used for serialization.</typeparam>
/// <typeparam name="TEnum">The enumeration type.</typeparam>
public sealed class ApiEnumConverter<TRaw, TEnum> : JsonConverter<ApiEnum<TRaw, TEnum>>
    where TEnum : struct, Enum
{
    /// <summary>
    /// Reads and converts the JSON to an <see cref="ApiEnum{TRaw,TEnum}"/>.
    /// </summary>
    /// <param name="reader">The reader to read JSON from.</param>
    /// <param name="typeToConvert">The type of object to convert to.</param>
    /// <param name="options">The serializer options to use.</param>
    /// <returns>The converted <see cref="ApiEnum{TRaw,TEnum}"/> value.</returns>
    public override ApiEnum<TRaw, TEnum> Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    ) => new(JsonSerializer.Deserialize<JsonElement>(ref reader, options));

    /// <summary>
    /// Writes the specified <see cref="ApiEnum{TRaw,TEnum}"/> value as JSON.
    /// </summary>
    /// <param name="writer">The writer to write JSON to.</param>
    /// <param name="value">The enum value to convert to JSON.</param>
    /// <param name="options">The serializer options to use.</param>
    public override void Write(
        Utf8JsonWriter writer,
        ApiEnum<TRaw, TEnum> value,
        JsonSerializerOptions options
    ) => JsonSerializer.Serialize(writer, value.Json, options);
}
