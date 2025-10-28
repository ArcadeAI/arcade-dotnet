using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeEngine.Core;
using ArcadeEngine.Exceptions;
using ArcadeEngine.Models.Auth.AuthRequestProperties;

namespace ArcadeEngine.Models.Auth;

[JsonConverter(typeof(ModelConverter<AuthRequest>))]
public sealed record class AuthRequest : ModelBase, IFromRaw<AuthRequest>
{
    public required AuthRequirement AuthRequirement
    {
        get
        {
            if (!this.Properties.TryGetValue("auth_requirement", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'auth_requirement' cannot be null",
                    new ArgumentOutOfRangeException("auth_requirement", "Missing required argument")
                );

            return JsonSerializer.Deserialize<AuthRequirement>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'auth_requirement' cannot be null",
                    new ArgumentNullException("auth_requirement")
                );
        }
        set
        {
            this.Properties["auth_requirement"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required string UserID
    {
        get
        {
            if (!this.Properties.TryGetValue("user_id", out JsonElement element))
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
        set
        {
            this.Properties["user_id"] = JsonSerializer.SerializeToElement(
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
            if (!this.Properties.TryGetValue("next_uri", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["next_uri"] = JsonSerializer.SerializeToElement(
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

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthRequest(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static AuthRequest FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
