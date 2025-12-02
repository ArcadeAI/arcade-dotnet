using System.Collections.Generic;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Admin.AuthProviders;

namespace ArcadeDotnet.Tests.Models.Admin.AuthProviders;

public class AuthProviderResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthProviderResponse
        {
            ID = "id",
            Binding = new() { ID = "id", Type = Type.Static },
            CreatedAt = "created_at",
            Description = "description",
            Oauth2 = new()
            {
                AuthorizeRequest = new()
                {
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Endpoint = "endpoint",
                    ExpirationFormat = "expiration_format",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType = "request_content_type",
                    ResponseContentType = "response_content_type",
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
                ClientID = "client_id",
                ClientSecret = new()
                {
                    Binding = ClientSecretBinding.Static,
                    Editable = true,
                    Exists = true,
                    Hint = "hint",
                    Value = "value",
                },
                Pkce = new() { CodeChallengeMethod = "code_challenge_method", Enabled = true },
                RedirectUri = "redirect_uri",
                RefreshRequest = new()
                {
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Endpoint = "endpoint",
                    ExpirationFormat = "expiration_format",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType = "request_content_type",
                    ResponseContentType = "response_content_type",
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
                ScopeDelimiter = "scope_delimiter",
                TokenIntrospectionRequest = new()
                {
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Enabled = true,
                    Endpoint = "endpoint",
                    ExpirationFormat = "expiration_format",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType = "request_content_type",
                    ResponseContentType = "response_content_type",
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                    Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
                },
                TokenRequest = new()
                {
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Endpoint = "endpoint",
                    ExpirationFormat = "expiration_format",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType = "request_content_type",
                    ResponseContentType = "response_content_type",
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                },
                UserInfoRequest = new()
                {
                    AuthHeaderValueFormat = "auth_header_value_format",
                    AuthMethod = "auth_method",
                    Endpoint = "endpoint",
                    ExpirationFormat = "expiration_format",
                    Method = "method",
                    Params = new Dictionary<string, string>() { { "foo", "string" } },
                    RequestContentType = "request_content_type",
                    ResponseContentType = "response_content_type",
                    ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                    Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
                },
            },
            ProviderID = "provider_id",
            Status = "status",
            Type = "type",
            UpdatedAt = "updated_at",
        };

        string expectedID = "id";
        Binding expectedBinding = new() { ID = "id", Type = Type.Static };
        string expectedCreatedAt = "created_at";
        string expectedDescription = "description";
        AuthProviderResponseOauth2 expectedOauth2 = new()
        {
            AuthorizeRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                ExpirationFormat = "expiration_format",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType = "request_content_type",
                ResponseContentType = "response_content_type",
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ClientID = "client_id",
            ClientSecret = new()
            {
                Binding = ClientSecretBinding.Static,
                Editable = true,
                Exists = true,
                Hint = "hint",
                Value = "value",
            },
            Pkce = new() { CodeChallengeMethod = "code_challenge_method", Enabled = true },
            RedirectUri = "redirect_uri",
            RefreshRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                ExpirationFormat = "expiration_format",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType = "request_content_type",
                ResponseContentType = "response_content_type",
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ScopeDelimiter = "scope_delimiter",
            TokenIntrospectionRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Enabled = true,
                Endpoint = "endpoint",
                ExpirationFormat = "expiration_format",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType = "request_content_type",
                ResponseContentType = "response_content_type",
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            },
            TokenRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                ExpirationFormat = "expiration_format",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType = "request_content_type",
                ResponseContentType = "response_content_type",
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            UserInfoRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                ExpirationFormat = "expiration_format",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType = "request_content_type",
                ResponseContentType = "response_content_type",
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            },
        };
        string expectedProviderID = "provider_id";
        string expectedStatus = "status";
        string expectedType = "type";
        string expectedUpdatedAt = "updated_at";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedBinding, model.Binding);
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedOauth2, model.Oauth2);
        Assert.Equal(expectedProviderID, model.ProviderID);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedType, model.Type);
        Assert.Equal(expectedUpdatedAt, model.UpdatedAt);
    }
}

public class BindingTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Binding { ID = "id", Type = Type.Static };

        string expectedID = "id";
        ApiEnum<string, Type> expectedType = Type.Static;

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedType, model.Type);
    }
}

