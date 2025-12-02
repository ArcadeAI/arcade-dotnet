using System.Collections.Generic;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Admin.AuthProviders;

namespace ArcadeDotnet.Tests.Models.Admin.AuthProviders;

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
}
