using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Chat.ChatMessageProperties.ToolCallProperties;

[JsonConverter(typeof(ModelConverter<Function>))]
public sealed record class Function : ModelBase, IFromRaw<Function>
{
    public string? Arguments
    {
        get
        {
            if (!this.Properties.TryGetValue("arguments", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["arguments"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Name
    {
        get
        {
            if (!this.Properties.TryGetValue("name", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["name"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.Arguments;
        _ = this.Name;
    }

    public Function() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Function(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static Function FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
