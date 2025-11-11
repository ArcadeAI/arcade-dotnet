using System.Threading.Tasks;

namespace ArcadeDotnet.Tests.Services.Admin;

public class SecretServiceTest : TestBase
{
    [Fact]
    public async Task List_Works()
    {
        var secrets = await this.client.Admin.Secrets.List();
        secrets.Validate();
    }

    [Fact]
    public async Task Delete_Works()
    {
        await this.client.Admin.Secrets.Delete(new() { SecretID = "secret_id" });
    }
}
