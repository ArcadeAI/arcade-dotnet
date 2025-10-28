using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeEngine.Core;

namespace ArcadeEngine.Models.Chat;

[JsonConverter(typeof(ModelConverter<Usage>))]
public sealed record class Usage : ModelBase, IFromRaw<Usage>
{
    public long? CompletionTokens
    {
        get
        {
            if (!this.Properties.TryGetValue("completion_tokens", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["completion_tokens"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public long? PromptTokens
    {
        get
        {
            if (!this.Properties.TryGetValue("prompt_tokens", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["prompt_tokens"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public long? TotalTokens
    {
        get
        {
            if (!this.Properties.TryGetValue("total_tokens", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["total_tokens"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.CompletionTokens;
        _ = this.PromptTokens;
        _ = this.TotalTokens;
    }

    public Usage() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Usage(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static Usage FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
