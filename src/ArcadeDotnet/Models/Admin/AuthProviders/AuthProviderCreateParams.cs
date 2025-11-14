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
    readonly FreezableDictionary<string, JsonElement> _bodyProperties = [];
    public IReadOnlyDictionary<string, JsonElement> BodyProperties
    {
        get { return this._bodyProperties.Freeze(); }
    }

    public required string ID
    {
        get
        {
            if (!this._bodyProperties.TryGetValue("id", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'id' cannot be null",
                    new System::ArgumentOutOfRangeException("id", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'id' cannot be null",
                    new System::ArgumentNullException("id")
                );
        }
        init
        {
            this._bodyProperties["id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Description
    {
        get
        {
            if (!this._bodyProperties.TryGetValue("description", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._bodyProperties["description"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    /// <summary>
    /// The unique external ID for the auth provider
    /// </summary>
    public string? ExternalID
    {
        get
        {
            if (!this._bodyProperties.TryGetValue("external_id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._bodyProperties["external_id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Oauth2? Oauth2
    {
        get
        {
            if (!this._bodyProperties.TryGetValue("oauth2", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Oauth2?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._bodyProperties["oauth2"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? ProviderID
    {
        get
        {
            if (!this._bodyProperties.TryGetValue("provider_id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._bodyProperties["provider_id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Status
    {
        get
        {
            if (!this._bodyProperties.TryGetValue("status", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._bodyProperties["status"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Type
    {
        get
        {
            if (!this._bodyProperties.TryGetValue("type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._bodyProperties["type"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public AuthProviderCreateParams() { }

    public AuthProviderCreateParams(
        IReadOnlyDictionary<string, JsonElement> headerProperties,
        IReadOnlyDictionary<string, JsonElement> queryProperties,
        IReadOnlyDictionary<string, JsonElement> bodyProperties
    )
    {
        this._headerProperties = [.. headerProperties];
        this._queryProperties = [.. queryProperties];
        this._bodyProperties = [.. bodyProperties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderCreateParams(
        FrozenDictionary<string, JsonElement> headerProperties,
        FrozenDictionary<string, JsonElement> queryProperties,
        FrozenDictionary<string, JsonElement> bodyProperties
    )
    {
        this._headerProperties = [.. headerProperties];
        this._queryProperties = [.. queryProperties];
        this._bodyProperties = [.. bodyProperties];
    }
#pragma warning restore CS8618

    public static AuthProviderCreateParams FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> headerProperties,
        IReadOnlyDictionary<string, JsonElement> queryProperties,
        IReadOnlyDictionary<string, JsonElement> bodyProperties
    )
    {
        return new(
            FrozenDictionary.ToFrozenDictionary(headerProperties),
            FrozenDictionary.ToFrozenDictionary(queryProperties),
            FrozenDictionary.ToFrozenDictionary(bodyProperties)
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
        return new(
            JsonSerializer.Serialize(this.BodyProperties),
            Encoding.UTF8,
            "application/json"
        );
    }

    internal override void AddHeadersToRequest(HttpRequestMessage request, ClientOptions options)
    {
        ParamsBase.AddDefaultHeaders(request, options);
        foreach (var item in this.HeaderProperties)
        {
            ParamsBase.AddHeaderElementToRequest(request, item.Key, item.Value);
        }
    }
}

[JsonConverter(typeof(ModelConverter<Oauth2>))]
public sealed record class Oauth2 : ModelBase, IFromRaw<Oauth2>
{
    public required string ClientID
    {
        get
        {
            if (!this._properties.TryGetValue("client_id", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'client_id' cannot be null",
                    new System::ArgumentOutOfRangeException(
                        "client_id",
                        "Missing required argument"
                    )
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'client_id' cannot be null",
                    new System::ArgumentNullException("client_id")
                );
        }
        init
        {
            this._properties["client_id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public AuthorizeRequest? AuthorizeRequest
    {
        get
        {
            if (!this._properties.TryGetValue("authorize_request", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<AuthorizeRequest?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["authorize_request"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? ClientSecret
    {
        get
        {
            if (!this._properties.TryGetValue("client_secret", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["client_secret"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Pkce? Pkce
    {
        get
        {
            if (!this._properties.TryGetValue("pkce", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Pkce?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["pkce"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public RefreshRequest? RefreshRequest
    {
        get
        {
            if (!this._properties.TryGetValue("refresh_request", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<RefreshRequest?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["refresh_request"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public ApiEnum<string, ScopeDelimiter>? ScopeDelimiter
    {
        get
        {
            if (!this._properties.TryGetValue("scope_delimiter", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<string, ScopeDelimiter>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["scope_delimiter"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public TokenIntrospectionRequest? TokenIntrospectionRequest
    {
        get
        {
            if (
                !this._properties.TryGetValue(
                    "token_introspection_request",
                    out JsonElement element
                )
            )
                return null;

            return JsonSerializer.Deserialize<TokenIntrospectionRequest?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["token_introspection_request"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public TokenRequest? TokenRequest
    {
        get
        {
            if (!this._properties.TryGetValue("token_request", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<TokenRequest?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["token_request"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public UserInfoRequest? UserInfoRequest
    {
        get
        {
            if (!this._properties.TryGetValue("user_info_request", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<UserInfoRequest?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["user_info_request"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
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

    public Oauth2(IReadOnlyDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Oauth2(FrozenDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static Oauth2 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> properties)
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }

    [SetsRequiredMembers]
    public Oauth2(string clientID)
        : this()
    {
        this.ClientID = clientID;
    }
}

[JsonConverter(typeof(ModelConverter<AuthorizeRequest>))]
public sealed record class AuthorizeRequest : ModelBase, IFromRaw<AuthorizeRequest>
{
    public required string Endpoint
    {
        get
        {
            if (!this._properties.TryGetValue("endpoint", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'endpoint' cannot be null",
                    new System::ArgumentOutOfRangeException("endpoint", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'endpoint' cannot be null",
                    new System::ArgumentNullException("endpoint")
                );
        }
        init
        {
            this._properties["endpoint"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? AuthHeaderValueFormat
    {
        get
        {
            if (!this._properties.TryGetValue("auth_header_value_format", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["auth_header_value_format"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? AuthMethod
    {
        get
        {
            if (!this._properties.TryGetValue("auth_method", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["auth_method"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Method
    {
        get
        {
            if (!this._properties.TryGetValue("method", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["method"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Dictionary<string, string>? Params
    {
        get
        {
            if (!this._properties.TryGetValue("params", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Dictionary<string, string>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["params"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public ApiEnum<string, RequestContentType>? RequestContentType
    {
        get
        {
            if (!this._properties.TryGetValue("request_content_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<string, RequestContentType>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["request_content_type"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public ApiEnum<string, ResponseContentType>? ResponseContentType
    {
        get
        {
            if (!this._properties.TryGetValue("response_content_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<string, ResponseContentType>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["response_content_type"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Dictionary<string, string>? ResponseMap
    {
        get
        {
            if (!this._properties.TryGetValue("response_map", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Dictionary<string, string>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["response_map"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
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

    public AuthorizeRequest(IReadOnlyDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthorizeRequest(FrozenDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static AuthorizeRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }

    [SetsRequiredMembers]
    public AuthorizeRequest(string endpoint)
        : this()
    {
        this.Endpoint = endpoint;
    }
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

[JsonConverter(typeof(ModelConverter<Pkce>))]
public sealed record class Pkce : ModelBase, IFromRaw<Pkce>
{
    public string? CodeChallengeMethod
    {
        get
        {
            if (!this._properties.TryGetValue("code_challenge_method", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["code_challenge_method"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public bool? Enabled
    {
        get
        {
            if (!this._properties.TryGetValue("enabled", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["enabled"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.CodeChallengeMethod;
        _ = this.Enabled;
    }

    public Pkce() { }

    public Pkce(IReadOnlyDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Pkce(FrozenDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static Pkce FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> properties)
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }
}

[JsonConverter(typeof(ModelConverter<RefreshRequest>))]
public sealed record class RefreshRequest : ModelBase, IFromRaw<RefreshRequest>
{
    public required string Endpoint
    {
        get
        {
            if (!this._properties.TryGetValue("endpoint", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'endpoint' cannot be null",
                    new System::ArgumentOutOfRangeException("endpoint", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'endpoint' cannot be null",
                    new System::ArgumentNullException("endpoint")
                );
        }
        init
        {
            this._properties["endpoint"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? AuthHeaderValueFormat
    {
        get
        {
            if (!this._properties.TryGetValue("auth_header_value_format", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["auth_header_value_format"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? AuthMethod
    {
        get
        {
            if (!this._properties.TryGetValue("auth_method", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["auth_method"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Method
    {
        get
        {
            if (!this._properties.TryGetValue("method", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["method"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Dictionary<string, string>? Params
    {
        get
        {
            if (!this._properties.TryGetValue("params", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Dictionary<string, string>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["params"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public ApiEnum<string, RefreshRequestRequestContentType>? RequestContentType
    {
        get
        {
            if (!this._properties.TryGetValue("request_content_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<string, RefreshRequestRequestContentType>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["request_content_type"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public ApiEnum<string, RefreshRequestResponseContentType>? ResponseContentType
    {
        get
        {
            if (!this._properties.TryGetValue("response_content_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<string, RefreshRequestResponseContentType>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["response_content_type"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Dictionary<string, string>? ResponseMap
    {
        get
        {
            if (!this._properties.TryGetValue("response_map", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Dictionary<string, string>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["response_map"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
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

    public RefreshRequest(IReadOnlyDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    RefreshRequest(FrozenDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static RefreshRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }

    [SetsRequiredMembers]
    public RefreshRequest(string endpoint)
        : this()
    {
        this.Endpoint = endpoint;
    }
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

[JsonConverter(typeof(ModelConverter<TokenIntrospectionRequest>))]
public sealed record class TokenIntrospectionRequest
    : ModelBase,
        IFromRaw<TokenIntrospectionRequest>
{
    public required string Endpoint
    {
        get
        {
            if (!this._properties.TryGetValue("endpoint", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'endpoint' cannot be null",
                    new System::ArgumentOutOfRangeException("endpoint", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'endpoint' cannot be null",
                    new System::ArgumentNullException("endpoint")
                );
        }
        init
        {
            this._properties["endpoint"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required Triggers Triggers
    {
        get
        {
            if (!this._properties.TryGetValue("triggers", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'triggers' cannot be null",
                    new System::ArgumentOutOfRangeException("triggers", "Missing required argument")
                );

            return JsonSerializer.Deserialize<Triggers>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'triggers' cannot be null",
                    new System::ArgumentNullException("triggers")
                );
        }
        init
        {
            this._properties["triggers"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? AuthHeaderValueFormat
    {
        get
        {
            if (!this._properties.TryGetValue("auth_header_value_format", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["auth_header_value_format"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? AuthMethod
    {
        get
        {
            if (!this._properties.TryGetValue("auth_method", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["auth_method"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Method
    {
        get
        {
            if (!this._properties.TryGetValue("method", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["method"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Dictionary<string, string>? Params
    {
        get
        {
            if (!this._properties.TryGetValue("params", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Dictionary<string, string>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["params"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public ApiEnum<string, TokenIntrospectionRequestRequestContentType>? RequestContentType
    {
        get
        {
            if (!this._properties.TryGetValue("request_content_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<
                string,
                TokenIntrospectionRequestRequestContentType
            >?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["request_content_type"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public ApiEnum<string, TokenIntrospectionRequestResponseContentType>? ResponseContentType
    {
        get
        {
            if (!this._properties.TryGetValue("response_content_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<
                string,
                TokenIntrospectionRequestResponseContentType
            >?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["response_content_type"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Dictionary<string, string>? ResponseMap
    {
        get
        {
            if (!this._properties.TryGetValue("response_map", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Dictionary<string, string>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["response_map"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
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

    public TokenIntrospectionRequest(IReadOnlyDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TokenIntrospectionRequest(FrozenDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static TokenIntrospectionRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }
}

[JsonConverter(typeof(ModelConverter<Triggers>))]
public sealed record class Triggers : ModelBase, IFromRaw<Triggers>
{
    public bool? OnTokenGrant
    {
        get
        {
            if (!this._properties.TryGetValue("on_token_grant", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["on_token_grant"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public bool? OnTokenRefresh
    {
        get
        {
            if (!this._properties.TryGetValue("on_token_refresh", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["on_token_refresh"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.OnTokenGrant;
        _ = this.OnTokenRefresh;
    }

    public Triggers() { }

    public Triggers(IReadOnlyDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Triggers(FrozenDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static Triggers FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> properties)
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }
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

[JsonConverter(typeof(ModelConverter<TokenRequest>))]
public sealed record class TokenRequest : ModelBase, IFromRaw<TokenRequest>
{
    public required string Endpoint
    {
        get
        {
            if (!this._properties.TryGetValue("endpoint", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'endpoint' cannot be null",
                    new System::ArgumentOutOfRangeException("endpoint", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'endpoint' cannot be null",
                    new System::ArgumentNullException("endpoint")
                );
        }
        init
        {
            this._properties["endpoint"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? AuthHeaderValueFormat
    {
        get
        {
            if (!this._properties.TryGetValue("auth_header_value_format", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["auth_header_value_format"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? AuthMethod
    {
        get
        {
            if (!this._properties.TryGetValue("auth_method", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["auth_method"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Method
    {
        get
        {
            if (!this._properties.TryGetValue("method", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["method"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Dictionary<string, string>? Params
    {
        get
        {
            if (!this._properties.TryGetValue("params", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Dictionary<string, string>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["params"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public ApiEnum<string, TokenRequestRequestContentType>? RequestContentType
    {
        get
        {
            if (!this._properties.TryGetValue("request_content_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<string, TokenRequestRequestContentType>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["request_content_type"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public ApiEnum<string, TokenRequestResponseContentType>? ResponseContentType
    {
        get
        {
            if (!this._properties.TryGetValue("response_content_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<string, TokenRequestResponseContentType>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["response_content_type"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Dictionary<string, string>? ResponseMap
    {
        get
        {
            if (!this._properties.TryGetValue("response_map", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Dictionary<string, string>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["response_map"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
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

    public TokenRequest(IReadOnlyDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TokenRequest(FrozenDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static TokenRequest FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> properties)
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }

    [SetsRequiredMembers]
    public TokenRequest(string endpoint)
        : this()
    {
        this.Endpoint = endpoint;
    }
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

[JsonConverter(typeof(ModelConverter<UserInfoRequest>))]
public sealed record class UserInfoRequest : ModelBase, IFromRaw<UserInfoRequest>
{
    public required string Endpoint
    {
        get
        {
            if (!this._properties.TryGetValue("endpoint", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'endpoint' cannot be null",
                    new System::ArgumentOutOfRangeException("endpoint", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'endpoint' cannot be null",
                    new System::ArgumentNullException("endpoint")
                );
        }
        init
        {
            this._properties["endpoint"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required UserInfoRequestTriggers Triggers
    {
        get
        {
            if (!this._properties.TryGetValue("triggers", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'triggers' cannot be null",
                    new System::ArgumentOutOfRangeException("triggers", "Missing required argument")
                );

            return JsonSerializer.Deserialize<UserInfoRequestTriggers>(
                    element,
                    ModelBase.SerializerOptions
                )
                ?? throw new ArcadeInvalidDataException(
                    "'triggers' cannot be null",
                    new System::ArgumentNullException("triggers")
                );
        }
        init
        {
            this._properties["triggers"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? AuthHeaderValueFormat
    {
        get
        {
            if (!this._properties.TryGetValue("auth_header_value_format", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["auth_header_value_format"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? AuthMethod
    {
        get
        {
            if (!this._properties.TryGetValue("auth_method", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["auth_method"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Method
    {
        get
        {
            if (!this._properties.TryGetValue("method", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["method"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Dictionary<string, string>? Params
    {
        get
        {
            if (!this._properties.TryGetValue("params", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Dictionary<string, string>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["params"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public ApiEnum<string, UserInfoRequestRequestContentType>? RequestContentType
    {
        get
        {
            if (!this._properties.TryGetValue("request_content_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<string, UserInfoRequestRequestContentType>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["request_content_type"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public ApiEnum<string, UserInfoRequestResponseContentType>? ResponseContentType
    {
        get
        {
            if (!this._properties.TryGetValue("response_content_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<string, UserInfoRequestResponseContentType>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["response_content_type"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Dictionary<string, string>? ResponseMap
    {
        get
        {
            if (!this._properties.TryGetValue("response_map", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Dictionary<string, string>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["response_map"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
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

    public UserInfoRequest(IReadOnlyDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    UserInfoRequest(FrozenDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static UserInfoRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }
}

[JsonConverter(typeof(ModelConverter<UserInfoRequestTriggers>))]
public sealed record class UserInfoRequestTriggers : ModelBase, IFromRaw<UserInfoRequestTriggers>
{
    public bool? OnTokenGrant
    {
        get
        {
            if (!this._properties.TryGetValue("on_token_grant", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["on_token_grant"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public bool? OnTokenRefresh
    {
        get
        {
            if (!this._properties.TryGetValue("on_token_refresh", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["on_token_refresh"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.OnTokenGrant;
        _ = this.OnTokenRefresh;
    }

    public UserInfoRequestTriggers() { }

    public UserInfoRequestTriggers(IReadOnlyDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    UserInfoRequestTriggers(FrozenDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static UserInfoRequestTriggers FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }
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
