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
/// Patch an existing auth provider
/// </summary>
public sealed record class AuthProviderPatchParams : ParamsBase
{
    readonly FreezableDictionary<string, JsonElement> _rawBodyData = [];
    public IReadOnlyDictionary<string, JsonElement> RawBodyData
    {
        get { return this._rawBodyData.Freeze(); }
    }

    public string? ID { get; init; }

    public string? IDValue
    {
        get { return ModelBase.GetNullableClass<string>(this.RawBodyData, "id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawBodyData, "id", value);
        }
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

    public AuthProviderPatchParamsOauth2? Oauth2
    {
        get
        {
            return ModelBase.GetNullableClass<AuthProviderPatchParamsOauth2>(
                this.RawBodyData,
                "oauth2"
            );
        }
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

    public AuthProviderPatchParams() { }

    public AuthProviderPatchParams(AuthProviderPatchParams authProviderPatchParams)
        : base(authProviderPatchParams)
    {
        this._rawBodyData = [.. authProviderPatchParams._rawBodyData];
    }

    public AuthProviderPatchParams(
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
    AuthProviderPatchParams(
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

    /// <inheritdoc cref="IFromRaw.FromRawUnchecked"/>
    public static AuthProviderPatchParams FromRawUnchecked(
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
            options.BaseUrl.ToString().TrimEnd('/')
                + string.Format("/v1/admin/auth_providers/{0}", this.ID)
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

[JsonConverter(
    typeof(ModelConverter<AuthProviderPatchParamsOauth2, AuthProviderPatchParamsOauth2FromRaw>)
)]
public sealed record class AuthProviderPatchParamsOauth2 : ModelBase
{
    public AuthProviderPatchParamsOauth2AuthorizeRequest? AuthorizeRequest
    {
        get
        {
            return ModelBase.GetNullableClass<AuthProviderPatchParamsOauth2AuthorizeRequest>(
                this.RawData,
                "authorize_request"
            );
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

    public AuthProviderPatchParamsOauth2Pkce? Pkce
    {
        get
        {
            return ModelBase.GetNullableClass<AuthProviderPatchParamsOauth2Pkce>(
                this.RawData,
                "pkce"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "pkce", value);
        }
    }

    public AuthProviderPatchParamsOauth2RefreshRequest? RefreshRequest
    {
        get
        {
            return ModelBase.GetNullableClass<AuthProviderPatchParamsOauth2RefreshRequest>(
                this.RawData,
                "refresh_request"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "refresh_request", value);
        }
    }

    public ApiEnum<string, AuthProviderPatchParamsOauth2ScopeDelimiter>? ScopeDelimiter
    {
        get
        {
            return ModelBase.GetNullableClass<
                ApiEnum<string, AuthProviderPatchParamsOauth2ScopeDelimiter>
            >(this.RawData, "scope_delimiter");
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

    public AuthProviderPatchParamsOauth2TokenRequest? TokenRequest
    {
        get
        {
            return ModelBase.GetNullableClass<AuthProviderPatchParamsOauth2TokenRequest>(
                this.RawData,
                "token_request"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "token_request", value);
        }
    }

    public AuthProviderPatchParamsOauth2UserInfoRequest? UserInfoRequest
    {
        get
        {
            return ModelBase.GetNullableClass<AuthProviderPatchParamsOauth2UserInfoRequest>(
                this.RawData,
                "user_info_request"
            );
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

    public AuthProviderPatchParamsOauth2() { }

    public AuthProviderPatchParamsOauth2(
        AuthProviderPatchParamsOauth2 authProviderPatchParamsOauth2
    )
        : base(authProviderPatchParamsOauth2) { }

    public AuthProviderPatchParamsOauth2(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderPatchParamsOauth2(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderPatchParamsOauth2FromRaw.FromRawUnchecked"/>
    public static AuthProviderPatchParamsOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthProviderPatchParamsOauth2FromRaw : IFromRaw<AuthProviderPatchParamsOauth2>
{
    /// <inheritdoc/>
    public AuthProviderPatchParamsOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderPatchParamsOauth2.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(ModelConverter<
        AuthProviderPatchParamsOauth2AuthorizeRequest,
        AuthProviderPatchParamsOauth2AuthorizeRequestFromRaw
    >)
)]
public sealed record class AuthProviderPatchParamsOauth2AuthorizeRequest : ModelBase
{
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

    public string? Endpoint
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "endpoint"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "endpoint", value);
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

    public ApiEnum<
        string,
        AuthProviderPatchParamsOauth2AuthorizeRequestRequestContentType
    >? RequestContentType
    {
        get
        {
            return ModelBase.GetNullableClass<
                ApiEnum<string, AuthProviderPatchParamsOauth2AuthorizeRequestRequestContentType>
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

    public ApiEnum<
        string,
        AuthProviderPatchParamsOauth2AuthorizeRequestResponseContentType
    >? ResponseContentType
    {
        get
        {
            return ModelBase.GetNullableClass<
                ApiEnum<string, AuthProviderPatchParamsOauth2AuthorizeRequestResponseContentType>
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

    public AuthProviderPatchParamsOauth2AuthorizeRequest() { }

    public AuthProviderPatchParamsOauth2AuthorizeRequest(
        AuthProviderPatchParamsOauth2AuthorizeRequest authProviderPatchParamsOauth2AuthorizeRequest
    )
        : base(authProviderPatchParamsOauth2AuthorizeRequest) { }

    public AuthProviderPatchParamsOauth2AuthorizeRequest(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderPatchParamsOauth2AuthorizeRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderPatchParamsOauth2AuthorizeRequestFromRaw.FromRawUnchecked"/>
    public static AuthProviderPatchParamsOauth2AuthorizeRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthProviderPatchParamsOauth2AuthorizeRequestFromRaw
    : IFromRaw<AuthProviderPatchParamsOauth2AuthorizeRequest>
{
    /// <inheritdoc/>
    public AuthProviderPatchParamsOauth2AuthorizeRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderPatchParamsOauth2AuthorizeRequest.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(AuthProviderPatchParamsOauth2AuthorizeRequestRequestContentTypeConverter))]
public enum AuthProviderPatchParamsOauth2AuthorizeRequestRequestContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class AuthProviderPatchParamsOauth2AuthorizeRequestRequestContentTypeConverter
    : JsonConverter<AuthProviderPatchParamsOauth2AuthorizeRequestRequestContentType>
{
    public override AuthProviderPatchParamsOauth2AuthorizeRequestRequestContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                AuthProviderPatchParamsOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            "application/json" =>
                AuthProviderPatchParamsOauth2AuthorizeRequestRequestContentType.ApplicationJson,
            _ => (AuthProviderPatchParamsOauth2AuthorizeRequestRequestContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AuthProviderPatchParamsOauth2AuthorizeRequestRequestContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AuthProviderPatchParamsOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                AuthProviderPatchParamsOauth2AuthorizeRequestRequestContentType.ApplicationJson =>
                    "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(AuthProviderPatchParamsOauth2AuthorizeRequestResponseContentTypeConverter))]
public enum AuthProviderPatchParamsOauth2AuthorizeRequestResponseContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class AuthProviderPatchParamsOauth2AuthorizeRequestResponseContentTypeConverter
    : JsonConverter<AuthProviderPatchParamsOauth2AuthorizeRequestResponseContentType>
{
    public override AuthProviderPatchParamsOauth2AuthorizeRequestResponseContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                AuthProviderPatchParamsOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            "application/json" =>
                AuthProviderPatchParamsOauth2AuthorizeRequestResponseContentType.ApplicationJson,
            _ => (AuthProviderPatchParamsOauth2AuthorizeRequestResponseContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AuthProviderPatchParamsOauth2AuthorizeRequestResponseContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AuthProviderPatchParamsOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                AuthProviderPatchParamsOauth2AuthorizeRequestResponseContentType.ApplicationJson =>
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
    typeof(ModelConverter<
        AuthProviderPatchParamsOauth2Pkce,
        AuthProviderPatchParamsOauth2PkceFromRaw
    >)
)]
public sealed record class AuthProviderPatchParamsOauth2Pkce : ModelBase
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

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.CodeChallengeMethod;
        _ = this.Enabled;
    }

    public AuthProviderPatchParamsOauth2Pkce() { }

    public AuthProviderPatchParamsOauth2Pkce(
        AuthProviderPatchParamsOauth2Pkce authProviderPatchParamsOauth2Pkce
    )
        : base(authProviderPatchParamsOauth2Pkce) { }

    public AuthProviderPatchParamsOauth2Pkce(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderPatchParamsOauth2Pkce(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderPatchParamsOauth2PkceFromRaw.FromRawUnchecked"/>
    public static AuthProviderPatchParamsOauth2Pkce FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthProviderPatchParamsOauth2PkceFromRaw : IFromRaw<AuthProviderPatchParamsOauth2Pkce>
{
    /// <inheritdoc/>
    public AuthProviderPatchParamsOauth2Pkce FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderPatchParamsOauth2Pkce.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(ModelConverter<
        AuthProviderPatchParamsOauth2RefreshRequest,
        AuthProviderPatchParamsOauth2RefreshRequestFromRaw
    >)
)]
public sealed record class AuthProviderPatchParamsOauth2RefreshRequest : ModelBase
{
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

    public string? Endpoint
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "endpoint"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "endpoint", value);
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

    public ApiEnum<
        string,
        AuthProviderPatchParamsOauth2RefreshRequestRequestContentType
    >? RequestContentType
    {
        get
        {
            return ModelBase.GetNullableClass<
                ApiEnum<string, AuthProviderPatchParamsOauth2RefreshRequestRequestContentType>
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

    public ApiEnum<
        string,
        AuthProviderPatchParamsOauth2RefreshRequestResponseContentType
    >? ResponseContentType
    {
        get
        {
            return ModelBase.GetNullableClass<
                ApiEnum<string, AuthProviderPatchParamsOauth2RefreshRequestResponseContentType>
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

    public AuthProviderPatchParamsOauth2RefreshRequest() { }

    public AuthProviderPatchParamsOauth2RefreshRequest(
        AuthProviderPatchParamsOauth2RefreshRequest authProviderPatchParamsOauth2RefreshRequest
    )
        : base(authProviderPatchParamsOauth2RefreshRequest) { }

    public AuthProviderPatchParamsOauth2RefreshRequest(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderPatchParamsOauth2RefreshRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderPatchParamsOauth2RefreshRequestFromRaw.FromRawUnchecked"/>
    public static AuthProviderPatchParamsOauth2RefreshRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthProviderPatchParamsOauth2RefreshRequestFromRaw
    : IFromRaw<AuthProviderPatchParamsOauth2RefreshRequest>
{
    /// <inheritdoc/>
    public AuthProviderPatchParamsOauth2RefreshRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderPatchParamsOauth2RefreshRequest.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(AuthProviderPatchParamsOauth2RefreshRequestRequestContentTypeConverter))]
public enum AuthProviderPatchParamsOauth2RefreshRequestRequestContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class AuthProviderPatchParamsOauth2RefreshRequestRequestContentTypeConverter
    : JsonConverter<AuthProviderPatchParamsOauth2RefreshRequestRequestContentType>
{
    public override AuthProviderPatchParamsOauth2RefreshRequestRequestContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                AuthProviderPatchParamsOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            "application/json" =>
                AuthProviderPatchParamsOauth2RefreshRequestRequestContentType.ApplicationJson,
            _ => (AuthProviderPatchParamsOauth2RefreshRequestRequestContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AuthProviderPatchParamsOauth2RefreshRequestRequestContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AuthProviderPatchParamsOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                AuthProviderPatchParamsOauth2RefreshRequestRequestContentType.ApplicationJson =>
                    "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(AuthProviderPatchParamsOauth2RefreshRequestResponseContentTypeConverter))]
public enum AuthProviderPatchParamsOauth2RefreshRequestResponseContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class AuthProviderPatchParamsOauth2RefreshRequestResponseContentTypeConverter
    : JsonConverter<AuthProviderPatchParamsOauth2RefreshRequestResponseContentType>
{
    public override AuthProviderPatchParamsOauth2RefreshRequestResponseContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                AuthProviderPatchParamsOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            "application/json" =>
                AuthProviderPatchParamsOauth2RefreshRequestResponseContentType.ApplicationJson,
            _ => (AuthProviderPatchParamsOauth2RefreshRequestResponseContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AuthProviderPatchParamsOauth2RefreshRequestResponseContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AuthProviderPatchParamsOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                AuthProviderPatchParamsOauth2RefreshRequestResponseContentType.ApplicationJson =>
                    "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(AuthProviderPatchParamsOauth2ScopeDelimiterConverter))]
public enum AuthProviderPatchParamsOauth2ScopeDelimiter
{
    Undefined,
    V1,
}

sealed class AuthProviderPatchParamsOauth2ScopeDelimiterConverter
    : JsonConverter<AuthProviderPatchParamsOauth2ScopeDelimiter>
{
    public override AuthProviderPatchParamsOauth2ScopeDelimiter Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "," => AuthProviderPatchParamsOauth2ScopeDelimiter.Undefined,
            " " => AuthProviderPatchParamsOauth2ScopeDelimiter.V1,
            _ => (AuthProviderPatchParamsOauth2ScopeDelimiter)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AuthProviderPatchParamsOauth2ScopeDelimiter value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AuthProviderPatchParamsOauth2ScopeDelimiter.Undefined => ",",
                AuthProviderPatchParamsOauth2ScopeDelimiter.V1 => " ",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(
    typeof(ModelConverter<
        AuthProviderPatchParamsOauth2TokenRequest,
        AuthProviderPatchParamsOauth2TokenRequestFromRaw
    >)
)]
public sealed record class AuthProviderPatchParamsOauth2TokenRequest : ModelBase
{
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

    public string? Endpoint
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "endpoint"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "endpoint", value);
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

    public ApiEnum<
        string,
        AuthProviderPatchParamsOauth2TokenRequestRequestContentType
    >? RequestContentType
    {
        get
        {
            return ModelBase.GetNullableClass<
                ApiEnum<string, AuthProviderPatchParamsOauth2TokenRequestRequestContentType>
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

    public ApiEnum<
        string,
        AuthProviderPatchParamsOauth2TokenRequestResponseContentType
    >? ResponseContentType
    {
        get
        {
            return ModelBase.GetNullableClass<
                ApiEnum<string, AuthProviderPatchParamsOauth2TokenRequestResponseContentType>
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

    public AuthProviderPatchParamsOauth2TokenRequest() { }

    public AuthProviderPatchParamsOauth2TokenRequest(
        AuthProviderPatchParamsOauth2TokenRequest authProviderPatchParamsOauth2TokenRequest
    )
        : base(authProviderPatchParamsOauth2TokenRequest) { }

    public AuthProviderPatchParamsOauth2TokenRequest(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderPatchParamsOauth2TokenRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderPatchParamsOauth2TokenRequestFromRaw.FromRawUnchecked"/>
    public static AuthProviderPatchParamsOauth2TokenRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthProviderPatchParamsOauth2TokenRequestFromRaw
    : IFromRaw<AuthProviderPatchParamsOauth2TokenRequest>
{
    /// <inheritdoc/>
    public AuthProviderPatchParamsOauth2TokenRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderPatchParamsOauth2TokenRequest.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(AuthProviderPatchParamsOauth2TokenRequestRequestContentTypeConverter))]
public enum AuthProviderPatchParamsOauth2TokenRequestRequestContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class AuthProviderPatchParamsOauth2TokenRequestRequestContentTypeConverter
    : JsonConverter<AuthProviderPatchParamsOauth2TokenRequestRequestContentType>
{
    public override AuthProviderPatchParamsOauth2TokenRequestRequestContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                AuthProviderPatchParamsOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            "application/json" =>
                AuthProviderPatchParamsOauth2TokenRequestRequestContentType.ApplicationJson,
            _ => (AuthProviderPatchParamsOauth2TokenRequestRequestContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AuthProviderPatchParamsOauth2TokenRequestRequestContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AuthProviderPatchParamsOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                AuthProviderPatchParamsOauth2TokenRequestRequestContentType.ApplicationJson =>
                    "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(AuthProviderPatchParamsOauth2TokenRequestResponseContentTypeConverter))]
public enum AuthProviderPatchParamsOauth2TokenRequestResponseContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class AuthProviderPatchParamsOauth2TokenRequestResponseContentTypeConverter
    : JsonConverter<AuthProviderPatchParamsOauth2TokenRequestResponseContentType>
{
    public override AuthProviderPatchParamsOauth2TokenRequestResponseContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                AuthProviderPatchParamsOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            "application/json" =>
                AuthProviderPatchParamsOauth2TokenRequestResponseContentType.ApplicationJson,
            _ => (AuthProviderPatchParamsOauth2TokenRequestResponseContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AuthProviderPatchParamsOauth2TokenRequestResponseContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AuthProviderPatchParamsOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                AuthProviderPatchParamsOauth2TokenRequestResponseContentType.ApplicationJson =>
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
    typeof(ModelConverter<
        AuthProviderPatchParamsOauth2UserInfoRequest,
        AuthProviderPatchParamsOauth2UserInfoRequestFromRaw
    >)
)]
public sealed record class AuthProviderPatchParamsOauth2UserInfoRequest : ModelBase
{
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

    public string? Endpoint
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "endpoint"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "endpoint", value);
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

    public ApiEnum<
        string,
        AuthProviderPatchParamsOauth2UserInfoRequestRequestContentType
    >? RequestContentType
    {
        get
        {
            return ModelBase.GetNullableClass<
                ApiEnum<string, AuthProviderPatchParamsOauth2UserInfoRequestRequestContentType>
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

    public ApiEnum<
        string,
        AuthProviderPatchParamsOauth2UserInfoRequestResponseContentType
    >? ResponseContentType
    {
        get
        {
            return ModelBase.GetNullableClass<
                ApiEnum<string, AuthProviderPatchParamsOauth2UserInfoRequestResponseContentType>
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

    public AuthProviderPatchParamsOauth2UserInfoRequestTriggers? Triggers
    {
        get
        {
            return ModelBase.GetNullableClass<AuthProviderPatchParamsOauth2UserInfoRequestTriggers>(
                this.RawData,
                "triggers"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "triggers", value);
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

    public AuthProviderPatchParamsOauth2UserInfoRequest() { }

    public AuthProviderPatchParamsOauth2UserInfoRequest(
        AuthProviderPatchParamsOauth2UserInfoRequest authProviderPatchParamsOauth2UserInfoRequest
    )
        : base(authProviderPatchParamsOauth2UserInfoRequest) { }

    public AuthProviderPatchParamsOauth2UserInfoRequest(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderPatchParamsOauth2UserInfoRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderPatchParamsOauth2UserInfoRequestFromRaw.FromRawUnchecked"/>
    public static AuthProviderPatchParamsOauth2UserInfoRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthProviderPatchParamsOauth2UserInfoRequestFromRaw
    : IFromRaw<AuthProviderPatchParamsOauth2UserInfoRequest>
{
    /// <inheritdoc/>
    public AuthProviderPatchParamsOauth2UserInfoRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderPatchParamsOauth2UserInfoRequest.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(AuthProviderPatchParamsOauth2UserInfoRequestRequestContentTypeConverter))]
public enum AuthProviderPatchParamsOauth2UserInfoRequestRequestContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class AuthProviderPatchParamsOauth2UserInfoRequestRequestContentTypeConverter
    : JsonConverter<AuthProviderPatchParamsOauth2UserInfoRequestRequestContentType>
{
    public override AuthProviderPatchParamsOauth2UserInfoRequestRequestContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                AuthProviderPatchParamsOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            "application/json" =>
                AuthProviderPatchParamsOauth2UserInfoRequestRequestContentType.ApplicationJson,
            _ => (AuthProviderPatchParamsOauth2UserInfoRequestRequestContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AuthProviderPatchParamsOauth2UserInfoRequestRequestContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AuthProviderPatchParamsOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                AuthProviderPatchParamsOauth2UserInfoRequestRequestContentType.ApplicationJson =>
                    "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(AuthProviderPatchParamsOauth2UserInfoRequestResponseContentTypeConverter))]
public enum AuthProviderPatchParamsOauth2UserInfoRequestResponseContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class AuthProviderPatchParamsOauth2UserInfoRequestResponseContentTypeConverter
    : JsonConverter<AuthProviderPatchParamsOauth2UserInfoRequestResponseContentType>
{
    public override AuthProviderPatchParamsOauth2UserInfoRequestResponseContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                AuthProviderPatchParamsOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            "application/json" =>
                AuthProviderPatchParamsOauth2UserInfoRequestResponseContentType.ApplicationJson,
            _ => (AuthProviderPatchParamsOauth2UserInfoRequestResponseContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AuthProviderPatchParamsOauth2UserInfoRequestResponseContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AuthProviderPatchParamsOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                AuthProviderPatchParamsOauth2UserInfoRequestResponseContentType.ApplicationJson =>
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
    typeof(ModelConverter<
        AuthProviderPatchParamsOauth2UserInfoRequestTriggers,
        AuthProviderPatchParamsOauth2UserInfoRequestTriggersFromRaw
    >)
)]
public sealed record class AuthProviderPatchParamsOauth2UserInfoRequestTriggers : ModelBase
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

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.OnTokenGrant;
        _ = this.OnTokenRefresh;
    }

    public AuthProviderPatchParamsOauth2UserInfoRequestTriggers() { }

    public AuthProviderPatchParamsOauth2UserInfoRequestTriggers(
        AuthProviderPatchParamsOauth2UserInfoRequestTriggers authProviderPatchParamsOauth2UserInfoRequestTriggers
    )
        : base(authProviderPatchParamsOauth2UserInfoRequestTriggers) { }

    public AuthProviderPatchParamsOauth2UserInfoRequestTriggers(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderPatchParamsOauth2UserInfoRequestTriggers(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderPatchParamsOauth2UserInfoRequestTriggersFromRaw.FromRawUnchecked"/>
    public static AuthProviderPatchParamsOauth2UserInfoRequestTriggers FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthProviderPatchParamsOauth2UserInfoRequestTriggersFromRaw
    : IFromRaw<AuthProviderPatchParamsOauth2UserInfoRequestTriggers>
{
    /// <inheritdoc/>
    public AuthProviderPatchParamsOauth2UserInfoRequestTriggers FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderPatchParamsOauth2UserInfoRequestTriggers.FromRawUnchecked(rawData);
}
