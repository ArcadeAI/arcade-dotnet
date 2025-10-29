using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Health;

[JsonConverter(typeof(ModelConverter<HealthSchema>))]
public sealed record class HealthSchema : ModelBase, IFromRaw<HealthSchema>
{
    public bool? Healthy
    {
        get
        {
            if (!this.Properties.TryGetValue("healthy", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["healthy"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.Healthy;
    }

    public HealthSchema() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    HealthSchema(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static HealthSchema FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
