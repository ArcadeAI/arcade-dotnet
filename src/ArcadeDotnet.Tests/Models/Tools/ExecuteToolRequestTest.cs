using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Core;
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
            QueryID = "query_id",
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
        string expectedQueryID = "query_id";
        string expectedRunAt = "run_at";
        string expectedToolVersion = "tool_version";
        string expectedUserID = "user_id";

        Assert.Equal(expectedToolName, model.ToolName);
        Assert.Equal(expectedIncludeErrorStacktrace, model.IncludeErrorStacktrace);
        Assert.NotNull(model.Input);
        Assert.Equal(expectedInput.Count, model.Input.Count);
        foreach (var item in expectedInput)
        {
            Assert.True(model.Input.TryGetValue(item.Key, out var value));

            Assert.True(JsonElement.DeepEquals(value, model.Input[item.Key]));
        }
        Assert.Equal(expectedQueryID, model.QueryID);
        Assert.Equal(expectedRunAt, model.RunAt);
        Assert.Equal(expectedToolVersion, model.ToolVersion);
        Assert.Equal(expectedUserID, model.UserID);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new ExecuteToolRequest
        {
            ToolName = "tool_name",
            IncludeErrorStacktrace = true,
            Input = new Dictionary<string, JsonElement>()
            {
                { "foo", JsonSerializer.SerializeToElement("bar") },
            },
            QueryID = "query_id",
            RunAt = "run_at",
            ToolVersion = "tool_version",
            UserID = "user_id",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ExecuteToolRequest>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ExecuteToolRequest
        {
            ToolName = "tool_name",
            IncludeErrorStacktrace = true,
            Input = new Dictionary<string, JsonElement>()
            {
                { "foo", JsonSerializer.SerializeToElement("bar") },
            },
            QueryID = "query_id",
            RunAt = "run_at",
            ToolVersion = "tool_version",
            UserID = "user_id",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ExecuteToolRequest>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedToolName = "tool_name";
        bool expectedIncludeErrorStacktrace = true;
        Dictionary<string, JsonElement> expectedInput = new()
        {
            { "foo", JsonSerializer.SerializeToElement("bar") },
        };
        string expectedQueryID = "query_id";
        string expectedRunAt = "run_at";
        string expectedToolVersion = "tool_version";
        string expectedUserID = "user_id";

        Assert.Equal(expectedToolName, deserialized.ToolName);
        Assert.Equal(expectedIncludeErrorStacktrace, deserialized.IncludeErrorStacktrace);
        Assert.NotNull(deserialized.Input);
        Assert.Equal(expectedInput.Count, deserialized.Input.Count);
        foreach (var item in expectedInput)
        {
            Assert.True(deserialized.Input.TryGetValue(item.Key, out var value));

            Assert.True(JsonElement.DeepEquals(value, deserialized.Input[item.Key]));
        }
        Assert.Equal(expectedQueryID, deserialized.QueryID);
        Assert.Equal(expectedRunAt, deserialized.RunAt);
        Assert.Equal(expectedToolVersion, deserialized.ToolVersion);
        Assert.Equal(expectedUserID, deserialized.UserID);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new ExecuteToolRequest
        {
            ToolName = "tool_name",
            IncludeErrorStacktrace = true,
            Input = new Dictionary<string, JsonElement>()
            {
                { "foo", JsonSerializer.SerializeToElement("bar") },
            },
            QueryID = "query_id",
            RunAt = "run_at",
            ToolVersion = "tool_version",
            UserID = "user_id",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new ExecuteToolRequest { ToolName = "tool_name" };

        Assert.Null(model.IncludeErrorStacktrace);
        Assert.False(model.RawData.ContainsKey("include_error_stacktrace"));
        Assert.Null(model.Input);
        Assert.False(model.RawData.ContainsKey("input"));
        Assert.Null(model.QueryID);
        Assert.False(model.RawData.ContainsKey("query_id"));
        Assert.Null(model.RunAt);
        Assert.False(model.RawData.ContainsKey("run_at"));
        Assert.Null(model.ToolVersion);
        Assert.False(model.RawData.ContainsKey("tool_version"));
        Assert.Null(model.UserID);
        Assert.False(model.RawData.ContainsKey("user_id"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new ExecuteToolRequest { ToolName = "tool_name" };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new ExecuteToolRequest
        {
            ToolName = "tool_name",

            // Null should be interpreted as omitted for these properties
            IncludeErrorStacktrace = null,
            Input = null,
            QueryID = null,
            RunAt = null,
            ToolVersion = null,
            UserID = null,
        };

        Assert.Null(model.IncludeErrorStacktrace);
        Assert.False(model.RawData.ContainsKey("include_error_stacktrace"));
        Assert.Null(model.Input);
        Assert.False(model.RawData.ContainsKey("input"));
        Assert.Null(model.QueryID);
        Assert.False(model.RawData.ContainsKey("query_id"));
        Assert.Null(model.RunAt);
        Assert.False(model.RawData.ContainsKey("run_at"));
        Assert.Null(model.ToolVersion);
        Assert.False(model.RawData.ContainsKey("tool_version"));
        Assert.Null(model.UserID);
        Assert.False(model.RawData.ContainsKey("user_id"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new ExecuteToolRequest
        {
            ToolName = "tool_name",

            // Null should be interpreted as omitted for these properties
            IncludeErrorStacktrace = null,
            Input = null,
            QueryID = null,
            RunAt = null,
            ToolVersion = null,
            UserID = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new ExecuteToolRequest
        {
            ToolName = "tool_name",
            IncludeErrorStacktrace = true,
            Input = new Dictionary<string, JsonElement>()
            {
                { "foo", JsonSerializer.SerializeToElement("bar") },
            },
            QueryID = "query_id",
            RunAt = "run_at",
            ToolVersion = "tool_version",
            UserID = "user_id",
        };

        ExecuteToolRequest copied = new(model);

        Assert.Equal(model, copied);
    }
}
