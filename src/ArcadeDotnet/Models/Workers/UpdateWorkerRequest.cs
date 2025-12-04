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

    public UpdateWorkerRequestHTTP? HTTP
    {
        get { return ModelBase.GetNullableClass<UpdateWorkerRequestHTTP>(this.RawData, "http"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "http", value);
        }
    }

    public UpdateWorkerRequestMcp? Mcp
    {
        get { return ModelBase.GetNullableClass<UpdateWorkerRequestMcp>(this.RawData, "mcp"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "mcp", value);
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

class UpdateWorkerRequestFromRaw : IFromRaw<UpdateWorkerRequest>
{
    /// <inheritdoc/>
    public UpdateWorkerRequest FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        UpdateWorkerRequest.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ModelConverter<UpdateWorkerRequestHTTP, UpdateWorkerRequestHTTPFromRaw>))]
public sealed record class UpdateWorkerRequestHTTP : ModelBase
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

    /// <inheritdoc cref="UpdateWorkerRequestHTTPFromRaw.FromRawUnchecked"/>
    public static UpdateWorkerRequestHTTP FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class UpdateWorkerRequestHTTPFromRaw : IFromRaw<UpdateWorkerRequestHTTP>
{
    /// <inheritdoc/>
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

    public UpdateWorkerRequestMcpOauth2? Oauth2
    {
        get
        {
            return ModelBase.GetNullableClass<UpdateWorkerRequestMcpOauth2>(this.RawData, "oauth2");
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

    /// <inheritdoc cref="UpdateWorkerRequestMcpFromRaw.FromRawUnchecked"/>
    public static UpdateWorkerRequestMcp FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class UpdateWorkerRequestMcpFromRaw : IFromRaw<UpdateWorkerRequestMcp>
{
    /// <inheritdoc/>
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

    /// <inheritdoc cref="UpdateWorkerRequestMcpOauth2FromRaw.FromRawUnchecked"/>
    public static UpdateWorkerRequestMcpOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class UpdateWorkerRequestMcpOauth2FromRaw : IFromRaw<UpdateWorkerRequestMcpOauth2>
{
    /// <inheritdoc/>
    public UpdateWorkerRequestMcpOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => UpdateWorkerRequestMcpOauth2.FromRawUnchecked(rawData);
}
