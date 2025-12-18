using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Workers;

[JsonConverter(typeof(JsonModelConverter<WorkerHealthResponse, WorkerHealthResponseFromRaw>))]
public sealed record class WorkerHealthResponse : JsonModel
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

    public bool? Enabled
    {
        get { return JsonModel.GetNullableStruct<bool>(this.RawData, "enabled"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "enabled", value);
        }
    }

    public bool? Healthy
    {
        get { return JsonModel.GetNullableStruct<bool>(this.RawData, "healthy"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "healthy", value);
        }
    }

    public string? Message
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "message"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "message", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.Enabled;
        _ = this.Healthy;
        _ = this.Message;
    }

    public WorkerHealthResponse() { }

    public WorkerHealthResponse(WorkerHealthResponse workerHealthResponse)
        : base(workerHealthResponse) { }

    public WorkerHealthResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WorkerHealthResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="WorkerHealthResponseFromRaw.FromRawUnchecked"/>
    public static WorkerHealthResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class WorkerHealthResponseFromRaw : IFromRawJson<WorkerHealthResponse>
{
    /// <inheritdoc/>
    public WorkerHealthResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => WorkerHealthResponse.FromRawUnchecked(rawData);
}
