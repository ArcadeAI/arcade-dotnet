using System.Threading.Tasks;

namespace ArcadeDotnet.Tests.Services.Health;

public class HealthServiceTest : TestBase
{
    [Fact]
    public async Task Check_Works()
    {
        var healthSchema = await this.Client.Health.Check();
        healthSchema.Validate();
    }
}
