using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Models.Tools;

namespace ArcadeDotnet.Tests.Models.Tools;

public class ToolExecuteParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new ToolExecuteParams
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

        Assert.Equal(expectedToolName, parameters.ToolName);
        Assert.Equal(expectedIncludeErrorStacktrace, parameters.IncludeErrorStacktrace);
        Assert.NotNull(parameters.Input);
        Assert.Equal(expectedInput.Count, parameters.Input.Count);
        foreach (var item in expectedInput)
        {
            Assert.True(parameters.Input.TryGetValue(item.Key, out var value));

            Assert.True(JsonElement.DeepEquals(value, parameters.Input[item.Key]));
        }
        Assert.Equal(expectedRunAt, parameters.RunAt);
        Assert.Equal(expectedToolVersion, parameters.ToolVersion);
        Assert.Equal(expectedUserID, parameters.UserID);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new ToolExecuteParams { ToolName = "tool_name" };

        Assert.Null(parameters.IncludeErrorStacktrace);
        Assert.False(parameters.RawBodyData.ContainsKey("include_error_stacktrace"));
        Assert.Null(parameters.Input);
        Assert.False(parameters.RawBodyData.ContainsKey("input"));
        Assert.Null(parameters.RunAt);
        Assert.False(parameters.RawBodyData.ContainsKey("run_at"));
        Assert.Null(parameters.ToolVersion);
        Assert.False(parameters.RawBodyData.ContainsKey("tool_version"));
        Assert.Null(parameters.UserID);
        Assert.False(parameters.RawBodyData.ContainsKey("user_id"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new ToolExecuteParams
        {
            ToolName = "tool_name",

            // Null should be interpreted as omitted for these properties
            IncludeErrorStacktrace = null,
            Input = null,
            RunAt = null,
            ToolVersion = null,
            UserID = null,
        };

        Assert.Null(parameters.IncludeErrorStacktrace);
        Assert.False(parameters.RawBodyData.ContainsKey("include_error_stacktrace"));
        Assert.Null(parameters.Input);
        Assert.False(parameters.RawBodyData.ContainsKey("input"));
        Assert.Null(parameters.RunAt);
        Assert.False(parameters.RawBodyData.ContainsKey("run_at"));
        Assert.Null(parameters.ToolVersion);
        Assert.False(parameters.RawBodyData.ContainsKey("tool_version"));
        Assert.Null(parameters.UserID);
        Assert.False(parameters.RawBodyData.ContainsKey("user_id"));
    }
}
