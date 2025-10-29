using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Exceptions;

namespace ArcadeDotnet.Models.Tools.ToolExecutionAttemptProperties.OutputProperties.ErrorProperties;

[JsonConverter(typeof(KindConverter))]
public enum Kind
{
    ToolkitLoadFailed,
    ToolDefinitionBadDefinition,
    ToolDefinitionBadInputSchema,
    ToolDefinitionBadOutputSchema,
    ToolRequirementsNotMet,
    ToolRuntimeBadInputValue,
    ToolRuntimeBadOutputValue,
    ToolRuntimeRetry,
    ToolRuntimeContextRequired,
    ToolRuntimeFatal,
    UpstreamRuntimeBadRequest,
    UpstreamRuntimeAuthError,
    UpstreamRuntimeNotFound,
    UpstreamRuntimeValidationError,
    UpstreamRuntimeRateLimit,
    UpstreamRuntimeServerError,
    UpstreamRuntimeUnmapped,
    Unknown,
}

sealed class KindConverter : JsonConverter<Kind>
{
    public override Kind Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "TOOLKIT_LOAD_FAILED" => Kind.ToolkitLoadFailed,
            "TOOL_DEFINITION_BAD_DEFINITION" => Kind.ToolDefinitionBadDefinition,
            "TOOL_DEFINITION_BAD_INPUT_SCHEMA" => Kind.ToolDefinitionBadInputSchema,
            "TOOL_DEFINITION_BAD_OUTPUT_SCHEMA" => Kind.ToolDefinitionBadOutputSchema,
            "TOOL_REQUIREMENTS_NOT_MET" => Kind.ToolRequirementsNotMet,
            "TOOL_RUNTIME_BAD_INPUT_VALUE" => Kind.ToolRuntimeBadInputValue,
            "TOOL_RUNTIME_BAD_OUTPUT_VALUE" => Kind.ToolRuntimeBadOutputValue,
            "TOOL_RUNTIME_RETRY" => Kind.ToolRuntimeRetry,
            "TOOL_RUNTIME_CONTEXT_REQUIRED" => Kind.ToolRuntimeContextRequired,
            "TOOL_RUNTIME_FATAL" => Kind.ToolRuntimeFatal,
            "UPSTREAM_RUNTIME_BAD_REQUEST" => Kind.UpstreamRuntimeBadRequest,
            "UPSTREAM_RUNTIME_AUTH_ERROR" => Kind.UpstreamRuntimeAuthError,
            "UPSTREAM_RUNTIME_NOT_FOUND" => Kind.UpstreamRuntimeNotFound,
            "UPSTREAM_RUNTIME_VALIDATION_ERROR" => Kind.UpstreamRuntimeValidationError,
            "UPSTREAM_RUNTIME_RATE_LIMIT" => Kind.UpstreamRuntimeRateLimit,
            "UPSTREAM_RUNTIME_SERVER_ERROR" => Kind.UpstreamRuntimeServerError,
            "UPSTREAM_RUNTIME_UNMAPPED" => Kind.UpstreamRuntimeUnmapped,
            "UNKNOWN" => Kind.Unknown,
            _ => (Kind)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, Kind value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Kind.ToolkitLoadFailed => "TOOLKIT_LOAD_FAILED",
                Kind.ToolDefinitionBadDefinition => "TOOL_DEFINITION_BAD_DEFINITION",
                Kind.ToolDefinitionBadInputSchema => "TOOL_DEFINITION_BAD_INPUT_SCHEMA",
                Kind.ToolDefinitionBadOutputSchema => "TOOL_DEFINITION_BAD_OUTPUT_SCHEMA",
                Kind.ToolRequirementsNotMet => "TOOL_REQUIREMENTS_NOT_MET",
                Kind.ToolRuntimeBadInputValue => "TOOL_RUNTIME_BAD_INPUT_VALUE",
                Kind.ToolRuntimeBadOutputValue => "TOOL_RUNTIME_BAD_OUTPUT_VALUE",
                Kind.ToolRuntimeRetry => "TOOL_RUNTIME_RETRY",
                Kind.ToolRuntimeContextRequired => "TOOL_RUNTIME_CONTEXT_REQUIRED",
                Kind.ToolRuntimeFatal => "TOOL_RUNTIME_FATAL",
                Kind.UpstreamRuntimeBadRequest => "UPSTREAM_RUNTIME_BAD_REQUEST",
                Kind.UpstreamRuntimeAuthError => "UPSTREAM_RUNTIME_AUTH_ERROR",
                Kind.UpstreamRuntimeNotFound => "UPSTREAM_RUNTIME_NOT_FOUND",
                Kind.UpstreamRuntimeValidationError => "UPSTREAM_RUNTIME_VALIDATION_ERROR",
                Kind.UpstreamRuntimeRateLimit => "UPSTREAM_RUNTIME_RATE_LIMIT",
                Kind.UpstreamRuntimeServerError => "UPSTREAM_RUNTIME_SERVER_ERROR",
                Kind.UpstreamRuntimeUnmapped => "UPSTREAM_RUNTIME_UNMAPPED",
                Kind.Unknown => "UNKNOWN",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
