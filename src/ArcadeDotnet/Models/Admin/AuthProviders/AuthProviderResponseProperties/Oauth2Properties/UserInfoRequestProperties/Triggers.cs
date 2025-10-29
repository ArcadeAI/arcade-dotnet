using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderResponseProperties.Oauth2Properties.UserInfoRequestProperties;

[JsonConverter(typeof(ModelConverter<Triggers>))]
public sealed record class Triggers : ModelBase, IFromRaw<Triggers>
{
    public bool? OnTokenGrant
    {
        get
        {
            if (!this.Properties.TryGetValue("on_token_grant", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["on_token_grant"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public bool? OnTokenRefresh
    {
        get
        {
            if (!this.Properties.TryGetValue("on_token_refresh", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["on_token_refresh"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.OnTokenGrant;
        _ = this.OnTokenRefresh;
    }

    public Triggers() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Triggers(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static Triggers FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
