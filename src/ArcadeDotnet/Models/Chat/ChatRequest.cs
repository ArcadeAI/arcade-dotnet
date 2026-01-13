using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using System = System;

namespace ArcadeDotnet.Models.Chat;

[JsonConverter(typeof(JsonModelConverter<ChatRequest, ChatRequestFromRaw>))]
public sealed record class ChatRequest : JsonModel
{
    public double? FrequencyPenalty
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<double>("frequency_penalty");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("frequency_penalty", value);
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
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<FrozenDictionary<string, long>>("logit_bias");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<FrozenDictionary<string, long>?>(
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
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("logprobs");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("logprobs", value);
        }
    }

    public long? MaxTokens
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<long>("max_tokens");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("max_tokens", value);
        }
    }

    public IReadOnlyList<ChatMessage>? Messages
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<ChatMessage>>("messages");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<ChatMessage>?>(
                "messages",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public string? Model
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("model");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("model", value);
        }
    }

    public long? N
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<long>("n");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("n", value);
        }
    }

    /// <summary>
    /// Disable the default behavior of parallel tool calls by setting it: false.
    /// </summary>
    public bool? ParallelToolCalls
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("parallel_tool_calls");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("parallel_tool_calls", value);
        }
    }

    public double? PresencePenalty
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<double>("presence_penalty");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("presence_penalty", value);
        }
    }

    public ResponseFormat? ResponseFormat
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ResponseFormat>("response_format");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("response_format", value);
        }
    }

    public long? Seed
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<long>("seed");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("seed", value);
        }
    }

    public IReadOnlyList<string>? Stop
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>("stop");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "stop",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public bool? Stream
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("stream");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("stream", value);
        }
    }

    /// <summary>
    /// Options for streaming response. Only set this when you set stream: true.
    /// </summary>
    public StreamOptions? StreamOptions
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<StreamOptions>("stream_options");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("stream_options", value);
        }
    }

    public double? Temperature
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<double>("temperature");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("temperature", value);
        }
    }

    /// <summary>
    /// This can be either a string or an ToolChoice object.
    /// </summary>
    public JsonElement? ToolChoice
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<JsonElement>("tool_choice");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("tool_choice", value);
        }
    }

    public JsonElement? Tools
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<JsonElement>("tools");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("tools", value);
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
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<long>("top_logprobs");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("top_logprobs", value);
        }
    }

    public double? TopP
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<double>("top_p");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("top_p", value);
        }
    }

    public string? User
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("user");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("user", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.FrequencyPenalty;
        _ = this.LogitBias;
        _ = this.Logprobs;
        _ = this.MaxTokens;
        foreach (var item in this.Messages ?? [])
        {
            item.Validate();
        }
        _ = this.Model;
        _ = this.N;
        _ = this.ParallelToolCalls;
        _ = this.PresencePenalty;
        this.ResponseFormat?.Validate();
        _ = this.Seed;
        _ = this.Stop;
        _ = this.Stream;
        this.StreamOptions?.Validate();
        _ = this.Temperature;
        _ = this.ToolChoice;
        _ = this.Tools;
        _ = this.TopLogprobs;
        _ = this.TopP;
        _ = this.User;
    }

    public ChatRequest() { }

    public ChatRequest(ChatRequest chatRequest)
        : base(chatRequest) { }

    public ChatRequest(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ChatRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ChatRequestFromRaw.FromRawUnchecked"/>
    public static ChatRequest FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ChatRequestFromRaw : IFromRawJson<ChatRequest>
{
    /// <inheritdoc/>
    public ChatRequest FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        ChatRequest.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<ResponseFormat, ResponseFormatFromRaw>))]
public sealed record class ResponseFormat : JsonModel
{
    public ApiEnum<string, ResponseFormatType>? Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ApiEnum<string, ResponseFormatType>>("type");
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

    public ResponseFormat(ResponseFormat responseFormat)
        : base(responseFormat) { }

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

[JsonConverter(typeof(ResponseFormatTypeConverter))]
public enum ResponseFormatType
{
    JsonObject,
    Text,
}

sealed class ResponseFormatTypeConverter : JsonConverter<ResponseFormatType>
{
    public override ResponseFormatType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "json_object" => ResponseFormatType.JsonObject,
            "text" => ResponseFormatType.Text,
            _ => (ResponseFormatType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        ResponseFormatType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                ResponseFormatType.JsonObject => "json_object",
                ResponseFormatType.Text => "text",
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

    public StreamOptions(StreamOptions streamOptions)
        : base(streamOptions) { }

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
