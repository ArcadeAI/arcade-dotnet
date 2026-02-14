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
///
/// <para>NOTE: Do not inherit from this type outside the SDK unless you're okay with
/// breaking changes in non-major versions. We may add new methods in the future that
/// cause existing derived classes to break.</para>
/// </summary>
public record class WorkerUpdateParams : ParamsBase
{
    readonly JsonDictionary _rawBodyData = new();
    public IReadOnlyDictionary<string, JsonElement> RawBodyData
    {
        get { return this._rawBodyData.Freeze(); }
    }

    public string? ID { get; init; }

    public bool? Enabled
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableStruct<bool>("enabled");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData.Set("enabled", value);
        }
    }

    public WorkerUpdateParamsHttp? Http
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableClass<WorkerUpdateParamsHttp>("http");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData.Set("http", value);
        }
    }

    public WorkerUpdateParamsMcp? Mcp
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableClass<WorkerUpdateParamsMcp>("mcp");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData.Set("mcp", value);
        }
    }

    public WorkerUpdateParams() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public WorkerUpdateParams(WorkerUpdateParams workerUpdateParams)
        : base(workerUpdateParams)
    {
        this.ID = workerUpdateParams.ID;

        this._rawBodyData = new(workerUpdateParams._rawBodyData);
    }
#pragma warning restore CS8618

    public WorkerUpdateParams(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData,
        IReadOnlyDictionary<string, JsonElement> rawBodyData
    )
    {
        this._rawHeaderData = new(rawHeaderData);
        this._rawQueryData = new(rawQueryData);
        this._rawBodyData = new(rawBodyData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WorkerUpdateParams(
        FrozenDictionary<string, JsonElement> rawHeaderData,
        FrozenDictionary<string, JsonElement> rawQueryData,
        FrozenDictionary<string, JsonElement> rawBodyData
    )
    {
        this._rawHeaderData = new(rawHeaderData);
        this._rawQueryData = new(rawQueryData);
        this._rawBodyData = new(rawBodyData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="IFromRawJson.FromRawUnchecked"/>
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

    public override string ToString() =>
        JsonSerializer.Serialize(
            FriendlyJsonPrinter.PrintValue(
                new Dictionary<string, JsonElement>()
                {
                    ["ID"] = JsonSerializer.SerializeToElement(this.ID),
                    ["HeaderData"] = FriendlyJsonPrinter.PrintValue(
                        JsonSerializer.SerializeToElement(this._rawHeaderData.Freeze())
                    ),
                    ["QueryData"] = FriendlyJsonPrinter.PrintValue(
                        JsonSerializer.SerializeToElement(this._rawQueryData.Freeze())
                    ),
                    ["BodyData"] = FriendlyJsonPrinter.PrintValue(this._rawBodyData.Freeze()),
                }
            ),
            ModelBase.ToStringSerializerOptions
        );

    public virtual bool Equals(WorkerUpdateParams? other)
    {
        if (other == null)
        {
            return false;
        }
        return (this.ID?.Equals(other.ID) ?? other.ID == null)
            && this._rawHeaderData.Equals(other._rawHeaderData)
            && this._rawQueryData.Equals(other._rawQueryData)
            && this._rawBodyData.Equals(other._rawBodyData);
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

    internal override HttpContent? BodyContent()
    {
        return new StringContent(
            JsonSerializer.Serialize(this.RawBodyData, ModelBase.SerializerOptions),
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

    public override int GetHashCode()
    {
        return 0;
    }
}

[JsonConverter(typeof(JsonModelConverter<WorkerUpdateParamsHttp, WorkerUpdateParamsHttpFromRaw>))]
public sealed record class WorkerUpdateParamsHttp : JsonModel
{
    public long? Retry
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<long>("retry");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("retry", value);
        }
    }

    public string? Secret
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("secret");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("secret", value);
        }
    }

    public long? Timeout
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<long>("timeout");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("timeout", value);
        }
    }

    public string? Uri
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("uri");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("uri", value);
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

    public WorkerUpdateParamsHttp() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public WorkerUpdateParamsHttp(WorkerUpdateParamsHttp workerUpdateParamsHttp)
        : base(workerUpdateParamsHttp) { }
#pragma warning restore CS8618

    public WorkerUpdateParamsHttp(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WorkerUpdateParamsHttp(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="WorkerUpdateParamsHttpFromRaw.FromRawUnchecked"/>
    public static WorkerUpdateParamsHttp FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class WorkerUpdateParamsHttpFromRaw : IFromRawJson<WorkerUpdateParamsHttp>
{
    /// <inheritdoc/>
    public WorkerUpdateParamsHttp FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => WorkerUpdateParamsHttp.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<WorkerUpdateParamsMcp, WorkerUpdateParamsMcpFromRaw>))]
public sealed record class WorkerUpdateParamsMcp : JsonModel
{
    public IReadOnlyDictionary<string, string>? Headers
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<FrozenDictionary<string, string>>("headers");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<FrozenDictionary<string, string>?>(
                "headers",
                value == null ? null : FrozenDictionary.ToFrozenDictionary(value)
            );
        }
    }

    public WorkerUpdateParamsMcpOauth2? Oauth2
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<WorkerUpdateParamsMcpOauth2>("oauth2");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("oauth2", value);
        }
    }

    public long? Retry
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<long>("retry");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("retry", value);
        }
    }

    public IReadOnlyDictionary<string, string>? Secrets
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<FrozenDictionary<string, string>>("secrets");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<FrozenDictionary<string, string>?>(
                "secrets",
                value == null ? null : FrozenDictionary.ToFrozenDictionary(value)
            );
        }
    }

    public long? Timeout
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<long>("timeout");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("timeout", value);
        }
    }

    public string? Uri
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("uri");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("uri", value);
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

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public WorkerUpdateParamsMcp(WorkerUpdateParamsMcp workerUpdateParamsMcp)
        : base(workerUpdateParamsMcp) { }
#pragma warning restore CS8618

    public WorkerUpdateParamsMcp(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WorkerUpdateParamsMcp(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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

class WorkerUpdateParamsMcpFromRaw : IFromRawJson<WorkerUpdateParamsMcp>
{
    /// <inheritdoc/>
    public WorkerUpdateParamsMcp FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => WorkerUpdateParamsMcp.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<WorkerUpdateParamsMcpOauth2, WorkerUpdateParamsMcpOauth2FromRaw>)
)]
public sealed record class WorkerUpdateParamsMcpOauth2 : JsonModel
{
    public string? AuthorizationUrl
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("authorization_url");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("authorization_url", value);
        }
    }

    public string? ClientID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("client_id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("client_id", value);
        }
    }

    public string? ClientSecret
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("client_secret");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("client_secret", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.AuthorizationUrl;
        _ = this.ClientID;
        _ = this.ClientSecret;
    }

    public WorkerUpdateParamsMcpOauth2() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public WorkerUpdateParamsMcpOauth2(WorkerUpdateParamsMcpOauth2 workerUpdateParamsMcpOauth2)
        : base(workerUpdateParamsMcpOauth2) { }
#pragma warning restore CS8618

    public WorkerUpdateParamsMcpOauth2(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WorkerUpdateParamsMcpOauth2(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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

class WorkerUpdateParamsMcpOauth2FromRaw : IFromRawJson<WorkerUpdateParamsMcpOauth2>
{
    /// <inheritdoc/>
    public WorkerUpdateParamsMcpOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => WorkerUpdateParamsMcpOauth2.FromRawUnchecked(rawData);
}
