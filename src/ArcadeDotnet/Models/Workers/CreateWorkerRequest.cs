using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using System = System;

namespace ArcadeDotnet.Models.Workers;

[JsonConverter(typeof(ModelConverter<CreateWorkerRequest>))]
public sealed record class CreateWorkerRequest : ModelBase, IFromRaw<CreateWorkerRequest>
{
    public required string ID
    {
        get
        {
            if (!this.Properties.TryGetValue("id", out JsonElement element))
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
            this.Properties["id"] = JsonSerializer.SerializeToElement(
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

    public HTTP1? HTTP
    {
        get
        {
            if (!this.Properties.TryGetValue("http", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<HTTP1?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["http"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Mcp1? Mcp
    {
        get
        {
            if (!this.Properties.TryGetValue("mcp", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Mcp1?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["mcp"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Type
    {
        get
        {
            if (!this.Properties.TryGetValue("type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["type"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.ID;
        _ = this.Enabled;
        this.HTTP?.Validate();
        this.Mcp?.Validate();
        _ = this.Type;
    }

    public CreateWorkerRequest() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CreateWorkerRequest(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static CreateWorkerRequest FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }

    [SetsRequiredMembers]
    public CreateWorkerRequest(string id)
        : this()
    {
        this.ID = id;
    }
}

[JsonConverter(typeof(ModelConverter<HTTP1>))]
public sealed record class HTTP1 : ModelBase, IFromRaw<HTTP1>
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

    public HTTP1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    HTTP1(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static HTTP1 FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}

[JsonConverter(typeof(ModelConverter<Mcp1>))]
public sealed record class Mcp1 : ModelBase, IFromRaw<Mcp1>
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

    public Oauth21? Oauth2
    {
        get
        {
            if (!this.Properties.TryGetValue("oauth2", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Oauth21?>(element, ModelBase.SerializerOptions);
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

    public Mcp1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Mcp1(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static Mcp1 FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}

[JsonConverter(typeof(ModelConverter<Oauth21>))]
public sealed record class Oauth21 : ModelBase, IFromRaw<Oauth21>
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

    public Oauth21() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Oauth21(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static Oauth21 FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
