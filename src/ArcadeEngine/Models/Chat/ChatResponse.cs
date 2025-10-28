using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeEngine.Core;

namespace ArcadeEngine.Models.Chat;

[JsonConverter(typeof(ModelConverter<ChatResponse>))]
public sealed record class ChatResponse : ModelBase, IFromRaw<ChatResponse>
{
    public string? ID
    {
        get
        {
            if (!this.Properties.TryGetValue("id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public List<Choice>? Choices
    {
        get
        {
            if (!this.Properties.TryGetValue("choices", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<List<Choice>?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["choices"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public long? Created
    {
        get
        {
            if (!this.Properties.TryGetValue("created", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["created"] = JsonSerializer.SerializeToElement(
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

    public string? Object
    {
        get
        {
            if (!this.Properties.TryGetValue("object", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["object"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? SystemFingerprint
    {
        get
        {
            if (!this.Properties.TryGetValue("system_fingerprint", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["system_fingerprint"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Usage? Usage
    {
        get
        {
            if (!this.Properties.TryGetValue("usage", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Usage?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["usage"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.ID;
        foreach (var item in this.Choices ?? [])
        {
            item.Validate();
        }
        _ = this.Created;
        _ = this.Model;
        _ = this.Object;
        _ = this.SystemFingerprint;
        this.Usage?.Validate();
    }

    public ChatResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ChatResponse(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static ChatResponse FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
