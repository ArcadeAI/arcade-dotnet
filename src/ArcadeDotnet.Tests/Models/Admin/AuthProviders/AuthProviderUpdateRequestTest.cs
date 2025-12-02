using System.Collections.Generic;
using ArcadeDotnet.Core;
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
        Assert.Equal(expectedTriggers, model.Triggers);
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
}
