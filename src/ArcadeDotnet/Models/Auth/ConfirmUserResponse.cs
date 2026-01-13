using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Auth;

[JsonConverter(typeof(JsonModelConverter<ConfirmUserResponse, ConfirmUserResponseFromRaw>))]
public sealed record class ConfirmUserResponse : JsonModel
{
    public required string AuthID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("auth_id");
        }
        init { this._rawData.Set("auth_id", value); }
    }

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
        _ = this.AuthID;
        _ = this.NextUri;
    }

    public ConfirmUserResponse() { }

    public ConfirmUserResponse(ConfirmUserResponse confirmUserResponse)
        : base(confirmUserResponse) { }

    public ConfirmUserResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ConfirmUserResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ConfirmUserResponseFromRaw.FromRawUnchecked"/>
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

class ConfirmUserResponseFromRaw : IFromRawJson<ConfirmUserResponse>
{
    /// <inheritdoc/>
    public ConfirmUserResponse FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        ConfirmUserResponse.FromRawUnchecked(rawData);
}
