using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using System = System;

namespace ArcadeDotnet.Models.Admin.AuthProviders;

[JsonConverter(
    typeof(JsonModelConverter<AuthProviderCreateRequest, AuthProviderCreateRequestFromRaw>)
)]
public sealed record class AuthProviderCreateRequest : JsonModel
{
    public required string ID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("id");
        }
        init { this._rawData.Set("id", value); }
    }

    public string? Description
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("description");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("description", value);
        }
    }

    /// <summary>
    /// The unique external ID for the auth provider
    /// </summary>
    public string? ExternalID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("external_id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("external_id", value);
        }
    }

    public AuthProviderCreateRequestOauth2? Oauth2
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<AuthProviderCreateRequestOauth2>("oauth2");
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

    public string? ProviderID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("provider_id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("provider_id", value);
        }
    }

    public string? Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("status");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("status", value);
        }
    }

    public string? Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("type");
        }
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
        _ = this.Description;
        _ = this.ExternalID;
        this.Oauth2?.Validate();
        _ = this.ProviderID;
        _ = this.Status;
        _ = this.Type;
    }

    public AuthProviderCreateRequest() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AuthProviderCreateRequest(AuthProviderCreateRequest authProviderCreateRequest)
        : base(authProviderCreateRequest) { }
#pragma warning restore CS8618

    public AuthProviderCreateRequest(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderCreateRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderCreateRequestFromRaw.FromRawUnchecked"/>
    public static AuthProviderCreateRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public AuthProviderCreateRequest(string id)
        : this()
    {
        this.ID = id;
    }
}

class AuthProviderCreateRequestFromRaw : IFromRawJson<AuthProviderCreateRequest>
{
    /// <inheritdoc/>
    public AuthProviderCreateRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderCreateRequest.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        AuthProviderCreateRequestOauth2,
        AuthProviderCreateRequestOauth2FromRaw
    >)
)]
public sealed record class AuthProviderCreateRequestOauth2 : JsonModel
{
    public required string ClientID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("client_id");
        }
        init { this._rawData.Set("client_id", value); }
    }

    public AuthProviderCreateRequestOauth2AuthorizeRequest? AuthorizeRequest
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<AuthProviderCreateRequestOauth2AuthorizeRequest>(
                "authorize_request"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("authorize_request", value);
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

    public AuthProviderCreateRequestOauth2Pkce? Pkce
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<AuthProviderCreateRequestOauth2Pkce>("pkce");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("pkce", value);
        }
    }

    public AuthProviderCreateRequestOauth2RefreshRequest? RefreshRequest
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<AuthProviderCreateRequestOauth2RefreshRequest>(
                "refresh_request"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("refresh_request", value);
        }
    }

    public ApiEnum<string, AuthProviderCreateRequestOauth2ScopeDelimiter>? ScopeDelimiter
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, AuthProviderCreateRequestOauth2ScopeDelimiter>
            >("scope_delimiter");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("scope_delimiter", value);
        }
    }

    public AuthProviderCreateRequestOauth2TokenIntrospectionRequest? TokenIntrospectionRequest
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<AuthProviderCreateRequestOauth2TokenIntrospectionRequest>(
                "token_introspection_request"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("token_introspection_request", value);
        }
    }

    public AuthProviderCreateRequestOauth2TokenRequest? TokenRequest
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<AuthProviderCreateRequestOauth2TokenRequest>(
                "token_request"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("token_request", value);
        }
    }

    public AuthProviderCreateRequestOauth2UserInfoRequest? UserInfoRequest
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<AuthProviderCreateRequestOauth2UserInfoRequest>(
                "user_info_request"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("user_info_request", value);
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

    public AuthProviderCreateRequestOauth2() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AuthProviderCreateRequestOauth2(
        AuthProviderCreateRequestOauth2 authProviderCreateRequestOauth2
    )
        : base(authProviderCreateRequestOauth2) { }
#pragma warning restore CS8618

    public AuthProviderCreateRequestOauth2(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderCreateRequestOauth2(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderCreateRequestOauth2FromRaw.FromRawUnchecked"/>
    public static AuthProviderCreateRequestOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public AuthProviderCreateRequestOauth2(string clientID)
        : this()
    {
        this.ClientID = clientID;
    }
}

class AuthProviderCreateRequestOauth2FromRaw : IFromRawJson<AuthProviderCreateRequestOauth2>
{
    /// <inheritdoc/>
    public AuthProviderCreateRequestOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderCreateRequestOauth2.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        AuthProviderCreateRequestOauth2AuthorizeRequest,
        AuthProviderCreateRequestOauth2AuthorizeRequestFromRaw
    >)
)]
public sealed record class AuthProviderCreateRequestOauth2AuthorizeRequest : JsonModel
{
    public required string Endpoint
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("endpoint");
        }
        init { this._rawData.Set("endpoint", value); }
    }

    public string? AuthHeaderValueFormat
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("auth_header_value_format");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("auth_header_value_format", value);
        }
    }

    public string? AuthMethod
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("auth_method");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("auth_method", value);
        }
    }

    public string? Method
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("method");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("method", value);
        }
    }

    public IReadOnlyDictionary<string, string>? Params
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<FrozenDictionary<string, string>>("params");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<FrozenDictionary<string, string>?>(
                "params",
                value == null ? null : FrozenDictionary.ToFrozenDictionary(value)
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
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType>
            >("request_content_type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("request_content_type", value);
        }
    }

    public ApiEnum<
        string,
        AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType
    >? ResponseContentType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType>
            >("response_content_type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("response_content_type", value);
        }
    }

    public IReadOnlyDictionary<string, string>? ResponseMap
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<FrozenDictionary<string, string>>("response_map");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<FrozenDictionary<string, string>?>(
                "response_map",
                value == null ? null : FrozenDictionary.ToFrozenDictionary(value)
            );
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

    public AuthProviderCreateRequestOauth2AuthorizeRequest() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AuthProviderCreateRequestOauth2AuthorizeRequest(
        AuthProviderCreateRequestOauth2AuthorizeRequest authProviderCreateRequestOauth2AuthorizeRequest
    )
        : base(authProviderCreateRequestOauth2AuthorizeRequest) { }
