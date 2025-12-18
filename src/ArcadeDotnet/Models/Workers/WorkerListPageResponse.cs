using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Workers;

[JsonConverter(typeof(JsonModelConverter<WorkerListPageResponse, WorkerListPageResponseFromRaw>))]
public sealed record class WorkerListPageResponse : JsonModel
{
    public IReadOnlyList<WorkerResponse>? Items
    {
        get { return JsonModel.GetNullableClass<List<WorkerResponse>>(this.RawData, "items"); }
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
        foreach (var item in this.Items ?? [])
        {
            item.Validate();
        }
        _ = this.Limit;
        _ = this.Offset;
        _ = this.PageCount;
        _ = this.TotalCount;
    }

    public WorkerListPageResponse() { }

    public WorkerListPageResponse(WorkerListPageResponse workerListPageResponse)
        : base(workerListPageResponse) { }

    public WorkerListPageResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WorkerListPageResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="WorkerListPageResponseFromRaw.FromRawUnchecked"/>
    public static WorkerListPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class WorkerListPageResponseFromRaw : IFromRawJson<WorkerListPageResponse>
{
    /// <inheritdoc/>
    public WorkerListPageResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => WorkerListPageResponse.FromRawUnchecked(rawData);
}
