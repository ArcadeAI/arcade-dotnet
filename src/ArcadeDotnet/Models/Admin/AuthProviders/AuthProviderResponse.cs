using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using System = System;

namespace ArcadeDotnet.Models.Admin.AuthProviders;

[JsonConverter(typeof(ModelConverter<AuthProviderResponse, AuthProviderResponseFromRaw>))]
public sealed record class AuthProviderResponse : ModelBase
{
    public string? ID
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "id", value);
        }
    }

    public Binding? Binding
    {
        get { return ModelBase.GetNullableClass<Binding>(this.RawData, "binding"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "binding", value);
        }
    }

    public string? CreatedAt
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "created_at"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "created_at", value);
        }
    }

    public string? Description
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "description"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "description", value);
        }
    }

    public AuthProviderResponseOauth2? Oauth2
    {
        get
        {
            return ModelBase.GetNullableClass<AuthProviderResponseOauth2>(this.RawData, "oauth2");
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

    public string? ProviderID
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "provider_id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "provider_id", value);
        }
    }

    public string? Status
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "status"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "status", value);
        }
    }

    public string? Type
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "type"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "type", value);
        }
    }

    public string? UpdatedAt
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "updated_at"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "updated_at", value);
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

    public AuthProviderResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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

class AuthProviderResponseFromRaw : IFromRaw<AuthProviderResponse>
{
    /// <inheritdoc/>
    public AuthProviderResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderResponse.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ModelConverter<Binding, BindingFromRaw>))]
