using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Tools;

[JsonConverter(typeof(JsonModelConverter<ToolExecution, ToolExecutionFromRaw>))]
public sealed record class ToolExecution : JsonModel
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

    public string? CreatedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("created_at");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("execution_status");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("execution_type");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("finished_at");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("finished_at", value);
        }
    }

    public string? RunAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("run_at");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("started_at");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("tool_name");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("toolkit_name");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("toolkit_version");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("updated_at");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("user_id");
        }
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
        _ = this.CreatedAt;
        _ = this.ExecutionStatus;
        _ = this.ExecutionType;
        _ = this.FinishedAt;
        _ = this.RunAt;
        _ = this.StartedAt;
        _ = this.ToolName;
        _ = this.ToolkitName;
        _ = this.ToolkitVersion;
        _ = this.UpdatedAt;
        _ = this.UserID;
    }

    public ToolExecution() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public ToolExecution(ToolExecution toolExecution)
        : base(toolExecution) { }
#pragma warning restore CS8618

    public ToolExecution(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ToolExecution(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ToolExecutionFromRaw.FromRawUnchecked"/>
    public static ToolExecution FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ToolExecutionFromRaw : IFromRawJson<ToolExecution>
{
    /// <inheritdoc/>
    public ToolExecution FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        ToolExecution.FromRawUnchecked(rawData);
}
