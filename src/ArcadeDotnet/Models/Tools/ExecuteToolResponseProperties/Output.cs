using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using OutputProperties = ArcadeDotnet.Models.Tools.ExecuteToolResponseProperties.OutputProperties;

namespace ArcadeDotnet.Models.Tools.ExecuteToolResponseProperties;

[JsonConverter(typeof(ModelConverter<Output>))]
public sealed record class Output : ModelBase, IFromRaw<Output>
{
    public AuthorizationResponse? Authorization
    {
        get
        {
            if (!this.Properties.TryGetValue("authorization", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<AuthorizationResponse?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["authorization"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public OutputProperties::Error? Error
    {
        get
        {
            if (!this.Properties.TryGetValue("error", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<OutputProperties::Error?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["error"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public List<OutputProperties::Log>? Logs
    {
        get
        {
            if (!this.Properties.TryGetValue("logs", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<List<OutputProperties::Log>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["logs"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public JsonElement? Value
    {
        get
        {
            if (!this.Properties.TryGetValue("value", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<JsonElement?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["value"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        this.Authorization?.Validate();
        this.Error?.Validate();
        foreach (var item in this.Logs ?? [])
        {
            item.Validate();
        }
        _ = this.Value;
    }

    public Output() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Output(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static Output FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
