using System.Threading.Tasks;

namespace ArcadeDotnet.Tests.Services;

public class WorkerServiceTest : TestBase
{
    [Fact]
    public async Task Create_Works()
    {
        var workerResponse = await this.client.Workers.Create(new() { ID = "id" });
        workerResponse.Validate();
    }

    [Fact]
    public async Task Update_Works()
    {
        var workerResponse = await this.client.Workers.Update(new() { ID = "id" });
        workerResponse.Validate();
    }

    [Fact]
    public async Task List_Works()
    {
        var page = await this.client.Workers.List();
        page.Validate();
    }

    [Fact]
    public async Task Delete_Works()
    {
        await this.client.Workers.Delete(new() { ID = "id" });
    }

    [Fact]
    public async Task Get_Works()
    {
        var workerResponse = await this.client.Workers.Get(new() { ID = "id" });
        workerResponse.Validate();
    }

    [Fact]
    public async Task Health_Works()
    {
        var workerHealthResponse = await this.client.Workers.Health(new() { ID = "id" });
        workerHealthResponse.Validate();
    }

    [Fact]
    public async Task Tools_Works()
    {
        var page = await this.client.Workers.Tools(new() { ID = "id" });
        page.Validate();
    }
}
