using System.Collections.Generic;
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
            HTTP = new()
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
                    AuthorizationURL = "authorization_url",
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
        CreateWorkerRequestHTTP expectedHTTP = new()
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
                AuthorizationURL = "authorization_url",
                ClientID = "client_id",
                ClientSecret = "client_secret",
                ExternalID = "external_id",
            },
            Secrets = new Dictionary<string, string>() { { "foo", "string" } },
        };
        string expectedType = "type";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedEnabled, model.Enabled);
        Assert.Equal(expectedHTTP, model.HTTP);
        Assert.Equal(expectedMcp, model.Mcp);
        Assert.Equal(expectedType, model.Type);
    }
}

public class CreateWorkerRequestHTTPTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CreateWorkerRequestHTTP
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
                AuthorizationURL = "authorization_url",
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
            AuthorizationURL = "authorization_url",
            ClientID = "client_id",
            ClientSecret = "client_secret",
            ExternalID = "external_id",
        };
        Dictionary<string, string> expectedSecrets = new() { { "foo", "string" } };

        Assert.Equal(expectedRetry, model.Retry);
        Assert.Equal(expectedTimeout, model.Timeout);
        Assert.Equal(expectedUri, model.Uri);
        Assert.Equal(expectedHeaders.Count, model.Headers.Count);
        foreach (var item in expectedHeaders)
        {
            Assert.True(model.Headers.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.Headers[item.Key]);
        }
        Assert.Equal(expectedOauth2, model.Oauth2);
        Assert.Equal(expectedSecrets.Count, model.Secrets.Count);
        foreach (var item in expectedSecrets)
        {
            Assert.True(model.Secrets.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.Secrets[item.Key]);
        }
    }
}

public class CreateWorkerRequestMcpOauth2Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CreateWorkerRequestMcpOauth2
        {
            AuthorizationURL = "authorization_url",
            ClientID = "client_id",
            ClientSecret = "client_secret",
            ExternalID = "external_id",
        };

        string expectedAuthorizationURL = "authorization_url";
        string expectedClientID = "client_id";
        string expectedClientSecret = "client_secret";
        string expectedExternalID = "external_id";

        Assert.Equal(expectedAuthorizationURL, model.AuthorizationURL);
        Assert.Equal(expectedClientID, model.ClientID);
        Assert.Equal(expectedClientSecret, model.ClientSecret);
        Assert.Equal(expectedExternalID, model.ExternalID);
    }
}
