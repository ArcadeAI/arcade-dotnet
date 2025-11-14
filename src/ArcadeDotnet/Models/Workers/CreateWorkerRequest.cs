using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;

namespace ArcadeDotnet.Models.Workers;

[JsonConverter(typeof(ModelConverter<CreateWorkerRequest>))]
public sealed record class CreateWorkerRequest : ModelBase, IFromRaw<CreateWorkerRequest>
{
    public required string ID
    {
        get
        {
            if (!this._properties.TryGetValue("id", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'id' cannot be null",
                    new ArgumentOutOfRangeException("id", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'id' cannot be null",
                    new ArgumentNullException("id")
                );
        }
        init
        {
            this._properties["id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public bool? Enabled
    {
        get
        {
            if (!this._properties.TryGetValue("enabled", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["enabled"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public CreateWorkerRequestHTTP? HTTP
    {
        get
        {
            if (!this._properties.TryGetValue("http", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<CreateWorkerRequestHTTP?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["http"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public CreateWorkerRequestMcp? Mcp
    {
        get
        {
            if (!this._properties.TryGetValue("mcp", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<CreateWorkerRequestMcp?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["mcp"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Type
    {
        get
        {
            if (!this._properties.TryGetValue("type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["type"] = JsonSerializer.SerializeToElement(
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

    public CreateWorkerRequest(IReadOnlyDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CreateWorkerRequest(FrozenDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static CreateWorkerRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }

    [SetsRequiredMembers]
    public CreateWorkerRequest(string id)
        : this()
    {
        this.ID = id;
    }
}

[JsonConverter(typeof(ModelConverter<CreateWorkerRequestHTTP>))]
public sealed record class CreateWorkerRequestHTTP : ModelBase, IFromRaw<CreateWorkerRequestHTTP>
{
    public required long Retry
    {
        get
        {
            if (!this._properties.TryGetValue("retry", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'retry' cannot be null",
                    new ArgumentOutOfRangeException("retry", "Missing required argument")
                );

            return JsonSerializer.Deserialize<long>(element, ModelBase.SerializerOptions);
        }
        init
        {
            this._properties["retry"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required string Secret
    {
        get
        {
            if (!this._properties.TryGetValue("secret", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'secret' cannot be null",
                    new ArgumentOutOfRangeException("secret", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'secret' cannot be null",
                    new ArgumentNullException("secret")
                );
        }
        init
        {
            this._properties["secret"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required long Timeout
    {
        get
        {
            if (!this._properties.TryGetValue("timeout", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'timeout' cannot be null",
                    new ArgumentOutOfRangeException("timeout", "Missing required argument")
                );

            return JsonSerializer.Deserialize<long>(element, ModelBase.SerializerOptions);
        }
        init
        {
            this._properties["timeout"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required string Uri
    {
        get
        {
            if (!this._properties.TryGetValue("uri", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'uri' cannot be null",
                    new ArgumentOutOfRangeException("uri", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'uri' cannot be null",
                    new ArgumentNullException("uri")
                );
        }
        init
        {
            this._properties["uri"] = JsonSerializer.SerializeToElement(
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

    public CreateWorkerRequestHTTP() { }

    public CreateWorkerRequestHTTP(IReadOnlyDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CreateWorkerRequestHTTP(FrozenDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static CreateWorkerRequestHTTP FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }
}

[JsonConverter(typeof(ModelConverter<CreateWorkerRequestMcp>))]
public sealed record class CreateWorkerRequestMcp : ModelBase, IFromRaw<CreateWorkerRequestMcp>
{
    public required long Retry
    {
        get
        {
            if (!this._properties.TryGetValue("retry", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'retry' cannot be null",
                    new ArgumentOutOfRangeException("retry", "Missing required argument")
                );

            return JsonSerializer.Deserialize<long>(element, ModelBase.SerializerOptions);
        }
        init
        {
            this._properties["retry"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required long Timeout
    {
        get
        {
            if (!this._properties.TryGetValue("timeout", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'timeout' cannot be null",
                    new ArgumentOutOfRangeException("timeout", "Missing required argument")
                );

            return JsonSerializer.Deserialize<long>(element, ModelBase.SerializerOptions);
        }
        init
        {
            this._properties["timeout"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required string Uri
    {
        get
        {
            if (!this._properties.TryGetValue("uri", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'uri' cannot be null",
                    new ArgumentOutOfRangeException("uri", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'uri' cannot be null",
                    new ArgumentNullException("uri")
                );
        }
        init
        {
            this._properties["uri"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Dictionary<string, string>? Headers
    {
        get
        {
            if (!this._properties.TryGetValue("headers", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Dictionary<string, string>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["headers"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public CreateWorkerRequestMcpOauth2? Oauth2
    {
        get
        {
            if (!this._properties.TryGetValue("oauth2", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<CreateWorkerRequestMcpOauth2?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["oauth2"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Dictionary<string, string>? Secrets
    {
        get
        {
            if (!this._properties.TryGetValue("secrets", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Dictionary<string, string>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["secrets"] = JsonSerializer.SerializeToElement(
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

    public CreateWorkerRequestMcp() { }

    public CreateWorkerRequestMcp(IReadOnlyDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CreateWorkerRequestMcp(FrozenDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static CreateWorkerRequestMcp FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }
}

[JsonConverter(typeof(ModelConverter<CreateWorkerRequestMcpOauth2>))]
public sealed record class CreateWorkerRequestMcpOauth2
    : ModelBase,
        IFromRaw<CreateWorkerRequestMcpOauth2>
{
    public string? AuthorizationURL
    {
        get
        {
            if (!this._properties.TryGetValue("authorization_url", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["authorization_url"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? ClientID
    {
        get
        {
            if (!this._properties.TryGetValue("client_id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["client_id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? ClientSecret
    {
        get
        {
            if (!this._properties.TryGetValue("client_secret", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["client_secret"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? ExternalID
    {
        get
        {
            if (!this._properties.TryGetValue("external_id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["external_id"] = JsonSerializer.SerializeToElement(
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

    public CreateWorkerRequestMcpOauth2() { }

    public CreateWorkerRequestMcpOauth2(IReadOnlyDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CreateWorkerRequestMcpOauth2(FrozenDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static CreateWorkerRequestMcpOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }
}
