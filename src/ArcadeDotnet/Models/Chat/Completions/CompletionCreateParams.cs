using System.Collections.Frozen;
using System.Collections.Generic;
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
/// </summary>
public sealed record class CompletionCreateParams : ParamsBase
{
    readonly FreezableDictionary<string, JsonElement> _rawBodyData = [];
    public IReadOnlyDictionary<string, JsonElement> RawBodyData
    {
        get { return this._rawBodyData.Freeze(); }
    }

    public double? FrequencyPenalty
    {
        get { return JsonModel.GetNullableStruct<double>(this.RawBodyData, "frequency_penalty"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "frequency_penalty", value);
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
            return JsonModel.GetNullableClass<Dictionary<string, long>>(
                this.RawBodyData,
                "logit_bias"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "logit_bias", value);
        }
    }

    /// <summary>
    /// LogProbs indicates whether to return log probabilities of the output tokens
    /// or not. If true, returns the log probabilities of each output token returned
    /// in the content of message. This option is currently not available on the gpt-4-vision-preview model.
    /// </summary>
    public bool? Logprobs
    {
        get { return JsonModel.GetNullableStruct<bool>(this.RawBodyData, "logprobs"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "logprobs", value);
        }
    }

    public long? MaxTokens
    {
        get { return JsonModel.GetNullableStruct<long>(this.RawBodyData, "max_tokens"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "max_tokens", value);
        }
    }

    public IReadOnlyList<ChatMessage>? Messages
    {
        get { return JsonModel.GetNullableClass<List<ChatMessage>>(this.RawBodyData, "messages"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "messages", value);
        }
    }

    public string? Model
    {
        get { return JsonModel.GetNullableClass<string>(this.RawBodyData, "model"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "model", value);
        }
    }

    public long? N
    {
        get { return JsonModel.GetNullableStruct<long>(this.RawBodyData, "n"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "n", value);
        }
    }

    /// <summary>
    /// Disable the default behavior of parallel tool calls by setting it: false.
    /// </summary>
    public bool? ParallelToolCalls
    {
        get { return JsonModel.GetNullableStruct<bool>(this.RawBodyData, "parallel_tool_calls"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "parallel_tool_calls", value);
        }
    }

    public double? PresencePenalty
    {
        get { return JsonModel.GetNullableStruct<double>(this.RawBodyData, "presence_penalty"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "presence_penalty", value);
        }
    }

    public global::ArcadeDotnet.Models.Chat.Completions.ResponseFormat? ResponseFormat
    {
        get
        {
            return JsonModel.GetNullableClass<global::ArcadeDotnet.Models.Chat.Completions.ResponseFormat>(
                this.RawBodyData,
                "response_format"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "response_format", value);
        }
    }

    public long? Seed
    {
        get { return JsonModel.GetNullableStruct<long>(this.RawBodyData, "seed"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "seed", value);
        }
    }

    public IReadOnlyList<string>? Stop
    {
        get { return JsonModel.GetNullableClass<List<string>>(this.RawBodyData, "stop"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "stop", value);
        }
    }

    public bool? Stream
    {
        get { return JsonModel.GetNullableStruct<bool>(this.RawBodyData, "stream"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "stream", value);
        }
    }

    /// <summary>
    /// Options for streaming response. Only set this when you set stream: true.
    /// </summary>
    public global::ArcadeDotnet.Models.Chat.Completions.StreamOptions? StreamOptions
    {
        get
        {
            return JsonModel.GetNullableClass<global::ArcadeDotnet.Models.Chat.Completions.StreamOptions>(
                this.RawBodyData,
                "stream_options"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "stream_options", value);
        }
    }

    public double? Temperature
    {
        get { return JsonModel.GetNullableStruct<double>(this.RawBodyData, "temperature"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "temperature", value);
        }
    }

    /// <summary>
    /// This can be either a string or an ToolChoice object.
    /// </summary>
    public JsonElement? ToolChoice
    {
        get { return JsonModel.GetNullableStruct<JsonElement>(this.RawBodyData, "tool_choice"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "tool_choice", value);
        }
    }

    public JsonElement? Tools
    {
        get { return JsonModel.GetNullableStruct<JsonElement>(this.RawBodyData, "tools"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "tools", value);
        }
    }

