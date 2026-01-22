using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using System = System;

namespace ArcadeDotnet.Models.Admin.AuthProviders;

[JsonConverter(typeof(JsonModelConverter<AuthProviderResponse, AuthProviderResponseFromRaw>))]
public sealed record class AuthProviderResponse : JsonModel
{
    public string? ID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("id", value);
        }
    }

    public Binding? Binding
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<Binding>("binding");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("binding", value);
        }
    }

    public string? CreatedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("created_at");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("created_at", value);
        }
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

    public AuthProviderResponseOauth2? Oauth2
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<AuthProviderResponseOauth2>("oauth2");
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

    public string? UpdatedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("updated_at");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("updated_at", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        this.Binding?.Validate();
        _ = this.CreatedAt;
        _ = this.Description;
        this.Oauth2?.Validate();
        _ = this.ProviderID;
        _ = this.Status;
        _ = this.Type;
        _ = this.UpdatedAt;
    }

    public AuthProviderResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AuthProviderResponse(AuthProviderResponse authProviderResponse)
        : base(authProviderResponse) { }
#pragma warning restore CS8618

    public AuthProviderResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderResponseFromRaw.FromRawUnchecked"/>
    public static AuthProviderResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthProviderResponseFromRaw : IFromRawJson<AuthProviderResponse>
{
    /// <inheritdoc/>
    public AuthProviderResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderResponse.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Binding, BindingFromRaw>))]
public sealed record class Binding : JsonModel
{
    public string? ID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("id", value);
        }
    }

    public ApiEnum<string, global::ArcadeDotnet.Models.Admin.AuthProviders.Type>? Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, global::ArcadeDotnet.Models.Admin.AuthProviders.Type>
            >("type");
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
        this.Type?.Validate();
    }

    public Binding() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Binding(Binding binding)
        : base(binding) { }
