using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeEngine.Core;
using ArcadeEngine.Models.Admin.AuthProviders.AuthProviderUpdateRequestProperties.Oauth2Properties;

namespace ArcadeEngine.Models.Admin.AuthProviders.AuthProviderUpdateRequestProperties;

[JsonConverter(typeof(ModelConverter<Oauth2>))]
public sealed record class Oauth2 : ModelBase, IFromRaw<Oauth2>
{
    public AuthorizeRequest? AuthorizeRequest
    {
        get
        {
            if (!this.Properties.TryGetValue("authorize_request", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<AuthorizeRequest?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["authorize_request"] = JsonSerializer.SerializeToElement(
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

    public Pkce? Pkce
    {
        get
        {
            if (!this.Properties.TryGetValue("pkce", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Pkce?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["pkce"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public RefreshRequest? RefreshRequest
    {
        get
        {
            if (!this.Properties.TryGetValue("refresh_request", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<RefreshRequest?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["refresh_request"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public ApiEnum<string, ScopeDelimiter>? ScopeDelimiter
    {
        get
        {
            if (!this.Properties.TryGetValue("scope_delimiter", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<string, ScopeDelimiter>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["scope_delimiter"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public TokenRequest? TokenRequest
    {
        get
        {
            if (!this.Properties.TryGetValue("token_request", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<TokenRequest?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["token_request"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public UserInfoRequest? UserInfoRequest
    {
        get
        {
            if (!this.Properties.TryGetValue("user_info_request", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<UserInfoRequest?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["user_info_request"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        this.AuthorizeRequest?.Validate();
        _ = this.ClientID;
        _ = this.ClientSecret;
        this.Pkce?.Validate();
        this.RefreshRequest?.Validate();
        this.ScopeDelimiter?.Validate();
        this.TokenRequest?.Validate();
        this.UserInfoRequest?.Validate();
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
