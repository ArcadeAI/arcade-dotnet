using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeEngine.Core;
using ArcadeEngine.Exceptions;

namespace ArcadeEngine.Models.Tools;

[JsonConverter(typeof(ModelConverter<ExecuteToolRequest>))]
public sealed record class ExecuteToolRequest : ModelBase, IFromRaw<ExecuteToolRequest>
{
    public required string ToolName
    {
        get
        {
            if (!this.Properties.TryGetValue("tool_name", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'tool_name' cannot be null",
                    new ArgumentOutOfRangeException("tool_name", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'tool_name' cannot be null",
                    new ArgumentNullException("tool_name")
                );
        }
        set
        {
            this.Properties["tool_name"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    /// <summary>
    /// Whether to include the error stacktrace in the response. If not provided,
    /// the error stacktrace is not included.
    /// </summary>
    public bool? IncludeErrorStacktrace
    {
        get
        {
            if (!this.Properties.TryGetValue("include_error_stacktrace", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["include_error_stacktrace"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    /// <summary>
    /// JSON input to the tool, if any
    /// </summary>
    public Dictionary<string, JsonElement>? Input
    {
        get
        {
            if (!this.Properties.TryGetValue("input", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Dictionary<string, JsonElement>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["input"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    /// <summary>
    /// The time at which the tool should be run (optional). If not provided, the
    /// tool is run immediately. Format ISO 8601: YYYY-MM-DDTHH:MM:SS
    /// </summary>
    public string? RunAt
    {
        get
        {
            if (!this.Properties.TryGetValue("run_at", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["run_at"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    /// <summary>
    /// The tool version to use (optional). If not provided, any version is used
    /// </summary>
    public string? ToolVersion
    {
        get
        {
            if (!this.Properties.TryGetValue("tool_version", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["tool_version"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? UserID
    {
        get
        {
            if (!this.Properties.TryGetValue("user_id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["user_id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.ToolName;
        _ = this.IncludeErrorStacktrace;
        if (this.Input != null)
        {
            foreach (var item in this.Input.Values)
            {
                _ = item;
            }
        }
        _ = this.RunAt;
        _ = this.ToolVersion;
        _ = this.UserID;
    }

    public ExecuteToolRequest() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ExecuteToolRequest(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static ExecuteToolRequest FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }

    [SetsRequiredMembers]
    public ExecuteToolRequest(string toolName)
        : this()
    {
        this.ToolName = toolName;
    }
}
