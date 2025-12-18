using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Tools;

[JsonConverter(typeof(JsonModelConverter<ExecuteToolRequest, ExecuteToolRequestFromRaw>))]
public sealed record class ExecuteToolRequest : JsonModel
{
    public required string ToolName
    {
        get { return JsonModel.GetNotNullClass<string>(this.RawData, "tool_name"); }
        init { JsonModel.Set(this._rawData, "tool_name", value); }
    }

    /// <summary>
    /// Whether to include the error stacktrace in the response. If not provided,
    /// the error stacktrace is not included.
    /// </summary>
    public bool? IncludeErrorStacktrace
    {
        get { return JsonModel.GetNullableStruct<bool>(this.RawData, "include_error_stacktrace"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "include_error_stacktrace", value);
        }
    }

    /// <summary>
    /// JSON input to the tool, if any
    /// </summary>
    public IReadOnlyDictionary<string, JsonElement>? Input
    {
        get
        {
            return JsonModel.GetNullableClass<Dictionary<string, JsonElement>>(
                this.RawData,
                "input"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "input", value);
        }
    }

    /// <summary>
    /// The time at which the tool should be run (optional). If not provided, the
    /// tool is run immediately. Format ISO 8601: YYYY-MM-DDTHH:MM:SS
    /// </summary>
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

    /// <summary>
    /// The tool version to use (optional). If not provided, any version is used
    /// </summary>
    public string? ToolVersion
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "tool_version"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "tool_version", value);
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
        _ = this.ToolName;
        _ = this.IncludeErrorStacktrace;
        _ = this.Input;
        _ = this.RunAt;
        _ = this.ToolVersion;
        _ = this.UserID;
    }

    public ExecuteToolRequest() { }

    public ExecuteToolRequest(ExecuteToolRequest executeToolRequest)
        : base(executeToolRequest) { }

    public ExecuteToolRequest(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ExecuteToolRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ExecuteToolRequestFromRaw.FromRawUnchecked"/>
    public static ExecuteToolRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public ExecuteToolRequest(string toolName)
        : this()
    {
        this.ToolName = toolName;
    }
}

class ExecuteToolRequestFromRaw : IFromRawJson<ExecuteToolRequest>
{
    /// <inheritdoc/>
    public ExecuteToolRequest FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        ExecuteToolRequest.FromRawUnchecked(rawData);
}
