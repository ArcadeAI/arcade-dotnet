using System.Threading.Tasks;

namespace ArcadeDotnet.Tests.Services;

public class HealthServiceTest : TestBase
{
    [Fact]
    public async Task Check_Works()
    {
        var healthSchema = await this.client.Health.Check(
            new(),
            TestContext.Current.CancellationToken
        );
        healthSchema.Validate();
    }
}
