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

    public string? ID1
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

    public Oauth2Model? Oauth2
    {
        get { return ModelBase.GetNullableClass<Oauth2Model>(this.RawBodyData, "oauth2"); }
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

[JsonConverter(typeof(ModelConverter<Oauth2Model, Oauth2ModelFromRaw>))]
public sealed record class Oauth2Model : ModelBase
{
    public Oauth2ModelAuthorizeRequest? AuthorizeRequest
    {
        get
        {
            return ModelBase.GetNullableClass<Oauth2ModelAuthorizeRequest>(
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

    public Oauth2ModelPkce? Pkce
    {
        get { return ModelBase.GetNullableClass<Oauth2ModelPkce>(this.RawData, "pkce"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "pkce", value);
        }
    }

    public Oauth2ModelRefreshRequest? RefreshRequest
    {
        get
        {
            return ModelBase.GetNullableClass<Oauth2ModelRefreshRequest>(
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

    public ApiEnum<string, Oauth2ModelScopeDelimiter>? ScopeDelimiter
    {
        get
        {
            return ModelBase.GetNullableClass<ApiEnum<string, Oauth2ModelScopeDelimiter>>(
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

    public Oauth2ModelTokenRequest? TokenRequest
    {
        get
        {
            return ModelBase.GetNullableClass<Oauth2ModelTokenRequest>(
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

    public Oauth2ModelUserInfoRequest? UserInfoRequest
    {
        get
        {
            return ModelBase.GetNullableClass<Oauth2ModelUserInfoRequest>(
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

    public Oauth2Model(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Oauth2Model(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    public static Oauth2Model FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class Oauth2ModelFromRaw : IFromRaw<Oauth2Model>
{
    public Oauth2Model FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Oauth2Model.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(ModelConverter<Oauth2ModelAuthorizeRequest, Oauth2ModelAuthorizeRequestFromRaw>)
)]
public sealed record class Oauth2ModelAuthorizeRequest : ModelBase
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

    public ApiEnum<string, Oauth2ModelAuthorizeRequestRequestContentType>? RequestContentType
    {
        get
        {
            return ModelBase.GetNullableClass<
                ApiEnum<string, Oauth2ModelAuthorizeRequestRequestContentType>
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

    public ApiEnum<string, Oauth2ModelAuthorizeRequestResponseContentType>? ResponseContentType
    {
        get
        {
            return ModelBase.GetNullableClass<
                ApiEnum<string, Oauth2ModelAuthorizeRequestResponseContentType>
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

    public Oauth2ModelAuthorizeRequest(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Oauth2ModelAuthorizeRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    public static Oauth2ModelAuthorizeRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class Oauth2ModelAuthorizeRequestFromRaw : IFromRaw<Oauth2ModelAuthorizeRequest>
{
    public Oauth2ModelAuthorizeRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => Oauth2ModelAuthorizeRequest.FromRawUnchecked(rawData);
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

[JsonConverter(typeof(ModelConverter<Oauth2ModelPkce, Oauth2ModelPkceFromRaw>))]
public sealed record class Oauth2ModelPkce : ModelBase
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

    public Oauth2ModelPkce() { }

    public Oauth2ModelPkce(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Oauth2ModelPkce(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    public static Oauth2ModelPkce FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class Oauth2ModelPkceFromRaw : IFromRaw<Oauth2ModelPkce>
{
    public Oauth2ModelPkce FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Oauth2ModelPkce.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ModelConverter<Oauth2ModelRefreshRequest, Oauth2ModelRefreshRequestFromRaw>))]
public sealed record class Oauth2ModelRefreshRequest : ModelBase
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

    public ApiEnum<string, Oauth2ModelRefreshRequestRequestContentType>? RequestContentType
    {
        get
        {
            return ModelBase.GetNullableClass<
                ApiEnum<string, Oauth2ModelRefreshRequestRequestContentType>
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

    public ApiEnum<string, Oauth2ModelRefreshRequestResponseContentType>? ResponseContentType
    {
        get
        {
            return ModelBase.GetNullableClass<
                ApiEnum<string, Oauth2ModelRefreshRequestResponseContentType>
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

    public Oauth2ModelRefreshRequest(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Oauth2ModelRefreshRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    public static Oauth2ModelRefreshRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class Oauth2ModelRefreshRequestFromRaw : IFromRaw<Oauth2ModelRefreshRequest>
{
    public Oauth2ModelRefreshRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => Oauth2ModelRefreshRequest.FromRawUnchecked(rawData);
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

[JsonConverter(typeof(ModelConverter<Oauth2ModelTokenRequest, Oauth2ModelTokenRequestFromRaw>))]
public sealed record class Oauth2ModelTokenRequest : ModelBase
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

    public ApiEnum<string, Oauth2ModelTokenRequestRequestContentType>? RequestContentType
    {
        get
        {
            return ModelBase.GetNullableClass<
                ApiEnum<string, Oauth2ModelTokenRequestRequestContentType>
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

    public ApiEnum<string, Oauth2ModelTokenRequestResponseContentType>? ResponseContentType
    {
        get
        {
            return ModelBase.GetNullableClass<
                ApiEnum<string, Oauth2ModelTokenRequestResponseContentType>
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

    public Oauth2ModelTokenRequest(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Oauth2ModelTokenRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    public static Oauth2ModelTokenRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class Oauth2ModelTokenRequestFromRaw : IFromRaw<Oauth2ModelTokenRequest>
{
    public Oauth2ModelTokenRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => Oauth2ModelTokenRequest.FromRawUnchecked(rawData);
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

[JsonConverter(
    typeof(ModelConverter<Oauth2ModelUserInfoRequest, Oauth2ModelUserInfoRequestFromRaw>)
)]
public sealed record class Oauth2ModelUserInfoRequest : ModelBase
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

    public ApiEnum<string, Oauth2ModelUserInfoRequestRequestContentType>? RequestContentType
    {
        get
        {
            return ModelBase.GetNullableClass<
                ApiEnum<string, Oauth2ModelUserInfoRequestRequestContentType>
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

    public ApiEnum<string, Oauth2ModelUserInfoRequestResponseContentType>? ResponseContentType
    {
        get
        {
            return ModelBase.GetNullableClass<
                ApiEnum<string, Oauth2ModelUserInfoRequestResponseContentType>
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

    public Oauth2ModelUserInfoRequestTriggers? Triggers
    {
        get
        {
            return ModelBase.GetNullableClass<Oauth2ModelUserInfoRequestTriggers>(
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

    public Oauth2ModelUserInfoRequest(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Oauth2ModelUserInfoRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    public static Oauth2ModelUserInfoRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class Oauth2ModelUserInfoRequestFromRaw : IFromRaw<Oauth2ModelUserInfoRequest>
{
    public Oauth2ModelUserInfoRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => Oauth2ModelUserInfoRequest.FromRawUnchecked(rawData);
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

[JsonConverter(
    typeof(ModelConverter<
        Oauth2ModelUserInfoRequestTriggers,
        Oauth2ModelUserInfoRequestTriggersFromRaw
    >)
)]
public sealed record class Oauth2ModelUserInfoRequestTriggers : ModelBase
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

    public Oauth2ModelUserInfoRequestTriggers() { }

    public Oauth2ModelUserInfoRequestTriggers(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Oauth2ModelUserInfoRequestTriggers(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    public static Oauth2ModelUserInfoRequestTriggers FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class Oauth2ModelUserInfoRequestTriggersFromRaw : IFromRaw<Oauth2ModelUserInfoRequestTriggers>
{
    public Oauth2ModelUserInfoRequestTriggers FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => Oauth2ModelUserInfoRequestTriggers.FromRawUnchecked(rawData);
}
