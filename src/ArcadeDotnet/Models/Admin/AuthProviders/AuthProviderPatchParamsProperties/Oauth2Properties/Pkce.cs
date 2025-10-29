using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderPatchParamsProperties.Oauth2Properties;

[JsonConverter(typeof(ModelConverter<Pkce>))]
public sealed record class Pkce : ModelBase, IFromRaw<Pkce>
{
    public string? CodeChallengeMethod
    {
        get
        {
            if (!this.Properties.TryGetValue("code_challenge_method", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["code_challenge_method"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public bool? Enabled
    {
        get
        {
            if (!this.Properties.TryGetValue("enabled", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["enabled"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.CodeChallengeMethod;
        _ = this.Enabled;
    }

    public Pkce() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Pkce(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static Pkce FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
