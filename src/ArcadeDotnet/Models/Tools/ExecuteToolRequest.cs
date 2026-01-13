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
        get { return this._rawData.GetNotNullClass<string>("tool_name"); }
        init { this._rawData.Set("tool_name", value); }
    }

    /// <summary>
    /// Whether to include the error stacktrace in the response. If not provided,
    /// the error stacktrace is not included.
    /// </summary>
    public bool? IncludeErrorStacktrace
    {
        get { return this._rawData.GetNullableStruct<bool>("include_error_stacktrace"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("include_error_stacktrace", value);
        }
    }

    /// <summary>
    /// JSON input to the tool, if any
    /// </summary>
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

    /// <summary>
    /// The time at which the tool should be run (optional). If not provided, the
    /// tool is run immediately. Format ISO 8601: YYYY-MM-DDTHH:MM:SS
    /// </summary>
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

    /// <summary>
    /// The tool version to use (optional). If not provided, any version is used
    /// </summary>
    public string? ToolVersion
    {
        get { return this._rawData.GetNullableClass<string>("tool_version"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("tool_version", value);
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
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ExecuteToolRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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
