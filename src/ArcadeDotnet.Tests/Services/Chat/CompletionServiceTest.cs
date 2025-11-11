using System.Threading.Tasks;

namespace ArcadeDotnet.Tests.Services.Chat;

public class CompletionServiceTest : TestBase
{
    [Fact]
    public async Task Create_Works()
    {
        var chatResponse = await this.client.Chat.Completions.Create();
        chatResponse.Validate();
    }
}
