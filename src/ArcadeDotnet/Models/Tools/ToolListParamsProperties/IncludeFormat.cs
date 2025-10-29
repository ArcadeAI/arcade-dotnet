using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Exceptions;

namespace ArcadeDotnet.Models.Tools.ToolListParamsProperties;

[JsonConverter(typeof(IncludeFormatConverter))]
public enum IncludeFormat
{
    Arcade,
    OpenAI,
    Anthropic,
}

sealed class IncludeFormatConverter : JsonConverter<IncludeFormat>
{
    public override IncludeFormat Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "arcade" => IncludeFormat.Arcade,
            "openai" => IncludeFormat.OpenAI,
            "anthropic" => IncludeFormat.Anthropic,
            _ => (IncludeFormat)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        IncludeFormat value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                IncludeFormat.Arcade => "arcade",
                IncludeFormat.OpenAI => "openai",
                IncludeFormat.Anthropic => "anthropic",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
