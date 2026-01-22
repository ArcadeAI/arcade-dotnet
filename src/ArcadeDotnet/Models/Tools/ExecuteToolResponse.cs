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

[JsonConverter(typeof(JsonModelConverter<ExecuteToolResponse, ExecuteToolResponseFromRaw>))]
public sealed record class ExecuteToolResponse : JsonModel
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

    public double? Duration
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<double>("duration");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("duration", value);
        }
    }

    public string? ExecutionID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("execution_id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("execution_id", value);
        }
    }

    public string? ExecutionType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("execution_type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("execution_type", value);
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

    public Output? Output
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<Output>("output");
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

    public string? RunAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("run_at");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("run_at", value);
        }
    }

    public string? Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("status");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("status", value);
        }
    }

    /// <summary>
    /// Whether the request was successful. For immediately-executed requests, this
    /// will be true if the tool call succeeded. For scheduled requests, this will
    /// be true if the request was scheduled successfully.
    /// </summary>
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

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.Duration;
        _ = this.ExecutionID;
        _ = this.ExecutionType;
        _ = this.FinishedAt;
        this.Output?.Validate();
        _ = this.RunAt;
        _ = this.Status;
        _ = this.Success;
    }

    public ExecuteToolResponse() { }

    public ExecuteToolResponse(ExecuteToolResponse executeToolResponse)
        : base(executeToolResponse) { }

    public ExecuteToolResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ExecuteToolResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ExecuteToolResponseFromRaw.FromRawUnchecked"/>
    public static ExecuteToolResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ExecuteToolResponseFromRaw : IFromRawJson<ExecuteToolResponse>
{
    /// <inheritdoc/>
    public ExecuteToolResponse FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        ExecuteToolResponse.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Output, OutputFromRaw>))]
public sealed record class Output : JsonModel
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

    public Error? Error
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<Error>("error");
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

    public IReadOnlyList<Log>? Logs
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<Log>>("logs");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<Log>?>(
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

    public Output() { }

    public Output(Output output)
        : base(output) { }

    public Output(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Output(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="OutputFromRaw.FromRawUnchecked"/>
    public static Output FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class OutputFromRaw : IFromRawJson<Output>
{
    /// <inheritdoc/>
    public Output FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Output.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Error, ErrorFromRaw>))]
public sealed record class Error : JsonModel
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

    public required ApiEnum<string, Kind> Kind
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, Kind>>("kind");
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

    public Error() { }

    public Error(Error error)
        : base(error) { }

    public Error(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Error(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ErrorFromRaw.FromRawUnchecked"/>
    public static Error FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ErrorFromRaw : IFromRawJson<Error>
{
    /// <inheritdoc/>
    public Error FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Error.FromRawUnchecked(rawData);
}

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
            "CONTEXT_CHECK_FAILED" => Kind.ContextCheckFailed,
            "CONTEXT_DENIED" => Kind.ContextDenied,
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
                Kind.ContextCheckFailed => "CONTEXT_CHECK_FAILED",
                Kind.ContextDenied => "CONTEXT_DENIED",
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

[JsonConverter(typeof(JsonModelConverter<Log, LogFromRaw>))]
public sealed record class Log : JsonModel
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

    public Log() { }

    public Log(Log log)
        : base(log) { }

    public Log(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Log(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="LogFromRaw.FromRawUnchecked"/>
    public static Log FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class LogFromRaw : IFromRawJson<Log>
{
    /// <inheritdoc/>
    public Log FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Log.FromRawUnchecked(rawData);
}
