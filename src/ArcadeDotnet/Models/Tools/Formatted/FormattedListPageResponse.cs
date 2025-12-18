using System.Collections.Frozen;
using System.Collections.Generic;
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
        get { return JsonModel.GetNullableClass<List<JsonElement>>(this.RawData, "items"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "items", value);
        }
    }

    public long? Limit
    {
        get { return JsonModel.GetNullableStruct<long>(this.RawData, "limit"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "limit", value);
        }
    }

    public long? Offset
    {
        get { return JsonModel.GetNullableStruct<long>(this.RawData, "offset"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "offset", value);
        }
    }

    public long? PageCount
    {
        get { return JsonModel.GetNullableStruct<long>(this.RawData, "page_count"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "page_count", value);
        }
    }

    public long? TotalCount
    {
        get { return JsonModel.GetNullableStruct<long>(this.RawData, "total_count"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "total_count", value);
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

    public FormattedListPageResponse(FormattedListPageResponse formattedListPageResponse)
        : base(formattedListPageResponse) { }

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
