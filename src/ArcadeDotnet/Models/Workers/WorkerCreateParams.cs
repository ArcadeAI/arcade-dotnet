using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using System = System;

namespace ArcadeDotnet.Models.Workers;

/// <summary>
/// Create a worker
/// </summary>
public sealed record class WorkerCreateParams : ParamsBase
{
    public Dictionary<string, JsonElement> BodyProperties { get; set; } = [];

    public required string ID
    {
        get
        {
            if (!this.BodyProperties.TryGetValue("id", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'id' cannot be null",
                    new System::ArgumentOutOfRangeException("id", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'id' cannot be null",
                    new System::ArgumentNullException("id")
                );
        }
        set
        {
            this.BodyProperties["id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public bool? Enabled
    {
        get
        {
            if (!this.BodyProperties.TryGetValue("enabled", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.BodyProperties["enabled"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public HTTP? HTTP
    {
        get
        {
            if (!this.BodyProperties.TryGetValue("http", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<HTTP?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.BodyProperties["http"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Mcp? Mcp
    {
        get
        {
            if (!this.BodyProperties.TryGetValue("mcp", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Mcp?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.BodyProperties["mcp"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Type
    {
        get
        {
            if (!this.BodyProperties.TryGetValue("type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.BodyProperties["type"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override System::Uri Url(IArcadeClient client)
    {
        return new System::UriBuilder(client.BaseUrl.ToString().TrimEnd('/') + "/v1/workers")
        {
            Query = this.QueryString(client),
        }.Uri;
    }

    internal override StringContent? BodyContent()
    {
        return new(
            JsonSerializer.Serialize(this.BodyProperties),
            Encoding.UTF8,
            "application/json"
        );
    }

    internal override void AddHeadersToRequest(HttpRequestMessage request, IArcadeClient client)
    {
        ParamsBase.AddDefaultHeaders(request, client);
        foreach (var item in this.HeaderProperties)
        {
            ParamsBase.AddHeaderElementToRequest(request, item.Key, item.Value);
        }
    }
}

[JsonConverter(typeof(ModelConverter<HTTP>))]
public sealed record class HTTP : ModelBase, IFromRaw<HTTP>
{
    public required long Retry
    {
        get
        {
            if (!this.Properties.TryGetValue("retry", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'retry' cannot be null",
                    new System::ArgumentOutOfRangeException("retry", "Missing required argument")
                );

            return JsonSerializer.Deserialize<long>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["retry"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required string Secret
    {
        get
        {
            if (!this.Properties.TryGetValue("secret", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'secret' cannot be null",
                    new System::ArgumentOutOfRangeException("secret", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'secret' cannot be null",
                    new System::ArgumentNullException("secret")
                );
        }
        set
        {
            this.Properties["secret"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required long Timeout
    {
        get
        {
            if (!this.Properties.TryGetValue("timeout", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'timeout' cannot be null",
                    new System::ArgumentOutOfRangeException("timeout", "Missing required argument")
                );

            return JsonSerializer.Deserialize<long>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["timeout"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required string Uri
    {
        get
        {
            if (!this.Properties.TryGetValue("uri", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'uri' cannot be null",
                    new System::ArgumentOutOfRangeException("uri", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'uri' cannot be null",
                    new System::ArgumentNullException("uri")
                );
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
        _ = this.Secret;
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

[JsonConverter(typeof(ModelConverter<Mcp>))]
public sealed record class Mcp : ModelBase, IFromRaw<Mcp>
{
    public required long Retry
    {
        get
        {
            if (!this.Properties.TryGetValue("retry", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'retry' cannot be null",
                    new System::ArgumentOutOfRangeException("retry", "Missing required argument")
                );

            return JsonSerializer.Deserialize<long>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["retry"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required long Timeout
    {
        get
        {
            if (!this.Properties.TryGetValue("timeout", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'timeout' cannot be null",
                    new System::ArgumentOutOfRangeException("timeout", "Missing required argument")
                );

            return JsonSerializer.Deserialize<long>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["timeout"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required string Uri
    {
        get
        {
            if (!this.Properties.TryGetValue("uri", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'uri' cannot be null",
                    new System::ArgumentOutOfRangeException("uri", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'uri' cannot be null",
                    new System::ArgumentNullException("uri")
                );
        }
        set
        {
            this.Properties["uri"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Dictionary<string, string>? Headers
    {
        get
        {
            if (!this.Properties.TryGetValue("headers", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Dictionary<string, string>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["headers"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Oauth2? Oauth2
    {
        get
        {
            if (!this.Properties.TryGetValue("oauth2", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Oauth2?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["oauth2"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Dictionary<string, string>? Secrets
    {
        get
        {
            if (!this.Properties.TryGetValue("secrets", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Dictionary<string, string>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["secrets"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.Retry;
        _ = this.Timeout;
        _ = this.Uri;
        _ = this.Headers;
        this.Oauth2?.Validate();
        _ = this.Secrets;
    }

    public Mcp() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Mcp(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static Mcp FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}

[JsonConverter(typeof(ModelConverter<Oauth2>))]
public sealed record class Oauth2 : ModelBase, IFromRaw<Oauth2>
{
    public string? AuthorizationURL
    {
        get
        {
            if (!this.Properties.TryGetValue("authorization_url", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["authorization_url"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? ClientID
    {
        get
        {
            if (!this.Properties.TryGetValue("client_id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["client_id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? ClientSecret
    {
        get
        {
            if (!this.Properties.TryGetValue("client_secret", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["client_secret"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? ExternalID
    {
        get
        {
            if (!this.Properties.TryGetValue("external_id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["external_id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.AuthorizationURL;
        _ = this.ClientID;
        _ = this.ClientSecret;
        _ = this.ExternalID;
    }

    public Oauth2() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Oauth2(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static Oauth2 FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
