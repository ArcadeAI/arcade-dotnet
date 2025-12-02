using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Workers;

[JsonConverter(typeof(ModelConverter<CreateWorkerRequest, CreateWorkerRequestFromRaw>))]
public sealed record class CreateWorkerRequest : ModelBase
{
    public required string ID
    {
        get { return ModelBase.GetNotNullClass<string>(this.RawData, "id"); }
        init { ModelBase.Set(this._rawData, "id", value); }
    }

    public bool? Enabled
    {
        get { return ModelBase.GetNullableStruct<bool>(this.RawData, "enabled"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "enabled", value);
        }
    }

    public CreateWorkerRequestHTTP? HTTP
    {
        get { return ModelBase.GetNullableClass<CreateWorkerRequestHTTP>(this.RawData, "http"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "http", value);
        }
    }

    public CreateWorkerRequestMcp? Mcp
    {
        get { return ModelBase.GetNullableClass<CreateWorkerRequestMcp>(this.RawData, "mcp"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "mcp", value);
        }
    }

    public string? Type
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "type"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "type", value);
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

class CreateWorkerRequestFromRaw : IFromRaw<CreateWorkerRequest>
{
    public CreateWorkerRequest FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        CreateWorkerRequest.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ModelConverter<CreateWorkerRequestHTTP, CreateWorkerRequestHTTPFromRaw>))]
public sealed record class CreateWorkerRequestHTTP : ModelBase
{
    public required long Retry
    {
        get { return ModelBase.GetNotNullStruct<long>(this.RawData, "retry"); }
        init { ModelBase.Set(this._rawData, "retry", value); }
    }

    public required string Secret
    {
        get { return ModelBase.GetNotNullClass<string>(this.RawData, "secret"); }
        init { ModelBase.Set(this._rawData, "secret", value); }
    }

    public required long Timeout
    {
        get { return ModelBase.GetNotNullStruct<long>(this.RawData, "timeout"); }
        init { ModelBase.Set(this._rawData, "timeout", value); }
    }

    public required string Uri
    {
        get { return ModelBase.GetNotNullClass<string>(this.RawData, "uri"); }
        init { ModelBase.Set(this._rawData, "uri", value); }
    }

    public override void Validate()
    {
        _ = this.Retry;
        _ = this.Secret;
        _ = this.Timeout;
        _ = this.Uri;
    }

    public CreateWorkerRequestHTTP() { }

    public CreateWorkerRequestHTTP(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CreateWorkerRequestHTTP(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    public static CreateWorkerRequestHTTP FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CreateWorkerRequestHTTPFromRaw : IFromRaw<CreateWorkerRequestHTTP>
{
    public CreateWorkerRequestHTTP FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => CreateWorkerRequestHTTP.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ModelConverter<CreateWorkerRequestMcp, CreateWorkerRequestMcpFromRaw>))]
public sealed record class CreateWorkerRequestMcp : ModelBase
{
    public required long Retry
    {
        get { return ModelBase.GetNotNullStruct<long>(this.RawData, "retry"); }
        init { ModelBase.Set(this._rawData, "retry", value); }
    }

    public required long Timeout
    {
        get { return ModelBase.GetNotNullStruct<long>(this.RawData, "timeout"); }
        init { ModelBase.Set(this._rawData, "timeout", value); }
    }

    public required string Uri
    {
        get { return ModelBase.GetNotNullClass<string>(this.RawData, "uri"); }
        init { ModelBase.Set(this._rawData, "uri", value); }
    }

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

    public CreateWorkerRequestMcpOauth2? Oauth2
    {
        get
        {
            return ModelBase.GetNullableClass<CreateWorkerRequestMcpOauth2>(this.RawData, "oauth2");
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

    public static CreateWorkerRequestMcp FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CreateWorkerRequestMcpFromRaw : IFromRaw<CreateWorkerRequestMcp>
{
    public CreateWorkerRequestMcp FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => CreateWorkerRequestMcp.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(ModelConverter<CreateWorkerRequestMcpOauth2, CreateWorkerRequestMcpOauth2FromRaw>)
)]
public sealed record class CreateWorkerRequestMcpOauth2 : ModelBase
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

    public string? ExternalID
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "external_id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "external_id", value);
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

    public static CreateWorkerRequestMcpOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CreateWorkerRequestMcpOauth2FromRaw : IFromRaw<CreateWorkerRequestMcpOauth2>
{
    public CreateWorkerRequestMcpOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => CreateWorkerRequestMcpOauth2.FromRawUnchecked(rawData);
}
