using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Tools.Formatted;

[JsonConverter(
    typeof(JsonModelConverter<FormattedListPageResponse, FormattedListPageResponseFromRaw>)
)]
public sealed record class FormattedListPageResponse : JsonModel
{
    public IReadOnlyList<JsonElement>? Items
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<JsonElement>>("items");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<JsonElement>?>(
                "items",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public long? Limit
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<long>("limit");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<long>("offset");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<long>("page_count");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<long>("total_count");
        }
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
        _ = this.Items;
        _ = this.Limit;
        _ = this.Offset;
        _ = this.PageCount;
        _ = this.TotalCount;
    }

    public FormattedListPageResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public FormattedListPageResponse(FormattedListPageResponse formattedListPageResponse)
        : base(formattedListPageResponse) { }
#pragma warning restore CS8618

    public FormattedListPageResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    FormattedListPageResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="FormattedListPageResponseFromRaw.FromRawUnchecked"/>
    public static FormattedListPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class FormattedListPageResponseFromRaw : IFromRawJson<FormattedListPageResponse>
{
    /// <inheritdoc/>
    public FormattedListPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => FormattedListPageResponse.FromRawUnchecked(rawData);
}
