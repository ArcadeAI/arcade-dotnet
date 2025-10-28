using System.Collections.Generic;
using System.Text.Json;
using ArcadeEngine.Models.Admin.AuthProviders.AuthProviderCreateRequestProperties.Oauth2Properties;
using ArcadeEngine.Models.Admin.AuthProviders.AuthProviderCreateRequestProperties.Oauth2Properties.AuthorizeRequestProperties;
using ArcadeEngine.Models.Admin.AuthProviders.AuthProviderResponseProperties.BindingProperties;
using ArcadeEngine.Models.Admin.AuthProviders.AuthProviderResponseProperties.Oauth2Properties.ClientSecretProperties;
using ArcadeEngine.Models.AuthorizationResponseProperties;
using ArcadeEngine.Models.Tools.ExecuteToolResponseProperties.OutputProperties.ErrorProperties;
using ArcadeEngine.Models.Tools.ToolListParamsProperties;
using AuthorizationProperties = ArcadeEngine.Models.Tools.ToolDefinitionProperties.RequirementsProperties.AuthorizationProperties;
using AuthorizeRequestProperties = ArcadeEngine.Models.Admin.AuthProviders.AuthProviderUpdateRequestProperties.Oauth2Properties.AuthorizeRequestProperties;
using BindingProperties = ArcadeEngine.Models.Admin.Secrets.SecretResponseProperties.BindingProperties;
using ClientSecretProperties = ArcadeEngine.Models.Workers.WorkerResponseProperties.McpProperties.Oauth2Properties.ClientSecretProperties;
using ErrorProperties = ArcadeEngine.Models.Tools.ToolExecutionAttemptProperties.OutputProperties.ErrorProperties;
using Oauth2Properties = ArcadeEngine.Models.Admin.AuthProviders.AuthProviderUpdateRequestProperties.Oauth2Properties;
using RefreshRequestProperties = ArcadeEngine.Models.Admin.AuthProviders.AuthProviderCreateRequestProperties.Oauth2Properties.RefreshRequestProperties;
using ResponseFormatProperties = ArcadeEngine.Models.Chat.ChatRequestProperties.ResponseFormatProperties;
using SecretProperties = ArcadeEngine.Models.Workers.WorkerResponseProperties.HTTPProperties.SecretProperties;
using SecretsItemProperties = ArcadeEngine.Models.Workers.WorkerResponseProperties.McpProperties.SecretsProperties.SecretsItemProperties;
using TokenIntrospectionRequestProperties = ArcadeEngine.Models.Admin.AuthProviders.AuthProviderCreateRequestProperties.Oauth2Properties.TokenIntrospectionRequestProperties;
using TokenRequestProperties = ArcadeEngine.Models.Admin.AuthProviders.AuthProviderCreateRequestProperties.Oauth2Properties.TokenRequestProperties;
using ToolCallProperties = ArcadeEngine.Models.Chat.ChatMessageProperties.ToolCallProperties;
using ToolGetParamsProperties = ArcadeEngine.Models.Tools.ToolGetParamsProperties;
using UserInfoRequestProperties = ArcadeEngine.Models.Admin.AuthProviders.AuthProviderCreateRequestProperties.Oauth2Properties.UserInfoRequestProperties;
using WorkerResponseProperties = ArcadeEngine.Models.Workers.WorkerResponseProperties;

