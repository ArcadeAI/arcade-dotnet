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
        get { return ModelBase.GetNotNullClass<string>(this.RawBodyData, "id"); }
        init { ModelBase.Set(this._rawBodyData, "id", value); }
    }

    public string? Description
    {
        get { return ModelBase.GetNullableClass<string>(this.RawBodyData, "description"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawBodyData, "description", value);
        }
    }

    /// <summary>
    /// The unique external ID for the auth provider
    /// </summary>
    public string? ExternalID
    {
        get { return ModelBase.GetNullableClass<string>(this.RawBodyData, "external_id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawBodyData, "external_id", value);
        }
    }

    public Oauth2? Oauth2
    {
        get { return ModelBase.GetNullableClass<Oauth2>(this.RawBodyData, "oauth2"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawBodyData, "oauth2", value);
        }
    }

    public string? ProviderID
    {
        get { return ModelBase.GetNullableClass<string>(this.RawBodyData, "provider_id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawBodyData, "provider_id", value);
        }
    }

    public string? Status
    {
        get { return ModelBase.GetNullableClass<string>(this.RawBodyData, "status"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawBodyData, "status", value);
        }
    }

    public string? Type
    {
        get { return ModelBase.GetNullableClass<string>(this.RawBodyData, "type"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawBodyData, "type", value);
        }
    }

    public AuthProviderCreateParams() { }

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

[JsonConverter(typeof(ModelConverter<Oauth2, Oauth2FromRaw>))]
public sealed record class Oauth2 : ModelBase
{
    public required string ClientID
    {
        get { return ModelBase.GetNotNullClass<string>(this.RawData, "client_id"); }
        init { ModelBase.Set(this._rawData, "client_id", value); }
    }

    public AuthorizeRequest? AuthorizeRequest
    {
        get
        {
            return ModelBase.GetNullableClass<AuthorizeRequest>(this.RawData, "authorize_request");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "authorize_request", value);
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

    public Pkce? Pkce
    {
        get { return ModelBase.GetNullableClass<Pkce>(this.RawData, "pkce"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "pkce", value);
        }
    }

    public RefreshRequest? RefreshRequest
    {
        get { return ModelBase.GetNullableClass<RefreshRequest>(this.RawData, "refresh_request"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "refresh_request", value);
        }
    }

    public ApiEnum<string, ScopeDelimiter>? ScopeDelimiter
    {
        get
        {
            return ModelBase.GetNullableClass<ApiEnum<string, ScopeDelimiter>>(
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

            ModelBase.Set(this._rawData, "scope_delimiter", value);
        }
    }

    public TokenIntrospectionRequest? TokenIntrospectionRequest
    {
        get
        {
            return ModelBase.GetNullableClass<TokenIntrospectionRequest>(
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

            ModelBase.Set(this._rawData, "token_introspection_request", value);
        }
    }

    public TokenRequest? TokenRequest
    {
        get { return ModelBase.GetNullableClass<TokenRequest>(this.RawData, "token_request"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "token_request", value);
        }
    }

    public UserInfoRequest? UserInfoRequest
    {
        get
        {
            return ModelBase.GetNullableClass<UserInfoRequest>(this.RawData, "user_info_request");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "user_info_request", value);
        }
    }

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

class Oauth2FromRaw : IFromRaw<Oauth2>
{
    public Oauth2 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Oauth2.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ModelConverter<AuthorizeRequest, AuthorizeRequestFromRaw>))]
public sealed record class AuthorizeRequest : ModelBase
{
    public required string Endpoint
    {
        get { return ModelBase.GetNotNullClass<string>(this.RawData, "endpoint"); }
        init { ModelBase.Set(this._rawData, "endpoint", value); }
    }

    public string? AuthHeaderValueFormat
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "auth_header_value_format"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "auth_header_value_format", value);
        }
    }

    public string? AuthMethod
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "auth_method"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "auth_method", value);
        }
    }

    public string? Method
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "method"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "method", value);
        }
    }

    public IReadOnlyDictionary<string, string>? Params
    {
        get
        {
            return ModelBase.GetNullableClass<Dictionary<string, string>>(this.RawData, "params");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "params", value);
        }
    }

    public ApiEnum<string, RequestContentType>? RequestContentType
    {
        get
        {
            return ModelBase.GetNullableClass<ApiEnum<string, RequestContentType>>(
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

            ModelBase.Set(this._rawData, "request_content_type", value);
        }
    }

    public ApiEnum<string, ResponseContentType>? ResponseContentType
    {
        get
        {
            return ModelBase.GetNullableClass<ApiEnum<string, ResponseContentType>>(
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

            ModelBase.Set(this._rawData, "response_content_type", value);
        }
    }

    public IReadOnlyDictionary<string, string>? ResponseMap
    {
        get
        {
            return ModelBase.GetNullableClass<Dictionary<string, string>>(
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

            ModelBase.Set(this._rawData, "response_map", value);
        }
    }

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

class AuthorizeRequestFromRaw : IFromRaw<AuthorizeRequest>
{
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

[JsonConverter(typeof(ModelConverter<Pkce, PkceFromRaw>))]
public sealed record class Pkce : ModelBase
{
    public string? CodeChallengeMethod
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "code_challenge_method"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "code_challenge_method", value);
        }
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

    public override void Validate()
    {
        _ = this.CodeChallengeMethod;
        _ = this.Enabled;
    }

    public Pkce() { }

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

    public static Pkce FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PkceFromRaw : IFromRaw<Pkce>
{
    public Pkce FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Pkce.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ModelConverter<RefreshRequest, RefreshRequestFromRaw>))]
public sealed record class RefreshRequest : ModelBase
{
    public required string Endpoint
    {
        get { return ModelBase.GetNotNullClass<string>(this.RawData, "endpoint"); }
        init { ModelBase.Set(this._rawData, "endpoint", value); }
    }

    public string? AuthHeaderValueFormat
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "auth_header_value_format"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "auth_header_value_format", value);
        }
    }

    public string? AuthMethod
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "auth_method"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "auth_method", value);
        }
    }

    public string? Method
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "method"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "method", value);
        }
    }

    public IReadOnlyDictionary<string, string>? Params
    {
        get
        {
            return ModelBase.GetNullableClass<Dictionary<string, string>>(this.RawData, "params");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "params", value);
        }
    }

    public ApiEnum<string, RefreshRequestRequestContentType>? RequestContentType
    {
        get
        {
            return ModelBase.GetNullableClass<ApiEnum<string, RefreshRequestRequestContentType>>(
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

            ModelBase.Set(this._rawData, "request_content_type", value);
        }
    }

    public ApiEnum<string, RefreshRequestResponseContentType>? ResponseContentType
    {
        get
        {
            return ModelBase.GetNullableClass<ApiEnum<string, RefreshRequestResponseContentType>>(
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

            ModelBase.Set(this._rawData, "response_content_type", value);
        }
    }

    public IReadOnlyDictionary<string, string>? ResponseMap
    {
        get
        {
            return ModelBase.GetNullableClass<Dictionary<string, string>>(
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

            ModelBase.Set(this._rawData, "response_map", value);
        }
    }

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

class RefreshRequestFromRaw : IFromRaw<RefreshRequest>
{
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

[JsonConverter(typeof(ModelConverter<TokenIntrospectionRequest, TokenIntrospectionRequestFromRaw>))]
public sealed record class TokenIntrospectionRequest : ModelBase
{
    public required string Endpoint
    {
        get { return ModelBase.GetNotNullClass<string>(this.RawData, "endpoint"); }
        init { ModelBase.Set(this._rawData, "endpoint", value); }
    }

    public required Triggers Triggers
    {
        get { return ModelBase.GetNotNullClass<Triggers>(this.RawData, "triggers"); }
        init { ModelBase.Set(this._rawData, "triggers", value); }
    }

    public string? AuthHeaderValueFormat
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "auth_header_value_format"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "auth_header_value_format", value);
        }
    }

    public string? AuthMethod
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "auth_method"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "auth_method", value);
        }
    }

    public string? Method
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "method"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "method", value);
        }
    }

    public IReadOnlyDictionary<string, string>? Params
    {
        get
        {
            return ModelBase.GetNullableClass<Dictionary<string, string>>(this.RawData, "params");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "params", value);
        }
    }

    public ApiEnum<string, TokenIntrospectionRequestRequestContentType>? RequestContentType
    {
        get
        {
            return ModelBase.GetNullableClass<
                ApiEnum<string, TokenIntrospectionRequestRequestContentType>
            >(this.RawData, "request_content_type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "request_content_type", value);
        }
    }

    public ApiEnum<string, TokenIntrospectionRequestResponseContentType>? ResponseContentType
    {
        get
        {
            return ModelBase.GetNullableClass<
                ApiEnum<string, TokenIntrospectionRequestResponseContentType>
            >(this.RawData, "response_content_type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "response_content_type", value);
        }
    }

    public IReadOnlyDictionary<string, string>? ResponseMap
    {
        get
        {
            return ModelBase.GetNullableClass<Dictionary<string, string>>(
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

            ModelBase.Set(this._rawData, "response_map", value);
        }
    }

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

    public static TokenIntrospectionRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TokenIntrospectionRequestFromRaw : IFromRaw<TokenIntrospectionRequest>
{
    public TokenIntrospectionRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TokenIntrospectionRequest.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ModelConverter<Triggers, TriggersFromRaw>))]
public sealed record class Triggers : ModelBase
{
    public bool? OnTokenGrant
    {
        get { return ModelBase.GetNullableStruct<bool>(this.RawData, "on_token_grant"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "on_token_grant", value);
        }
    }

    public bool? OnTokenRefresh
    {
        get { return ModelBase.GetNullableStruct<bool>(this.RawData, "on_token_refresh"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "on_token_refresh", value);
        }
    }

    public override void Validate()
    {
        _ = this.OnTokenGrant;
        _ = this.OnTokenRefresh;
    }

    public Triggers() { }

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

    public static Triggers FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TriggersFromRaw : IFromRaw<Triggers>
{
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

[JsonConverter(typeof(ModelConverter<TokenRequest, TokenRequestFromRaw>))]
public sealed record class TokenRequest : ModelBase
{
    public required string Endpoint
    {
        get { return ModelBase.GetNotNullClass<string>(this.RawData, "endpoint"); }
        init { ModelBase.Set(this._rawData, "endpoint", value); }
    }

    public string? AuthHeaderValueFormat
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "auth_header_value_format"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "auth_header_value_format", value);
        }
    }

    public string? AuthMethod
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "auth_method"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "auth_method", value);
        }
    }

    public string? Method
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "method"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "method", value);
        }
    }

    public IReadOnlyDictionary<string, string>? Params
    {
        get
        {
            return ModelBase.GetNullableClass<Dictionary<string, string>>(this.RawData, "params");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "params", value);
        }
    }

    public ApiEnum<string, TokenRequestRequestContentType>? RequestContentType
    {
        get
        {
            return ModelBase.GetNullableClass<ApiEnum<string, TokenRequestRequestContentType>>(
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

            ModelBase.Set(this._rawData, "request_content_type", value);
        }
    }

    public ApiEnum<string, TokenRequestResponseContentType>? ResponseContentType
    {
        get
        {
            return ModelBase.GetNullableClass<ApiEnum<string, TokenRequestResponseContentType>>(
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

            ModelBase.Set(this._rawData, "response_content_type", value);
        }
    }

    public IReadOnlyDictionary<string, string>? ResponseMap
    {
        get
        {
            return ModelBase.GetNullableClass<Dictionary<string, string>>(
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

            ModelBase.Set(this._rawData, "response_map", value);
        }
    }

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

class TokenRequestFromRaw : IFromRaw<TokenRequest>
{
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

[JsonConverter(typeof(ModelConverter<UserInfoRequest, UserInfoRequestFromRaw>))]
public sealed record class UserInfoRequest : ModelBase
{
    public required string Endpoint
    {
        get { return ModelBase.GetNotNullClass<string>(this.RawData, "endpoint"); }
        init { ModelBase.Set(this._rawData, "endpoint", value); }
    }

    public required UserInfoRequestTriggers Triggers
    {
        get { return ModelBase.GetNotNullClass<UserInfoRequestTriggers>(this.RawData, "triggers"); }
        init { ModelBase.Set(this._rawData, "triggers", value); }
    }

    public string? AuthHeaderValueFormat
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "auth_header_value_format"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "auth_header_value_format", value);
        }
    }

    public string? AuthMethod
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "auth_method"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "auth_method", value);
        }
    }

    public string? Method
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "method"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "method", value);
        }
    }

    public IReadOnlyDictionary<string, string>? Params
    {
        get
        {
            return ModelBase.GetNullableClass<Dictionary<string, string>>(this.RawData, "params");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "params", value);
        }
    }

    public ApiEnum<string, UserInfoRequestRequestContentType>? RequestContentType
    {
        get
        {
            return ModelBase.GetNullableClass<ApiEnum<string, UserInfoRequestRequestContentType>>(
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

            ModelBase.Set(this._rawData, "request_content_type", value);
        }
    }

    public ApiEnum<string, UserInfoRequestResponseContentType>? ResponseContentType
    {
        get
        {
            return ModelBase.GetNullableClass<ApiEnum<string, UserInfoRequestResponseContentType>>(
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

            ModelBase.Set(this._rawData, "response_content_type", value);
        }
    }

    public IReadOnlyDictionary<string, string>? ResponseMap
    {
        get
        {
            return ModelBase.GetNullableClass<Dictionary<string, string>>(
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

            ModelBase.Set(this._rawData, "response_map", value);
        }
    }

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

    public static UserInfoRequest FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class UserInfoRequestFromRaw : IFromRaw<UserInfoRequest>
{
    public UserInfoRequest FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        UserInfoRequest.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ModelConverter<UserInfoRequestTriggers, UserInfoRequestTriggersFromRaw>))]
public sealed record class UserInfoRequestTriggers : ModelBase
{
    public bool? OnTokenGrant
    {
        get { return ModelBase.GetNullableStruct<bool>(this.RawData, "on_token_grant"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "on_token_grant", value);
        }
    }

    public bool? OnTokenRefresh
    {
        get { return ModelBase.GetNullableStruct<bool>(this.RawData, "on_token_refresh"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "on_token_refresh", value);
        }
    }

    public override void Validate()
    {
        _ = this.OnTokenGrant;
        _ = this.OnTokenRefresh;
    }

    public UserInfoRequestTriggers() { }

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

    public static UserInfoRequestTriggers FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class UserInfoRequestTriggersFromRaw : IFromRaw<UserInfoRequestTriggers>
{
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
