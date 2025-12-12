using System.Threading.Tasks;

namespace ArcadeDotnet.Tests.Services;

public class WorkerServiceTest : TestBase
{
    [Fact]
    public async Task Create_Works()
    {
        var workerResponse = await this.client.Workers.Create(
            new() { ID = "id" },
            TestContext.Current.CancellationToken
        );
        workerResponse.Validate();
    }

    [Fact]
    public async Task Update_Works()
    {
        var workerResponse = await this.client.Workers.Update(
            "id",
            new(),
            TestContext.Current.CancellationToken
        );
        workerResponse.Validate();
    }

    [Fact]
    public async Task List_Works()
    {
        var page = await this.client.Workers.List(new(), TestContext.Current.CancellationToken);
        page.Validate();
    }

    [Fact]
    public async Task Delete_Works()
    {
        await this.client.Workers.Delete("id", new(), TestContext.Current.CancellationToken);
    }

    [Fact]
    public async Task Get_Works()
    {
        var workerResponse = await this.client.Workers.Get(
            "id",
            new(),
            TestContext.Current.CancellationToken
        );
        workerResponse.Validate();
    }

    [Fact]
    public async Task Health_Works()
    {
        var workerHealthResponse = await this.client.Workers.Health(
            "id",
            new(),
            TestContext.Current.CancellationToken
        );
        workerHealthResponse.Validate();
    }

    [Fact]
    public async Task Tools_Works()
    {
        var page = await this.client.Workers.Tools(
            "id",
            new(),
            TestContext.Current.CancellationToken
        );
        page.Validate();
    }
}