#pragma warning restore CS8618

    public Binding(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Binding(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="BindingFromRaw.FromRawUnchecked"/>
    public static Binding FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class BindingFromRaw : IFromRawJson<Binding>
{
    /// <inheritdoc/>
    public Binding FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Binding.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(TypeConverter))]
public enum Type
{
    Static,
    Tenant,
    Project,
    Account,
}

sealed class TypeConverter : JsonConverter<global::ArcadeDotnet.Models.Admin.AuthProviders.Type>
{
    public override global::ArcadeDotnet.Models.Admin.AuthProviders.Type Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "static" => global::ArcadeDotnet.Models.Admin.AuthProviders.Type.Static,
            "tenant" => global::ArcadeDotnet.Models.Admin.AuthProviders.Type.Tenant,
            "project" => global::ArcadeDotnet.Models.Admin.AuthProviders.Type.Project,
            "account" => global::ArcadeDotnet.Models.Admin.AuthProviders.Type.Account,
            _ => (global::ArcadeDotnet.Models.Admin.AuthProviders.Type)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        global::ArcadeDotnet.Models.Admin.AuthProviders.Type value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                global::ArcadeDotnet.Models.Admin.AuthProviders.Type.Static => "static",
                global::ArcadeDotnet.Models.Admin.AuthProviders.Type.Tenant => "tenant",
                global::ArcadeDotnet.Models.Admin.AuthProviders.Type.Project => "project",
                global::ArcadeDotnet.Models.Admin.AuthProviders.Type.Account => "account",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(
    typeof(JsonModelConverter<AuthProviderResponseOauth2, AuthProviderResponseOauth2FromRaw>)
)]
public sealed record class AuthProviderResponseOauth2 : JsonModel
{
    public AuthProviderResponseOauth2AuthorizeRequest? AuthorizeRequest
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<AuthProviderResponseOauth2AuthorizeRequest>(
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("client_id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("client_id", value);
        }
    }

    public ClientSecret? ClientSecret
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ClientSecret>("client_secret");
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

    public AuthProviderResponseOauth2Pkce? Pkce
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<AuthProviderResponseOauth2Pkce>("pkce");
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

    /// <summary>
    /// The redirect URI required for this provider.
    /// </summary>
    public string? RedirectUri
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("redirect_uri");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("redirect_uri", value);
        }
    }

    public AuthProviderResponseOauth2RefreshRequest? RefreshRequest
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<AuthProviderResponseOauth2RefreshRequest>(
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

    public string? ScopeDelimiter
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("scope_delimiter");
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

    public AuthProviderResponseOauth2TokenIntrospectionRequest? TokenIntrospectionRequest
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<AuthProviderResponseOauth2TokenIntrospectionRequest>(
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

    public AuthProviderResponseOauth2TokenRequest? TokenRequest
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<AuthProviderResponseOauth2TokenRequest>(
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

    public AuthProviderResponseOauth2UserInfoRequest? UserInfoRequest
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<AuthProviderResponseOauth2UserInfoRequest>(
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
        this.ClientSecret?.Validate();
        this.Pkce?.Validate();
        _ = this.RedirectUri;
        this.RefreshRequest?.Validate();
        _ = this.ScopeDelimiter;
        this.TokenIntrospectionRequest?.Validate();
        this.TokenRequest?.Validate();
        this.UserInfoRequest?.Validate();
    }

    public AuthProviderResponseOauth2() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AuthProviderResponseOauth2(AuthProviderResponseOauth2 authProviderResponseOauth2)
        : base(authProviderResponseOauth2) { }
#pragma warning restore CS8618

    public AuthProviderResponseOauth2(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderResponseOauth2(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderResponseOauth2FromRaw.FromRawUnchecked"/>
    public static AuthProviderResponseOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthProviderResponseOauth2FromRaw : IFromRawJson<AuthProviderResponseOauth2>
{
    /// <inheritdoc/>
    public AuthProviderResponseOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderResponseOauth2.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        AuthProviderResponseOauth2AuthorizeRequest,
        AuthProviderResponseOauth2AuthorizeRequestFromRaw
    >)
)]
public sealed record class AuthProviderResponseOauth2AuthorizeRequest : JsonModel
{
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

    public string? Endpoint
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("endpoint");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("endpoint", value);
        }
    }

    public string? ExpirationFormat
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("expiration_format");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("expiration_format", value);
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

    public string? RequestContentType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("request_content_type");
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

    public string? ResponseContentType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("response_content_type");
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
        _ = this.AuthHeaderValueFormat;
        _ = this.AuthMethod;
        _ = this.Endpoint;
        _ = this.ExpirationFormat;
        _ = this.Method;
        _ = this.Params;
        _ = this.RequestContentType;
        _ = this.ResponseContentType;
        _ = this.ResponseMap;
    }

    public AuthProviderResponseOauth2AuthorizeRequest() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AuthProviderResponseOauth2AuthorizeRequest(
        AuthProviderResponseOauth2AuthorizeRequest authProviderResponseOauth2AuthorizeRequest
    )
        : base(authProviderResponseOauth2AuthorizeRequest) { }
#pragma warning restore CS8618

    public AuthProviderResponseOauth2AuthorizeRequest(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderResponseOauth2AuthorizeRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderResponseOauth2AuthorizeRequestFromRaw.FromRawUnchecked"/>
    public static AuthProviderResponseOauth2AuthorizeRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthProviderResponseOauth2AuthorizeRequestFromRaw
    : IFromRawJson<AuthProviderResponseOauth2AuthorizeRequest>
{
    /// <inheritdoc/>
    public AuthProviderResponseOauth2AuthorizeRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderResponseOauth2AuthorizeRequest.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<ClientSecret, ClientSecretFromRaw>))]
public sealed record class ClientSecret : JsonModel
{
    public ApiEnum<string, ClientSecretBinding>? Binding
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ApiEnum<string, ClientSecretBinding>>("binding");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("binding", value);
        }
    }

    public bool? Editable
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("editable");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("editable", value);
        }
    }

    public bool? Exists
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("exists");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("exists", value);
        }
    }

    public string? Hint
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("hint");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("hint", value);
        }
    }

    public string? Value
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("value");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("value", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        this.Binding?.Validate();
        _ = this.Editable;
        _ = this.Exists;
        _ = this.Hint;
        _ = this.Value;
    }

    public ClientSecret() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public ClientSecret(ClientSecret clientSecret)
        : base(clientSecret) { }
