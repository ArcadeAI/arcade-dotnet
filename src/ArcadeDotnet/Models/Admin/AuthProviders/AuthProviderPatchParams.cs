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
    readonly FreezableDictionary<string, JsonElement> _bodyProperties = [];
    public IReadOnlyDictionary<string, JsonElement> BodyProperties
    {
        get { return this._bodyProperties.Freeze(); }
    }

    public required string ID { get; init; }

    public string? ID1
    {
        get
        {
            if (!this._bodyProperties.TryGetValue("id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

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

    public Oauth2Model? Oauth2
    {
        get
        {
            if (!this._bodyProperties.TryGetValue("oauth2", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Oauth2Model?>(element, ModelBase.SerializerOptions);
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

    public AuthProviderPatchParams() { }

    public AuthProviderPatchParams(
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
    AuthProviderPatchParams(
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

    public static AuthProviderPatchParams FromRawUnchecked(
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
            options.BaseUrl.ToString().TrimEnd('/')
                + string.Format("/v1/admin/auth_providers/{0}", this.ID)
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

[JsonConverter(typeof(ModelConverter<Oauth2Model>))]
public sealed record class Oauth2Model : ModelBase, IFromRaw<Oauth2Model>
{
    public Oauth2ModelAuthorizeRequest? AuthorizeRequest
    {
        get
        {
            if (!this._properties.TryGetValue("authorize_request", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Oauth2ModelAuthorizeRequest?>(
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

    public string? ClientID
    {
        get
        {
            if (!this._properties.TryGetValue("client_id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["client_id"] = JsonSerializer.SerializeToElement(
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

    public Oauth2ModelPkce? Pkce
    {
        get
        {
            if (!this._properties.TryGetValue("pkce", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Oauth2ModelPkce?>(
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

    public Oauth2ModelRefreshRequest? RefreshRequest
    {
        get
        {
            if (!this._properties.TryGetValue("refresh_request", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Oauth2ModelRefreshRequest?>(
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

    public ApiEnum<string, Oauth2ModelScopeDelimiter>? ScopeDelimiter
    {
        get
        {
            if (!this._properties.TryGetValue("scope_delimiter", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<string, Oauth2ModelScopeDelimiter>?>(
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

    public Oauth2ModelTokenRequest? TokenRequest
    {
        get
        {
            if (!this._properties.TryGetValue("token_request", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Oauth2ModelTokenRequest?>(
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

    public Oauth2ModelUserInfoRequest? UserInfoRequest
    {
        get
        {
            if (!this._properties.TryGetValue("user_info_request", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Oauth2ModelUserInfoRequest?>(
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
        this.AuthorizeRequest?.Validate();
        _ = this.ClientID;
        _ = this.ClientSecret;
        this.Pkce?.Validate();
        this.RefreshRequest?.Validate();
        this.ScopeDelimiter?.Validate();
        this.TokenRequest?.Validate();
        this.UserInfoRequest?.Validate();
    }

    public Oauth2Model() { }

    public Oauth2Model(IReadOnlyDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Oauth2Model(FrozenDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static Oauth2Model FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> properties)
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }
}

[JsonConverter(typeof(ModelConverter<Oauth2ModelAuthorizeRequest>))]
public sealed record class Oauth2ModelAuthorizeRequest
    : ModelBase,
        IFromRaw<Oauth2ModelAuthorizeRequest>
{
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

    public string? Endpoint
    {
        get
        {
            if (!this._properties.TryGetValue("endpoint", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["endpoint"] = JsonSerializer.SerializeToElement(
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

    public ApiEnum<string, Oauth2ModelAuthorizeRequestRequestContentType>? RequestContentType
    {
        get
        {
            if (!this._properties.TryGetValue("request_content_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<
                string,
                Oauth2ModelAuthorizeRequestRequestContentType
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

    public ApiEnum<string, Oauth2ModelAuthorizeRequestResponseContentType>? ResponseContentType
    {
        get
        {
            if (!this._properties.TryGetValue("response_content_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<
                string,
                Oauth2ModelAuthorizeRequestResponseContentType
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
        _ = this.AuthHeaderValueFormat;
        _ = this.AuthMethod;
        _ = this.Endpoint;
        _ = this.Method;
        _ = this.Params;
        this.RequestContentType?.Validate();
        this.ResponseContentType?.Validate();
        _ = this.ResponseMap;
    }

    public Oauth2ModelAuthorizeRequest() { }

    public Oauth2ModelAuthorizeRequest(IReadOnlyDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Oauth2ModelAuthorizeRequest(FrozenDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static Oauth2ModelAuthorizeRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }
}

[JsonConverter(typeof(Oauth2ModelAuthorizeRequestRequestContentTypeConverter))]
public enum Oauth2ModelAuthorizeRequestRequestContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class Oauth2ModelAuthorizeRequestRequestContentTypeConverter
    : JsonConverter<Oauth2ModelAuthorizeRequestRequestContentType>
{
    public override Oauth2ModelAuthorizeRequestRequestContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                Oauth2ModelAuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            "application/json" => Oauth2ModelAuthorizeRequestRequestContentType.ApplicationJson,
            _ => (Oauth2ModelAuthorizeRequestRequestContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        Oauth2ModelAuthorizeRequestRequestContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Oauth2ModelAuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                Oauth2ModelAuthorizeRequestRequestContentType.ApplicationJson => "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(Oauth2ModelAuthorizeRequestResponseContentTypeConverter))]
public enum Oauth2ModelAuthorizeRequestResponseContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class Oauth2ModelAuthorizeRequestResponseContentTypeConverter
    : JsonConverter<Oauth2ModelAuthorizeRequestResponseContentType>
{
    public override Oauth2ModelAuthorizeRequestResponseContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                Oauth2ModelAuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            "application/json" => Oauth2ModelAuthorizeRequestResponseContentType.ApplicationJson,
            _ => (Oauth2ModelAuthorizeRequestResponseContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        Oauth2ModelAuthorizeRequestResponseContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Oauth2ModelAuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                Oauth2ModelAuthorizeRequestResponseContentType.ApplicationJson =>
                    "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(ModelConverter<Oauth2ModelPkce>))]
public sealed record class Oauth2ModelPkce : ModelBase, IFromRaw<Oauth2ModelPkce>
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

    public Oauth2ModelPkce() { }

    public Oauth2ModelPkce(IReadOnlyDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Oauth2ModelPkce(FrozenDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static Oauth2ModelPkce FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }
}

[JsonConverter(typeof(ModelConverter<Oauth2ModelRefreshRequest>))]
public sealed record class Oauth2ModelRefreshRequest
    : ModelBase,
        IFromRaw<Oauth2ModelRefreshRequest>
{
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

    public string? Endpoint
    {
        get
        {
            if (!this._properties.TryGetValue("endpoint", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["endpoint"] = JsonSerializer.SerializeToElement(
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

    public ApiEnum<string, Oauth2ModelRefreshRequestRequestContentType>? RequestContentType
    {
        get
        {
            if (!this._properties.TryGetValue("request_content_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<
                string,
                Oauth2ModelRefreshRequestRequestContentType
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

    public ApiEnum<string, Oauth2ModelRefreshRequestResponseContentType>? ResponseContentType
    {
        get
        {
            if (!this._properties.TryGetValue("response_content_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<
                string,
                Oauth2ModelRefreshRequestResponseContentType
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
        _ = this.AuthHeaderValueFormat;
        _ = this.AuthMethod;
        _ = this.Endpoint;
        _ = this.Method;
        _ = this.Params;
        this.RequestContentType?.Validate();
        this.ResponseContentType?.Validate();
        _ = this.ResponseMap;
    }

    public Oauth2ModelRefreshRequest() { }

    public Oauth2ModelRefreshRequest(IReadOnlyDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Oauth2ModelRefreshRequest(FrozenDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static Oauth2ModelRefreshRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }
}

[JsonConverter(typeof(Oauth2ModelRefreshRequestRequestContentTypeConverter))]
public enum Oauth2ModelRefreshRequestRequestContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class Oauth2ModelRefreshRequestRequestContentTypeConverter
    : JsonConverter<Oauth2ModelRefreshRequestRequestContentType>
{
    public override Oauth2ModelRefreshRequestRequestContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                Oauth2ModelRefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            "application/json" => Oauth2ModelRefreshRequestRequestContentType.ApplicationJson,
            _ => (Oauth2ModelRefreshRequestRequestContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        Oauth2ModelRefreshRequestRequestContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Oauth2ModelRefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                Oauth2ModelRefreshRequestRequestContentType.ApplicationJson => "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(Oauth2ModelRefreshRequestResponseContentTypeConverter))]
public enum Oauth2ModelRefreshRequestResponseContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class Oauth2ModelRefreshRequestResponseContentTypeConverter
    : JsonConverter<Oauth2ModelRefreshRequestResponseContentType>
{
    public override Oauth2ModelRefreshRequestResponseContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                Oauth2ModelRefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            "application/json" => Oauth2ModelRefreshRequestResponseContentType.ApplicationJson,
            _ => (Oauth2ModelRefreshRequestResponseContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        Oauth2ModelRefreshRequestResponseContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Oauth2ModelRefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                Oauth2ModelRefreshRequestResponseContentType.ApplicationJson => "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(Oauth2ModelScopeDelimiterConverter))]
public enum Oauth2ModelScopeDelimiter
{
    Undefined,
    V1,
}

sealed class Oauth2ModelScopeDelimiterConverter : JsonConverter<Oauth2ModelScopeDelimiter>
{
    public override Oauth2ModelScopeDelimiter Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "," => Oauth2ModelScopeDelimiter.Undefined,
            " " => Oauth2ModelScopeDelimiter.V1,
            _ => (Oauth2ModelScopeDelimiter)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        Oauth2ModelScopeDelimiter value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Oauth2ModelScopeDelimiter.Undefined => ",",
                Oauth2ModelScopeDelimiter.V1 => " ",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(ModelConverter<Oauth2ModelTokenRequest>))]
public sealed record class Oauth2ModelTokenRequest : ModelBase, IFromRaw<Oauth2ModelTokenRequest>
{
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

    public string? Endpoint
    {
        get
        {
            if (!this._properties.TryGetValue("endpoint", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["endpoint"] = JsonSerializer.SerializeToElement(
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

    public ApiEnum<string, Oauth2ModelTokenRequestRequestContentType>? RequestContentType
    {
        get
        {
            if (!this._properties.TryGetValue("request_content_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<
                string,
                Oauth2ModelTokenRequestRequestContentType
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

    public ApiEnum<string, Oauth2ModelTokenRequestResponseContentType>? ResponseContentType
    {
        get
        {
            if (!this._properties.TryGetValue("response_content_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<
                string,
                Oauth2ModelTokenRequestResponseContentType
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
        _ = this.AuthHeaderValueFormat;
        _ = this.AuthMethod;
        _ = this.Endpoint;
        _ = this.Method;
        _ = this.Params;
        this.RequestContentType?.Validate();
        this.ResponseContentType?.Validate();
        _ = this.ResponseMap;
    }

    public Oauth2ModelTokenRequest() { }

    public Oauth2ModelTokenRequest(IReadOnlyDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Oauth2ModelTokenRequest(FrozenDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static Oauth2ModelTokenRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }
}

[JsonConverter(typeof(Oauth2ModelTokenRequestRequestContentTypeConverter))]
public enum Oauth2ModelTokenRequestRequestContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class Oauth2ModelTokenRequestRequestContentTypeConverter
    : JsonConverter<Oauth2ModelTokenRequestRequestContentType>
{
    public override Oauth2ModelTokenRequestRequestContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                Oauth2ModelTokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            "application/json" => Oauth2ModelTokenRequestRequestContentType.ApplicationJson,
            _ => (Oauth2ModelTokenRequestRequestContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        Oauth2ModelTokenRequestRequestContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Oauth2ModelTokenRequestRequestContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                Oauth2ModelTokenRequestRequestContentType.ApplicationJson => "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(Oauth2ModelTokenRequestResponseContentTypeConverter))]
public enum Oauth2ModelTokenRequestResponseContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class Oauth2ModelTokenRequestResponseContentTypeConverter
    : JsonConverter<Oauth2ModelTokenRequestResponseContentType>
{
    public override Oauth2ModelTokenRequestResponseContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                Oauth2ModelTokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            "application/json" => Oauth2ModelTokenRequestResponseContentType.ApplicationJson,
            _ => (Oauth2ModelTokenRequestResponseContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        Oauth2ModelTokenRequestResponseContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Oauth2ModelTokenRequestResponseContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                Oauth2ModelTokenRequestResponseContentType.ApplicationJson => "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(ModelConverter<Oauth2ModelUserInfoRequest>))]
public sealed record class Oauth2ModelUserInfoRequest
    : ModelBase,
        IFromRaw<Oauth2ModelUserInfoRequest>
{
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

    public string? Endpoint
    {
        get
        {
            if (!this._properties.TryGetValue("endpoint", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._properties["endpoint"] = JsonSerializer.SerializeToElement(
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

    public ApiEnum<string, Oauth2ModelUserInfoRequestRequestContentType>? RequestContentType
    {
        get
        {
            if (!this._properties.TryGetValue("request_content_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<
                string,
                Oauth2ModelUserInfoRequestRequestContentType
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

    public ApiEnum<string, Oauth2ModelUserInfoRequestResponseContentType>? ResponseContentType
    {
        get
        {
            if (!this._properties.TryGetValue("response_content_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<
                string,
                Oauth2ModelUserInfoRequestResponseContentType
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

    public Oauth2ModelUserInfoRequestTriggers? Triggers
    {
        get
        {
            if (!this._properties.TryGetValue("triggers", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Oauth2ModelUserInfoRequestTriggers?>(
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

            this._properties["triggers"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

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

    public Oauth2ModelUserInfoRequest() { }

    public Oauth2ModelUserInfoRequest(IReadOnlyDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Oauth2ModelUserInfoRequest(FrozenDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static Oauth2ModelUserInfoRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }
}

[JsonConverter(typeof(Oauth2ModelUserInfoRequestRequestContentTypeConverter))]
public enum Oauth2ModelUserInfoRequestRequestContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class Oauth2ModelUserInfoRequestRequestContentTypeConverter
    : JsonConverter<Oauth2ModelUserInfoRequestRequestContentType>
{
    public override Oauth2ModelUserInfoRequestRequestContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                Oauth2ModelUserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            "application/json" => Oauth2ModelUserInfoRequestRequestContentType.ApplicationJson,
            _ => (Oauth2ModelUserInfoRequestRequestContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        Oauth2ModelUserInfoRequestRequestContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Oauth2ModelUserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                Oauth2ModelUserInfoRequestRequestContentType.ApplicationJson => "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(Oauth2ModelUserInfoRequestResponseContentTypeConverter))]
public enum Oauth2ModelUserInfoRequestResponseContentType
{
    ApplicationXWwwFormUrlencoded,
    ApplicationJson,
}

sealed class Oauth2ModelUserInfoRequestResponseContentTypeConverter
    : JsonConverter<Oauth2ModelUserInfoRequestResponseContentType>
{
    public override Oauth2ModelUserInfoRequestResponseContentType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "application/x-www-form-urlencoded" =>
                Oauth2ModelUserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            "application/json" => Oauth2ModelUserInfoRequestResponseContentType.ApplicationJson,
            _ => (Oauth2ModelUserInfoRequestResponseContentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        Oauth2ModelUserInfoRequestResponseContentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Oauth2ModelUserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded =>
                    "application/x-www-form-urlencoded",
                Oauth2ModelUserInfoRequestResponseContentType.ApplicationJson => "application/json",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(ModelConverter<Oauth2ModelUserInfoRequestTriggers>))]
public sealed record class Oauth2ModelUserInfoRequestTriggers
    : ModelBase,
        IFromRaw<Oauth2ModelUserInfoRequestTriggers>
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

    public Oauth2ModelUserInfoRequestTriggers() { }

    public Oauth2ModelUserInfoRequestTriggers(IReadOnlyDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Oauth2ModelUserInfoRequestTriggers(FrozenDictionary<string, JsonElement> properties)
    {
        this._properties = [.. properties];
    }
#pragma warning restore CS8618

    public static Oauth2ModelUserInfoRequestTriggers FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> properties
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(properties));
    }
}
