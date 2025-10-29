using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Admin.UserConnections.UserConnectionListParamsProperties;

[JsonConverter(typeof(ModelConverter<Provider>))]
public sealed record class Provider : ModelBase, IFromRaw<Provider>
{
    /// <summary>
    /// Provider ID
    /// </summary>
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

    public override void Validate()
    {
        _ = this.ID;
    }

    public Provider() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Provider(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static Provider FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
