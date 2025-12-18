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

    public UpdateWorkerRequestHTTP? HTTP
    {
        get { return JsonModel.GetNullableClass<UpdateWorkerRequestHTTP>(this.RawData, "http"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "http", value);
        }
    }

    public UpdateWorkerRequestMcp? Mcp
    {
        get { return JsonModel.GetNullableClass<UpdateWorkerRequestMcp>(this.RawData, "mcp"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "mcp", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Enabled;
        this.HTTP?.Validate();
        this.Mcp?.Validate();
    }

    public UpdateWorkerRequest() { }

    public UpdateWorkerRequest(UpdateWorkerRequest updateWorkerRequest)
        : base(updateWorkerRequest) { }

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

[JsonConverter(typeof(JsonModelConverter<UpdateWorkerRequestHTTP, UpdateWorkerRequestHTTPFromRaw>))]
public sealed record class UpdateWorkerRequestHTTP : JsonModel
{
    public long? Retry
    {
        get { return JsonModel.GetNullableStruct<long>(this.RawData, "retry"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "retry", value);
        }
    }

    public string? Secret
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "secret"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "secret", value);
        }
    }

    public long? Timeout
    {
        get { return JsonModel.GetNullableStruct<long>(this.RawData, "timeout"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "timeout", value);
        }
    }

    public string? Uri
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "uri"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "uri", value);
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

    public UpdateWorkerRequestHTTP() { }

    public UpdateWorkerRequestHTTP(UpdateWorkerRequestHTTP updateWorkerRequestHTTP)
        : base(updateWorkerRequestHTTP) { }

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

    /// <inheritdoc cref="UpdateWorkerRequestHTTPFromRaw.FromRawUnchecked"/>
    public static UpdateWorkerRequestHTTP FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class UpdateWorkerRequestHTTPFromRaw : IFromRawJson<UpdateWorkerRequestHTTP>
{
    /// <inheritdoc/>
    public UpdateWorkerRequestHTTP FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => UpdateWorkerRequestHTTP.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<UpdateWorkerRequestMcp, UpdateWorkerRequestMcpFromRaw>))]
public sealed record class UpdateWorkerRequestMcp : JsonModel
{
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

    public UpdateWorkerRequestMcpOauth2? Oauth2
    {
        get
        {
            return JsonModel.GetNullableClass<UpdateWorkerRequestMcpOauth2>(this.RawData, "oauth2");
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

    public long? Retry
    {
        get { return JsonModel.GetNullableStruct<long>(this.RawData, "retry"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "retry", value);
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

    public long? Timeout
    {
        get { return JsonModel.GetNullableStruct<long>(this.RawData, "timeout"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "timeout", value);
        }
    }

    public string? Uri
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "uri"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "uri", value);
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

    public UpdateWorkerRequestMcp(UpdateWorkerRequestMcp updateWorkerRequestMcp)
        : base(updateWorkerRequestMcp) { }

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
    public string? AuthorizationURL
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

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.AuthorizationURL;
        _ = this.ClientID;
        _ = this.ClientSecret;
    }

    public UpdateWorkerRequestMcpOauth2() { }

    public UpdateWorkerRequestMcpOauth2(UpdateWorkerRequestMcpOauth2 updateWorkerRequestMcpOauth2)
        : base(updateWorkerRequestMcpOauth2) { }

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