#pragma warning restore CS8618

    public AuthProviderCreateRequestOauth2AuthorizeRequest(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderCreateRequestOauth2AuthorizeRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderCreateRequestOauth2AuthorizeRequestFromRaw.FromRawUnchecked"/>
    public static AuthProviderCreateRequestOauth2AuthorizeRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public AuthProviderCreateRequestOauth2AuthorizeRequest(string endpoint)
        : this()
    {
        this.Endpoint = endpoint;
    }
}

class AuthProviderCreateRequestOauth2AuthorizeRequestFromRaw
    : IFromRawJson<AuthProviderCreateRequestOauth2AuthorizeRequest>
{
    /// <inheritdoc/>
    public AuthProviderCreateRequestOauth2AuthorizeRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderCreateRequestOauth2AuthorizeRequest.FromRawUnchecked(rawData);
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

[JsonConverter(
    typeof(JsonModelConverter<
        AuthProviderCreateRequestOauth2Pkce,
        AuthProviderCreateRequestOauth2PkceFromRaw
    >)
)]
public sealed record class AuthProviderCreateRequestOauth2Pkce : JsonModel
{
    public string? CodeChallengeMethod
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("code_challenge_method");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("code_challenge_method", value);
        }
    }

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

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.CodeChallengeMethod;
        _ = this.Enabled;
    }

    public AuthProviderCreateRequestOauth2Pkce() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AuthProviderCreateRequestOauth2Pkce(
        AuthProviderCreateRequestOauth2Pkce authProviderCreateRequestOauth2Pkce
    )
        : base(authProviderCreateRequestOauth2Pkce) { }
