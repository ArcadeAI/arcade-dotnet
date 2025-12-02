using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Chat.Completions;

namespace ArcadeDotnet.Tests.Models.Chat.Completions;

public class ResponseFormatTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ResponseFormat { Type = Type.JsonObject };

        ApiEnum<string, Type> expectedType = Type.JsonObject;

        Assert.Equal(expectedType, model.Type);
    }
}

public class StreamOptionsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new StreamOptions { IncludeUsage = true };

        bool expectedIncludeUsage = true;

        Assert.Equal(expectedIncludeUsage, model.IncludeUsage);
    }
}
