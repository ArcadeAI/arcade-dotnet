using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;

namespace ArcadeDotnet.Models.Tools;

[JsonConverter(typeof(ModelConverter<ToolExecutionAttempt, ToolExecutionAttemptFromRaw>))]
public sealed record class ToolExecutionAttempt : ModelBase
{
    public string? ID
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "id", value);
        }
    }

    public string? FinishedAt
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "finished_at"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "finished_at", value);
        }
    }

    public ToolExecutionAttemptOutput? Output
    {
        get
        {
            return ModelBase.GetNullableClass<ToolExecutionAttemptOutput>(this.RawData, "output");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "output", value);
        }
    }

    public string? StartedAt
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "started_at"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "started_at", value);
        }
    }

    public bool? Success
    {
        get { return ModelBase.GetNullableStruct<bool>(this.RawData, "success"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "success", value);
        }
    }

    public string? SystemErrorMessage
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "system_error_message"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "system_error_message", value);
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
            return ModelBase.GetNullableClass<AuthorizationResponse>(this.RawData, "authorization");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "authorization", value);
        }
    }

    public ToolExecutionAttemptOutputError? Error
    {
        get
        {
            return ModelBase.GetNullableClass<ToolExecutionAttemptOutputError>(
                this.RawData,
                "error"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "error", value);
        }
    }

    public IReadOnlyList<ToolExecutionAttemptOutputLog>? Logs
    {
        get
        {
            return ModelBase.GetNullableClass<List<ToolExecutionAttemptOutputLog>>(
                this.RawData,
                "logs"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "logs", value);
        }
    }

    public JsonElement? Value
    {
        get { return ModelBase.GetNullableStruct<JsonElement>(this.RawData, "value"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "value", value);
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
        get { return ModelBase.GetNotNullStruct<bool>(this.RawData, "can_retry"); }
        init { ModelBase.Set(this._rawData, "can_retry", value); }
    }

    public required ApiEnum<string, ToolExecutionAttemptOutputErrorKind> Kind
    {
        get
        {
            return ModelBase.GetNotNullClass<ApiEnum<string, ToolExecutionAttemptOutputErrorKind>>(
                this.RawData,
                "kind"
            );
        }
        init { ModelBase.Set(this._rawData, "kind", value); }
    }

    public required string Message
    {
        get { return ModelBase.GetNotNullClass<string>(this.RawData, "message"); }
        init { ModelBase.Set(this._rawData, "message", value); }
    }

    public string? AdditionalPromptContent
    {
        get
        {
            return ModelBase.GetNullableClass<string>(this.RawData, "additional_prompt_content");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "additional_prompt_content", value);
        }
    }

    public string? DeveloperMessage
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "developer_message"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "developer_message", value);
        }
    }

    public IReadOnlyDictionary<string, JsonElement>? Extra
    {
        get
        {
            return ModelBase.GetNullableClass<Dictionary<string, JsonElement>>(
                this.RawData,
                "extra"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "extra", value);
        }
    }

    public long? RetryAfterMs
    {
        get { return ModelBase.GetNullableStruct<long>(this.RawData, "retry_after_ms"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "retry_after_ms", value);
        }
    }

    public string? Stacktrace
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "stacktrace"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "stacktrace", value);
        }
    }

    public long? StatusCode
    {
        get { return ModelBase.GetNullableStruct<long>(this.RawData, "status_code"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "status_code", value);
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
        Type typeToConvert,
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

[JsonConverter(
    typeof(ModelConverter<ToolExecutionAttemptOutputLog, ToolExecutionAttemptOutputLogFromRaw>)
)]
public sealed record class ToolExecutionAttemptOutputLog : ModelBase
{
    public required string Level
    {
        get { return ModelBase.GetNotNullClass<string>(this.RawData, "level"); }
        init { ModelBase.Set(this._rawData, "level", value); }
    }

    public required string Message
    {
        get { return ModelBase.GetNotNullClass<string>(this.RawData, "message"); }
        init { ModelBase.Set(this._rawData, "message", value); }
    }

    public string? Subtype
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "subtype"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "subtype", value);
        }
    }

    public override void Validate()
    {
        _ = this.Level;
        _ = this.Message;
        _ = this.Subtype;
    }

    public ToolExecutionAttemptOutputLog() { }

    public ToolExecutionAttemptOutputLog(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ToolExecutionAttemptOutputLog(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    public static ToolExecutionAttemptOutputLog FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ToolExecutionAttemptOutputLogFromRaw : IFromRaw<ToolExecutionAttemptOutputLog>
{
    public ToolExecutionAttemptOutputLog FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => ToolExecutionAttemptOutputLog.FromRawUnchecked(rawData);
}
