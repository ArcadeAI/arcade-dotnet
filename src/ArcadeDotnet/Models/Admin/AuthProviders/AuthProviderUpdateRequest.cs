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
    typeof(JsonModelConverter<AuthProviderUpdateRequest, AuthProviderUpdateRequestFromRaw>)
)]
public sealed record class AuthProviderUpdateRequest : JsonModel
{
    public string? ID
    {
        get { return this._rawData.GetNullableClass<string>("id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("id", value);
        }
    }

    public string? Description
    {
        get { return this._rawData.GetNullableClass<string>("description"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("description", value);
        }
    }

    public AuthProviderUpdateRequestOauth2? Oauth2
    {
        get { return this._rawData.GetNullableClass<AuthProviderUpdateRequestOauth2>("oauth2"); }
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
        get { return this._rawData.GetNullableClass<string>("provider_id"); }
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
        get { return this._rawData.GetNullableClass<string>("status"); }
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
        _ = this.Description;
        this.Oauth2?.Validate();
        _ = this.ProviderID;
        _ = this.Status;
        _ = this.Type;
    }

    public AuthProviderUpdateRequest() { }

    public AuthProviderUpdateRequest(AuthProviderUpdateRequest authProviderUpdateRequest)
        : base(authProviderUpdateRequest) { }

    public AuthProviderUpdateRequest(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderUpdateRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderUpdateRequestFromRaw.FromRawUnchecked"/>
    public static AuthProviderUpdateRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthProviderUpdateRequestFromRaw : IFromRawJson<AuthProviderUpdateRequest>
{
    /// <inheritdoc/>
    public AuthProviderUpdateRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderUpdateRequest.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        AuthProviderUpdateRequestOauth2,
        AuthProviderUpdateRequestOauth2FromRaw
    >)
)]
public sealed record class AuthProviderUpdateRequestOauth2 : JsonModel
{
    public AuthProviderUpdateRequestOauth2AuthorizeRequest? AuthorizeRequest
    {
        get
        {
            return this._rawData.GetNullableClass<AuthProviderUpdateRequestOauth2AuthorizeRequest>(
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

    public AuthProviderUpdateRequestOauth2Pkce? Pkce
    {
        get { return this._rawData.GetNullableClass<AuthProviderUpdateRequestOauth2Pkce>("pkce"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("pkce", value);
        }
    }

    public AuthProviderUpdateRequestOauth2RefreshRequest? RefreshRequest
    {
        get
        {
            return this._rawData.GetNullableClass<AuthProviderUpdateRequestOauth2RefreshRequest>(
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

    public ApiEnum<string, AuthProviderUpdateRequestOauth2ScopeDelimiter>? ScopeDelimiter
    {
        get
        {
            return this._rawData.GetNullableClass<
                ApiEnum<string, AuthProviderUpdateRequestOauth2ScopeDelimiter>
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

    public AuthProviderUpdateRequestOauth2TokenRequest? TokenRequest
    {
        get
        {
            return this._rawData.GetNullableClass<AuthProviderUpdateRequestOauth2TokenRequest>(
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

    public AuthProviderUpdateRequestOauth2UserInfoRequest? UserInfoRequest
    {
        get
        {
            return this._rawData.GetNullableClass<AuthProviderUpdateRequestOauth2UserInfoRequest>(
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
        this.AuthorizeRequest?.Validate();
        _ = this.ClientID;
        _ = this.ClientSecret;
        this.Pkce?.Validate();
        this.RefreshRequest?.Validate();
        this.ScopeDelimiter?.Validate();
        this.TokenRequest?.Validate();
        this.UserInfoRequest?.Validate();
    }

    public AuthProviderUpdateRequestOauth2() { }

    public AuthProviderUpdateRequestOauth2(
        AuthProviderUpdateRequestOauth2 authProviderUpdateRequestOauth2
    )
        : base(authProviderUpdateRequestOauth2) { }

    public AuthProviderUpdateRequestOauth2(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderUpdateRequestOauth2(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderUpdateRequestOauth2FromRaw.FromRawUnchecked"/>
    public static AuthProviderUpdateRequestOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthProviderUpdateRequestOauth2FromRaw : IFromRawJson<AuthProviderUpdateRequestOauth2>
{
    /// <inheritdoc/>
    public AuthProviderUpdateRequestOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderUpdateRequestOauth2.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        AuthProviderUpdateRequestOauth2AuthorizeRequest,
        AuthProviderUpdateRequestOauth2AuthorizeRequestFromRaw
    >)
)]
public sealed record class AuthProviderUpdateRequestOauth2AuthorizeRequest : JsonModel
{
    public string? AuthHeaderValueFormat
    {
        get { return this._rawData.GetNullableClass<string>("auth_header_value_format"); }
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
        get { return this._rawData.GetNullableClass<string>("auth_method"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("auth_method", value);
        }
    }

    public string? Endpoint
    {
        get { return this._rawData.GetNullableClass<string>("endpoint"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("endpoint", value);
        }
    }

    public string? Method
    {
        get { return this._rawData.GetNullableClass<string>("method"); }
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
        get { return this._rawData.GetNullableClass<FrozenDictionary<string, string>>("params"); }
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
        AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType
    >? RequestContentType
    {
        get
        {
            return this._rawData.GetNullableClass<
                ApiEnum<string, AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType>
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
        AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType
    >? ResponseContentType
    {
        get
        {
            return this._rawData.GetNullableClass<
                ApiEnum<string, AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType>
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
        _ = this.AuthHeaderValueFormat;
        _ = this.AuthMethod;
        _ = this.Endpoint;
        _ = this.Method;
        _ = this.Params;
        this.RequestContentType?.Validate();
        this.ResponseContentType?.Validate();
        _ = this.ResponseMap;
    }

    public AuthProviderUpdateRequestOauth2AuthorizeRequest() { }

    public AuthProviderUpdateRequestOauth2AuthorizeRequest(
        AuthProviderUpdateRequestOauth2AuthorizeRequest authProviderUpdateRequestOauth2AuthorizeRequest
    )
        : base(authProviderUpdateRequestOauth2AuthorizeRequest) { }

    public AuthProviderUpdateRequestOauth2AuthorizeRequest(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderUpdateRequestOauth2AuthorizeRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderUpdateRequestOauth2AuthorizeRequestFromRaw.FromRawUnchecked"/>
    public static AuthProviderUpdateRequestOauth2AuthorizeRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthProviderUpdateRequestOauth2AuthorizeRequestFromRaw
    : IFromRawJson<AuthProviderUpdateRequestOauth2AuthorizeRequest>
{
    /// <inheritdoc/>
    public AuthProviderUpdateRequestOauth2AuthorizeRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderUpdateRequestOauth2AuthorizeRequest.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentTypeConverter))]
public enum AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentTypeConverter
    : JsonConverter<AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType>
{
    public override AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            "application/json" =>
                AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType.ApplicationJson,
            _ => (AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType.ApplicationJson =>
                    "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentTypeConverter))]
public enum AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentTypeConverter
    : JsonConverter<AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType>
{
    public override AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            "application/json" =>
                AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType.ApplicationJson,
            _ => (AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType.ApplicationJson =>
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
        AuthProviderUpdateRequestOauth2Pkce,
        AuthProviderUpdateRequestOauth2PkceFromRaw
    >)
)]
public sealed record class AuthProviderUpdateRequestOauth2Pkce : JsonModel
{
    public string? CodeChallengeMethod
    {
        get { return this._rawData.GetNullableClass<string>("code_challenge_method"); }
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

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.CodeChallengeMethod;
        _ = this.Enabled;
    }

    public AuthProviderUpdateRequestOauth2Pkce() { }

    public AuthProviderUpdateRequestOauth2Pkce(
        AuthProviderUpdateRequestOauth2Pkce authProviderUpdateRequestOauth2Pkce
    )
        : base(authProviderUpdateRequestOauth2Pkce) { }

    public AuthProviderUpdateRequestOauth2Pkce(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderUpdateRequestOauth2Pkce(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderUpdateRequestOauth2PkceFromRaw.FromRawUnchecked"/>
    public static AuthProviderUpdateRequestOauth2Pkce FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthProviderUpdateRequestOauth2PkceFromRaw : IFromRawJson<AuthProviderUpdateRequestOauth2Pkce>
{
    /// <inheritdoc/>
    public AuthProviderUpdateRequestOauth2Pkce FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderUpdateRequestOauth2Pkce.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        AuthProviderUpdateRequestOauth2RefreshRequest,
        AuthProviderUpdateRequestOauth2RefreshRequestFromRaw
    >)
)]
public sealed record class AuthProviderUpdateRequestOauth2RefreshRequest : JsonModel
{
    public string? AuthHeaderValueFormat
    {
        get { return this._rawData.GetNullableClass<string>("auth_header_value_format"); }
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
        get { return this._rawData.GetNullableClass<string>("auth_method"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("auth_method", value);
        }
    }

    public string? Endpoint
    {
        get { return this._rawData.GetNullableClass<string>("endpoint"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("endpoint", value);
        }
    }

    public string? Method
    {
        get { return this._rawData.GetNullableClass<string>("method"); }
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
        get { return this._rawData.GetNullableClass<FrozenDictionary<string, string>>("params"); }
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
        AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType
    >? RequestContentType
    {
        get
        {
            return this._rawData.GetNullableClass<
                ApiEnum<string, AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType>
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
        AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType
    >? ResponseContentType
    {
        get
        {
            return this._rawData.GetNullableClass<
                ApiEnum<string, AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType>
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
        _ = this.AuthHeaderValueFormat;
        _ = this.AuthMethod;
        _ = this.Endpoint;
        _ = this.Method;
        _ = this.Params;
        this.RequestContentType?.Validate();
        this.ResponseContentType?.Validate();
        _ = this.ResponseMap;
    }

    public AuthProviderUpdateRequestOauth2RefreshRequest() { }

    public AuthProviderUpdateRequestOauth2RefreshRequest(
        AuthProviderUpdateRequestOauth2RefreshRequest authProviderUpdateRequestOauth2RefreshRequest
    )
        : base(authProviderUpdateRequestOauth2RefreshRequest) { }

    public AuthProviderUpdateRequestOauth2RefreshRequest(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderUpdateRequestOauth2RefreshRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderUpdateRequestOauth2RefreshRequestFromRaw.FromRawUnchecked"/>
    public static AuthProviderUpdateRequestOauth2RefreshRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthProviderUpdateRequestOauth2RefreshRequestFromRaw
    : IFromRawJson<AuthProviderUpdateRequestOauth2RefreshRequest>
{
    /// <inheritdoc/>
    public AuthProviderUpdateRequestOauth2RefreshRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderUpdateRequestOauth2RefreshRequest.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(AuthProviderUpdateRequestOauth2RefreshRequestRequestContentTypeConverter))]
public enum AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class AuthProviderUpdateRequestOauth2RefreshRequestRequestContentTypeConverter
    : JsonConverter<AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType>
{
    public override AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            "application/json" =>
                AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType.ApplicationJson,
            _ => (AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType.ApplicationJson =>
                    "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(AuthProviderUpdateRequestOauth2RefreshRequestResponseContentTypeConverter))]
public enum AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class AuthProviderUpdateRequestOauth2RefreshRequestResponseContentTypeConverter
    : JsonConverter<AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType>
{
    public override AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            "application/json" =>
                AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType.ApplicationJson,
            _ => (AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType.ApplicationJson =>
                    "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(AuthProviderUpdateRequestOauth2ScopeDelimiterConverter))]
public enum AuthProviderUpdateRequestOauth2ScopeDelimiter
{
    Undefined,
    V1,
}

sealed class AuthProviderUpdateRequestOauth2ScopeDelimiterConverter
    : JsonConverter<AuthProviderUpdateRequestOauth2ScopeDelimiter>
{
    public override AuthProviderUpdateRequestOauth2ScopeDelimiter Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "," => AuthProviderUpdateRequestOauth2ScopeDelimiter.Undefined,
            " " => AuthProviderUpdateRequestOauth2ScopeDelimiter.V1,
            _ => (AuthProviderUpdateRequestOauth2ScopeDelimiter)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AuthProviderUpdateRequestOauth2ScopeDelimiter value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AuthProviderUpdateRequestOauth2ScopeDelimiter.Undefined => ",",
                AuthProviderUpdateRequestOauth2ScopeDelimiter.V1 => " ",
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
        AuthProviderUpdateRequestOauth2TokenRequest,
        AuthProviderUpdateRequestOauth2TokenRequestFromRaw
    >)
)]
public sealed record class AuthProviderUpdateRequestOauth2TokenRequest : JsonModel
{
    public string? AuthHeaderValueFormat
    {
        get { return this._rawData.GetNullableClass<string>("auth_header_value_format"); }
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
        get { return this._rawData.GetNullableClass<string>("auth_method"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("auth_method", value);
        }
    }

    public string? Endpoint
    {
        get { return this._rawData.GetNullableClass<string>("endpoint"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("endpoint", value);
        }
    }

    public string? Method
    {
        get { return this._rawData.GetNullableClass<string>("method"); }
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
        get { return this._rawData.GetNullableClass<FrozenDictionary<string, string>>("params"); }
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
        AuthProviderUpdateRequestOauth2TokenRequestRequestContentType
    >? RequestContentType
    {
        get
        {
            return this._rawData.GetNullableClass<
                ApiEnum<string, AuthProviderUpdateRequestOauth2TokenRequestRequestContentType>
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
        AuthProviderUpdateRequestOauth2TokenRequestResponseContentType
    >? ResponseContentType
    {
        get
        {
            return this._rawData.GetNullableClass<
                ApiEnum<string, AuthProviderUpdateRequestOauth2TokenRequestResponseContentType>
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
        _ = this.AuthHeaderValueFormat;
        _ = this.AuthMethod;
        _ = this.Endpoint;
        _ = this.Method;
        _ = this.Params;
        this.RequestContentType?.Validate();
        this.ResponseContentType?.Validate();
        _ = this.ResponseMap;
    }

    public AuthProviderUpdateRequestOauth2TokenRequest() { }

    public AuthProviderUpdateRequestOauth2TokenRequest(
        AuthProviderUpdateRequestOauth2TokenRequest authProviderUpdateRequestOauth2TokenRequest
    )
        : base(authProviderUpdateRequestOauth2TokenRequest) { }

    public AuthProviderUpdateRequestOauth2TokenRequest(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderUpdateRequestOauth2TokenRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderUpdateRequestOauth2TokenRequestFromRaw.FromRawUnchecked"/>
    public static AuthProviderUpdateRequestOauth2TokenRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthProviderUpdateRequestOauth2TokenRequestFromRaw
    : IFromRawJson<AuthProviderUpdateRequestOauth2TokenRequest>
{
    /// <inheritdoc/>
    public AuthProviderUpdateRequestOauth2TokenRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderUpdateRequestOauth2TokenRequest.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(AuthProviderUpdateRequestOauth2TokenRequestRequestContentTypeConverter))]
public enum AuthProviderUpdateRequestOauth2TokenRequestRequestContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class AuthProviderUpdateRequestOauth2TokenRequestRequestContentTypeConverter
    : JsonConverter<AuthProviderUpdateRequestOauth2TokenRequestRequestContentType>
{
    public override AuthProviderUpdateRequestOauth2TokenRequestRequestContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                AuthProviderUpdateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            "application/json" =>
                AuthProviderUpdateRequestOauth2TokenRequestRequestContentType.ApplicationJson,
            _ => (AuthProviderUpdateRequestOauth2TokenRequestRequestContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AuthProviderUpdateRequestOauth2TokenRequestRequestContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AuthProviderUpdateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                AuthProviderUpdateRequestOauth2TokenRequestRequestContentType.ApplicationJson =>
                    "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(AuthProviderUpdateRequestOauth2TokenRequestResponseContentTypeConverter))]
public enum AuthProviderUpdateRequestOauth2TokenRequestResponseContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class AuthProviderUpdateRequestOauth2TokenRequestResponseContentTypeConverter
    : JsonConverter<AuthProviderUpdateRequestOauth2TokenRequestResponseContentType>
{
    public override AuthProviderUpdateRequestOauth2TokenRequestResponseContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                AuthProviderUpdateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            "application/json" =>
                AuthProviderUpdateRequestOauth2TokenRequestResponseContentType.ApplicationJson,
            _ => (AuthProviderUpdateRequestOauth2TokenRequestResponseContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AuthProviderUpdateRequestOauth2TokenRequestResponseContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AuthProviderUpdateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                AuthProviderUpdateRequestOauth2TokenRequestResponseContentType.ApplicationJson =>
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
        AuthProviderUpdateRequestOauth2UserInfoRequest,
        AuthProviderUpdateRequestOauth2UserInfoRequestFromRaw
    >)
)]
public sealed record class AuthProviderUpdateRequestOauth2UserInfoRequest : JsonModel
{
    public string? AuthHeaderValueFormat
    {
        get { return this._rawData.GetNullableClass<string>("auth_header_value_format"); }
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
        get { return this._rawData.GetNullableClass<string>("auth_method"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("auth_method", value);
        }
    }

    public string? Endpoint
    {
        get { return this._rawData.GetNullableClass<string>("endpoint"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("endpoint", value);
        }
    }

    public string? Method
    {
        get { return this._rawData.GetNullableClass<string>("method"); }
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
        get { return this._rawData.GetNullableClass<FrozenDictionary<string, string>>("params"); }
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
        AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType
    >? RequestContentType
    {
        get
        {
            return this._rawData.GetNullableClass<
                ApiEnum<string, AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType>
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
        AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType
    >? ResponseContentType
    {
        get
        {
            return this._rawData.GetNullableClass<
                ApiEnum<string, AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType>
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

    public AuthProviderUpdateRequestOauth2UserInfoRequestTriggers? Triggers
    {
        get
        {
            return this._rawData.GetNullableClass<AuthProviderUpdateRequestOauth2UserInfoRequestTriggers>(
                "triggers"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("triggers", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.AuthHeaderValueFormat;
        _ = this.AuthMethod;
        _ = this.Endpoint;
        _ = this.Method;
        _ = this.Params;
        this.RequestContentType?.Validate();
        this.ResponseContentType?.Validate();
        _ = this.ResponseMap;
        this.Triggers?.Validate();
    }

    public AuthProviderUpdateRequestOauth2UserInfoRequest() { }

    public AuthProviderUpdateRequestOauth2UserInfoRequest(
        AuthProviderUpdateRequestOauth2UserInfoRequest authProviderUpdateRequestOauth2UserInfoRequest
    )
        : base(authProviderUpdateRequestOauth2UserInfoRequest) { }

    public AuthProviderUpdateRequestOauth2UserInfoRequest(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderUpdateRequestOauth2UserInfoRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderUpdateRequestOauth2UserInfoRequestFromRaw.FromRawUnchecked"/>
    public static AuthProviderUpdateRequestOauth2UserInfoRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthProviderUpdateRequestOauth2UserInfoRequestFromRaw
    : IFromRawJson<AuthProviderUpdateRequestOauth2UserInfoRequest>
{
    /// <inheritdoc/>
    public AuthProviderUpdateRequestOauth2UserInfoRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderUpdateRequestOauth2UserInfoRequest.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentTypeConverter))]
public enum AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentTypeConverter
    : JsonConverter<AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType>
{
    public override AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            "application/json" =>
                AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType.ApplicationJson,
            _ => (AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType.ApplicationJson =>
                    "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentTypeConverter))]
public enum AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentTypeConverter
    : JsonConverter<AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType>
{
    public override AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            "application/json" =>
                AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType.ApplicationJson,
            _ => (AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType.ApplicationJson =>
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
        AuthProviderUpdateRequestOauth2UserInfoRequestTriggers,
        AuthProviderUpdateRequestOauth2UserInfoRequestTriggersFromRaw
    >)
)]
public sealed record class AuthProviderUpdateRequestOauth2UserInfoRequestTriggers : JsonModel
{
    public bool? OnTokenGrant
    {
        get { return this._rawData.GetNullableStruct<bool>("on_token_grant"); }
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
        get { return this._rawData.GetNullableStruct<bool>("on_token_refresh"); }
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

    public AuthProviderUpdateRequestOauth2UserInfoRequestTriggers() { }

    public AuthProviderUpdateRequestOauth2UserInfoRequestTriggers(
        AuthProviderUpdateRequestOauth2UserInfoRequestTriggers authProviderUpdateRequestOauth2UserInfoRequestTriggers
    )
        : base(authProviderUpdateRequestOauth2UserInfoRequestTriggers) { }

    public AuthProviderUpdateRequestOauth2UserInfoRequestTriggers(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderUpdateRequestOauth2UserInfoRequestTriggers(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderUpdateRequestOauth2UserInfoRequestTriggersFromRaw.FromRawUnchecked"/>
    public static AuthProviderUpdateRequestOauth2UserInfoRequestTriggers FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthProviderUpdateRequestOauth2UserInfoRequestTriggersFromRaw
    : IFromRawJson<AuthProviderUpdateRequestOauth2UserInfoRequestTriggers>
{
    /// <inheritdoc/>
    public AuthProviderUpdateRequestOauth2UserInfoRequestTriggers FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderUpdateRequestOauth2UserInfoRequestTriggers.FromRawUnchecked(rawData);
}
