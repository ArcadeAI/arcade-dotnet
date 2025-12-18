using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Admin.UserConnections;

[JsonConverter(typeof(JsonModelConverter<UserConnectionResponse, UserConnectionResponseFromRaw>))]
public sealed record class UserConnectionResponse : JsonModel
{
    public string? ID
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "id", value);
        }
    }

    public string? ConnectionID
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "connection_id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "connection_id", value);
        }
    }

    public string? ConnectionStatus
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "connection_status"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "connection_status", value);
        }
    }

    public string? ProviderDescription
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "provider_description"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "provider_description", value);
        }
    }

    public string? ProviderID
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "provider_id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "provider_id", value);
        }
    }

    public string? ProviderType
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "provider_type"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "provider_type", value);
        }
    }

    public JsonElement? ProviderUserInfo
    {
        get { return JsonModel.GetNullableStruct<JsonElement>(this.RawData, "provider_user_info"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "provider_user_info", value);
        }
    }

    public IReadOnlyList<string>? Scopes
    {
        get { return JsonModel.GetNullableClass<List<string>>(this.RawData, "scopes"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "scopes", value);
        }
    }

    public string? UserID
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "user_id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "user_id", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.ConnectionID;
        _ = this.ConnectionStatus;
        _ = this.ProviderDescription;
        _ = this.ProviderID;
        _ = this.ProviderType;
        _ = this.ProviderUserInfo;
        _ = this.Scopes;
        _ = this.UserID;
    }

    public UserConnectionResponse() { }

    public UserConnectionResponse(UserConnectionResponse userConnectionResponse)
        : base(userConnectionResponse) { }

    public UserConnectionResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    UserConnectionResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="UserConnectionResponseFromRaw.FromRawUnchecked"/>
    public static UserConnectionResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class UserConnectionResponseFromRaw : IFromRawJson<UserConnectionResponse>
{
    /// <inheritdoc/>
    public UserConnectionResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => UserConnectionResponse.FromRawUnchecked(rawData);
}