#pragma warning restore CS8618

    public ClientSecret(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ClientSecret(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ClientSecretFromRaw.FromRawUnchecked"/>
    public static ClientSecret FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ClientSecretFromRaw : IFromRawJson<ClientSecret>
{
    /// <inheritdoc/>
    public ClientSecret FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        ClientSecret.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ClientSecretBindingConverter))]
public enum ClientSecretBinding
{
    Static,
    Tenant,
    Project,
    Account,
}

sealed class ClientSecretBindingConverter : JsonConverter<ClientSecretBinding>
{
    public override ClientSecretBinding Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "static" => ClientSecretBinding.Static,
            "tenant" => ClientSecretBinding.Tenant,
            "project" => ClientSecretBinding.Project,
            "account" => ClientSecretBinding.Account,
            _ => (ClientSecretBinding)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        ClientSecretBinding value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                ClientSecretBinding.Static => "static",
                ClientSecretBinding.Tenant => "tenant",
                ClientSecretBinding.Project => "project",
                ClientSecretBinding.Account => "account",
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
        AuthProviderResponseOauth2Pkce,
        AuthProviderResponseOauth2PkceFromRaw
    >)
)]
public sealed record class AuthProviderResponseOauth2Pkce : JsonModel
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

    public AuthProviderResponseOauth2Pkce() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AuthProviderResponseOauth2Pkce(
        AuthProviderResponseOauth2Pkce authProviderResponseOauth2Pkce
    )
        : base(authProviderResponseOauth2Pkce) { }
#pragma warning restore CS8618

    public AuthProviderResponseOauth2Pkce(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderResponseOauth2Pkce(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderResponseOauth2PkceFromRaw.FromRawUnchecked"/>
    public static AuthProviderResponseOauth2Pkce FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthProviderResponseOauth2PkceFromRaw : IFromRawJson<AuthProviderResponseOauth2Pkce>
{
    /// <inheritdoc/>
    public AuthProviderResponseOauth2Pkce FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderResponseOauth2Pkce.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        AuthProviderResponseOauth2RefreshRequest,
        AuthProviderResponseOauth2RefreshRequestFromRaw
    >)
)]
public sealed record class AuthProviderResponseOauth2RefreshRequest : JsonModel
{
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

    public string? Endpoint
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("endpoint");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("endpoint", value);
        }
    }

    public string? ExpirationFormat
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("expiration_format");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("expiration_format", value);
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

    public string? RequestContentType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("request_content_type");
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

    public string? ResponseContentType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("response_content_type");
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
        _ = this.AuthHeaderValueFormat;
        _ = this.AuthMethod;
        _ = this.Endpoint;
        _ = this.ExpirationFormat;
        _ = this.Method;
        _ = this.Params;
        _ = this.RequestContentType;
        _ = this.ResponseContentType;
        _ = this.ResponseMap;
    }

    public AuthProviderResponseOauth2RefreshRequest() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AuthProviderResponseOauth2RefreshRequest(
        AuthProviderResponseOauth2RefreshRequest authProviderResponseOauth2RefreshRequest
    )
        : base(authProviderResponseOauth2RefreshRequest) { }
#pragma warning restore CS8618

    public AuthProviderResponseOauth2RefreshRequest(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderResponseOauth2RefreshRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderResponseOauth2RefreshRequestFromRaw.FromRawUnchecked"/>
    public static AuthProviderResponseOauth2RefreshRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthProviderResponseOauth2RefreshRequestFromRaw
    : IFromRawJson<AuthProviderResponseOauth2RefreshRequest>
{
    /// <inheritdoc/>
    public AuthProviderResponseOauth2RefreshRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderResponseOauth2RefreshRequest.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        AuthProviderResponseOauth2TokenIntrospectionRequest,
        AuthProviderResponseOauth2TokenIntrospectionRequestFromRaw
    >)
)]
public sealed record class AuthProviderResponseOauth2TokenIntrospectionRequest : JsonModel
{
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

