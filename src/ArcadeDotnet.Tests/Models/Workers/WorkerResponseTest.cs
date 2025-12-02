using System.Collections.Generic;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Workers;

namespace ArcadeDotnet.Tests.Models.Workers;

public class WorkerResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new WorkerResponse
        {
            ID = "id",
            Binding = new() { ID = "id", Type = Type.Static },
            Enabled = true,
            HTTP = new()
            {
                Retry = 0,
                Secret = new()
                {
                    Binding = SecretBinding.Static,
                    Editable = true,
                    Exists = true,
                    Hint = "hint",
                    Value = "value",
                },
                Timeout = 0,
                Uri = "uri",
            },
            Managed = true,
            Mcp = new()
            {
                Headers = new Dictionary<string, string>() { { "foo", "string" } },
                Oauth2 = new()
                {
                    AuthorizationURL = "authorization_url",
                    ClientID = "client_id",
                    ClientSecret = new()
                    {
                        Binding = ClientSecretBinding.Static,
                        Editable = true,
                        Exists = true,
                        Hint = "hint",
                        Value = "value",
                    },
                    RedirectUri = "redirect_uri",
                },
                Retry = 0,
                Secrets = new Dictionary<string, SecretsItem>()
                {
                    {
                        "foo",
                        new()
                        {
                            Binding = SecretsItemBinding.Static,
                            Editable = true,
                            Exists = true,
                            Hint = "hint",
                            Value = "value",
                        }
                    },
                },
                Timeout = 0,
                Uri = "uri",
            },
            Requirements = new()
            {
                Authorization = new()
                {
                    Met = true,
                    Oauth2 = new() { Met = true },
                },
                Met = true,
            },
            Type = WorkerResponseType.HTTP,
        };

        string expectedID = "id";
        Binding expectedBinding = new() { ID = "id", Type = Type.Static };
        bool expectedEnabled = true;
        WorkerResponseHTTP expectedHTTP = new()
        {
            Retry = 0,
            Secret = new()
            {
                Binding = SecretBinding.Static,
                Editable = true,
                Exists = true,
                Hint = "hint",
                Value = "value",
            },
            Timeout = 0,
            Uri = "uri",
        };
        bool expectedManaged = true;
        WorkerResponseMcp expectedMcp = new()
        {
            Headers = new Dictionary<string, string>() { { "foo", "string" } },
            Oauth2 = new()
            {
                AuthorizationURL = "authorization_url",
                ClientID = "client_id",
                ClientSecret = new()
                {
                    Binding = ClientSecretBinding.Static,
                    Editable = true,
                    Exists = true,
                    Hint = "hint",
                    Value = "value",
                },
                RedirectUri = "redirect_uri",
            },
            Retry = 0,
            Secrets = new Dictionary<string, SecretsItem>()
            {
                {
                    "foo",
                    new()
                    {
                        Binding = SecretsItemBinding.Static,
                        Editable = true,
                        Exists = true,
                        Hint = "hint",
                        Value = "value",
                    }
                },
            },
            Timeout = 0,
            Uri = "uri",
        };
        Requirements expectedRequirements = new()
        {
            Authorization = new()
            {
                Met = true,
                Oauth2 = new() { Met = true },
            },
            Met = true,
        };
        ApiEnum<string, WorkerResponseType> expectedType = WorkerResponseType.HTTP;

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedBinding, model.Binding);
        Assert.Equal(expectedEnabled, model.Enabled);
        Assert.Equal(expectedHTTP, model.HTTP);
        Assert.Equal(expectedManaged, model.Managed);
        Assert.Equal(expectedMcp, model.Mcp);
        Assert.Equal(expectedRequirements, model.Requirements);
        Assert.Equal(expectedType, model.Type);
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

public class WorkerResponseHTTPTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new WorkerResponseHTTP
        {
            Retry = 0,
            Secret = new()
            {
                Binding = SecretBinding.Static,
                Editable = true,
                Exists = true,
                Hint = "hint",
                Value = "value",
            },
            Timeout = 0,
            Uri = "uri",
        };

        long expectedRetry = 0;
        Secret expectedSecret = new()
        {
            Binding = SecretBinding.Static,
            Editable = true,
            Exists = true,
            Hint = "hint",
            Value = "value",
        };
        long expectedTimeout = 0;
        string expectedUri = "uri";

        Assert.Equal(expectedRetry, model.Retry);
        Assert.Equal(expectedSecret, model.Secret);
        Assert.Equal(expectedTimeout, model.Timeout);
        Assert.Equal(expectedUri, model.Uri);
    }
}

