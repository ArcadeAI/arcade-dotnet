using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Tools.ToolDefinitionProperties;

[JsonConverter(typeof(ModelConverter<Output>))]
public sealed record class Output : ModelBase, IFromRaw<Output>
{
    public List<string>? AvailableModes
    {
        get
        {
            if (!this.Properties.TryGetValue("available_modes", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<List<string>?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["available_modes"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Description
    {
        get
        {
            if (!this.Properties.TryGetValue("description", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["description"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public ValueSchema? ValueSchema
    {
        get
        {
            if (!this.Properties.TryGetValue("value_schema", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ValueSchema?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["value_schema"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        foreach (var item in this.AvailableModes ?? [])
        {
            _ = item;
        }
        _ = this.Description;
        this.ValueSchema?.Validate();
    }

    public Output() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Output(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static Output FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
