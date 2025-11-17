using System.Threading.Tasks;

namespace ArcadeDotnet.Tests.Services.Tools.Formatted;

public class FormattedServiceTest : TestBase
{
    [Fact]
    public async Task List_Works()
    {
        var page = await this.Client.Tools.Formatted.List();
        page.Validate();
    }

    [Fact]
    public async Task Get_Works()
    {
        var formatted = await this.Client.Tools.Formatted.Get(new() { Name = "name" });
        _ = formatted;
    }
}
