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
}
