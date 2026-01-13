using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using ArcadeDotnet.Models.Admin.AuthProviders;

namespace ArcadeDotnet.Tests.Models.Admin.AuthProviders;

public class AuthProviderUpdateRequestTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthProviderUpdateRequest
        {
            ID = "id",
            Description = "description",
            Oauth2 = new()
            {
                AuthorizeRequest = new()
                {
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Endpoint = "endpoint",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
                ClientID = "client_id",
                ClientSecret = "client_secret",
                Pkce = new() { CodeChallengeMethod = "code_challenge_method", Enabled = true },
                RefreshRequest = new()
                {
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Endpoint = "endpoint",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
                ScopeDelimiter = AuthProviderUpdateRequestOauth2ScopeDelimiter.Undefined,
                TokenRequest = new()
                {
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Endpoint = "endpoint",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderUpdateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderUpdateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
                UserInfoRequest = new()
                {
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Endpoint = "endpoint",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                    Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
                },
            },
            ProviderID = "provider_id",
            Status = "status",
            Type = "type",
        };

        string expectedID = "id";
        string expectedDescription = "description";
        AuthProviderUpdateRequestOauth2 expectedOauth2 = new()
        {
            AuthorizeRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ClientID = "client_id",
            ClientSecret = "client_secret",
            Pkce = new() { CodeChallengeMethod = "code_challenge_method", Enabled = true },
            RefreshRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ScopeDelimiter = AuthProviderUpdateRequestOauth2ScopeDelimiter.Undefined,
            TokenRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderUpdateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderUpdateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            UserInfoRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            },
        };
        string expectedProviderID = "provider_id";
        string expectedStatus = "status";
        string expectedType = "type";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedOauth2, model.Oauth2);
        Assert.Equal(expectedProviderID, model.ProviderID);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedType, model.Type);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AuthProviderUpdateRequest
        {
            ID = "id",
            Description = "description",
            Oauth2 = new()
            {
                AuthorizeRequest = new()
                {
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Endpoint = "endpoint",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
                ClientID = "client_id",
                ClientSecret = "client_secret",
                Pkce = new() { CodeChallengeMethod = "code_challenge_method", Enabled = true },
                RefreshRequest = new()
                {
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Endpoint = "endpoint",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
                ScopeDelimiter = AuthProviderUpdateRequestOauth2ScopeDelimiter.Undefined,
                TokenRequest = new()
                {
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Endpoint = "endpoint",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderUpdateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderUpdateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
                UserInfoRequest = new()
                {
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Endpoint = "endpoint",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                    Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
                },
            },
            ProviderID = "provider_id",
            Status = "status",
            Type = "type",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthProviderUpdateRequest>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AuthProviderUpdateRequest
        {
            ID = "id",
            Description = "description",
            Oauth2 = new()
            {
                AuthorizeRequest = new()
                {
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Endpoint = "endpoint",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
                ClientID = "client_id",
                ClientSecret = "client_secret",
                Pkce = new() { CodeChallengeMethod = "code_challenge_method", Enabled = true },
                RefreshRequest = new()
                {
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Endpoint = "endpoint",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
                ScopeDelimiter = AuthProviderUpdateRequestOauth2ScopeDelimiter.Undefined,
                TokenRequest = new()
                {
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Endpoint = "endpoint",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderUpdateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderUpdateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
                UserInfoRequest = new()
                {
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Endpoint = "endpoint",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                    Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
                },
            },
            ProviderID = "provider_id",
            Status = "status",
            Type = "type",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthProviderUpdateRequest>(element);
        Assert.NotNull(deserialized);

        string expectedID = "id";
        string expectedDescription = "description";
        AuthProviderUpdateRequestOauth2 expectedOauth2 = new()
        {
            AuthorizeRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ClientID = "client_id",
            ClientSecret = "client_secret",
            Pkce = new() { CodeChallengeMethod = "code_challenge_method", Enabled = true },
            RefreshRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ScopeDelimiter = AuthProviderUpdateRequestOauth2ScopeDelimiter.Undefined,
            TokenRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderUpdateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderUpdateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            UserInfoRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            },
        };
        string expectedProviderID = "provider_id";
        string expectedStatus = "status";
        string expectedType = "type";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedOauth2, deserialized.Oauth2);
        Assert.Equal(expectedProviderID, deserialized.ProviderID);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedType, deserialized.Type);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AuthProviderUpdateRequest
        {
            ID = "id",
            Description = "description",
            Oauth2 = new()
            {
                AuthorizeRequest = new()
                {
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Endpoint = "endpoint",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
                ClientID = "client_id",
                ClientSecret = "client_secret",
                Pkce = new() { CodeChallengeMethod = "code_challenge_method", Enabled = true },
                RefreshRequest = new()
                {
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Endpoint = "endpoint",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
                ScopeDelimiter = AuthProviderUpdateRequestOauth2ScopeDelimiter.Undefined,
                TokenRequest = new()
                {
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Endpoint = "endpoint",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderUpdateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderUpdateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
                UserInfoRequest = new()
                {
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Endpoint = "endpoint",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                    Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
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
        var model = new AuthProviderUpdateRequest { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
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
        var model = new AuthProviderUpdateRequest { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthProviderUpdateRequest
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Description = null,
            Oauth2 = null,
            ProviderID = null,
            Status = null,
            Type = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
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
        var model = new AuthProviderUpdateRequest
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Description = null,
            Oauth2 = null,
            ProviderID = null,
            Status = null,
            Type = null,
        };

        model.Validate();
    }
}

public class AuthProviderUpdateRequestOauth2Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2
        {
            AuthorizeRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ClientID = "client_id",
            ClientSecret = "client_secret",
            Pkce = new() { CodeChallengeMethod = "code_challenge_method", Enabled = true },
            RefreshRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ScopeDelimiter = AuthProviderUpdateRequestOauth2ScopeDelimiter.Undefined,
            TokenRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderUpdateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderUpdateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            UserInfoRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            },
        };

        AuthProviderUpdateRequestOauth2AuthorizeRequest expectedAuthorizeRequest = new()
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };
        string expectedClientID = "client_id";
        string expectedClientSecret = "client_secret";
        AuthProviderUpdateRequestOauth2Pkce expectedPkce = new()
        {
            CodeChallengeMethod = "code_challenge_method",
            Enabled = true,
        };
        AuthProviderUpdateRequestOauth2RefreshRequest expectedRefreshRequest = new()
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };
        ApiEnum<string, AuthProviderUpdateRequestOauth2ScopeDelimiter> expectedScopeDelimiter =
            AuthProviderUpdateRequestOauth2ScopeDelimiter.Undefined;
        AuthProviderUpdateRequestOauth2TokenRequest expectedTokenRequest = new()
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderUpdateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderUpdateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };
        AuthProviderUpdateRequestOauth2UserInfoRequest expectedUserInfoRequest = new()
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
        };

        Assert.Equal(expectedAuthorizeRequest, model.AuthorizeRequest);
        Assert.Equal(expectedClientID, model.ClientID);
        Assert.Equal(expectedClientSecret, model.ClientSecret);
        Assert.Equal(expectedPkce, model.Pkce);
        Assert.Equal(expectedRefreshRequest, model.RefreshRequest);
        Assert.Equal(expectedScopeDelimiter, model.ScopeDelimiter);
        Assert.Equal(expectedTokenRequest, model.TokenRequest);
        Assert.Equal(expectedUserInfoRequest, model.UserInfoRequest);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2
        {
            AuthorizeRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ClientID = "client_id",
            ClientSecret = "client_secret",
            Pkce = new() { CodeChallengeMethod = "code_challenge_method", Enabled = true },
            RefreshRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ScopeDelimiter = AuthProviderUpdateRequestOauth2ScopeDelimiter.Undefined,
            TokenRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderUpdateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderUpdateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            UserInfoRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthProviderUpdateRequestOauth2>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2
        {
            AuthorizeRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ClientID = "client_id",
            ClientSecret = "client_secret",
            Pkce = new() { CodeChallengeMethod = "code_challenge_method", Enabled = true },
            RefreshRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ScopeDelimiter = AuthProviderUpdateRequestOauth2ScopeDelimiter.Undefined,
            TokenRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderUpdateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderUpdateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            UserInfoRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            },
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthProviderUpdateRequestOauth2>(element);
        Assert.NotNull(deserialized);

        AuthProviderUpdateRequestOauth2AuthorizeRequest expectedAuthorizeRequest = new()
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };
        string expectedClientID = "client_id";
        string expectedClientSecret = "client_secret";
        AuthProviderUpdateRequestOauth2Pkce expectedPkce = new()
        {
            CodeChallengeMethod = "code_challenge_method",
            Enabled = true,
        };
        AuthProviderUpdateRequestOauth2RefreshRequest expectedRefreshRequest = new()
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };
        ApiEnum<string, AuthProviderUpdateRequestOauth2ScopeDelimiter> expectedScopeDelimiter =
            AuthProviderUpdateRequestOauth2ScopeDelimiter.Undefined;
        AuthProviderUpdateRequestOauth2TokenRequest expectedTokenRequest = new()
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderUpdateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderUpdateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };
        AuthProviderUpdateRequestOauth2UserInfoRequest expectedUserInfoRequest = new()
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
        };

        Assert.Equal(expectedAuthorizeRequest, deserialized.AuthorizeRequest);
        Assert.Equal(expectedClientID, deserialized.ClientID);
        Assert.Equal(expectedClientSecret, deserialized.ClientSecret);
        Assert.Equal(expectedPkce, deserialized.Pkce);
        Assert.Equal(expectedRefreshRequest, deserialized.RefreshRequest);
        Assert.Equal(expectedScopeDelimiter, deserialized.ScopeDelimiter);
        Assert.Equal(expectedTokenRequest, deserialized.TokenRequest);
        Assert.Equal(expectedUserInfoRequest, deserialized.UserInfoRequest);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2
        {
            AuthorizeRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ClientID = "client_id",
            ClientSecret = "client_secret",
            Pkce = new() { CodeChallengeMethod = "code_challenge_method", Enabled = true },
            RefreshRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ScopeDelimiter = AuthProviderUpdateRequestOauth2ScopeDelimiter.Undefined,
            TokenRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderUpdateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderUpdateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            UserInfoRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2 { };

        Assert.Null(model.AuthorizeRequest);
        Assert.False(model.RawData.ContainsKey("authorize_request"));
        Assert.Null(model.ClientID);
        Assert.False(model.RawData.ContainsKey("client_id"));
        Assert.Null(model.ClientSecret);
        Assert.False(model.RawData.ContainsKey("client_secret"));
        Assert.Null(model.Pkce);
        Assert.False(model.RawData.ContainsKey("pkce"));
        Assert.Null(model.RefreshRequest);
        Assert.False(model.RawData.ContainsKey("refresh_request"));
        Assert.Null(model.ScopeDelimiter);
        Assert.False(model.RawData.ContainsKey("scope_delimiter"));
        Assert.Null(model.TokenRequest);
        Assert.False(model.RawData.ContainsKey("token_request"));
        Assert.Null(model.UserInfoRequest);
        Assert.False(model.RawData.ContainsKey("user_info_request"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2 { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2
        {
            // Null should be interpreted as omitted for these properties
            AuthorizeRequest = null,
            ClientID = null,
            ClientSecret = null,
            Pkce = null,
            RefreshRequest = null,
            ScopeDelimiter = null,
            TokenRequest = null,
            UserInfoRequest = null,
        };

        Assert.Null(model.AuthorizeRequest);
        Assert.False(model.RawData.ContainsKey("authorize_request"));
        Assert.Null(model.ClientID);
        Assert.False(model.RawData.ContainsKey("client_id"));
        Assert.Null(model.ClientSecret);
        Assert.False(model.RawData.ContainsKey("client_secret"));
        Assert.Null(model.Pkce);
        Assert.False(model.RawData.ContainsKey("pkce"));
        Assert.Null(model.RefreshRequest);
        Assert.False(model.RawData.ContainsKey("refresh_request"));
        Assert.Null(model.ScopeDelimiter);
        Assert.False(model.RawData.ContainsKey("scope_delimiter"));
        Assert.Null(model.TokenRequest);
        Assert.False(model.RawData.ContainsKey("token_request"));
        Assert.Null(model.UserInfoRequest);
        Assert.False(model.RawData.ContainsKey("user_info_request"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2
        {
            // Null should be interpreted as omitted for these properties
            AuthorizeRequest = null,
            ClientID = null,
            ClientSecret = null,
            Pkce = null,
            RefreshRequest = null,
            ScopeDelimiter = null,
            TokenRequest = null,
            UserInfoRequest = null,
        };

        model.Validate();
    }
}

public class AuthProviderUpdateRequestOauth2AuthorizeRequestTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2AuthorizeRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedEndpoint = "endpoint";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<
            string,
            AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType
        > expectedRequestContentType =
            AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<
            string,
            AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType
        > expectedResponseContentType =
            AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded;
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedAuthHeaderValueFormat, model.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, model.AuthMethod);
        Assert.Equal(expectedEndpoint, model.Endpoint);
        Assert.Equal(expectedMethod, model.Method);
        Assert.NotNull(model.Params);
        Assert.Equal(expectedParams.Count, model.Params.Count);
        foreach (var item in expectedParams)
        {
            Assert.True(model.Params.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.Params[item.Key]);
        }
        Assert.Equal(expectedRequestContentType, model.RequestContentType);
        Assert.Equal(expectedResponseContentType, model.ResponseContentType);
        Assert.NotNull(model.ResponseMap);
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
        var model = new AuthProviderUpdateRequestOauth2AuthorizeRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<AuthProviderUpdateRequestOauth2AuthorizeRequest>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2AuthorizeRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<AuthProviderUpdateRequestOauth2AuthorizeRequest>(element);
        Assert.NotNull(deserialized);

        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedEndpoint = "endpoint";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<
            string,
            AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType
        > expectedRequestContentType =
            AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<
            string,
            AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType
        > expectedResponseContentType =
            AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded;
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedAuthHeaderValueFormat, deserialized.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, deserialized.AuthMethod);
        Assert.Equal(expectedEndpoint, deserialized.Endpoint);
        Assert.Equal(expectedMethod, deserialized.Method);
        Assert.NotNull(deserialized.Params);
        Assert.Equal(expectedParams.Count, deserialized.Params.Count);
        foreach (var item in expectedParams)
        {
            Assert.True(deserialized.Params.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.Params[item.Key]);
        }
        Assert.Equal(expectedRequestContentType, deserialized.RequestContentType);
        Assert.Equal(expectedResponseContentType, deserialized.ResponseContentType);
        Assert.NotNull(deserialized.ResponseMap);
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
        var model = new AuthProviderUpdateRequestOauth2AuthorizeRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2AuthorizeRequest { };

        Assert.Null(model.AuthHeaderValueFormat);
        Assert.False(model.RawData.ContainsKey("auth_header_value_format"));
        Assert.Null(model.AuthMethod);
        Assert.False(model.RawData.ContainsKey("auth_method"));
        Assert.Null(model.Endpoint);
        Assert.False(model.RawData.ContainsKey("endpoint"));
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
        var model = new AuthProviderUpdateRequestOauth2AuthorizeRequest { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2AuthorizeRequest
        {
            // Null should be interpreted as omitted for these properties
            AuthHeaderValueFormat = null,
            AuthMethod = null,
            Endpoint = null,
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
        Assert.Null(model.Endpoint);
        Assert.False(model.RawData.ContainsKey("endpoint"));
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
        var model = new AuthProviderUpdateRequestOauth2AuthorizeRequest
        {
            // Null should be interpreted as omitted for these properties
            AuthHeaderValueFormat = null,
            AuthMethod = null,
            Endpoint = null,
            Method = null,
            Params = null,
            RequestContentType = null,
            ResponseContentType = null,
            ResponseMap = null,
        };

        model.Validate();
    }
}

public class AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentTypeTest : TestBase
{
    [Theory]
    [InlineData(
        AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType.ApplicationJson)]
    public void Validation_Works(
        AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType> value =
            rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(
        AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType.ApplicationJson)]
    public void SerializationRoundtrip_Works(
        AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType> value =
            rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentTypeTest : TestBase
{
    [Theory]
    [InlineData(
        AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType.ApplicationJson)]
    public void Validation_Works(
        AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType> value =
            rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(
        AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType.ApplicationJson)]
    public void SerializationRoundtrip_Works(
        AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType> value =
            rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class AuthProviderUpdateRequestOauth2PkceTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2Pkce
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
        var model = new AuthProviderUpdateRequestOauth2Pkce
        {
            CodeChallengeMethod = "code_challenge_method",
            Enabled = true,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthProviderUpdateRequestOauth2Pkce>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2Pkce
        {
            CodeChallengeMethod = "code_challenge_method",
            Enabled = true,
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthProviderUpdateRequestOauth2Pkce>(element);
        Assert.NotNull(deserialized);

        string expectedCodeChallengeMethod = "code_challenge_method";
        bool expectedEnabled = true;

        Assert.Equal(expectedCodeChallengeMethod, deserialized.CodeChallengeMethod);
        Assert.Equal(expectedEnabled, deserialized.Enabled);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2Pkce
        {
            CodeChallengeMethod = "code_challenge_method",
            Enabled = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2Pkce { };

        Assert.Null(model.CodeChallengeMethod);
        Assert.False(model.RawData.ContainsKey("code_challenge_method"));
        Assert.Null(model.Enabled);
        Assert.False(model.RawData.ContainsKey("enabled"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2Pkce { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2Pkce
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
        var model = new AuthProviderUpdateRequestOauth2Pkce
        {
            // Null should be interpreted as omitted for these properties
            CodeChallengeMethod = null,
            Enabled = null,
        };

        model.Validate();
    }
}

public class AuthProviderUpdateRequestOauth2RefreshRequestTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2RefreshRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedEndpoint = "endpoint";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<
            string,
            AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType
        > expectedRequestContentType =
            AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<
            string,
            AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType
        > expectedResponseContentType =
            AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded;
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedAuthHeaderValueFormat, model.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, model.AuthMethod);
        Assert.Equal(expectedEndpoint, model.Endpoint);
        Assert.Equal(expectedMethod, model.Method);
        Assert.NotNull(model.Params);
        Assert.Equal(expectedParams.Count, model.Params.Count);
        foreach (var item in expectedParams)
        {
            Assert.True(model.Params.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.Params[item.Key]);
        }
        Assert.Equal(expectedRequestContentType, model.RequestContentType);
        Assert.Equal(expectedResponseContentType, model.ResponseContentType);
        Assert.NotNull(model.ResponseMap);
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
        var model = new AuthProviderUpdateRequestOauth2RefreshRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<AuthProviderUpdateRequestOauth2RefreshRequest>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2RefreshRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<AuthProviderUpdateRequestOauth2RefreshRequest>(element);
        Assert.NotNull(deserialized);

        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedEndpoint = "endpoint";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<
            string,
            AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType
        > expectedRequestContentType =
            AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<
            string,
            AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType
        > expectedResponseContentType =
            AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded;
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedAuthHeaderValueFormat, deserialized.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, deserialized.AuthMethod);
        Assert.Equal(expectedEndpoint, deserialized.Endpoint);
        Assert.Equal(expectedMethod, deserialized.Method);
        Assert.NotNull(deserialized.Params);
        Assert.Equal(expectedParams.Count, deserialized.Params.Count);
        foreach (var item in expectedParams)
        {
            Assert.True(deserialized.Params.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.Params[item.Key]);
        }
        Assert.Equal(expectedRequestContentType, deserialized.RequestContentType);
        Assert.Equal(expectedResponseContentType, deserialized.ResponseContentType);
        Assert.NotNull(deserialized.ResponseMap);
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
        var model = new AuthProviderUpdateRequestOauth2RefreshRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2RefreshRequest { };

        Assert.Null(model.AuthHeaderValueFormat);
        Assert.False(model.RawData.ContainsKey("auth_header_value_format"));
        Assert.Null(model.AuthMethod);
        Assert.False(model.RawData.ContainsKey("auth_method"));
        Assert.Null(model.Endpoint);
        Assert.False(model.RawData.ContainsKey("endpoint"));
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
        var model = new AuthProviderUpdateRequestOauth2RefreshRequest { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2RefreshRequest
        {
            // Null should be interpreted as omitted for these properties
            AuthHeaderValueFormat = null,
            AuthMethod = null,
            Endpoint = null,
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
        Assert.Null(model.Endpoint);
        Assert.False(model.RawData.ContainsKey("endpoint"));
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
        var model = new AuthProviderUpdateRequestOauth2RefreshRequest
        {
            // Null should be interpreted as omitted for these properties
            AuthHeaderValueFormat = null,
            AuthMethod = null,
            Endpoint = null,
            Method = null,
            Params = null,
            RequestContentType = null,
            ResponseContentType = null,
            ResponseMap = null,
        };

        model.Validate();
    }
}

public class AuthProviderUpdateRequestOauth2RefreshRequestRequestContentTypeTest : TestBase
{
    [Theory]
    [InlineData(
        AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType.ApplicationJson)]
    public void Validation_Works(
        AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType> value =
            rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(
        AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType.ApplicationJson)]
    public void SerializationRoundtrip_Works(
        AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType> value =
            rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class AuthProviderUpdateRequestOauth2RefreshRequestResponseContentTypeTest : TestBase
{
    [Theory]
    [InlineData(
        AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType.ApplicationJson)]
    public void Validation_Works(
        AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType> value =
            rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(
        AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType.ApplicationJson)]
    public void SerializationRoundtrip_Works(
        AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType> value =
            rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class AuthProviderUpdateRequestOauth2ScopeDelimiterTest : TestBase
{
    [Theory]
    [InlineData(AuthProviderUpdateRequestOauth2ScopeDelimiter.Undefined)]
    [InlineData(AuthProviderUpdateRequestOauth2ScopeDelimiter.V1)]
    public void Validation_Works(AuthProviderUpdateRequestOauth2ScopeDelimiter rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderUpdateRequestOauth2ScopeDelimiter> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2ScopeDelimiter>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(AuthProviderUpdateRequestOauth2ScopeDelimiter.Undefined)]
    [InlineData(AuthProviderUpdateRequestOauth2ScopeDelimiter.V1)]
    public void SerializationRoundtrip_Works(AuthProviderUpdateRequestOauth2ScopeDelimiter rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderUpdateRequestOauth2ScopeDelimiter> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2ScopeDelimiter>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2ScopeDelimiter>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2ScopeDelimiter>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class AuthProviderUpdateRequestOauth2TokenRequestTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2TokenRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderUpdateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderUpdateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedEndpoint = "endpoint";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<
            string,
            AuthProviderUpdateRequestOauth2TokenRequestRequestContentType
        > expectedRequestContentType =
            AuthProviderUpdateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<
            string,
            AuthProviderUpdateRequestOauth2TokenRequestResponseContentType
        > expectedResponseContentType =
            AuthProviderUpdateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded;
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedAuthHeaderValueFormat, model.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, model.AuthMethod);
        Assert.Equal(expectedEndpoint, model.Endpoint);
        Assert.Equal(expectedMethod, model.Method);
        Assert.NotNull(model.Params);
        Assert.Equal(expectedParams.Count, model.Params.Count);
        foreach (var item in expectedParams)
        {
            Assert.True(model.Params.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.Params[item.Key]);
        }
        Assert.Equal(expectedRequestContentType, model.RequestContentType);
        Assert.Equal(expectedResponseContentType, model.ResponseContentType);
        Assert.NotNull(model.ResponseMap);
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
        var model = new AuthProviderUpdateRequestOauth2TokenRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderUpdateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderUpdateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthProviderUpdateRequestOauth2TokenRequest>(
            json
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2TokenRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderUpdateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderUpdateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthProviderUpdateRequestOauth2TokenRequest>(
            element
        );
        Assert.NotNull(deserialized);

        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedEndpoint = "endpoint";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<
            string,
            AuthProviderUpdateRequestOauth2TokenRequestRequestContentType
        > expectedRequestContentType =
            AuthProviderUpdateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<
            string,
            AuthProviderUpdateRequestOauth2TokenRequestResponseContentType
        > expectedResponseContentType =
            AuthProviderUpdateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded;
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedAuthHeaderValueFormat, deserialized.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, deserialized.AuthMethod);
        Assert.Equal(expectedEndpoint, deserialized.Endpoint);
        Assert.Equal(expectedMethod, deserialized.Method);
        Assert.NotNull(deserialized.Params);
        Assert.Equal(expectedParams.Count, deserialized.Params.Count);
        foreach (var item in expectedParams)
        {
            Assert.True(deserialized.Params.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.Params[item.Key]);
        }
        Assert.Equal(expectedRequestContentType, deserialized.RequestContentType);
        Assert.Equal(expectedResponseContentType, deserialized.ResponseContentType);
        Assert.NotNull(deserialized.ResponseMap);
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
        var model = new AuthProviderUpdateRequestOauth2TokenRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderUpdateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderUpdateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2TokenRequest { };

        Assert.Null(model.AuthHeaderValueFormat);
        Assert.False(model.RawData.ContainsKey("auth_header_value_format"));
        Assert.Null(model.AuthMethod);
        Assert.False(model.RawData.ContainsKey("auth_method"));
        Assert.Null(model.Endpoint);
        Assert.False(model.RawData.ContainsKey("endpoint"));
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
        var model = new AuthProviderUpdateRequestOauth2TokenRequest { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2TokenRequest
        {
            // Null should be interpreted as omitted for these properties
            AuthHeaderValueFormat = null,
            AuthMethod = null,
            Endpoint = null,
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
        Assert.Null(model.Endpoint);
        Assert.False(model.RawData.ContainsKey("endpoint"));
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
        var model = new AuthProviderUpdateRequestOauth2TokenRequest
        {
            // Null should be interpreted as omitted for these properties
            AuthHeaderValueFormat = null,
            AuthMethod = null,
            Endpoint = null,
            Method = null,
            Params = null,
            RequestContentType = null,
            ResponseContentType = null,
            ResponseMap = null,
        };

        model.Validate();
    }
}

public class AuthProviderUpdateRequestOauth2TokenRequestRequestContentTypeTest : TestBase
{
    [Theory]
    [InlineData(
        AuthProviderUpdateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(AuthProviderUpdateRequestOauth2TokenRequestRequestContentType.ApplicationJson)]
    public void Validation_Works(
        AuthProviderUpdateRequestOauth2TokenRequestRequestContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderUpdateRequestOauth2TokenRequestRequestContentType> value =
            rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2TokenRequestRequestContentType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(
        AuthProviderUpdateRequestOauth2TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(AuthProviderUpdateRequestOauth2TokenRequestRequestContentType.ApplicationJson)]
    public void SerializationRoundtrip_Works(
        AuthProviderUpdateRequestOauth2TokenRequestRequestContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderUpdateRequestOauth2TokenRequestRequestContentType> value =
            rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2TokenRequestRequestContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2TokenRequestRequestContentType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2TokenRequestRequestContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class AuthProviderUpdateRequestOauth2TokenRequestResponseContentTypeTest : TestBase
{
    [Theory]
    [InlineData(
        AuthProviderUpdateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(AuthProviderUpdateRequestOauth2TokenRequestResponseContentType.ApplicationJson)]
    public void Validation_Works(
        AuthProviderUpdateRequestOauth2TokenRequestResponseContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderUpdateRequestOauth2TokenRequestResponseContentType> value =
            rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2TokenRequestResponseContentType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(
        AuthProviderUpdateRequestOauth2TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(AuthProviderUpdateRequestOauth2TokenRequestResponseContentType.ApplicationJson)]
    public void SerializationRoundtrip_Works(
        AuthProviderUpdateRequestOauth2TokenRequestResponseContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderUpdateRequestOauth2TokenRequestResponseContentType> value =
            rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2TokenRequestResponseContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2TokenRequestResponseContentType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2TokenRequestResponseContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class AuthProviderUpdateRequestOauth2UserInfoRequestTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2UserInfoRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
        };

        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedEndpoint = "endpoint";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<
            string,
            AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType
        > expectedRequestContentType =
            AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<
            string,
            AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType
        > expectedResponseContentType =
            AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded;
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };
        AuthProviderUpdateRequestOauth2UserInfoRequestTriggers expectedTriggers = new()
        {
            OnTokenGrant = true,
            OnTokenRefresh = true,
        };

        Assert.Equal(expectedAuthHeaderValueFormat, model.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, model.AuthMethod);
        Assert.Equal(expectedEndpoint, model.Endpoint);
        Assert.Equal(expectedMethod, model.Method);
        Assert.NotNull(model.Params);
        Assert.Equal(expectedParams.Count, model.Params.Count);
        foreach (var item in expectedParams)
        {
            Assert.True(model.Params.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.Params[item.Key]);
        }
        Assert.Equal(expectedRequestContentType, model.RequestContentType);
        Assert.Equal(expectedResponseContentType, model.ResponseContentType);
        Assert.NotNull(model.ResponseMap);
        Assert.Equal(expectedResponseMap.Count, model.ResponseMap.Count);
        foreach (var item in expectedResponseMap)
        {
            Assert.True(model.ResponseMap.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.ResponseMap[item.Key]);
        }
        Assert.Equal(expectedTriggers, model.Triggers);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2UserInfoRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<AuthProviderUpdateRequestOauth2UserInfoRequest>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2UserInfoRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<AuthProviderUpdateRequestOauth2UserInfoRequest>(element);
        Assert.NotNull(deserialized);

        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedEndpoint = "endpoint";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<
            string,
            AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType
        > expectedRequestContentType =
            AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<
            string,
            AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType
        > expectedResponseContentType =
            AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded;
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };
        AuthProviderUpdateRequestOauth2UserInfoRequestTriggers expectedTriggers = new()
        {
            OnTokenGrant = true,
            OnTokenRefresh = true,
        };

        Assert.Equal(expectedAuthHeaderValueFormat, deserialized.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, deserialized.AuthMethod);
        Assert.Equal(expectedEndpoint, deserialized.Endpoint);
        Assert.Equal(expectedMethod, deserialized.Method);
        Assert.NotNull(deserialized.Params);
        Assert.Equal(expectedParams.Count, deserialized.Params.Count);
        foreach (var item in expectedParams)
        {
            Assert.True(deserialized.Params.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.Params[item.Key]);
        }
        Assert.Equal(expectedRequestContentType, deserialized.RequestContentType);
        Assert.Equal(expectedResponseContentType, deserialized.ResponseContentType);
        Assert.NotNull(deserialized.ResponseMap);
        Assert.Equal(expectedResponseMap.Count, deserialized.ResponseMap.Count);
        foreach (var item in expectedResponseMap)
        {
            Assert.True(deserialized.ResponseMap.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.ResponseMap[item.Key]);
        }
        Assert.Equal(expectedTriggers, deserialized.Triggers);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2UserInfoRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2UserInfoRequest { };

        Assert.Null(model.AuthHeaderValueFormat);
        Assert.False(model.RawData.ContainsKey("auth_header_value_format"));
        Assert.Null(model.AuthMethod);
        Assert.False(model.RawData.ContainsKey("auth_method"));
        Assert.Null(model.Endpoint);
        Assert.False(model.RawData.ContainsKey("endpoint"));
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
        Assert.Null(model.Triggers);
        Assert.False(model.RawData.ContainsKey("triggers"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2UserInfoRequest { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2UserInfoRequest
        {
            // Null should be interpreted as omitted for these properties
            AuthHeaderValueFormat = null,
            AuthMethod = null,
            Endpoint = null,
            Method = null,
            Params = null,
            RequestContentType = null,
            ResponseContentType = null,
            ResponseMap = null,
            Triggers = null,
        };

        Assert.Null(model.AuthHeaderValueFormat);
        Assert.False(model.RawData.ContainsKey("auth_header_value_format"));
        Assert.Null(model.AuthMethod);
        Assert.False(model.RawData.ContainsKey("auth_method"));
        Assert.Null(model.Endpoint);
        Assert.False(model.RawData.ContainsKey("endpoint"));
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
        Assert.Null(model.Triggers);
        Assert.False(model.RawData.ContainsKey("triggers"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2UserInfoRequest
        {
            // Null should be interpreted as omitted for these properties
            AuthHeaderValueFormat = null,
            AuthMethod = null,
            Endpoint = null,
            Method = null,
            Params = null,
            RequestContentType = null,
            ResponseContentType = null,
            ResponseMap = null,
            Triggers = null,
        };

        model.Validate();
    }
}

public class AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentTypeTest : TestBase
{
    [Theory]
    [InlineData(
        AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType.ApplicationJson)]
    public void Validation_Works(
        AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType> value =
            rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(
        AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType.ApplicationJson)]
    public void SerializationRoundtrip_Works(
        AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType> value =
            rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentTypeTest : TestBase
{
    [Theory]
    [InlineData(
        AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType.ApplicationJson)]
    public void Validation_Works(
        AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType> value =
            rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(
        AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded
    )]
    [InlineData(AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType.ApplicationJson)]
    public void SerializationRoundtrip_Works(
        AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType> value =
            rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class AuthProviderUpdateRequestOauth2UserInfoRequestTriggersTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2UserInfoRequestTriggers
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
        var model = new AuthProviderUpdateRequestOauth2UserInfoRequestTriggers
        {
            OnTokenGrant = true,
            OnTokenRefresh = true,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<AuthProviderUpdateRequestOauth2UserInfoRequestTriggers>(
                json
            );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2UserInfoRequestTriggers
        {
            OnTokenGrant = true,
            OnTokenRefresh = true,
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<AuthProviderUpdateRequestOauth2UserInfoRequestTriggers>(
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
        var model = new AuthProviderUpdateRequestOauth2UserInfoRequestTriggers
        {
            OnTokenGrant = true,
            OnTokenRefresh = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2UserInfoRequestTriggers { };

        Assert.Null(model.OnTokenGrant);
        Assert.False(model.RawData.ContainsKey("on_token_grant"));
        Assert.Null(model.OnTokenRefresh);
        Assert.False(model.RawData.ContainsKey("on_token_refresh"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2UserInfoRequestTriggers { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthProviderUpdateRequestOauth2UserInfoRequestTriggers
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
        var model = new AuthProviderUpdateRequestOauth2UserInfoRequestTriggers
        {
            // Null should be interpreted as omitted for these properties
            OnTokenGrant = null,
            OnTokenRefresh = null,
        };

        model.Validate();
    }
}
