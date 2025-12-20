using ArcadeDotnet.Models.Workers;

namespace ArcadeDotnet.Tests.Models.Workers;

public class WorkerDeleteParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new WorkerDeleteParams { ID = "id" };

        string expectedID = "id";

        Assert.Equal(expectedID, parameters.ID);
    }
}
