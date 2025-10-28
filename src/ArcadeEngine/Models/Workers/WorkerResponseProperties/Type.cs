using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeEngine.Exceptions;
using System = System;

namespace ArcadeEngine.Models.Workers.WorkerResponseProperties;

[JsonConverter(typeof(TypeConverter))]
public enum Type
{
    HTTP,
    Mcp,
    Unknown,
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
            "http" => WorkerResponseProperties.Type.HTTP,
            "mcp" => WorkerResponseProperties.Type.Mcp,
            "unknown" => WorkerResponseProperties.Type.Unknown,
            _ => (Type)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, Type value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                WorkerResponseProperties.Type.HTTP => "http",
                WorkerResponseProperties.Type.Mcp => "mcp",
                WorkerResponseProperties.Type.Unknown => "unknown",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
