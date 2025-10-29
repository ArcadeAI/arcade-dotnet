using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderCreateRequestProperties.Oauth2Properties;
using ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderCreateRequestProperties.Oauth2Properties.AuthorizeRequestProperties;
using ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderResponseProperties.BindingProperties;
using ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderResponseProperties.Oauth2Properties.ClientSecretProperties;
using ArcadeDotnet.Models.AuthorizationResponseProperties;
using ArcadeDotnet.Models.Tools.ExecuteToolResponseProperties.OutputProperties.ErrorProperties;
using ArcadeDotnet.Models.Tools.ToolListParamsProperties;
using AuthorizationProperties = ArcadeDotnet.Models.Tools.ToolDefinitionProperties.RequirementsProperties.AuthorizationProperties;
using AuthorizeRequestProperties = ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderUpdateRequestProperties.Oauth2Properties.AuthorizeRequestProperties;
using BindingProperties = ArcadeDotnet.Models.Admin.Secrets.SecretResponseProperties.BindingProperties;
using ClientSecretProperties = ArcadeDotnet.Models.Workers.WorkerResponseProperties.McpProperties.Oauth2Properties.ClientSecretProperties;
using ErrorProperties = ArcadeDotnet.Models.Tools.ToolExecutionAttemptProperties.OutputProperties.ErrorProperties;
using Oauth2Properties = ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderUpdateRequestProperties.Oauth2Properties;
using RefreshRequestProperties = ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderCreateRequestProperties.Oauth2Properties.RefreshRequestProperties;
using ResponseFormatProperties = ArcadeDotnet.Models.Chat.ChatRequestProperties.ResponseFormatProperties;
using SecretProperties = ArcadeDotnet.Models.Workers.WorkerResponseProperties.HTTPProperties.SecretProperties;
using SecretsItemProperties = ArcadeDotnet.Models.Workers.WorkerResponseProperties.McpProperties.SecretsProperties.SecretsItemProperties;
using TokenIntrospectionRequestProperties = ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderCreateRequestProperties.Oauth2Properties.TokenIntrospectionRequestProperties;
using TokenRequestProperties = ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderCreateRequestProperties.Oauth2Properties.TokenRequestProperties;
using ToolCallProperties = ArcadeDotnet.Models.Chat.ChatMessageProperties.ToolCallProperties;
using ToolGetParamsProperties = ArcadeDotnet.Models.Tools.ToolGetParamsProperties;
using UserInfoRequestProperties = ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderCreateRequestProperties.Oauth2Properties.UserInfoRequestProperties;
using WorkerResponseProperties = ArcadeDotnet.Models.Workers.WorkerResponseProperties;

namespace ArcadeDotnet.Core;

public abstract record class ModelBase
{
    public Dictionary<string, JsonElement> Properties { get; set; } = [];