namespace ArcadeEngine.Core;

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
                global::ArcadeEngine.Models.Admin.AuthProviders.AuthProviderUpdateRequestProperties.Oauth2Properties.RefreshRequestProperties.RequestContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeEngine.Models.Admin.AuthProviders.AuthProviderUpdateRequestProperties.Oauth2Properties.RefreshRequestProperties.ResponseContentType
            >(),
            new ApiEnumConverter<string, Oauth2Properties::ScopeDelimiter>(),
            new ApiEnumConverter<
                string,
                global::ArcadeEngine.Models.Admin.AuthProviders.AuthProviderUpdateRequestProperties.Oauth2Properties.TokenRequestProperties.RequestContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeEngine.Models.Admin.AuthProviders.AuthProviderUpdateRequestProperties.Oauth2Properties.TokenRequestProperties.ResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeEngine.Models.Admin.AuthProviders.AuthProviderUpdateRequestProperties.Oauth2Properties.UserInfoRequestProperties.RequestContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeEngine.Models.Admin.AuthProviders.AuthProviderUpdateRequestProperties.Oauth2Properties.UserInfoRequestProperties.ResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeEngine.Models.Admin.AuthProviders.AuthProviderCreateParamsProperties.Oauth2Properties.AuthorizeRequestProperties.RequestContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeEngine.Models.Admin.AuthProviders.AuthProviderCreateParamsProperties.Oauth2Properties.AuthorizeRequestProperties.ResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeEngine.Models.Admin.AuthProviders.AuthProviderCreateParamsProperties.Oauth2Properties.RefreshRequestProperties.RequestContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeEngine.Models.Admin.AuthProviders.AuthProviderCreateParamsProperties.Oauth2Properties.RefreshRequestProperties.ResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeEngine.Models.Admin.AuthProviders.AuthProviderCreateParamsProperties.Oauth2Properties.ScopeDelimiter
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeEngine.Models.Admin.AuthProviders.AuthProviderCreateParamsProperties.Oauth2Properties.TokenIntrospectionRequestProperties.RequestContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeEngine.Models.Admin.AuthProviders.AuthProviderCreateParamsProperties.Oauth2Properties.TokenIntrospectionRequestProperties.ResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeEngine.Models.Admin.AuthProviders.AuthProviderCreateParamsProperties.Oauth2Properties.TokenRequestProperties.RequestContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeEngine.Models.Admin.AuthProviders.AuthProviderCreateParamsProperties.Oauth2Properties.TokenRequestProperties.ResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeEngine.Models.Admin.AuthProviders.AuthProviderCreateParamsProperties.Oauth2Properties.UserInfoRequestProperties.RequestContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeEngine.Models.Admin.AuthProviders.AuthProviderCreateParamsProperties.Oauth2Properties.UserInfoRequestProperties.ResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeEngine.Models.Admin.AuthProviders.AuthProviderPatchParamsProperties.Oauth2Properties.AuthorizeRequestProperties.RequestContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeEngine.Models.Admin.AuthProviders.AuthProviderPatchParamsProperties.Oauth2Properties.AuthorizeRequestProperties.ResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeEngine.Models.Admin.AuthProviders.AuthProviderPatchParamsProperties.Oauth2Properties.RefreshRequestProperties.RequestContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeEngine.Models.Admin.AuthProviders.AuthProviderPatchParamsProperties.Oauth2Properties.RefreshRequestProperties.ResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeEngine.Models.Admin.AuthProviders.AuthProviderPatchParamsProperties.Oauth2Properties.ScopeDelimiter
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeEngine.Models.Admin.AuthProviders.AuthProviderPatchParamsProperties.Oauth2Properties.TokenRequestProperties.RequestContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeEngine.Models.Admin.AuthProviders.AuthProviderPatchParamsProperties.Oauth2Properties.TokenRequestProperties.ResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeEngine.Models.Admin.AuthProviders.AuthProviderPatchParamsProperties.Oauth2Properties.UserInfoRequestProperties.RequestContentType
            >(),
            new ApiEnumConverter<
                string,
                global::ArcadeEngine.Models.Admin.AuthProviders.AuthProviderPatchParamsProperties.Oauth2Properties.UserInfoRequestProperties.ResponseContentType
            >(),
            new ApiEnumConverter<string, BindingProperties::Type>(),
            new ApiEnumConverter<string, ToolCallProperties::Type>(),
            new ApiEnumConverter<string, ResponseFormatProperties::Type>(),
            new ApiEnumConverter<
                string,
                global::ArcadeEngine.Models.Chat.Completions.CompletionCreateParamsProperties.ResponseFormatProperties.Type
            >(),
            new ApiEnumConverter<string, Kind>(),
            new ApiEnumConverter<string, AuthorizationProperties::Status>(),
            new ApiEnumConverter<string, AuthorizationProperties::TokenStatus>(),
            new ApiEnumConverter<string, ErrorProperties::Kind>(),
            new ApiEnumConverter<string, IncludeFormat>(),
            new ApiEnumConverter<string, ToolGetParamsProperties::IncludeFormat>(),
            new ApiEnumConverter<
                string,
                global::ArcadeEngine.Models.Workers.WorkerResponseProperties.BindingProperties.Type
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
