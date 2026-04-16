using System;
using ArcadeDotnet.Models.Admin.Secrets;

namespace ArcadeDotnet.Tests.Models.Admin.Secrets;

public class SecretCreateParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new SecretCreateParams
        {
            SecretKey = "secret_key",
            Value = "value",
            Description = "description",
        };

        string expectedSecretKey = "secret_key";
        string expectedValue = "value";
        string expectedDescription = "description";

        Assert.Equal(expectedSecretKey, parameters.SecretKey);
        Assert.Equal(expectedValue, parameters.Value);
        Assert.Equal(expectedDescription, parameters.Description);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new SecretCreateParams { SecretKey = "secret_key", Value = "value" };

        Assert.Null(parameters.Description);
        Assert.False(parameters.RawBodyData.ContainsKey("description"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new SecretCreateParams
        {
            SecretKey = "secret_key",
            Value = "value",

            // Null should be interpreted as omitted for these properties
            Description = null,
        };

        Assert.Null(parameters.Description);
        Assert.False(parameters.RawBodyData.ContainsKey("description"));
    }

    [Fact]
    public void Url_Works()
    {
        SecretCreateParams parameters = new() { SecretKey = "secret_key", Value = "value" };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.True(
            TestBase.UrisEqual(new Uri("https://api.arcade.dev/v1/admin/secrets/secret_key"), url)
        );
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var parameters = new SecretCreateParams
        {
            SecretKey = "secret_key",
            Value = "value",
            Description = "description",
        };

        SecretCreateParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}
