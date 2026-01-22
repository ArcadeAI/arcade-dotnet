using System.Text.Json;
using ArcadeDotnet.Core;
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

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AuthorizeToolRequest
        {
            ToolName = "tool_name",
            NextUri = "next_uri",
            ToolVersion = "tool_version",
            UserID = "user_id",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AuthorizeToolRequest>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AuthorizeToolRequest
        {
            ToolName = "tool_name",
            NextUri = "next_uri",
            ToolVersion = "tool_version",
            UserID = "user_id",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AuthorizeToolRequest>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedToolName = "tool_name";
        string expectedNextUri = "next_uri";
        string expectedToolVersion = "tool_version";
        string expectedUserID = "user_id";

        Assert.Equal(expectedToolName, deserialized.ToolName);
        Assert.Equal(expectedNextUri, deserialized.NextUri);
        Assert.Equal(expectedToolVersion, deserialized.ToolVersion);
        Assert.Equal(expectedUserID, deserialized.UserID);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AuthorizeToolRequest
        {
            ToolName = "tool_name",
            NextUri = "next_uri",
            ToolVersion = "tool_version",
            UserID = "user_id",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthorizeToolRequest { ToolName = "tool_name" };

        Assert.Null(model.NextUri);
        Assert.False(model.RawData.ContainsKey("next_uri"));
        Assert.Null(model.ToolVersion);
        Assert.False(model.RawData.ContainsKey("tool_version"));
        Assert.Null(model.UserID);
        Assert.False(model.RawData.ContainsKey("user_id"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AuthorizeToolRequest { ToolName = "tool_name" };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthorizeToolRequest
        {
            ToolName = "tool_name",

            // Null should be interpreted as omitted for these properties
            NextUri = null,
            ToolVersion = null,
            UserID = null,
        };

        Assert.Null(model.NextUri);
        Assert.False(model.RawData.ContainsKey("next_uri"));
        Assert.Null(model.ToolVersion);
        Assert.False(model.RawData.ContainsKey("tool_version"));
        Assert.Null(model.UserID);
        Assert.False(model.RawData.ContainsKey("user_id"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new AuthorizeToolRequest
        {
            ToolName = "tool_name",

            // Null should be interpreted as omitted for these properties
            NextUri = null,
            ToolVersion = null,
            UserID = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new AuthorizeToolRequest
        {
            ToolName = "tool_name",
            NextUri = "next_uri",
            ToolVersion = "tool_version",
            UserID = "user_id",
        };

        AuthorizeToolRequest copied = new(model);

        Assert.Equal(model, copied);
    }
}
