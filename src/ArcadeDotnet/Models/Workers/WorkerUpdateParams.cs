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
/// Update a worker
/// </summary>
public sealed record class WorkerUpdateParams : ParamsBase
{
    readonly FreezableDictionary<string, JsonElement> _rawBodyData = [];
    public IReadOnlyDictionary<string, JsonElement> RawBodyData
    {
        get { return this._rawBodyData.Freeze(); }
    }

    public string? ID { get; init; }

    public bool? Enabled
    {
        get { return ModelBase.GetNullableStruct<bool>(this.RawBodyData, "enabled"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawBodyData, "enabled", value);
        }
    }

    public WorkerUpdateParamsHTTP? HTTP
    {
        get { return ModelBase.GetNullableClass<WorkerUpdateParamsHTTP>(this.RawBodyData, "http"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawBodyData, "http", value);
        }
    }

    public WorkerUpdateParamsMcp? Mcp
    {
        get { return ModelBase.GetNullableClass<WorkerUpdateParamsMcp>(this.RawBodyData, "mcp"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawBodyData, "mcp", value);
        }
    }

    public WorkerUpdateParams() { }

    public WorkerUpdateParams(
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
    WorkerUpdateParams(
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

    /// <inheritdoc cref="IFromRaw.FromRawUnchecked"/>
    public static WorkerUpdateParams FromRawUnchecked(
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
        return new UriBuilder(
            options.BaseUrl.ToString().TrimEnd('/') + string.Format("/v1/workers/{0}", this.ID)
        )
        {
            Query = this.QueryString(options),
        }.Uri;
    }

    internal override StringContent? BodyContent()
    {
        return new(JsonSerializer.Serialize(this.RawBodyData), Encoding.UTF8, "application/json");
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

[JsonConverter(typeof(ModelConverter<WorkerUpdateParamsHTTP, WorkerUpdateParamsHTTPFromRaw>))]
public sealed record class WorkerUpdateParamsHTTP : ModelBase
{
    public long? Retry
    {
        get { return ModelBase.GetNullableStruct<long>(this.RawData, "retry"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "retry", value);
        }
    }

    public string? Secret
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "secret"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "secret", value);
        }
    }

    public long? Timeout
    {
        get { return ModelBase.GetNullableStruct<long>(this.RawData, "timeout"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "timeout", value);
        }
    }

    public string? Uri
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "uri"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "uri", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Retry;
        _ = this.Secret;
        _ = this.Timeout;
        _ = this.Uri;
    }

    public WorkerUpdateParamsHTTP() { }

    public WorkerUpdateParamsHTTP(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WorkerUpdateParamsHTTP(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="WorkerUpdateParamsHTTPFromRaw.FromRawUnchecked"/>
    public static WorkerUpdateParamsHTTP FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class WorkerUpdateParamsHTTPFromRaw : IFromRaw<WorkerUpdateParamsHTTP>
{
    /// <inheritdoc/>
    public WorkerUpdateParamsHTTP FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => WorkerUpdateParamsHTTP.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ModelConverter<WorkerUpdateParamsMcp, WorkerUpdateParamsMcpFromRaw>))]
public sealed record class WorkerUpdateParamsMcp : ModelBase
{
    public IReadOnlyDictionary<string, string>? Headers
    {
        get
        {
            return ModelBase.GetNullableClass<Dictionary<string, string>>(this.RawData, "headers");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "headers", value);
        }
    }

    public WorkerUpdateParamsMcpOauth2? Oauth2
    {
        get
        {
            return ModelBase.GetNullableClass<WorkerUpdateParamsMcpOauth2>(this.RawData, "oauth2");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "oauth2", value);
        }
    }

    public long? Retry
    {
        get { return ModelBase.GetNullableStruct<long>(this.RawData, "retry"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "retry", value);
        }
    }

    public IReadOnlyDictionary<string, string>? Secrets
    {
        get
        {
            return ModelBase.GetNullableClass<Dictionary<string, string>>(this.RawData, "secrets");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "secrets", value);
        }
    }

    public long? Timeout
    {
        get { return ModelBase.GetNullableStruct<long>(this.RawData, "timeout"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "timeout", value);
        }
    }

    public string? Uri
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "uri"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "uri", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Headers;
        this.Oauth2?.Validate();
        _ = this.Retry;
        _ = this.Secrets;
        _ = this.Timeout;
        _ = this.Uri;
    }

    public WorkerUpdateParamsMcp() { }

    public WorkerUpdateParamsMcp(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WorkerUpdateParamsMcp(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="WorkerUpdateParamsMcpFromRaw.FromRawUnchecked"/>
    public static WorkerUpdateParamsMcp FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class WorkerUpdateParamsMcpFromRaw : IFromRaw<WorkerUpdateParamsMcp>
{
    /// <inheritdoc/>
    public WorkerUpdateParamsMcp FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => WorkerUpdateParamsMcp.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(ModelConverter<WorkerUpdateParamsMcpOauth2, WorkerUpdateParamsMcpOauth2FromRaw>)
)]
public sealed record class WorkerUpdateParamsMcpOauth2 : ModelBase
{
    public string? AuthorizationURL
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "authorization_url"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "authorization_url", value);
        }
    }

    public string? ClientID
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "client_id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "client_id", value);
        }
    }

    public string? ClientSecret
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "client_secret"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "client_secret", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.AuthorizationURL;
        _ = this.ClientID;
        _ = this.ClientSecret;
    }

    public WorkerUpdateParamsMcpOauth2() { }

    public WorkerUpdateParamsMcpOauth2(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WorkerUpdateParamsMcpOauth2(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="WorkerUpdateParamsMcpOauth2FromRaw.FromRawUnchecked"/>
    public static WorkerUpdateParamsMcpOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class WorkerUpdateParamsMcpOauth2FromRaw : IFromRaw<WorkerUpdateParamsMcpOauth2>
{
    /// <inheritdoc/>
    public WorkerUpdateParamsMcpOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => WorkerUpdateParamsMcpOauth2.FromRawUnchecked(rawData);
}
