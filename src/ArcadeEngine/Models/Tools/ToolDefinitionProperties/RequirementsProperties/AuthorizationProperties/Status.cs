using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeEngine.Exceptions;

namespace ArcadeEngine.Models.Tools.ToolDefinitionProperties.RequirementsProperties.AuthorizationProperties;

[JsonConverter(typeof(StatusConverter))]
public enum Status
{
    Active,
    Inactive,
}

sealed class StatusConverter : JsonConverter<Status>
{
    public override Status Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "active" => Status.Active,
            "inactive" => Status.Inactive,
            _ => (Status)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, Status value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Status.Active => "active",
                Status.Inactive => "inactive",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
