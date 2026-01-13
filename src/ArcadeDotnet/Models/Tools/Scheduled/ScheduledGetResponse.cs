using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Tools.Scheduled;

[JsonConverter(typeof(JsonModelConverter<ScheduledGetResponse, ScheduledGetResponseFromRaw>))]
public sealed record class ScheduledGetResponse : JsonModel
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

    public IReadOnlyList<ToolExecutionAttempt>? Attempts
    {
        get
        {
            return this._rawData.GetNullableStruct<ImmutableArray<ToolExecutionAttempt>>(
                "attempts"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<ToolExecutionAttempt>?>(
                "attempts",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public string? CreatedAt
    {
        get { return this._rawData.GetNullableClass<string>("created_at"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("created_at", value);
        }
    }

    public string? ExecutionStatus
    {
        get { return this._rawData.GetNullableClass<string>("execution_status"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("execution_status", value);
        }
    }

    public string? ExecutionType
    {
        get { return this._rawData.GetNullableClass<string>("execution_type"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("execution_type", value);
        }
    }

    public string? FinishedAt
    {
        get { return this._rawData.GetNullableClass<string>("finished_at"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("finished_at", value);
        }
    }

    public IReadOnlyDictionary<string, JsonElement>? Input
    {
        get
        {
            return this._rawData.GetNullableClass<FrozenDictionary<string, JsonElement>>("input");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<FrozenDictionary<string, JsonElement>?>(
                "input",
                value == null ? null : FrozenDictionary.ToFrozenDictionary(value)
            );
        }
    }

    public string? RunAt
    {
        get { return this._rawData.GetNullableClass<string>("run_at"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("run_at", value);
        }
    }

    public string? StartedAt
    {
        get { return this._rawData.GetNullableClass<string>("started_at"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("started_at", value);
        }
    }

    public string? ToolName
    {
        get { return this._rawData.GetNullableClass<string>("tool_name"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("tool_name", value);
        }
    }

    public string? ToolkitName
    {
        get { return this._rawData.GetNullableClass<string>("toolkit_name"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("toolkit_name", value);
        }
    }

    public string? ToolkitVersion
    {
        get { return this._rawData.GetNullableClass<string>("toolkit_version"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("toolkit_version", value);
        }
    }

    public string? UpdatedAt
    {
        get { return this._rawData.GetNullableClass<string>("updated_at"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("updated_at", value);
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
        foreach (var item in this.Attempts ?? [])
        {
            item.Validate();
        }
        _ = this.CreatedAt;
        _ = this.ExecutionStatus;
        _ = this.ExecutionType;
        _ = this.FinishedAt;
        _ = this.Input;
        _ = this.RunAt;
        _ = this.StartedAt;
        _ = this.ToolName;
        _ = this.ToolkitName;
        _ = this.ToolkitVersion;
        _ = this.UpdatedAt;
        _ = this.UserID;
    }

    public ScheduledGetResponse() { }

    public ScheduledGetResponse(ScheduledGetResponse scheduledGetResponse)
        : base(scheduledGetResponse) { }

    public ScheduledGetResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ScheduledGetResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ScheduledGetResponseFromRaw.FromRawUnchecked"/>
    public static ScheduledGetResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ScheduledGetResponseFromRaw : IFromRawJson<ScheduledGetResponse>
{
    /// <inheritdoc/>
    public ScheduledGetResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => ScheduledGetResponse.FromRawUnchecked(rawData);
}
