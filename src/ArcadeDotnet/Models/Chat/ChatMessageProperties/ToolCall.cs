using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Chat.ChatMessageProperties.ToolCallProperties;

namespace ArcadeDotnet.Models.Chat.ChatMessageProperties;

[JsonConverter(typeof(ModelConverter<ToolCall>))]
public sealed record class ToolCall : ModelBase, IFromRaw<ToolCall>
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

    public Function? Function
    {
        get
        {
            if (!this.Properties.TryGetValue("function", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Function?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["function"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public ApiEnum<string, Type>? Type
    {
        get
        {
            if (!this.Properties.TryGetValue("type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<string, Type>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["type"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.ID;
        this.Function?.Validate();
        this.Type?.Validate();
    }

    public ToolCall() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ToolCall(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static ToolCall FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
