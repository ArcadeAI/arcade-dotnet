using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeEngine.Core;
using ClientSecretProperties = ArcadeEngine.Models.Workers.WorkerResponseProperties.McpProperties.Oauth2Properties.ClientSecretProperties;

namespace ArcadeEngine.Models.Workers.WorkerResponseProperties.McpProperties.Oauth2Properties;

[JsonConverter(typeof(ModelConverter<ClientSecret>))]
public sealed record class ClientSecret : ModelBase, IFromRaw<ClientSecret>
{
    public ApiEnum<string, ClientSecretProperties::Binding>? Binding
    {
        get
        {
            if (!this.Properties.TryGetValue("binding", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<string, ClientSecretProperties::Binding>?>(
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

    public ClientSecret() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ClientSecret(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static ClientSecret FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
