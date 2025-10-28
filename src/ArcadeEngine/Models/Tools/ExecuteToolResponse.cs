using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeEngine.Core;
using ArcadeEngine.Models.Tools.ExecuteToolResponseProperties;

namespace ArcadeEngine.Models.Tools;

[JsonConverter(typeof(ModelConverter<ExecuteToolResponse>))]
public sealed record class ExecuteToolResponse : ModelBase, IFromRaw<ExecuteToolResponse>
{
    public string? ID
    {
        get
        {
            if (!this.Properties.TryGetValue("id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public double? Duration
    {
        get
        {
            if (!this.Properties.TryGetValue("duration", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<double?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["duration"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? ExecutionID
    {
        get
        {
            if (!this.Properties.TryGetValue("execution_id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["execution_id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? ExecutionType
    {
        get
        {
            if (!this.Properties.TryGetValue("execution_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["execution_type"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? FinishedAt
    {
        get
        {
            if (!this.Properties.TryGetValue("finished_at", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["finished_at"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Output? Output
    {
        get
        {
            if (!this.Properties.TryGetValue("output", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Output?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["output"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

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

    public string? Status
    {
        get
        {
            if (!this.Properties.TryGetValue("status", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["status"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    /// <summary>
    /// Whether the request was successful. For immediately-executed requests, this
    /// will be true if the tool call succeeded. For scheduled requests, this will
    /// be true if the request was scheduled successfully.
    /// </summary>
    public bool? Success
    {
        get
        {
            if (!this.Properties.TryGetValue("success", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["success"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.ID;
        _ = this.Duration;
        _ = this.ExecutionID;
        _ = this.ExecutionType;
        _ = this.FinishedAt;
        this.Output?.Validate();
        _ = this.RunAt;
        _ = this.Status;
        _ = this.Success;
    }

    public ExecuteToolResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ExecuteToolResponse(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static ExecuteToolResponse FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
