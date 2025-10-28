using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeEngine.Exceptions;

namespace ArcadeEngine.Models.Admin.AuthProviders.AuthProviderUpdateRequestProperties.Oauth2Properties;

[JsonConverter(typeof(ScopeDelimiterConverter))]
public enum ScopeDelimiter
{
    Undefined,
    V1,
}

sealed class ScopeDelimiterConverter : JsonConverter<ScopeDelimiter>
{
    public override ScopeDelimiter Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "," => ScopeDelimiter.Undefined,
            " " => ScopeDelimiter.V1,
            _ => (ScopeDelimiter)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        ScopeDelimiter value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                ScopeDelimiter.Undefined => ",",
                ScopeDelimiter.V1 => " ",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
