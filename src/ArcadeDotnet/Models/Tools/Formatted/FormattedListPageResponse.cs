using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Tools.Formatted;

[JsonConverter(typeof(ModelConverter<FormattedListPageResponse, FormattedListPageResponseFromRaw>))]
public sealed record class FormattedListPageResponse : ModelBase
{
    public IReadOnlyList<JsonElement>? Items
    {
        get { return ModelBase.GetNullableClass<List<JsonElement>>(this.RawData, "items"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "items", value);
        }
    }

    public long? Limit
    {
        get { return ModelBase.GetNullableStruct<long>(this.RawData, "limit"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "limit", value);
        }
    }

    public long? Offset
    {
        get { return ModelBase.GetNullableStruct<long>(this.RawData, "offset"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "offset", value);
        }
    }

    public long? PageCount
    {
        get { return ModelBase.GetNullableStruct<long>(this.RawData, "page_count"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "page_count", value);
        }
    }

    public long? TotalCount
    {
        get { return ModelBase.GetNullableStruct<long>(this.RawData, "total_count"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "total_count", value);
        }
    }

    public override void Validate()
    {
        _ = this.Items;
        _ = this.Limit;
        _ = this.Offset;
        _ = this.PageCount;
        _ = this.TotalCount;
    }

    public FormattedListPageResponse() { }

    public FormattedListPageResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    FormattedListPageResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    public static FormattedListPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class FormattedListPageResponseFromRaw : IFromRaw<FormattedListPageResponse>
{
    public FormattedListPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => FormattedListPageResponse.FromRawUnchecked(rawData);
}
