using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Auth;

[JsonConverter(typeof(JsonModelConverter<ConfirmUserRequest, ConfirmUserRequestFromRaw>))]
public sealed record class ConfirmUserRequest : JsonModel
{
    public required string FlowID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("flow_id");
        }
        init { this._rawData.Set("flow_id", value); }
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

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.FlowID;
        _ = this.UserID;
    }

    public ConfirmUserRequest() { }

    public ConfirmUserRequest(ConfirmUserRequest confirmUserRequest)
        : base(confirmUserRequest) { }

    public ConfirmUserRequest(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ConfirmUserRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ConfirmUserRequestFromRaw.FromRawUnchecked"/>
    public static ConfirmUserRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ConfirmUserRequestFromRaw : IFromRawJson<ConfirmUserRequest>
{
    /// <inheritdoc/>
    public ConfirmUserRequest FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        ConfirmUserRequest.FromRawUnchecked(rawData);
}
