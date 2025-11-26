using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using System = System;

namespace ArcadeDotnet.Models.Tools;

[JsonConverter(typeof(ModelConverter<ToolExecutionAttempt, ToolExecutionAttemptFromRaw>))]
public sealed record class ToolExecutionAttempt : ModelBase
{
    public string? ID
    {
        get
        {
            if (!this._rawData.TryGetValue("id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? FinishedAt
    {
        get
        {
            if (!this._rawData.TryGetValue("finished_at", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["finished_at"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public ToolExecutionAttemptOutput? Output
    {
        get
        {
            if (!this._rawData.TryGetValue("output", out JsonElement element))
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

            this._rawData["output"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? StartedAt
    {
        get
        {
            if (!this._rawData.TryGetValue("started_at", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["started_at"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public bool? Success
    {
        get
        {
            if (!this._rawData.TryGetValue("success", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["success"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? SystemErrorMessage
    {
        get
        {
            if (!this._rawData.TryGetValue("system_error_message", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["system_error_message"] = JsonSerializer.SerializeToElement(
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

    public ToolExecutionAttempt(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ToolExecutionAttempt(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    public static ToolExecutionAttempt FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ToolExecutionAttemptFromRaw : IFromRaw<ToolExecutionAttempt>
{
    public ToolExecutionAttempt FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => ToolExecutionAttempt.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(ModelConverter<ToolExecutionAttemptOutput, ToolExecutionAttemptOutputFromRaw>)
)]
public sealed record class ToolExecutionAttemptOutput : ModelBase
{
    public AuthorizationResponse? Authorization
    {
        get
        {
            if (!this._rawData.TryGetValue("authorization", out JsonElement element))
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

            this._rawData["authorization"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public ToolExecutionAttemptOutputError? Error
    {
        get
        {
            if (!this._rawData.TryGetValue("error", out JsonElement element))
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

            this._rawData["error"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public List<LogModel>? Logs
    {
        get
        {
            if (!this._rawData.TryGetValue("logs", out JsonElement element))
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

            this._rawData["logs"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public JsonElement? Value
    {
        get
        {
            if (!this._rawData.TryGetValue("value", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<JsonElement?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["value"] = JsonSerializer.SerializeToElement(
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

    public ToolExecutionAttemptOutput(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ToolExecutionAttemptOutput(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    public static ToolExecutionAttemptOutput FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ToolExecutionAttemptOutputFromRaw : IFromRaw<ToolExecutionAttemptOutput>
{
    public ToolExecutionAttemptOutput FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => ToolExecutionAttemptOutput.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(ModelConverter<ToolExecutionAttemptOutputError, ToolExecutionAttemptOutputErrorFromRaw>)
)]
public sealed record class ToolExecutionAttemptOutputError : ModelBase
{
    public required bool CanRetry
    {
        get
        {
            if (!this._rawData.TryGetValue("can_retry", out JsonElement element))
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
            this._rawData["can_retry"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required ApiEnum<string, ToolExecutionAttemptOutputErrorKind> Kind
    {
        get
        {
            if (!this._rawData.TryGetValue("kind", out JsonElement element))
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
            this._rawData["kind"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required string Message
    {
        get
        {
            if (!this._rawData.TryGetValue("message", out JsonElement element))
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
            this._rawData["message"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? AdditionalPromptContent
    {
        get
        {
            if (!this._rawData.TryGetValue("additional_prompt_content", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["additional_prompt_content"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? DeveloperMessage
    {
        get
        {
            if (!this._rawData.TryGetValue("developer_message", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["developer_message"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Dictionary<string, JsonElement>? Extra
    {
        get
        {
            if (!this._rawData.TryGetValue("extra", out JsonElement element))
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

            this._rawData["extra"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public long? RetryAfterMs
    {
        get
        {
            if (!this._rawData.TryGetValue("retry_after_ms", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["retry_after_ms"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Stacktrace
    {
        get
        {
            if (!this._rawData.TryGetValue("stacktrace", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["stacktrace"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public long? StatusCode
    {
        get
        {
            if (!this._rawData.TryGetValue("status_code", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["status_code"] = JsonSerializer.SerializeToElement(
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

    public ToolExecutionAttemptOutputError(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ToolExecutionAttemptOutputError(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    public static ToolExecutionAttemptOutputError FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ToolExecutionAttemptOutputErrorFromRaw : IFromRaw<ToolExecutionAttemptOutputError>
{
    public ToolExecutionAttemptOutputError FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => ToolExecutionAttemptOutputError.FromRawUnchecked(rawData);
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

[JsonConverter(typeof(ModelConverter<LogModel, LogModelFromRaw>))]
public sealed record class LogModel : ModelBase
{
    public required string Level
    {
        get
        {
            if (!this._rawData.TryGetValue("level", out JsonElement element))
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
            this._rawData["level"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required string Message
    {
        get
        {
            if (!this._rawData.TryGetValue("message", out JsonElement element))
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
            this._rawData["message"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Subtype
    {
        get
        {
            if (!this._rawData.TryGetValue("subtype", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["subtype"] = JsonSerializer.SerializeToElement(
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

    public LogModel(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    LogModel(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    public static LogModel FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class LogModelFromRaw : IFromRaw<LogModel>
{
    public LogModel FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        LogModel.FromRawUnchecked(rawData);
}
