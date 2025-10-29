using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderCreateParamsProperties.Oauth2Properties.RefreshRequestProperties;

namespace ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderCreateParamsProperties.Oauth2Properties;

[JsonConverter(typeof(ModelConverter<RefreshRequest>))]
public sealed record class RefreshRequest : ModelBase, IFromRaw<RefreshRequest>
{
    public required string Endpoint
    {
        get
        {
            if (!this.Properties.TryGetValue("endpoint", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'endpoint' cannot be null",
                    new ArgumentOutOfRangeException("endpoint", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'endpoint' cannot be null",
                    new ArgumentNullException("endpoint")
                );
        }
        set
        {
            this.Properties["endpoint"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

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

    public ApiEnum<string, RequestContentType>? RequestContentType
    {
        get
        {
            if (!this.Properties.TryGetValue("request_content_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<string, RequestContentType>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["request_content_type"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public ApiEnum<string, ResponseContentType>? ResponseContentType
    {
        get
        {
            if (!this.Properties.TryGetValue("response_content_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<string, ResponseContentType>?>(
                element,
                ModelBase.SerializerOptions
            );
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

    public override void Validate()
    {
        _ = this.Endpoint;
        _ = this.AuthMethod;
        _ = this.Method;
        if (this.Params != null)
        {
            foreach (var item in this.Params.Values)
            {
                _ = item;
            }
        }
        this.RequestContentType?.Validate();
        this.ResponseContentType?.Validate();
        if (this.ResponseMap != null)
        {
            foreach (var item in this.ResponseMap.Values)
            {
                _ = item;
            }
        }
    }

    public RefreshRequest() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    RefreshRequest(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static RefreshRequest FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }

    [SetsRequiredMembers]
    public RefreshRequest(string endpoint)
        : this()
    {
        this.Endpoint = endpoint;
    }
}
