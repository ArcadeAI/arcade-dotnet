using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Tools.ToolExecutionAttemptProperties;

namespace ArcadeDotnet.Models.Tools;

[JsonConverter(typeof(ModelConverter<ToolExecutionAttempt>))]
public sealed record class ToolExecutionAttempt : ModelBase, IFromRaw<ToolExecutionAttempt>
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

    public string? StartedAt
    {
        get
        {
            if (!this.Properties.TryGetValue("started_at", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["started_at"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

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

    public string? SystemErrorMessage
    {
        get
        {
            if (!this.Properties.TryGetValue("system_error_message", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["system_error_message"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.ID;
        _ = this.FinishedAt;
        this.Output?.Validate();
        _ = this.StartedAt;
        _ = this.Success;
        _ = this.SystemErrorMessage;
    }

    public ToolExecutionAttempt() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ToolExecutionAttempt(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static ToolExecutionAttempt FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
