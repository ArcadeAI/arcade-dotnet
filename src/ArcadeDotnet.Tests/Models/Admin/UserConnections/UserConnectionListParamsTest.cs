using ArcadeDotnet.Models.Admin.UserConnections;

namespace ArcadeDotnet.Tests.Models.Admin.UserConnections;

public class ProviderTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Provider { ID = "id" };

        string expectedID = "id";

        Assert.Equal(expectedID, model.ID);
    }
}

public class UserTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new User { ID = "id" };

        string expectedID = "id";

        Assert.Equal(expectedID, model.ID);
    }
}
