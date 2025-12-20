using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Models.Workers;

namespace ArcadeDotnet.Tests.Models.Workers;

public class WorkerUpdateParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new WorkerUpdateParams
        {
            ID = "id",
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

        string expectedID = "id";
        bool expectedEnabled = true;
        WorkerUpdateParamsHTTP expectedHTTP = new()
        {
            Retry = 0,
            Secret = "secret",
            Timeout = 1,
            Uri = "uri",
        };
        WorkerUpdateParamsMcp expectedMcp = new()
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

        Assert.Equal(expectedID, parameters.ID);
        Assert.Equal(expectedEnabled, parameters.Enabled);
        Assert.Equal(expectedHTTP, parameters.HTTP);
        Assert.Equal(expectedMcp, parameters.Mcp);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new WorkerUpdateParams { ID = "id" };

        Assert.Null(parameters.Enabled);
        Assert.False(parameters.RawBodyData.ContainsKey("enabled"));
        Assert.Null(parameters.HTTP);
        Assert.False(parameters.RawBodyData.ContainsKey("http"));
        Assert.Null(parameters.Mcp);
        Assert.False(parameters.RawBodyData.ContainsKey("mcp"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new WorkerUpdateParams
        {
            ID = "id",

            // Null should be interpreted as omitted for these properties
            Enabled = null,
            HTTP = null,
            Mcp = null,
        };

        Assert.Null(parameters.Enabled);
        Assert.False(parameters.RawBodyData.ContainsKey("enabled"));
        Assert.Null(parameters.HTTP);
        Assert.False(parameters.RawBodyData.ContainsKey("http"));
        Assert.Null(parameters.Mcp);
        Assert.False(parameters.RawBodyData.ContainsKey("mcp"));
    }
}

public class WorkerUpdateParamsHTTPTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new WorkerUpdateParamsHTTP
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
        var model = new WorkerUpdateParamsHTTP
        {
            Retry = 0,
            Secret = "secret",
            Timeout = 1,
            Uri = "uri",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<WorkerUpdateParamsHTTP>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new WorkerUpdateParamsHTTP
        {
            Retry = 0,
            Secret = "secret",
            Timeout = 1,
            Uri = "uri",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<WorkerUpdateParamsHTTP>(element);
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
        var model = new WorkerUpdateParamsHTTP
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
        var model = new WorkerUpdateParamsHTTP { };

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
        var model = new WorkerUpdateParamsHTTP { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new WorkerUpdateParamsHTTP
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
        var model = new WorkerUpdateParamsHTTP
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

public class WorkerUpdateParamsMcpTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new WorkerUpdateParamsMcp
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
        WorkerUpdateParamsMcpOauth2 expectedOauth2 = new()
        {
            AuthorizationURL = "authorization_url",
            ClientID = "client_id",
            ClientSecret = "client_secret",
        };
        long expectedRetry = 0;
        Dictionary<string, string> expectedSecrets = new() { { "foo", "string" } };
        long expectedTimeout = 1;
        string expectedUri = "uri";

        Assert.NotNull(model.Headers);
        Assert.Equal(expectedHeaders.Count, model.Headers.Count);
        foreach (var item in expectedHeaders)
        {
            Assert.True(model.Headers.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.Headers[item.Key]);
        }
        Assert.Equal(expectedOauth2, model.Oauth2);
        Assert.Equal(expectedRetry, model.Retry);
        Assert.NotNull(model.Secrets);
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
        var model = new WorkerUpdateParamsMcp
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
        var deserialized = JsonSerializer.Deserialize<WorkerUpdateParamsMcp>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new WorkerUpdateParamsMcp
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
        var deserialized = JsonSerializer.Deserialize<WorkerUpdateParamsMcp>(element);
        Assert.NotNull(deserialized);

        Dictionary<string, string> expectedHeaders = new() { { "foo", "string" } };
        WorkerUpdateParamsMcpOauth2 expectedOauth2 = new()
        {
            AuthorizationURL = "authorization_url",
            ClientID = "client_id",
            ClientSecret = "client_secret",
        };
        long expectedRetry = 0;
        Dictionary<string, string> expectedSecrets = new() { { "foo", "string" } };
        long expectedTimeout = 1;
        string expectedUri = "uri";

        Assert.NotNull(deserialized.Headers);
        Assert.Equal(expectedHeaders.Count, deserialized.Headers.Count);
        foreach (var item in expectedHeaders)
        {
            Assert.True(deserialized.Headers.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.Headers[item.Key]);
        }
        Assert.Equal(expectedOauth2, deserialized.Oauth2);
        Assert.Equal(expectedRetry, deserialized.Retry);
        Assert.NotNull(deserialized.Secrets);
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
        var model = new WorkerUpdateParamsMcp
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
        var model = new WorkerUpdateParamsMcp { };

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
        var model = new WorkerUpdateParamsMcp { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new WorkerUpdateParamsMcp
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
        var model = new WorkerUpdateParamsMcp
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

public class WorkerUpdateParamsMcpOauth2Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new WorkerUpdateParamsMcpOauth2
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
        var model = new WorkerUpdateParamsMcpOauth2
        {
            AuthorizationURL = "authorization_url",
            ClientID = "client_id",
            ClientSecret = "client_secret",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<WorkerUpdateParamsMcpOauth2>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new WorkerUpdateParamsMcpOauth2
        {
            AuthorizationURL = "authorization_url",
            ClientID = "client_id",
            ClientSecret = "client_secret",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<WorkerUpdateParamsMcpOauth2>(element);
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
        var model = new WorkerUpdateParamsMcpOauth2
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
        var model = new WorkerUpdateParamsMcpOauth2 { };

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
        var model = new WorkerUpdateParamsMcpOauth2 { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new WorkerUpdateParamsMcpOauth2
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
        var model = new WorkerUpdateParamsMcpOauth2
        {
            // Null should be interpreted as omitted for these properties
            AuthorizationURL = null,
            ClientID = null,
            ClientSecret = null,
        };

        model.Validate();
    }
}
