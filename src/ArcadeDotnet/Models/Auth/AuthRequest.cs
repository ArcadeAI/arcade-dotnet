using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Auth;

[JsonConverter(typeof(JsonModelConverter<AuthRequest, AuthRequestFromRaw>))]
public sealed record class AuthRequest : JsonModel
{
    public required AuthRequestAuthRequirement AuthRequirement
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<AuthRequestAuthRequirement>("auth_requirement");
        }
        init { this._rawData.Set("auth_requirement", value); }
    }

    public required string UserID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("user_id");
        }
        init { this._rawData.Set("user_id", value); }
    }

    /// <summary>
    /// Optional: if provided, the user will be redirected to this URI after authorization
    /// </summary>
    public string? NextUri
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("next_uri");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("next_uri", value);
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

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AuthRequest(AuthRequest authRequest)
        : base(authRequest) { }
#pragma warning restore CS8618

    public AuthRequest(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthRequestFromRaw.FromRawUnchecked"/>
    public static AuthRequest FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthRequestFromRaw : IFromRawJson<AuthRequest>
{
    /// <inheritdoc/>
    public AuthRequest FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        AuthRequest.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<AuthRequestAuthRequirement, AuthRequestAuthRequirementFromRaw>)
)]
public sealed record class AuthRequestAuthRequirement : JsonModel
{
    /// <summary>
    /// one of ID or ProviderID must be set
    /// </summary>
    public string? ID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("id", value);
        }
    }

    public AuthRequestAuthRequirementOauth2? Oauth2
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<AuthRequestAuthRequirementOauth2>("oauth2");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("oauth2", value);
        }
    }

    /// <summary>
    /// one of ID or ProviderID must be set
    /// </summary>
    public string? ProviderID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("provider_id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("provider_id", value);
        }
    }

    public string? ProviderType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("provider_type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("provider_type", value);
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

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AuthRequestAuthRequirement(AuthRequestAuthRequirement authRequestAuthRequirement)
        : base(authRequestAuthRequirement) { }
#pragma warning restore CS8618

    public AuthRequestAuthRequirement(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthRequestAuthRequirement(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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

class AuthRequestAuthRequirementFromRaw : IFromRawJson<AuthRequestAuthRequirement>
{
    /// <inheritdoc/>
    public AuthRequestAuthRequirement FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthRequestAuthRequirement.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        AuthRequestAuthRequirementOauth2,
        AuthRequestAuthRequirementOauth2FromRaw
    >)
)]
public sealed record class AuthRequestAuthRequirementOauth2 : JsonModel
{
    public IReadOnlyList<string>? Scopes
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>("scopes");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "scopes",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Scopes;
    }

    public AuthRequestAuthRequirementOauth2() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AuthRequestAuthRequirementOauth2(
        AuthRequestAuthRequirementOauth2 authRequestAuthRequirementOauth2
    )
        : base(authRequestAuthRequirementOauth2) { }
#pragma warning restore CS8618

    public AuthRequestAuthRequirementOauth2(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthRequestAuthRequirementOauth2(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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

class AuthRequestAuthRequirementOauth2FromRaw : IFromRawJson<AuthRequestAuthRequirementOauth2>
{
    /// <inheritdoc/>
    public AuthRequestAuthRequirementOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthRequestAuthRequirementOauth2.FromRawUnchecked(rawData);
}
