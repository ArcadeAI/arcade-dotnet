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
        get { return JsonModel.GetNotNullClass<string>(this.RawData, "id"); }
        init { JsonModel.Set(this._rawData, "id", value); }
    }

    public bool? Enabled
    {
        get { return JsonModel.GetNullableStruct<bool>(this.RawData, "enabled"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "enabled", value);
        }
    }

    public CreateWorkerRequestHttp? Http
    {
        get { return JsonModel.GetNullableClass<CreateWorkerRequestHttp>(this.RawData, "http"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "http", value);
        }
    }

    public CreateWorkerRequestMcp? Mcp
    {
        get { return JsonModel.GetNullableClass<CreateWorkerRequestMcp>(this.RawData, "mcp"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "mcp", value);
        }
    }

    public string? Type
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "type"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "type", value);
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CreateWorkerRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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

    public CreateWorkerRequestHttp() { }

    public CreateWorkerRequestHttp(CreateWorkerRequestHttp createWorkerRequestHttp)
        : base(createWorkerRequestHttp) { }

    public CreateWorkerRequestHttp(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CreateWorkerRequestHttp(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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

    public CreateWorkerRequestMcpOauth2? Oauth2
    {
        get
        {
            return JsonModel.GetNullableClass<CreateWorkerRequestMcpOauth2>(this.RawData, "oauth2");
        }
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

    public CreateWorkerRequestMcp() { }

    public CreateWorkerRequestMcp(CreateWorkerRequestMcp createWorkerRequestMcp)
        : base(createWorkerRequestMcp) { }

    public CreateWorkerRequestMcp(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CreateWorkerRequestMcp(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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

    public CreateWorkerRequestMcpOauth2() { }

    public CreateWorkerRequestMcpOauth2(CreateWorkerRequestMcpOauth2 createWorkerRequestMcpOauth2)
        : base(createWorkerRequestMcpOauth2) { }

    public CreateWorkerRequestMcpOauth2(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CreateWorkerRequestMcpOauth2(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
