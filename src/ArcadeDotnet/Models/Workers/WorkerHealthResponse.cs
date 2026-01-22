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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("id", value);
        }
    }

    public bool? Enabled
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("enabled");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("enabled", value);
        }
    }

    public bool? Healthy
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("healthy");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("healthy", value);
        }
    }

    public string? Message
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("message");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("message", value);
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

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public WorkerHealthResponse(WorkerHealthResponse workerHealthResponse)
        : base(workerHealthResponse) { }
#pragma warning restore CS8618

    public WorkerHealthResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WorkerHealthResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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
