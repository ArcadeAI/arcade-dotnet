using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeEngine.Exceptions;
using System = System;

namespace ArcadeEngine.Models.Chat.ChatRequestProperties.ResponseFormatProperties;

[JsonConverter(typeof(TypeConverter))]
public enum Type
{
    JsonObject,
    Text,
}

sealed class TypeConverter : JsonConverter<Type>
{
    public override Type Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "json_object" => ResponseFormatProperties.Type.JsonObject,
            "text" => ResponseFormatProperties.Type.Text,
            _ => (Type)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, Type value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                ResponseFormatProperties.Type.JsonObject => "json_object",
                ResponseFormatProperties.Type.Text => "text",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
