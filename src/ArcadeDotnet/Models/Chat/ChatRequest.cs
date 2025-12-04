using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using System = System;

namespace ArcadeDotnet.Models.Chat;

[JsonConverter(typeof(ModelConverter<ChatRequest, ChatRequestFromRaw>))]
public sealed record class ChatRequest : ModelBase
{
    public double? FrequencyPenalty
    {
        get { return ModelBase.GetNullableStruct<double>(this.RawData, "frequency_penalty"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "frequency_penalty", value);
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
            return ModelBase.GetNullableClass<Dictionary<string, long>>(this.RawData, "logit_bias");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "logit_bias", value);
        }
    }

    /// <summary>
    /// LogProbs indicates whether to return log probabilities of the output tokens
    /// or not. If true, returns the log probabilities of each output token returned
    /// in the content of message. This option is currently not available on the gpt-4-vision-preview model.
    /// </summary>
    public bool? Logprobs
    {
        get { return ModelBase.GetNullableStruct<bool>(this.RawData, "logprobs"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "logprobs", value);
        }
    }

    public long? MaxTokens
    {
        get { return ModelBase.GetNullableStruct<long>(this.RawData, "max_tokens"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "max_tokens", value);
        }
    }

    public IReadOnlyList<ChatMessage>? Messages
    {
        get { return ModelBase.GetNullableClass<List<ChatMessage>>(this.RawData, "messages"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "messages", value);
        }
    }

    public string? Model
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "model"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "model", value);
        }
    }

    public long? N
    {
        get { return ModelBase.GetNullableStruct<long>(this.RawData, "n"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "n", value);
        }
    }

    /// <summary>
    /// Disable the default behavior of parallel tool calls by setting it: false.
    /// </summary>
    public bool? ParallelToolCalls
    {
        get { return ModelBase.GetNullableStruct<bool>(this.RawData, "parallel_tool_calls"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "parallel_tool_calls", value);
        }
    }

    public double? PresencePenalty
    {
        get { return ModelBase.GetNullableStruct<double>(this.RawData, "presence_penalty"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "presence_penalty", value);
        }
    }

    public ResponseFormat? ResponseFormat
    {
        get { return ModelBase.GetNullableClass<ResponseFormat>(this.RawData, "response_format"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "response_format", value);
        }
    }

    public long? Seed
    {
        get { return ModelBase.GetNullableStruct<long>(this.RawData, "seed"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "seed", value);
        }
    }

    public IReadOnlyList<string>? Stop
    {
        get { return ModelBase.GetNullableClass<List<string>>(this.RawData, "stop"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "stop", value);
        }
    }

    public bool? Stream
    {
        get { return ModelBase.GetNullableStruct<bool>(this.RawData, "stream"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "stream", value);
        }
    }

    /// <summary>
    /// Options for streaming response. Only set this when you set stream: true.
    /// </summary>
    public StreamOptions? StreamOptions
    {
        get { return ModelBase.GetNullableClass<StreamOptions>(this.RawData, "stream_options"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "stream_options", value);
        }
    }

    public double? Temperature
    {
        get { return ModelBase.GetNullableStruct<double>(this.RawData, "temperature"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "temperature", value);
        }
    }

    /// <summary>
    /// This can be either a string or an ToolChoice object.
    /// </summary>
    public JsonElement? ToolChoice
    {
        get { return ModelBase.GetNullableStruct<JsonElement>(this.RawData, "tool_choice"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "tool_choice", value);
        }
    }

    public JsonElement? Tools
    {
        get { return ModelBase.GetNullableStruct<JsonElement>(this.RawData, "tools"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "tools", value);
        }
    }

    /// <summary>
    /// TopLogProbs is an integer between 0 and 5 specifying the number of most likely
    /// tokens to return at each token position, each with an associated log probability.
    /// logprobs must be set to true if this parameter is used.
    /// </summary>
    public long? TopLogprobs
    {
        get { return ModelBase.GetNullableStruct<long>(this.RawData, "top_logprobs"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "top_logprobs", value);
        }
    }

    public double? TopP
    {
        get { return ModelBase.GetNullableStruct<double>(this.RawData, "top_p"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "top_p", value);
        }
    }

    public string? User
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "user"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "user", value);
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ChatRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ChatRequestFromRaw.FromRawUnchecked"/>
    public static ChatRequest FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ChatRequestFromRaw : IFromRaw<ChatRequest>
{
    /// <inheritdoc/>
    public ChatRequest FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        ChatRequest.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ModelConverter<ResponseFormat, ResponseFormatFromRaw>))]
public sealed record class ResponseFormat : ModelBase
{
    public ApiEnum<string, ResponseFormatType>? Type
    {
        get
        {
            return ModelBase.GetNullableClass<ApiEnum<string, ResponseFormatType>>(
                this.RawData,
                "type"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "type", value);
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ResponseFormat(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ResponseFormatFromRaw.FromRawUnchecked"/>
    public static ResponseFormat FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ResponseFormatFromRaw : IFromRaw<ResponseFormat>
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
[JsonConverter(typeof(ModelConverter<StreamOptions, StreamOptionsFromRaw>))]
public sealed record class StreamOptions : ModelBase
{
    /// <summary>
    /// If set, an additional chunk will be streamed before the data: [DONE] message.
    /// The usage field on this chunk shows the token usage statistics for the entire
    /// request, and the choices field will always be an empty array. All other chunks
    /// will also include a usage field, but with a null value.
    /// </summary>
    public bool? IncludeUsage
    {
        get { return ModelBase.GetNullableStruct<bool>(this.RawData, "include_usage"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "include_usage", value);
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    StreamOptions(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="StreamOptionsFromRaw.FromRawUnchecked"/>
    public static StreamOptions FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class StreamOptionsFromRaw : IFromRaw<StreamOptions>
{
    /// <inheritdoc/>
    public StreamOptions FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        StreamOptions.FromRawUnchecked(rawData);
}
