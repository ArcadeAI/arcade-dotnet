using System.Collections.Frozen;
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
            if (!this._properties.TryGetValue("id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? FinishedAt
    {
        get
        {
            if (!this._properties.TryGetValue("finished_at", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["finished_at"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public ToolExecutionAttemptOutput? Output
    {
        get
        {
            if (!this._properties.TryGetValue("output", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ToolExecutionAttemptOutput?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["output"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? StartedAt
    {
        get
        {
            if (!this._properties.TryGetValue("started_at", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["started_at"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public bool? Success
    {
        get
        {
            if (!this._properties.TryGetValue("success", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["success"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? SystemErrorMessage
    {
        get
        {
            if (!this._properties.TryGetValue("system_error_message", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["system_error_message"] = JsonSerializer.SerializeToElement(
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

    public ToolExecutionAttempt(IReadOnlyDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ToolExecutionAttempt(FrozenDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static ToolExecutionAttempt FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }
}

[JsonConverter(typeof(ModelConverter<ToolExecutionAttemptOutput>))]
public sealed record class ToolExecutionAttemptOutput
    : ModelBase,
        IFromRaw<ToolExecutionAttemptOutput>
{
    public AuthorizationResponse? Authorization
    {
        get
        {
            if (!this._properties.TryGetValue("authorization", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<AuthorizationResponse?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["authorization"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public ToolExecutionAttemptOutputError? Error
    {
        get
        {
            if (!this._properties.TryGetValue("error", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ToolExecutionAttemptOutputError?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["error"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public List<LogModel>? Logs
    {
        get
        {
            if (!this._properties.TryGetValue("logs", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<List<LogModel>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["logs"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public JsonElement? Value
    {
        get
        {
            if (!this._properties.TryGetValue("value", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<JsonElement?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["value"] = JsonSerializer.SerializeToElement(
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

    public ToolExecutionAttemptOutput() { }

    public ToolExecutionAttemptOutput(IReadOnlyDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ToolExecutionAttemptOutput(FrozenDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static ToolExecutionAttemptOutput FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }
}

[JsonConverter(typeof(ModelConverter<ToolExecutionAttemptOutputError>))]
public sealed record class ToolExecutionAttemptOutputError
    : ModelBase,
        IFromRaw<ToolExecutionAttemptOutputError>
{
    public required bool CanRetry
    {
        get
        {
            if (!this._properties.TryGetValue("can_retry", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'can_retry' cannot be null",
                    new System::ArgumentOutOfRangeException(
                        "can_retry",
                        "Missing required argument"
                    )
                );

            return JsonSerializer.Deserialize<bool>(element, ModelBase.SerializerOptions);
        }
        init
        {
            this._properties["can_retry"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required ApiEnum<string, ToolExecutionAttemptOutputErrorKind> Kind
    {
        get
        {
            if (!this._properties.TryGetValue("kind", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'kind' cannot be null",
                    new System::ArgumentOutOfRangeException("kind", "Missing required argument")
                );

            return JsonSerializer.Deserialize<ApiEnum<string, ToolExecutionAttemptOutputErrorKind>>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            this._properties["kind"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required string Message
    {
        get
        {
            if (!this._properties.TryGetValue("message", out JsonElement element))
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
        init
        {
            this._properties["message"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? AdditionalPromptContent
    {
        get
        {
            if (!this._properties.TryGetValue("additional_prompt_content", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["additional_prompt_content"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? DeveloperMessage
    {
        get
        {
            if (!this._properties.TryGetValue("developer_message", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["developer_message"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Dictionary<string, JsonElement>? Extra
    {
        get
        {
            if (!this._properties.TryGetValue("extra", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Dictionary<string, JsonElement>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["extra"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public long? RetryAfterMs
    {
        get
        {
            if (!this._properties.TryGetValue("retry_after_ms", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["retry_after_ms"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Stacktrace
    {
        get
        {
            if (!this._properties.TryGetValue("stacktrace", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["stacktrace"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public long? StatusCode
    {
        get
        {
            if (!this._properties.TryGetValue("status_code", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["status_code"] = JsonSerializer.SerializeToElement(
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

    public ToolExecutionAttemptOutputError() { }

    public ToolExecutionAttemptOutputError(IReadOnlyDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ToolExecutionAttemptOutputError(FrozenDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static ToolExecutionAttemptOutputError FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }
}

[JsonConverter(typeof(ToolExecutionAttemptOutputErrorKindConverter))]
public enum ToolExecutionAttemptOutputErrorKind
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

sealed class ToolExecutionAttemptOutputErrorKindConverter
    : JsonConverter<ToolExecutionAttemptOutputErrorKind>
{
    public override ToolExecutionAttemptOutputErrorKind Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "TOOLKIT_LOAD_FAILED" => ToolExecutionAttemptOutputErrorKind.ToolkitLoadFailed,
            "TOOL_DEFINITION_BAD_DEFINITION" =>
                ToolExecutionAttemptOutputErrorKind.ToolDefinitionBadDefinition,
            "TOOL_DEFINITION_BAD_INPUT_SCHEMA" =>
                ToolExecutionAttemptOutputErrorKind.ToolDefinitionBadInputSchema,
            "TOOL_DEFINITION_BAD_OUTPUT_SCHEMA" =>
                ToolExecutionAttemptOutputErrorKind.ToolDefinitionBadOutputSchema,
            "TOOL_REQUIREMENTS_NOT_MET" =>
                ToolExecutionAttemptOutputErrorKind.ToolRequirementsNotMet,
            "TOOL_RUNTIME_BAD_INPUT_VALUE" =>
                ToolExecutionAttemptOutputErrorKind.ToolRuntimeBadInputValue,
            "TOOL_RUNTIME_BAD_OUTPUT_VALUE" =>
                ToolExecutionAttemptOutputErrorKind.ToolRuntimeBadOutputValue,
            "TOOL_RUNTIME_RETRY" => ToolExecutionAttemptOutputErrorKind.ToolRuntimeRetry,
            "TOOL_RUNTIME_CONTEXT_REQUIRED" =>
                ToolExecutionAttemptOutputErrorKind.ToolRuntimeContextRequired,
            "TOOL_RUNTIME_FATAL" => ToolExecutionAttemptOutputErrorKind.ToolRuntimeFatal,
            "UPSTREAM_RUNTIME_BAD_REQUEST" =>
                ToolExecutionAttemptOutputErrorKind.UpstreamRuntimeBadRequest,
            "UPSTREAM_RUNTIME_AUTH_ERROR" =>
                ToolExecutionAttemptOutputErrorKind.UpstreamRuntimeAuthError,
            "UPSTREAM_RUNTIME_NOT_FOUND" =>
                ToolExecutionAttemptOutputErrorKind.UpstreamRuntimeNotFound,
            "UPSTREAM_RUNTIME_VALIDATION_ERROR" =>
                ToolExecutionAttemptOutputErrorKind.UpstreamRuntimeValidationError,
            "UPSTREAM_RUNTIME_RATE_LIMIT" =>
                ToolExecutionAttemptOutputErrorKind.UpstreamRuntimeRateLimit,
            "UPSTREAM_RUNTIME_SERVER_ERROR" =>
                ToolExecutionAttemptOutputErrorKind.UpstreamRuntimeServerError,
            "UPSTREAM_RUNTIME_UNMAPPED" =>
                ToolExecutionAttemptOutputErrorKind.UpstreamRuntimeUnmapped,
            "UNKNOWN" => ToolExecutionAttemptOutputErrorKind.Unknown,
            _ => (ToolExecutionAttemptOutputErrorKind)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        ToolExecutionAttemptOutputErrorKind value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                ToolExecutionAttemptOutputErrorKind.ToolkitLoadFailed => "TOOLKIT_LOAD_FAILED",
                ToolExecutionAttemptOutputErrorKind.ToolDefinitionBadDefinition =>
                    "TOOL_DEFINITION_BAD_DEFINITION",
                ToolExecutionAttemptOutputErrorKind.ToolDefinitionBadInputSchema =>
                    "TOOL_DEFINITION_BAD_INPUT_SCHEMA",
                ToolExecutionAttemptOutputErrorKind.ToolDefinitionBadOutputSchema =>
                    "TOOL_DEFINITION_BAD_OUTPUT_SCHEMA",
                ToolExecutionAttemptOutputErrorKind.ToolRequirementsNotMet =>
                    "TOOL_REQUIREMENTS_NOT_MET",
                ToolExecutionAttemptOutputErrorKind.ToolRuntimeBadInputValue =>
                    "TOOL_RUNTIME_BAD_INPUT_VALUE",
                ToolExecutionAttemptOutputErrorKind.ToolRuntimeBadOutputValue =>
                    "TOOL_RUNTIME_BAD_OUTPUT_VALUE",
                ToolExecutionAttemptOutputErrorKind.ToolRuntimeRetry => "TOOL_RUNTIME_RETRY",
                ToolExecutionAttemptOutputErrorKind.ToolRuntimeContextRequired =>
                    "TOOL_RUNTIME_CONTEXT_REQUIRED",
                ToolExecutionAttemptOutputErrorKind.ToolRuntimeFatal => "TOOL_RUNTIME_FATAL",
                ToolExecutionAttemptOutputErrorKind.UpstreamRuntimeBadRequest =>
                    "UPSTREAM_RUNTIME_BAD_REQUEST",
                ToolExecutionAttemptOutputErrorKind.UpstreamRuntimeAuthError =>
                    "UPSTREAM_RUNTIME_AUTH_ERROR",
                ToolExecutionAttemptOutputErrorKind.UpstreamRuntimeNotFound =>
                    "UPSTREAM_RUNTIME_NOT_FOUND",
                ToolExecutionAttemptOutputErrorKind.UpstreamRuntimeValidationError =>
                    "UPSTREAM_RUNTIME_VALIDATION_ERROR",
                ToolExecutionAttemptOutputErrorKind.UpstreamRuntimeRateLimit =>
                    "UPSTREAM_RUNTIME_RATE_LIMIT",
                ToolExecutionAttemptOutputErrorKind.UpstreamRuntimeServerError =>
                    "UPSTREAM_RUNTIME_SERVER_ERROR",
                ToolExecutionAttemptOutputErrorKind.UpstreamRuntimeUnmapped =>
                    "UPSTREAM_RUNTIME_UNMAPPED",
                ToolExecutionAttemptOutputErrorKind.Unknown => "UNKNOWN",
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
            if (!this._properties.TryGetValue("level", out JsonElement element))
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
        init
        {
            this._properties["level"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required string Message
    {
        get
        {
            if (!this._properties.TryGetValue("message", out JsonElement element))
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
        init
        {
            this._properties["message"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Subtype
    {
        get
        {
            if (!this._properties.TryGetValue("subtype", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["subtype"] = JsonSerializer.SerializeToElement(
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

    public LogModel(IReadOnlyDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    LogModel(FrozenDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static LogModel FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> properties)
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }
}
