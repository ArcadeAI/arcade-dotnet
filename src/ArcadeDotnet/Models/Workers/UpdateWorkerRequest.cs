using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Workers;

[JsonConverter(typeof(JsonModelConverter<UpdateWorkerRequest, UpdateWorkerRequestFromRaw>))]
public sealed record class UpdateWorkerRequest : JsonModel
{
    public bool? Enabled
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("enabled");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("enabled", value);
        }
    }

    public UpdateWorkerRequestHttp? Http
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<UpdateWorkerRequestHttp>("http");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("http", value);
        }
    }

    public UpdateWorkerRequestMcp? Mcp
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<UpdateWorkerRequestMcp>("mcp");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("mcp", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Enabled;
        this.Http?.Validate();
        this.Mcp?.Validate();
    }

    public UpdateWorkerRequest() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public UpdateWorkerRequest(UpdateWorkerRequest updateWorkerRequest)
        : base(updateWorkerRequest) { }
#pragma warning restore CS8618

    public UpdateWorkerRequest(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    UpdateWorkerRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="UpdateWorkerRequestFromRaw.FromRawUnchecked"/>
    public static UpdateWorkerRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class UpdateWorkerRequestFromRaw : IFromRawJson<UpdateWorkerRequest>
{
    /// <inheritdoc/>
    public UpdateWorkerRequest FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        UpdateWorkerRequest.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<UpdateWorkerRequestHttp, UpdateWorkerRequestHttpFromRaw>))]
public sealed record class UpdateWorkerRequestHttp : JsonModel
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

    public UpdateWorkerRequestHttp() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public UpdateWorkerRequestHttp(UpdateWorkerRequestHttp updateWorkerRequestHttp)
        : base(updateWorkerRequestHttp) { }
#pragma warning restore CS8618

    public UpdateWorkerRequestHttp(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    UpdateWorkerRequestHttp(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="UpdateWorkerRequestHttpFromRaw.FromRawUnchecked"/>
    public static UpdateWorkerRequestHttp FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class UpdateWorkerRequestHttpFromRaw : IFromRawJson<UpdateWorkerRequestHttp>
{
    /// <inheritdoc/>
    public UpdateWorkerRequestHttp FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => UpdateWorkerRequestHttp.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<UpdateWorkerRequestMcp, UpdateWorkerRequestMcpFromRaw>))]
public sealed record class UpdateWorkerRequestMcp : JsonModel
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

    public UpdateWorkerRequestMcpOauth2? Oauth2
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<UpdateWorkerRequestMcpOauth2>("oauth2");
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

    public UpdateWorkerRequestMcp() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public UpdateWorkerRequestMcp(UpdateWorkerRequestMcp updateWorkerRequestMcp)
        : base(updateWorkerRequestMcp) { }
#pragma warning restore CS8618

    public UpdateWorkerRequestMcp(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    UpdateWorkerRequestMcp(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="UpdateWorkerRequestMcpFromRaw.FromRawUnchecked"/>
    public static UpdateWorkerRequestMcp FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class UpdateWorkerRequestMcpFromRaw : IFromRawJson<UpdateWorkerRequestMcp>
{
    /// <inheritdoc/>
    public UpdateWorkerRequestMcp FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => UpdateWorkerRequestMcp.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<UpdateWorkerRequestMcpOauth2, UpdateWorkerRequestMcpOauth2FromRaw>)
)]
public sealed record class UpdateWorkerRequestMcpOauth2 : JsonModel
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

    public UpdateWorkerRequestMcpOauth2() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public UpdateWorkerRequestMcpOauth2(UpdateWorkerRequestMcpOauth2 updateWorkerRequestMcpOauth2)
        : base(updateWorkerRequestMcpOauth2) { }
#pragma warning restore CS8618

    public UpdateWorkerRequestMcpOauth2(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    UpdateWorkerRequestMcpOauth2(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="UpdateWorkerRequestMcpOauth2FromRaw.FromRawUnchecked"/>
    public static UpdateWorkerRequestMcpOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class UpdateWorkerRequestMcpOauth2FromRaw : IFromRawJson<UpdateWorkerRequestMcpOauth2>
{
    /// <inheritdoc/>
    public UpdateWorkerRequestMcpOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => UpdateWorkerRequestMcpOauth2.FromRawUnchecked(rawData);
}
