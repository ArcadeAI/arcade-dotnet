using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using ArcadeDotnet.Models.Admin.AuthProviders;

namespace ArcadeDotnet.Tests.Models.Admin.AuthProviders;

public class AuthProviderCreateRequestTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthProviderCreateRequest
        {
            ID = "id",
            Description = "description",
            ExternalID = "external_id",
            Oauth2 = new()
            {
                ClientID = "client_id",
                AuthorizeRequest = new()
                {
                    Endpoint = "endpoint",
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
                ClientSecret = "client_secret",
                Pkce = new() { CodeChallengeMethod = "code_challenge_method", Enabled = true },
                RefreshRequest = new()
                {
                    Endpoint = "endpoint",
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderCreateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderCreateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
                ScopeDelimiter = AuthProviderCreateRequestOauth2ScopeDelimiter.Undefined,
                TokenIntrospectionRequest = new()
                {
                    Endpoint = "endpoint",
                    Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
                TokenRequest = new()
                {
                    Endpoint = "endpoint",
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderCreateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderCreateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
                UserInfoRequest = new()
                {
                    Endpoint = "endpoint",
                    Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
            },
            ProviderID = "provider_id",
            Status = "status",
            Type = "type",
        };

        string expectedID = "id";
        string expectedDescription = "description";
        string expectedExternalID = "external_id";
        AuthProviderCreateRequestOauth2 expectedOauth2 = new()
        {
            ClientID = "client_id",
            AuthorizeRequest = new()
            {
                Endpoint = "endpoint",
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ClientSecret = "client_secret",
            Pkce = new() { CodeChallengeMethod = "code_challenge_method", Enabled = true },
            RefreshRequest = new()
            {
                Endpoint = "endpoint",
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderCreateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderCreateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ScopeDelimiter = AuthProviderCreateRequestOauth2ScopeDelimiter.Undefined,
            TokenIntrospectionRequest = new()
            {
                Endpoint = "endpoint",
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            TokenRequest = new()
            {
                Endpoint = "endpoint",
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderCreateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderCreateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            UserInfoRequest = new()
            {
                Endpoint = "endpoint",
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
        };
        string expectedProviderID = "provider_id";
        string expectedStatus = "status";
        string expectedType = "type";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedExternalID, model.ExternalID);
        Assert.Equal(expectedOauth2, model.Oauth2);
        Assert.Equal(expectedProviderID, model.ProviderID);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedType, model.Type);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AuthProviderCreateRequest
        {
            ID = "id",
            Description = "description",
            ExternalID = "external_id",
            Oauth2 = new()
            {
                ClientID = "client_id",
                AuthorizeRequest = new()
                {
                    Endpoint = "endpoint",
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
                ClientSecret = "client_secret",
                Pkce = new() { CodeChallengeMethod = "code_challenge_method", Enabled = true },
                RefreshRequest = new()
                {
                    Endpoint = "endpoint",
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderCreateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderCreateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
                ScopeDelimiter = AuthProviderCreateRequestOauth2ScopeDelimiter.Undefined,
                TokenIntrospectionRequest = new()
                {
                    Endpoint = "endpoint",
                    Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
                TokenRequest = new()
                {
                    Endpoint = "endpoint",
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderCreateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderCreateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
                UserInfoRequest = new()
                {
                    Endpoint = "endpoint",
                    Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
            },
            ProviderID = "provider_id",
            Status = "status",
            Type = "type",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthProviderCreateRequest>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AuthProviderCreateRequest
        {
            ID = "id",
            Description = "description",
            ExternalID = "external_id",
            Oauth2 = new()
            {
                ClientID = "client_id",
                AuthorizeRequest = new()
                {
                    Endpoint = "endpoint",
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
                ClientSecret = "client_secret",
                Pkce = new() { CodeChallengeMethod = "code_challenge_method", Enabled = true },
                RefreshRequest = new()
                {
                    Endpoint = "endpoint",
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderCreateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderCreateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
                ScopeDelimiter = AuthProviderCreateRequestOauth2ScopeDelimiter.Undefined,
                TokenIntrospectionRequest = new()
                {
                    Endpoint = "endpoint",
                    Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
                TokenRequest = new()
                {
                    Endpoint = "endpoint",
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderCreateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderCreateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
                UserInfoRequest = new()
                {
                    Endpoint = "endpoint",
                    Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
            },
            ProviderID = "provider_id",
            Status = "status",
            Type = "type",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthProviderCreateRequest>(element);
        Assert.NotNull(deserialized);

        string expectedID = "id";
        string expectedDescription = "description";
        string expectedExternalID = "external_id";
        AuthProviderCreateRequestOauth2 expectedOauth2 = new()
        {
            ClientID = "client_id",
            AuthorizeRequest = new()
            {
                Endpoint = "endpoint",
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ClientSecret = "client_secret",
            Pkce = new() { CodeChallengeMethod = "code_challenge_method", Enabled = true },
            RefreshRequest = new()
            {
                Endpoint = "endpoint",
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderCreateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderCreateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ScopeDelimiter = AuthProviderCreateRequestOauth2ScopeDelimiter.Undefined,
            TokenIntrospectionRequest = new()
            {
                Endpoint = "endpoint",
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            TokenRequest = new()
            {
                Endpoint = "endpoint",
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderCreateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderCreateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            UserInfoRequest = new()
            {
                Endpoint = "endpoint",
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
        };
        string expectedProviderID = "provider_id";
        string expectedStatus = "status";
        string expectedType = "type";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedExternalID, deserialized.ExternalID);
        Assert.Equal(expectedOauth2, deserialized.Oauth2);
        Assert.Equal(expectedProviderID, deserialized.ProviderID);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedType, deserialized.Type);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AuthProviderCreateRequest
        {
            ID = "id",
            Description = "description",
            ExternalID = "external_id",
            Oauth2 = new()
            {
                ClientID = "client_id",
                AuthorizeRequest = new()
                {
                    Endpoint = "endpoint",
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
                ClientSecret = "client_secret",
                Pkce = new() { CodeChallengeMethod = "code_challenge_method", Enabled = true },
                RefreshRequest = new()
                {
                    Endpoint = "endpoint",
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderCreateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderCreateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
                ScopeDelimiter = AuthProviderCreateRequestOauth2ScopeDelimiter.Undefined,
                TokenIntrospectionRequest = new()
                {
                    Endpoint = "endpoint",
                    Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
                TokenRequest = new()
                {
                    Endpoint = "endpoint",
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderCreateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderCreateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
                UserInfoRequest = new()
                {
                    Endpoint = "endpoint",
                    Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
            },
            ProviderID = "provider_id",
            Status = "status",
            Type = "type",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthProviderCreateRequest { ID = "id" };

        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.ExternalID);
        Assert.False(model.RawData.ContainsKey("external_id"));
        Assert.Null(model.Oauth2);
        Assert.False(model.RawData.ContainsKey("oauth2"));
        Assert.Null(model.ProviderID);
        Assert.False(model.RawData.ContainsKey("provider_id"));
        Assert.Null(model.Status);
        Assert.False(model.RawData.ContainsKey("status"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AuthProviderCreateRequest { ID = "id" };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthProviderCreateRequest
        {
            ID = "id",

            // Null should be interpreted as omitted for these properties
            Description = null,
            ExternalID = null,
            Oauth2 = null,
            ProviderID = null,
            Status = null,
            Type = null,
        };

        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.ExternalID);
        Assert.False(model.RawData.ContainsKey("external_id"));
        Assert.Null(model.Oauth2);
        Assert.False(model.RawData.ContainsKey("oauth2"));
        Assert.Null(model.ProviderID);
        Assert.False(model.RawData.ContainsKey("provider_id"));
        Assert.Null(model.Status);
        Assert.False(model.RawData.ContainsKey("status"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new AuthProviderCreateRequest
        {
            ID = "id",

            // Null should be interpreted as omitted for these properties
            Description = null,
            ExternalID = null,
            Oauth2 = null,
            ProviderID = null,
            Status = null,
            Type = null,
        };

        model.Validate();
    }
}

public class AuthProviderCreateRequestOauth2Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthProviderCreateRequestOauth2
        {
            ClientID = "client_id",
            AuthorizeRequest = new()
            {
                Endpoint = "endpoint",
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ClientSecret = "client_secret",
            Pkce = new() { CodeChallengeMethod = "code_challenge_method", Enabled = true },
            RefreshRequest = new()
            {
                Endpoint = "endpoint",
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderCreateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderCreateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ScopeDelimiter = AuthProviderCreateRequestOauth2ScopeDelimiter.Undefined,
            TokenIntrospectionRequest = new()
            {
                Endpoint = "endpoint",
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            TokenRequest = new()
            {
                Endpoint = "endpoint",
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderCreateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderCreateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            UserInfoRequest = new()
            {
                Endpoint = "endpoint",
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
        };

        string expectedClientID = "client_id";
        AuthProviderCreateRequestOauth2AuthorizeRequest expectedAuthorizeRequest = new()
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };
        string expectedClientSecret = "client_secret";
        AuthProviderCreateRequestOauth2Pkce expectedPkce = new()
        {
            CodeChallengeMethod = "code_challenge_method",
            Enabled = true,
        };
        AuthProviderCreateRequestOauth2RefreshRequest expectedRefreshRequest = new()
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderCreateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderCreateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };
        ApiEnum<string, AuthProviderCreateRequestOauth2ScopeDelimiter> expectedScopeDelimiter =
            AuthProviderCreateRequestOauth2ScopeDelimiter.Undefined;
        AuthProviderCreateRequestOauth2TokenIntrospectionRequest expectedTokenIntrospectionRequest =
            new()
            {
                Endpoint = "endpoint",
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            };
        AuthProviderCreateRequestOauth2TokenRequest expectedTokenRequest = new()
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderCreateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderCreateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };
        AuthProviderCreateRequestOauth2UserInfoRequest expectedUserInfoRequest = new()
        {
            Endpoint = "endpoint",
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        Assert.Equal(expectedClientID, model.ClientID);
        Assert.Equal(expectedAuthorizeRequest, model.AuthorizeRequest);
        Assert.Equal(expectedClientSecret, model.ClientSecret);
        Assert.Equal(expectedPkce, model.Pkce);
        Assert.Equal(expectedRefreshRequest, model.RefreshRequest);
        Assert.Equal(expectedScopeDelimiter, model.ScopeDelimiter);
        Assert.Equal(expectedTokenIntrospectionRequest, model.TokenIntrospectionRequest);
        Assert.Equal(expectedTokenRequest, model.TokenRequest);
        Assert.Equal(expectedUserInfoRequest, model.UserInfoRequest);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AuthProviderCreateRequestOauth2
        {
            ClientID = "client_id",
            AuthorizeRequest = new()
            {
                Endpoint = "endpoint",
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ClientSecret = "client_secret",
            Pkce = new() { CodeChallengeMethod = "code_challenge_method", Enabled = true },
            RefreshRequest = new()
            {
                Endpoint = "endpoint",
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderCreateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderCreateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ScopeDelimiter = AuthProviderCreateRequestOauth2ScopeDelimiter.Undefined,
            TokenIntrospectionRequest = new()
            {
                Endpoint = "endpoint",
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            TokenRequest = new()
            {
                Endpoint = "endpoint",
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderCreateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderCreateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            UserInfoRequest = new()
            {
                Endpoint = "endpoint",
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthProviderCreateRequestOauth2>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AuthProviderCreateRequestOauth2
        {
            ClientID = "client_id",
            AuthorizeRequest = new()
            {
                Endpoint = "endpoint",
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ClientSecret = "client_secret",
            Pkce = new() { CodeChallengeMethod = "code_challenge_method", Enabled = true },
            RefreshRequest = new()
            {
                Endpoint = "endpoint",
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderCreateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderCreateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ScopeDelimiter = AuthProviderCreateRequestOauth2ScopeDelimiter.Undefined,
            TokenIntrospectionRequest = new()
            {
                Endpoint = "endpoint",
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            TokenRequest = new()
            {
                Endpoint = "endpoint",
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderCreateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderCreateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            UserInfoRequest = new()
            {
                Endpoint = "endpoint",
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthProviderCreateRequestOauth2>(element);
        Assert.NotNull(deserialized);

        string expectedClientID = "client_id";
        AuthProviderCreateRequestOauth2AuthorizeRequest expectedAuthorizeRequest = new()
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };
        string expectedClientSecret = "client_secret";
        AuthProviderCreateRequestOauth2Pkce expectedPkce = new()
        {
            CodeChallengeMethod = "code_challenge_method",
            Enabled = true,
        };
        AuthProviderCreateRequestOauth2RefreshRequest expectedRefreshRequest = new()
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderCreateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderCreateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };
        ApiEnum<string, AuthProviderCreateRequestOauth2ScopeDelimiter> expectedScopeDelimiter =
            AuthProviderCreateRequestOauth2ScopeDelimiter.Undefined;
        AuthProviderCreateRequestOauth2TokenIntrospectionRequest expectedTokenIntrospectionRequest =
            new()
            {
                Endpoint = "endpoint",
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            };
        AuthProviderCreateRequestOauth2TokenRequest expectedTokenRequest = new()
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderCreateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderCreateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };
        AuthProviderCreateRequestOauth2UserInfoRequest expectedUserInfoRequest = new()
        {
            Endpoint = "endpoint",
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        Assert.Equal(expectedClientID, deserialized.ClientID);
        Assert.Equal(expectedAuthorizeRequest, deserialized.AuthorizeRequest);
        Assert.Equal(expectedClientSecret, deserialized.ClientSecret);
        Assert.Equal(expectedPkce, deserialized.Pkce);
        Assert.Equal(expectedRefreshRequest, deserialized.RefreshRequest);
        Assert.Equal(expectedScopeDelimiter, deserialized.ScopeDelimiter);
        Assert.Equal(expectedTokenIntrospectionRequest, deserialized.TokenIntrospectionRequest);
        Assert.Equal(expectedTokenRequest, deserialized.TokenRequest);
        Assert.Equal(expectedUserInfoRequest, deserialized.UserInfoRequest);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AuthProviderCreateRequestOauth2
        {
            ClientID = "client_id",
            AuthorizeRequest = new()
            {
                Endpoint = "endpoint",
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ClientSecret = "client_secret",
            Pkce = new() { CodeChallengeMethod = "code_challenge_method", Enabled = true },
            RefreshRequest = new()
            {
                Endpoint = "endpoint",
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderCreateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderCreateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ScopeDelimiter = AuthProviderCreateRequestOauth2ScopeDelimiter.Undefined,
            TokenIntrospectionRequest = new()
            {
                Endpoint = "endpoint",
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            TokenRequest = new()
            {
                Endpoint = "endpoint",
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderCreateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderCreateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            UserInfoRequest = new()
            {
                Endpoint = "endpoint",
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthProviderCreateRequestOauth2 { ClientID = "client_id" };

        Assert.Null(model.AuthorizeRequest);
        Assert.False(model.RawData.ContainsKey("authorize_request"));
        Assert.Null(model.ClientSecret);
        Assert.False(model.RawData.ContainsKey("client_secret"));
        Assert.Null(model.Pkce);
        Assert.False(model.RawData.ContainsKey("pkce"));
        Assert.Null(model.RefreshRequest);
        Assert.False(model.RawData.ContainsKey("refresh_request"));
        Assert.Null(model.ScopeDelimiter);
        Assert.False(model.RawData.ContainsKey("scope_delimiter"));
        Assert.Null(model.TokenIntrospectionRequest);
        Assert.False(model.RawData.ContainsKey("token_introspection_request"));
        Assert.Null(model.TokenRequest);
        Assert.False(model.RawData.ContainsKey("token_request"));
        Assert.Null(model.UserInfoRequest);
        Assert.False(model.RawData.ContainsKey("user_info_request"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AuthProviderCreateRequestOauth2 { ClientID = "client_id" };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthProviderCreateRequestOauth2
        {
            ClientID = "client_id",

            // Null should be interpreted as omitted for these properties
            AuthorizeRequest = null,
            ClientSecret = null,
            Pkce = null,
            RefreshRequest = null,
            ScopeDelimiter = null,
            TokenIntrospectionRequest = null,
            TokenRequest = null,
            UserInfoRequest = null,
        };

        Assert.Null(model.AuthorizeRequest);
        Assert.False(model.RawData.ContainsKey("authorize_request"));
        Assert.Null(model.ClientSecret);
        Assert.False(model.RawData.ContainsKey("client_secret"));
        Assert.Null(model.Pkce);
        Assert.False(model.RawData.ContainsKey("pkce"));
        Assert.Null(model.RefreshRequest);
        Assert.False(model.RawData.ContainsKey("refresh_request"));
        Assert.Null(model.ScopeDelimiter);
        Assert.False(model.RawData.ContainsKey("scope_delimiter"));
        Assert.Null(model.TokenIntrospectionRequest);
        Assert.False(model.RawData.ContainsKey("token_introspection_request"));
        Assert.Null(model.TokenRequest);
        Assert.False(model.RawData.ContainsKey("token_request"));
        Assert.Null(model.UserInfoRequest);
        Assert.False(model.RawData.ContainsKey("user_info_request"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new AuthProviderCreateRequestOauth2
        {
            ClientID = "client_id",

            // Null should be interpreted as omitted for these properties
            AuthorizeRequest = null,
            ClientSecret = null,
            Pkce = null,
            RefreshRequest = null,
            ScopeDelimiter = null,
            TokenIntrospectionRequest = null,
            TokenRequest = null,
            UserInfoRequest = null,
        };

        model.Validate();
    }
}

public class AuthProviderCreateRequestOauth2AuthorizeRequestTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthProviderCreateRequestOauth2AuthorizeRequest
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string expectedEndpoint = "endpoint";
        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<
            string,
            AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType
        > expectedRequestContentType =
            AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<
            string,
            AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType
        > expectedResponseContentType =
            AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded;
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedEndpoint, model.Endpoint);
        Assert.Equal(expectedAuthHeaderValueFormat, model.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, model.AuthMethod);
        Assert.Equal(expectedMethod, model.Method);
        Assert.Equal(expectedParams.Count, model.Params.Count);
        foreach (var item in expectedParams)
        {
            Assert.True(model.Params.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.Params[item.Key]);
        }
        Assert.Equal(expectedRequestContentType, model.RequestContentType);
        Assert.Equal(expectedResponseContentType, model.ResponseContentType);
        Assert.Equal(expectedResponseMap.Count, model.ResponseMap.Count);
        foreach (var item in expectedResponseMap)
        {
            Assert.True(model.ResponseMap.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.ResponseMap[item.Key]);
        }
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AuthProviderCreateRequestOauth2AuthorizeRequest
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<AuthProviderCreateRequestOauth2AuthorizeRequest>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AuthProviderCreateRequestOauth2AuthorizeRequest
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<AuthProviderCreateRequestOauth2AuthorizeRequest>(element);
        Assert.NotNull(deserialized);

        string expectedEndpoint = "endpoint";
        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<
            string,
            AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType
        > expectedRequestContentType =
            AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<
            string,
            AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType
        > expectedResponseContentType =
            AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded;
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedEndpoint, deserialized.Endpoint);
        Assert.Equal(expectedAuthHeaderValueFormat, deserialized.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, deserialized.AuthMethod);
        Assert.Equal(expectedMethod, deserialized.Method);
        Assert.Equal(expectedParams.Count, deserialized.Params.Count);
        foreach (var item in expectedParams)
        {
            Assert.True(deserialized.Params.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.Params[item.Key]);
        }
        Assert.Equal(expectedRequestContentType, deserialized.RequestContentType);
        Assert.Equal(expectedResponseContentType, deserialized.ResponseContentType);
        Assert.Equal(expectedResponseMap.Count, deserialized.ResponseMap.Count);
        foreach (var item in expectedResponseMap)
        {
            Assert.True(deserialized.ResponseMap.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.ResponseMap[item.Key]);
        }
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AuthProviderCreateRequestOauth2AuthorizeRequest
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthProviderCreateRequestOauth2AuthorizeRequest { Endpoint = "endpoint" };

        Assert.Null(model.AuthHeaderValueFormat);
        Assert.False(model.RawData.ContainsKey("auth_header_value_format"));
        Assert.Null(model.AuthMethod);
        Assert.False(model.RawData.ContainsKey("auth_method"));
        Assert.Null(model.Method);
        Assert.False(model.RawData.ContainsKey("method"));
        Assert.Null(model.Params);
        Assert.False(model.RawData.ContainsKey("params"));
        Assert.Null(model.RequestContentType);
        Assert.False(model.RawData.ContainsKey("request_content_type"));
        Assert.Null(model.ResponseContentType);
        Assert.False(model.RawData.ContainsKey("response_content_type"));
        Assert.Null(model.ResponseMap);
        Assert.False(model.RawData.ContainsKey("response_map"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AuthProviderCreateRequestOauth2AuthorizeRequest { Endpoint = "endpoint" };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthProviderCreateRequestOauth2AuthorizeRequest
        {
            Endpoint = "endpoint",

            // Null should be interpreted as omitted for these properties
            AuthHeaderValueFormat = null,
            AuthMethod = null,
            Method = null,
            Params = null,
            RequestContentType = null,
            ResponseContentType = null,
            ResponseMap = null,
        };

        Assert.Null(model.AuthHeaderValueFormat);
        Assert.False(model.RawData.ContainsKey("auth_header_value_format"));
        Assert.Null(model.AuthMethod);
        Assert.False(model.RawData.ContainsKey("auth_method"));
        Assert.Null(model.Method);
        Assert.False(model.RawData.ContainsKey("method"));
        Assert.Null(model.Params);
        Assert.False(model.RawData.ContainsKey("params"));
        Assert.Null(model.RequestContentType);
        Assert.False(model.RawData.ContainsKey("request_content_type"));
        Assert.Null(model.ResponseContentType);
        Assert.False(model.RawData.ContainsKey("response_content_type"));
        Assert.Null(model.ResponseMap);
        Assert.False(model.RawData.ContainsKey("response_map"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new AuthProviderCreateRequestOauth2AuthorizeRequest
        {
            Endpoint = "endpoint",

            // Null should be interpreted as omitted for these properties
            AuthHeaderValueFormat = null,
            AuthMethod = null,
            Method = null,
            Params = null,
            RequestContentType = null,
            ResponseContentType = null,
            ResponseMap = null,
        };

        model.Validate();
    }
}

public class AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentTypeTest : TestBase
{
    [Theory]
    [InlineData(
        AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType.ApplicationJson)]
    public void Validation_Works(
        AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType> value =
            rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType>
        >(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(
        AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType.ApplicationJson)]
    public void SerializationRoundtrip_Works(
        AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType> value =
            rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType>
        >(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentTypeTest : TestBase
{
    [Theory]
    [InlineData(
        AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType.ApplicationJson)]
    public void Validation_Works(
        AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType> value =
            rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType>
        >(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(
        AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType.ApplicationJson)]
    public void SerializationRoundtrip_Works(
        AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType> value =
            rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType>
        >(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class AuthProviderCreateRequestOauth2PkceTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthProviderCreateRequestOauth2Pkce
        {
            CodeChallengeMethod = "code_challenge_method",
            Enabled = true,
        };

        string expectedCodeChallengeMethod = "code_challenge_method";
        bool expectedEnabled = true;

        Assert.Equal(expectedCodeChallengeMethod, model.CodeChallengeMethod);
        Assert.Equal(expectedEnabled, model.Enabled);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AuthProviderCreateRequestOauth2Pkce
        {
            CodeChallengeMethod = "code_challenge_method",
            Enabled = true,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthProviderCreateRequestOauth2Pkce>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AuthProviderCreateRequestOauth2Pkce
        {
            CodeChallengeMethod = "code_challenge_method",
            Enabled = true,
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthProviderCreateRequestOauth2Pkce>(element);
        Assert.NotNull(deserialized);

        string expectedCodeChallengeMethod = "code_challenge_method";
        bool expectedEnabled = true;

        Assert.Equal(expectedCodeChallengeMethod, deserialized.CodeChallengeMethod);
        Assert.Equal(expectedEnabled, deserialized.Enabled);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AuthProviderCreateRequestOauth2Pkce
        {
            CodeChallengeMethod = "code_challenge_method",
            Enabled = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthProviderCreateRequestOauth2Pkce { };

        Assert.Null(model.CodeChallengeMethod);
        Assert.False(model.RawData.ContainsKey("code_challenge_method"));
        Assert.Null(model.Enabled);
        Assert.False(model.RawData.ContainsKey("enabled"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AuthProviderCreateRequestOauth2Pkce { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthProviderCreateRequestOauth2Pkce
        {
            // Null should be interpreted as omitted for these properties
            CodeChallengeMethod = null,
            Enabled = null,
        };

        Assert.Null(model.CodeChallengeMethod);
        Assert.False(model.RawData.ContainsKey("code_challenge_method"));
        Assert.Null(model.Enabled);
        Assert.False(model.RawData.ContainsKey("enabled"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new AuthProviderCreateRequestOauth2Pkce
        {
            // Null should be interpreted as omitted for these properties
            CodeChallengeMethod = null,
            Enabled = null,
        };

        model.Validate();
    }
}

public class AuthProviderCreateRequestOauth2RefreshRequestTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthProviderCreateRequestOauth2RefreshRequest
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderCreateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderCreateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string expectedEndpoint = "endpoint";
        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<
            string,
            AuthProviderCreateRequestOauth2RefreshRequestRequestContentType
        > expectedRequestContentType =
            AuthProviderCreateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<
            string,
            AuthProviderCreateRequestOauth2RefreshRequestResponseContentType
        > expectedResponseContentType =
            AuthProviderCreateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded;
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedEndpoint, model.Endpoint);
        Assert.Equal(expectedAuthHeaderValueFormat, model.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, model.AuthMethod);
        Assert.Equal(expectedMethod, model.Method);
        Assert.Equal(expectedParams.Count, model.Params.Count);
        foreach (var item in expectedParams)
        {
            Assert.True(model.Params.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.Params[item.Key]);
        }
        Assert.Equal(expectedRequestContentType, model.RequestContentType);
        Assert.Equal(expectedResponseContentType, model.ResponseContentType);
        Assert.Equal(expectedResponseMap.Count, model.ResponseMap.Count);
        foreach (var item in expectedResponseMap)
        {
            Assert.True(model.ResponseMap.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.ResponseMap[item.Key]);
        }
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AuthProviderCreateRequestOauth2RefreshRequest
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderCreateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderCreateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<AuthProviderCreateRequestOauth2RefreshRequest>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AuthProviderCreateRequestOauth2RefreshRequest
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderCreateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderCreateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<AuthProviderCreateRequestOauth2RefreshRequest>(element);
        Assert.NotNull(deserialized);

        string expectedEndpoint = "endpoint";
        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<
            string,
            AuthProviderCreateRequestOauth2RefreshRequestRequestContentType
        > expectedRequestContentType =
            AuthProviderCreateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<
            string,
            AuthProviderCreateRequestOauth2RefreshRequestResponseContentType
        > expectedResponseContentType =
            AuthProviderCreateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded;
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedEndpoint, deserialized.Endpoint);
        Assert.Equal(expectedAuthHeaderValueFormat, deserialized.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, deserialized.AuthMethod);
        Assert.Equal(expectedMethod, deserialized.Method);
        Assert.Equal(expectedParams.Count, deserialized.Params.Count);
        foreach (var item in expectedParams)
        {
            Assert.True(deserialized.Params.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.Params[item.Key]);
        }
        Assert.Equal(expectedRequestContentType, deserialized.RequestContentType);
        Assert.Equal(expectedResponseContentType, deserialized.ResponseContentType);
        Assert.Equal(expectedResponseMap.Count, deserialized.ResponseMap.Count);
        foreach (var item in expectedResponseMap)
        {
            Assert.True(deserialized.ResponseMap.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.ResponseMap[item.Key]);
        }
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AuthProviderCreateRequestOauth2RefreshRequest
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderCreateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderCreateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthProviderCreateRequestOauth2RefreshRequest { Endpoint = "endpoint" };

        Assert.Null(model.AuthHeaderValueFormat);
        Assert.False(model.RawData.ContainsKey("auth_header_value_format"));
        Assert.Null(model.AuthMethod);
        Assert.False(model.RawData.ContainsKey("auth_method"));
        Assert.Null(model.Method);
        Assert.False(model.RawData.ContainsKey("method"));
        Assert.Null(model.Params);
        Assert.False(model.RawData.ContainsKey("params"));
        Assert.Null(model.RequestContentType);
        Assert.False(model.RawData.ContainsKey("request_content_type"));
        Assert.Null(model.ResponseContentType);
        Assert.False(model.RawData.ContainsKey("response_content_type"));
        Assert.Null(model.ResponseMap);
        Assert.False(model.RawData.ContainsKey("response_map"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AuthProviderCreateRequestOauth2RefreshRequest { Endpoint = "endpoint" };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthProviderCreateRequestOauth2RefreshRequest
        {
            Endpoint = "endpoint",

            // Null should be interpreted as omitted for these properties
            AuthHeaderValueFormat = null,
            AuthMethod = null,
            Method = null,
            Params = null,
            RequestContentType = null,
            ResponseContentType = null,
            ResponseMap = null,
        };

        Assert.Null(model.AuthHeaderValueFormat);
        Assert.False(model.RawData.ContainsKey("auth_header_value_format"));
        Assert.Null(model.AuthMethod);
        Assert.False(model.RawData.ContainsKey("auth_method"));
        Assert.Null(model.Method);
        Assert.False(model.RawData.ContainsKey("method"));
        Assert.Null(model.Params);
        Assert.False(model.RawData.ContainsKey("params"));
        Assert.Null(model.RequestContentType);
        Assert.False(model.RawData.ContainsKey("request_content_type"));
        Assert.Null(model.ResponseContentType);
        Assert.False(model.RawData.ContainsKey("response_content_type"));
        Assert.Null(model.ResponseMap);
        Assert.False(model.RawData.ContainsKey("response_map"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new AuthProviderCreateRequestOauth2RefreshRequest
        {
            Endpoint = "endpoint",

            // Null should be interpreted as omitted for these properties
            AuthHeaderValueFormat = null,
            AuthMethod = null,
            Method = null,
            Params = null,
            RequestContentType = null,
            ResponseContentType = null,
            ResponseMap = null,
        };

        model.Validate();
    }
}

public class AuthProviderCreateRequestOauth2RefreshRequestRequestContentTypeTest : TestBase
{
    [Theory]
    [InlineData(
        AuthProviderCreateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(AuthProviderCreateRequestOauth2RefreshRequestRequestContentType.ApplicationJson)]
    public void Validation_Works(
        AuthProviderCreateRequestOauth2RefreshRequestRequestContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderCreateRequestOauth2RefreshRequestRequestContentType> value =
            rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2RefreshRequestRequestContentType>
        >(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(
        AuthProviderCreateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(AuthProviderCreateRequestOauth2RefreshRequestRequestContentType.ApplicationJson)]
    public void SerializationRoundtrip_Works(
        AuthProviderCreateRequestOauth2RefreshRequestRequestContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderCreateRequestOauth2RefreshRequestRequestContentType> value =
            rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2RefreshRequestRequestContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2RefreshRequestRequestContentType>
        >(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2RefreshRequestRequestContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class AuthProviderCreateRequestOauth2RefreshRequestResponseContentTypeTest : TestBase
{
    [Theory]
    [InlineData(
        AuthProviderCreateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(AuthProviderCreateRequestOauth2RefreshRequestResponseContentType.ApplicationJson)]
    public void Validation_Works(
        AuthProviderCreateRequestOauth2RefreshRequestResponseContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderCreateRequestOauth2RefreshRequestResponseContentType> value =
            rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2RefreshRequestResponseContentType>
        >(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(
        AuthProviderCreateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(AuthProviderCreateRequestOauth2RefreshRequestResponseContentType.ApplicationJson)]
    public void SerializationRoundtrip_Works(
        AuthProviderCreateRequestOauth2RefreshRequestResponseContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderCreateRequestOauth2RefreshRequestResponseContentType> value =
            rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2RefreshRequestResponseContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2RefreshRequestResponseContentType>
        >(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2RefreshRequestResponseContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class AuthProviderCreateRequestOauth2ScopeDelimiterTest : TestBase
{
    [Theory]
    [InlineData(AuthProviderCreateRequestOauth2ScopeDelimiter.Undefined)]
    [InlineData(AuthProviderCreateRequestOauth2ScopeDelimiter.V1)]
    public void Validation_Works(AuthProviderCreateRequestOauth2ScopeDelimiter rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderCreateRequestOauth2ScopeDelimiter> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2ScopeDelimiter>
        >(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(AuthProviderCreateRequestOauth2ScopeDelimiter.Undefined)]
    [InlineData(AuthProviderCreateRequestOauth2ScopeDelimiter.V1)]
    public void SerializationRoundtrip_Works(AuthProviderCreateRequestOauth2ScopeDelimiter rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderCreateRequestOauth2ScopeDelimiter> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2ScopeDelimiter>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2ScopeDelimiter>
        >(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2ScopeDelimiter>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class AuthProviderCreateRequestOauth2TokenIntrospectionRequestTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthProviderCreateRequestOauth2TokenIntrospectionRequest
        {
            Endpoint = "endpoint",
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string expectedEndpoint = "endpoint";
        AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers expectedTriggers = new()
        {
            OnTokenGrant = true,
            OnTokenRefresh = true,
        };
        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<
            string,
            AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType
        > expectedRequestContentType =
            AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<
            string,
            AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType
        > expectedResponseContentType =
            AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded;
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedEndpoint, model.Endpoint);
        Assert.Equal(expectedTriggers, model.Triggers);
        Assert.Equal(expectedAuthHeaderValueFormat, model.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, model.AuthMethod);
        Assert.Equal(expectedMethod, model.Method);
        Assert.Equal(expectedParams.Count, model.Params.Count);
        foreach (var item in expectedParams)
        {
            Assert.True(model.Params.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.Params[item.Key]);
        }
        Assert.Equal(expectedRequestContentType, model.RequestContentType);
        Assert.Equal(expectedResponseContentType, model.ResponseContentType);
        Assert.Equal(expectedResponseMap.Count, model.ResponseMap.Count);
        foreach (var item in expectedResponseMap)
        {
            Assert.True(model.ResponseMap.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.ResponseMap[item.Key]);
        }
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AuthProviderCreateRequestOauth2TokenIntrospectionRequest
        {
            Endpoint = "endpoint",
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<AuthProviderCreateRequestOauth2TokenIntrospectionRequest>(
                json
            );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AuthProviderCreateRequestOauth2TokenIntrospectionRequest
        {
            Endpoint = "endpoint",
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<AuthProviderCreateRequestOauth2TokenIntrospectionRequest>(
                element
            );
        Assert.NotNull(deserialized);

        string expectedEndpoint = "endpoint";
        AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers expectedTriggers = new()
        {
            OnTokenGrant = true,
            OnTokenRefresh = true,
        };
        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<
            string,
            AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType
        > expectedRequestContentType =
            AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<
            string,
            AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType
        > expectedResponseContentType =
            AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded;
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedEndpoint, deserialized.Endpoint);
        Assert.Equal(expectedTriggers, deserialized.Triggers);
        Assert.Equal(expectedAuthHeaderValueFormat, deserialized.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, deserialized.AuthMethod);
        Assert.Equal(expectedMethod, deserialized.Method);
        Assert.Equal(expectedParams.Count, deserialized.Params.Count);
        foreach (var item in expectedParams)
        {
            Assert.True(deserialized.Params.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.Params[item.Key]);
        }
        Assert.Equal(expectedRequestContentType, deserialized.RequestContentType);
        Assert.Equal(expectedResponseContentType, deserialized.ResponseContentType);
        Assert.Equal(expectedResponseMap.Count, deserialized.ResponseMap.Count);
        foreach (var item in expectedResponseMap)
        {
            Assert.True(deserialized.ResponseMap.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.ResponseMap[item.Key]);
        }
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AuthProviderCreateRequestOauth2TokenIntrospectionRequest
        {
            Endpoint = "endpoint",
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthProviderCreateRequestOauth2TokenIntrospectionRequest
        {
            Endpoint = "endpoint",
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
        };

        Assert.Null(model.AuthHeaderValueFormat);
        Assert.False(model.RawData.ContainsKey("auth_header_value_format"));
        Assert.Null(model.AuthMethod);
        Assert.False(model.RawData.ContainsKey("auth_method"));
        Assert.Null(model.Method);
        Assert.False(model.RawData.ContainsKey("method"));
        Assert.Null(model.Params);
        Assert.False(model.RawData.ContainsKey("params"));
        Assert.Null(model.RequestContentType);
        Assert.False(model.RawData.ContainsKey("request_content_type"));
        Assert.Null(model.ResponseContentType);
        Assert.False(model.RawData.ContainsKey("response_content_type"));
        Assert.Null(model.ResponseMap);
        Assert.False(model.RawData.ContainsKey("response_map"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AuthProviderCreateRequestOauth2TokenIntrospectionRequest
        {
            Endpoint = "endpoint",
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthProviderCreateRequestOauth2TokenIntrospectionRequest
        {
            Endpoint = "endpoint",
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },

            // Null should be interpreted as omitted for these properties
            AuthHeaderValueFormat = null,
            AuthMethod = null,
            Method = null,
            Params = null,
            RequestContentType = null,
            ResponseContentType = null,
            ResponseMap = null,
        };

        Assert.Null(model.AuthHeaderValueFormat);
        Assert.False(model.RawData.ContainsKey("auth_header_value_format"));
        Assert.Null(model.AuthMethod);
        Assert.False(model.RawData.ContainsKey("auth_method"));
        Assert.Null(model.Method);
        Assert.False(model.RawData.ContainsKey("method"));
        Assert.Null(model.Params);
        Assert.False(model.RawData.ContainsKey("params"));
        Assert.Null(model.RequestContentType);
        Assert.False(model.RawData.ContainsKey("request_content_type"));
        Assert.Null(model.ResponseContentType);
        Assert.False(model.RawData.ContainsKey("response_content_type"));
        Assert.Null(model.ResponseMap);
        Assert.False(model.RawData.ContainsKey("response_map"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new AuthProviderCreateRequestOauth2TokenIntrospectionRequest
        {
            Endpoint = "endpoint",
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },

            // Null should be interpreted as omitted for these properties
            AuthHeaderValueFormat = null,
            AuthMethod = null,
            Method = null,
            Params = null,
            RequestContentType = null,
            ResponseContentType = null,
            ResponseMap = null,
        };

        model.Validate();
    }
}

public class AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggersTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers
        {
            OnTokenGrant = true,
            OnTokenRefresh = true,
        };

        bool expectedOnTokenGrant = true;
        bool expectedOnTokenRefresh = true;

        Assert.Equal(expectedOnTokenGrant, model.OnTokenGrant);
        Assert.Equal(expectedOnTokenRefresh, model.OnTokenRefresh);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers
        {
            OnTokenGrant = true,
            OnTokenRefresh = true,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers>(
                json
            );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers
        {
            OnTokenGrant = true,
            OnTokenRefresh = true,
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers>(
                element
            );
        Assert.NotNull(deserialized);

        bool expectedOnTokenGrant = true;
        bool expectedOnTokenRefresh = true;

        Assert.Equal(expectedOnTokenGrant, deserialized.OnTokenGrant);
        Assert.Equal(expectedOnTokenRefresh, deserialized.OnTokenRefresh);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers
        {
            OnTokenGrant = true,
            OnTokenRefresh = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers { };

        Assert.Null(model.OnTokenGrant);
        Assert.False(model.RawData.ContainsKey("on_token_grant"));
        Assert.Null(model.OnTokenRefresh);
        Assert.False(model.RawData.ContainsKey("on_token_refresh"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers
        {
            // Null should be interpreted as omitted for these properties
            OnTokenGrant = null,
            OnTokenRefresh = null,
        };

        Assert.Null(model.OnTokenGrant);
        Assert.False(model.RawData.ContainsKey("on_token_grant"));
        Assert.Null(model.OnTokenRefresh);
        Assert.False(model.RawData.ContainsKey("on_token_refresh"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new AuthProviderCreateRequestOauth2TokenIntrospectionRequestTriggers
        {
            // Null should be interpreted as omitted for these properties
            OnTokenGrant = null,
            OnTokenRefresh = null,
        };

        model.Validate();
    }
}

public class AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentTypeTest
    : TestBase
{
    [Theory]
    [InlineData(
        AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(
        AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType.ApplicationJson
    )]
    public void Validation_Works(
        AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<
            string,
            AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType
        > value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<
                string,
                AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType
            >
        >(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(
        AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(
        AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType.ApplicationJson
    )]
    public void SerializationRoundtrip_Works(
        AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<
            string,
            AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType
        > value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<
                string,
                AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType
            >
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<
                string,
                AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType
            >
        >(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<
                string,
                AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType
            >
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentTypeTest
    : TestBase
{
    [Theory]
    [InlineData(
        AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(
        AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType.ApplicationJson
    )]
    public void Validation_Works(
        AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<
            string,
            AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType
        > value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<
                string,
                AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType
            >
        >(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(
        AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(
        AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType.ApplicationJson
    )]
    public void SerializationRoundtrip_Works(
        AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<
            string,
            AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType
        > value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<
                string,
                AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType
            >
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<
                string,
                AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType
            >
        >(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<
                string,
                AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType
            >
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class AuthProviderCreateRequestOauth2TokenRequestTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthProviderCreateRequestOauth2TokenRequest
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderCreateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderCreateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string expectedEndpoint = "endpoint";
        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<
            string,
            AuthProviderCreateRequestOauth2TokenRequestRequestContentType
        > expectedRequestContentType =
            AuthProviderCreateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<
            string,
            AuthProviderCreateRequestOauth2TokenRequestResponseContentType
        > expectedResponseContentType =
            AuthProviderCreateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded;
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedEndpoint, model.Endpoint);
        Assert.Equal(expectedAuthHeaderValueFormat, model.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, model.AuthMethod);
        Assert.Equal(expectedMethod, model.Method);
        Assert.Equal(expectedParams.Count, model.Params.Count);
        foreach (var item in expectedParams)
        {
            Assert.True(model.Params.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.Params[item.Key]);
        }
        Assert.Equal(expectedRequestContentType, model.RequestContentType);
        Assert.Equal(expectedResponseContentType, model.ResponseContentType);
        Assert.Equal(expectedResponseMap.Count, model.ResponseMap.Count);
        foreach (var item in expectedResponseMap)
        {
            Assert.True(model.ResponseMap.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.ResponseMap[item.Key]);
        }
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AuthProviderCreateRequestOauth2TokenRequest
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderCreateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderCreateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthProviderCreateRequestOauth2TokenRequest>(
            json
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AuthProviderCreateRequestOauth2TokenRequest
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderCreateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderCreateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthProviderCreateRequestOauth2TokenRequest>(
            element
        );
        Assert.NotNull(deserialized);

        string expectedEndpoint = "endpoint";
        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<
            string,
            AuthProviderCreateRequestOauth2TokenRequestRequestContentType
        > expectedRequestContentType =
            AuthProviderCreateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<
            string,
            AuthProviderCreateRequestOauth2TokenRequestResponseContentType
        > expectedResponseContentType =
            AuthProviderCreateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded;
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedEndpoint, deserialized.Endpoint);
        Assert.Equal(expectedAuthHeaderValueFormat, deserialized.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, deserialized.AuthMethod);
        Assert.Equal(expectedMethod, deserialized.Method);
        Assert.Equal(expectedParams.Count, deserialized.Params.Count);
        foreach (var item in expectedParams)
        {
            Assert.True(deserialized.Params.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.Params[item.Key]);
        }
        Assert.Equal(expectedRequestContentType, deserialized.RequestContentType);
        Assert.Equal(expectedResponseContentType, deserialized.ResponseContentType);
        Assert.Equal(expectedResponseMap.Count, deserialized.ResponseMap.Count);
        foreach (var item in expectedResponseMap)
        {
            Assert.True(deserialized.ResponseMap.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.ResponseMap[item.Key]);
        }
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AuthProviderCreateRequestOauth2TokenRequest
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderCreateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderCreateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthProviderCreateRequestOauth2TokenRequest { Endpoint = "endpoint" };

        Assert.Null(model.AuthHeaderValueFormat);
        Assert.False(model.RawData.ContainsKey("auth_header_value_format"));
        Assert.Null(model.AuthMethod);
        Assert.False(model.RawData.ContainsKey("auth_method"));
        Assert.Null(model.Method);
        Assert.False(model.RawData.ContainsKey("method"));
        Assert.Null(model.Params);
        Assert.False(model.RawData.ContainsKey("params"));
        Assert.Null(model.RequestContentType);
        Assert.False(model.RawData.ContainsKey("request_content_type"));
        Assert.Null(model.ResponseContentType);
        Assert.False(model.RawData.ContainsKey("response_content_type"));
        Assert.Null(model.ResponseMap);
        Assert.False(model.RawData.ContainsKey("response_map"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AuthProviderCreateRequestOauth2TokenRequest { Endpoint = "endpoint" };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthProviderCreateRequestOauth2TokenRequest
        {
            Endpoint = "endpoint",

            // Null should be interpreted as omitted for these properties
            AuthHeaderValueFormat = null,
            AuthMethod = null,
            Method = null,
            Params = null,
            RequestContentType = null,
            ResponseContentType = null,
            ResponseMap = null,
        };

        Assert.Null(model.AuthHeaderValueFormat);
        Assert.False(model.RawData.ContainsKey("auth_header_value_format"));
        Assert.Null(model.AuthMethod);
        Assert.False(model.RawData.ContainsKey("auth_method"));
        Assert.Null(model.Method);
        Assert.False(model.RawData.ContainsKey("method"));
        Assert.Null(model.Params);
        Assert.False(model.RawData.ContainsKey("params"));
        Assert.Null(model.RequestContentType);
        Assert.False(model.RawData.ContainsKey("request_content_type"));
        Assert.Null(model.ResponseContentType);
        Assert.False(model.RawData.ContainsKey("response_content_type"));
        Assert.Null(model.ResponseMap);
        Assert.False(model.RawData.ContainsKey("response_map"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new AuthProviderCreateRequestOauth2TokenRequest
        {
            Endpoint = "endpoint",

            // Null should be interpreted as omitted for these properties
            AuthHeaderValueFormat = null,
            AuthMethod = null,
            Method = null,
            Params = null,
            RequestContentType = null,
            ResponseContentType = null,
            ResponseMap = null,
        };

        model.Validate();
    }
}

public class AuthProviderCreateRequestOauth2TokenRequestRequestContentTypeTest : TestBase
{
    [Theory]
    [InlineData(
        AuthProviderCreateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(AuthProviderCreateRequestOauth2TokenRequestRequestContentType.ApplicationJson)]
    public void Validation_Works(
        AuthProviderCreateRequestOauth2TokenRequestRequestContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderCreateRequestOauth2TokenRequestRequestContentType> value =
            rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2TokenRequestRequestContentType>
        >(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(
        AuthProviderCreateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(AuthProviderCreateRequestOauth2TokenRequestRequestContentType.ApplicationJson)]
    public void SerializationRoundtrip_Works(
        AuthProviderCreateRequestOauth2TokenRequestRequestContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderCreateRequestOauth2TokenRequestRequestContentType> value =
            rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2TokenRequestRequestContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2TokenRequestRequestContentType>
        >(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2TokenRequestRequestContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class AuthProviderCreateRequestOauth2TokenRequestResponseContentTypeTest : TestBase
{
    [Theory]
    [InlineData(
        AuthProviderCreateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(AuthProviderCreateRequestOauth2TokenRequestResponseContentType.ApplicationJson)]
    public void Validation_Works(
        AuthProviderCreateRequestOauth2TokenRequestResponseContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderCreateRequestOauth2TokenRequestResponseContentType> value =
            rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2TokenRequestResponseContentType>
        >(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(
        AuthProviderCreateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(AuthProviderCreateRequestOauth2TokenRequestResponseContentType.ApplicationJson)]
    public void SerializationRoundtrip_Works(
        AuthProviderCreateRequestOauth2TokenRequestResponseContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderCreateRequestOauth2TokenRequestResponseContentType> value =
            rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2TokenRequestResponseContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2TokenRequestResponseContentType>
        >(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2TokenRequestResponseContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class AuthProviderCreateRequestOauth2UserInfoRequestTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthProviderCreateRequestOauth2UserInfoRequest
        {
            Endpoint = "endpoint",
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string expectedEndpoint = "endpoint";
        AuthProviderCreateRequestOauth2UserInfoRequestTriggers expectedTriggers = new()
        {
            OnTokenGrant = true,
            OnTokenRefresh = true,
        };
        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<
            string,
            AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType
        > expectedRequestContentType =
            AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<
            string,
            AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType
        > expectedResponseContentType =
            AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded;
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedEndpoint, model.Endpoint);
        Assert.Equal(expectedTriggers, model.Triggers);
        Assert.Equal(expectedAuthHeaderValueFormat, model.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, model.AuthMethod);
        Assert.Equal(expectedMethod, model.Method);
        Assert.Equal(expectedParams.Count, model.Params.Count);
        foreach (var item in expectedParams)
        {
            Assert.True(model.Params.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.Params[item.Key]);
        }
        Assert.Equal(expectedRequestContentType, model.RequestContentType);
        Assert.Equal(expectedResponseContentType, model.ResponseContentType);
        Assert.Equal(expectedResponseMap.Count, model.ResponseMap.Count);
        foreach (var item in expectedResponseMap)
        {
            Assert.True(model.ResponseMap.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.ResponseMap[item.Key]);
        }
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AuthProviderCreateRequestOauth2UserInfoRequest
        {
            Endpoint = "endpoint",
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<AuthProviderCreateRequestOauth2UserInfoRequest>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AuthProviderCreateRequestOauth2UserInfoRequest
        {
            Endpoint = "endpoint",
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<AuthProviderCreateRequestOauth2UserInfoRequest>(element);
        Assert.NotNull(deserialized);

        string expectedEndpoint = "endpoint";
        AuthProviderCreateRequestOauth2UserInfoRequestTriggers expectedTriggers = new()
        {
            OnTokenGrant = true,
            OnTokenRefresh = true,
        };
        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<
            string,
            AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType
        > expectedRequestContentType =
            AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<
            string,
            AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType
        > expectedResponseContentType =
            AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded;
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedEndpoint, deserialized.Endpoint);
        Assert.Equal(expectedTriggers, deserialized.Triggers);
        Assert.Equal(expectedAuthHeaderValueFormat, deserialized.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, deserialized.AuthMethod);
        Assert.Equal(expectedMethod, deserialized.Method);
        Assert.Equal(expectedParams.Count, deserialized.Params.Count);
        foreach (var item in expectedParams)
        {
            Assert.True(deserialized.Params.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.Params[item.Key]);
        }
        Assert.Equal(expectedRequestContentType, deserialized.RequestContentType);
        Assert.Equal(expectedResponseContentType, deserialized.ResponseContentType);
        Assert.Equal(expectedResponseMap.Count, deserialized.ResponseMap.Count);
        foreach (var item in expectedResponseMap)
        {
            Assert.True(deserialized.ResponseMap.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.ResponseMap[item.Key]);
        }
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AuthProviderCreateRequestOauth2UserInfoRequest
        {
            Endpoint = "endpoint",
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthProviderCreateRequestOauth2UserInfoRequest
        {
            Endpoint = "endpoint",
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
        };

        Assert.Null(model.AuthHeaderValueFormat);
        Assert.False(model.RawData.ContainsKey("auth_header_value_format"));
        Assert.Null(model.AuthMethod);
        Assert.False(model.RawData.ContainsKey("auth_method"));
        Assert.Null(model.Method);
        Assert.False(model.RawData.ContainsKey("method"));
        Assert.Null(model.Params);
        Assert.False(model.RawData.ContainsKey("params"));
        Assert.Null(model.RequestContentType);
        Assert.False(model.RawData.ContainsKey("request_content_type"));
        Assert.Null(model.ResponseContentType);
        Assert.False(model.RawData.ContainsKey("response_content_type"));
        Assert.Null(model.ResponseMap);
        Assert.False(model.RawData.ContainsKey("response_map"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AuthProviderCreateRequestOauth2UserInfoRequest
        {
            Endpoint = "endpoint",
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthProviderCreateRequestOauth2UserInfoRequest
        {
            Endpoint = "endpoint",
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },

            // Null should be interpreted as omitted for these properties
            AuthHeaderValueFormat = null,
            AuthMethod = null,
            Method = null,
            Params = null,
            RequestContentType = null,
            ResponseContentType = null,
            ResponseMap = null,
        };

        Assert.Null(model.AuthHeaderValueFormat);
        Assert.False(model.RawData.ContainsKey("auth_header_value_format"));
        Assert.Null(model.AuthMethod);
        Assert.False(model.RawData.ContainsKey("auth_method"));
        Assert.Null(model.Method);
        Assert.False(model.RawData.ContainsKey("method"));
        Assert.Null(model.Params);
        Assert.False(model.RawData.ContainsKey("params"));
        Assert.Null(model.RequestContentType);
        Assert.False(model.RawData.ContainsKey("request_content_type"));
        Assert.Null(model.ResponseContentType);
        Assert.False(model.RawData.ContainsKey("response_content_type"));
        Assert.Null(model.ResponseMap);
        Assert.False(model.RawData.ContainsKey("response_map"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new AuthProviderCreateRequestOauth2UserInfoRequest
        {
            Endpoint = "endpoint",
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },

            // Null should be interpreted as omitted for these properties
            AuthHeaderValueFormat = null,
            AuthMethod = null,
            Method = null,
            Params = null,
            RequestContentType = null,
            ResponseContentType = null,
            ResponseMap = null,
        };

        model.Validate();
    }
}

public class AuthProviderCreateRequestOauth2UserInfoRequestTriggersTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthProviderCreateRequestOauth2UserInfoRequestTriggers
        {
            OnTokenGrant = true,
            OnTokenRefresh = true,
        };

        bool expectedOnTokenGrant = true;
        bool expectedOnTokenRefresh = true;

        Assert.Equal(expectedOnTokenGrant, model.OnTokenGrant);
        Assert.Equal(expectedOnTokenRefresh, model.OnTokenRefresh);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AuthProviderCreateRequestOauth2UserInfoRequestTriggers
        {
            OnTokenGrant = true,
            OnTokenRefresh = true,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<AuthProviderCreateRequestOauth2UserInfoRequestTriggers>(
                json
            );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AuthProviderCreateRequestOauth2UserInfoRequestTriggers
        {
            OnTokenGrant = true,
            OnTokenRefresh = true,
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<AuthProviderCreateRequestOauth2UserInfoRequestTriggers>(
                element
            );
        Assert.NotNull(deserialized);

        bool expectedOnTokenGrant = true;
        bool expectedOnTokenRefresh = true;

        Assert.Equal(expectedOnTokenGrant, deserialized.OnTokenGrant);
        Assert.Equal(expectedOnTokenRefresh, deserialized.OnTokenRefresh);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AuthProviderCreateRequestOauth2UserInfoRequestTriggers
        {
            OnTokenGrant = true,
            OnTokenRefresh = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthProviderCreateRequestOauth2UserInfoRequestTriggers { };

        Assert.Null(model.OnTokenGrant);
        Assert.False(model.RawData.ContainsKey("on_token_grant"));
        Assert.Null(model.OnTokenRefresh);
        Assert.False(model.RawData.ContainsKey("on_token_refresh"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AuthProviderCreateRequestOauth2UserInfoRequestTriggers { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthProviderCreateRequestOauth2UserInfoRequestTriggers
        {
            // Null should be interpreted as omitted for these properties
            OnTokenGrant = null,
            OnTokenRefresh = null,
        };

        Assert.Null(model.OnTokenGrant);
        Assert.False(model.RawData.ContainsKey("on_token_grant"));
        Assert.Null(model.OnTokenRefresh);
        Assert.False(model.RawData.ContainsKey("on_token_refresh"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new AuthProviderCreateRequestOauth2UserInfoRequestTriggers
        {
            // Null should be interpreted as omitted for these properties
            OnTokenGrant = null,
            OnTokenRefresh = null,
        };

        model.Validate();
    }
}

public class AuthProviderCreateRequestOauth2UserInfoRequestRequestContentTypeTest : TestBase
{
    [Theory]
    [InlineData(
        AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType.ApplicationJson)]
    public void Validation_Works(
        AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType> value =
            rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType>
        >(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(
        AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType.ApplicationJson)]
    public void SerializationRoundtrip_Works(
        AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType> value =
            rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType>
        >(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class AuthProviderCreateRequestOauth2UserInfoRequestResponseContentTypeTest : TestBase
{
    [Theory]
    [InlineData(
        AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType.ApplicationJson)]
    public void Validation_Works(
        AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType> value =
            rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType>
        >(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(
        AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType.ApplicationJson)]
    public void SerializationRoundtrip_Works(
        AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType> value =
            rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType>
        >(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}
