using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeEngine.Core;
using ArcadeEngine.Exceptions;

namespace ArcadeEngine.Models.Auth;

[JsonConverter(typeof(ModelConverter<ConfirmUserResponse>))]
public sealed record class ConfirmUserResponse : ModelBase, IFromRaw<ConfirmUserResponse>
{
    public required string AuthID
    {
        get
        {
            if (!this.Properties.TryGetValue("auth_id", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'auth_id' cannot be null",
                    new ArgumentOutOfRangeException("auth_id", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'auth_id' cannot be null",
                    new ArgumentNullException("auth_id")
                );
        }
        set
        {
            this.Properties["auth_id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

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
        _ = this.AuthID;
        _ = this.NextUri;
    }

    public ConfirmUserResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ConfirmUserResponse(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static ConfirmUserResponse FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }

    [SetsRequiredMembers]
    public ConfirmUserResponse(string authID)
        : this()
    {
        this.AuthID = authID;
    }
}
