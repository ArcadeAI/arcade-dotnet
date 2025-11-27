using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Workers;

[JsonConverter(typeof(ModelConverter<UpdateWorkerRequest, UpdateWorkerRequestFromRaw>))]
public sealed record class UpdateWorkerRequest : ModelBase
{
    public bool? Enabled
    {
        get
        {
            if (!this._rawData.TryGetValue("enabled", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["enabled"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public UpdateWorkerRequestHTTP? HTTP
    {
        get
        {
            if (!this._rawData.TryGetValue("http", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<UpdateWorkerRequestHTTP?>(
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

            this._rawData["http"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public UpdateWorkerRequestMcp? Mcp
    {
        get
        {
            if (!this._rawData.TryGetValue("mcp", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<UpdateWorkerRequestMcp?>(
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

            this._rawData["mcp"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.Enabled;
        this.HTTP?.Validate();
        this.Mcp?.Validate();
    }

    public UpdateWorkerRequest() { }

    public UpdateWorkerRequest(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    UpdateWorkerRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    public static UpdateWorkerRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class UpdateWorkerRequestFromRaw : IFromRaw<UpdateWorkerRequest>
{
    public UpdateWorkerRequest FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        UpdateWorkerRequest.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ModelConverter<UpdateWorkerRequestHTTP, UpdateWorkerRequestHTTPFromRaw>))]
public sealed record class UpdateWorkerRequestHTTP : ModelBase
{
    public long? Retry
    {
        get
        {
            if (!this._rawData.TryGetValue("retry", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["retry"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Secret
    {
        get
        {
            if (!this._rawData.TryGetValue("secret", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["secret"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public long? Timeout
    {
        get
        {
            if (!this._rawData.TryGetValue("timeout", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["timeout"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Uri
    {
        get
        {
            if (!this._rawData.TryGetValue("uri", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["uri"] = JsonSerializer.SerializeToElement(
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

    public UpdateWorkerRequestHTTP() { }

    public UpdateWorkerRequestHTTP(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    UpdateWorkerRequestHTTP(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    public static UpdateWorkerRequestHTTP FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class UpdateWorkerRequestHTTPFromRaw : IFromRaw<UpdateWorkerRequestHTTP>
{
    public UpdateWorkerRequestHTTP FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => UpdateWorkerRequestHTTP.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ModelConverter<UpdateWorkerRequestMcp, UpdateWorkerRequestMcpFromRaw>))]
public sealed record class UpdateWorkerRequestMcp : ModelBase
{
    public IReadOnlyDictionary<string, string>? Headers
    {
        get
        {
            if (!this._rawData.TryGetValue("headers", out JsonElement element))
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

            this._rawData["headers"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public UpdateWorkerRequestMcpOauth2? Oauth2
    {
        get
        {
            if (!this._rawData.TryGetValue("oauth2", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<UpdateWorkerRequestMcpOauth2?>(
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

            this._rawData["oauth2"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public long? Retry
    {
        get
        {
            if (!this._rawData.TryGetValue("retry", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["retry"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public IReadOnlyDictionary<string, string>? Secrets
    {
        get
        {
            if (!this._rawData.TryGetValue("secrets", out JsonElement element))
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

            this._rawData["secrets"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public long? Timeout
    {
        get
        {
            if (!this._rawData.TryGetValue("timeout", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["timeout"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Uri
    {
        get
        {
            if (!this._rawData.TryGetValue("uri", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["uri"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.Headers;
        this.Oauth2?.Validate();
        _ = this.Retry;
        _ = this.Secrets;
        _ = this.Timeout;
        _ = this.Uri;
    }

    public UpdateWorkerRequestMcp() { }

    public UpdateWorkerRequestMcp(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    UpdateWorkerRequestMcp(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    public static UpdateWorkerRequestMcp FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class UpdateWorkerRequestMcpFromRaw : IFromRaw<UpdateWorkerRequestMcp>
{
    public UpdateWorkerRequestMcp FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => UpdateWorkerRequestMcp.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(ModelConverter<UpdateWorkerRequestMcpOauth2, UpdateWorkerRequestMcpOauth2FromRaw>)
)]
public sealed record class UpdateWorkerRequestMcpOauth2 : ModelBase
{
    public string? AuthorizationURL
    {
        get
        {
            if (!this._rawData.TryGetValue("authorization_url", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["authorization_url"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? ClientID
    {
        get
        {
            if (!this._rawData.TryGetValue("client_id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["client_id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? ClientSecret
    {
        get
        {
            if (!this._rawData.TryGetValue("client_secret", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["client_secret"] = JsonSerializer.SerializeToElement(
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
    }

    public UpdateWorkerRequestMcpOauth2() { }

    public UpdateWorkerRequestMcpOauth2(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    UpdateWorkerRequestMcpOauth2(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    public static UpdateWorkerRequestMcpOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class UpdateWorkerRequestMcpOauth2FromRaw : IFromRaw<UpdateWorkerRequestMcpOauth2>
{
    public UpdateWorkerRequestMcpOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => UpdateWorkerRequestMcpOauth2.FromRawUnchecked(rawData);
}