public sealed record class Binding : ModelBase
{
    public string? ID
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "id", value);
        }
    }

    public ApiEnum<string, global::ArcadeDotnet.Models.Admin.AuthProviders.Type>? Type
    {
        get
        {
            return ModelBase.GetNullableClass<
                ApiEnum<string, global::ArcadeDotnet.Models.Admin.AuthProviders.Type>
            >(this.RawData, "type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "type", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        this.Type?.Validate();
    }

    public Binding() { }

    public Binding(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Binding(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="BindingFromRaw.FromRawUnchecked"/>
    public static Binding FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class BindingFromRaw : IFromRaw<Binding>
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
    typeof(ModelConverter<AuthProviderResponseOauth2, AuthProviderResponseOauth2FromRaw>)
)]
public sealed record class AuthProviderResponseOauth2 : ModelBase
{
    public AuthProviderResponseOauth2AuthorizeRequest? AuthorizeRequest
    {
        get
        {
            return ModelBase.GetNullableClass<AuthProviderResponseOauth2AuthorizeRequest>(
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

    public ClientSecret? ClientSecret
    {
        get { return ModelBase.GetNullableClass<ClientSecret>(this.RawData, "client_secret"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "client_secret", value);
        }
    }

    public AuthProviderResponseOauth2Pkce? Pkce
    {
        get
        {
            return ModelBase.GetNullableClass<AuthProviderResponseOauth2Pkce>(this.RawData, "pkce");
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

    /// <summary>
    /// The redirect URI required for this provider.
    /// </summary>
    public string? RedirectUri
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "redirect_uri"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "redirect_uri", value);
        }
    }

    public AuthProviderResponseOauth2RefreshRequest? RefreshRequest
    {
        get
        {
            return ModelBase.GetNullableClass<AuthProviderResponseOauth2RefreshRequest>(
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

    public string? ScopeDelimiter
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "scope_delimiter"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "scope_delimiter", value);
        }
    }

    public AuthProviderResponseOauth2TokenIntrospectionRequest? TokenIntrospectionRequest
    {
        get
        {
            return ModelBase.GetNullableClass<AuthProviderResponseOauth2TokenIntrospectionRequest>(
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

    public AuthProviderResponseOauth2TokenRequest? TokenRequest
    {
        get
        {
            return ModelBase.GetNullableClass<AuthProviderResponseOauth2TokenRequest>(
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

    public AuthProviderResponseOauth2UserInfoRequest? UserInfoRequest
    {
        get
        {
            return ModelBase.GetNullableClass<AuthProviderResponseOauth2UserInfoRequest>(
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

    public AuthProviderResponseOauth2(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderResponseOauth2(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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

class AuthProviderResponseOauth2FromRaw : IFromRaw<AuthProviderResponseOauth2>
{
    /// <inheritdoc/>
    public AuthProviderResponseOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderResponseOauth2.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(ModelConverter<
        AuthProviderResponseOauth2AuthorizeRequest,
        AuthProviderResponseOauth2AuthorizeRequestFromRaw
    >)
)]
public sealed record class AuthProviderResponseOauth2AuthorizeRequest : ModelBase
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

    public string? ExpirationFormat
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "expiration_format"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "expiration_format", value);
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

    public string? RequestContentType
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "request_content_type"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "request_content_type", value);
        }
    }

    public string? ResponseContentType
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "response_content_type"); }
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
        _ = this.ExpirationFormat;
        _ = this.Method;
        _ = this.Params;
        _ = this.RequestContentType;
        _ = this.ResponseContentType;
        _ = this.ResponseMap;
    }

    public AuthProviderResponseOauth2AuthorizeRequest() { }

    public AuthProviderResponseOauth2AuthorizeRequest(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderResponseOauth2AuthorizeRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
    : IFromRaw<AuthProviderResponseOauth2AuthorizeRequest>
{
    /// <inheritdoc/>
    public AuthProviderResponseOauth2AuthorizeRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderResponseOauth2AuthorizeRequest.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ModelConverter<ClientSecret, ClientSecretFromRaw>))]
public sealed record class ClientSecret : ModelBase
{
    public ApiEnum<string, ClientSecretBinding>? Binding
    {
        get
        {
            return ModelBase.GetNullableClass<ApiEnum<string, ClientSecretBinding>>(
                this.RawData,
                "binding"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "binding", value);
        }
    }

    public bool? Editable
    {
        get { return ModelBase.GetNullableStruct<bool>(this.RawData, "editable"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "editable", value);
        }
    }

    public bool? Exists
    {
        get { return ModelBase.GetNullableStruct<bool>(this.RawData, "exists"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "exists", value);
        }
    }

    public string? Hint
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "hint"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "hint", value);
        }
    }

    public string? Value
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "value"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "value", value);
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

    public ClientSecret(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ClientSecret(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ClientSecretFromRaw.FromRawUnchecked"/>
    public static ClientSecret FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ClientSecretFromRaw : IFromRaw<ClientSecret>
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
    typeof(ModelConverter<AuthProviderResponseOauth2Pkce, AuthProviderResponseOauth2PkceFromRaw>)
)]
public sealed record class AuthProviderResponseOauth2Pkce : ModelBase
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

    public AuthProviderResponseOauth2Pkce() { }

    public AuthProviderResponseOauth2Pkce(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderResponseOauth2Pkce(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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

class AuthProviderResponseOauth2PkceFromRaw : IFromRaw<AuthProviderResponseOauth2Pkce>
{
    /// <inheritdoc/>
    public AuthProviderResponseOauth2Pkce FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderResponseOauth2Pkce.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(ModelConverter<
        AuthProviderResponseOauth2RefreshRequest,
        AuthProviderResponseOauth2RefreshRequestFromRaw
    >)
)]
public sealed record class AuthProviderResponseOauth2RefreshRequest : ModelBase
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

    public string? ExpirationFormat
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "expiration_format"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "expiration_format", value);
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

    public string? RequestContentType
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "request_content_type"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "request_content_type", value);
        }
    }

    public string? ResponseContentType
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "response_content_type"); }
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
        _ = this.ExpirationFormat;
        _ = this.Method;
        _ = this.Params;
        _ = this.RequestContentType;
        _ = this.ResponseContentType;
        _ = this.ResponseMap;
    }

    public AuthProviderResponseOauth2RefreshRequest() { }

    public AuthProviderResponseOauth2RefreshRequest(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderResponseOauth2RefreshRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
    : IFromRaw<AuthProviderResponseOauth2RefreshRequest>
{
    /// <inheritdoc/>
    public AuthProviderResponseOauth2RefreshRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderResponseOauth2RefreshRequest.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(ModelConverter<
        AuthProviderResponseOauth2TokenIntrospectionRequest,
        AuthProviderResponseOauth2TokenIntrospectionRequestFromRaw
    >)
)]
public sealed record class AuthProviderResponseOauth2TokenIntrospectionRequest : ModelBase
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

    public string? ExpirationFormat
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "expiration_format"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "expiration_format", value);
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

    public string? RequestContentType
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "request_content_type"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "request_content_type", value);
        }
    }

    public string? ResponseContentType
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "response_content_type"); }
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

    public AuthProviderResponseOauth2TokenIntrospectionRequestTriggers? Triggers
    {
        get
        {
            return ModelBase.GetNullableClass<AuthProviderResponseOauth2TokenIntrospectionRequestTriggers>(
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

    public AuthProviderResponseOauth2TokenIntrospectionRequest(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderResponseOauth2TokenIntrospectionRequest(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = [.. rawData];
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
    : IFromRaw<AuthProviderResponseOauth2TokenIntrospectionRequest>
{
    /// <inheritdoc/>
    public AuthProviderResponseOauth2TokenIntrospectionRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderResponseOauth2TokenIntrospectionRequest.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(ModelConverter<
        AuthProviderResponseOauth2TokenIntrospectionRequestTriggers,
        AuthProviderResponseOauth2TokenIntrospectionRequestTriggersFromRaw
    >)
)]
public sealed record class AuthProviderResponseOauth2TokenIntrospectionRequestTriggers : ModelBase
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

    public AuthProviderResponseOauth2TokenIntrospectionRequestTriggers() { }

    public AuthProviderResponseOauth2TokenIntrospectionRequestTriggers(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderResponseOauth2TokenIntrospectionRequestTriggers(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = [.. rawData];
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
    : IFromRaw<AuthProviderResponseOauth2TokenIntrospectionRequestTriggers>
{
    /// <inheritdoc/>
    public AuthProviderResponseOauth2TokenIntrospectionRequestTriggers FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderResponseOauth2TokenIntrospectionRequestTriggers.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(ModelConverter<
        AuthProviderResponseOauth2TokenRequest,
        AuthProviderResponseOauth2TokenRequestFromRaw
    >)
)]
public sealed record class AuthProviderResponseOauth2TokenRequest : ModelBase
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

    public string? ExpirationFormat
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "expiration_format"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "expiration_format", value);
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

    public string? RequestContentType
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "request_content_type"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "request_content_type", value);
        }
    }

    public string? ResponseContentType
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "response_content_type"); }
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
        _ = this.ExpirationFormat;
        _ = this.Method;
        _ = this.Params;
        _ = this.RequestContentType;
        _ = this.ResponseContentType;
        _ = this.ResponseMap;
    }

    public AuthProviderResponseOauth2TokenRequest() { }

    public AuthProviderResponseOauth2TokenRequest(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderResponseOauth2TokenRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
    : IFromRaw<AuthProviderResponseOauth2TokenRequest>
{
    /// <inheritdoc/>
    public AuthProviderResponseOauth2TokenRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderResponseOauth2TokenRequest.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(ModelConverter<
        AuthProviderResponseOauth2UserInfoRequest,
        AuthProviderResponseOauth2UserInfoRequestFromRaw
    >)
)]
public sealed record class AuthProviderResponseOauth2UserInfoRequest : ModelBase
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

    public string? ExpirationFormat
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "expiration_format"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "expiration_format", value);
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

    public string? RequestContentType
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "request_content_type"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "request_content_type", value);
        }
    }

    public string? ResponseContentType
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "response_content_type"); }
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

    public AuthProviderResponseOauth2UserInfoRequestTriggers? Triggers
    {
        get
        {
            return ModelBase.GetNullableClass<AuthProviderResponseOauth2UserInfoRequestTriggers>(
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
        _ = this.ExpirationFormat;
        _ = this.Method;
        _ = this.Params;
        _ = this.RequestContentType;
        _ = this.ResponseContentType;
        _ = this.ResponseMap;
        this.Triggers?.Validate();
    }

    public AuthProviderResponseOauth2UserInfoRequest() { }

    public AuthProviderResponseOauth2UserInfoRequest(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderResponseOauth2UserInfoRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
    : IFromRaw<AuthProviderResponseOauth2UserInfoRequest>
{
    /// <inheritdoc/>
    public AuthProviderResponseOauth2UserInfoRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderResponseOauth2UserInfoRequest.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(ModelConverter<
        AuthProviderResponseOauth2UserInfoRequestTriggers,
        AuthProviderResponseOauth2UserInfoRequestTriggersFromRaw
    >)
)]
public sealed record class AuthProviderResponseOauth2UserInfoRequestTriggers : ModelBase
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

    public AuthProviderResponseOauth2UserInfoRequestTriggers() { }

    public AuthProviderResponseOauth2UserInfoRequestTriggers(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthProviderResponseOauth2UserInfoRequestTriggers(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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
    : IFromRaw<AuthProviderResponseOauth2UserInfoRequestTriggers>
{
    /// <inheritdoc/>
    public AuthProviderResponseOauth2UserInfoRequestTriggers FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthProviderResponseOauth2UserInfoRequestTriggers.FromRawUnchecked(rawData);
}
