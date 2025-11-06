using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using System = System;

namespace ArcadeDotnet.Models.Tools;

[JsonConverter(typeof(ModelConverter<ToolExecutionAttempt>))]
public sealed record class ToolExecutionAttempt : ModelBase, IFromRaw<ToolExecutionAttempt>
{
    public string? ID
    {
        get
        {
            if (!this.Properties.TryGetValue("id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? FinishedAt
    {
        get
        {
            if (!this.Properties.TryGetValue("finished_at", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["finished_at"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Output1? Output
    {
        get
        {
            if (!this.Properties.TryGetValue("output", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Output1?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["output"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? StartedAt
    {
        get
        {
            if (!this.Properties.TryGetValue("started_at", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["started_at"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public bool? Success
    {
        get
        {
            if (!this.Properties.TryGetValue("success", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["success"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? SystemErrorMessage
    {
        get
        {
            if (!this.Properties.TryGetValue("system_error_message", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["system_error_message"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.ID;
        _ = this.FinishedAt;
        this.Output?.Validate();
        _ = this.StartedAt;
        _ = this.Success;
        _ = this.SystemErrorMessage;
    }

    public ToolExecutionAttempt() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ToolExecutionAttempt(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static ToolExecutionAttempt FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}

[JsonConverter(typeof(ModelConverter<Output1>))]
public sealed record class Output1 : ModelBase, IFromRaw<Output1>
{
    public AuthorizationResponse? Authorization
    {
        get
        {
            if (!this.Properties.TryGetValue("authorization", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<AuthorizationResponse?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["authorization"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public ErrorModel? Error
    {
        get
        {
            if (!this.Properties.TryGetValue("error", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ErrorModel?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["error"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public List<LogModel>? Logs
    {
        get
        {
            if (!this.Properties.TryGetValue("logs", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<List<LogModel>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["logs"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public JsonElement? Value
    {
        get
        {
            if (!this.Properties.TryGetValue("value", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<JsonElement?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["value"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        this.Authorization?.Validate();
        this.Error?.Validate();
        foreach (var item in this.Logs ?? [])
        {
            item.Validate();
        }
        _ = this.Value;
    }

    public Output1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Output1(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static Output1 FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}

[JsonConverter(typeof(ModelConverter<ErrorModel>))]
public sealed record class ErrorModel : ModelBase, IFromRaw<ErrorModel>
{
    public required bool CanRetry
    {
        get
        {
            if (!this.Properties.TryGetValue("can_retry", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'can_retry' cannot be null",
                    new System::ArgumentOutOfRangeException(
                        "can_retry",
                        "Missing required argument"
                    )
                );

            return JsonSerializer.Deserialize<bool>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["can_retry"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required ApiEnum<string, KindModel> Kind
    {
        get
        {
            if (!this.Properties.TryGetValue("kind", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'kind' cannot be null",
                    new System::ArgumentOutOfRangeException("kind", "Missing required argument")
                );

            return JsonSerializer.Deserialize<ApiEnum<string, KindModel>>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["kind"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required string Message
    {
        get
        {
            if (!this.Properties.TryGetValue("message", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'message' cannot be null",
                    new System::ArgumentOutOfRangeException("message", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'message' cannot be null",
                    new System::ArgumentNullException("message")
                );
        }
        set
        {
            this.Properties["message"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? AdditionalPromptContent
    {
        get
        {
            if (!this.Properties.TryGetValue("additional_prompt_content", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["additional_prompt_content"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? DeveloperMessage
    {
        get
        {
            if (!this.Properties.TryGetValue("developer_message", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["developer_message"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Dictionary<string, JsonElement>? Extra
    {
        get
        {
            if (!this.Properties.TryGetValue("extra", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Dictionary<string, JsonElement>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["extra"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public long? RetryAfterMs
    {
        get
        {
            if (!this.Properties.TryGetValue("retry_after_ms", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["retry_after_ms"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Stacktrace
    {
        get
        {
            if (!this.Properties.TryGetValue("stacktrace", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["stacktrace"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public long? StatusCode
    {
        get
        {
            if (!this.Properties.TryGetValue("status_code", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["status_code"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.CanRetry;
        this.Kind.Validate();
        _ = this.Message;
        _ = this.AdditionalPromptContent;
        _ = this.DeveloperMessage;
        _ = this.Extra;
        _ = this.RetryAfterMs;
        _ = this.Stacktrace;
        _ = this.StatusCode;
    }

    public ErrorModel() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ErrorModel(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static ErrorModel FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}

[JsonConverter(typeof(KindModelConverter))]
public enum KindModel
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

sealed class KindModelConverter : JsonConverter<KindModel>
{
    public override KindModel Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "TOOLKIT_LOAD_FAILED" => KindModel.ToolkitLoadFailed,
            "TOOL_DEFINITION_BAD_DEFINITION" => KindModel.ToolDefinitionBadDefinition,
            "TOOL_DEFINITION_BAD_INPUT_SCHEMA" => KindModel.ToolDefinitionBadInputSchema,
            "TOOL_DEFINITION_BAD_OUTPUT_SCHEMA" => KindModel.ToolDefinitionBadOutputSchema,
            "TOOL_REQUIREMENTS_NOT_MET" => KindModel.ToolRequirementsNotMet,
            "TOOL_RUNTIME_BAD_INPUT_VALUE" => KindModel.ToolRuntimeBadInputValue,
            "TOOL_RUNTIME_BAD_OUTPUT_VALUE" => KindModel.ToolRuntimeBadOutputValue,
            "TOOL_RUNTIME_RETRY" => KindModel.ToolRuntimeRetry,
            "TOOL_RUNTIME_CONTEXT_REQUIRED" => KindModel.ToolRuntimeContextRequired,
            "TOOL_RUNTIME_FATAL" => KindModel.ToolRuntimeFatal,
            "UPSTREAM_RUNTIME_BAD_REQUEST" => KindModel.UpstreamRuntimeBadRequest,
            "UPSTREAM_RUNTIME_AUTH_ERROR" => KindModel.UpstreamRuntimeAuthError,
            "UPSTREAM_RUNTIME_NOT_FOUND" => KindModel.UpstreamRuntimeNotFound,
            "UPSTREAM_RUNTIME_VALIDATION_ERROR" => KindModel.UpstreamRuntimeValidationError,
            "UPSTREAM_RUNTIME_RATE_LIMIT" => KindModel.UpstreamRuntimeRateLimit,
            "UPSTREAM_RUNTIME_SERVER_ERROR" => KindModel.UpstreamRuntimeServerError,
            "UPSTREAM_RUNTIME_UNMAPPED" => KindModel.UpstreamRuntimeUnmapped,
            "UNKNOWN" => KindModel.Unknown,
            _ => (KindModel)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        KindModel value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                KindModel.ToolkitLoadFailed => "TOOLKIT_LOAD_FAILED",
                KindModel.ToolDefinitionBadDefinition => "TOOL_DEFINITION_BAD_DEFINITION",
                KindModel.ToolDefinitionBadInputSchema => "TOOL_DEFINITION_BAD_INPUT_SCHEMA",
                KindModel.ToolDefinitionBadOutputSchema => "TOOL_DEFINITION_BAD_OUTPUT_SCHEMA",
                KindModel.ToolRequirementsNotMet => "TOOL_REQUIREMENTS_NOT_MET",
                KindModel.ToolRuntimeBadInputValue => "TOOL_RUNTIME_BAD_INPUT_VALUE",
                KindModel.ToolRuntimeBadOutputValue => "TOOL_RUNTIME_BAD_OUTPUT_VALUE",
                KindModel.ToolRuntimeRetry => "TOOL_RUNTIME_RETRY",
                KindModel.ToolRuntimeContextRequired => "TOOL_RUNTIME_CONTEXT_REQUIRED",
                KindModel.ToolRuntimeFatal => "TOOL_RUNTIME_FATAL",
                KindModel.UpstreamRuntimeBadRequest => "UPSTREAM_RUNTIME_BAD_REQUEST",
                KindModel.UpstreamRuntimeAuthError => "UPSTREAM_RUNTIME_AUTH_ERROR",
                KindModel.UpstreamRuntimeNotFound => "UPSTREAM_RUNTIME_NOT_FOUND",
                KindModel.UpstreamRuntimeValidationError => "UPSTREAM_RUNTIME_VALIDATION_ERROR",
                KindModel.UpstreamRuntimeRateLimit => "UPSTREAM_RUNTIME_RATE_LIMIT",
                KindModel.UpstreamRuntimeServerError => "UPSTREAM_RUNTIME_SERVER_ERROR",
                KindModel.UpstreamRuntimeUnmapped => "UPSTREAM_RUNTIME_UNMAPPED",
                KindModel.Unknown => "UNKNOWN",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(ModelConverter<LogModel>))]
public sealed record class LogModel : ModelBase, IFromRaw<LogModel>
{
    public required string Level
    {
        get
        {
            if (!this.Properties.TryGetValue("level", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'level' cannot be null",
                    new System::ArgumentOutOfRangeException("level", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'level' cannot be null",
                    new System::ArgumentNullException("level")
                );
        }
        set
        {
            this.Properties["level"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required string Message
    {
        get
        {
            if (!this.Properties.TryGetValue("message", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'message' cannot be null",
                    new System::ArgumentOutOfRangeException("message", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'message' cannot be null",
                    new System::ArgumentNullException("message")
                );
        }
        set
        {
            this.Properties["message"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Subtype
    {
        get
        {
            if (!this.Properties.TryGetValue("subtype", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["subtype"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.Level;
        _ = this.Message;
        _ = this.Subtype;
    }

    public LogModel() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    LogModel(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static LogModel FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