#pragma warning restore CS8618

    public AuthProviderCreateRequestOauth2Pkce(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderCreateRequestOauth2Pkce(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderCreateRequestOauth2PkceFromRaw.FromRawUnchecked"/>
    public static AuthProviderCreateRequestOauth2Pkce FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthProviderCreateRequestOauth2PkceFromRaw : IFromRawJson<AuthProviderCreateRequestOauth2Pkce>
{
    /// <inheritdoc/>
    public AuthProviderCreateRequestOauth2Pkce FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderCreateRequestOauth2Pkce.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        AuthProviderCreateRequestOauth2RefreshRequest,
        AuthProviderCreateRequestOauth2RefreshRequestFromRaw
    >)
)]
public sealed record class AuthProviderCreateRequestOauth2RefreshRequest : JsonModel
{
    public required string Endpoint
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("endpoint");
        }
        init { this._rawData.Set("endpoint", value); }
    }

    public string? AuthHeaderValueFormat
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("auth_header_value_format");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("auth_header_value_format", value);
        }
    }

    public string? AuthMethod
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("auth_method");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("auth_method", value);
        }
    }

    public string? Method
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("method");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("method", value);
        }
    }

    public IReadOnlyDictionary<string, string>? Params
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<FrozenDictionary<string, string>>("params");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<FrozenDictionary<string, string>?>(
                "params",
                value == null ? null : FrozenDictionary.ToFrozenDictionary(value)
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
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, AuthProviderCreateRequestOauth2RefreshRequestRequestContentType>
            >("request_content_type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("request_content_type", value);
        }
    }

    public ApiEnum<
        string,
        AuthProviderCreateRequestOauth2RefreshRequestResponseContentType
    >? ResponseContentType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, AuthProviderCreateRequestOauth2RefreshRequestResponseContentType>
            >("response_content_type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("response_content_type", value);
        }
    }

    public IReadOnlyDictionary<string, string>? ResponseMap
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<FrozenDictionary<string, string>>("response_map");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<FrozenDictionary<string, string>?>(
                "response_map",
                value == null ? null : FrozenDictionary.ToFrozenDictionary(value)
            );
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

    public AuthProviderCreateRequestOauth2RefreshRequest() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AuthProviderCreateRequestOauth2RefreshRequest(
        AuthProviderCreateRequestOauth2RefreshRequest authProviderCreateRequestOauth2RefreshRequest
    )
        : base(authProviderCreateRequestOauth2RefreshRequest) { }
#pragma warning restore CS8618

    public AuthProviderCreateRequestOauth2RefreshRequest(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderCreateRequestOauth2RefreshRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderCreateRequestOauth2RefreshRequestFromRaw.FromRawUnchecked"/>
    public static AuthProviderCreateRequestOauth2RefreshRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public AuthProviderCreateRequestOauth2RefreshRequest(string endpoint)
        : this()
    {
        this.Endpoint = endpoint;
    }
}

class AuthProviderCreateRequestOauth2RefreshRequestFromRaw
    : IFromRawJson<AuthProviderCreateRequestOauth2RefreshRequest>
{
    /// <inheritdoc/>
    public AuthProviderCreateRequestOauth2RefreshRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderCreateRequestOauth2RefreshRequest.FromRawUnchecked(rawData);
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

[JsonConverter(
    typeof(JsonModelConverter<
        AuthProviderCreateRequestOauth2TokenIntrospectionRequest,
        AuthProviderCreateRequestOauth2TokenIntrospectionRequestFromRaw
    >)
)]
public sealed record class AuthProviderCreateRequestOauth2TokenIntrospectionRequest : JsonModel
{
    public required string Endpoint
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("endpoint");
        }
        init { this._rawData.Set("endpoint", value); }
    }

    public required AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers Triggers
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers>(
                "triggers"
            );
        }
        init { this._rawData.Set("triggers", value); }
    }

    public string? AuthHeaderValueFormat
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("auth_header_value_format");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("auth_header_value_format", value);
        }
    }

    public string? AuthMethod
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("auth_method");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("auth_method", value);
        }
    }

    public string? Method
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("method");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("method", value);
        }
    }

    public IReadOnlyDictionary<string, string>? Params
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<FrozenDictionary<string, string>>("params");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<FrozenDictionary<string, string>?>(
                "params",
                value == null ? null : FrozenDictionary.ToFrozenDictionary(value)
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
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<
                    string,
                    AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType
                >
            >("request_content_type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("request_content_type", value);
        }
    }

    public ApiEnum<
        string,
        AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType
    >? ResponseContentType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<
                    string,
                    AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType
                >
            >("response_content_type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("response_content_type", value);
        }
    }

    public IReadOnlyDictionary<string, string>? ResponseMap
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<FrozenDictionary<string, string>>("response_map");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<FrozenDictionary<string, string>?>(
                "response_map",
                value == null ? null : FrozenDictionary.ToFrozenDictionary(value)
            );
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

    public AuthProviderCreateRequestOauth2TokenIntrospectionRequest() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AuthProviderCreateRequestOauth2TokenIntrospectionRequest(
        AuthProviderCreateRequestOauth2TokenIntrospectionRequest authProviderCreateRequestOauth2TokenIntrospectionRequest
    )
        : base(authProviderCreateRequestOauth2TokenIntrospectionRequest) { }
