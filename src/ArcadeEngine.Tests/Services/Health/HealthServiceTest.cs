using System.Threading.Tasks;

namespace ArcadeEngine.Tests.Services.Health;

public class HealthServiceTest : TestBase
{
    [Fact]
    public async Task Check_Works()
    {
        var healthSchema = await this.client.Health.Check();
        healthSchema.Validate();
    }
}
