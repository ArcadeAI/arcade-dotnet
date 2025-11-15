using System.Threading.Tasks;

namespace ArcadeDotnet.Tests.Services;

public class ToolServiceTest : TestBase
{
    [Fact]
    public async Task List_Works()
    {
        var page = await this.client.Tools.List();
        page.Validate();
    }

    [Fact]
    public async Task Authorize_Works()
    {
        var authorizationResponse = await this.client.Tools.Authorize(
            new() { ToolName = "tool_name" }
        );
        authorizationResponse.Validate();
    }

    [Fact]
    public async Task Execute_Works()
    {
        var executeToolResponse = await this.client.Tools.Execute(new() { ToolName = "tool_name" });
        executeToolResponse.Validate();
    }

    [Fact]
    public async Task Get_Works()
    {
        var toolDefinition = await this.client.Tools.Get(new() { Name = "name" });
        toolDefinition.Validate();
    }
}
