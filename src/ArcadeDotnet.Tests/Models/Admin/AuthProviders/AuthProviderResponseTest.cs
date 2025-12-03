using System.Collections.Generic;
using System.Text.Json;
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

    [Fact]
    public void SerializationRoundtrip_Works()
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

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthProviderResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
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

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthProviderResponse>(json);
        Assert.NotNull(deserialized);

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

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedBinding, deserialized.Binding);
        Assert.Equal(expectedCreatedAt, deserialized.CreatedAt);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedOauth2, deserialized.Oauth2);
        Assert.Equal(expectedProviderID, deserialized.ProviderID);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedType, deserialized.Type);
        Assert.Equal(expectedUpdatedAt, deserialized.UpdatedAt);
    }

    [Fact]
    public void Validation_Works()
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

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthProviderResponse { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Binding);
        Assert.False(model.RawData.ContainsKey("binding"));
        Assert.Null(model.CreatedAt);
        Assert.False(model.RawData.ContainsKey("created_at"));
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
        Assert.Null(model.UpdatedAt);
        Assert.False(model.RawData.ContainsKey("updated_at"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AuthProviderResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthProviderResponse
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Binding = null,
            CreatedAt = null,
            Description = null,
            Oauth2 = null,
            ProviderID = null,
            Status = null,
            Type = null,
            UpdatedAt = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Binding);
        Assert.False(model.RawData.ContainsKey("binding"));
        Assert.Null(model.CreatedAt);
        Assert.False(model.RawData.ContainsKey("created_at"));
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
        Assert.Null(model.UpdatedAt);
        Assert.False(model.RawData.ContainsKey("updated_at"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new AuthProviderResponse
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Binding = null,
            CreatedAt = null,
            Description = null,
            Oauth2 = null,
            ProviderID = null,
            Status = null,
            Type = null,
            UpdatedAt = null,
        };

        model.Validate();
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

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Binding { ID = "id", Type = Type.Static };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Binding>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Binding { ID = "id", Type = Type.Static };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Binding>(json);
        Assert.NotNull(deserialized);

        string expectedID = "id";
        ApiEnum<string, Type> expectedType = Type.Static;

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedType, deserialized.Type);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Binding { ID = "id", Type = Type.Static };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Binding { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Binding { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Binding
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Type = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Binding
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Type = null,
        };

        model.Validate();
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

    [Fact]
    public void SerializationRoundtrip_Works()
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

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthProviderResponseOauth2>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
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

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthProviderResponseOauth2>(json);
        Assert.NotNull(deserialized);

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

        Assert.Equal(expectedAuthorizeRequest, deserialized.AuthorizeRequest);
        Assert.Equal(expectedClientID, deserialized.ClientID);
        Assert.Equal(expectedClientSecret, deserialized.ClientSecret);
        Assert.Equal(expectedPkce, deserialized.Pkce);
        Assert.Equal(expectedRedirectUri, deserialized.RedirectUri);
        Assert.Equal(expectedRefreshRequest, deserialized.RefreshRequest);
        Assert.Equal(expectedScopeDelimiter, deserialized.ScopeDelimiter);
        Assert.Equal(expectedTokenIntrospectionRequest, deserialized.TokenIntrospectionRequest);
        Assert.Equal(expectedTokenRequest, deserialized.TokenRequest);
        Assert.Equal(expectedUserInfoRequest, deserialized.UserInfoRequest);
    }

    [Fact]
    public void Validation_Works()
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

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthProviderResponseOauth2 { };

        Assert.Null(model.AuthorizeRequest);
        Assert.False(model.RawData.ContainsKey("authorize_request"));
        Assert.Null(model.ClientID);
        Assert.False(model.RawData.ContainsKey("client_id"));
        Assert.Null(model.ClientSecret);
        Assert.False(model.RawData.ContainsKey("client_secret"));
        Assert.Null(model.Pkce);
        Assert.False(model.RawData.ContainsKey("pkce"));
        Assert.Null(model.RedirectUri);
        Assert.False(model.RawData.ContainsKey("redirect_uri"));
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
        var model = new AuthProviderResponseOauth2 { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthProviderResponseOauth2
        {
            // Null should be interpreted as omitted for these properties
            AuthorizeRequest = null,
            ClientID = null,
            ClientSecret = null,
            Pkce = null,
            RedirectUri = null,
            RefreshRequest = null,
            ScopeDelimiter = null,
            TokenIntrospectionRequest = null,
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
        Assert.Null(model.RedirectUri);
        Assert.False(model.RawData.ContainsKey("redirect_uri"));
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
        var model = new AuthProviderResponseOauth2
        {
            // Null should be interpreted as omitted for these properties
            AuthorizeRequest = null,
            ClientID = null,
            ClientSecret = null,
            Pkce = null,
            RedirectUri = null,
            RefreshRequest = null,
            ScopeDelimiter = null,
            TokenIntrospectionRequest = null,
            TokenRequest = null,
            UserInfoRequest = null,
        };

        model.Validate();
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

    [Fact]
    public void SerializationRoundtrip_Works()
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

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthProviderResponseOauth2AuthorizeRequest>(
            json
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
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

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthProviderResponseOauth2AuthorizeRequest>(
            json
        );
        Assert.NotNull(deserialized);

        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedEndpoint = "endpoint";
        string expectedExpirationFormat = "expiration_format";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        string expectedRequestContentType = "request_content_type";
        string expectedResponseContentType = "response_content_type";
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedAuthHeaderValueFormat, deserialized.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, deserialized.AuthMethod);
        Assert.Equal(expectedEndpoint, deserialized.Endpoint);
        Assert.Equal(expectedExpirationFormat, deserialized.ExpirationFormat);
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

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthProviderResponseOauth2AuthorizeRequest { };

        Assert.Null(model.AuthHeaderValueFormat);
        Assert.False(model.RawData.ContainsKey("auth_header_value_format"));
        Assert.Null(model.AuthMethod);
        Assert.False(model.RawData.ContainsKey("auth_method"));
        Assert.Null(model.Endpoint);
        Assert.False(model.RawData.ContainsKey("endpoint"));
        Assert.Null(model.ExpirationFormat);
        Assert.False(model.RawData.ContainsKey("expiration_format"));
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
        var model = new AuthProviderResponseOauth2AuthorizeRequest { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthProviderResponseOauth2AuthorizeRequest
        {
            // Null should be interpreted as omitted for these properties
            AuthHeaderValueFormat = null,
            AuthMethod = null,
            Endpoint = null,
            ExpirationFormat = null,
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
        Assert.Null(model.ExpirationFormat);
        Assert.False(model.RawData.ContainsKey("expiration_format"));
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
        var model = new AuthProviderResponseOauth2AuthorizeRequest
        {
            // Null should be interpreted as omitted for these properties
            AuthHeaderValueFormat = null,
            AuthMethod = null,
            Endpoint = null,
            ExpirationFormat = null,
            Method = null,
            Params = null,
            RequestContentType = null,
            ResponseContentType = null,
            ResponseMap = null,
        };

        model.Validate();
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

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new ClientSecret
        {
            Binding = ClientSecretBinding.Static,
            Editable = true,
            Exists = true,
            Hint = "hint",
            Value = "value",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ClientSecret>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ClientSecret
        {
            Binding = ClientSecretBinding.Static,
            Editable = true,
            Exists = true,
            Hint = "hint",
            Value = "value",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ClientSecret>(json);
        Assert.NotNull(deserialized);

        ApiEnum<string, ClientSecretBinding> expectedBinding = ClientSecretBinding.Static;
        bool expectedEditable = true;
        bool expectedExists = true;
        string expectedHint = "hint";
        string expectedValue = "value";

        Assert.Equal(expectedBinding, deserialized.Binding);
        Assert.Equal(expectedEditable, deserialized.Editable);
        Assert.Equal(expectedExists, deserialized.Exists);
        Assert.Equal(expectedHint, deserialized.Hint);
        Assert.Equal(expectedValue, deserialized.Value);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new ClientSecret
        {
            Binding = ClientSecretBinding.Static,
            Editable = true,
            Exists = true,
            Hint = "hint",
            Value = "value",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new ClientSecret { };

        Assert.Null(model.Binding);
        Assert.False(model.RawData.ContainsKey("binding"));
        Assert.Null(model.Editable);
        Assert.False(model.RawData.ContainsKey("editable"));
        Assert.Null(model.Exists);
        Assert.False(model.RawData.ContainsKey("exists"));
        Assert.Null(model.Hint);
        Assert.False(model.RawData.ContainsKey("hint"));
        Assert.Null(model.Value);
        Assert.False(model.RawData.ContainsKey("value"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new ClientSecret { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new ClientSecret
        {
            // Null should be interpreted as omitted for these properties
            Binding = null,
            Editable = null,
            Exists = null,
            Hint = null,
            Value = null,
        };

        Assert.Null(model.Binding);
        Assert.False(model.RawData.ContainsKey("binding"));
        Assert.Null(model.Editable);
        Assert.False(model.RawData.ContainsKey("editable"));
        Assert.Null(model.Exists);
        Assert.False(model.RawData.ContainsKey("exists"));
        Assert.Null(model.Hint);
        Assert.False(model.RawData.ContainsKey("hint"));
        Assert.Null(model.Value);
        Assert.False(model.RawData.ContainsKey("value"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new ClientSecret
        {
            // Null should be interpreted as omitted for these properties
            Binding = null,
            Editable = null,
            Exists = null,
            Hint = null,
            Value = null,
        };

        model.Validate();
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

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AuthProviderResponseOauth2Pkce
        {
            CodeChallengeMethod = "code_challenge_method",
            Enabled = true,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthProviderResponseOauth2Pkce>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AuthProviderResponseOauth2Pkce
        {
            CodeChallengeMethod = "code_challenge_method",
            Enabled = true,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthProviderResponseOauth2Pkce>(json);
        Assert.NotNull(deserialized);

        string expectedCodeChallengeMethod = "code_challenge_method";
        bool expectedEnabled = true;

        Assert.Equal(expectedCodeChallengeMethod, deserialized.CodeChallengeMethod);
        Assert.Equal(expectedEnabled, deserialized.Enabled);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AuthProviderResponseOauth2Pkce
        {
            CodeChallengeMethod = "code_challenge_method",
            Enabled = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthProviderResponseOauth2Pkce { };

        Assert.Null(model.CodeChallengeMethod);
        Assert.False(model.RawData.ContainsKey("code_challenge_method"));
        Assert.Null(model.Enabled);
        Assert.False(model.RawData.ContainsKey("enabled"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AuthProviderResponseOauth2Pkce { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthProviderResponseOauth2Pkce
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
        var model = new AuthProviderResponseOauth2Pkce
        {
            // Null should be interpreted as omitted for these properties
            CodeChallengeMethod = null,
            Enabled = null,
        };

        model.Validate();
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

    [Fact]
    public void SerializationRoundtrip_Works()
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

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthProviderResponseOauth2RefreshRequest>(
            json
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
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

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthProviderResponseOauth2RefreshRequest>(
            json
        );
        Assert.NotNull(deserialized);

        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedEndpoint = "endpoint";
        string expectedExpirationFormat = "expiration_format";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        string expectedRequestContentType = "request_content_type";
        string expectedResponseContentType = "response_content_type";
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedAuthHeaderValueFormat, deserialized.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, deserialized.AuthMethod);
        Assert.Equal(expectedEndpoint, deserialized.Endpoint);
        Assert.Equal(expectedExpirationFormat, deserialized.ExpirationFormat);
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

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthProviderResponseOauth2RefreshRequest { };

        Assert.Null(model.AuthHeaderValueFormat);
        Assert.False(model.RawData.ContainsKey("auth_header_value_format"));
        Assert.Null(model.AuthMethod);
        Assert.False(model.RawData.ContainsKey("auth_method"));
        Assert.Null(model.Endpoint);
        Assert.False(model.RawData.ContainsKey("endpoint"));
        Assert.Null(model.ExpirationFormat);
        Assert.False(model.RawData.ContainsKey("expiration_format"));
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
        var model = new AuthProviderResponseOauth2RefreshRequest { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthProviderResponseOauth2RefreshRequest
        {
            // Null should be interpreted as omitted for these properties
            AuthHeaderValueFormat = null,
            AuthMethod = null,
            Endpoint = null,
            ExpirationFormat = null,
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
        Assert.Null(model.ExpirationFormat);
        Assert.False(model.RawData.ContainsKey("expiration_format"));
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
        var model = new AuthProviderResponseOauth2RefreshRequest
        {
            // Null should be interpreted as omitted for these properties
            AuthHeaderValueFormat = null,
            AuthMethod = null,
            Endpoint = null,
            ExpirationFormat = null,
            Method = null,
            Params = null,
            RequestContentType = null,
            ResponseContentType = null,
            ResponseMap = null,
        };

        model.Validate();
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

    [Fact]
    public void SerializationRoundtrip_Works()
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

        string json = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<AuthProviderResponseOauth2TokenIntrospectionRequest>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
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

        string json = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<AuthProviderResponseOauth2TokenIntrospectionRequest>(json);
        Assert.NotNull(deserialized);

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

        Assert.Equal(expectedAuthHeaderValueFormat, deserialized.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, deserialized.AuthMethod);
        Assert.Equal(expectedEnabled, deserialized.Enabled);
        Assert.Equal(expectedEndpoint, deserialized.Endpoint);
        Assert.Equal(expectedExpirationFormat, deserialized.ExpirationFormat);
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

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthProviderResponseOauth2TokenIntrospectionRequest { };

        Assert.Null(model.AuthHeaderValueFormat);
        Assert.False(model.RawData.ContainsKey("auth_header_value_format"));
        Assert.Null(model.AuthMethod);
        Assert.False(model.RawData.ContainsKey("auth_method"));
        Assert.Null(model.Enabled);
        Assert.False(model.RawData.ContainsKey("enabled"));
        Assert.Null(model.Endpoint);
        Assert.False(model.RawData.ContainsKey("endpoint"));
        Assert.Null(model.ExpirationFormat);
        Assert.False(model.RawData.ContainsKey("expiration_format"));
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
        var model = new AuthProviderResponseOauth2TokenIntrospectionRequest { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthProviderResponseOauth2TokenIntrospectionRequest
        {
            // Null should be interpreted as omitted for these properties
            AuthHeaderValueFormat = null,
            AuthMethod = null,
            Enabled = null,
            Endpoint = null,
            ExpirationFormat = null,
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
        Assert.Null(model.Enabled);
        Assert.False(model.RawData.ContainsKey("enabled"));
        Assert.Null(model.Endpoint);
        Assert.False(model.RawData.ContainsKey("endpoint"));
        Assert.Null(model.ExpirationFormat);
        Assert.False(model.RawData.ContainsKey("expiration_format"));
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
        var model = new AuthProviderResponseOauth2TokenIntrospectionRequest
        {
            // Null should be interpreted as omitted for these properties
            AuthHeaderValueFormat = null,
            AuthMethod = null,
            Enabled = null,
            Endpoint = null,
            ExpirationFormat = null,
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

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AuthProviderResponseOauth2TokenIntrospectionRequestTriggers
        {
            OnTokenGrant = true,
            OnTokenRefresh = true,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<AuthProviderResponseOauth2TokenIntrospectionRequestTriggers>(
                json
            );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AuthProviderResponseOauth2TokenIntrospectionRequestTriggers
        {
            OnTokenGrant = true,
            OnTokenRefresh = true,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<AuthProviderResponseOauth2TokenIntrospectionRequestTriggers>(
                json
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
        var model = new AuthProviderResponseOauth2TokenIntrospectionRequestTriggers
        {
            OnTokenGrant = true,
            OnTokenRefresh = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthProviderResponseOauth2TokenIntrospectionRequestTriggers { };

        Assert.Null(model.OnTokenGrant);
        Assert.False(model.RawData.ContainsKey("on_token_grant"));
        Assert.Null(model.OnTokenRefresh);
        Assert.False(model.RawData.ContainsKey("on_token_refresh"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AuthProviderResponseOauth2TokenIntrospectionRequestTriggers { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthProviderResponseOauth2TokenIntrospectionRequestTriggers
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
        var model = new AuthProviderResponseOauth2TokenIntrospectionRequestTriggers
        {
            // Null should be interpreted as omitted for these properties
            OnTokenGrant = null,
            OnTokenRefresh = null,
        };

        model.Validate();
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

    [Fact]
    public void SerializationRoundtrip_Works()
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

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthProviderResponseOauth2TokenRequest>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
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

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthProviderResponseOauth2TokenRequest>(json);
        Assert.NotNull(deserialized);

        string expectedAuthHeaderValueFormat = "auth_header_value_format";
        string expectedAuthMethod = "auth_method";
        string expectedEndpoint = "endpoint";
        string expectedExpirationFormat = "expiration_format";
        string expectedMethod = "method";
        Dictionary<string, string> expectedParams = new() { { "foo", "string" } };
        string expectedRequestContentType = "request_content_type";
        string expectedResponseContentType = "response_content_type";
        Dictionary<string, string> expectedResponseMap = new() { { "foo", "string" } };

        Assert.Equal(expectedAuthHeaderValueFormat, deserialized.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, deserialized.AuthMethod);
        Assert.Equal(expectedEndpoint, deserialized.Endpoint);
        Assert.Equal(expectedExpirationFormat, deserialized.ExpirationFormat);
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

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthProviderResponseOauth2TokenRequest { };

        Assert.Null(model.AuthHeaderValueFormat);
        Assert.False(model.RawData.ContainsKey("auth_header_value_format"));
        Assert.Null(model.AuthMethod);
        Assert.False(model.RawData.ContainsKey("auth_method"));
        Assert.Null(model.Endpoint);
        Assert.False(model.RawData.ContainsKey("endpoint"));
        Assert.Null(model.ExpirationFormat);
        Assert.False(model.RawData.ContainsKey("expiration_format"));
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
        var model = new AuthProviderResponseOauth2TokenRequest { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthProviderResponseOauth2TokenRequest
        {
            // Null should be interpreted as omitted for these properties
            AuthHeaderValueFormat = null,
            AuthMethod = null,
            Endpoint = null,
            ExpirationFormat = null,
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
        Assert.Null(model.ExpirationFormat);
        Assert.False(model.RawData.ContainsKey("expiration_format"));
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
        var model = new AuthProviderResponseOauth2TokenRequest
        {
            // Null should be interpreted as omitted for these properties
            AuthHeaderValueFormat = null,
            AuthMethod = null,
            Endpoint = null,
            ExpirationFormat = null,
            Method = null,
            Params = null,
            RequestContentType = null,
            ResponseContentType = null,
            ResponseMap = null,
        };

        model.Validate();
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

    [Fact]
    public void SerializationRoundtrip_Works()
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

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthProviderResponseOauth2UserInfoRequest>(
            json
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
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

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthProviderResponseOauth2UserInfoRequest>(
            json
        );
        Assert.NotNull(deserialized);

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

        Assert.Equal(expectedAuthHeaderValueFormat, deserialized.AuthHeaderValueFormat);
        Assert.Equal(expectedAuthMethod, deserialized.AuthMethod);
        Assert.Equal(expectedEndpoint, deserialized.Endpoint);
        Assert.Equal(expectedExpirationFormat, deserialized.ExpirationFormat);
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

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthProviderResponseOauth2UserInfoRequest { };

        Assert.Null(model.AuthHeaderValueFormat);
        Assert.False(model.RawData.ContainsKey("auth_header_value_format"));
        Assert.Null(model.AuthMethod);
        Assert.False(model.RawData.ContainsKey("auth_method"));
        Assert.Null(model.Endpoint);
        Assert.False(model.RawData.ContainsKey("endpoint"));
        Assert.Null(model.ExpirationFormat);
        Assert.False(model.RawData.ContainsKey("expiration_format"));
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
        var model = new AuthProviderResponseOauth2UserInfoRequest { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthProviderResponseOauth2UserInfoRequest
        {
            // Null should be interpreted as omitted for these properties
            AuthHeaderValueFormat = null,
            AuthMethod = null,
            Endpoint = null,
            ExpirationFormat = null,
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
        Assert.Null(model.ExpirationFormat);
        Assert.False(model.RawData.ContainsKey("expiration_format"));
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
        var model = new AuthProviderResponseOauth2UserInfoRequest
        {
            // Null should be interpreted as omitted for these properties
            AuthHeaderValueFormat = null,
            AuthMethod = null,
            Endpoint = null,
            ExpirationFormat = null,
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

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AuthProviderResponseOauth2UserInfoRequestTriggers
        {
            OnTokenGrant = true,
            OnTokenRefresh = true,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<AuthProviderResponseOauth2UserInfoRequestTriggers>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AuthProviderResponseOauth2UserInfoRequestTriggers
        {
            OnTokenGrant = true,
            OnTokenRefresh = true,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized =
            JsonSerializer.Deserialize<AuthProviderResponseOauth2UserInfoRequestTriggers>(json);
        Assert.NotNull(deserialized);

        bool expectedOnTokenGrant = true;
        bool expectedOnTokenRefresh = true;

        Assert.Equal(expectedOnTokenGrant, deserialized.OnTokenGrant);
        Assert.Equal(expectedOnTokenRefresh, deserialized.OnTokenRefresh);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AuthProviderResponseOauth2UserInfoRequestTriggers
        {
            OnTokenGrant = true,
            OnTokenRefresh = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthProviderResponseOauth2UserInfoRequestTriggers { };

        Assert.Null(model.OnTokenGrant);
        Assert.False(model.RawData.ContainsKey("on_token_grant"));
        Assert.Null(model.OnTokenRefresh);
        Assert.False(model.RawData.ContainsKey("on_token_refresh"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AuthProviderResponseOauth2UserInfoRequestTriggers { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthProviderResponseOauth2UserInfoRequestTriggers
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
        var model = new AuthProviderResponseOauth2UserInfoRequestTriggers
        {
            // Null should be interpreted as omitted for these properties
            OnTokenGrant = null,
            OnTokenRefresh = null,
        };

        model.Validate();
    }
}
