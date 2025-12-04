using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Auth;

[JsonConverter(typeof(ModelConverter<ConfirmUserRequest, ConfirmUserRequestFromRaw>))]
public sealed record class ConfirmUserRequest : ModelBase
{
    public required string FlowID
    {
        get { return ModelBase.GetNotNullClass<string>(this.RawData, "flow_id"); }
        init { ModelBase.Set(this._rawData, "flow_id", value); }
    }

    public required string UserID
    {
        get { return ModelBase.GetNotNullClass<string>(this.RawData, "user_id"); }
        init { ModelBase.Set(this._rawData, "user_id", value); }
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ConfirmUserRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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

class ConfirmUserRequestFromRaw : IFromRaw<ConfirmUserRequest>
{
    /// <inheritdoc/>
    public ConfirmUserRequest FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        ConfirmUserRequest.FromRawUnchecked(rawData);
}
