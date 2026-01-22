using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using System = System;

namespace ArcadeDotnet.Models.Chat.Completions;

/// <summary>
/// Interact with language models via OpenAI's chat completions API
///
/// <para>NOTE: Do not inherit from this type outside the SDK unless you're okay with
/// breaking changes in non-major versions. We may add new methods in the future that
/// cause existing derived classes to break.</para>
/// </summary>
public record class CompletionCreateParams : ParamsBase
{
    readonly JsonDictionary _rawBodyData = new();
    public IReadOnlyDictionary<string, JsonElement> RawBodyData
    {
        get { return this._rawBodyData.Freeze(); }
    }

    public double? FrequencyPenalty
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableStruct<double>("frequency_penalty");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData.Set("frequency_penalty", value);
        }
    }

    /// <summary>
    /// LogitBias is must be a token id string (specified by their token ID in the
    /// tokenizer), not a word string. incorrect: `"logit_bias":{"You": 6}`, correct:
    /// `"logit_bias":{"1639": 6}` refs: https://platform.openai.com/docs/api-reference/chat/create#chat/create-logit_bias
    /// </summary>
    public IReadOnlyDictionary<string, long>? LogitBias
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableClass<FrozenDictionary<string, long>>("logit_bias");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData.Set<FrozenDictionary<string, long>?>(
                "logit_bias",
                value == null ? null : FrozenDictionary.ToFrozenDictionary(value)
            );
        }
    }

    /// <summary>
    /// LogProbs indicates whether to return log probabilities of the output tokens
    /// or not. If true, returns the log probabilities of each output token returned
    /// in the content of message. This option is currently not available on the gpt-4-vision-preview model.
    /// </summary>
    public bool? Logprobs
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableStruct<bool>("logprobs");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData.Set("logprobs", value);
        }
    }

    public long? MaxTokens
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableStruct<long>("max_tokens");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData.Set("max_tokens", value);
        }
    }

    public IReadOnlyList<ChatMessage>? Messages
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableStruct<ImmutableArray<ChatMessage>>("messages");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData.Set<ImmutableArray<ChatMessage>?>(
                "messages",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public string? Model
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableClass<string>("model");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData.Set("model", value);
        }
    }

    public long? N
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableStruct<long>("n");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData.Set("n", value);
        }
    }

    /// <summary>
    /// Disable the default behavior of parallel tool calls by setting it: false.
    /// </summary>
    public bool? ParallelToolCalls
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableStruct<bool>("parallel_tool_calls");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData.Set("parallel_tool_calls", value);
        }
    }

    public double? PresencePenalty
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableStruct<double>("presence_penalty");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData.Set("presence_penalty", value);
        }
    }

    public ResponseFormat? ResponseFormat
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableClass<ResponseFormat>("response_format");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData.Set("response_format", value);
        }
    }

    public long? Seed
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableStruct<long>("seed");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData.Set("seed", value);
        }
    }

    public IReadOnlyList<string>? Stop
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableStruct<ImmutableArray<string>>("stop");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData.Set<ImmutableArray<string>?>(
                "stop",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public bool? Stream
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableStruct<bool>("stream");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData.Set("stream", value);
        }
    }

    /// <summary>
    /// Options for streaming response. Only set this when you set stream: true.
    /// </summary>
    public StreamOptions? StreamOptions
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableClass<StreamOptions>("stream_options");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData.Set("stream_options", value);
        }
    }

    public double? Temperature
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableStruct<double>("temperature");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData.Set("temperature", value);
        }
    }

    /// <summary>
    /// This can be either a string or an ToolChoice object.
    /// </summary>
    public JsonElement? ToolChoice
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableStruct<JsonElement>("tool_choice");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData.Set("tool_choice", value);
        }
    }

    public JsonElement? Tools
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableStruct<JsonElement>("tools");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData.Set("tools", value);
        }
    }

    /// <summary>
    /// TopLogProbs is an integer between 0 and 5 specifying the number of most likely
    /// tokens to return at each token position, each with an associated log probability.
    /// logprobs must be set to true if this parameter is used.
    /// </summary>
    public long? TopLogprobs
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableStruct<long>("top_logprobs");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData.Set("top_logprobs", value);
        }
    }

    public double? TopP
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableStruct<double>("top_p");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData.Set("top_p", value);
        }
    }

    public string? User
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableClass<string>("user");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData.Set("user", value);
        }
    }

    public CompletionCreateParams() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public CompletionCreateParams(CompletionCreateParams completionCreateParams)
        : base(completionCreateParams)
    {
        this._rawBodyData = new(completionCreateParams._rawBodyData);
    }
