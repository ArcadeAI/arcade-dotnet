using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using System = System;

namespace ArcadeDotnet.Models.Tools;

[JsonConverter(typeof(ModelConverter<ExecuteToolResponse, ExecuteToolResponseFromRaw>))]
public sealed record class ExecuteToolResponse : ModelBase
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

    public double? Duration
    {
        get
        {
            if (!this._rawData.TryGetValue("duration", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<double?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["duration"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? ExecutionID
    {
        get
        {
            if (!this._rawData.TryGetValue("execution_id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["execution_id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? ExecutionType
    {
        get
        {
            if (!this._rawData.TryGetValue("execution_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["execution_type"] = JsonSerializer.SerializeToElement(
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

    public Output? Output
    {
        get
        {
            if (!this._rawData.TryGetValue("output", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Output?>(element, ModelBase.SerializerOptions);
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

    public string? RunAt
    {
        get
        {
            if (!this._rawData.TryGetValue("run_at", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["run_at"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Status
    {
        get
        {
            if (!this._rawData.TryGetValue("status", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["status"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
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

    public static ExecuteToolResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ExecuteToolResponseFromRaw : IFromRaw<ExecuteToolResponse>
{
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

    public global::ArcadeDotnet.Models.Tools.Error? Error
    {
        get
        {
            if (!this._rawData.TryGetValue("error", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<global::ArcadeDotnet.Models.Tools.Error?>(
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

    public List<Log>? Logs
    {
        get
        {
            if (!this._rawData.TryGetValue("logs", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<List<Log>?>(element, ModelBase.SerializerOptions);
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

    public static Output FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class OutputFromRaw : IFromRaw<Output>
{
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

    public required ApiEnum<string, Kind> Kind
    {
        get
        {
            if (!this._rawData.TryGetValue("kind", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'kind' cannot be null",
                    new System::ArgumentOutOfRangeException("kind", "Missing required argument")
                );

            return JsonSerializer.Deserialize<ApiEnum<string, Kind>>(
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

    public static global::ArcadeDotnet.Models.Tools.Error FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ErrorFromRaw : IFromRaw<global::ArcadeDotnet.Models.Tools.Error>
{
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
        System::Type typeToConvert,
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

    public static Log FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class LogFromRaw : IFromRaw<Log>
{
    public Log FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Log.FromRawUnchecked(rawData);
}
