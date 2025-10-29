using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Workers.UpdateWorkerRequestProperties;

namespace ArcadeDotnet.Models.Workers;

[JsonConverter(typeof(ModelConverter<UpdateWorkerRequest>))]
public sealed record class UpdateWorkerRequest : ModelBase, IFromRaw<UpdateWorkerRequest>
{
    public bool? Enabled
    {
        get
        {
            if (!this.Properties.TryGetValue("enabled", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["enabled"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public HTTP? HTTP
    {
        get
        {
            if (!this.Properties.TryGetValue("http", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<HTTP?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["http"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Mcp? Mcp
    {
        get
        {
            if (!this.Properties.TryGetValue("mcp", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Mcp?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["mcp"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.Enabled;
        this.HTTP?.Validate();
        this.Mcp?.Validate();
    }

    public UpdateWorkerRequest() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    UpdateWorkerRequest(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static UpdateWorkerRequest FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