#pragma warning restore CS8618

    public AuthProviderCreateRequestOauth2TokenIntrospectionRequest(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderCreateRequestOauth2TokenIntrospectionRequest(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderCreateRequestOauth2TokenIntrospectionRequestFromRaw.FromRawUnchecked"/>
    public static AuthProviderCreateRequestOauth2TokenIntrospectionRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthProviderCreateRequestOauth2TokenIntrospectionRequestFromRaw
    : IFromRawJson<AuthProviderCreateRequestOauth2TokenIntrospectionRequest>
{
    /// <inheritdoc/>
    public AuthProviderCreateRequestOauth2TokenIntrospectionRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderCreateRequestOauth2TokenIntrospectionRequest.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers,
        AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggersFromRaw
    >)
)]
public sealed record class AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers
    : JsonModel
{
    public bool? OnTokenGrant
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("on_token_grant");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("on_token_grant", value);
        }
    }

    public bool? OnTokenRefresh
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("on_token_refresh");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("on_token_refresh", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.OnTokenGrant;
        _ = this.OnTokenRefresh;
    }

    public AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers(
        AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers authProviderCreateRequestOauth2TokenIntrospectionRequestTriggers
    )
        : base(authProviderCreateRequestOauth2TokenIntrospectionRequestTriggers) { }
#pragma warning restore CS8618

    public AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggersFromRaw.FromRawUnchecked"/>
    public static AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggersFromRaw
    : IFromRawJson<AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers>
{
    /// <inheritdoc/>
    public AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers.FromRawUnchecked(rawData);
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

[JsonConverter(
    typeof(JsonModelConverter<
        AuthProviderCreateRequestOauth2TokenRequest,
        AuthProviderCreateRequestOauth2TokenRequestFromRaw
    >)
)]
public sealed record class AuthProviderCreateRequestOauth2TokenRequest : JsonModel
{
    public required string Endpoint
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("endpoint");
        }
        init { this._rawData.Set("endpoint", value); }
    }

    public string? AuthHeaderValueFormat
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("auth_header_value_format");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("auth_header_value_format", value);
        }
    }

    public string? AuthMethod
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("auth_method");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("auth_method", value);
        }
    }

    public string? Method
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("method");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("method", value);
        }
    }

    public IReadOnlyDictionary<string, string>? Params
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<FrozenDictionary<string, string>>("params");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<FrozenDictionary<string, string>?>(
                "params",
                value == null ? null : FrozenDictionary.ToFrozenDictionary(value)
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
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, AuthProviderCreateRequestOauth2TokenRequestRequestContentType>
            >("request_content_type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("request_content_type", value);
        }
    }

    public ApiEnum<
        string,
        AuthProviderCreateRequestOauth2TokenRequestResponseContentType
    >? ResponseContentType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, AuthProviderCreateRequestOauth2TokenRequestResponseContentType>
            >("response_content_type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("response_content_type", value);
        }
    }

    public IReadOnlyDictionary<string, string>? ResponseMap
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<FrozenDictionary<string, string>>("response_map");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<FrozenDictionary<string, string>?>(
                "response_map",
                value == null ? null : FrozenDictionary.ToFrozenDictionary(value)
            );
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

    public AuthProviderCreateRequestOauth2TokenRequest() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AuthProviderCreateRequestOauth2TokenRequest(
        AuthProviderCreateRequestOauth2TokenRequest authProviderCreateRequestOauth2TokenRequest
    )
        : base(authProviderCreateRequestOauth2TokenRequest) { }
#pragma warning restore CS8618

    public AuthProviderCreateRequestOauth2TokenRequest(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderCreateRequestOauth2TokenRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderCreateRequestOauth2TokenRequestFromRaw.FromRawUnchecked"/>
    public static AuthProviderCreateRequestOauth2TokenRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public AuthProviderCreateRequestOauth2TokenRequest(string endpoint)
        : this()
    {
        this.Endpoint = endpoint;
    }
}

