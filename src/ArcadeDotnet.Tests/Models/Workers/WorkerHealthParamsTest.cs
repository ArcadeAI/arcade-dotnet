using ArcadeDotnet.Models.Workers;

namespace ArcadeDotnet.Tests.Models.Workers;

public class WorkerHealthParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new WorkerHealthParams { ID = "id" };

        string expectedID = "id";

        Assert.Equal(expectedID, parameters.ID);
    }
}
