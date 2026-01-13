using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Workers;

[JsonConverter(typeof(JsonModelConverter<CreateWorkerRequest, CreateWorkerRequestFromRaw>))]
public sealed record class CreateWorkerRequest : JsonModel
{
    public required string ID
    {
        get { return this._rawData.GetNotNullClass<string>("id"); }
        init { this._rawData.Set("id", value); }
    }

    public bool? Enabled
    {
        get { return this._rawData.GetNullableStruct<bool>("enabled"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("enabled", value);
        }
    }

    public CreateWorkerRequestHttp? Http
    {
        get { return this._rawData.GetNullableClass<CreateWorkerRequestHttp>("http"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("http", value);
        }
    }

    public CreateWorkerRequestMcp? Mcp
    {
        get { return this._rawData.GetNullableClass<CreateWorkerRequestMcp>("mcp"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("mcp", value);
        }
    }

    public string? Type
    {
        get { return this._rawData.GetNullableClass<string>("type"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("type", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.Enabled;
        this.Http?.Validate();
        this.Mcp?.Validate();
        _ = this.Type;
    }

    public CreateWorkerRequest() { }

    public CreateWorkerRequest(CreateWorkerRequest createWorkerRequest)
        : base(createWorkerRequest) { }

    public CreateWorkerRequest(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CreateWorkerRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CreateWorkerRequestFromRaw.FromRawUnchecked"/>
    public static CreateWorkerRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public CreateWorkerRequest(string id)
        : this()
    {
        this.ID = id;
    }
}

class CreateWorkerRequestFromRaw : IFromRawJson<CreateWorkerRequest>
{
    /// <inheritdoc/>
    public CreateWorkerRequest FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        CreateWorkerRequest.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<CreateWorkerRequestHttp, CreateWorkerRequestHttpFromRaw>))]
public sealed record class CreateWorkerRequestHttp : JsonModel
{
    public required long Retry
    {
        get { return this._rawData.GetNotNullStruct<long>("retry"); }
        init { this._rawData.Set("retry", value); }
    }

    public required string Secret
    {
        get { return this._rawData.GetNotNullClass<string>("secret"); }
        init { this._rawData.Set("secret", value); }
    }

    public required long Timeout
    {
        get { return this._rawData.GetNotNullStruct<long>("timeout"); }
        init { this._rawData.Set("timeout", value); }
    }

    public required string Uri
    {
        get { return this._rawData.GetNotNullClass<string>("uri"); }
        init { this._rawData.Set("uri", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Retry;
        _ = this.Secret;
        _ = this.Timeout;
        _ = this.Uri;
    }

    public CreateWorkerRequestHttp() { }

    public CreateWorkerRequestHttp(CreateWorkerRequestHttp createWorkerRequestHttp)
        : base(createWorkerRequestHttp) { }

    public CreateWorkerRequestHttp(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CreateWorkerRequestHttp(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CreateWorkerRequestHttpFromRaw.FromRawUnchecked"/>
    public static CreateWorkerRequestHttp FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CreateWorkerRequestHttpFromRaw : IFromRawJson<CreateWorkerRequestHttp>
{
    /// <inheritdoc/>
    public CreateWorkerRequestHttp FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => CreateWorkerRequestHttp.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<CreateWorkerRequestMcp, CreateWorkerRequestMcpFromRaw>))]
public sealed record class CreateWorkerRequestMcp : JsonModel
{
    public required long Retry
    {
        get { return this._rawData.GetNotNullStruct<long>("retry"); }
        init { this._rawData.Set("retry", value); }
    }

    public required long Timeout
    {
        get { return this._rawData.GetNotNullStruct<long>("timeout"); }
        init { this._rawData.Set("timeout", value); }
    }

    public required string Uri
    {
        get { return this._rawData.GetNotNullClass<string>("uri"); }
        init { this._rawData.Set("uri", value); }
    }

    public IReadOnlyDictionary<string, string>? Headers
    {
        get { return this._rawData.GetNullableClass<FrozenDictionary<string, string>>("headers"); }
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

    public CreateWorkerRequestMcpOauth2? Oauth2
    {
        get { return this._rawData.GetNullableClass<CreateWorkerRequestMcpOauth2>("oauth2"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("oauth2", value);
        }
    }

    public IReadOnlyDictionary<string, string>? Secrets
    {
        get { return this._rawData.GetNullableClass<FrozenDictionary<string, string>>("secrets"); }
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

    public CreateWorkerRequestMcp() { }

    public CreateWorkerRequestMcp(CreateWorkerRequestMcp createWorkerRequestMcp)
        : base(createWorkerRequestMcp) { }

    public CreateWorkerRequestMcp(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CreateWorkerRequestMcp(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CreateWorkerRequestMcpFromRaw.FromRawUnchecked"/>
    public static CreateWorkerRequestMcp FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CreateWorkerRequestMcpFromRaw : IFromRawJson<CreateWorkerRequestMcp>
{
    /// <inheritdoc/>
    public CreateWorkerRequestMcp FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => CreateWorkerRequestMcp.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<CreateWorkerRequestMcpOauth2, CreateWorkerRequestMcpOauth2FromRaw>)
)]
public sealed record class CreateWorkerRequestMcpOauth2 : JsonModel
{
    public string? AuthorizationUrl
    {
        get { return this._rawData.GetNullableClass<string>("authorization_url"); }
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
        get { return this._rawData.GetNullableClass<string>("client_id"); }
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
        get { return this._rawData.GetNullableClass<string>("client_secret"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("client_secret", value);
        }
    }

    public string? ExternalID
    {
        get { return this._rawData.GetNullableClass<string>("external_id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("external_id", value);
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

    public CreateWorkerRequestMcpOauth2() { }

    public CreateWorkerRequestMcpOauth2(CreateWorkerRequestMcpOauth2 createWorkerRequestMcpOauth2)
        : base(createWorkerRequestMcpOauth2) { }

    public CreateWorkerRequestMcpOauth2(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CreateWorkerRequestMcpOauth2(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CreateWorkerRequestMcpOauth2FromRaw.FromRawUnchecked"/>
    public static CreateWorkerRequestMcpOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CreateWorkerRequestMcpOauth2FromRaw : IFromRawJson<CreateWorkerRequestMcpOauth2>
{
    /// <inheritdoc/>
    public CreateWorkerRequestMcpOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => CreateWorkerRequestMcpOauth2.FromRawUnchecked(rawData);
}
