using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Exceptions;

namespace ArcadeDotnet.Models.Tools.ToolDefinitionProperties.RequirementsProperties.AuthorizationProperties;

[JsonConverter(typeof(TokenStatusConverter))]
public enum TokenStatus
{
    NotStarted,
    Pending,
    Completed,
    Failed,
}

sealed class TokenStatusConverter : JsonConverter<TokenStatus>
{
    public override TokenStatus Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "not_started" => TokenStatus.NotStarted,
            "pending" => TokenStatus.Pending,
            "completed" => TokenStatus.Completed,
            "failed" => TokenStatus.Failed,
            _ => (TokenStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        TokenStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                TokenStatus.NotStarted => "not_started",
                TokenStatus.Pending => "pending",
                TokenStatus.Completed => "completed",
                TokenStatus.Failed => "failed",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
