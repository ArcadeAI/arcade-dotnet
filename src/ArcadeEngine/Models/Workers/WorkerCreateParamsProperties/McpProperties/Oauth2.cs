using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeEngine.Core;

namespace ArcadeEngine.Models.Workers.WorkerCreateParamsProperties.McpProperties;

[JsonConverter(typeof(ModelConverter<Oauth2>))]
public sealed record class Oauth2 : ModelBase, IFromRaw<Oauth2>
{
    public string? AuthorizationURL
    {
        get
        {
            if (!this.Properties.TryGetValue("authorization_url", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["authorization_url"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? ClientID
    {
        get
        {
            if (!this.Properties.TryGetValue("client_id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["client_id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? ClientSecret
    {
        get
        {
            if (!this.Properties.TryGetValue("client_secret", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["client_secret"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? ExternalID
    {
        get
        {
            if (!this.Properties.TryGetValue("external_id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["external_id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.AuthorizationURL;
        _ = this.ClientID;
        _ = this.ClientSecret;
        _ = this.ExternalID;
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
