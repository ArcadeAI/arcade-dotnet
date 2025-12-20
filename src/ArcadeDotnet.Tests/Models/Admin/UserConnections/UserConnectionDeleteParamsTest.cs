using ArcadeDotnet.Models.Admin.UserConnections;

namespace ArcadeDotnet.Tests.Models.Admin.UserConnections;

public class UserConnectionDeleteParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new UserConnectionDeleteParams { ID = "id" };

        string expectedID = "id";

        Assert.Equal(expectedID, parameters.ID);
    }
}
