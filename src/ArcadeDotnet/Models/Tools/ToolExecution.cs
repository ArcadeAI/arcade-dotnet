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

    public string? CreatedAt
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "created_at"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "created_at", value);
        }
    }

    public string? ExecutionStatus
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "execution_status"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "execution_status", value);
        }
    }

    public string? ExecutionType
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "execution_type"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "execution_type", value);
        }
    }

    public string? FinishedAt
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "finished_at"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "finished_at", value);
        }
    }

    public string? RunAt
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "run_at"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "run_at", value);
        }
    }

    public string? StartedAt
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "started_at"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "started_at", value);
        }
    }

    public string? ToolName
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "tool_name"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "tool_name", value);
        }
    }

    public string? ToolkitName
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "toolkit_name"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "toolkit_name", value);
        }
    }

    public string? ToolkitVersion
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "toolkit_version"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "toolkit_version", value);
        }
    }

    public string? UpdatedAt
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "updated_at"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "updated_at", value);
        }
    }

    public string? UserID
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "user_id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "user_id", value);
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

    public ToolExecution(ToolExecution toolExecution)
        : base(toolExecution) { }

    public ToolExecution(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ToolExecution(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
