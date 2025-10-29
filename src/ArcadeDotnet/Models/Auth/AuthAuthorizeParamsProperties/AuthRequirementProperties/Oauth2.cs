using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Auth.AuthAuthorizeParamsProperties.AuthRequirementProperties;

[JsonConverter(typeof(ModelConverter<Oauth2>))]
public sealed record class Oauth2 : ModelBase, IFromRaw<Oauth2>
{
    public List<string>? Scopes
    {
        get
        {
            if (!this.Properties.TryGetValue("scopes", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<List<string>?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["scopes"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        foreach (var item in this.Scopes ?? [])
        {
            _ = item;
        }
    }

    public Oauth2() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Oauth2(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static Oauth2 FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
