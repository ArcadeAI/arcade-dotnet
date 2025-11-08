using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;

namespace ArcadeDotnet.Models.Auth;

[JsonConverter(typeof(ModelConverter<AuthRequest>))]
public sealed record class AuthRequest : ModelBase, IFromRaw<AuthRequest>
{
    public required AuthRequirementModel AuthRequirement
    {
        get
        {
            if (!this._properties.TryGetValue("auth_requirement", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'auth_requirement' cannot be null",
                    new ArgumentOutOfRangeException("auth_requirement", "Missing required argument")
                );

            return JsonSerializer.Deserialize<AuthRequirementModel>(
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
            this._properties["auth_requirement"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required string UserID
    {
        get
        {
            if (!this._properties.TryGetValue("user_id", out JsonElement element))
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
            this._properties["user_id"] = JsonSerializer.SerializeToElement(
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
            if (!this._properties.TryGetValue("next_uri", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["next_uri"] = JsonSerializer.SerializeToElement(
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

    public AuthRequest(IReadOnlyDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthRequest(FrozenDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static AuthRequest FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> properties)
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }
}

[JsonConverter(typeof(ModelConverter<AuthRequirementModel>))]
public sealed record class AuthRequirementModel : ModelBase, IFromRaw<AuthRequirementModel>
{
    /// <summary>
    /// one of ID or ProviderID must be set
    /// </summary>
    public string? ID
    {
        get
        {
            if (!this._properties.TryGetValue("id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Oauth2Model? Oauth2
    {
        get
        {
            if (!this._properties.TryGetValue("oauth2", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Oauth2Model?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["oauth2"] = JsonSerializer.SerializeToElement(
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
            if (!this._properties.TryGetValue("provider_id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["provider_id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? ProviderType
    {
        get
        {
            if (!this._properties.TryGetValue("provider_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["provider_type"] = JsonSerializer.SerializeToElement(
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

    public AuthRequirementModel() { }

    public AuthRequirementModel(IReadOnlyDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthRequirementModel(FrozenDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static AuthRequirementModel FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }
}

[JsonConverter(typeof(ModelConverter<Oauth2Model>))]
public sealed record class Oauth2Model : ModelBase, IFromRaw<Oauth2Model>
{
    public List<string>? Scopes
    {
        get
        {
            if (!this._properties.TryGetValue("scopes", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<List<string>?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["scopes"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.Scopes;
    }

    public Oauth2Model() { }

    public Oauth2Model(IReadOnlyDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Oauth2Model(FrozenDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static Oauth2Model FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> properties)
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }
}
