using System.Threading.Tasks;

namespace ArcadeEngine.Tests.Services.Chat.Completions;

public class CompletionServiceTest : TestBase
{
    [Fact]
    public async Task Create_Works()
    {
        var chatResponse = await this.client.Chat.Completions.Create();
        chatResponse.Validate();
    }
}
