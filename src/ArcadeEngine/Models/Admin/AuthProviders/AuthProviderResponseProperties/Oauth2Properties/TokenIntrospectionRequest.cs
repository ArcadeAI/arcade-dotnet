using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeEngine.Core;
using ArcadeEngine.Models.Admin.AuthProviders.AuthProviderResponseProperties.Oauth2Properties.TokenIntrospectionRequestProperties;

namespace ArcadeEngine.Models.Admin.AuthProviders.AuthProviderResponseProperties.Oauth2Properties;

[JsonConverter(typeof(ModelConverter<TokenIntrospectionRequest>))]
public sealed record class TokenIntrospectionRequest
    : ModelBase,
        IFromRaw<TokenIntrospectionRequest>
{
    public string? AuthMethod
    {
        get
        {
            if (!this.Properties.TryGetValue("auth_method", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["auth_method"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

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

    public string? Endpoint
    {
        get
        {
            if (!this.Properties.TryGetValue("endpoint", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["endpoint"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? ExpirationFormat
    {
        get
        {
            if (!this.Properties.TryGetValue("expiration_format", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["expiration_format"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Method
    {
        get
        {
            if (!this.Properties.TryGetValue("method", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["method"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Dictionary<string, string>? Params
    {
        get
        {
            if (!this.Properties.TryGetValue("params", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Dictionary<string, string>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["params"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? RequestContentType
    {
        get
        {
            if (!this.Properties.TryGetValue("request_content_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["request_content_type"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? ResponseContentType
    {
        get
        {
            if (!this.Properties.TryGetValue("response_content_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["response_content_type"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Dictionary<string, string>? ResponseMap
    {
        get
        {
            if (!this.Properties.TryGetValue("response_map", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Dictionary<string, string>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["response_map"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Triggers? Triggers
    {
        get
        {
            if (!this.Properties.TryGetValue("triggers", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Triggers?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["triggers"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.AuthMethod;
        _ = this.Enabled;
        _ = this.Endpoint;
        _ = this.ExpirationFormat;
        _ = this.Method;
        if (this.Params != null)
        {
            foreach (var item in this.Params.Values)
            {
                _ = item;
            }
        }
        _ = this.RequestContentType;
        _ = this.ResponseContentType;
        if (this.ResponseMap != null)
        {
            foreach (var item in this.ResponseMap.Values)
            {
                _ = item;
            }
        }
        this.Triggers?.Validate();
    }

    public TokenIntrospectionRequest() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TokenIntrospectionRequest(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static TokenIntrospectionRequest FromRawUnchecked(
        Dictionary<string, JsonElement> properties
    )
    {
        return new(properties);
    }
}
