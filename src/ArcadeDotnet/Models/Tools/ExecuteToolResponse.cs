using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;

namespace ArcadeDotnet.Models.Tools;

[JsonConverter(typeof(ModelConverter<ExecuteToolResponse, ExecuteToolResponseFromRaw>))]
public sealed record class ExecuteToolResponse : ModelBase
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

    public double? Duration
    {
        get { return ModelBase.GetNullableStruct<double>(this.RawData, "duration"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "duration", value);
        }
    }

    public string? ExecutionID
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "execution_id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "execution_id", value);
        }
    }

    public string? ExecutionType
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "execution_type"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "execution_type", value);
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

    public Output? Output
    {
        get { return ModelBase.GetNullableClass<Output>(this.RawData, "output"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "output", value);
        }
    }

    public string? RunAt
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "run_at"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "run_at", value);
        }
    }

    public string? Status
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "status"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "status", value);
        }
    }

    /// <summary>
    /// Whether the request was successful. For immediately-executed requests, this
    /// will be true if the tool call succeeded. For scheduled requests, this will
    /// be true if the request was scheduled successfully.
    /// </summary>
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

    public ExecuteToolResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ExecuteToolResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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

class ExecuteToolResponseFromRaw : IFromRaw<ExecuteToolResponse>
{
    /// <inheritdoc/>
    public ExecuteToolResponse FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        ExecuteToolResponse.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ModelConverter<Output, OutputFromRaw>))]
public sealed record class Output : ModelBase
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

    public global::ArcadeDotnet.Models.Tools.Error? Error
    {
        get
        {
            return ModelBase.GetNullableClass<global::ArcadeDotnet.Models.Tools.Error>(
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

    public IReadOnlyList<Log>? Logs
    {
        get { return ModelBase.GetNullableClass<List<Log>>(this.RawData, "logs"); }
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

    public Output(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Output(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="OutputFromRaw.FromRawUnchecked"/>
    public static Output FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class OutputFromRaw : IFromRaw<Output>
{
    /// <inheritdoc/>
    public Output FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Output.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(ModelConverter<
        global::ArcadeDotnet.Models.Tools.Error,
        global::ArcadeDotnet.Models.Tools.ErrorFromRaw
    >)
)]
public sealed record class Error : ModelBase
{
    public required bool CanRetry
    {
        get { return ModelBase.GetNotNullStruct<bool>(this.RawData, "can_retry"); }
        init { ModelBase.Set(this._rawData, "can_retry", value); }
    }

    public required ApiEnum<string, Kind> Kind
    {
        get { return ModelBase.GetNotNullClass<ApiEnum<string, Kind>>(this.RawData, "kind"); }
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

    public Error(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Error(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="global::ArcadeDotnet.Models.Tools.ErrorFromRaw.FromRawUnchecked"/>
    public static global::ArcadeDotnet.Models.Tools.Error FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ErrorFromRaw : IFromRaw<global::ArcadeDotnet.Models.Tools.Error>
{
    /// <inheritdoc/>
    public global::ArcadeDotnet.Models.Tools.Error FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => global::ArcadeDotnet.Models.Tools.Error.FromRawUnchecked(rawData);
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

[JsonConverter(typeof(ModelConverter<Log, LogFromRaw>))]
public sealed record class Log : ModelBase
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

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Level;
        _ = this.Message;
        _ = this.Subtype;
    }

    public Log() { }

    public Log(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Log(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="LogFromRaw.FromRawUnchecked"/>
    public static Log FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class LogFromRaw : IFromRaw<Log>
{
    /// <inheritdoc/>
    public Log FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Log.FromRawUnchecked(rawData);
}
