using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Workers;

/// <summary>
/// Create a worker
/// </summary>
public sealed record class WorkerCreateParams : ParamsBase
{
    readonly FreezableDictionary<string, JsonElement> _rawBodyData = [];
    public IReadOnlyDictionary<string, JsonElement> RawBodyData
    {
        get { return this._rawBodyData.Freeze(); }
    }

    public required string ID
    {
        get { return JsonModel.GetNotNullClass<string>(this.RawBodyData, "id"); }
        init { JsonModel.Set(this._rawBodyData, "id", value); }
    }

    public bool? Enabled
    {
        get { return JsonModel.GetNullableStruct<bool>(this.RawBodyData, "enabled"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "enabled", value);
        }
    }

    public Http? Http
    {
        get { return JsonModel.GetNullableClass<Http>(this.RawBodyData, "http"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "http", value);
        }
    }

    public Mcp? Mcp
    {
        get { return JsonModel.GetNullableClass<Mcp>(this.RawBodyData, "mcp"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "mcp", value);
        }
    }

    public string? Type
    {
        get { return JsonModel.GetNullableClass<string>(this.RawBodyData, "type"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "type", value);
        }
    }

    public WorkerCreateParams() { }

    public WorkerCreateParams(WorkerCreateParams workerCreateParams)
        : base(workerCreateParams)
    {
        this._rawBodyData = [.. workerCreateParams._rawBodyData];
    }

    public WorkerCreateParams(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData,
        IReadOnlyDictionary<string, JsonElement> rawBodyData
    )
    {
        this._rawHeaderData = [.. rawHeaderData];
        this._rawQueryData = [.. rawQueryData];
        this._rawBodyData = [.. rawBodyData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WorkerCreateParams(
        FrozenDictionary<string, JsonElement> rawHeaderData,
        FrozenDictionary<string, JsonElement> rawQueryData,
        FrozenDictionary<string, JsonElement> rawBodyData
    )
    {
        this._rawHeaderData = [.. rawHeaderData];
        this._rawQueryData = [.. rawQueryData];
        this._rawBodyData = [.. rawBodyData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="IFromRawJson.FromRawUnchecked"/>
    public static WorkerCreateParams FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData,
        IReadOnlyDictionary<string, JsonElement> rawBodyData
    )
    {
        return new(
            FrozenDictionary.ToFrozenDictionary(rawHeaderData),
            FrozenDictionary.ToFrozenDictionary(rawQueryData),
            FrozenDictionary.ToFrozenDictionary(rawBodyData)
        );
    }

    public override Uri Url(ClientOptions options)
    {
        return new UriBuilder(options.BaseUrl.ToString().TrimEnd('/') + "/v1/workers")
        {
            Query = this.QueryString(options),
        }.Uri;
    }

    internal override HttpContent? BodyContent()
    {
        return new StringContent(
            JsonSerializer.Serialize(this.RawBodyData),
            Encoding.UTF8,
            "application/json"
        );
    }

    internal override void AddHeadersToRequest(HttpRequestMessage request, ClientOptions options)
    {
        ParamsBase.AddDefaultHeaders(request, options);
        foreach (var item in this.RawHeaderData)
        {
            ParamsBase.AddHeaderElementToRequest(request, item.Key, item.Value);
        }
    }
}

[JsonConverter(typeof(JsonModelConverter<Http, HttpFromRaw>))]
public sealed record class Http : JsonModel
{
    public required long Retry
    {
        get { return JsonModel.GetNotNullStruct<long>(this.RawData, "retry"); }
        init { JsonModel.Set(this._rawData, "retry", value); }
    }

    public required string Secret
    {
        get { return JsonModel.GetNotNullClass<string>(this.RawData, "secret"); }
        init { JsonModel.Set(this._rawData, "secret", value); }
    }

    public required long Timeout
    {
        get { return JsonModel.GetNotNullStruct<long>(this.RawData, "timeout"); }
        init { JsonModel.Set(this._rawData, "timeout", value); }
    }

    public required string Uri
    {
        get { return JsonModel.GetNotNullClass<string>(this.RawData, "uri"); }
        init { JsonModel.Set(this._rawData, "uri", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Retry;
        _ = this.Secret;
        _ = this.Timeout;
        _ = this.Uri;
    }

    public Http() { }

    public Http(Http http)
        : base(http) { }

    public Http(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Http(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="HttpFromRaw.FromRawUnchecked"/>
    public static Http FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class HttpFromRaw : IFromRawJson<Http>
{
    /// <inheritdoc/>
    public Http FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Http.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Mcp, McpFromRaw>))]
public sealed record class Mcp : JsonModel
{
    public required long Retry
    {
        get { return JsonModel.GetNotNullStruct<long>(this.RawData, "retry"); }
        init { JsonModel.Set(this._rawData, "retry", value); }
    }

    public required long Timeout
    {
        get { return JsonModel.GetNotNullStruct<long>(this.RawData, "timeout"); }
        init { JsonModel.Set(this._rawData, "timeout", value); }
    }

    public required string Uri
    {
        get { return JsonModel.GetNotNullClass<string>(this.RawData, "uri"); }
        init { JsonModel.Set(this._rawData, "uri", value); }
    }

    public IReadOnlyDictionary<string, string>? Headers
    {
        get
        {
            return JsonModel.GetNullableClass<Dictionary<string, string>>(this.RawData, "headers");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "headers", value);
        }
    }

    public Oauth2? Oauth2
    {
        get { return JsonModel.GetNullableClass<Oauth2>(this.RawData, "oauth2"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "oauth2", value);
        }
    }

    public IReadOnlyDictionary<string, string>? Secrets
    {
        get
        {
            return JsonModel.GetNullableClass<Dictionary<string, string>>(this.RawData, "secrets");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "secrets", value);
        }
    }

    /// <inheritdoc/>
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

    public Mcp(Mcp mcp)
        : base(mcp) { }

    public Mcp(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Mcp(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="McpFromRaw.FromRawUnchecked"/>
    public static Mcp FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class McpFromRaw : IFromRawJson<Mcp>
{
    /// <inheritdoc/>
    public Mcp FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Mcp.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Oauth2, Oauth2FromRaw>))]
public sealed record class Oauth2 : JsonModel
{
    public string? AuthorizationUrl
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "authorization_url"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "authorization_url", value);
        }
    }

    public string? ClientID
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "client_id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "client_id", value);
        }
    }

    public string? ClientSecret
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "client_secret"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "client_secret", value);
        }
    }

    public string? ExternalID
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "external_id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "external_id", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.AuthorizationUrl;
        _ = this.ClientID;
        _ = this.ClientSecret;
        _ = this.ExternalID;
    }

    public Oauth2() { }

    public Oauth2(Oauth2 oauth2)
        : base(oauth2) { }

    public Oauth2(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Oauth2(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="Oauth2FromRaw.FromRawUnchecked"/>
    public static Oauth2 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class Oauth2FromRaw : IFromRawJson<Oauth2>
{
    /// <inheritdoc/>
    public Oauth2 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Oauth2.FromRawUnchecked(rawData);
}
