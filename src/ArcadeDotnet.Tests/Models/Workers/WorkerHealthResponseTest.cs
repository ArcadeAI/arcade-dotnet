using ArcadeDotnet.Models.Workers;

namespace ArcadeDotnet.Tests.Models.Workers;

public class WorkerHealthResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new WorkerHealthResponse
        {
            ID = "id",
            Enabled = true,
            Healthy = true,
            Message = "message",
        };

        string expectedID = "id";
        bool expectedEnabled = true;
        bool expectedHealthy = true;
        string expectedMessage = "message";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedEnabled, model.Enabled);
        Assert.Equal(expectedHealthy, model.Healthy);
        Assert.Equal(expectedMessage, model.Message);
    }
}