#pragma warning restore CS8618

    public CompletionCreateParams(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData,
        IReadOnlyDictionary<string, JsonElement> rawBodyData
    )
    {
        this._rawHeaderData = new(rawHeaderData);
        this._rawQueryData = new(rawQueryData);
        this._rawBodyData = new(rawBodyData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CompletionCreateParams(
        FrozenDictionary<string, JsonElement> rawHeaderData,
        FrozenDictionary<string, JsonElement> rawQueryData,
        FrozenDictionary<string, JsonElement> rawBodyData
    )
    {
        this._rawHeaderData = new(rawHeaderData);
        this._rawQueryData = new(rawQueryData);
        this._rawBodyData = new(rawBodyData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="IFromRawJson.FromRawUnchecked"/>
    public static CompletionCreateParams FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData,
        IReadOnlyDictionary<string, JsonElement> rawBodyData
    )
    {
        return new(
            FrozenDictionary.ToFrozenDictionary(rawHeaderData),
            FrozenDictionary.ToFrozenDictionary(rawQueryData),
            FrozenDictionary.ToFrozenDictionary(rawBodyData)
        );
    }

    public override string ToString() =>
        JsonSerializer.Serialize(
            new Dictionary<string, object?>()
            {
                ["HeaderData"] = this._rawHeaderData.Freeze(),
                ["QueryData"] = this._rawQueryData.Freeze(),
                ["BodyData"] = this._rawBodyData.Freeze(),
            },
            ModelBase.ToStringSerializerOptions
        );

    public virtual bool Equals(CompletionCreateParams? other)
    {
        if (other == null)
        {
            return false;
        }
        return this._rawHeaderData.Equals(other._rawHeaderData)
            && this._rawQueryData.Equals(other._rawQueryData)
            && this._rawBodyData.Equals(other._rawBodyData);
    }

    public override System::Uri Url(ClientOptions options)
    {
        return new System::UriBuilder(
            options.BaseUrl.ToString().TrimEnd('/') + "/v1/chat/completions"
        )
        {
            Query = this.QueryString(options),
        }.Uri;
    }

    internal override HttpContent? BodyContent()
    {
        return new StringContent(
            JsonSerializer.Serialize(this.RawBodyData, ModelBase.SerializerOptions),
            Encoding.UTF8,
            "application/json"
        );
    }

    internal override void AddHeadersToRequest(HttpRequestMessage request, ClientOptions options)
    {
        ParamsBase.AddDefaultHeaders(request, options);
        foreach (var item in this.RawHeaderData)
        {
            ParamsBase.AddHeaderElementToRequest(request, item.Key, item.Value);
        }
    }

    public override int GetHashCode()
    {
        return 0;
    }
}

[JsonConverter(typeof(JsonModelConverter<ResponseFormat, ResponseFormatFromRaw>))]
public sealed record class ResponseFormat : JsonModel
{
    public ApiEnum<string, global::ArcadeDotnet.Models.Chat.Completions.Type>? Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, global::ArcadeDotnet.Models.Chat.Completions.Type>
            >("type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("type", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        this.Type?.Validate();
    }

    public ResponseFormat() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public ResponseFormat(ResponseFormat responseFormat)
        : base(responseFormat) { }
#pragma warning restore CS8618

    public ResponseFormat(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ResponseFormat(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ResponseFormatFromRaw.FromRawUnchecked"/>
    public static ResponseFormat FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ResponseFormatFromRaw : IFromRawJson<ResponseFormat>
{
    /// <inheritdoc/>
    public ResponseFormat FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        ResponseFormat.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(TypeConverter))]
public enum Type
{
    JsonObject,
    Text,
}

sealed class TypeConverter : JsonConverter<global::ArcadeDotnet.Models.Chat.Completions.Type>
{
    public override global::ArcadeDotnet.Models.Chat.Completions.Type Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "json_object" => global::ArcadeDotnet.Models.Chat.Completions.Type.JsonObject,
            "text" => global::ArcadeDotnet.Models.Chat.Completions.Type.Text,
            _ => (global::ArcadeDotnet.Models.Chat.Completions.Type)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        global::ArcadeDotnet.Models.Chat.Completions.Type value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                global::ArcadeDotnet.Models.Chat.Completions.Type.JsonObject => "json_object",
                global::ArcadeDotnet.Models.Chat.Completions.Type.Text => "text",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// Options for streaming response. Only set this when you set stream: true.
/// </summary>
[JsonConverter(typeof(JsonModelConverter<StreamOptions, StreamOptionsFromRaw>))]
public sealed record class StreamOptions : JsonModel
{
    /// <summary>
    /// If set, an additional chunk will be streamed before the data: [DONE] message.
    /// The usage field on this chunk shows the token usage statistics for the entire
    /// request, and the choices field will always be an empty array. All other chunks
    /// will also include a usage field, but with a null value.
    /// </summary>
    public bool? IncludeUsage
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("include_usage");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("include_usage", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.IncludeUsage;
    }

    public StreamOptions() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public StreamOptions(StreamOptions streamOptions)
        : base(streamOptions) { }
#pragma warning restore CS8618

    public StreamOptions(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    StreamOptions(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="StreamOptionsFromRaw.FromRawUnchecked"/>
    public static StreamOptions FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class StreamOptionsFromRaw : IFromRawJson<StreamOptions>
{
    /// <inheritdoc/>
    public StreamOptions FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        StreamOptions.FromRawUnchecked(rawData);
}