    internal static readonly JsonSerializerOptions SerializerOptions = new()
    {
        Converters =
        {
            new ApiEnumConverter<string, Status>(),
            new ApiEnumConverter<string, RequestContentType>(),
            new ApiEnumConverter<string, ResponseContentType>(),
            new ApiEnumConverter<string, RefreshRequestProperties::RequestContentType>(),
            new ApiEnumConverter<string, RefreshRequestProperties::ResponseContentType>(),
            new ApiEnumConverter<string, ScopeDelimiter>(),
            new ApiEnumConverter<string, TokenIntrospectionRequestProperties::RequestContentType>(),
            new ApiEnumConverter<
                string,
                TokenIntrospectionRequestProperties::ResponseContentType
            >(),
            new ApiEnumConverter<string, TokenRequestProperties::RequestContentType>(),
            new ApiEnumConverter<string, TokenRequestProperties::ResponseContentType>(),
            new ApiEnumConverter<string, UserInfoRequestProperties::RequestContentType>(),
            new ApiEnumConverter<string, UserInfoRequestProperties::ResponseContentType>(),
            new ApiEnumConverter<string, Type>(),
            new ApiEnumConverter<string, Binding>(),
            new ApiEnumConverter<string, AuthorizeRequestProperties::RequestContentType>(),
            new ApiEnumConverter<string, AuthorizeRequestProperties::ResponseContentType>(),
            new ApiEnumConverter<
                string,
                global::ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderUpdateRequestProperties.Oauth2Properties.RefreshRequestProperties.RequestContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderUpdateRequestProperties.Oauth2Properties.RefreshRequestProperties.ResponseContentType
            >(),
            new ApiEnumConverter<string, Oauth2Properties::ScopeDelimiter>(),
            new ApiEnumConverter<
                string,
                global::ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderUpdateRequestProperties.Oauth2Properties.TokenRequestProperties.RequestContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderUpdateRequestProperties.Oauth2Properties.TokenRequestProperties.ResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderUpdateRequestProperties.Oauth2Properties.UserInfoRequestProperties.RequestContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderUpdateRequestProperties.Oauth2Properties.UserInfoRequestProperties.ResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderCreateParamsProperties.Oauth2Properties.AuthorizeRequestProperties.RequestContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderCreateParamsProperties.Oauth2Properties.AuthorizeRequestProperties.ResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderCreateParamsProperties.Oauth2Properties.RefreshRequestProperties.RequestContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderCreateParamsProperties.Oauth2Properties.RefreshRequestProperties.ResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderCreateParamsProperties.Oauth2Properties.ScopeDelimiter
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderCreateParamsProperties.Oauth2Properties.TokenIntrospectionRequestProperties.RequestContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderCreateParamsProperties.Oauth2Properties.TokenIntrospectionRequestProperties.ResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderCreateParamsProperties.Oauth2Properties.TokenRequestProperties.RequestContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderCreateParamsProperties.Oauth2Properties.TokenRequestProperties.ResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderCreateParamsProperties.Oauth2Properties.UserInfoRequestProperties.RequestContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderCreateParamsProperties.Oauth2Properties.UserInfoRequestProperties.ResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderPatchParamsProperties.Oauth2Properties.AuthorizeRequestProperties.RequestContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderPatchParamsProperties.Oauth2Properties.AuthorizeRequestProperties.ResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderPatchParamsProperties.Oauth2Properties.RefreshRequestProperties.RequestContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderPatchParamsProperties.Oauth2Properties.RefreshRequestProperties.ResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderPatchParamsProperties.Oauth2Properties.ScopeDelimiter
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderPatchParamsProperties.Oauth2Properties.TokenRequestProperties.RequestContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderPatchParamsProperties.Oauth2Properties.TokenRequestProperties.ResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderPatchParamsProperties.Oauth2Properties.UserInfoRequestProperties.RequestContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderPatchParamsProperties.Oauth2Properties.UserInfoRequestProperties.ResponseContentType
            >(),
            new ApiEnumConverter<string, BindingProperties::Type>(),
            new ApiEnumConverter<string, ToolCallProperties::Type>(),
            new ApiEnumConverter<string, ResponseFormatProperties::Type>(),
            new ApiEnumConverter<
                string,
                global::ArcadeDotnet.Models.Chat.Completions.CompletionCreateParamsProperties.ResponseFormatProperties.Type
            >(),
            new ApiEnumConverter<string, Kind>(),
            new ApiEnumConverter<string, AuthorizationProperties::Status>(),
            new ApiEnumConverter<string, AuthorizationProperties::TokenStatus>(),
            new ApiEnumConverter<string, ErrorProperties::Kind>(),
            new ApiEnumConverter<string, IncludeFormat>(),
            new ApiEnumConverter<string, ToolGetParamsProperties::IncludeFormat>(),
            new ApiEnumConverter<
                string,
                global::ArcadeDotnet.Models.Workers.WorkerResponseProperties.BindingProperties.Type
            >(),
            new ApiEnumConverter<string, SecretProperties::Binding>(),
            new ApiEnumConverter<string, ClientSecretProperties::Binding>(),
            new ApiEnumConverter<string, SecretsItemProperties::Binding>(),
            new ApiEnumConverter<string, WorkerResponseProperties::Type>(),
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
    static abstract T FromRawUnchecked(Dictionary<string, JsonElement> properties);
}
