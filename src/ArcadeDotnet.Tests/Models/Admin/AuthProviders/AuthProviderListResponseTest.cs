using System.Collections.Generic;
using ArcadeDotnet.Models.Admin.AuthProviders;

namespace ArcadeDotnet.Tests.Models.Admin.AuthProviders;

public class AuthProviderListResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthProviderListResponse
        {
            Items =
            [
                new()
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
                        Pkce = new()
                        {
                            CodeChallengeMethod = "code_challenge_method",
                            Enabled = true,
                        },
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
                },
            ],
            Limit = 0,
            Offset = 0,
            PageCount = 0,
            TotalCount = 0,
        };

        List<AuthProviderResponse> expectedItems =
        [
            new()
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
            },
        ];
        long expectedLimit = 0;
        long expectedOffset = 0;
        long expectedPageCount = 0;
        long expectedTotalCount = 0;

        Assert.Equal(expectedItems.Count, model.Items.Count);
        for (int i = 0; i < expectedItems.Count; i++)
        {
            Assert.Equal(expectedItems[i], model.Items[i]);
        }
        Assert.Equal(expectedLimit, model.Limit);
        Assert.Equal(expectedOffset, model.Offset);
        Assert.Equal(expectedPageCount, model.PageCount);
        Assert.Equal(expectedTotalCount, model.TotalCount);
    }
}