    public string? Endpoint
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("endpoint");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("endpoint", value);
        }
    }

    public string? ExpirationFormat
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("expiration_format");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("expiration_format", value);
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

    public string? RequestContentType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("request_content_type");
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

    public string? ResponseContentType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("response_content_type");
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

    public AuthProviderResponseOauth2TokenIntrospectionRequestTriggers? Triggers
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<AuthProviderResponseOauth2TokenIntrospectionRequestTriggers>(
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
        _ = this.Enabled;
        _ = this.Endpoint;
        _ = this.ExpirationFormat;
        _ = this.Method;
        _ = this.Params;
        _ = this.RequestContentType;
        _ = this.ResponseContentType;
        _ = this.ResponseMap;
        this.Triggers?.Validate();
    }

    public AuthProviderResponseOauth2TokenIntrospectionRequest() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AuthProviderResponseOauth2TokenIntrospectionRequest(
        AuthProviderResponseOauth2TokenIntrospectionRequest authProviderResponseOauth2TokenIntrospectionRequest
    )
        : base(authProviderResponseOauth2TokenIntrospectionRequest) { }
#pragma warning restore CS8618

    public AuthProviderResponseOauth2TokenIntrospectionRequest(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderResponseOauth2TokenIntrospectionRequest(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderResponseOauth2TokenIntrospectionRequestFromRaw.FromRawUnchecked"/>
    public static AuthProviderResponseOauth2TokenIntrospectionRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthProviderResponseOauth2TokenIntrospectionRequestFromRaw
    : IFromRawJson<AuthProviderResponseOauth2TokenIntrospectionRequest>
{
    /// <inheritdoc/>
    public AuthProviderResponseOauth2TokenIntrospectionRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderResponseOauth2TokenIntrospectionRequest.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        AuthProviderResponseOauth2TokenIntrospectionRequestTriggers,
        AuthProviderResponseOauth2TokenIntrospectionRequestTriggersFromRaw
    >)
)]
public sealed record class AuthProviderResponseOauth2TokenIntrospectionRequestTriggers : JsonModel
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

    public AuthProviderResponseOauth2TokenIntrospectionRequestTriggers() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AuthProviderResponseOauth2TokenIntrospectionRequestTriggers(
        AuthProviderResponseOauth2TokenIntrospectionRequestTriggers authProviderResponseOauth2TokenIntrospectionRequestTriggers
    )
        : base(authProviderResponseOauth2TokenIntrospectionRequestTriggers) { }
#pragma warning restore CS8618

    public AuthProviderResponseOauth2TokenIntrospectionRequestTriggers(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderResponseOauth2TokenIntrospectionRequestTriggers(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderResponseOauth2TokenIntrospectionRequestTriggersFromRaw.FromRawUnchecked"/>
    public static AuthProviderResponseOauth2TokenIntrospectionRequestTriggers FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthProviderResponseOauth2TokenIntrospectionRequestTriggersFromRaw
    : IFromRawJson<AuthProviderResponseOauth2TokenIntrospectionRequestTriggers>
{
    /// <inheritdoc/>
    public AuthProviderResponseOauth2TokenIntrospectionRequestTriggers FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderResponseOauth2TokenIntrospectionRequestTriggers.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        AuthProviderResponseOauth2TokenRequest,
        AuthProviderResponseOauth2TokenRequestFromRaw
    >)
)]
public sealed record class AuthProviderResponseOauth2TokenRequest : JsonModel
{
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

    public string? Endpoint
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("endpoint");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("endpoint", value);
        }
    }

    public string? ExpirationFormat
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("expiration_format");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("expiration_format", value);
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

    public string? RequestContentType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("request_content_type");
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

    public string? ResponseContentType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("response_content_type");
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
        _ = this.AuthHeaderValueFormat;
        _ = this.AuthMethod;
        _ = this.Endpoint;
        _ = this.ExpirationFormat;
        _ = this.Method;
        _ = this.Params;
        _ = this.RequestContentType;
        _ = this.ResponseContentType;
        _ = this.ResponseMap;
    }

    public AuthProviderResponseOauth2TokenRequest() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AuthProviderResponseOauth2TokenRequest(
        AuthProviderResponseOauth2TokenRequest authProviderResponseOauth2TokenRequest
    )
        : base(authProviderResponseOauth2TokenRequest) { }
