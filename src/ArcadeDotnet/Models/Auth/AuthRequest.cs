using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;

namespace ArcadeDotnet.Models.Auth;

[JsonConverter(typeof(ModelConverter<AuthRequest, AuthRequestFromRaw>))]
public sealed record class AuthRequest : ModelBase
{
    public required AuthRequestAuthRequirement AuthRequirement
    {
        get
        {
            if (!this._rawData.TryGetValue("auth_requirement", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'auth_requirement' cannot be null",
                    new ArgumentOutOfRangeException("auth_requirement", "Missing required argument")
                );

            return JsonSerializer.Deserialize<AuthRequestAuthRequirement>(
                    element,
                    ModelBase.SerializerOptions
                )
                ?? throw new ArcadeInvalidDataException(
                    "'auth_requirement' cannot be null",
                    new ArgumentNullException("auth_requirement")
                );
        }
        init
        {
            this._rawData["auth_requirement"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required string UserID
    {
        get
        {
            if (!this._rawData.TryGetValue("user_id", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'user_id' cannot be null",
                    new ArgumentOutOfRangeException("user_id", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'user_id' cannot be null",
                    new ArgumentNullException("user_id")
                );
        }
        init
        {
            this._rawData["user_id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    /// <summary>
    /// Optional: if provided, the user will be redirected to this URI after authorization
    /// </summary>
    public string? NextUri
    {
        get
        {
            if (!this._rawData.TryGetValue("next_uri", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["next_uri"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        this.AuthRequirement.Validate();
        _ = this.UserID;
        _ = this.NextUri;
    }

    public AuthRequest() { }

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

    public static AuthRequest FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthRequestFromRaw : IFromRaw<AuthRequest>
{
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
        get
        {
            if (!this._rawData.TryGetValue("id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public AuthRequestAuthRequirementOauth2? Oauth2
    {
        get
        {
            if (!this._rawData.TryGetValue("oauth2", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<AuthRequestAuthRequirementOauth2?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["oauth2"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    /// <summary>
    /// one of ID or ProviderID must be set
    /// </summary>
    public string? ProviderID
    {
        get
        {
            if (!this._rawData.TryGetValue("provider_id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["provider_id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? ProviderType
    {
        get
        {
            if (!this._rawData.TryGetValue("provider_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["provider_type"] = JsonSerializer.SerializeToElement(
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
    }

    public AuthRequestAuthRequirement() { }

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

    public static AuthRequestAuthRequirement FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthRequestAuthRequirementFromRaw : IFromRaw<AuthRequestAuthRequirement>
{
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
    public List<string>? Scopes
    {
        get
        {
            if (!this._rawData.TryGetValue("scopes", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<List<string>?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["scopes"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.Scopes;
    }

    public AuthRequestAuthRequirementOauth2() { }

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

    public static AuthRequestAuthRequirementOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthRequestAuthRequirementOauth2FromRaw : IFromRaw<AuthRequestAuthRequirementOauth2>
{
    public AuthRequestAuthRequirementOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthRequestAuthRequirementOauth2.FromRawUnchecked(rawData);
}
