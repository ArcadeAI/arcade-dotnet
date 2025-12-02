using ArcadeDotnet.Models.Tools;

namespace ArcadeDotnet.Tests.Models.Tools;

public class AuthorizeToolRequestTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthorizeToolRequest
        {
            ToolName = "tool_name",
            NextUri = "next_uri",
            ToolVersion = "tool_version",
            UserID = "user_id",
        };

        string expectedToolName = "tool_name";
        string expectedNextUri = "next_uri";
        string expectedToolVersion = "tool_version";
        string expectedUserID = "user_id";

        Assert.Equal(expectedToolName, model.ToolName);
        Assert.Equal(expectedNextUri, model.NextUri);
        Assert.Equal(expectedToolVersion, model.ToolVersion);
        Assert.Equal(expectedUserID, model.UserID);
    }
}
