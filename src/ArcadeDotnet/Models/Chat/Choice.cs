using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Chat;

[JsonConverter(typeof(ModelConverter<Choice, ChoiceFromRaw>))]
public sealed record class Choice : ModelBase
{
    public string? FinishReason
    {
        get
        {
            if (!this._rawData.TryGetValue("finish_reason", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["finish_reason"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public long? Index
    {
        get
        {
            if (!this._rawData.TryGetValue("index", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["index"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public JsonElement? Logprobs
    {
        get
        {
            if (!this._rawData.TryGetValue("logprobs", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<JsonElement?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["logprobs"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public ChatMessage? Message
    {
        get
        {
            if (!this._rawData.TryGetValue("message", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ChatMessage?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["message"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public IReadOnlyList<AuthorizationResponse>? ToolAuthorizations
    {
        get
        {
            if (!this._rawData.TryGetValue("tool_authorizations", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<List<AuthorizationResponse>?>(
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

            this._rawData["tool_authorizations"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public IReadOnlyList<ChatMessage>? ToolMessages
    {
        get
        {
            if (!this._rawData.TryGetValue("tool_messages", out JsonElement element))
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

            this._rawData["tool_messages"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.FinishReason;
        _ = this.Index;
        _ = this.Logprobs;
        this.Message?.Validate();
        foreach (var item in this.ToolAuthorizations ?? [])
        {
            item.Validate();
        }
        foreach (var item in this.ToolMessages ?? [])
        {
            item.Validate();
        }
    }

    public Choice() { }

    public Choice(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Choice(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    public static Choice FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ChoiceFromRaw : IFromRaw<Choice>
{
    public Choice FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Choice.FromRawUnchecked(rawData);
}