public class SecretTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Secret
        {
            Binding = SecretBinding.Static,
            Editable = true,
            Exists = true,
            Hint = "hint",
            Value = "value",
        };

        ApiEnum<string, SecretBinding> expectedBinding = SecretBinding.Static;
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

public class WorkerResponseMcpTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new WorkerResponseMcp
        {
            Headers = new Dictionary<string, string>() { { "foo", "string" } },
            Oauth2 = new()
            {
                AuthorizationURL = "authorization_url",
                ClientID = "client_id",
                ClientSecret = new()
                {
                    Binding = ClientSecretBinding.Static,
                    Editable = true,
                    Exists = true,
                    Hint = "hint",
                    Value = "value",
                },
                RedirectUri = "redirect_uri",
            },
            Retry = 0,
            Secrets = new Dictionary<string, SecretsItem>()
            {
                {
                    "foo",
                    new()
                    {
                        Binding = SecretsItemBinding.Static,
                        Editable = true,
                        Exists = true,
                        Hint = "hint",
                        Value = "value",
                    }
                },
            },
            Timeout = 0,
            Uri = "uri",
        };

        Dictionary<string, string> expectedHeaders = new() { { "foo", "string" } };
        WorkerResponseMcpOauth2 expectedOauth2 = new()
        {
            AuthorizationURL = "authorization_url",
            ClientID = "client_id",
            ClientSecret = new()
            {
                Binding = ClientSecretBinding.Static,
                Editable = true,
                Exists = true,
                Hint = "hint",
                Value = "value",
            },
            RedirectUri = "redirect_uri",
        };
        long expectedRetry = 0;
        Dictionary<string, SecretsItem> expectedSecrets = new()
        {
            {
                "foo",
                new()
                {
                    Binding = SecretsItemBinding.Static,
                    Editable = true,
                    Exists = true,
                    Hint = "hint",
                    Value = "value",
                }
            },
        };
        long expectedTimeout = 0;
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

public class WorkerResponseMcpOauth2Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new WorkerResponseMcpOauth2
        {
            AuthorizationURL = "authorization_url",
            ClientID = "client_id",
            ClientSecret = new()
            {
                Binding = ClientSecretBinding.Static,
                Editable = true,
                Exists = true,
                Hint = "hint",
                Value = "value",
            },
            RedirectUri = "redirect_uri",
        };

        string expectedAuthorizationURL = "authorization_url";
        string expectedClientID = "client_id";
        ClientSecret expectedClientSecret = new()
        {
            Binding = ClientSecretBinding.Static,
            Editable = true,
            Exists = true,
            Hint = "hint",
            Value = "value",
        };
        string expectedRedirectUri = "redirect_uri";

        Assert.Equal(expectedAuthorizationURL, model.AuthorizationURL);
        Assert.Equal(expectedClientID, model.ClientID);
        Assert.Equal(expectedClientSecret, model.ClientSecret);
        Assert.Equal(expectedRedirectUri, model.RedirectUri);
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

public class SecretsItemTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new SecretsItem
        {
            Binding = SecretsItemBinding.Static,
            Editable = true,
            Exists = true,
            Hint = "hint",
            Value = "value",
        };

        ApiEnum<string, SecretsItemBinding> expectedBinding = SecretsItemBinding.Static;
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

public class RequirementsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Requirements
        {
            Authorization = new()
            {
                Met = true,
                Oauth2 = new() { Met = true },
            },
            Met = true,
        };

        Authorization expectedAuthorization = new()
        {
            Met = true,
            Oauth2 = new() { Met = true },
        };
        bool expectedMet = true;

        Assert.Equal(expectedAuthorization, model.Authorization);
        Assert.Equal(expectedMet, model.Met);
    }
}

public class AuthorizationTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Authorization
        {
            Met = true,
            Oauth2 = new() { Met = true },
        };

        bool expectedMet = true;
        AuthorizationOauth2 expectedOauth2 = new() { Met = true };

        Assert.Equal(expectedMet, model.Met);
        Assert.Equal(expectedOauth2, model.Oauth2);
    }
}

public class AuthorizationOauth2Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthorizationOauth2 { Met = true };

        bool expectedMet = true;

        Assert.Equal(expectedMet, model.Met);
    }
}
