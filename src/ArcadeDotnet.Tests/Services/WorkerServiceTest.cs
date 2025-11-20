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
        var workerResponse = await this.client.Workers.Update("id");
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
        await this.client.Workers.Delete("id");
    }

    [Fact]
    public async Task Get_Works()
    {
        var workerResponse = await this.client.Workers.Get("id");
        workerResponse.Validate();
    }

    [Fact]
    public async Task Health_Works()
    {
        var workerHealthResponse = await this.client.Workers.Health("id");
        workerHealthResponse.Validate();
    }

    [Fact]
    public async Task Tools_Works()
    {
        var page = await this.client.Workers.Tools("id");
        page.Validate();
    }
}
