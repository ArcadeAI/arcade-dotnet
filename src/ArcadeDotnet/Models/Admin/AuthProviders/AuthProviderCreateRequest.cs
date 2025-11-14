using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using System = System;

namespace ArcadeDotnet.Models.Admin.AuthProviders;

[JsonConverter(typeof(ModelConverter<AuthProviderCreateRequest>))]
public sealed record class AuthProviderCreateRequest
    : ModelBase,
        IFromRaw<AuthProviderCreateRequest>
{
    public required string ID
    {
        get
        {
            if (!this._properties.TryGetValue("id", out JsonElement element))
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
            this._properties["id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Description
    {
        get
        {
            if (!this._properties.TryGetValue("description", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["description"] = JsonSerializer.SerializeToElement(
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
            if (!this._properties.TryGetValue("external_id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["external_id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public AuthProviderCreateRequestOauth2? Oauth2
    {
        get
        {
            if (!this._properties.TryGetValue("oauth2", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<AuthProviderCreateRequestOauth2?>(
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

            this._properties["oauth2"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? ProviderID
    {
        get
        {
            if (!this._properties.TryGetValue("provider_id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["provider_id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Status
    {
        get
        {
            if (!this._properties.TryGetValue("status", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["status"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Type
    {
        get
        {
            if (!this._properties.TryGetValue("type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["type"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.ID;
        _ = this.Description;
        _ = this.ExternalID;
        this.Oauth2?.Validate();
        _ = this.ProviderID;
        _ = this.Status;
        _ = this.Type;
    }

    public AuthProviderCreateRequest() { }

    public AuthProviderCreateRequest(IReadOnlyDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderCreateRequest(FrozenDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static AuthProviderCreateRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }

    [SetsRequiredMembers]
    public AuthProviderCreateRequest(string id)
        : this()
    {
        this.ID = id;
    }
}

[JsonConverter(typeof(ModelConverter<AuthProviderCreateRequestOauth2>))]
public sealed record class AuthProviderCreateRequestOauth2
    : ModelBase,
        IFromRaw<AuthProviderCreateRequestOauth2>
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

    public AuthProviderCreateRequestOauth2AuthorizeRequest? AuthorizeRequest
    {
        get
        {
            if (!this._properties.TryGetValue("authorize_request", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<AuthProviderCreateRequestOauth2AuthorizeRequest?>(
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

    public AuthProviderCreateRequestOauth2Pkce? Pkce
    {
        get
        {
            if (!this._properties.TryGetValue("pkce", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<AuthProviderCreateRequestOauth2Pkce?>(
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

            this._properties["pkce"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public AuthProviderCreateRequestOauth2RefreshRequest? RefreshRequest
    {
        get
        {
            if (!this._properties.TryGetValue("refresh_request", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<AuthProviderCreateRequestOauth2RefreshRequest?>(
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

    public ApiEnum<string, AuthProviderCreateRequestOauth2ScopeDelimiter>? ScopeDelimiter
    {
        get
        {
            if (!this._properties.TryGetValue("scope_delimiter", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<
                string,
                AuthProviderCreateRequestOauth2ScopeDelimiter
            >?>(element, ModelBase.SerializerOptions);
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

    public AuthProviderCreateRequestOauth2TokenIntrospectionRequest? TokenIntrospectionRequest
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

            return JsonSerializer.Deserialize<AuthProviderCreateRequestOauth2TokenIntrospectionRequest?>(
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

    public AuthProviderCreateRequestOauth2TokenRequest? TokenRequest
    {
        get
        {
            if (!this._properties.TryGetValue("token_request", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<AuthProviderCreateRequestOauth2TokenRequest?>(
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

            this._properties["token_request"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public AuthProviderCreateRequestOauth2UserInfoRequest? UserInfoRequest
    {
        get
        {
            if (!this._properties.TryGetValue("user_info_request", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<AuthProviderCreateRequestOauth2UserInfoRequest?>(
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

    public AuthProviderCreateRequestOauth2() { }

    public AuthProviderCreateRequestOauth2(IReadOnlyDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderCreateRequestOauth2(FrozenDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static AuthProviderCreateRequestOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }

    [SetsRequiredMembers]
    public AuthProviderCreateRequestOauth2(string clientID)
        : this()
    {
        this.ClientID = clientID;
    }
}

[JsonConverter(typeof(ModelConverter<AuthProviderCreateRequestOauth2AuthorizeRequest>))]
public sealed record class AuthProviderCreateRequestOauth2AuthorizeRequest
    : ModelBase,
        IFromRaw<AuthProviderCreateRequestOauth2AuthorizeRequest>
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

    public ApiEnum<
        string,
        AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType
    >? RequestContentType
    {
        get
        {
            if (!this._properties.TryGetValue("request_content_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<
                string,
                AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType
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

    public ApiEnum<
        string,
        AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType
    >? ResponseContentType
    {
        get
        {
            if (!this._properties.TryGetValue("response_content_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<
                string,
                AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType
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
        _ = this.AuthHeaderValueFormat;
        _ = this.AuthMethod;
        _ = this.Method;
        _ = this.Params;
        this.RequestContentType?.Validate();
        this.ResponseContentType?.Validate();
        _ = this.ResponseMap;
    }

    public AuthProviderCreateRequestOauth2AuthorizeRequest() { }

    public AuthProviderCreateRequestOauth2AuthorizeRequest(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderCreateRequestOauth2AuthorizeRequest(
        FrozenDictionary<string, JsonElement> properties
    )
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static AuthProviderCreateRequestOauth2AuthorizeRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }

    [SetsRequiredMembers]
    public AuthProviderCreateRequestOauth2AuthorizeRequest(string endpoint)
        : this()
    {
        this.Endpoint = endpoint;
    }
}

[JsonConverter(typeof(AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentTypeConverter))]
public enum AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentTypeConverter
    : JsonConverter<AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType>
{
    public override AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            "application/json" =>
                AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType.ApplicationJson,
            _ => (AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType.ApplicationJson =>
                    "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentTypeConverter))]
public enum AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentTypeConverter
    : JsonConverter<AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType>
{
    public override AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            "application/json" =>
                AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType.ApplicationJson,
            _ => (AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType.ApplicationJson =>
                    "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(ModelConverter<AuthProviderCreateRequestOauth2Pkce>))]
public sealed record class AuthProviderCreateRequestOauth2Pkce
    : ModelBase,
        IFromRaw<AuthProviderCreateRequestOauth2Pkce>
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

    public AuthProviderCreateRequestOauth2Pkce() { }

    public AuthProviderCreateRequestOauth2Pkce(IReadOnlyDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderCreateRequestOauth2Pkce(FrozenDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static AuthProviderCreateRequestOauth2Pkce FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }
}

[JsonConverter(typeof(ModelConverter<AuthProviderCreateRequestOauth2RefreshRequest>))]
public sealed record class AuthProviderCreateRequestOauth2RefreshRequest
    : ModelBase,
        IFromRaw<AuthProviderCreateRequestOauth2RefreshRequest>
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

    public ApiEnum<
        string,
        AuthProviderCreateRequestOauth2RefreshRequestRequestContentType
    >? RequestContentType
    {
        get
        {
            if (!this._properties.TryGetValue("request_content_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<
                string,
                AuthProviderCreateRequestOauth2RefreshRequestRequestContentType
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

    public ApiEnum<
        string,
        AuthProviderCreateRequestOauth2RefreshRequestResponseContentType
    >? ResponseContentType
    {
        get
        {
            if (!this._properties.TryGetValue("response_content_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<
                string,
                AuthProviderCreateRequestOauth2RefreshRequestResponseContentType
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
        _ = this.AuthHeaderValueFormat;
        _ = this.AuthMethod;
        _ = this.Method;
        _ = this.Params;
        this.RequestContentType?.Validate();
        this.ResponseContentType?.Validate();
        _ = this.ResponseMap;
    }

    public AuthProviderCreateRequestOauth2RefreshRequest() { }

    public AuthProviderCreateRequestOauth2RefreshRequest(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderCreateRequestOauth2RefreshRequest(FrozenDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static AuthProviderCreateRequestOauth2RefreshRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }

    [SetsRequiredMembers]
    public AuthProviderCreateRequestOauth2RefreshRequest(string endpoint)
        : this()
    {
        this.Endpoint = endpoint;
    }
}

[JsonConverter(typeof(AuthProviderCreateRequestOauth2RefreshRequestRequestContentTypeConverter))]
public enum AuthProviderCreateRequestOauth2RefreshRequestRequestContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class AuthProviderCreateRequestOauth2RefreshRequestRequestContentTypeConverter
    : JsonConverter<AuthProviderCreateRequestOauth2RefreshRequestRequestContentType>
{
    public override AuthProviderCreateRequestOauth2RefreshRequestRequestContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                AuthProviderCreateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            "application/json" =>
                AuthProviderCreateRequestOauth2RefreshRequestRequestContentType.ApplicationJson,
            _ => (AuthProviderCreateRequestOauth2RefreshRequestRequestContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AuthProviderCreateRequestOauth2RefreshRequestRequestContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AuthProviderCreateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                AuthProviderCreateRequestOauth2RefreshRequestRequestContentType.ApplicationJson =>
                    "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(AuthProviderCreateRequestOauth2RefreshRequestResponseContentTypeConverter))]
public enum AuthProviderCreateRequestOauth2RefreshRequestResponseContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class AuthProviderCreateRequestOauth2RefreshRequestResponseContentTypeConverter
    : JsonConverter<AuthProviderCreateRequestOauth2RefreshRequestResponseContentType>
{
    public override AuthProviderCreateRequestOauth2RefreshRequestResponseContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                AuthProviderCreateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            "application/json" =>
                AuthProviderCreateRequestOauth2RefreshRequestResponseContentType.ApplicationJson,
            _ => (AuthProviderCreateRequestOauth2RefreshRequestResponseContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AuthProviderCreateRequestOauth2RefreshRequestResponseContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AuthProviderCreateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                AuthProviderCreateRequestOauth2RefreshRequestResponseContentType.ApplicationJson =>
                    "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(AuthProviderCreateRequestOauth2ScopeDelimiterConverter))]
public enum AuthProviderCreateRequestOauth2ScopeDelimiter
{
    Undefined,
    V1,
}

sealed class AuthProviderCreateRequestOauth2ScopeDelimiterConverter
    : JsonConverter<AuthProviderCreateRequestOauth2ScopeDelimiter>
{
    public override AuthProviderCreateRequestOauth2ScopeDelimiter Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "," => AuthProviderCreateRequestOauth2ScopeDelimiter.Undefined,
            " " => AuthProviderCreateRequestOauth2ScopeDelimiter.V1,
            _ => (AuthProviderCreateRequestOauth2ScopeDelimiter)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AuthProviderCreateRequestOauth2ScopeDelimiter value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AuthProviderCreateRequestOauth2ScopeDelimiter.Undefined => ",",
                AuthProviderCreateRequestOauth2ScopeDelimiter.V1 => " ",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(ModelConverter<AuthProviderCreateRequestOauth2TokenIntrospectionRequest>))]
public sealed record class AuthProviderCreateRequestOauth2TokenIntrospectionRequest
    : ModelBase,
        IFromRaw<AuthProviderCreateRequestOauth2TokenIntrospectionRequest>
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

    public required AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers Triggers
    {
        get
        {
            if (!this._properties.TryGetValue("triggers", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'triggers' cannot be null",
                    new System::ArgumentOutOfRangeException("triggers", "Missing required argument")
                );

            return JsonSerializer.Deserialize<AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers>(
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

    public ApiEnum<
        string,
        AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType
    >? RequestContentType
    {
        get
        {
            if (!this._properties.TryGetValue("request_content_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<
                string,
                AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType
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

    public ApiEnum<
        string,
        AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType
    >? ResponseContentType
    {
        get
        {
            if (!this._properties.TryGetValue("response_content_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<
                string,
                AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType
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

    public AuthProviderCreateRequestOauth2TokenIntrospectionRequest() { }

    public AuthProviderCreateRequestOauth2TokenIntrospectionRequest(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderCreateRequestOauth2TokenIntrospectionRequest(
        FrozenDictionary<string, JsonElement> properties
    )
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static AuthProviderCreateRequestOauth2TokenIntrospectionRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }
}

[JsonConverter(
    typeof(ModelConverter<AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers>)
)]
public sealed record class AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers
    : ModelBase,
        IFromRaw<AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers>
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

    public AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers() { }

    public AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers(
        FrozenDictionary<string, JsonElement> properties
    )
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }
}

[JsonConverter(
    typeof(AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentTypeConverter)
)]
public enum AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentTypeConverter
    : JsonConverter<AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType>
{
    public override AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            "application/json" =>
                AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType.ApplicationJson,
            _ => (AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType.ApplicationJson =>
                    "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(
    typeof(AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentTypeConverter)
)]
public enum AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentTypeConverter
    : JsonConverter<AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType>
{
    public override AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            "application/json" =>
                AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType.ApplicationJson,
            _ => (AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType.ApplicationJson =>
                    "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(ModelConverter<AuthProviderCreateRequestOauth2TokenRequest>))]
public sealed record class AuthProviderCreateRequestOauth2TokenRequest
    : ModelBase,
        IFromRaw<AuthProviderCreateRequestOauth2TokenRequest>
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

    public ApiEnum<
        string,
        AuthProviderCreateRequestOauth2TokenRequestRequestContentType
    >? RequestContentType
    {
        get
        {
            if (!this._properties.TryGetValue("request_content_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<
                string,
                AuthProviderCreateRequestOauth2TokenRequestRequestContentType
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

    public ApiEnum<
        string,
        AuthProviderCreateRequestOauth2TokenRequestResponseContentType
    >? ResponseContentType
    {
        get
        {
            if (!this._properties.TryGetValue("response_content_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<
                string,
                AuthProviderCreateRequestOauth2TokenRequestResponseContentType
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
        _ = this.AuthHeaderValueFormat;
        _ = this.AuthMethod;
        _ = this.Method;
        _ = this.Params;
        this.RequestContentType?.Validate();
        this.ResponseContentType?.Validate();
        _ = this.ResponseMap;
    }

    public AuthProviderCreateRequestOauth2TokenRequest() { }

    public AuthProviderCreateRequestOauth2TokenRequest(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderCreateRequestOauth2TokenRequest(FrozenDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static AuthProviderCreateRequestOauth2TokenRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }

    [SetsRequiredMembers]
    public AuthProviderCreateRequestOauth2TokenRequest(string endpoint)
        : this()
    {
        this.Endpoint = endpoint;
    }
}

[JsonConverter(typeof(AuthProviderCreateRequestOauth2TokenRequestRequestContentTypeConverter))]
public enum AuthProviderCreateRequestOauth2TokenRequestRequestContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class AuthProviderCreateRequestOauth2TokenRequestRequestContentTypeConverter
    : JsonConverter<AuthProviderCreateRequestOauth2TokenRequestRequestContentType>
{
    public override AuthProviderCreateRequestOauth2TokenRequestRequestContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                AuthProviderCreateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            "application/json" =>
                AuthProviderCreateRequestOauth2TokenRequestRequestContentType.ApplicationJson,
            _ => (AuthProviderCreateRequestOauth2TokenRequestRequestContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AuthProviderCreateRequestOauth2TokenRequestRequestContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AuthProviderCreateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                AuthProviderCreateRequestOauth2TokenRequestRequestContentType.ApplicationJson =>
                    "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(AuthProviderCreateRequestOauth2TokenRequestResponseContentTypeConverter))]
public enum AuthProviderCreateRequestOauth2TokenRequestResponseContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class AuthProviderCreateRequestOauth2TokenRequestResponseContentTypeConverter
    : JsonConverter<AuthProviderCreateRequestOauth2TokenRequestResponseContentType>
{
    public override AuthProviderCreateRequestOauth2TokenRequestResponseContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                AuthProviderCreateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            "application/json" =>
                AuthProviderCreateRequestOauth2TokenRequestResponseContentType.ApplicationJson,
            _ => (AuthProviderCreateRequestOauth2TokenRequestResponseContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AuthProviderCreateRequestOauth2TokenRequestResponseContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AuthProviderCreateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                AuthProviderCreateRequestOauth2TokenRequestResponseContentType.ApplicationJson =>
                    "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(ModelConverter<AuthProviderCreateRequestOauth2UserInfoRequest>))]
public sealed record class AuthProviderCreateRequestOauth2UserInfoRequest
    : ModelBase,
        IFromRaw<AuthProviderCreateRequestOauth2UserInfoRequest>
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

    public required AuthProviderCreateRequestOauth2UserInfoRequestTriggers Triggers
    {
        get
        {
            if (!this._properties.TryGetValue("triggers", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'triggers' cannot be null",
                    new System::ArgumentOutOfRangeException("triggers", "Missing required argument")
                );

            return JsonSerializer.Deserialize<AuthProviderCreateRequestOauth2UserInfoRequestTriggers>(
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

    public ApiEnum<
        string,
        AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType
    >? RequestContentType
    {
        get
        {
            if (!this._properties.TryGetValue("request_content_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<
                string,
                AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType
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

    public ApiEnum<
        string,
        AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType
    >? ResponseContentType
    {
        get
        {
            if (!this._properties.TryGetValue("response_content_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<
                string,
                AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType
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

    public AuthProviderCreateRequestOauth2UserInfoRequest() { }

    public AuthProviderCreateRequestOauth2UserInfoRequest(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderCreateRequestOauth2UserInfoRequest(FrozenDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static AuthProviderCreateRequestOauth2UserInfoRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }
}

[JsonConverter(typeof(ModelConverter<AuthProviderCreateRequestOauth2UserInfoRequestTriggers>))]
public sealed record class AuthProviderCreateRequestOauth2UserInfoRequestTriggers
    : ModelBase,
        IFromRaw<AuthProviderCreateRequestOauth2UserInfoRequestTriggers>
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

    public AuthProviderCreateRequestOauth2UserInfoRequestTriggers() { }

    public AuthProviderCreateRequestOauth2UserInfoRequestTriggers(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderCreateRequestOauth2UserInfoRequestTriggers(
        FrozenDictionary<string, JsonElement> properties
    )
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static AuthProviderCreateRequestOauth2UserInfoRequestTriggers FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }
}

[JsonConverter(typeof(AuthProviderCreateRequestOauth2UserInfoRequestRequestContentTypeConverter))]
public enum AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class AuthProviderCreateRequestOauth2UserInfoRequestRequestContentTypeConverter
    : JsonConverter<AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType>
{
    public override AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            "application/json" =>
                AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType.ApplicationJson,
            _ => (AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType.ApplicationJson =>
                    "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(AuthProviderCreateRequestOauth2UserInfoRequestResponseContentTypeConverter))]
public enum AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class AuthProviderCreateRequestOauth2UserInfoRequestResponseContentTypeConverter
    : JsonConverter<AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType>
{
    public override AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            "application/json" =>
                AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType.ApplicationJson,
            _ => (AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType.ApplicationJson =>
                    "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
