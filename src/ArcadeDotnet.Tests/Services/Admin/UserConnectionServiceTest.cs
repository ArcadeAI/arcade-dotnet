using System.Threading.Tasks;

namespace ArcadeDotnet.Tests.Services.Admin;

public class UserConnectionServiceTest : TestBase
{
    [Fact]
    public async Task List_Works()
    {
        var page = await this.client.Admin.UserConnections.List();
        page.Validate();
    }

    [Fact]
    public async Task Delete_Works()
    {
        await this.client.Admin.UserConnections.Delete(new() { ID = "id" });
    }
}
