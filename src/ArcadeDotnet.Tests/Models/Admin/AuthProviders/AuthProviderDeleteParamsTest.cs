using ArcadeDotnet.Models.Admin.AuthProviders;

namespace ArcadeDotnet.Tests.Models.Admin.AuthProviders;

public class AuthProviderDeleteParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new AuthProviderDeleteParams { ID = "id" };

        string expectedID = "id";

        Assert.Equal(expectedID, parameters.ID);
    }
}
