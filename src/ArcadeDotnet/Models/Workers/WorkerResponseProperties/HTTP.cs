using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Workers.WorkerResponseProperties.HTTPProperties;

namespace ArcadeDotnet.Models.Workers.WorkerResponseProperties;

[JsonConverter(typeof(ModelConverter<HTTP>))]
public sealed record class HTTP : ModelBase, IFromRaw<HTTP>
{
    public long? Retry
    {
        get
        {
            if (!this.Properties.TryGetValue("retry", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["retry"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Secret? Secret
    {
        get
        {
            if (!this.Properties.TryGetValue("secret", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Secret?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["secret"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public long? Timeout
    {
        get
        {
            if (!this.Properties.TryGetValue("timeout", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["timeout"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Uri
    {
        get
        {
            if (!this.Properties.TryGetValue("uri", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["uri"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.Retry;
        this.Secret?.Validate();
        _ = this.Timeout;
        _ = this.Uri;
    }

    public HTTP() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    HTTP(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static HTTP FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