public class AuthProviderResponseOauth2Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthProviderResponseOauth2
        {
            AuthorizeRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                ExpirationFormat = "expiration_format",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType = "request_content_type",
                ResponseContentType = "response_content_type",
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ClientID = "client_id",
            ClientSecret = new()
            {
                Binding = ClientSecretBinding.Static,
                Editable = true,
                Exists = true,
                Hint = "hint",
                Value = "value",
            },
            Pkce = new() { CodeChallengeMethod = "code_challenge_method", Enabled = true },
            RedirectUri = "redirect_uri",
            RefreshRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                ExpirationFormat = "expiration_format",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType = "request_content_type",
                ResponseContentType = "response_content_type",
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ScopeDelimiter = "scope_delimiter",
            TokenIntrospectionRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Enabled = true,
                Endpoint = "endpoint",
                ExpirationFormat = "expiration_format",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType = "request_content_type",
                ResponseContentType = "response_content_type",
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            },
            TokenRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                ExpirationFormat = "expiration_format",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType = "request_content_type",
                ResponseContentType = "response_content_type",
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            UserInfoRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                ExpirationFormat = "expiration_format",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType = "request_content_type",
                ResponseContentType = "response_content_type",
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            },
        };

        AuthProviderResponseOauth2AuthorizeRequest expectedAuthorizeRequest = new()
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            ExpirationFormat = "expiration_format",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType = "request_content_type",
            ResponseContentType = "response_content_type",
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };
        string expectedClientID = "client_id";
        ClientSecret expectedClientSecret = new()
        {
            Binding = ClientSecretBinding.Static,
            Editable = true,
            Exists = true,
            Hint = "hint",
            Value = "value",
        };
        AuthProviderResponseOauth2Pkce expectedPkce = new()
        {
            CodeChallengeMethod = "code_challenge_method",
            Enabled = true,
        };
        string expectedRedirectUri = "redirect_uri";
        AuthProviderResponseOauth2RefreshRequest expectedRefreshRequest = new()
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            ExpirationFormat = "expiration_format",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType = "request_content_type",
            ResponseContentType = "response_content_type",
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };
        string expectedScopeDelimiter = "scope_delimiter";
        AuthProviderResponseOauth2TokenIntrospectionRequest expectedTokenIntrospectionRequest =
            new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Enabled = true,
                Endpoint = "endpoint",
                ExpirationFormat = "expiration_format",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType = "request_content_type",
                ResponseContentType = "response_content_type",
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            };
        AuthProviderResponseOauth2TokenRequest expectedTokenRequest = new()
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            ExpirationFormat = "expiration_format",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType = "request_content_type",
            ResponseContentType = "response_content_type",
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };
        AuthProviderResponseOauth2UserInfoRequest expectedUserInfoRequest = new()
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            ExpirationFormat = "expiration_format",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType = "request_content_type",
            ResponseContentType = "response_content_type",
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
        };

        Assert.Equal(expectedAuthorizeRequest, model.AuthorizeRequest);
        Assert.Equal(expectedClientID, model.ClientID);
        Assert.Equal(expectedClientSecret, model.ClientSecret);
        Assert.Equal(expectedPkce, model.Pkce);
        Assert.Equal(expectedRedirectUri, model.RedirectUri);
        Assert.Equal(expectedRefreshRequest, model.RefreshRequest);
        Assert.Equal(expectedScopeDelimiter, model.ScopeDelimiter);
        Assert.Equal(expectedTokenIntrospectionRequest, model.TokenIntrospectionRequest);
        Assert.Equal(expectedTokenRequest, model.TokenRequest);
        Assert.Equal(expectedUserInfoRequest, model.UserInfoRequest);
    }
}

public class AuthProviderResponseOauth2AuthorizeRequestTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthProviderResponseOauth2AuthorizeRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            ExpirationFormat = "expiration_format",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType = "request_content_type",
            ResponseContentType = "response_content_type",
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedEndpoint = "endpoint";
        string expectedExpirationFormat = "expiration_format";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        string expectedRequestContentType = "request_content_type";
        string expectedResponseContentType = "response_content_type";
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedAuthHeaderValueFormat, model.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, model.AuthMethod);
        Assert.Equal(expectedEndpoint, model.Endpoint);
        Assert.Equal(expectedExpirationFormat, model.ExpirationFormat);
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

