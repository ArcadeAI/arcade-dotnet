using ArcadeDotnet.Models.Health;

namespace ArcadeDotnet.Tests.Models.Health;

public class HealthSchemaTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new HealthSchema { Healthy = true };

        bool expectedHealthy = true;

        Assert.Equal(expectedHealthy, model.Healthy);
    }
}
