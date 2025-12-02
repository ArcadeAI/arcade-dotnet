using System.Collections.Generic;
using ArcadeDotnet.Core;
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
}
