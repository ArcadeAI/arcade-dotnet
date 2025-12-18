using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Auth;

/// <summary>
/// Starts the authorization process for given authorization requirements
/// </summary>
public sealed record class AuthAuthorizeParams : ParamsBase
{
    readonly FreezableDictionary<string, JsonElement> _rawBodyData = [];
    public IReadOnlyDictionary<string, JsonElement> RawBodyData
    {
        get { return this._rawBodyData.Freeze(); }
    }

    public required AuthRequirement AuthRequirement
    {
        get
        {
            return JsonModel.GetNotNullClass<AuthRequirement>(this.RawBodyData, "auth_requirement");
        }
        init { JsonModel.Set(this._rawBodyData, "auth_requirement", value); }
    }

    public required string UserID
    {
        get { return JsonModel.GetNotNullClass<string>(this.RawBodyData, "user_id"); }
        init { JsonModel.Set(this._rawBodyData, "user_id", value); }
    }

    /// <summary>
    /// Optional: if provided, the user will be redirected to this URI after authorization
    /// </summary>
    public string? NextUri
    {
        get { return JsonModel.GetNullableClass<string>(this.RawBodyData, "next_uri"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "next_uri", value);
        }
    }

    public AuthAuthorizeParams() { }

    public AuthAuthorizeParams(AuthAuthorizeParams authAuthorizeParams)
        : base(authAuthorizeParams)
    {
        this._rawBodyData = [.. authAuthorizeParams._rawBodyData];
    }

    public AuthAuthorizeParams(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData,
        IReadOnlyDictionary<string, JsonElement> rawBodyData
    )
    {
        this._rawHeaderData = [.. rawHeaderData];
        this._rawQueryData = [.. rawQueryData];
        this._rawBodyData = [.. rawBodyData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthAuthorizeParams(
        FrozenDictionary<string, JsonElement> rawHeaderData,
        FrozenDictionary<string, JsonElement> rawQueryData,
        FrozenDictionary<string, JsonElement> rawBodyData
    )
    {
        this._rawHeaderData = [.. rawHeaderData];
        this._rawQueryData = [.. rawQueryData];
        this._rawBodyData = [.. rawBodyData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="IFromRawJson.FromRawUnchecked"/>
    public static AuthAuthorizeParams FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData,
        IReadOnlyDictionary<string, JsonElement> rawBodyData
    )
    {
        return new(
            FrozenDictionary.ToFrozenDictionary(rawHeaderData),
            FrozenDictionary.ToFrozenDictionary(rawQueryData),
            FrozenDictionary.ToFrozenDictionary(rawBodyData)
        );
    }

    public override Uri Url(ClientOptions options)
    {
        return new UriBuilder(options.BaseUrl.ToString().TrimEnd('/') + "/v1/auth/authorize")
        {
            Query = this.QueryString(options),
        }.Uri;
    }

    internal override HttpContent? BodyContent()
    {
        return new StringContent(
            JsonSerializer.Serialize(this.RawBodyData),
            Encoding.UTF8,
            "application/json"
        );
    }

    internal override void AddHeadersToRequest(HttpRequestMessage request, ClientOptions options)
    {
        ParamsBase.AddDefaultHeaders(request, options);
        foreach (var item in this.RawHeaderData)
        {
            ParamsBase.AddHeaderElementToRequest(request, item.Key, item.Value);
        }
    }
}

[JsonConverter(typeof(JsonModelConverter<AuthRequirement, AuthRequirementFromRaw>))]
public sealed record class AuthRequirement : JsonModel
{
    /// <summary>
    /// one of ID or ProviderID must be set
    /// </summary>
    public string? ID
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "id", value);
        }
    }

    public Oauth2? Oauth2
    {
        get { return JsonModel.GetNullableClass<Oauth2>(this.RawData, "oauth2"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "oauth2", value);
        }
    }

    /// <summary>
    /// one of ID or ProviderID must be set
    /// </summary>
    public string? ProviderID
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "provider_id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "provider_id", value);
        }
    }

    public string? ProviderType
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "provider_type"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "provider_type", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        this.Oauth2?.Validate();
        _ = this.ProviderID;
        _ = this.ProviderType;
    }

    public AuthRequirement() { }

    public AuthRequirement(AuthRequirement authRequirement)
        : base(authRequirement) { }

    public AuthRequirement(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthRequirement(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthRequirementFromRaw.FromRawUnchecked"/>
    public static AuthRequirement FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthRequirementFromRaw : IFromRawJson<AuthRequirement>
{
    /// <inheritdoc/>
    public AuthRequirement FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        AuthRequirement.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Oauth2, Oauth2FromRaw>))]
public sealed record class Oauth2 : JsonModel
{
    public IReadOnlyList<string>? Scopes
    {
        get { return JsonModel.GetNullableClass<List<string>>(this.RawData, "scopes"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "scopes", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Scopes;
    }

    public Oauth2() { }

    public Oauth2(Oauth2 oauth2)
        : base(oauth2) { }

    public Oauth2(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Oauth2(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="Oauth2FromRaw.FromRawUnchecked"/>
    public static Oauth2 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class Oauth2FromRaw : IFromRawJson<Oauth2>
{
    /// <inheritdoc/>
    public Oauth2 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Oauth2.FromRawUnchecked(rawData);
}
