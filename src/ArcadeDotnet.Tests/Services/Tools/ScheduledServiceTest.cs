using System.Threading.Tasks;

namespace ArcadeDotnet.Tests.Services.Tools;

public class ScheduledServiceTest : TestBase
{
    [Fact]
    public async Task List_Works()
    {
        var page = await this.client.Tools.Scheduled.List(
            new(),
            TestContext.Current.CancellationToken
        );
        page.Validate();
    }

    [Fact]
    public async Task Get_Works()
    {
        var scheduled = await this.client.Tools.Scheduled.Get(
            "id",
            new(),
            TestContext.Current.CancellationToken
        );
        scheduled.Validate();
    }
}
