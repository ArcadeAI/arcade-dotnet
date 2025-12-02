using ArcadeDotnet.Models;

namespace ArcadeDotnet.Tests.Models;

public class ErrorTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Error { Message = "message", Name = "name" };

        string expectedMessage = "message";
        string expectedName = "name";

        Assert.Equal(expectedMessage, model.Message);
        Assert.Equal(expectedName, model.Name);
    }
}