class AuthProviderCreateRequestOauth2TokenRequestFromRaw
    : IFromRawJson<AuthProviderCreateRequestOauth2TokenRequest>
{
    /// <inheritdoc/>
    public AuthProviderCreateRequestOauth2TokenRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderCreateRequestOauth2TokenRequest.FromRawUnchecked(rawData);
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

[JsonConverter(
    typeof(JsonModelConverter<
        AuthProviderCreateRequestOauth2UserInfoRequest,
        AuthProviderCreateRequestOauth2UserInfoRequestFromRaw
    >)
)]
public sealed record class AuthProviderCreateRequestOauth2UserInfoRequest : JsonModel
{
    public required string Endpoint
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("endpoint");
        }
        init { this._rawData.Set("endpoint", value); }
    }

    public required AuthProviderCreateRequestOauth2UserInfoRequestTriggers Triggers
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<AuthProviderCreateRequestOauth2UserInfoRequestTriggers>(
                "triggers"
            );
        }
        init { this._rawData.Set("triggers", value); }
    }

    public string? AuthHeaderValueFormat
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("auth_header_value_format");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("auth_header_value_format", value);
        }
    }

    public string? AuthMethod
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("auth_method");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("auth_method", value);
        }
    }

    public string? Method
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("method");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("method", value);
        }
    }

    public IReadOnlyDictionary<string, string>? Params
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<FrozenDictionary<string, string>>("params");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<FrozenDictionary<string, string>?>(
                "params",
                value == null ? null : FrozenDictionary.ToFrozenDictionary(value)
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
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType>
            >("request_content_type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("request_content_type", value);
        }
    }

    public ApiEnum<
        string,
        AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType
    >? ResponseContentType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType>
            >("response_content_type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("response_content_type", value);
        }
    }

    public IReadOnlyDictionary<string, string>? ResponseMap
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<FrozenDictionary<string, string>>("response_map");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<FrozenDictionary<string, string>?>(
                "response_map",
                value == null ? null : FrozenDictionary.ToFrozenDictionary(value)
            );
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

    public AuthProviderCreateRequestOauth2UserInfoRequest() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AuthProviderCreateRequestOauth2UserInfoRequest(
        AuthProviderCreateRequestOauth2UserInfoRequest authProviderCreateRequestOauth2UserInfoRequest
    )
        : base(authProviderCreateRequestOauth2UserInfoRequest) { }
#pragma warning restore CS8618

    public AuthProviderCreateRequestOauth2UserInfoRequest(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderCreateRequestOauth2UserInfoRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderCreateRequestOauth2UserInfoRequestFromRaw.FromRawUnchecked"/>
    public static AuthProviderCreateRequestOauth2UserInfoRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthProviderCreateRequestOauth2UserInfoRequestFromRaw
    : IFromRawJson<AuthProviderCreateRequestOauth2UserInfoRequest>
{
    /// <inheritdoc/>
    public AuthProviderCreateRequestOauth2UserInfoRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderCreateRequestOauth2UserInfoRequest.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        AuthProviderCreateRequestOauth2UserInfoRequestTriggers,
        AuthProviderCreateRequestOauth2UserInfoRequestTriggersFromRaw
    >)
)]
public sealed record class AuthProviderCreateRequestOauth2UserInfoRequestTriggers : JsonModel
{
    public bool? OnTokenGrant
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("on_token_grant");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("on_token_grant", value);
        }
    }

    public bool? OnTokenRefresh
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("on_token_refresh");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("on_token_refresh", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.OnTokenGrant;
        _ = this.OnTokenRefresh;
    }

    public AuthProviderCreateRequestOauth2UserInfoRequestTriggers() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AuthProviderCreateRequestOauth2UserInfoRequestTriggers(
        AuthProviderCreateRequestOauth2UserInfoRequestTriggers authProviderCreateRequestOauth2UserInfoRequestTriggers
    )
        : base(authProviderCreateRequestOauth2UserInfoRequestTriggers) { }
#pragma warning restore CS8618

    public AuthProviderCreateRequestOauth2UserInfoRequestTriggers(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderCreateRequestOauth2UserInfoRequestTriggers(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderCreateRequestOauth2UserInfoRequestTriggersFromRaw.FromRawUnchecked"/>
    public static AuthProviderCreateRequestOauth2UserInfoRequestTriggers FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthProviderCreateRequestOauth2UserInfoRequestTriggersFromRaw
    : IFromRawJson<AuthProviderCreateRequestOauth2UserInfoRequestTriggers>
{
    /// <inheritdoc/>
    public AuthProviderCreateRequestOauth2UserInfoRequestTriggers FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderCreateRequestOauth2UserInfoRequestTriggers.FromRawUnchecked(rawData);
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
