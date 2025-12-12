using System.Threading.Tasks;

namespace ArcadeDotnet.Tests.Services.Admin;

public class SecretServiceTest : TestBase
{
    [Fact]
    public async Task Create_Works()
    {
        var secretResponse = await this.client.Admin.Secrets.Create(
            "secret_key",
            new() { Value = "value" },
            TestContext.Current.CancellationToken
        );
        secretResponse.Validate();
    }

    [Fact]
    public async Task List_Works()
    {
        var secrets = await this.client.Admin.Secrets.List(
            new(),
            TestContext.Current.CancellationToken
        );
        secrets.Validate();
    }

    [Fact]
    public async Task Delete_Works()
    {
        await this.client.Admin.Secrets.Delete(
            "secret_id",
            new(),
            TestContext.Current.CancellationToken
        );
    }
}
