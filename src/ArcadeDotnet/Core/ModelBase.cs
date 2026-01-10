using System.Text.Json;
using ArcadeDotnet.Exceptions;
using ArcadeDotnet.Models;
using ArcadeDotnet.Models.Admin.AuthProviders;
using Chat = ArcadeDotnet.Models.Chat;
using Completions = ArcadeDotnet.Models.Chat.Completions;
using Secrets = ArcadeDotnet.Models.Admin.Secrets;
using Tools = ArcadeDotnet.Models.Tools;
using Workers = ArcadeDotnet.Models.Workers;

namespace ArcadeDotnet.Core;

/// <summary>
/// The base class for all API objects with properties.
///
/// <para>API objects such as enums and unions do not inherit from this class.</para>
/// </summary>
public abstract record class ModelBase
{
    protected ModelBase(ModelBase modelBase)
    {
        // Nothing to copy. Just so that subclasses can define copy constructors.
    }

    internal static readonly JsonSerializerOptions SerializerOptions = new()
    {
        Converters =
        {
            new ApiEnumConverter<string, Status>(),
            new ApiEnumConverter<
                string,
                AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderCreateRequestOauth2RefreshRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderCreateRequestOauth2RefreshRequestResponseContentType
            >(),
            new ApiEnumConverter<string, AuthProviderCreateRequestOauth2ScopeDelimiter>(),
            new ApiEnumConverter<
                string,
                AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderCreateRequestOauth2TokenRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderCreateRequestOauth2TokenRequestResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType
            >(),
            new ApiEnumConverter<string, Type>(),
            new ApiEnumConverter<string, ClientSecretBinding>(),
            new ApiEnumConverter<
                string,
                AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType
            >(),
            new ApiEnumConverter<string, AuthProviderUpdateRequestOauth2ScopeDelimiter>(),
            new ApiEnumConverter<
                string,
                AuthProviderUpdateRequestOauth2TokenRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderUpdateRequestOauth2TokenRequestResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType
            >(),
            new ApiEnumConverter<string, RequestContentType>(),
            new ApiEnumConverter<string, ResponseContentType>(),
            new ApiEnumConverter<string, RefreshRequestRequestContentType>(),
            new ApiEnumConverter<string, RefreshRequestResponseContentType>(),
            new ApiEnumConverter<string, ScopeDelimiter>(),
            new ApiEnumConverter<string, TokenIntrospectionRequestRequestContentType>(),
            new ApiEnumConverter<string, TokenIntrospectionRequestResponseContentType>(),
            new ApiEnumConverter<string, TokenRequestRequestContentType>(),
            new ApiEnumConverter<string, TokenRequestResponseContentType>(),
            new ApiEnumConverter<string, UserInfoRequestRequestContentType>(),
            new ApiEnumConverter<string, UserInfoRequestResponseContentType>(),
            new ApiEnumConverter<
                string,
                AuthProviderPatchParamsOauth2AuthorizeRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderPatchParamsOauth2AuthorizeRequestResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderPatchParamsOauth2RefreshRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderPatchParamsOauth2RefreshRequestResponseContentType
            >(),
            new ApiEnumConverter<string, AuthProviderPatchParamsOauth2ScopeDelimiter>(),
            new ApiEnumConverter<
                string,
                AuthProviderPatchParamsOauth2TokenRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderPatchParamsOauth2TokenRequestResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderPatchParamsOauth2UserInfoRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderPatchParamsOauth2UserInfoRequestResponseContentType
            >(),
            new ApiEnumConverter<string, Secrets::Type>(),
            new ApiEnumConverter<string, Chat::Type>(),
            new ApiEnumConverter<string, Chat::ResponseFormatType>(),
            new ApiEnumConverter<string, Completions::Type>(),
            new ApiEnumConverter<string, Tools::Kind>(),
            new ApiEnumConverter<string, Tools::Status>(),
            new ApiEnumConverter<string, Tools::TokenStatus>(),
            new ApiEnumConverter<string, Tools::ToolExecutionAttemptOutputErrorKind>(),
            new ApiEnumConverter<string, Tools::IncludeFormat>(),
            new ApiEnumConverter<string, Tools::ToolGetParamsIncludeFormat>(),
            new ApiEnumConverter<string, Workers::Type>(),
            new ApiEnumConverter<string, Workers::SecretBinding>(),
            new ApiEnumConverter<string, Workers::ClientSecretBinding>(),
            new ApiEnumConverter<string, Workers::SecretsItemBinding>(),
            new ApiEnumConverter<string, Workers::WorkerResponseType>(),
        },
    };

    internal static readonly JsonSerializerOptions ToStringSerializerOptions = new(
        SerializerOptions
    )
    {
        WriteIndented = true,
    };

    /// <summary>
    /// Validates that all required fields are set and that each field's value is of the expected type.
    ///
    /// <para>This is useful for instances constructed from raw JSON data (e.g. deserialized from an API response).</para>
    ///
    /// <exception cref="ArcadeInvalidDataException">
    /// Thrown when the instance does not pass validation.
    /// </exception>
    /// </summary>
    public abstract void Validate();
}
