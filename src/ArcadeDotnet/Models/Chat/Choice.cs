using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Chat;

[JsonConverter(typeof(ModelConverter<Choice>))]
public sealed record class Choice : ModelBase, IFromRaw<Choice>
{
    public string? FinishReason
    {
        get
        {
            if (!this.Properties.TryGetValue("finish_reason", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["finish_reason"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public long? Index
    {
        get
        {
            if (!this.Properties.TryGetValue("index", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["index"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public JsonElement? Logprobs
    {
        get
        {
            if (!this.Properties.TryGetValue("logprobs", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<JsonElement?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["logprobs"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public ChatMessage? Message
    {
        get
        {
            if (!this.Properties.TryGetValue("message", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ChatMessage?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["message"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public List<AuthorizationResponse>? ToolAuthorizations
    {
        get
        {
            if (!this.Properties.TryGetValue("tool_authorizations", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<List<AuthorizationResponse>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["tool_authorizations"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public List<ChatMessage>? ToolMessages
    {
        get
        {
            if (!this.Properties.TryGetValue("tool_messages", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<List<ChatMessage>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["tool_messages"] = JsonSerializer.SerializeToElement(
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

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Choice(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static Choice FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
