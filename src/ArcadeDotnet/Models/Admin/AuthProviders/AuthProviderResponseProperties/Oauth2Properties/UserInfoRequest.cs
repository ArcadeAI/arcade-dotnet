using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderResponseProperties.Oauth2Properties.UserInfoRequestProperties;

namespace ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderResponseProperties.Oauth2Properties;

[JsonConverter(typeof(ModelConverter<UserInfoRequest>))]
public sealed record class UserInfoRequest : ModelBase, IFromRaw<UserInfoRequest>
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
        _ = this.Endpoint;
        _ = this.ExpirationFormat;
        _ = this.Method;
        _ = this.Params;
        _ = this.RequestContentType;
        _ = this.ResponseContentType;
        _ = this.ResponseMap;
        this.Triggers?.Validate();
    }

    public UserInfoRequest() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    UserInfoRequest(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static UserInfoRequest FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
