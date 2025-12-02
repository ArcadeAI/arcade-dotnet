using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Auth;

[JsonConverter(typeof(ModelConverter<ConfirmUserResponse, ConfirmUserResponseFromRaw>))]
public sealed record class ConfirmUserResponse : ModelBase
{
    public required string AuthID
    {
        get { return ModelBase.GetNotNullClass<string>(this.RawData, "auth_id"); }
        init { ModelBase.Set(this._rawData, "auth_id", value); }
    }

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

class ConfirmUserResponseFromRaw : IFromRaw<ConfirmUserResponse>
{
    public ConfirmUserResponse FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        ConfirmUserResponse.FromRawUnchecked(rawData);
}
