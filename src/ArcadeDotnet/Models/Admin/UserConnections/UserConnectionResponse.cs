using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
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
        get { return this._rawData.GetNullableClass<string>("id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("id", value);
        }
    }

    public string? ConnectionID
    {
        get { return this._rawData.GetNullableClass<string>("connection_id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("connection_id", value);
        }
    }

    public string? ConnectionStatus
    {
        get { return this._rawData.GetNullableClass<string>("connection_status"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("connection_status", value);
        }
    }

    public string? ProviderDescription
    {
        get { return this._rawData.GetNullableClass<string>("provider_description"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("provider_description", value);
        }
    }

    public string? ProviderID
    {
        get { return this._rawData.GetNullableClass<string>("provider_id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("provider_id", value);
        }
    }

    public string? ProviderType
    {
        get { return this._rawData.GetNullableClass<string>("provider_type"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("provider_type", value);
        }
    }

    public JsonElement? ProviderUserInfo
    {
        get { return this._rawData.GetNullableStruct<JsonElement>("provider_user_info"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("provider_user_info", value);
        }
    }

    public IReadOnlyList<string>? Scopes
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<string>>("scopes"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "scopes",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public string? UserID
    {
        get { return this._rawData.GetNullableClass<string>("user_id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("user_id", value);
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
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    UserConnectionResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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
