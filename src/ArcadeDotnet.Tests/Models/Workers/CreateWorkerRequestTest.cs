using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Models.Workers;

namespace ArcadeDotnet.Tests.Models.Workers;

public class CreateWorkerRequestTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CreateWorkerRequest
        {
            ID = "id",
            Enabled = true,
            Http = new()
            {
                Retry = 0,
                Secret = "secret",
                Timeout = 1,
                Uri = "uri",
            },
            Mcp = new()
            {
                Retry = 0,
                Timeout = 1,
                Uri = "uri",
                Headers = new Dictionary<string, string>() { { "foo", "string" } },
                Oauth2 = new()
                {
                    AuthorizationUrl = "authorization_url",
                    ClientID = "client_id",
                    ClientSecret = "client_secret",
                    ExternalID = "external_id",
                },
                Secrets = new Dictionary<string, string>() { { "foo", "string" } },
            },
            Type = "type",
        };

        string expectedID = "id";
        bool expectedEnabled = true;
        CreateWorkerRequestHttp expectedHttp = new()
        {
            Retry = 0,
            Secret = "secret",
            Timeout = 1,
            Uri = "uri",
        };
        CreateWorkerRequestMcp expectedMcp = new()
        {
            Retry = 0,
            Timeout = 1,
            Uri = "uri",
            Headers = new Dictionary<string, string>() { { "foo", "string" } },
            Oauth2 = new()
            {
                AuthorizationUrl = "authorization_url",
                ClientID = "client_id",
                ClientSecret = "client_secret",
                ExternalID = "external_id",
            },
            Secrets = new Dictionary<string, string>() { { "foo", "string" } },
        };
        string expectedType = "type";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedEnabled, model.Enabled);
        Assert.Equal(expectedHttp, model.Http);
        Assert.Equal(expectedMcp, model.Mcp);
        Assert.Equal(expectedType, model.Type);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new CreateWorkerRequest
        {
            ID = "id",
            Enabled = true,
            Http = new()
            {
                Retry = 0,
                Secret = "secret",
                Timeout = 1,
                Uri = "uri",
            },
            Mcp = new()
            {
                Retry = 0,
                Timeout = 1,
                Uri = "uri",
                Headers = new Dictionary<string, string>() { { "foo", "string" } },
                Oauth2 = new()
                {
                    AuthorizationUrl = "authorization_url",
                    ClientID = "client_id",
                    ClientSecret = "client_secret",
                    ExternalID = "external_id",
                },
                Secrets = new Dictionary<string, string>() { { "foo", "string" } },
            },
            Type = "type",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<CreateWorkerRequest>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CreateWorkerRequest
        {
            ID = "id",
            Enabled = true,
            Http = new()
            {
                Retry = 0,
                Secret = "secret",
                Timeout = 1,
                Uri = "uri",
            },
            Mcp = new()
            {
                Retry = 0,
                Timeout = 1,
                Uri = "uri",
                Headers = new Dictionary<string, string>() { { "foo", "string" } },
                Oauth2 = new()
                {
                    AuthorizationUrl = "authorization_url",
                    ClientID = "client_id",
                    ClientSecret = "client_secret",
                    ExternalID = "external_id",
                },
                Secrets = new Dictionary<string, string>() { { "foo", "string" } },
            },
            Type = "type",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<CreateWorkerRequest>(element);
        Assert.NotNull(deserialized);

        string expectedID = "id";
        bool expectedEnabled = true;
        CreateWorkerRequestHttp expectedHttp = new()
        {
            Retry = 0,
            Secret = "secret",
            Timeout = 1,
            Uri = "uri",
        };
        CreateWorkerRequestMcp expectedMcp = new()
        {
            Retry = 0,
            Timeout = 1,
            Uri = "uri",
            Headers = new Dictionary<string, string>() { { "foo", "string" } },
            Oauth2 = new()
            {
                AuthorizationUrl = "authorization_url",
                ClientID = "client_id",
                ClientSecret = "client_secret",
                ExternalID = "external_id",
            },
            Secrets = new Dictionary<string, string>() { { "foo", "string" } },
        };
        string expectedType = "type";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedEnabled, deserialized.Enabled);
        Assert.Equal(expectedHttp, deserialized.Http);
        Assert.Equal(expectedMcp, deserialized.Mcp);
        Assert.Equal(expectedType, deserialized.Type);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new CreateWorkerRequest
        {
            ID = "id",
            Enabled = true,
            Http = new()
            {
                Retry = 0,
                Secret = "secret",
                Timeout = 1,
                Uri = "uri",
            },
            Mcp = new()
            {
                Retry = 0,
                Timeout = 1,
                Uri = "uri",
                Headers = new Dictionary<string, string>() { { "foo", "string" } },
                Oauth2 = new()
                {
                    AuthorizationUrl = "authorization_url",
                    ClientID = "client_id",
                    ClientSecret = "client_secret",
                    ExternalID = "external_id",
                },
                Secrets = new Dictionary<string, string>() { { "foo", "string" } },
            },
            Type = "type",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new CreateWorkerRequest { ID = "id" };

        Assert.Null(model.Enabled);
        Assert.False(model.RawData.ContainsKey("enabled"));
        Assert.Null(model.Http);
        Assert.False(model.RawData.ContainsKey("http"));
        Assert.Null(model.Mcp);
        Assert.False(model.RawData.ContainsKey("mcp"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new CreateWorkerRequest { ID = "id" };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new CreateWorkerRequest
        {
            ID = "id",

            // Null should be interpreted as omitted for these properties
            Enabled = null,
            Http = null,
            Mcp = null,
            Type = null,
        };

        Assert.Null(model.Enabled);
        Assert.False(model.RawData.ContainsKey("enabled"));
        Assert.Null(model.Http);
        Assert.False(model.RawData.ContainsKey("http"));
        Assert.Null(model.Mcp);
        Assert.False(model.RawData.ContainsKey("mcp"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new CreateWorkerRequest
        {
            ID = "id",

            // Null should be interpreted as omitted for these properties
            Enabled = null,
            Http = null,
            Mcp = null,
            Type = null,
        };

        model.Validate();
    }
}

public class CreateWorkerRequestHttpTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CreateWorkerRequestHttp
        {
            Retry = 0,
            Secret = "secret",
            Timeout = 1,
            Uri = "uri",
        };

        long expectedRetry = 0;
        string expectedSecret = "secret";
        long expectedTimeout = 1;
        string expectedUri = "uri";

        Assert.Equal(expectedRetry, model.Retry);
        Assert.Equal(expectedSecret, model.Secret);
        Assert.Equal(expectedTimeout, model.Timeout);
        Assert.Equal(expectedUri, model.Uri);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new CreateWorkerRequestHttp
        {
            Retry = 0,
            Secret = "secret",
            Timeout = 1,
            Uri = "uri",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<CreateWorkerRequestHttp>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CreateWorkerRequestHttp
        {
            Retry = 0,
            Secret = "secret",
            Timeout = 1,
            Uri = "uri",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<CreateWorkerRequestHttp>(element);
        Assert.NotNull(deserialized);

        long expectedRetry = 0;
        string expectedSecret = "secret";
        long expectedTimeout = 1;
        string expectedUri = "uri";

        Assert.Equal(expectedRetry, deserialized.Retry);
        Assert.Equal(expectedSecret, deserialized.Secret);
        Assert.Equal(expectedTimeout, deserialized.Timeout);
        Assert.Equal(expectedUri, deserialized.Uri);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new CreateWorkerRequestHttp
        {
            Retry = 0,
            Secret = "secret",
            Timeout = 1,
            Uri = "uri",
        };

        model.Validate();
    }
}

public class CreateWorkerRequestMcpTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CreateWorkerRequestMcp
        {
            Retry = 0,
            Timeout = 1,
            Uri = "uri",
            Headers = new Dictionary<string, string>() { { "foo", "string" } },
            Oauth2 = new()
            {
                AuthorizationUrl = "authorization_url",
                ClientID = "client_id",
                ClientSecret = "client_secret",
                ExternalID = "external_id",
            },
            Secrets = new Dictionary<string, string>() { { "foo", "string" } },
        };

        long expectedRetry = 0;
        long expectedTimeout = 1;
        string expectedUri = "uri";
        Dictionary<string, string> expectedHeaders = new() { { "foo", "string" } };
        CreateWorkerRequestMcpOauth2 expectedOauth2 = new()
        {
            AuthorizationUrl = "authorization_url",
            ClientID = "client_id",
            ClientSecret = "client_secret",
            ExternalID = "external_id",
        };
        Dictionary<string, string> expectedSecrets = new() { { "foo", "string" } };

        Assert.Equal(expectedRetry, model.Retry);
        Assert.Equal(expectedTimeout, model.Timeout);
        Assert.Equal(expectedUri, model.Uri);
        Assert.NotNull(model.Headers);
        Assert.Equal(expectedHeaders.Count, model.Headers.Count);
        foreach (var item in expectedHeaders)
        {
            Assert.True(model.Headers.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.Headers[item.Key]);
        }
        Assert.Equal(expectedOauth2, model.Oauth2);
        Assert.NotNull(model.Secrets);
        Assert.Equal(expectedSecrets.Count, model.Secrets.Count);
        foreach (var item in expectedSecrets)
        {
            Assert.True(model.Secrets.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.Secrets[item.Key]);
        }
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new CreateWorkerRequestMcp
        {
            Retry = 0,
            Timeout = 1,
            Uri = "uri",
            Headers = new Dictionary<string, string>() { { "foo", "string" } },
            Oauth2 = new()
            {
                AuthorizationUrl = "authorization_url",
                ClientID = "client_id",
                ClientSecret = "client_secret",
                ExternalID = "external_id",
            },
            Secrets = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<CreateWorkerRequestMcp>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CreateWorkerRequestMcp
        {
            Retry = 0,
            Timeout = 1,
            Uri = "uri",
            Headers = new Dictionary<string, string>() { { "foo", "string" } },
            Oauth2 = new()
            {
                AuthorizationUrl = "authorization_url",
                ClientID = "client_id",
                ClientSecret = "client_secret",
                ExternalID = "external_id",
            },
            Secrets = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<CreateWorkerRequestMcp>(element);
        Assert.NotNull(deserialized);

        long expectedRetry = 0;
        long expectedTimeout = 1;
        string expectedUri = "uri";
        Dictionary<string, string> expectedHeaders = new() { { "foo", "string" } };
        CreateWorkerRequestMcpOauth2 expectedOauth2 = new()
        {
            AuthorizationUrl = "authorization_url",
            ClientID = "client_id",
            ClientSecret = "client_secret",
            ExternalID = "external_id",
        };
        Dictionary<string, string> expectedSecrets = new() { { "foo", "string" } };

        Assert.Equal(expectedRetry, deserialized.Retry);
        Assert.Equal(expectedTimeout, deserialized.Timeout);
        Assert.Equal(expectedUri, deserialized.Uri);
        Assert.NotNull(deserialized.Headers);
        Assert.Equal(expectedHeaders.Count, deserialized.Headers.Count);
        foreach (var item in expectedHeaders)
        {
            Assert.True(deserialized.Headers.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.Headers[item.Key]);
        }
        Assert.Equal(expectedOauth2, deserialized.Oauth2);
        Assert.NotNull(deserialized.Secrets);
        Assert.Equal(expectedSecrets.Count, deserialized.Secrets.Count);
        foreach (var item in expectedSecrets)
        {
            Assert.True(deserialized.Secrets.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.Secrets[item.Key]);
        }
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new CreateWorkerRequestMcp
        {
            Retry = 0,
            Timeout = 1,
            Uri = "uri",
            Headers = new Dictionary<string, string>() { { "foo", "string" } },
            Oauth2 = new()
            {
                AuthorizationUrl = "authorization_url",
                ClientID = "client_id",
                ClientSecret = "client_secret",
                ExternalID = "external_id",
            },
            Secrets = new Dictionary<string, string>() { { "foo", "string" } },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new CreateWorkerRequestMcp
        {
            Retry = 0,
            Timeout = 1,
            Uri = "uri",
        };

        Assert.Null(model.Headers);
        Assert.False(model.RawData.ContainsKey("headers"));
        Assert.Null(model.Oauth2);
        Assert.False(model.RawData.ContainsKey("oauth2"));
        Assert.Null(model.Secrets);
        Assert.False(model.RawData.ContainsKey("secrets"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new CreateWorkerRequestMcp
        {
            Retry = 0,
            Timeout = 1,
            Uri = "uri",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new CreateWorkerRequestMcp
        {
            Retry = 0,
            Timeout = 1,
            Uri = "uri",

            // Null should be interpreted as omitted for these properties
            Headers = null,
            Oauth2 = null,
            Secrets = null,
        };

        Assert.Null(model.Headers);
        Assert.False(model.RawData.ContainsKey("headers"));
        Assert.Null(model.Oauth2);
        Assert.False(model.RawData.ContainsKey("oauth2"));
        Assert.Null(model.Secrets);
        Assert.False(model.RawData.ContainsKey("secrets"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new CreateWorkerRequestMcp
        {
            Retry = 0,
            Timeout = 1,
            Uri = "uri",

            // Null should be interpreted as omitted for these properties
            Headers = null,
            Oauth2 = null,
            Secrets = null,
        };

        model.Validate();
    }
}

public class CreateWorkerRequestMcpOauth2Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CreateWorkerRequestMcpOauth2
        {
            AuthorizationUrl = "authorization_url",
            ClientID = "client_id",
            ClientSecret = "client_secret",
            ExternalID = "external_id",
        };

        string expectedAuthorizationUrl = "authorization_url";
        string expectedClientID = "client_id";
        string expectedClientSecret = "client_secret";
        string expectedExternalID = "external_id";

        Assert.Equal(expectedAuthorizationUrl, model.AuthorizationUrl);
        Assert.Equal(expectedClientID, model.ClientID);
        Assert.Equal(expectedClientSecret, model.ClientSecret);
        Assert.Equal(expectedExternalID, model.ExternalID);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new CreateWorkerRequestMcpOauth2
        {
            AuthorizationUrl = "authorization_url",
            ClientID = "client_id",
            ClientSecret = "client_secret",
            ExternalID = "external_id",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<CreateWorkerRequestMcpOauth2>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CreateWorkerRequestMcpOauth2
        {
            AuthorizationUrl = "authorization_url",
            ClientID = "client_id",
            ClientSecret = "client_secret",
            ExternalID = "external_id",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<CreateWorkerRequestMcpOauth2>(element);
        Assert.NotNull(deserialized);

        string expectedAuthorizationUrl = "authorization_url";
        string expectedClientID = "client_id";
        string expectedClientSecret = "client_secret";
        string expectedExternalID = "external_id";

        Assert.Equal(expectedAuthorizationUrl, deserialized.AuthorizationUrl);
        Assert.Equal(expectedClientID, deserialized.ClientID);
        Assert.Equal(expectedClientSecret, deserialized.ClientSecret);
        Assert.Equal(expectedExternalID, deserialized.ExternalID);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new CreateWorkerRequestMcpOauth2
        {
            AuthorizationUrl = "authorization_url",
            ClientID = "client_id",
            ClientSecret = "client_secret",
            ExternalID = "external_id",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new CreateWorkerRequestMcpOauth2 { };

        Assert.Null(model.AuthorizationUrl);
        Assert.False(model.RawData.ContainsKey("authorization_url"));
        Assert.Null(model.ClientID);
        Assert.False(model.RawData.ContainsKey("client_id"));
        Assert.Null(model.ClientSecret);
        Assert.False(model.RawData.ContainsKey("client_secret"));
        Assert.Null(model.ExternalID);
        Assert.False(model.RawData.ContainsKey("external_id"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new CreateWorkerRequestMcpOauth2 { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new CreateWorkerRequestMcpOauth2
        {
            // Null should be interpreted as omitted for these properties
            AuthorizationUrl = null,
            ClientID = null,
            ClientSecret = null,
            ExternalID = null,
        };

        Assert.Null(model.AuthorizationUrl);
        Assert.False(model.RawData.ContainsKey("authorization_url"));
        Assert.Null(model.ClientID);
        Assert.False(model.RawData.ContainsKey("client_id"));
        Assert.Null(model.ClientSecret);
        Assert.False(model.RawData.ContainsKey("client_secret"));
        Assert.Null(model.ExternalID);
        Assert.False(model.RawData.ContainsKey("external_id"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new CreateWorkerRequestMcpOauth2
        {
            // Null should be interpreted as omitted for these properties
            AuthorizationUrl = null,
            ClientID = null,
            ClientSecret = null,
            ExternalID = null,
        };

        model.Validate();
    }
}
