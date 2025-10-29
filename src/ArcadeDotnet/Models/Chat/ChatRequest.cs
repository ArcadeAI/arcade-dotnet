using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Chat.ChatRequestProperties;

namespace ArcadeDotnet.Models.Chat;

[JsonConverter(typeof(ModelConverter<ChatRequest>))]
public sealed record class ChatRequest : ModelBase, IFromRaw<ChatRequest>
{
    public double? FrequencyPenalty
    {
        get
        {
            if (!this.Properties.TryGetValue("frequency_penalty", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<double?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["frequency_penalty"] = JsonSerializer.SerializeToElement(
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
            if (!this.Properties.TryGetValue("logit_bias", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Dictionary<string, long>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["logit_bias"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    /// <summary>
    /// LogProbs indicates whether to return log probabilities of the output tokens
    /// or not. If true, returns the log probabilities of each output token returned
    /// in the content of message. This option is currently not available on the
    /// gpt-4-vision-preview model.
    /// </summary>
    public bool? Logprobs
    {
        get
        {
            if (!this.Properties.TryGetValue("logprobs", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["logprobs"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public long? MaxTokens
    {
        get
        {
            if (!this.Properties.TryGetValue("max_tokens", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["max_tokens"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public List<ChatMessage>? Messages
    {
        get
        {
            if (!this.Properties.TryGetValue("messages", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<List<ChatMessage>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["messages"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Model
    {
        get
        {
            if (!this.Properties.TryGetValue("model", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["model"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public long? N
    {
        get
        {
            if (!this.Properties.TryGetValue("n", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["n"] = JsonSerializer.SerializeToElement(
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
            if (!this.Properties.TryGetValue("parallel_tool_calls", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["parallel_tool_calls"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public double? PresencePenalty
    {
        get
        {
            if (!this.Properties.TryGetValue("presence_penalty", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<double?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["presence_penalty"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public ResponseFormat? ResponseFormat
    {
        get
        {
            if (!this.Properties.TryGetValue("response_format", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ResponseFormat?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["response_format"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public long? Seed
    {
        get
        {
            if (!this.Properties.TryGetValue("seed", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["seed"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public List<string>? Stop
    {
        get
        {
            if (!this.Properties.TryGetValue("stop", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<List<string>?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["stop"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public bool? Stream
    {
        get
        {
            if (!this.Properties.TryGetValue("stream", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["stream"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    /// <summary>
    /// Options for streaming response. Only set this when you set stream: true.
    /// </summary>
    public StreamOptions? StreamOptions
    {
        get
        {
            if (!this.Properties.TryGetValue("stream_options", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<StreamOptions?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["stream_options"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public double? Temperature
    {
        get
        {
            if (!this.Properties.TryGetValue("temperature", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<double?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["temperature"] = JsonSerializer.SerializeToElement(
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
            if (!this.Properties.TryGetValue("tool_choice", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<JsonElement?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["tool_choice"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public JsonElement? Tools
    {
        get
        {
            if (!this.Properties.TryGetValue("tools", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<JsonElement?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["tools"] = JsonSerializer.SerializeToElement(
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
            if (!this.Properties.TryGetValue("top_logprobs", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["top_logprobs"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public double? TopP
    {
        get
        {
            if (!this.Properties.TryGetValue("top_p", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<double?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["top_p"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? User
    {
        get
        {
            if (!this.Properties.TryGetValue("user", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["user"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.FrequencyPenalty;
        if (this.LogitBias != null)
        {
            foreach (var item in this.LogitBias.Values)
            {
                _ = item;
            }
        }
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
        foreach (var item in this.Stop ?? [])
        {
            _ = item;
        }
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

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ChatRequest(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static ChatRequest FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
