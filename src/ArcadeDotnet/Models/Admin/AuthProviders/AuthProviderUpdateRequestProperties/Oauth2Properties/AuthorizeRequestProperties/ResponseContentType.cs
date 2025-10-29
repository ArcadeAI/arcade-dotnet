using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Exceptions;

namespace ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderUpdateRequestProperties.Oauth2Properties.AuthorizeRequestProperties;

[JsonConverter(typeof(ResponseContentTypeConverter))]
public enum ResponseContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class ResponseContentTypeConverter : JsonConverter<ResponseContentType>
{
    public override ResponseContentType Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                ResponseContentType.ApplicationXWwwFormUrlencoded,
            "application/json" => ResponseContentType.ApplicationJson,
            _ => (ResponseContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        ResponseContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                ResponseContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                ResponseContentType.ApplicationJson => "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
