using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using SecretsItemProperties = ArcadeDotnet.Models.Workers.WorkerResponseProperties.McpProperties.SecretsProperties.SecretsItemProperties;

namespace ArcadeDotnet.Models.Workers.WorkerResponseProperties.McpProperties.SecretsProperties;

[JsonConverter(typeof(ModelConverter<SecretsItem>))]
public sealed record class SecretsItem : ModelBase, IFromRaw<SecretsItem>
{
    public ApiEnum<string, SecretsItemProperties::Binding>? Binding
    {
        get
        {
            if (!this.Properties.TryGetValue("binding", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<string, SecretsItemProperties::Binding>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["binding"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public bool? Editable
    {
        get
        {
            if (!this.Properties.TryGetValue("editable", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["editable"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public bool? Exists
    {
        get
        {
            if (!this.Properties.TryGetValue("exists", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["exists"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Hint
    {
        get
        {
            if (!this.Properties.TryGetValue("hint", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["hint"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Value
    {
        get
        {
            if (!this.Properties.TryGetValue("value", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
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
        this.Binding?.Validate();
        _ = this.Editable;
        _ = this.Exists;
        _ = this.Hint;
        _ = this.Value;
    }

    public SecretsItem() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    SecretsItem(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static SecretsItem FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
