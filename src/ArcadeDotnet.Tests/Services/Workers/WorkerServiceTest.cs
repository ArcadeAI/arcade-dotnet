using System.Threading.Tasks;

namespace ArcadeDotnet.Tests.Services.Workers;

public class WorkerServiceTest : TestBase
{
    [Fact]
    public async Task Create_Works()
    {
        var workerResponse = await this.Client.Workers.Create(new() { ID = "id" });
        workerResponse.Validate();
    }

    [Fact]
    public async Task Update_Works()
    {
        var workerResponse = await this.Client.Workers.Update(new() { ID = "id" });
        workerResponse.Validate();
    }

    [Fact]
    public async Task List_Works()
    {
        var page = await this.Client.Workers.List();
        page.Validate();
    }

    [Fact]
    public async Task Delete_Works()
    {
        await this.Client.Workers.Delete(new() { ID = "id" });
    }

    [Fact]
    public async Task Get_Works()
    {
        var workerResponse = await this.Client.Workers.Get(new() { ID = "id" });
        workerResponse.Validate();
    }

    [Fact]
    public async Task Health_Works()
    {
        var workerHealthResponse = await this.Client.Workers.Health(new() { ID = "id" });
        workerHealthResponse.Validate();
    }

    [Fact]
    public async Task Tools_Works()
    {
        var page = await this.Client.Workers.Tools(new() { ID = "id" });
        page.Validate();
    }
}
