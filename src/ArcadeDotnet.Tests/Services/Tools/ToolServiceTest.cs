using System.Threading.Tasks;

namespace ArcadeDotnet.Tests.Services.Tools;

public class ToolServiceTest : TestBase
{
    [Fact]
    public async Task List_Works()
    {
        var page = await this.Client.Tools.List();
        page.Validate();
    }

    [Fact]
    public async Task Authorize_Works()
    {
        var authorizationResponse = await this.Client.Tools.Authorize(
            new() { ToolName = "tool_name" }
        );
        authorizationResponse.Validate();
    }

    [Fact]
    public async Task Execute_Works()
    {
        var executeToolResponse = await this.Client.Tools.Execute(new() { ToolName = "tool_name" });
        executeToolResponse.Validate();
    }

    [Fact]
    public async Task Get_Works()
    {
        var toolDefinition = await this.Client.Tools.Get(new() { Name = "name" });
        toolDefinition.Validate();
    }
}
