using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using ArcadeDotnet.Models.Admin.AuthProviders;

namespace ArcadeDotnet.Tests.Models.Admin.AuthProviders;

public class AuthProviderCreateParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new AuthProviderCreateParams
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
                    RequestContentType = RequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType = ResponseContentType.ApplicationXWwwFormUrlencoded,
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
                        RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
                ScopeDelimiter = ScopeDelimiter.Undefined,
                TokenIntrospectionRequest = new()
                {
                    Endpoint = "endpoint",
                    Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType =
                        TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded,
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
                        TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
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
                        UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                    ResponseContentType =
                        UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
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
        Oauth2 expectedOauth2 = new()
        {
            ClientID = "client_id",
            AuthorizeRequest = new()
            {
                Endpoint = "endpoint",
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType = RequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType = ResponseContentType.ApplicationXWwwFormUrlencoded,
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
                RequestContentType = RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ScopeDelimiter = ScopeDelimiter.Undefined,
            TokenIntrospectionRequest = new()
            {
                Endpoint = "endpoint",
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            TokenRequest = new()
            {
                Endpoint = "endpoint",
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType = TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType = TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
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
                    UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
        };
        string expectedProviderID = "provider_id";
        string expectedStatus = "status";
        string expectedType = "type";

        Assert.Equal(expectedID, parameters.ID);
        Assert.Equal(expectedDescription, parameters.Description);
        Assert.Equal(expectedExternalID, parameters.ExternalID);
        Assert.Equal(expectedOauth2, parameters.Oauth2);
        Assert.Equal(expectedProviderID, parameters.ProviderID);
        Assert.Equal(expectedStatus, parameters.Status);
        Assert.Equal(expectedType, parameters.Type);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new AuthProviderCreateParams { ID = "id" };

        Assert.Null(parameters.Description);
        Assert.False(parameters.RawBodyData.ContainsKey("description"));
        Assert.Null(parameters.ExternalID);
        Assert.False(parameters.RawBodyData.ContainsKey("external_id"));
        Assert.Null(parameters.Oauth2);
        Assert.False(parameters.RawBodyData.ContainsKey("oauth2"));
        Assert.Null(parameters.ProviderID);
        Assert.False(parameters.RawBodyData.ContainsKey("provider_id"));
        Assert.Null(parameters.Status);
        Assert.False(parameters.RawBodyData.ContainsKey("status"));
        Assert.Null(parameters.Type);
        Assert.False(parameters.RawBodyData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new AuthProviderCreateParams
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

        Assert.Null(parameters.Description);
        Assert.False(parameters.RawBodyData.ContainsKey("description"));
        Assert.Null(parameters.ExternalID);
        Assert.False(parameters.RawBodyData.ContainsKey("external_id"));
        Assert.Null(parameters.Oauth2);
        Assert.False(parameters.RawBodyData.ContainsKey("oauth2"));
        Assert.Null(parameters.ProviderID);
        Assert.False(parameters.RawBodyData.ContainsKey("provider_id"));
        Assert.Null(parameters.Status);
        Assert.False(parameters.RawBodyData.ContainsKey("status"));
        Assert.Null(parameters.Type);
        Assert.False(parameters.RawBodyData.ContainsKey("type"));
    }
}

public class Oauth2Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Oauth2
        {
            ClientID = "client_id",
            AuthorizeRequest = new()
            {
                Endpoint = "endpoint",
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType = RequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType = ResponseContentType.ApplicationXWwwFormUrlencoded,
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
                RequestContentType = RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ScopeDelimiter = ScopeDelimiter.Undefined,
            TokenIntrospectionRequest = new()
            {
                Endpoint = "endpoint",
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            TokenRequest = new()
            {
                Endpoint = "endpoint",
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType = TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType = TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
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
                    UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
        };

        string expectedClientID = "client_id";
        AuthorizeRequest expectedAuthorizeRequest = new()
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType = RequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType = ResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };
        string expectedClientSecret = "client_secret";
        Pkce expectedPkce = new() { CodeChallengeMethod = "code_challenge_method", Enabled = true };
        RefreshRequest expectedRefreshRequest = new()
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType = RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType = RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };
        ApiEnum<string, ScopeDelimiter> expectedScopeDelimiter = ScopeDelimiter.Undefined;
        TokenIntrospectionRequest expectedTokenIntrospectionRequest = new()
        {
            Endpoint = "endpoint",
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };
        TokenRequest expectedTokenRequest = new()
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType = TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType = TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };
        UserInfoRequest expectedUserInfoRequest = new()
        {
            Endpoint = "endpoint",
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType = UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType = UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
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
        var model = new Oauth2
        {
            ClientID = "client_id",
            AuthorizeRequest = new()
            {
                Endpoint = "endpoint",
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType = RequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType = ResponseContentType.ApplicationXWwwFormUrlencoded,
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
                RequestContentType = RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ScopeDelimiter = ScopeDelimiter.Undefined,
            TokenIntrospectionRequest = new()
            {
                Endpoint = "endpoint",
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            TokenRequest = new()
            {
                Endpoint = "endpoint",
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType = TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType = TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
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
                    UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Oauth2>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Oauth2
        {
            ClientID = "client_id",
            AuthorizeRequest = new()
            {
                Endpoint = "endpoint",
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType = RequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType = ResponseContentType.ApplicationXWwwFormUrlencoded,
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
                RequestContentType = RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ScopeDelimiter = ScopeDelimiter.Undefined,
            TokenIntrospectionRequest = new()
            {
                Endpoint = "endpoint",
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            TokenRequest = new()
            {
                Endpoint = "endpoint",
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType = TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType = TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
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
                    UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Oauth2>(element);
        Assert.NotNull(deserialized);

        string expectedClientID = "client_id";
        AuthorizeRequest expectedAuthorizeRequest = new()
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType = RequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType = ResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };
        string expectedClientSecret = "client_secret";
        Pkce expectedPkce = new() { CodeChallengeMethod = "code_challenge_method", Enabled = true };
        RefreshRequest expectedRefreshRequest = new()
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType = RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType = RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };
        ApiEnum<string, ScopeDelimiter> expectedScopeDelimiter = ScopeDelimiter.Undefined;
        TokenIntrospectionRequest expectedTokenIntrospectionRequest = new()
        {
            Endpoint = "endpoint",
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };
        TokenRequest expectedTokenRequest = new()
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType = TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType = TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };
        UserInfoRequest expectedUserInfoRequest = new()
        {
            Endpoint = "endpoint",
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType = UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType = UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
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
        var model = new Oauth2
        {
            ClientID = "client_id",
            AuthorizeRequest = new()
            {
                Endpoint = "endpoint",
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType = RequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType = ResponseContentType.ApplicationXWwwFormUrlencoded,
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
                RequestContentType = RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ScopeDelimiter = ScopeDelimiter.Undefined,
            TokenIntrospectionRequest = new()
            {
                Endpoint = "endpoint",
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            TokenRequest = new()
            {
                Endpoint = "endpoint",
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType = TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType = TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
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
                    UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Oauth2 { ClientID = "client_id" };

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
        var model = new Oauth2 { ClientID = "client_id" };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Oauth2
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
        var model = new Oauth2
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

public class AuthorizeRequestTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthorizeRequest
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType = RequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType = ResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string expectedEndpoint = "endpoint";
        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<string, RequestContentType> expectedRequestContentType =
            RequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<string, ResponseContentType> expectedResponseContentType =
            ResponseContentType.ApplicationXWwwFormUrlencoded;
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedEndpoint, model.Endpoint);
        Assert.Equal(expectedAuthHeaderValueFormat, model.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, model.AuthMethod);
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
        var model = new AuthorizeRequest
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType = RequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType = ResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthorizeRequest>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AuthorizeRequest
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType = RequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType = ResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthorizeRequest>(element);
        Assert.NotNull(deserialized);

        string expectedEndpoint = "endpoint";
        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<string, RequestContentType> expectedRequestContentType =
            RequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<string, ResponseContentType> expectedResponseContentType =
            ResponseContentType.ApplicationXWwwFormUrlencoded;
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedEndpoint, deserialized.Endpoint);
        Assert.Equal(expectedAuthHeaderValueFormat, deserialized.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, deserialized.AuthMethod);
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
        var model = new AuthorizeRequest
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType = RequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType = ResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthorizeRequest { Endpoint = "endpoint" };

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
        var model = new AuthorizeRequest { Endpoint = "endpoint" };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthorizeRequest
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
        var model = new AuthorizeRequest
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

public class RequestContentTypeTest : TestBase
{
    [Theory]
    [InlineData(RequestContentType.ApplicationXWwwFormUrlencoded)]
    [InlineData(RequestContentType.ApplicationJson)]
    public void Validation_Works(RequestContentType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, RequestContentType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, RequestContentType>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(RequestContentType.ApplicationXWwwFormUrlencoded)]
    [InlineData(RequestContentType.ApplicationJson)]
    public void SerializationRoundtrip_Works(RequestContentType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, RequestContentType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, RequestContentType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, RequestContentType>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, RequestContentType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class ResponseContentTypeTest : TestBase
{
    [Theory]
    [InlineData(ResponseContentType.ApplicationXWwwFormUrlencoded)]
    [InlineData(ResponseContentType.ApplicationJson)]
    public void Validation_Works(ResponseContentType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ResponseContentType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, ResponseContentType>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(ResponseContentType.ApplicationXWwwFormUrlencoded)]
    [InlineData(ResponseContentType.ApplicationJson)]
    public void SerializationRoundtrip_Works(ResponseContentType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ResponseContentType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, ResponseContentType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, ResponseContentType>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, ResponseContentType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class PkceTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Pkce { CodeChallengeMethod = "code_challenge_method", Enabled = true };

        string expectedCodeChallengeMethod = "code_challenge_method";
        bool expectedEnabled = true;

        Assert.Equal(expectedCodeChallengeMethod, model.CodeChallengeMethod);
        Assert.Equal(expectedEnabled, model.Enabled);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Pkce { CodeChallengeMethod = "code_challenge_method", Enabled = true };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Pkce>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Pkce { CodeChallengeMethod = "code_challenge_method", Enabled = true };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Pkce>(element);
        Assert.NotNull(deserialized);

        string expectedCodeChallengeMethod = "code_challenge_method";
        bool expectedEnabled = true;

        Assert.Equal(expectedCodeChallengeMethod, deserialized.CodeChallengeMethod);
        Assert.Equal(expectedEnabled, deserialized.Enabled);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Pkce { CodeChallengeMethod = "code_challenge_method", Enabled = true };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Pkce { };

        Assert.Null(model.CodeChallengeMethod);
        Assert.False(model.RawData.ContainsKey("code_challenge_method"));
        Assert.Null(model.Enabled);
        Assert.False(model.RawData.ContainsKey("enabled"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Pkce { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Pkce
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
        var model = new Pkce
        {
            // Null should be interpreted as omitted for these properties
            CodeChallengeMethod = null,
            Enabled = null,
        };

        model.Validate();
    }
}

public class RefreshRequestTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new RefreshRequest
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType = RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType = RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string expectedEndpoint = "endpoint";
        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<string, RefreshRequestRequestContentType> expectedRequestContentType =
            RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<string, RefreshRequestResponseContentType> expectedResponseContentType =
            RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded;
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedEndpoint, model.Endpoint);
        Assert.Equal(expectedAuthHeaderValueFormat, model.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, model.AuthMethod);
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
        var model = new RefreshRequest
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType = RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType = RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<RefreshRequest>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new RefreshRequest
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType = RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType = RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<RefreshRequest>(element);
        Assert.NotNull(deserialized);

        string expectedEndpoint = "endpoint";
        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<string, RefreshRequestRequestContentType> expectedRequestContentType =
            RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<string, RefreshRequestResponseContentType> expectedResponseContentType =
            RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded;
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedEndpoint, deserialized.Endpoint);
        Assert.Equal(expectedAuthHeaderValueFormat, deserialized.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, deserialized.AuthMethod);
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
        var model = new RefreshRequest
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType = RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType = RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new RefreshRequest { Endpoint = "endpoint" };

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
        var model = new RefreshRequest { Endpoint = "endpoint" };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new RefreshRequest
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
        var model = new RefreshRequest
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

public class RefreshRequestRequestContentTypeTest : TestBase
{
    [Theory]
    [InlineData(RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded)]
    [InlineData(RefreshRequestRequestContentType.ApplicationJson)]
    public void Validation_Works(RefreshRequestRequestContentType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, RefreshRequestRequestContentType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, RefreshRequestRequestContentType>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(RefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded)]
    [InlineData(RefreshRequestRequestContentType.ApplicationJson)]
    public void SerializationRoundtrip_Works(RefreshRequestRequestContentType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, RefreshRequestRequestContentType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, RefreshRequestRequestContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, RefreshRequestRequestContentType>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, RefreshRequestRequestContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class RefreshRequestResponseContentTypeTest : TestBase
{
    [Theory]
    [InlineData(RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded)]
    [InlineData(RefreshRequestResponseContentType.ApplicationJson)]
    public void Validation_Works(RefreshRequestResponseContentType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, RefreshRequestResponseContentType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, RefreshRequestResponseContentType>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(RefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded)]
    [InlineData(RefreshRequestResponseContentType.ApplicationJson)]
    public void SerializationRoundtrip_Works(RefreshRequestResponseContentType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, RefreshRequestResponseContentType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, RefreshRequestResponseContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, RefreshRequestResponseContentType>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, RefreshRequestResponseContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class ScopeDelimiterTest : TestBase
{
    [Theory]
    [InlineData(ScopeDelimiter.Undefined)]
    [InlineData(ScopeDelimiter.V1)]
    public void Validation_Works(ScopeDelimiter rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ScopeDelimiter> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, ScopeDelimiter>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(ScopeDelimiter.Undefined)]
    [InlineData(ScopeDelimiter.V1)]
    public void SerializationRoundtrip_Works(ScopeDelimiter rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ScopeDelimiter> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, ScopeDelimiter>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, ScopeDelimiter>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, ScopeDelimiter>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class TokenIntrospectionRequestTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new TokenIntrospectionRequest
        {
            Endpoint = "endpoint",
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string expectedEndpoint = "endpoint";
        Triggers expectedTriggers = new() { OnTokenGrant = true, OnTokenRefresh = true };
        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<string, TokenIntrospectionRequestRequestContentType> expectedRequestContentType =
            TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<string, TokenIntrospectionRequestResponseContentType> expectedResponseContentType =
            TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded;
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedEndpoint, model.Endpoint);
        Assert.Equal(expectedTriggers, model.Triggers);
        Assert.Equal(expectedAuthHeaderValueFormat, model.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, model.AuthMethod);
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
        var model = new TokenIntrospectionRequest
        {
            Endpoint = "endpoint",
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<TokenIntrospectionRequest>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new TokenIntrospectionRequest
        {
            Endpoint = "endpoint",
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<TokenIntrospectionRequest>(element);
        Assert.NotNull(deserialized);

        string expectedEndpoint = "endpoint";
        Triggers expectedTriggers = new() { OnTokenGrant = true, OnTokenRefresh = true };
        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<string, TokenIntrospectionRequestRequestContentType> expectedRequestContentType =
            TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<string, TokenIntrospectionRequestResponseContentType> expectedResponseContentType =
            TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded;
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedEndpoint, deserialized.Endpoint);
        Assert.Equal(expectedTriggers, deserialized.Triggers);
        Assert.Equal(expectedAuthHeaderValueFormat, deserialized.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, deserialized.AuthMethod);
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
        var model = new TokenIntrospectionRequest
        {
            Endpoint = "endpoint",
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new TokenIntrospectionRequest
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
        var model = new TokenIntrospectionRequest
        {
            Endpoint = "endpoint",
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new TokenIntrospectionRequest
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
        var model = new TokenIntrospectionRequest
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

public class TriggersTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Triggers { OnTokenGrant = true, OnTokenRefresh = true };

        bool expectedOnTokenGrant = true;
        bool expectedOnTokenRefresh = true;

        Assert.Equal(expectedOnTokenGrant, model.OnTokenGrant);
        Assert.Equal(expectedOnTokenRefresh, model.OnTokenRefresh);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Triggers { OnTokenGrant = true, OnTokenRefresh = true };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Triggers>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Triggers { OnTokenGrant = true, OnTokenRefresh = true };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Triggers>(element);
        Assert.NotNull(deserialized);

        bool expectedOnTokenGrant = true;
        bool expectedOnTokenRefresh = true;

        Assert.Equal(expectedOnTokenGrant, deserialized.OnTokenGrant);
        Assert.Equal(expectedOnTokenRefresh, deserialized.OnTokenRefresh);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Triggers { OnTokenGrant = true, OnTokenRefresh = true };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Triggers { };

        Assert.Null(model.OnTokenGrant);
        Assert.False(model.RawData.ContainsKey("on_token_grant"));
        Assert.Null(model.OnTokenRefresh);
        Assert.False(model.RawData.ContainsKey("on_token_refresh"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Triggers { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Triggers
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
        var model = new Triggers
        {
            // Null should be interpreted as omitted for these properties
            OnTokenGrant = null,
            OnTokenRefresh = null,
        };

        model.Validate();
    }
}

public class TokenIntrospectionRequestRequestContentTypeTest : TestBase
{
    [Theory]
    [InlineData(TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded)]
    [InlineData(TokenIntrospectionRequestRequestContentType.ApplicationJson)]
    public void Validation_Works(TokenIntrospectionRequestRequestContentType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, TokenIntrospectionRequestRequestContentType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, TokenIntrospectionRequestRequestContentType>
        >(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(TokenIntrospectionRequestRequestContentType.ApplicationXWwwFormUrlencoded)]
    [InlineData(TokenIntrospectionRequestRequestContentType.ApplicationJson)]
    public void SerializationRoundtrip_Works(TokenIntrospectionRequestRequestContentType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, TokenIntrospectionRequestRequestContentType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, TokenIntrospectionRequestRequestContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, TokenIntrospectionRequestRequestContentType>
        >(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, TokenIntrospectionRequestRequestContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class TokenIntrospectionRequestResponseContentTypeTest : TestBase
{
    [Theory]
    [InlineData(TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded)]
    [InlineData(TokenIntrospectionRequestResponseContentType.ApplicationJson)]
    public void Validation_Works(TokenIntrospectionRequestResponseContentType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, TokenIntrospectionRequestResponseContentType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, TokenIntrospectionRequestResponseContentType>
        >(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(TokenIntrospectionRequestResponseContentType.ApplicationXWwwFormUrlencoded)]
    [InlineData(TokenIntrospectionRequestResponseContentType.ApplicationJson)]
    public void SerializationRoundtrip_Works(TokenIntrospectionRequestResponseContentType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, TokenIntrospectionRequestResponseContentType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, TokenIntrospectionRequestResponseContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, TokenIntrospectionRequestResponseContentType>
        >(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, TokenIntrospectionRequestResponseContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class TokenRequestTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new TokenRequest
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType = TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType = TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string expectedEndpoint = "endpoint";
        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<string, TokenRequestRequestContentType> expectedRequestContentType =
            TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<string, TokenRequestResponseContentType> expectedResponseContentType =
            TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded;
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedEndpoint, model.Endpoint);
        Assert.Equal(expectedAuthHeaderValueFormat, model.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, model.AuthMethod);
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
        var model = new TokenRequest
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType = TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType = TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<TokenRequest>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new TokenRequest
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType = TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType = TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<TokenRequest>(element);
        Assert.NotNull(deserialized);

        string expectedEndpoint = "endpoint";
        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<string, TokenRequestRequestContentType> expectedRequestContentType =
            TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<string, TokenRequestResponseContentType> expectedResponseContentType =
            TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded;
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedEndpoint, deserialized.Endpoint);
        Assert.Equal(expectedAuthHeaderValueFormat, deserialized.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, deserialized.AuthMethod);
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
        var model = new TokenRequest
        {
            Endpoint = "endpoint",
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType = TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType = TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new TokenRequest { Endpoint = "endpoint" };

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
        var model = new TokenRequest { Endpoint = "endpoint" };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new TokenRequest
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
        var model = new TokenRequest
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

public class TokenRequestRequestContentTypeTest : TestBase
{
    [Theory]
    [InlineData(TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded)]
    [InlineData(TokenRequestRequestContentType.ApplicationJson)]
    public void Validation_Works(TokenRequestRequestContentType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, TokenRequestRequestContentType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, TokenRequestRequestContentType>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(TokenRequestRequestContentType.ApplicationXWwwFormUrlencoded)]
    [InlineData(TokenRequestRequestContentType.ApplicationJson)]
    public void SerializationRoundtrip_Works(TokenRequestRequestContentType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, TokenRequestRequestContentType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, TokenRequestRequestContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, TokenRequestRequestContentType>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, TokenRequestRequestContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class TokenRequestResponseContentTypeTest : TestBase
{
    [Theory]
    [InlineData(TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded)]
    [InlineData(TokenRequestResponseContentType.ApplicationJson)]
    public void Validation_Works(TokenRequestResponseContentType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, TokenRequestResponseContentType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, TokenRequestResponseContentType>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(TokenRequestResponseContentType.ApplicationXWwwFormUrlencoded)]
    [InlineData(TokenRequestResponseContentType.ApplicationJson)]
    public void SerializationRoundtrip_Works(TokenRequestResponseContentType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, TokenRequestResponseContentType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, TokenRequestResponseContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, TokenRequestResponseContentType>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, TokenRequestResponseContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class UserInfoRequestTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new UserInfoRequest
        {
            Endpoint = "endpoint",
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType = UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType = UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string expectedEndpoint = "endpoint";
        UserInfoRequestTriggers expectedTriggers = new()
        {
            OnTokenGrant = true,
            OnTokenRefresh = true,
        };
        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<string, UserInfoRequestRequestContentType> expectedRequestContentType =
            UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<string, UserInfoRequestResponseContentType> expectedResponseContentType =
            UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded;
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedEndpoint, model.Endpoint);
        Assert.Equal(expectedTriggers, model.Triggers);
        Assert.Equal(expectedAuthHeaderValueFormat, model.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, model.AuthMethod);
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
        var model = new UserInfoRequest
        {
            Endpoint = "endpoint",
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType = UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType = UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<UserInfoRequest>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new UserInfoRequest
        {
            Endpoint = "endpoint",
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType = UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType = UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<UserInfoRequest>(element);
        Assert.NotNull(deserialized);

        string expectedEndpoint = "endpoint";
        UserInfoRequestTriggers expectedTriggers = new()
        {
            OnTokenGrant = true,
            OnTokenRefresh = true,
        };
        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<string, UserInfoRequestRequestContentType> expectedRequestContentType =
            UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<string, UserInfoRequestResponseContentType> expectedResponseContentType =
            UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded;
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedEndpoint, deserialized.Endpoint);
        Assert.Equal(expectedTriggers, deserialized.Triggers);
        Assert.Equal(expectedAuthHeaderValueFormat, deserialized.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, deserialized.AuthMethod);
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
        var model = new UserInfoRequest
        {
            Endpoint = "endpoint",
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType = UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType = UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new UserInfoRequest
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
        var model = new UserInfoRequest
        {
            Endpoint = "endpoint",
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new UserInfoRequest
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
        var model = new UserInfoRequest
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

public class UserInfoRequestTriggersTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new UserInfoRequestTriggers { OnTokenGrant = true, OnTokenRefresh = true };

        bool expectedOnTokenGrant = true;
        bool expectedOnTokenRefresh = true;

        Assert.Equal(expectedOnTokenGrant, model.OnTokenGrant);
        Assert.Equal(expectedOnTokenRefresh, model.OnTokenRefresh);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new UserInfoRequestTriggers { OnTokenGrant = true, OnTokenRefresh = true };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<UserInfoRequestTriggers>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new UserInfoRequestTriggers { OnTokenGrant = true, OnTokenRefresh = true };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<UserInfoRequestTriggers>(element);
        Assert.NotNull(deserialized);

        bool expectedOnTokenGrant = true;
        bool expectedOnTokenRefresh = true;

        Assert.Equal(expectedOnTokenGrant, deserialized.OnTokenGrant);
        Assert.Equal(expectedOnTokenRefresh, deserialized.OnTokenRefresh);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new UserInfoRequestTriggers { OnTokenGrant = true, OnTokenRefresh = true };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new UserInfoRequestTriggers { };

        Assert.Null(model.OnTokenGrant);
        Assert.False(model.RawData.ContainsKey("on_token_grant"));
        Assert.Null(model.OnTokenRefresh);
        Assert.False(model.RawData.ContainsKey("on_token_refresh"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new UserInfoRequestTriggers { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new UserInfoRequestTriggers
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
        var model = new UserInfoRequestTriggers
        {
            // Null should be interpreted as omitted for these properties
            OnTokenGrant = null,
            OnTokenRefresh = null,
        };

        model.Validate();
    }
}

public class UserInfoRequestRequestContentTypeTest : TestBase
{
    [Theory]
    [InlineData(UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded)]
    [InlineData(UserInfoRequestRequestContentType.ApplicationJson)]
    public void Validation_Works(UserInfoRequestRequestContentType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, UserInfoRequestRequestContentType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, UserInfoRequestRequestContentType>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(UserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded)]
    [InlineData(UserInfoRequestRequestContentType.ApplicationJson)]
    public void SerializationRoundtrip_Works(UserInfoRequestRequestContentType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, UserInfoRequestRequestContentType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, UserInfoRequestRequestContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, UserInfoRequestRequestContentType>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, UserInfoRequestRequestContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class UserInfoRequestResponseContentTypeTest : TestBase
{
    [Theory]
    [InlineData(UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded)]
    [InlineData(UserInfoRequestResponseContentType.ApplicationJson)]
    public void Validation_Works(UserInfoRequestResponseContentType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, UserInfoRequestResponseContentType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, UserInfoRequestResponseContentType>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(UserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded)]
    [InlineData(UserInfoRequestResponseContentType.ApplicationJson)]
    public void SerializationRoundtrip_Works(UserInfoRequestResponseContentType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, UserInfoRequestResponseContentType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, UserInfoRequestResponseContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, UserInfoRequestResponseContentType>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, UserInfoRequestResponseContentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}
