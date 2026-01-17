using System;
using ArcadeDotnet.Models.Tools;

namespace ArcadeDotnet.Tests.Models.Tools;

public class ToolAuthorizeParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new ToolAuthorizeParams
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

        Assert.Equal(expectedToolName, parameters.ToolName);
        Assert.Equal(expectedNextUri, parameters.NextUri);
        Assert.Equal(expectedToolVersion, parameters.ToolVersion);
        Assert.Equal(expectedUserID, parameters.UserID);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new ToolAuthorizeParams { ToolName = "tool_name" };

        Assert.Null(parameters.NextUri);
        Assert.False(parameters.RawBodyData.ContainsKey("next_uri"));
        Assert.Null(parameters.ToolVersion);
        Assert.False(parameters.RawBodyData.ContainsKey("tool_version"));
        Assert.Null(parameters.UserID);
        Assert.False(parameters.RawBodyData.ContainsKey("user_id"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new ToolAuthorizeParams
        {
            ToolName = "tool_name",

            // Null should be interpreted as omitted for these properties
            NextUri = null,
            ToolVersion = null,
            UserID = null,
        };

        Assert.Null(parameters.NextUri);
        Assert.False(parameters.RawBodyData.ContainsKey("next_uri"));
        Assert.Null(parameters.ToolVersion);
        Assert.False(parameters.RawBodyData.ContainsKey("tool_version"));
        Assert.Null(parameters.UserID);
        Assert.False(parameters.RawBodyData.ContainsKey("user_id"));
    }

    [Fact]
    public void Url_Works()
    {
        ToolAuthorizeParams parameters = new() { ToolName = "tool_name" };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(new Uri("https://api.arcade.dev/v1/tools/authorize"), url);
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var parameters = new ToolAuthorizeParams
        {
            ToolName = "tool_name",
            NextUri = "next_uri",
            ToolVersion = "tool_version",
            UserID = "user_id",
        };

        ToolAuthorizeParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}
