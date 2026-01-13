using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Admin.UserConnections;

[JsonConverter(
    typeof(JsonModelConverter<
        UserConnectionListPageResponse,
        UserConnectionListPageResponseFromRaw
    >)
)]
public sealed record class UserConnectionListPageResponse : JsonModel
{
    public IReadOnlyList<UserConnectionResponse>? Items
    {
        get
        {
            return this._rawData.GetNullableStruct<ImmutableArray<UserConnectionResponse>>("items");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<UserConnectionResponse>?>(
                "items",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public long? Limit
    {
        get { return this._rawData.GetNullableStruct<long>("limit"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("limit", value);
        }
    }

    public long? Offset
    {
        get { return this._rawData.GetNullableStruct<long>("offset"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("offset", value);
        }
    }

    public long? PageCount
    {
        get { return this._rawData.GetNullableStruct<long>("page_count"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("page_count", value);
        }
    }

    public long? TotalCount
    {
        get { return this._rawData.GetNullableStruct<long>("total_count"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("total_count", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        foreach (var item in this.Items ?? [])
        {
            item.Validate();
        }
        _ = this.Limit;
        _ = this.Offset;
        _ = this.PageCount;
        _ = this.TotalCount;
    }

    public UserConnectionListPageResponse() { }

    public UserConnectionListPageResponse(
        UserConnectionListPageResponse userConnectionListPageResponse
    )
        : base(userConnectionListPageResponse) { }

    public UserConnectionListPageResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    UserConnectionListPageResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="UserConnectionListPageResponseFromRaw.FromRawUnchecked"/>
    public static UserConnectionListPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class UserConnectionListPageResponseFromRaw : IFromRawJson<UserConnectionListPageResponse>
{
    /// <inheritdoc/>
    public UserConnectionListPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => UserConnectionListPageResponse.FromRawUnchecked(rawData);
}