#pragma warning restore CS8618

    public AuthProviderResponseOauth2TokenRequest(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderResponseOauth2TokenRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderResponseOauth2TokenRequestFromRaw.FromRawUnchecked"/>
    public static AuthProviderResponseOauth2TokenRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthProviderResponseOauth2TokenRequestFromRaw
    : IFromRawJson<AuthProviderResponseOauth2TokenRequest>
{
    /// <inheritdoc/>
    public AuthProviderResponseOauth2TokenRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderResponseOauth2TokenRequest.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        AuthProviderResponseOauth2UserInfoRequest,
        AuthProviderResponseOauth2UserInfoRequestFromRaw
    >)
)]
public sealed record class AuthProviderResponseOauth2UserInfoRequest : JsonModel
{
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

    public string? Endpoint
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("endpoint");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("endpoint", value);
        }
    }

    public string? ExpirationFormat
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("expiration_format");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("expiration_format", value);
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

    public string? RequestContentType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("request_content_type");
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

    public string? ResponseContentType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("response_content_type");
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

    public AuthProviderResponseOauth2UserInfoRequestTriggers? Triggers
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<AuthProviderResponseOauth2UserInfoRequestTriggers>(
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
        _ = this.ExpirationFormat;
        _ = this.Method;
        _ = this.Params;
        _ = this.RequestContentType;
        _ = this.ResponseContentType;
        _ = this.ResponseMap;
        this.Triggers?.Validate();
    }

    public AuthProviderResponseOauth2UserInfoRequest() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AuthProviderResponseOauth2UserInfoRequest(
        AuthProviderResponseOauth2UserInfoRequest authProviderResponseOauth2UserInfoRequest
    )
        : base(authProviderResponseOauth2UserInfoRequest) { }
#pragma warning restore CS8618

    public AuthProviderResponseOauth2UserInfoRequest(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderResponseOauth2UserInfoRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderResponseOauth2UserInfoRequestFromRaw.FromRawUnchecked"/>
    public static AuthProviderResponseOauth2UserInfoRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthProviderResponseOauth2UserInfoRequestFromRaw
    : IFromRawJson<AuthProviderResponseOauth2UserInfoRequest>
{
    /// <inheritdoc/>
    public AuthProviderResponseOauth2UserInfoRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderResponseOauth2UserInfoRequest.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        AuthProviderResponseOauth2UserInfoRequestTriggers,
        AuthProviderResponseOauth2UserInfoRequestTriggersFromRaw
    >)
)]
public sealed record class AuthProviderResponseOauth2UserInfoRequestTriggers : JsonModel
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

    public AuthProviderResponseOauth2UserInfoRequestTriggers() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AuthProviderResponseOauth2UserInfoRequestTriggers(
        AuthProviderResponseOauth2UserInfoRequestTriggers authProviderResponseOauth2UserInfoRequestTriggers
    )
        : base(authProviderResponseOauth2UserInfoRequestTriggers) { }
#pragma warning restore CS8618

    public AuthProviderResponseOauth2UserInfoRequestTriggers(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderResponseOauth2UserInfoRequestTriggers(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthProviderResponseOauth2UserInfoRequestTriggersFromRaw.FromRawUnchecked"/>
    public static AuthProviderResponseOauth2UserInfoRequestTriggers FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthProviderResponseOauth2UserInfoRequestTriggersFromRaw
    : IFromRawJson<AuthProviderResponseOauth2UserInfoRequestTriggers>
{
    /// <inheritdoc/>
    public AuthProviderResponseOauth2UserInfoRequestTriggers FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderResponseOauth2UserInfoRequestTriggers.FromRawUnchecked(rawData);
}
