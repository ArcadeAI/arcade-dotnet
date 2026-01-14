using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Core;
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

        Assert.NotNull(model.Items);
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

    [Fact]
    public void SerializationRoundtrip_Works()
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

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AuthProviderListResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
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

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AuthProviderListResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

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

        Assert.NotNull(deserialized.Items);
        Assert.Equal(expectedItems.Count, deserialized.Items.Count);
        for (int i = 0; i < expectedItems.Count; i++)
        {
            Assert.Equal(expectedItems[i], deserialized.Items[i]);
        }
        Assert.Equal(expectedLimit, deserialized.Limit);
        Assert.Equal(expectedOffset, deserialized.Offset);
        Assert.Equal(expectedPageCount, deserialized.PageCount);
        Assert.Equal(expectedTotalCount, deserialized.TotalCount);
    }

    [Fact]
    public void Validation_Works()
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

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthProviderListResponse { };

        Assert.Null(model.Items);
        Assert.False(model.RawData.ContainsKey("items"));
        Assert.Null(model.Limit);
        Assert.False(model.RawData.ContainsKey("limit"));
        Assert.Null(model.Offset);
        Assert.False(model.RawData.ContainsKey("offset"));
        Assert.Null(model.PageCount);
        Assert.False(model.RawData.ContainsKey("page_count"));
        Assert.Null(model.TotalCount);
        Assert.False(model.RawData.ContainsKey("total_count"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AuthProviderListResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthProviderListResponse
        {
            // Null should be interpreted as omitted for these properties
            Items = null,
            Limit = null,
            Offset = null,
            PageCount = null,
            TotalCount = null,
        };

        Assert.Null(model.Items);
        Assert.False(model.RawData.ContainsKey("items"));
        Assert.Null(model.Limit);
        Assert.False(model.RawData.ContainsKey("limit"));
        Assert.Null(model.Offset);
        Assert.False(model.RawData.ContainsKey("offset"));
        Assert.Null(model.PageCount);
        Assert.False(model.RawData.ContainsKey("page_count"));
        Assert.Null(model.TotalCount);
        Assert.False(model.RawData.ContainsKey("total_count"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new AuthProviderListResponse
        {
            // Null should be interpreted as omitted for these properties
            Items = null,
            Limit = null,
            Offset = null,
            PageCount = null,
            TotalCount = null,
        };

        model.Validate();
    }
}
