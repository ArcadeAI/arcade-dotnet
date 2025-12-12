using System.Threading.Tasks;

namespace ArcadeDotnet.Tests.Services.Tools;

public class FormattedServiceTest : TestBase
{
    [Fact]
    public async Task List_Works()
    {
        var page = await this.client.Tools.Formatted.List(
            new(),
            TestContext.Current.CancellationToken
        );
        page.Validate();
    }

    [Fact]
    public async Task Get_Works()
    {
        await this.client.Tools.Formatted.Get("name", new(), TestContext.Current.CancellationToken);
    }
}
