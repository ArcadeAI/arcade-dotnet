using System;
using ArcadeDotnet.Models.Admin.Secrets;

namespace ArcadeDotnet.Tests.Models.Admin.Secrets;

public class SecretDeleteParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new SecretDeleteParams { SecretID = "secret_id" };

        string expectedSecretID = "secret_id";

        Assert.Equal(expectedSecretID, parameters.SecretID);
    }

    [Fact]
    public void Url_Works()
    {
        SecretDeleteParams parameters = new() { SecretID = "secret_id" };

        var url = parameters.Url(new() { APIKey = "My API Key" });

        Assert.Equal(new Uri("https://api.arcade.dev/v1/admin/secrets/secret_id"), url);
    }
}
