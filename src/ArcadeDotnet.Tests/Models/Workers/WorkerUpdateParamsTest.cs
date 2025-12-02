using System.Collections.Generic;
using ArcadeDotnet.Models.Workers;

namespace ArcadeDotnet.Tests.Models.Workers;

public class HTTPModelTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new HTTPModel
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
}

public class McpModelTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new McpModel
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
        McpModelOauth2 expectedOauth2 = new()
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
}

public class McpModelOauth2Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new McpModelOauth2
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
}
