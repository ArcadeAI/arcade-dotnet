using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Models.Tools;

namespace ArcadeDotnet.Tests.Models.Tools;

public class ExecuteToolRequestTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ExecuteToolRequest
        {
            ToolName = "tool_name",
            IncludeErrorStacktrace = true,
            Input = new Dictionary<string, JsonElement>()
            {
                { "foo", JsonSerializer.SerializeToElement("bar") },
            },
            RunAt = "run_at",
            ToolVersion = "tool_version",
            UserID = "user_id",
        };

        string expectedToolName = "tool_name";
        bool expectedIncludeErrorStacktrace = true;
        Dictionary<string, JsonElement> expectedInput = new()
        {
            { "foo", JsonSerializer.SerializeToElement("bar") },
        };
        string expectedRunAt = "run_at";
        string expectedToolVersion = "tool_version";
        string expectedUserID = "user_id";

        Assert.Equal(expectedToolName, model.ToolName);
        Assert.Equal(expectedIncludeErrorStacktrace, model.IncludeErrorStacktrace);
        Assert.Equal(expectedInput.Count, model.Input.Count);
        foreach (var item in expectedInput)
        {
            Assert.True(model.Input.TryGetValue(item.Key, out var value));

            Assert.True(JsonElement.DeepEquals(value, model.Input[item.Key]));
        }
        Assert.Equal(expectedRunAt, model.RunAt);
        Assert.Equal(expectedToolVersion, model.ToolVersion);
        Assert.Equal(expectedUserID, model.UserID);
    }
}
