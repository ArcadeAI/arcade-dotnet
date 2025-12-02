using ArcadeDotnet.Models.Chat;

namespace ArcadeDotnet.Tests.Models.Chat;

public class UsageTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Usage
        {
            CompletionTokens = 0,
            PromptTokens = 0,
            TotalTokens = 0,
        };

        long expectedCompletionTokens = 0;
        long expectedPromptTokens = 0;
        long expectedTotalTokens = 0;

        Assert.Equal(expectedCompletionTokens, model.CompletionTokens);
        Assert.Equal(expectedPromptTokens, model.PromptTokens);
        Assert.Equal(expectedTotalTokens, model.TotalTokens);
    }
}
