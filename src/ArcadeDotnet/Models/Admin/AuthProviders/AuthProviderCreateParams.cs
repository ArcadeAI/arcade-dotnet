using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using System = System;

namespace ArcadeDotnet.Models.Admin.AuthProviders;

/// <summary>
/// Create a new auth provider
/// </summary>
public sealed record class AuthProviderCreateParams : ParamsBase
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

    public string? Description
    {
        get { return JsonModel.GetNullableClass<string>(this.RawBodyData, "description"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "description", value);
        }
    }

    /// <summary>
    /// The unique external ID for the auth provider
    /// </summary>
    public string? ExternalID
    {
        get { return JsonModel.GetNullableClass<string>(this.RawBodyData, "external_id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "external_id", value);
        }
    }

    public Oauth2? Oauth2
    {
        get { return JsonModel.GetNullableClass<Oauth2>(this.RawBodyData, "oauth2"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "oauth2", value);
        }
    }

    public string? ProviderID
    {
        get { return JsonModel.GetNullableClass<string>(this.RawBodyData, "provider_id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "provider_id", value);
        }
    }

    public string? Status
    {
        get { return JsonModel.GetNullableClass<string>(this.RawBodyData, "status"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "status", value);
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

    public AuthProviderCreateParams() { }

    public AuthProviderCreateParams(AuthProviderCreateParams authProviderCreateParams)
        : base(authProviderCreateParams)
    {
        this._rawBodyData = [.. authProviderCreateParams._rawBodyData];
    }

    public AuthProviderCreateParams(
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
    AuthProviderCreateParams(
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
    public static AuthProviderCreateParams FromRawUnchecked(
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

    public override System::Uri Url(ClientOptions options)
    {
        return new System::UriBuilder(
            options.BaseUrl.ToString().TrimEnd('/') + "/v1/admin/auth_providers"
        )
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

[JsonConverter(typeof(JsonModelConverter<Oauth2, Oauth2FromRaw>))]
public sealed record class Oauth2 : JsonModel
{
    public required string ClientID
    {
        get { return JsonModel.GetNotNullClass<string>(this.RawData, "client_id"); }
        init { JsonModel.Set(this._rawData, "client_id", value); }
    }

    public AuthorizeRequest? AuthorizeRequest
    {
        get
        {
            return JsonModel.GetNullableClass<AuthorizeRequest>(this.RawData, "authorize_request");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "authorize_request", value);
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

    public Pkce? Pkce
    {
        get { return JsonModel.GetNullableClass<Pkce>(this.RawData, "pkce"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "pkce", value);
        }
    }

    public RefreshRequest? RefreshRequest
    {
        get { return JsonModel.GetNullableClass<RefreshRequest>(this.RawData, "refresh_request"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "refresh_request", value);
        }
    }

    public ApiEnum<string, ScopeDelimiter>? ScopeDelimiter
    {
        get
        {
            return JsonModel.GetNullableClass<ApiEnum<string, ScopeDelimiter>>(
                this.RawData,
                "scope_delimiter"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "scope_delimiter", value);
        }
    }

    public TokenIntrospectionRequest? TokenIntrospectionRequest
    {
        get
        {
            return JsonModel.GetNullableClass<TokenIntrospectionRequest>(
                this.RawData,
                "token_introspection_request"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "token_introspection_request", value);
        }
    }

    public TokenRequest? TokenRequest
    {
        get { return JsonModel.GetNullableClass<TokenRequest>(this.RawData, "token_request"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "token_request", value);
        }
    }

    public UserInfoRequest? UserInfoRequest
    {
        get
        {
            return JsonModel.GetNullableClass<UserInfoRequest>(this.RawData, "user_info_request");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "user_info_request", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ClientID;
        this.AuthorizeRequest?.Validate();
        _ = this.ClientSecret;
        this.Pkce?.Validate();
        this.RefreshRequest?.Validate();
        this.ScopeDelimiter?.Validate();
        this.TokenIntrospectionRequest?.Validate();
        this.TokenRequest?.Validate();
        this.UserInfoRequest?.Validate();
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

    [SetsRequiredMembers]
    public Oauth2(string clientID)
        : this()
    {
        this.ClientID = clientID;
    }
}

class Oauth2FromRaw : IFromRawJson<Oauth2>
{
    /// <inheritdoc/>
    public Oauth2 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Oauth2.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<AuthorizeRequest, AuthorizeRequestFromRaw>))]
public sealed record class AuthorizeRequest : JsonModel
{
    public required string Endpoint
    {
        get { return JsonModel.GetNotNullClass<string>(this.RawData, "endpoint"); }
        init { JsonModel.Set(this._rawData, "endpoint", value); }
    }

    public string? AuthHeaderValueFormat
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "auth_header_value_format"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "auth_header_value_format", value);
        }
    }

    public string? AuthMethod
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "auth_method"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "auth_method", value);
        }
    }

    public string? Method
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "method"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "method", value);
        }
    }

    public IReadOnlyDictionary<string, string>? Params
    {
        get
        {
            return JsonModel.GetNullableClass<Dictionary<string, string>>(this.RawData, "params");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "params", value);
        }
    }

    public ApiEnum<string, RequestContentType>? RequestContentType
    {
        get
        {
            return JsonModel.GetNullableClass<ApiEnum<string, RequestContentType>>(
                this.RawData,
                "request_content_type"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "request_content_type", value);
        }
    }

    public ApiEnum<string, ResponseContentType>? ResponseContentType
    {
        get
        {
            return JsonModel.GetNullableClass<ApiEnum<string, ResponseContentType>>(
                this.RawData,
                "response_content_type"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "response_content_type", value);
        }
    }

    public IReadOnlyDictionary<string, string>? ResponseMap
    {
        get
        {
            return JsonModel.GetNullableClass<Dictionary<string, string>>(
                this.RawData,
                "response_map"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "response_map", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Endpoint;
        _ = this.AuthHeaderValueFormat;
        _ = this.AuthMethod;
        _ = this.Method;
        _ = this.Params;
        this.RequestContentType?.Validate();
        this.ResponseContentType?.Validate();
        _ = this.ResponseMap;
    }

    public AuthorizeRequest() { }

    public AuthorizeRequest(AuthorizeRequest authorizeRequest)
        : base(authorizeRequest) { }

    public AuthorizeRequest(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthorizeRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthorizeRequestFromRaw.FromRawUnchecked"/>
    public static AuthorizeRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public AuthorizeRequest(string endpoint)
        : this()
    {
        this.Endpoint = endpoint;
    }
}

class AuthorizeRequestFromRaw : IFromRawJson<AuthorizeRequest>
{
    /// <inheritdoc/>
    public AuthorizeRequest FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        AuthorizeRequest.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(RequestContentTypeConverter))]
public enum RequestContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class RequestContentTypeConverter : JsonConverter<RequestContentType>
{
    public override RequestContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" => RequestContentType.ApplicationXWwwFormUrlencoded,
            "application/json" => RequestContentType.ApplicationJson,
            _ => (RequestContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        RequestContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                RequestContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                RequestContentType.ApplicationJson => "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(ResponseContentTypeConverter))]
public enum ResponseContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class ResponseContentTypeConverter : JsonConverter<ResponseContentType>
{
    public override ResponseContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                ResponseContentType.ApplicationXWwwFormUrlencoded,
            "application/json" => ResponseContentType.ApplicationJson,
            _ => (ResponseContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        ResponseContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                ResponseContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                ResponseContentType.ApplicationJson => "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(JsonModelConverter<Pkce, PkceFromRaw>))]
public sealed record class Pkce : JsonModel
{
    public string? CodeChallengeMethod
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "code_challenge_method"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "code_challenge_method", value);
        }
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

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.CodeChallengeMethod;
        _ = this.Enabled;
    }

    public Pkce() { }

    public Pkce(Pkce pkce)
        : base(pkce) { }

    public Pkce(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Pkce(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PkceFromRaw.FromRawUnchecked"/>
    public static Pkce FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PkceFromRaw : IFromRawJson<Pkce>
{
    /// <inheritdoc/>
    public Pkce FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Pkce.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<RefreshRequest, RefreshRequestFromRaw>))]
public sealed record class RefreshRequest : JsonModel
{
    public required string Endpoint
    {
        get { return JsonModel.GetNotNullClass<string>(this.RawData, "endpoint"); }
        init { JsonModel.Set(this._rawData, "endpoint", value); }
    }

    public string? AuthHeaderValueFormat
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "auth_header_value_format"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "auth_header_value_format", value);
        }
    }

    public string? AuthMethod
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "auth_method"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "auth_method", value);
        }
    }

    public string? Method
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "method"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "method", value);
        }
    }

    public IReadOnlyDictionary<string, string>? Params
    {
        get
        {
            return JsonModel.GetNullableClass<Dictionary<string, string>>(this.RawData, "params");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "params", value);
        }
    }

    public ApiEnum<string, RefreshRequestRequestContentType>? RequestContentType
    {
        get
        {
            return JsonModel.GetNullableClass<ApiEnum<string, RefreshRequestRequestContentType>>(
                this.RawData,
                "request_content_type"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "request_content_type", value);
        }
    }

    public ApiEnum<string, RefreshRequestResponseContentType>? ResponseContentType
    {
        get
        {
            return JsonModel.GetNullableClass<ApiEnum<string, RefreshRequestResponseContentType>>(
                this.RawData,
                "response_content_type"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "response_content_type", value);
        }
    }

    public IReadOnlyDictionary<string, string>? ResponseMap
    {
        get
        {
            return JsonModel.GetNullableClass<Dictionary<string, string>>(
                this.RawData,
                "response_map"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "response_map", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Endpoint;
        _ = this.AuthHeaderValueFormat;
        _ = this.AuthMethod;
        _ = this.Method;
        _ = this.Params;
        this.RequestContentType?.Validate();
        this.ResponseContentType?.Validate();
        _ = this.ResponseMap;
    }

    public RefreshRequest() { }

    public RefreshRequest(RefreshRequest refreshRequest)
        : base(refreshRequest) { }

    public RefreshRequest(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    RefreshRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="RefreshRequestFromRaw.FromRawUnchecked"/>
    public static RefreshRequest FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public RefreshRequest(string endpoint)
        : this()
    {
        this.Endpoint = endpoint;
    }
}

class RefreshRequestFromRaw : IFromRawJson<RefreshRequest>
{
    /// <inheritdoc/>
    public RefreshRequest FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        RefreshRequest.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(RefreshRequestRequestContentTypeConverter))]
public enum RefreshRequestRequestContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class RefreshRequestRequestContentTypeConverter
    : JsonConverter<RefreshRequestRequestContentType>
{
    public override RefreshRequestRequestContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            "application/json" => RefreshRequestRequestContentType.ApplicationJson,
            _ => (RefreshRequestRequestContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        RefreshRequestRequestContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                RefreshRequestRequestContentType.ApplicationJson => "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(RefreshRequestResponseContentTypeConverter))]
public enum RefreshRequestResponseContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class RefreshRequestResponseContentTypeConverter
    : JsonConverter<RefreshRequestResponseContentType>
{
    public override RefreshRequestResponseContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            "application/json" => RefreshRequestResponseContentType.ApplicationJson,
            _ => (RefreshRequestResponseContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        RefreshRequestResponseContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                RefreshRequestResponseContentType.ApplicationJson => "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(ScopeDelimiterConverter))]
public enum ScopeDelimiter
{
    Undefined,
    V1,
}

sealed class ScopeDelimiterConverter : JsonConverter<ScopeDelimiter>
{
    public override ScopeDelimiter Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "," => ScopeDelimiter.Undefined,
            " " => ScopeDelimiter.V1,
            _ => (ScopeDelimiter)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        ScopeDelimiter value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                ScopeDelimiter.Undefined => ",",
                ScopeDelimiter.V1 => " ",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(
    typeof(JsonModelConverter<TokenIntrospectionRequest, TokenIntrospectionRequestFromRaw>)
)]
public sealed record class TokenIntrospectionRequest : JsonModel
{
    public required string Endpoint
    {
        get { return JsonModel.GetNotNullClass<string>(this.RawData, "endpoint"); }
        init { JsonModel.Set(this._rawData, "endpoint", value); }
    }

    public required Triggers Triggers
    {
        get { return JsonModel.GetNotNullClass<Triggers>(this.RawData, "triggers"); }
        init { JsonModel.Set(this._rawData, "triggers", value); }
    }

    public string? AuthHeaderValueFormat
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "auth_header_value_format"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "auth_header_value_format", value);
        }
    }

    public string? AuthMethod
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "auth_method"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "auth_method", value);
        }
    }

    public string? Method
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "method"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "method", value);
        }
    }

    public IReadOnlyDictionary<string, string>? Params
    {
        get
        {
            return JsonModel.GetNullableClass<Dictionary<string, string>>(this.RawData, "params");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "params", value);
        }
    }

    public ApiEnum<string, TokenIntrospectionRequestRequestContentType>? RequestContentType
    {
        get
        {
            return JsonModel.GetNullableClass<
                ApiEnum<string, TokenIntrospectionRequestRequestContentType>
            >(this.RawData, "request_content_type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "request_content_type", value);
        }
    }

    public ApiEnum<string, TokenIntrospectionRequestResponseContentType>? ResponseContentType
    {
        get
        {
            return JsonModel.GetNullableClass<
                ApiEnum<string, TokenIntrospectionRequestResponseContentType>
            >(this.RawData, "response_content_type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "response_content_type", value);
        }
    }

    public IReadOnlyDictionary<string, string>? ResponseMap
    {
        get
        {
            return JsonModel.GetNullableClass<Dictionary<string, string>>(
                this.RawData,
                "response_map"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "response_map", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Endpoint;
        this.Triggers.Validate();
        _ = this.AuthHeaderValueFormat;
        _ = this.AuthMethod;
        _ = this.Method;
        _ = this.Params;
        this.RequestContentType?.Validate();
        this.ResponseContentType?.Validate();
        _ = this.ResponseMap;
    }

    public TokenIntrospectionRequest() { }

    public TokenIntrospectionRequest(TokenIntrospectionRequest tokenIntrospectionRequest)
        : base(tokenIntrospectionRequest) { }

    public TokenIntrospectionRequest(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TokenIntrospectionRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TokenIntrospectionRequestFromRaw.FromRawUnchecked"/>
    public static TokenIntrospectionRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TokenIntrospectionRequestFromRaw : IFromRawJson<TokenIntrospectionRequest>
{
    /// <inheritdoc/>
    public TokenIntrospectionRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TokenIntrospectionRequest.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Triggers, TriggersFromRaw>))]
public sealed record class Triggers : JsonModel
{
    public bool? OnTokenGrant
    {
        get { return JsonModel.GetNullableStruct<bool>(this.RawData, "on_token_grant"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "on_token_grant", value);
        }
    }

    public bool? OnTokenRefresh
    {
        get { return JsonModel.GetNullableStruct<bool>(this.RawData, "on_token_refresh"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "on_token_refresh", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.OnTokenGrant;
        _ = this.OnTokenRefresh;
    }

    public Triggers() { }

    public Triggers(Triggers triggers)
        : base(triggers) { }

    public Triggers(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Triggers(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TriggersFromRaw.FromRawUnchecked"/>
    public static Triggers FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TriggersFromRaw : IFromRawJson<Triggers>
{
    /// <inheritdoc/>
    public Triggers FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Triggers.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(TokenIntrospectionRequestRequestContentTypeConverter))]
public enum TokenIntrospectionRequestRequestContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class TokenIntrospectionRequestRequestContentTypeConverter
    : JsonConverter<TokenIntrospectionRequestRequestContentType>
{
    public override TokenIntrospectionRequestRequestContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            "application/json" => TokenIntrospectionRequestRequestContentType.ApplicationJson,
            _ => (TokenIntrospectionRequestRequestContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        TokenIntrospectionRequestRequestContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                TokenIntrospectionRequestRequestContentType.ApplicationJson => "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(TokenIntrospectionRequestResponseContentTypeConverter))]
public enum TokenIntrospectionRequestResponseContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class TokenIntrospectionRequestResponseContentTypeConverter
    : JsonConverter<TokenIntrospectionRequestResponseContentType>
{
    public override TokenIntrospectionRequestResponseContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            "application/json" => TokenIntrospectionRequestResponseContentType.ApplicationJson,
            _ => (TokenIntrospectionRequestResponseContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        TokenIntrospectionRequestResponseContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                TokenIntrospectionRequestResponseContentType.ApplicationJson => "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(JsonModelConverter<TokenRequest, TokenRequestFromRaw>))]
public sealed record class TokenRequest : JsonModel
{
    public required string Endpoint
    {
        get { return JsonModel.GetNotNullClass<string>(this.RawData, "endpoint"); }
        init { JsonModel.Set(this._rawData, "endpoint", value); }
    }

    public string? AuthHeaderValueFormat
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "auth_header_value_format"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "auth_header_value_format", value);
        }
    }

    public string? AuthMethod
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "auth_method"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "auth_method", value);
        }
    }

    public string? Method
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "method"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "method", value);
        }
    }

    public IReadOnlyDictionary<string, string>? Params
    {
        get
        {
            return JsonModel.GetNullableClass<Dictionary<string, string>>(this.RawData, "params");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "params", value);
        }
    }

    public ApiEnum<string, TokenRequestRequestContentType>? RequestContentType
    {
        get
        {
            return JsonModel.GetNullableClass<ApiEnum<string, TokenRequestRequestContentType>>(
                this.RawData,
                "request_content_type"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "request_content_type", value);
        }
    }

    public ApiEnum<string, TokenRequestResponseContentType>? ResponseContentType
    {
        get
        {
            return JsonModel.GetNullableClass<ApiEnum<string, TokenRequestResponseContentType>>(
                this.RawData,
                "response_content_type"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "response_content_type", value);
        }
    }

    public IReadOnlyDictionary<string, string>? ResponseMap
    {
        get
        {
            return JsonModel.GetNullableClass<Dictionary<string, string>>(
                this.RawData,
                "response_map"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "response_map", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Endpoint;
        _ = this.AuthHeaderValueFormat;
        _ = this.AuthMethod;
        _ = this.Method;
        _ = this.Params;
        this.RequestContentType?.Validate();
        this.ResponseContentType?.Validate();
        _ = this.ResponseMap;
    }

    public TokenRequest() { }

    public TokenRequest(TokenRequest tokenRequest)
        : base(tokenRequest) { }

    public TokenRequest(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TokenRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TokenRequestFromRaw.FromRawUnchecked"/>
    public static TokenRequest FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public TokenRequest(string endpoint)
        : this()
    {
        this.Endpoint = endpoint;
    }
}

class TokenRequestFromRaw : IFromRawJson<TokenRequest>
{
    /// <inheritdoc/>
    public TokenRequest FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        TokenRequest.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(TokenRequestRequestContentTypeConverter))]
public enum TokenRequestRequestContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class TokenRequestRequestContentTypeConverter : JsonConverter<TokenRequestRequestContentType>
{
    public override TokenRequestRequestContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            "application/json" => TokenRequestRequestContentType.ApplicationJson,
            _ => (TokenRequestRequestContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        TokenRequestRequestContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                TokenRequestRequestContentType.ApplicationJson => "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(TokenRequestResponseContentTypeConverter))]
public enum TokenRequestResponseContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class TokenRequestResponseContentTypeConverter
    : JsonConverter<TokenRequestResponseContentType>
{
    public override TokenRequestResponseContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            "application/json" => TokenRequestResponseContentType.ApplicationJson,
            _ => (TokenRequestResponseContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        TokenRequestResponseContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                TokenRequestResponseContentType.ApplicationJson => "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(JsonModelConverter<UserInfoRequest, UserInfoRequestFromRaw>))]
public sealed record class UserInfoRequest : JsonModel
{
    public required string Endpoint
    {
        get { return JsonModel.GetNotNullClass<string>(this.RawData, "endpoint"); }
        init { JsonModel.Set(this._rawData, "endpoint", value); }
    }

    public required UserInfoRequestTriggers Triggers
    {
        get { return JsonModel.GetNotNullClass<UserInfoRequestTriggers>(this.RawData, "triggers"); }
        init { JsonModel.Set(this._rawData, "triggers", value); }
    }

    public string? AuthHeaderValueFormat
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "auth_header_value_format"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "auth_header_value_format", value);
        }
    }

    public string? AuthMethod
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "auth_method"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "auth_method", value);
        }
    }

    public string? Method
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "method"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "method", value);
        }
    }

    public IReadOnlyDictionary<string, string>? Params
    {
        get
        {
            return JsonModel.GetNullableClass<Dictionary<string, string>>(this.RawData, "params");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "params", value);
        }
    }

    public ApiEnum<string, UserInfoRequestRequestContentType>? RequestContentType
    {
        get
        {
            return JsonModel.GetNullableClass<ApiEnum<string, UserInfoRequestRequestContentType>>(
                this.RawData,
                "request_content_type"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "request_content_type", value);
        }
    }

    public ApiEnum<string, UserInfoRequestResponseContentType>? ResponseContentType
    {
        get
        {
            return JsonModel.GetNullableClass<ApiEnum<string, UserInfoRequestResponseContentType>>(
                this.RawData,
                "response_content_type"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "response_content_type", value);
        }
    }

    public IReadOnlyDictionary<string, string>? ResponseMap
    {
        get
        {
            return JsonModel.GetNullableClass<Dictionary<string, string>>(
                this.RawData,
                "response_map"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "response_map", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Endpoint;
        this.Triggers.Validate();
        _ = this.AuthHeaderValueFormat;
        _ = this.AuthMethod;
        _ = this.Method;
        _ = this.Params;
        this.RequestContentType?.Validate();
        this.ResponseContentType?.Validate();
        _ = this.ResponseMap;
    }

    public UserInfoRequest() { }

    public UserInfoRequest(UserInfoRequest userInfoRequest)
        : base(userInfoRequest) { }

    public UserInfoRequest(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    UserInfoRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="UserInfoRequestFromRaw.FromRawUnchecked"/>
    public static UserInfoRequest FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class UserInfoRequestFromRaw : IFromRawJson<UserInfoRequest>
{
    /// <inheritdoc/>
    public UserInfoRequest FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        UserInfoRequest.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<UserInfoRequestTriggers, UserInfoRequestTriggersFromRaw>))]
public sealed record class UserInfoRequestTriggers : JsonModel
{
    public bool? OnTokenGrant
    {
        get { return JsonModel.GetNullableStruct<bool>(this.RawData, "on_token_grant"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "on_token_grant", value);
        }
    }

    public bool? OnTokenRefresh
    {
        get { return JsonModel.GetNullableStruct<bool>(this.RawData, "on_token_refresh"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "on_token_refresh", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.OnTokenGrant;
        _ = this.OnTokenRefresh;
    }

    public UserInfoRequestTriggers() { }

    public UserInfoRequestTriggers(UserInfoRequestTriggers userInfoRequestTriggers)
        : base(userInfoRequestTriggers) { }

    public UserInfoRequestTriggers(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    UserInfoRequestTriggers(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="UserInfoRequestTriggersFromRaw.FromRawUnchecked"/>
    public static UserInfoRequestTriggers FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class UserInfoRequestTriggersFromRaw : IFromRawJson<UserInfoRequestTriggers>
{
    /// <inheritdoc/>
    public UserInfoRequestTriggers FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => UserInfoRequestTriggers.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(UserInfoRequestRequestContentTypeConverter))]
public enum UserInfoRequestRequestContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class UserInfoRequestRequestContentTypeConverter
    : JsonConverter<UserInfoRequestRequestContentType>
{
    public override UserInfoRequestRequestContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            "application/json" => UserInfoRequestRequestContentType.ApplicationJson,
            _ => (UserInfoRequestRequestContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        UserInfoRequestRequestContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                UserInfoRequestRequestContentType.ApplicationJson => "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(UserInfoRequestResponseContentTypeConverter))]
public enum UserInfoRequestResponseContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class UserInfoRequestResponseContentTypeConverter
    : JsonConverter<UserInfoRequestResponseContentType>
{
    public override UserInfoRequestResponseContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            "application/json" => UserInfoRequestResponseContentType.ApplicationJson,
            _ => (UserInfoRequestResponseContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        UserInfoRequestResponseContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                UserInfoRequestResponseContentType.ApplicationJson => "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
