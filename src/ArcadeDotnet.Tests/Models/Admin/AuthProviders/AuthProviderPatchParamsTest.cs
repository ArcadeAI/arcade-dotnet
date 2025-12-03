using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Admin.AuthProviders;

namespace ArcadeDotnet.Tests.Models.Admin.AuthProviders;

public class Oauth2ModelTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Oauth2Model
        {
            AuthorizeRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    Oauth2ModelAuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    Oauth2ModelAuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
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
                    Oauth2ModelRefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    Oauth2ModelRefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ScopeDelimiter = Oauth2ModelScopeDelimiter.Undefined,
            TokenRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    Oauth2ModelTokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    Oauth2ModelTokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
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
                    Oauth2ModelUserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    Oauth2ModelUserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            },
        };

        Oauth2ModelAuthorizeRequest expectedAuthorizeRequest = new()
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                Oauth2ModelAuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                Oauth2ModelAuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };
        string expectedClientID = "client_id";
        string expectedClientSecret = "client_secret";
        Oauth2ModelPkce expectedPkce = new()
        {
            CodeChallengeMethod = "code_challenge_method",
            Enabled = true,
        };
        Oauth2ModelRefreshRequest expectedRefreshRequest = new()
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                Oauth2ModelRefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                Oauth2ModelRefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };
        ApiEnum<string, Oauth2ModelScopeDelimiter> expectedScopeDelimiter =
            Oauth2ModelScopeDelimiter.Undefined;
        Oauth2ModelTokenRequest expectedTokenRequest = new()
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                Oauth2ModelTokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                Oauth2ModelTokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };
        Oauth2ModelUserInfoRequest expectedUserInfoRequest = new()
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                Oauth2ModelUserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                Oauth2ModelUserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
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
        var model = new Oauth2Model
        {
            AuthorizeRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    Oauth2ModelAuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    Oauth2ModelAuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
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
                    Oauth2ModelRefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    Oauth2ModelRefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ScopeDelimiter = Oauth2ModelScopeDelimiter.Undefined,
            TokenRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    Oauth2ModelTokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    Oauth2ModelTokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
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
                    Oauth2ModelUserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    Oauth2ModelUserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Oauth2Model>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Oauth2Model
        {
            AuthorizeRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    Oauth2ModelAuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    Oauth2ModelAuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
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
                    Oauth2ModelRefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    Oauth2ModelRefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ScopeDelimiter = Oauth2ModelScopeDelimiter.Undefined,
            TokenRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    Oauth2ModelTokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    Oauth2ModelTokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
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
                    Oauth2ModelUserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    Oauth2ModelUserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Oauth2Model>(json);
        Assert.NotNull(deserialized);

        Oauth2ModelAuthorizeRequest expectedAuthorizeRequest = new()
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                Oauth2ModelAuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                Oauth2ModelAuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };
        string expectedClientID = "client_id";
        string expectedClientSecret = "client_secret";
        Oauth2ModelPkce expectedPkce = new()
        {
            CodeChallengeMethod = "code_challenge_method",
            Enabled = true,
        };
        Oauth2ModelRefreshRequest expectedRefreshRequest = new()
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                Oauth2ModelRefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                Oauth2ModelRefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };
        ApiEnum<string, Oauth2ModelScopeDelimiter> expectedScopeDelimiter =
            Oauth2ModelScopeDelimiter.Undefined;
        Oauth2ModelTokenRequest expectedTokenRequest = new()
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                Oauth2ModelTokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                Oauth2ModelTokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };
        Oauth2ModelUserInfoRequest expectedUserInfoRequest = new()
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                Oauth2ModelUserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                Oauth2ModelUserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
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
        var model = new Oauth2Model
        {
            AuthorizeRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    Oauth2ModelAuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    Oauth2ModelAuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
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
                    Oauth2ModelRefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    Oauth2ModelRefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            },
            ScopeDelimiter = Oauth2ModelScopeDelimiter.Undefined,
            TokenRequest = new()
            {
                AuthHeaderValueFormat = "auth_header_value_format",
                AuthMethod = "auth_method",
                Endpoint = "endpoint",
                Method = "method",
                Params = new Dictionary<string, string>() { { "foo", "string" } },
                RequestContentType =
                    Oauth2ModelTokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    Oauth2ModelTokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
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
                    Oauth2ModelUserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
                ResponseContentType =
                    Oauth2ModelUserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
                ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
                Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Oauth2Model { };

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
        var model = new Oauth2Model { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Oauth2Model
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
        var model = new Oauth2Model
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

public class Oauth2ModelAuthorizeRequestTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Oauth2ModelAuthorizeRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                Oauth2ModelAuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                Oauth2ModelAuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedEndpoint = "endpoint";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<string, Oauth2ModelAuthorizeRequestRequestContentType> expectedRequestContentType =
            Oauth2ModelAuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<
            string,
            Oauth2ModelAuthorizeRequestResponseContentType
        > expectedResponseContentType =
            Oauth2ModelAuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded;
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

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Oauth2ModelAuthorizeRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                Oauth2ModelAuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                Oauth2ModelAuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Oauth2ModelAuthorizeRequest>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Oauth2ModelAuthorizeRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                Oauth2ModelAuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                Oauth2ModelAuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Oauth2ModelAuthorizeRequest>(json);
        Assert.NotNull(deserialized);

        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedEndpoint = "endpoint";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<string, Oauth2ModelAuthorizeRequestRequestContentType> expectedRequestContentType =
            Oauth2ModelAuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<
            string,
            Oauth2ModelAuthorizeRequestResponseContentType
        > expectedResponseContentType =
            Oauth2ModelAuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded;
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedAuthHeaderValueFormat, deserialized.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, deserialized.AuthMethod);
        Assert.Equal(expectedEndpoint, deserialized.Endpoint);
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
        var model = new Oauth2ModelAuthorizeRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                Oauth2ModelAuthorizeRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                Oauth2ModelAuthorizeRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Oauth2ModelAuthorizeRequest { };

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
        var model = new Oauth2ModelAuthorizeRequest { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Oauth2ModelAuthorizeRequest
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
        var model = new Oauth2ModelAuthorizeRequest
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

public class Oauth2ModelPkceTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Oauth2ModelPkce
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
        var model = new Oauth2ModelPkce
        {
            CodeChallengeMethod = "code_challenge_method",
            Enabled = true,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Oauth2ModelPkce>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Oauth2ModelPkce
        {
            CodeChallengeMethod = "code_challenge_method",
            Enabled = true,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Oauth2ModelPkce>(json);
        Assert.NotNull(deserialized);

        string expectedCodeChallengeMethod = "code_challenge_method";
        bool expectedEnabled = true;

        Assert.Equal(expectedCodeChallengeMethod, deserialized.CodeChallengeMethod);
        Assert.Equal(expectedEnabled, deserialized.Enabled);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Oauth2ModelPkce
        {
            CodeChallengeMethod = "code_challenge_method",
            Enabled = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Oauth2ModelPkce { };

        Assert.Null(model.CodeChallengeMethod);
        Assert.False(model.RawData.ContainsKey("code_challenge_method"));
        Assert.Null(model.Enabled);
        Assert.False(model.RawData.ContainsKey("enabled"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Oauth2ModelPkce { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Oauth2ModelPkce
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
        var model = new Oauth2ModelPkce
        {
            // Null should be interpreted as omitted for these properties
            CodeChallengeMethod = null,
            Enabled = null,
        };

        model.Validate();
    }
}

public class Oauth2ModelRefreshRequestTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Oauth2ModelRefreshRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                Oauth2ModelRefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                Oauth2ModelRefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedEndpoint = "endpoint";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<string, Oauth2ModelRefreshRequestRequestContentType> expectedRequestContentType =
            Oauth2ModelRefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<string, Oauth2ModelRefreshRequestResponseContentType> expectedResponseContentType =
            Oauth2ModelRefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded;
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

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Oauth2ModelRefreshRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                Oauth2ModelRefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                Oauth2ModelRefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Oauth2ModelRefreshRequest>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Oauth2ModelRefreshRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                Oauth2ModelRefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                Oauth2ModelRefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Oauth2ModelRefreshRequest>(json);
        Assert.NotNull(deserialized);

        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedEndpoint = "endpoint";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<string, Oauth2ModelRefreshRequestRequestContentType> expectedRequestContentType =
            Oauth2ModelRefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<string, Oauth2ModelRefreshRequestResponseContentType> expectedResponseContentType =
            Oauth2ModelRefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded;
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedAuthHeaderValueFormat, deserialized.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, deserialized.AuthMethod);
        Assert.Equal(expectedEndpoint, deserialized.Endpoint);
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
        var model = new Oauth2ModelRefreshRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                Oauth2ModelRefreshRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                Oauth2ModelRefreshRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Oauth2ModelRefreshRequest { };

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
        var model = new Oauth2ModelRefreshRequest { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Oauth2ModelRefreshRequest
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
        var model = new Oauth2ModelRefreshRequest
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

public class Oauth2ModelTokenRequestTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Oauth2ModelTokenRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                Oauth2ModelTokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                Oauth2ModelTokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedEndpoint = "endpoint";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<string, Oauth2ModelTokenRequestRequestContentType> expectedRequestContentType =
            Oauth2ModelTokenRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<string, Oauth2ModelTokenRequestResponseContentType> expectedResponseContentType =
            Oauth2ModelTokenRequestResponseContentType.ApplicationXWwwFormUrlencoded;
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

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Oauth2ModelTokenRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                Oauth2ModelTokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                Oauth2ModelTokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Oauth2ModelTokenRequest>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Oauth2ModelTokenRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                Oauth2ModelTokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                Oauth2ModelTokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Oauth2ModelTokenRequest>(json);
        Assert.NotNull(deserialized);

        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedEndpoint = "endpoint";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<string, Oauth2ModelTokenRequestRequestContentType> expectedRequestContentType =
            Oauth2ModelTokenRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<string, Oauth2ModelTokenRequestResponseContentType> expectedResponseContentType =
            Oauth2ModelTokenRequestResponseContentType.ApplicationXWwwFormUrlencoded;
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedAuthHeaderValueFormat, deserialized.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, deserialized.AuthMethod);
        Assert.Equal(expectedEndpoint, deserialized.Endpoint);
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
        var model = new Oauth2ModelTokenRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                Oauth2ModelTokenRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                Oauth2ModelTokenRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Oauth2ModelTokenRequest { };

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
        var model = new Oauth2ModelTokenRequest { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Oauth2ModelTokenRequest
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
        var model = new Oauth2ModelTokenRequest
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

public class Oauth2ModelUserInfoRequestTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Oauth2ModelUserInfoRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                Oauth2ModelUserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                Oauth2ModelUserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
        };

        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedEndpoint = "endpoint";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<string, Oauth2ModelUserInfoRequestRequestContentType> expectedRequestContentType =
            Oauth2ModelUserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<string, Oauth2ModelUserInfoRequestResponseContentType> expectedResponseContentType =
            Oauth2ModelUserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded;
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };
        Oauth2ModelUserInfoRequestTriggers expectedTriggers = new()
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

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Oauth2ModelUserInfoRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                Oauth2ModelUserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                Oauth2ModelUserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Oauth2ModelUserInfoRequest>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Oauth2ModelUserInfoRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                Oauth2ModelUserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                Oauth2ModelUserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Oauth2ModelUserInfoRequest>(json);
        Assert.NotNull(deserialized);

        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedEndpoint = "endpoint";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        ApiEnum<string, Oauth2ModelUserInfoRequestRequestContentType> expectedRequestContentType =
            Oauth2ModelUserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded;
        ApiEnum<string, Oauth2ModelUserInfoRequestResponseContentType> expectedResponseContentType =
            Oauth2ModelUserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded;
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };
        Oauth2ModelUserInfoRequestTriggers expectedTriggers = new()
        {
            OnTokenGrant = true,
            OnTokenRefresh = true,
        };

        Assert.Equal(expectedAuthHeaderValueFormat, deserialized.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, deserialized.AuthMethod);
        Assert.Equal(expectedEndpoint, deserialized.Endpoint);
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
        Assert.Equal(expectedTriggers, deserialized.Triggers);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Oauth2ModelUserInfoRequest
        {
            AuthHeaderValueFormat = "auth_header_value_format",
            AuthMethod = "auth_method",
            Endpoint = "endpoint",
            Method = "method",
            Params = new Dictionary<string, string>() { { "foo", "string" } },
            RequestContentType =
                Oauth2ModelUserInfoRequestRequestContentType.ApplicationXWwwFormUrlencoded,
            ResponseContentType =
                Oauth2ModelUserInfoRequestResponseContentType.ApplicationXWwwFormUrlencoded,
            ResponseMap = new Dictionary<string, string>() { { "foo", "string" } },
            Triggers = new() { OnTokenGrant = true, OnTokenRefresh = true },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Oauth2ModelUserInfoRequest { };

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
        var model = new Oauth2ModelUserInfoRequest { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Oauth2ModelUserInfoRequest
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
        var model = new Oauth2ModelUserInfoRequest
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

public class Oauth2ModelUserInfoRequestTriggersTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Oauth2ModelUserInfoRequestTriggers
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
        var model = new Oauth2ModelUserInfoRequestTriggers
        {
            OnTokenGrant = true,
            OnTokenRefresh = true,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Oauth2ModelUserInfoRequestTriggers>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Oauth2ModelUserInfoRequestTriggers
        {
            OnTokenGrant = true,
            OnTokenRefresh = true,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Oauth2ModelUserInfoRequestTriggers>(json);
        Assert.NotNull(deserialized);

        bool expectedOnTokenGrant = true;
        bool expectedOnTokenRefresh = true;

        Assert.Equal(expectedOnTokenGrant, deserialized.OnTokenGrant);
        Assert.Equal(expectedOnTokenRefresh, deserialized.OnTokenRefresh);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Oauth2ModelUserInfoRequestTriggers
        {
            OnTokenGrant = true,
            OnTokenRefresh = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Oauth2ModelUserInfoRequestTriggers { };

        Assert.Null(model.OnTokenGrant);
        Assert.False(model.RawData.ContainsKey("on_token_grant"));
        Assert.Null(model.OnTokenRefresh);
        Assert.False(model.RawData.ContainsKey("on_token_refresh"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Oauth2ModelUserInfoRequestTriggers { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Oauth2ModelUserInfoRequestTriggers
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
        var model = new Oauth2ModelUserInfoRequestTriggers
        {
            // Null should be interpreted as omitted for these properties
            OnTokenGrant = null,
            OnTokenRefresh = null,
        };

        model.Validate();
    }
}