    /// <summary>
    /// TopLogProbs is an integer between 0 and 5 specifying the number of most likely
    /// tokens to return at each token position, each with an associated log probability.
    /// logprobs must be set to true if this parameter is used.
    /// </summary>
    public long? TopLogprobs
    {
        get { return JsonModel.GetNullableStruct<long>(this.RawBodyData, "top_logprobs"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "top_logprobs", value);
        }
    }

    public double? TopP
    {
        get { return JsonModel.GetNullableStruct<double>(this.RawBodyData, "top_p"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "top_p", value);
        }
    }

    public string? User
    {
        get { return JsonModel.GetNullableClass<string>(this.RawBodyData, "user"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "user", value);
        }
    }

    public CompletionCreateParams() { }

    public CompletionCreateParams(CompletionCreateParams completionCreateParams)
        : base(completionCreateParams)
    {
        this._rawBodyData = [.. completionCreateParams._rawBodyData];
    }

    public CompletionCreateParams(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData,
        IReadOnlyDictionary<string, JsonElement> rawBodyData
    )
    {
        this._rawHeaderData = [.. rawHeaderData];
        this._rawQueryData = [.. rawQueryData];
        this._rawBodyData = [.. rawBodyData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CompletionCreateParams(
        FrozenDictionary<string, JsonElement> rawHeaderData,
        FrozenDictionary<string, JsonElement> rawQueryData,
        FrozenDictionary<string, JsonElement> rawBodyData
    )
    {
        this._rawHeaderData = [.. rawHeaderData];
        this._rawQueryData = [.. rawQueryData];
        this._rawBodyData = [.. rawBodyData];
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
            JsonSerializer.Serialize(this.RawBodyData),
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
}

[JsonConverter(
    typeof(JsonModelConverter<
        global::ArcadeDotnet.Models.Chat.Completions.ResponseFormat,
        global::ArcadeDotnet.Models.Chat.Completions.ResponseFormatFromRaw
    >)
)]
public sealed record class ResponseFormat : JsonModel
{
    public ApiEnum<string, global::ArcadeDotnet.Models.Chat.Completions.Type>? Type
    {
        get
        {
            return JsonModel.GetNullableClass<
                ApiEnum<string, global::ArcadeDotnet.Models.Chat.Completions.Type>
            >(this.RawData, "type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "type", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        this.Type?.Validate();
    }

    public ResponseFormat() { }

    public ResponseFormat(
        global::ArcadeDotnet.Models.Chat.Completions.ResponseFormat responseFormat
    )
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

    /// <inheritdoc cref="global::ArcadeDotnet.Models.Chat.Completions.ResponseFormatFromRaw.FromRawUnchecked"/>
    public static global::ArcadeDotnet.Models.Chat.Completions.ResponseFormat FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ResponseFormatFromRaw
    : IFromRawJson<global::ArcadeDotnet.Models.Chat.Completions.ResponseFormat>
{
    /// <inheritdoc/>
    public global::ArcadeDotnet.Models.Chat.Completions.ResponseFormat FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => global::ArcadeDotnet.Models.Chat.Completions.ResponseFormat.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(global::ArcadeDotnet.Models.Chat.Completions.TypeConverter))]
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
[JsonConverter(
    typeof(JsonModelConverter<
        global::ArcadeDotnet.Models.Chat.Completions.StreamOptions,
        global::ArcadeDotnet.Models.Chat.Completions.StreamOptionsFromRaw
    >)
)]
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
        get { return JsonModel.GetNullableStruct<bool>(this.RawData, "include_usage"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "include_usage", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.IncludeUsage;
    }

    public StreamOptions() { }

    public StreamOptions(global::ArcadeDotnet.Models.Chat.Completions.StreamOptions streamOptions)
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

    /// <inheritdoc cref="global::ArcadeDotnet.Models.Chat.Completions.StreamOptionsFromRaw.FromRawUnchecked"/>
    public static global::ArcadeDotnet.Models.Chat.Completions.StreamOptions FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class StreamOptionsFromRaw
    : IFromRawJson<global::ArcadeDotnet.Models.Chat.Completions.StreamOptions>
{
    /// <inheritdoc/>
    public global::ArcadeDotnet.Models.Chat.Completions.StreamOptions FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => global::ArcadeDotnet.Models.Chat.Completions.StreamOptions.FromRawUnchecked(rawData);
}
