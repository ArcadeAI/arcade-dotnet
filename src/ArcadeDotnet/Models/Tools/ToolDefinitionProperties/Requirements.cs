using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Tools.ToolDefinitionProperties.RequirementsProperties;

namespace ArcadeDotnet.Models.Tools.ToolDefinitionProperties;

[JsonConverter(typeof(ModelConverter<Requirements>))]
public sealed record class Requirements : ModelBase, IFromRaw<Requirements>
{
    public Authorization? Authorization
    {
        get
        {
            if (!this.Properties.TryGetValue("authorization", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Authorization?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["authorization"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public bool? Met
    {
        get
        {
            if (!this.Properties.TryGetValue("met", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["met"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public List<Secret>? Secrets
    {
        get
        {
            if (!this.Properties.TryGetValue("secrets", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<List<Secret>?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["secrets"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        this.Authorization?.Validate();
        _ = this.Met;
        foreach (var item in this.Secrets ?? [])
        {
            item.Validate();
        }
    }

    public Requirements() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Requirements(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static Requirements FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
