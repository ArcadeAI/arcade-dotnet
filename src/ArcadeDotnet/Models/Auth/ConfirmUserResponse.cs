using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;

namespace ArcadeDotnet.Models.Auth;

[JsonConverter(typeof(ModelConverter<ConfirmUserResponse>))]
public sealed record class ConfirmUserResponse : ModelBase, IFromRaw<ConfirmUserResponse>
{
    public required string AuthID
    {
        get
        {
            if (!this._rawData.TryGetValue("auth_id", out JsonElement element))
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
        init
        {
            this._rawData["auth_id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

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
        _ = this.AuthID;
        _ = this.NextUri;
    }

    public ConfirmUserResponse() { }

    public ConfirmUserResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ConfirmUserResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    public static ConfirmUserResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public ConfirmUserResponse(string authID)
        : this()
    {
        this.AuthID = authID;
    }
}
