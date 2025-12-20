using ArcadeDotnet.Models.Tools.Scheduled;

namespace ArcadeDotnet.Tests.Models.Tools.Scheduled;

public class ScheduledGetParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new ScheduledGetParams { ID = "id" };

        string expectedID = "id";

        Assert.Equal(expectedID, parameters.ID);
    }
}
