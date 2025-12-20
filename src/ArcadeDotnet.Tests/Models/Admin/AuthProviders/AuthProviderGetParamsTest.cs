using ArcadeDotnet.Models.Admin.AuthProviders;

namespace ArcadeDotnet.Tests.Models.Admin.AuthProviders;

public class AuthProviderGetParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new AuthProviderGetParams { ID = "id" };

        string expectedID = "id";

        Assert.Equal(expectedID, parameters.ID);
    }
}
