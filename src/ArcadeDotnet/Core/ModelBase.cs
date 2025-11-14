using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Models;
using ArcadeDotnet.Models.Admin.Secrets;
using AuthProviders = ArcadeDotnet.Models.Admin.AuthProviders;
using Chat = ArcadeDotnet.Models.Chat;
using Completions = ArcadeDotnet.Models.Chat.Completions;
using Tools = ArcadeDotnet.Models.Tools;
using Workers = ArcadeDotnet.Models.Workers;

namespace ArcadeDotnet.Core;

public abstract record class ModelBase
{
    private protected FreezableDictionary<string, JsonElement> _properties = [];

    public IReadOnlyDictionary<string, JsonElement> Properties
    {
        get { return this._properties.Freeze(); }
    }

    internal static readonly JsonSerializerOptions SerializerOptions = new()
    {
        Converters =
        {
            new ApiEnumConverter<string, Status>(),
            new ApiEnumConverter<
                string,
                AuthProviders::AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviders::AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviders::AuthProviderCreateRequestOauth2RefreshRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviders::AuthProviderCreateRequestOauth2RefreshRequestResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviders::AuthProviderCreateRequestOauth2ScopeDelimiter
            >(),
            new ApiEnumConverter<
                string,
                AuthProviders::AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviders::AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviders::AuthProviderCreateRequestOauth2TokenRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviders::AuthProviderCreateRequestOauth2TokenRequestResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviders::AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviders::AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType
            >(),
            new ApiEnumConverter<string, AuthProviders::Type>(),
            new ApiEnumConverter<string, AuthProviders::ClientSecretBinding>(),
            new ApiEnumConverter<
                string,
                AuthProviders::AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviders::AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviders::AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviders::AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviders::AuthProviderUpdateRequestOauth2ScopeDelimiter
            >(),
            new ApiEnumConverter<
                string,
                AuthProviders::AuthProviderUpdateRequestOauth2TokenRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviders::AuthProviderUpdateRequestOauth2TokenRequestResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviders::AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviders::AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType
            >(),
            new ApiEnumConverter<string, AuthProviders::RequestContentType>(),
            new ApiEnumConverter<string, AuthProviders::ResponseContentType>(),
            new ApiEnumConverter<string, AuthProviders::RefreshRequestRequestContentType>(),
            new ApiEnumConverter<string, AuthProviders::RefreshRequestResponseContentType>(),
            new ApiEnumConverter<string, AuthProviders::ScopeDelimiter>(),
            new ApiEnumConverter<
                string,
                AuthProviders::TokenIntrospectionRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviders::TokenIntrospectionRequestResponseContentType
            >(),
            new ApiEnumConverter<string, AuthProviders::TokenRequestRequestContentType>(),
            new ApiEnumConverter<string, AuthProviders::TokenRequestResponseContentType>(),
            new ApiEnumConverter<string, AuthProviders::UserInfoRequestRequestContentType>(),
            new ApiEnumConverter<string, AuthProviders::UserInfoRequestResponseContentType>(),
            new ApiEnumConverter<
                string,
                AuthProviders::Oauth2ModelAuthorizeRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviders::Oauth2ModelAuthorizeRequestResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviders::Oauth2ModelRefreshRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviders::Oauth2ModelRefreshRequestResponseContentType
            >(),
            new ApiEnumConverter<string, AuthProviders::Oauth2ModelScopeDelimiter>(),
            new ApiEnumConverter<
                string,
                AuthProviders::Oauth2ModelTokenRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviders::Oauth2ModelTokenRequestResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviders::Oauth2ModelUserInfoRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviders::Oauth2ModelUserInfoRequestResponseContentType
            >(),
            new ApiEnumConverter<string, Type>(),
            new ApiEnumConverter<string, Chat::Type>(),
            new ApiEnumConverter<string, Chat::ResponseFormatType>(),
            new ApiEnumConverter<string, Completions::Type>(),
            new ApiEnumConverter<string, Tools::Kind>(),
            new ApiEnumConverter<string, Tools::Status>(),
            new ApiEnumConverter<string, Tools::TokenStatus>(),
            new ApiEnumConverter<string, Tools::ToolExecutionAttemptOutputErrorKind>(),
            new ApiEnumConverter<string, Tools::IncludeFormat>(),
            new ApiEnumConverter<string, Tools::IncludeFormatModel>(),
            new ApiEnumConverter<string, Workers::Type>(),
            new ApiEnumConverter<string, Workers::SecretBinding>(),
            new ApiEnumConverter<string, Workers::ClientSecretBinding>(),
            new ApiEnumConverter<string, Workers::SecretsItemBinding>(),
            new ApiEnumConverter<string, Workers::WorkerResponseType>(),
        },
    };

    static readonly JsonSerializerOptions _toStringSerializerOptions = new(SerializerOptions)
    {
        WriteIndented = true,
    };

    public sealed override string? ToString()
    {
        return JsonSerializer.Serialize(this.Properties, _toStringSerializerOptions);
    }

    public abstract void Validate();
}

interface IFromRaw<T>
{
    static abstract T FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> properties);
}
