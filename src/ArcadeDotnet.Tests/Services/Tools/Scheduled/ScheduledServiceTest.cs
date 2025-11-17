using System.Threading.Tasks;

namespace ArcadeDotnet.Tests.Services.Tools.Scheduled;

public class ScheduledServiceTest : TestBase
{
    [Fact]
    public async Task List_Works()
    {
        var page = await this.Client.Tools.Scheduled.List();
        page.Validate();
    }

    [Fact]
    public async Task Get_Works()
    {
        var scheduled = await this.Client.Tools.Scheduled.Get(new() { ID = "id" });
        scheduled.Validate();
    }
}
