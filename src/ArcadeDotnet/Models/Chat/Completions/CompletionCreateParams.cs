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
        get
        {
            if (!this._rawBodyData.TryGetValue("frequency_penalty", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<double?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData["frequency_penalty"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    /// <summary>
    /// LogitBias is must be a token id string (specified by their token ID in the
    /// tokenizer), not a word string. incorrect: `"logit_bias":{"You": 6}`, correct:
    /// `"logit_bias":{"1639": 6}` refs: https://platform.openai.com/docs/api-reference/chat/create#chat/create-logit_bias
    /// </summary>
    public Dictionary<string, long>? LogitBias
    {
        get
        {
            if (!this._rawBodyData.TryGetValue("logit_bias", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Dictionary<string, long>?>(
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

            this._rawBodyData["logit_bias"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
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
            if (!this._rawBodyData.TryGetValue("logprobs", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData["logprobs"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public long? MaxTokens
    {
        get
        {
            if (!this._rawBodyData.TryGetValue("max_tokens", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData["max_tokens"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public List<ChatMessage>? Messages
    {
        get
        {
            if (!this._rawBodyData.TryGetValue("messages", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<List<ChatMessage>?>(
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

            this._rawBodyData["messages"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Model
    {
        get
        {
            if (!this._rawBodyData.TryGetValue("model", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData["model"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public long? N
    {
        get
        {
            if (!this._rawBodyData.TryGetValue("n", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData["n"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    /// <summary>
    /// Disable the default behavior of parallel tool calls by setting it: false.
    /// </summary>
    public bool? ParallelToolCalls
    {
        get
        {
            if (!this._rawBodyData.TryGetValue("parallel_tool_calls", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData["parallel_tool_calls"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public double? PresencePenalty
    {
        get
        {
            if (!this._rawBodyData.TryGetValue("presence_penalty", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<double?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData["presence_penalty"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public global::ArcadeDotnet.Models.Chat.Completions.ResponseFormat? ResponseFormat
    {
        get
        {
            if (!this._rawBodyData.TryGetValue("response_format", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<global::ArcadeDotnet.Models.Chat.Completions.ResponseFormat?>(
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

            this._rawBodyData["response_format"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public long? Seed
    {
        get
        {
            if (!this._rawBodyData.TryGetValue("seed", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData["seed"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public List<string>? Stop
    {
        get
        {
            if (!this._rawBodyData.TryGetValue("stop", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<List<string>?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData["stop"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public bool? Stream
    {
        get
        {
            if (!this._rawBodyData.TryGetValue("stream", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData["stream"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    /// <summary>
    /// Options for streaming response. Only set this when you set stream: true.
    /// </summary>
    public global::ArcadeDotnet.Models.Chat.Completions.StreamOptions? StreamOptions
    {
        get
        {
            if (!this._rawBodyData.TryGetValue("stream_options", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<global::ArcadeDotnet.Models.Chat.Completions.StreamOptions?>(
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

            this._rawBodyData["stream_options"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public double? Temperature
    {
        get
        {
            if (!this._rawBodyData.TryGetValue("temperature", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<double?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData["temperature"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    /// <summary>
    /// This can be either a string or an ToolChoice object.
    /// </summary>
    public JsonElement? ToolChoice
    {
        get
        {
            if (!this._rawBodyData.TryGetValue("tool_choice", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<JsonElement?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData["tool_choice"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public JsonElement? Tools
    {
        get
        {
            if (!this._rawBodyData.TryGetValue("tools", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<JsonElement?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData["tools"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
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
            if (!this._rawBodyData.TryGetValue("top_logprobs", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData["top_logprobs"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public double? TopP
    {
        get
        {
            if (!this._rawBodyData.TryGetValue("top_p", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<double?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData["top_p"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? User
    {
        get
        {
            if (!this._rawBodyData.TryGetValue("user", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData["user"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public CompletionCreateParams() { }

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

    internal override StringContent? BodyContent()
    {
        return new(JsonSerializer.Serialize(this.RawBodyData), Encoding.UTF8, "application/json");
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
    typeof(ModelConverter<
        global::ArcadeDotnet.Models.Chat.Completions.ResponseFormat,
        global::ArcadeDotnet.Models.Chat.Completions.ResponseFormatFromRaw
    >)
)]
public sealed record class ResponseFormat : ModelBase
{
    public ApiEnum<string, global::ArcadeDotnet.Models.Chat.Completions.Type>? Type
    {
        get
        {
            if (!this._rawData.TryGetValue("type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<
                string,
                global::ArcadeDotnet.Models.Chat.Completions.Type
            >?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["type"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        this.Type?.Validate();
    }

    public ResponseFormat() { }

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

    public static global::ArcadeDotnet.Models.Chat.Completions.ResponseFormat FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ResponseFormatFromRaw : IFromRaw<global::ArcadeDotnet.Models.Chat.Completions.ResponseFormat>
{
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
    typeof(ModelConverter<
        global::ArcadeDotnet.Models.Chat.Completions.StreamOptions,
        global::ArcadeDotnet.Models.Chat.Completions.StreamOptionsFromRaw
    >)
)]
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
        get
        {
            if (!this._rawData.TryGetValue("include_usage", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["include_usage"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.IncludeUsage;
    }

    public StreamOptions() { }

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

    public static global::ArcadeDotnet.Models.Chat.Completions.StreamOptions FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class StreamOptionsFromRaw : IFromRaw<global::ArcadeDotnet.Models.Chat.Completions.StreamOptions>
{
    public global::ArcadeDotnet.Models.Chat.Completions.StreamOptions FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => global::ArcadeDotnet.Models.Chat.Completions.StreamOptions.FromRawUnchecked(rawData);
}
