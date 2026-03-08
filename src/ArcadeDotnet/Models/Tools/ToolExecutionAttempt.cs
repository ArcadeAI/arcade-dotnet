using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;

namespace ArcadeDotnet.Models.Tools;

[JsonConverter(typeof(JsonModelConverter<ToolExecutionAttempt, ToolExecutionAttemptFromRaw>))]
public sealed record class ToolExecutionAttempt : JsonModel
{
    public string? ID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("id", value);
        }
    }

    public string? FinishedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("finished_at");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("finished_at", value);
        }
    }

    public ToolExecutionAttemptOutput? Output
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ToolExecutionAttemptOutput>("output");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("output", value);
        }
    }

    public string? StartedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("started_at");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("started_at", value);
        }
    }

    public bool? Success
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("success");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("success", value);
        }
    }

    public string? SystemErrorMessage
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("system_error_message");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("system_error_message", value);
        }
    }

    /// <inheritdoc/>
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
    public ToolExecutionAttempt(ToolExecutionAttempt toolExecutionAttempt)
        : base(toolExecutionAttempt) { }
#pragma warning restore CS8618

    public ToolExecutionAttempt(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ToolExecutionAttempt(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ToolExecutionAttemptFromRaw.FromRawUnchecked"/>
    public static ToolExecutionAttempt FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ToolExecutionAttemptFromRaw : IFromRawJson<ToolExecutionAttempt>
{
    /// <inheritdoc/>
    public ToolExecutionAttempt FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => ToolExecutionAttempt.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<ToolExecutionAttemptOutput, ToolExecutionAttemptOutputFromRaw>)
)]
public sealed record class ToolExecutionAttemptOutput : JsonModel
{
    public AuthorizationResponse? Authorization
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<AuthorizationResponse>("authorization");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("authorization", value);
        }
    }

    public ToolExecutionAttemptOutputError? Error
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ToolExecutionAttemptOutputError>("error");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("error", value);
        }
    }

    public IReadOnlyList<ToolExecutionAttemptOutputLog>? Logs
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<ToolExecutionAttemptOutputLog>>(
                "logs"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<ToolExecutionAttemptOutputLog>?>(
                "logs",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public JsonElement? Value
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<JsonElement>("value");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("value", value);
        }
    }

    /// <inheritdoc/>
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

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public ToolExecutionAttemptOutput(ToolExecutionAttemptOutput toolExecutionAttemptOutput)
        : base(toolExecutionAttemptOutput) { }
#pragma warning restore CS8618

    public ToolExecutionAttemptOutput(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ToolExecutionAttemptOutput(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ToolExecutionAttemptOutputFromRaw.FromRawUnchecked"/>
    public static ToolExecutionAttemptOutput FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ToolExecutionAttemptOutputFromRaw : IFromRawJson<ToolExecutionAttemptOutput>
{
    /// <inheritdoc/>
    public ToolExecutionAttemptOutput FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => ToolExecutionAttemptOutput.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        ToolExecutionAttemptOutputError,
        ToolExecutionAttemptOutputErrorFromRaw
    >)
)]
public sealed record class ToolExecutionAttemptOutputError : JsonModel
{
    public required bool CanRetry
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<bool>("can_retry");
        }
        init { this._rawData.Set("can_retry", value); }
    }

    public required ApiEnum<string, ToolExecutionAttemptOutputErrorKind> Kind
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, ToolExecutionAttemptOutputErrorKind>
            >("kind");
        }
        init { this._rawData.Set("kind", value); }
    }

    public required string Message
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("message");
        }
        init { this._rawData.Set("message", value); }
    }

    public string? AdditionalPromptContent
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("additional_prompt_content");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("additional_prompt_content", value);
        }
    }

    public string? DeveloperMessage
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("developer_message");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("developer_message", value);
        }
    }

    public IReadOnlyDictionary<string, JsonElement>? Extra
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<FrozenDictionary<string, JsonElement>>("extra");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<FrozenDictionary<string, JsonElement>?>(
                "extra",
                value == null ? null : FrozenDictionary.ToFrozenDictionary(value)
            );
        }
    }

    public long? RetryAfterMs
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<long>("retry_after_ms");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("retry_after_ms", value);
        }
    }

    public string? Stacktrace
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("stacktrace");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("stacktrace", value);
        }
    }

    public long? StatusCode
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<long>("status_code");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("status_code", value);
        }
    }

    /// <inheritdoc/>
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

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public ToolExecutionAttemptOutputError(
        ToolExecutionAttemptOutputError toolExecutionAttemptOutputError
    )
        : base(toolExecutionAttemptOutputError) { }
#pragma warning restore CS8618

    public ToolExecutionAttemptOutputError(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ToolExecutionAttemptOutputError(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ToolExecutionAttemptOutputErrorFromRaw.FromRawUnchecked"/>
    public static ToolExecutionAttemptOutputError FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ToolExecutionAttemptOutputErrorFromRaw : IFromRawJson<ToolExecutionAttemptOutputError>
{
    /// <inheritdoc/>
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
    ContextCheckFailed,
    ContextDenied,
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
            "CONTEXT_CHECK_FAILED" => ToolExecutionAttemptOutputErrorKind.ContextCheckFailed,
            "CONTEXT_DENIED" => ToolExecutionAttemptOutputErrorKind.ContextDenied,
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
                ToolExecutionAttemptOutputErrorKind.ContextCheckFailed => "CONTEXT_CHECK_FAILED",
                ToolExecutionAttemptOutputErrorKind.ContextDenied => "CONTEXT_DENIED",
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
    typeof(JsonModelConverter<ToolExecutionAttemptOutputLog, ToolExecutionAttemptOutputLogFromRaw>)
)]
public sealed record class ToolExecutionAttemptOutputLog : JsonModel
{
    public required string Level
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("level");
        }
        init { this._rawData.Set("level", value); }
    }

    public required string Message
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("message");
        }
        init { this._rawData.Set("message", value); }
    }

    public string? Subtype
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("subtype");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("subtype", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Level;
        _ = this.Message;
        _ = this.Subtype;
    }

    public ToolExecutionAttemptOutputLog() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public ToolExecutionAttemptOutputLog(
        ToolExecutionAttemptOutputLog toolExecutionAttemptOutputLog
    )
        : base(toolExecutionAttemptOutputLog) { }
#pragma warning restore CS8618

    public ToolExecutionAttemptOutputLog(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ToolExecutionAttemptOutputLog(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ToolExecutionAttemptOutputLogFromRaw.FromRawUnchecked"/>
    public static ToolExecutionAttemptOutputLog FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ToolExecutionAttemptOutputLogFromRaw : IFromRawJson<ToolExecutionAttemptOutputLog>
{
    /// <inheritdoc/>
    public ToolExecutionAttemptOutputLog FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => ToolExecutionAttemptOutputLog.FromRawUnchecked(rawData);
}