public class ClientSecretTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ClientSecret
        {
            Binding = ClientSecretBinding.Static,
            Editable = true,
            Exists = true,
            Hint = "hint",
            Value = "value",
        };

        ApiEnum<string, ClientSecretBinding> expectedBinding = ClientSecretBinding.Static;
        bool expectedEditable = true;
        bool expectedExists = true;
        string expectedHint = "hint";
        string expectedValue = "value";

        Assert.Equal(expectedBinding, model.Binding);
        Assert.Equal(expectedEditable, model.Editable);
        Assert.Equal(expectedExists, model.Exists);
        Assert.Equal(expectedHint, model.Hint);
        Assert.Equal(expectedValue, model.Value);
    }
}

public class AuthProviderResponseOauth2PkceTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthProviderResponseOauth2Pkce
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

public class AuthProviderResponseOauth2RefreshRequestTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthProviderResponseOauth2RefreshRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            ExpirationFormat = "expiration_format",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType = "request_content_type",
            ResponseContentType = "response_content_type",
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedEndpoint = "endpoint";
        string expectedExpirationFormat = "expiration_format";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        string expectedRequestContentType = "request_content_type";
        string expectedResponseContentType = "response_content_type";
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedAuthHeaderValueFormat, model.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, model.AuthMethod);
        Assert.Equal(expectedEndpoint, model.Endpoint);
        Assert.Equal(expectedExpirationFormat, model.ExpirationFormat);
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

public class AuthProviderResponseOauth2TokenIntrospectionRequestTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthProviderResponseOauth2TokenIntrospectionRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Enabled = true,
            Endpoint = "endpoint",
            ExpirationFormat = "expiration_format",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType = "request_content_type",
            ResponseContentType = "response_content_type",
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
        };

        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        bool expectedEnabled = true;
        string expectedEndpoint = "endpoint";
        string expectedExpirationFormat = "expiration_format";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        string expectedRequestContentType = "request_content_type";
        string expectedResponseContentType = "response_content_type";
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };
        AuthProviderResponseOauth2TokenIntrospectionRequestTriggers expectedTriggers = new()
        {
            OnTokenGrant = true,
            OnTokenRefresh = true,
        };

        Assert.Equal(expectedAuthHeaderValueFormat, model.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, model.AuthMethod);
        Assert.Equal(expectedEnabled, model.Enabled);
        Assert.Equal(expectedEndpoint, model.Endpoint);
        Assert.Equal(expectedExpirationFormat, model.ExpirationFormat);
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

public class AuthProviderResponseOauth2TokenIntrospectionRequestTriggersTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthProviderResponseOauth2TokenIntrospectionRequestTriggers
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

public class AuthProviderResponseOauth2TokenRequestTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthProviderResponseOauth2TokenRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            ExpirationFormat = "expiration_format",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType = "request_content_type",
            ResponseContentType = "response_content_type",
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedEndpoint = "endpoint";
        string expectedExpirationFormat = "expiration_format";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        string expectedRequestContentType = "request_content_type";
        string expectedResponseContentType = "response_content_type";
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedAuthHeaderValueFormat, model.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, model.AuthMethod);
        Assert.Equal(expectedEndpoint, model.Endpoint);
        Assert.Equal(expectedExpirationFormat, model.ExpirationFormat);
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

public class AuthProviderResponseOauth2UserInfoRequestTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthProviderResponseOauth2UserInfoRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            ExpirationFormat = "expiration_format",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType = "request_content_type",
            ResponseContentType = "response_content_type",
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
        };

        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedEndpoint = "endpoint";
        string expectedExpirationFormat = "expiration_format";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        string expectedRequestContentType = "request_content_type";
        string expectedResponseContentType = "response_content_type";
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };
        AuthProviderResponseOauth2UserInfoRequestTriggers expectedTriggers = new()
        {
            OnTokenGrant = true,
            OnTokenRefresh = true,
        };

        Assert.Equal(expectedAuthHeaderValueFormat, model.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, model.AuthMethod);
        Assert.Equal(expectedEndpoint, model.Endpoint);
        Assert.Equal(expectedExpirationFormat, model.ExpirationFormat);
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

public class AuthProviderResponseOauth2UserInfoRequestTriggersTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthProviderResponseOauth2UserInfoRequestTriggers
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
