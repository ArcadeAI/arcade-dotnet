using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Auth;

[JsonConverter(typeof(ModelConverter<AuthRequest, AuthRequestFromRaw>))]
public sealed record class AuthRequest : ModelBase
{
    public required AuthRequestAuthRequirement AuthRequirement
    {
        get
        {
            return ModelBase.GetNotNullClass<AuthRequestAuthRequirement>(
                this.RawData,
                "auth_requirement"
            );
        }
        init { ModelBase.Set(this._rawData, "auth_requirement", value); }
    }

    public required string UserID
    {
        get { return ModelBase.GetNotNullClass<string>(this.RawData, "user_id"); }
        init { ModelBase.Set(this._rawData, "user_id", value); }
    }

    /// <summary>
    /// Optional: if provided, the user will be redirected to this URI after authorization
    /// </summary>
    public string? NextUri
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "next_uri"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "next_uri", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        this.AuthRequirement.Validate();
        _ = this.UserID;
        _ = this.NextUri;
    }

    public AuthRequest() { }

    public AuthRequest(AuthRequest authRequest)
        : base(authRequest) { }

    public AuthRequest(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthRequestFromRaw.FromRawUnchecked"/>
    public static AuthRequest FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthRequestFromRaw : IFromRaw<AuthRequest>
{
    /// <inheritdoc/>
    public AuthRequest FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        AuthRequest.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(ModelConverter<AuthRequestAuthRequirement, AuthRequestAuthRequirementFromRaw>)
)]
public sealed record class AuthRequestAuthRequirement : ModelBase
{
    /// <summary>
    /// one of ID or ProviderID must be set
    /// </summary>
    public string? ID
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "id", value);
        }
    }

    public AuthRequestAuthRequirementOauth2? Oauth2
    {
        get
        {
            return ModelBase.GetNullableClass<AuthRequestAuthRequirementOauth2>(
                this.RawData,
                "oauth2"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "oauth2", value);
        }
    }

    /// <summary>
    /// one of ID or ProviderID must be set
    /// </summary>
    public string? ProviderID
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "provider_id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "provider_id", value);
        }
    }

    public string? ProviderType
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "provider_type"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "provider_type", value);
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

    public AuthRequestAuthRequirement() { }

    public AuthRequestAuthRequirement(AuthRequestAuthRequirement authRequestAuthRequirement)
        : base(authRequestAuthRequirement) { }

    public AuthRequestAuthRequirement(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthRequestAuthRequirement(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthRequestAuthRequirementFromRaw.FromRawUnchecked"/>
    public static AuthRequestAuthRequirement FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthRequestAuthRequirementFromRaw : IFromRaw<AuthRequestAuthRequirement>
{
    /// <inheritdoc/>
    public AuthRequestAuthRequirement FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthRequestAuthRequirement.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(ModelConverter<
        AuthRequestAuthRequirementOauth2,
        AuthRequestAuthRequirementOauth2FromRaw
    >)
)]
public sealed record class AuthRequestAuthRequirementOauth2 : ModelBase
{
    public IReadOnlyList<string>? Scopes
    {
        get { return ModelBase.GetNullableClass<List<string>>(this.RawData, "scopes"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "scopes", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Scopes;
    }

    public AuthRequestAuthRequirementOauth2() { }

    public AuthRequestAuthRequirementOauth2(
        AuthRequestAuthRequirementOauth2 authRequestAuthRequirementOauth2
    )
        : base(authRequestAuthRequirementOauth2) { }

    public AuthRequestAuthRequirementOauth2(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthRequestAuthRequirementOauth2(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthRequestAuthRequirementOauth2FromRaw.FromRawUnchecked"/>
    public static AuthRequestAuthRequirementOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthRequestAuthRequirementOauth2FromRaw : IFromRaw<AuthRequestAuthRequirementOauth2>
{
    /// <inheritdoc/>
    public AuthRequestAuthRequirementOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthRequestAuthRequirementOauth2.FromRawUnchecked(rawData);
}
