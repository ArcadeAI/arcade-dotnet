using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeEngine.Core;
using ArcadeEngine.Models.Workers.WorkerResponseProperties.RequirementsProperties.AuthorizationProperties;

namespace ArcadeEngine.Models.Workers.WorkerResponseProperties.RequirementsProperties;

[JsonConverter(typeof(ModelConverter<Authorization>))]
public sealed record class Authorization : ModelBase, IFromRaw<Authorization>
{
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

    public Oauth2? Oauth2
    {
        get
        {
            if (!this.Properties.TryGetValue("oauth2", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Oauth2?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["oauth2"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.Met;
        this.Oauth2?.Validate();
    }

    public Authorization() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Authorization(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static Authorization FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
