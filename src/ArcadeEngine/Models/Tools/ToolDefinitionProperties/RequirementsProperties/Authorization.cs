using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeEngine.Core;
using ArcadeEngine.Models.Tools.ToolDefinitionProperties.RequirementsProperties.AuthorizationProperties;

namespace ArcadeEngine.Models.Tools.ToolDefinitionProperties.RequirementsProperties;

[JsonConverter(typeof(ModelConverter<Authorization>))]
public sealed record class Authorization : ModelBase, IFromRaw<Authorization>
{
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

    public string? ProviderID
    {
        get
        {
            if (!this.Properties.TryGetValue("provider_id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["provider_id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? ProviderType
    {
        get
        {
            if (!this.Properties.TryGetValue("provider_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["provider_type"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public ApiEnum<string, Status>? Status
    {
        get
        {
            if (!this.Properties.TryGetValue("status", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<string, Status>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["status"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? StatusReason
    {
        get
        {
            if (!this.Properties.TryGetValue("status_reason", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["status_reason"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public ApiEnum<string, TokenStatus>? TokenStatus
    {
        get
        {
            if (!this.Properties.TryGetValue("token_status", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<string, TokenStatus>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["token_status"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.ID;
        this.Oauth2?.Validate();
        _ = this.ProviderID;
        _ = this.ProviderType;
        this.Status?.Validate();
        _ = this.StatusReason;
        this.TokenStatus?.Validate();
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
