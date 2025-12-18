using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Models.Workers;

namespace ArcadeDotnet.Tests.Models.Workers;

public class UpdateWorkerRequestTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new UpdateWorkerRequest
        {
            Enabled = true,
            HTTP = new()
            {
                Retry = 0,
                Secret = "secret",
                Timeout = 1,
                Uri = "uri",
            },
            Mcp = new()
            {
                Headers = new Dictionary<string, string>() { { "foo", "string" } },
                Oauth2 = new()
                {
                    AuthorizationURL = "authorization_url",
                    ClientID = "client_id",
                    ClientSecret = "client_secret",
                },
                Retry = 0,
                Secrets = new Dictionary<string, string>() { { "foo", "string" } },
                Timeout = 1,
                Uri = "uri",
            },
        };

        bool expectedEnabled = true;
        UpdateWorkerRequestHTTP expectedHTTP = new()
        {
            Retry = 0,
            Secret = "secret",
            Timeout = 1,
            Uri = "uri",
        };
        UpdateWorkerRequestMcp expectedMcp = new()
        {
            Headers = new Dictionary<string, string>() { { "foo", "string" } },
            Oauth2 = new()
            {
                AuthorizationURL = "authorization_url",
                ClientID = "client_id",
                ClientSecret = "client_secret",
            },
            Retry = 0,
            Secrets = new Dictionary<string, string>() { { "foo", "string" } },
            Timeout = 1,
            Uri = "uri",
        };

        Assert.Equal(expectedEnabled, model.Enabled);
        Assert.Equal(expectedHTTP, model.HTTP);
        Assert.Equal(expectedMcp, model.Mcp);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new UpdateWorkerRequest
        {
            Enabled = true,
            HTTP = new()
            {
                Retry = 0,
                Secret = "secret",
                Timeout = 1,
                Uri = "uri",
            },
            Mcp = new()
            {
                Headers = new Dictionary<string, string>() { { "foo", "string" } },
                Oauth2 = new()
                {
                    AuthorizationURL = "authorization_url",
                    ClientID = "client_id",
                    ClientSecret = "client_secret",
                },
                Retry = 0,
                Secrets = new Dictionary<string, string>() { { "foo", "string" } },
                Timeout = 1,
                Uri = "uri",
            },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<UpdateWorkerRequest>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new UpdateWorkerRequest
        {
            Enabled = true,
            HTTP = new()
            {
                Retry = 0,
                Secret = "secret",
                Timeout = 1,
                Uri = "uri",
            },
            Mcp = new()
            {
                Headers = new Dictionary<string, string>() { { "foo", "string" } },
                Oauth2 = new()
                {
                    AuthorizationURL = "authorization_url",
                    ClientID = "client_id",
                    ClientSecret = "client_secret",
                },
                Retry = 0,
                Secrets = new Dictionary<string, string>() { { "foo", "string" } },
                Timeout = 1,
                Uri = "uri",
            },
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<UpdateWorkerRequest>(element);
        Assert.NotNull(deserialized);

        bool expectedEnabled = true;
        UpdateWorkerRequestHTTP expectedHTTP = new()
        {
            Retry = 0,
            Secret = "secret",
            Timeout = 1,
            Uri = "uri",
        };
        UpdateWorkerRequestMcp expectedMcp = new()
        {
            Headers = new Dictionary<string, string>() { { "foo", "string" } },
            Oauth2 = new()
            {
                AuthorizationURL = "authorization_url",
                ClientID = "client_id",
                ClientSecret = "client_secret",
            },
            Retry = 0,
            Secrets = new Dictionary<string, string>() { { "foo", "string" } },
            Timeout = 1,
            Uri = "uri",
        };

        Assert.Equal(expectedEnabled, deserialized.Enabled);
        Assert.Equal(expectedHTTP, deserialized.HTTP);
        Assert.Equal(expectedMcp, deserialized.Mcp);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new UpdateWorkerRequest
        {
            Enabled = true,
            HTTP = new()
            {
                Retry = 0,
                Secret = "secret",
                Timeout = 1,
                Uri = "uri",
            },
            Mcp = new()
            {
                Headers = new Dictionary<string, string>() { { "foo", "string" } },
                Oauth2 = new()
                {
                    AuthorizationURL = "authorization_url",
                    ClientID = "client_id",
                    ClientSecret = "client_secret",
                },
                Retry = 0,
                Secrets = new Dictionary<string, string>() { { "foo", "string" } },
                Timeout = 1,
                Uri = "uri",
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new UpdateWorkerRequest { };

        Assert.Null(model.Enabled);
        Assert.False(model.RawData.ContainsKey("enabled"));
        Assert.Null(model.HTTP);
        Assert.False(model.RawData.ContainsKey("http"));
        Assert.Null(model.Mcp);
        Assert.False(model.RawData.ContainsKey("mcp"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new UpdateWorkerRequest { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new UpdateWorkerRequest
        {
            // Null should be interpreted as omitted for these properties
            Enabled = null,
            HTTP = null,
            Mcp = null,
        };

        Assert.Null(model.Enabled);
        Assert.False(model.RawData.ContainsKey("enabled"));
        Assert.Null(model.HTTP);
        Assert.False(model.RawData.ContainsKey("http"));
        Assert.Null(model.Mcp);
        Assert.False(model.RawData.ContainsKey("mcp"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new UpdateWorkerRequest
        {
            // Null should be interpreted as omitted for these properties
            Enabled = null,
            HTTP = null,
            Mcp = null,
        };

        model.Validate();
    }
}

public class UpdateWorkerRequestHTTPTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new UpdateWorkerRequestHTTP
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
        var model = new UpdateWorkerRequestHTTP
        {
            Retry = 0,
            Secret = "secret",
            Timeout = 1,
            Uri = "uri",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<UpdateWorkerRequestHTTP>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new UpdateWorkerRequestHTTP
        {
            Retry = 0,
            Secret = "secret",
            Timeout = 1,
            Uri = "uri",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<UpdateWorkerRequestHTTP>(element);
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
        var model = new UpdateWorkerRequestHTTP
        {
            Retry = 0,
            Secret = "secret",
            Timeout = 1,
            Uri = "uri",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new UpdateWorkerRequestHTTP { };

        Assert.Null(model.Retry);
        Assert.False(model.RawData.ContainsKey("retry"));
        Assert.Null(model.Secret);
        Assert.False(model.RawData.ContainsKey("secret"));
        Assert.Null(model.Timeout);
        Assert.False(model.RawData.ContainsKey("timeout"));
        Assert.Null(model.Uri);
        Assert.False(model.RawData.ContainsKey("uri"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new UpdateWorkerRequestHTTP { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new UpdateWorkerRequestHTTP
        {
            // Null should be interpreted as omitted for these properties
            Retry = null,
            Secret = null,
            Timeout = null,
            Uri = null,
        };

        Assert.Null(model.Retry);
        Assert.False(model.RawData.ContainsKey("retry"));
        Assert.Null(model.Secret);
        Assert.False(model.RawData.ContainsKey("secret"));
        Assert.Null(model.Timeout);
        Assert.False(model.RawData.ContainsKey("timeout"));
        Assert.Null(model.Uri);
        Assert.False(model.RawData.ContainsKey("uri"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new UpdateWorkerRequestHTTP
        {
            // Null should be interpreted as omitted for these properties
            Retry = null,
            Secret = null,
            Timeout = null,
            Uri = null,
        };

        model.Validate();
    }
}

public class UpdateWorkerRequestMcpTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new UpdateWorkerRequestMcp
        {
            Headers = new Dictionary<string, string>() { { "foo", "string" } },
            Oauth2 = new()
            {
                AuthorizationURL = "authorization_url",
                ClientID = "client_id",
                ClientSecret = "client_secret",
            },
            Retry = 0,
            Secrets = new Dictionary<string, string>() { { "foo", "string" } },
            Timeout = 1,
            Uri = "uri",
        };

        Dictionary<string, string> expectedHeaders = new() { { "foo", "string" } };
        UpdateWorkerRequestMcpOauth2 expectedOauth2 = new()
        {
            AuthorizationURL = "authorization_url",
            ClientID = "client_id",
            ClientSecret = "client_secret",
        };
        long expectedRetry = 0;
        Dictionary<string, string> expectedSecrets = new() { { "foo", "string" } };
        long expectedTimeout = 1;
        string expectedUri = "uri";

        Assert.Equal(expectedHeaders.Count, model.Headers.Count);
        foreach (var item in expectedHeaders)
        {
            Assert.True(model.Headers.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.Headers[item.Key]);
        }
        Assert.Equal(expectedOauth2, model.Oauth2);
        Assert.Equal(expectedRetry, model.Retry);
        Assert.Equal(expectedSecrets.Count, model.Secrets.Count);
        foreach (var item in expectedSecrets)
        {
            Assert.True(model.Secrets.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.Secrets[item.Key]);
        }
        Assert.Equal(expectedTimeout, model.Timeout);
        Assert.Equal(expectedUri, model.Uri);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new UpdateWorkerRequestMcp
        {
            Headers = new Dictionary<string, string>() { { "foo", "string" } },
            Oauth2 = new()
            {
                AuthorizationURL = "authorization_url",
                ClientID = "client_id",
                ClientSecret = "client_secret",
            },
            Retry = 0,
            Secrets = new Dictionary<string, string>() { { "foo", "string" } },
            Timeout = 1,
            Uri = "uri",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<UpdateWorkerRequestMcp>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new UpdateWorkerRequestMcp
        {
            Headers = new Dictionary<string, string>() { { "foo", "string" } },
            Oauth2 = new()
            {
                AuthorizationURL = "authorization_url",
                ClientID = "client_id",
                ClientSecret = "client_secret",
            },
            Retry = 0,
            Secrets = new Dictionary<string, string>() { { "foo", "string" } },
            Timeout = 1,
            Uri = "uri",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<UpdateWorkerRequestMcp>(element);
        Assert.NotNull(deserialized);

        Dictionary<string, string> expectedHeaders = new() { { "foo", "string" } };
        UpdateWorkerRequestMcpOauth2 expectedOauth2 = new()
        {
            AuthorizationURL = "authorization_url",
            ClientID = "client_id",
            ClientSecret = "client_secret",
        };
        long expectedRetry = 0;
        Dictionary<string, string> expectedSecrets = new() { { "foo", "string" } };
        long expectedTimeout = 1;
        string expectedUri = "uri";

        Assert.Equal(expectedHeaders.Count, deserialized.Headers.Count);
        foreach (var item in expectedHeaders)
        {
            Assert.True(deserialized.Headers.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.Headers[item.Key]);
        }
        Assert.Equal(expectedOauth2, deserialized.Oauth2);
        Assert.Equal(expectedRetry, deserialized.Retry);
        Assert.Equal(expectedSecrets.Count, deserialized.Secrets.Count);
        foreach (var item in expectedSecrets)
        {
            Assert.True(deserialized.Secrets.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.Secrets[item.Key]);
        }
        Assert.Equal(expectedTimeout, deserialized.Timeout);
        Assert.Equal(expectedUri, deserialized.Uri);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new UpdateWorkerRequestMcp
        {
            Headers = new Dictionary<string, string>() { { "foo", "string" } },
            Oauth2 = new()
            {
                AuthorizationURL = "authorization_url",
                ClientID = "client_id",
                ClientSecret = "client_secret",
            },
            Retry = 0,
            Secrets = new Dictionary<string, string>() { { "foo", "string" } },
            Timeout = 1,
            Uri = "uri",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new UpdateWorkerRequestMcp { };

        Assert.Null(model.Headers);
        Assert.False(model.RawData.ContainsKey("headers"));
        Assert.Null(model.Oauth2);
        Assert.False(model.RawData.ContainsKey("oauth2"));
        Assert.Null(model.Retry);
        Assert.False(model.RawData.ContainsKey("retry"));
        Assert.Null(model.Secrets);
        Assert.False(model.RawData.ContainsKey("secrets"));
        Assert.Null(model.Timeout);
        Assert.False(model.RawData.ContainsKey("timeout"));
        Assert.Null(model.Uri);
        Assert.False(model.RawData.ContainsKey("uri"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new UpdateWorkerRequestMcp { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new UpdateWorkerRequestMcp
        {
            // Null should be interpreted as omitted for these properties
            Headers = null,
            Oauth2 = null,
            Retry = null,
            Secrets = null,
            Timeout = null,
            Uri = null,
        };

        Assert.Null(model.Headers);
        Assert.False(model.RawData.ContainsKey("headers"));
        Assert.Null(model.Oauth2);
        Assert.False(model.RawData.ContainsKey("oauth2"));
        Assert.Null(model.Retry);
        Assert.False(model.RawData.ContainsKey("retry"));
        Assert.Null(model.Secrets);
        Assert.False(model.RawData.ContainsKey("secrets"));
        Assert.Null(model.Timeout);
        Assert.False(model.RawData.ContainsKey("timeout"));
        Assert.Null(model.Uri);
        Assert.False(model.RawData.ContainsKey("uri"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new UpdateWorkerRequestMcp
        {
            // Null should be interpreted as omitted for these properties
            Headers = null,
            Oauth2 = null,
            Retry = null,
            Secrets = null,
            Timeout = null,
            Uri = null,
        };

        model.Validate();
    }
}

public class UpdateWorkerRequestMcpOauth2Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new UpdateWorkerRequestMcpOauth2
        {
            AuthorizationURL = "authorization_url",
            ClientID = "client_id",
            ClientSecret = "client_secret",
        };

        string expectedAuthorizationURL = "authorization_url";
        string expectedClientID = "client_id";
        string expectedClientSecret = "client_secret";

        Assert.Equal(expectedAuthorizationURL, model.AuthorizationURL);
        Assert.Equal(expectedClientID, model.ClientID);
        Assert.Equal(expectedClientSecret, model.ClientSecret);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new UpdateWorkerRequestMcpOauth2
        {
            AuthorizationURL = "authorization_url",
            ClientID = "client_id",
            ClientSecret = "client_secret",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<UpdateWorkerRequestMcpOauth2>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new UpdateWorkerRequestMcpOauth2
        {
            AuthorizationURL = "authorization_url",
            ClientID = "client_id",
            ClientSecret = "client_secret",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<UpdateWorkerRequestMcpOauth2>(element);
        Assert.NotNull(deserialized);

        string expectedAuthorizationURL = "authorization_url";
        string expectedClientID = "client_id";
        string expectedClientSecret = "client_secret";

        Assert.Equal(expectedAuthorizationURL, deserialized.AuthorizationURL);
        Assert.Equal(expectedClientID, deserialized.ClientID);
        Assert.Equal(expectedClientSecret, deserialized.ClientSecret);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new UpdateWorkerRequestMcpOauth2
        {
            AuthorizationURL = "authorization_url",
            ClientID = "client_id",
            ClientSecret = "client_secret",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new UpdateWorkerRequestMcpOauth2 { };

        Assert.Null(model.AuthorizationURL);
        Assert.False(model.RawData.ContainsKey("authorization_url"));
        Assert.Null(model.ClientID);
        Assert.False(model.RawData.ContainsKey("client_id"));
        Assert.Null(model.ClientSecret);
        Assert.False(model.RawData.ContainsKey("client_secret"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new UpdateWorkerRequestMcpOauth2 { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new UpdateWorkerRequestMcpOauth2
        {
            // Null should be interpreted as omitted for these properties
            AuthorizationURL = null,
            ClientID = null,
            ClientSecret = null,
        };

        Assert.Null(model.AuthorizationURL);
        Assert.False(model.RawData.ContainsKey("authorization_url"));
        Assert.Null(model.ClientID);
        Assert.False(model.RawData.ContainsKey("client_id"));
        Assert.Null(model.ClientSecret);
        Assert.False(model.RawData.ContainsKey("client_secret"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new UpdateWorkerRequestMcpOauth2
        {
            // Null should be interpreted as omitted for these properties
            AuthorizationURL = null,
            ClientID = null,
            ClientSecret = null,
        };

        model.Validate();
    }
}
