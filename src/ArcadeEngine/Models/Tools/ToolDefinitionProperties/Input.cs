using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeEngine.Core;
using ArcadeEngine.Models.Tools.ToolDefinitionProperties.InputProperties;

namespace ArcadeEngine.Models.Tools.ToolDefinitionProperties;

[JsonConverter(typeof(ModelConverter<Input>))]
public sealed record class Input : ModelBase, IFromRaw<Input>
{
    public List<Parameter>? Parameters
    {
        get
        {
            if (!this.Properties.TryGetValue("parameters", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<List<Parameter>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["parameters"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        foreach (var item in this.Parameters ?? [])
        {
            item.Validate();
        }
    }

    public Input() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Input(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static Input FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
