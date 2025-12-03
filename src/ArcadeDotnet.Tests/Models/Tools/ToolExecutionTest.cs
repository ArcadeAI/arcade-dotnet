using System.Text.Json;
using ArcadeDotnet.Models.Tools;

namespace ArcadeDotnet.Tests.Models.Tools;

public class ToolExecutionTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ToolExecution
        {
            ID = "id",
            CreatedAt = "created_at",
            ExecutionStatus = "execution_status",
            ExecutionType = "execution_type",
            FinishedAt = "finished_at",
            RunAt = "run_at",
            StartedAt = "started_at",
            ToolName = "tool_name",
            ToolkitName = "toolkit_name",
            ToolkitVersion = "toolkit_version",
            UpdatedAt = "updated_at",
            UserID = "user_id",
        };

        string expectedID = "id";
        string expectedCreatedAt = "created_at";
        string expectedExecutionStatus = "execution_status";
        string expectedExecutionType = "execution_type";
        string expectedFinishedAt = "finished_at";
        string expectedRunAt = "run_at";
        string expectedStartedAt = "started_at";
        string expectedToolName = "tool_name";
        string expectedToolkitName = "toolkit_name";
        string expectedToolkitVersion = "toolkit_version";
        string expectedUpdatedAt = "updated_at";
        string expectedUserID = "user_id";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
        Assert.Equal(expectedExecutionStatus, model.ExecutionStatus);
        Assert.Equal(expectedExecutionType, model.ExecutionType);
        Assert.Equal(expectedFinishedAt, model.FinishedAt);
        Assert.Equal(expectedRunAt, model.RunAt);
        Assert.Equal(expectedStartedAt, model.StartedAt);
        Assert.Equal(expectedToolName, model.ToolName);
        Assert.Equal(expectedToolkitName, model.ToolkitName);
        Assert.Equal(expectedToolkitVersion, model.ToolkitVersion);
        Assert.Equal(expectedUpdatedAt, model.UpdatedAt);
        Assert.Equal(expectedUserID, model.UserID);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new ToolExecution
        {
            ID = "id",
            CreatedAt = "created_at",
            ExecutionStatus = "execution_status",
            ExecutionType = "execution_type",
            FinishedAt = "finished_at",
            RunAt = "run_at",
            StartedAt = "started_at",
            ToolName = "tool_name",
            ToolkitName = "toolkit_name",
            ToolkitVersion = "toolkit_version",
            UpdatedAt = "updated_at",
            UserID = "user_id",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ToolExecution>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ToolExecution
        {
            ID = "id",
            CreatedAt = "created_at",
            ExecutionStatus = "execution_status",
            ExecutionType = "execution_type",
            FinishedAt = "finished_at",
            RunAt = "run_at",
            StartedAt = "started_at",
            ToolName = "tool_name",
            ToolkitName = "toolkit_name",
            ToolkitVersion = "toolkit_version",
            UpdatedAt = "updated_at",
            UserID = "user_id",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ToolExecution>(json);
        Assert.NotNull(deserialized);

        string expectedID = "id";
        string expectedCreatedAt = "created_at";
        string expectedExecutionStatus = "execution_status";
        string expectedExecutionType = "execution_type";
        string expectedFinishedAt = "finished_at";
        string expectedRunAt = "run_at";
        string expectedStartedAt = "started_at";
        string expectedToolName = "tool_name";
        string expectedToolkitName = "toolkit_name";
        string expectedToolkitVersion = "toolkit_version";
        string expectedUpdatedAt = "updated_at";
        string expectedUserID = "user_id";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedCreatedAt, deserialized.CreatedAt);
        Assert.Equal(expectedExecutionStatus, deserialized.ExecutionStatus);
        Assert.Equal(expectedExecutionType, deserialized.ExecutionType);
        Assert.Equal(expectedFinishedAt, deserialized.FinishedAt);
        Assert.Equal(expectedRunAt, deserialized.RunAt);
        Assert.Equal(expectedStartedAt, deserialized.StartedAt);
        Assert.Equal(expectedToolName, deserialized.ToolName);
        Assert.Equal(expectedToolkitName, deserialized.ToolkitName);
        Assert.Equal(expectedToolkitVersion, deserialized.ToolkitVersion);
        Assert.Equal(expectedUpdatedAt, deserialized.UpdatedAt);
        Assert.Equal(expectedUserID, deserialized.UserID);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new ToolExecution
        {
            ID = "id",
            CreatedAt = "created_at",
            ExecutionStatus = "execution_status",
            ExecutionType = "execution_type",
            FinishedAt = "finished_at",
            RunAt = "run_at",
            StartedAt = "started_at",
            ToolName = "tool_name",
            ToolkitName = "toolkit_name",
            ToolkitVersion = "toolkit_version",
            UpdatedAt = "updated_at",
            UserID = "user_id",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new ToolExecution { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.CreatedAt);
        Assert.False(model.RawData.ContainsKey("created_at"));
        Assert.Null(model.ExecutionStatus);
        Assert.False(model.RawData.ContainsKey("execution_status"));
        Assert.Null(model.ExecutionType);
        Assert.False(model.RawData.ContainsKey("execution_type"));
        Assert.Null(model.FinishedAt);
        Assert.False(model.RawData.ContainsKey("finished_at"));
        Assert.Null(model.RunAt);
        Assert.False(model.RawData.ContainsKey("run_at"));
        Assert.Null(model.StartedAt);
        Assert.False(model.RawData.ContainsKey("started_at"));
        Assert.Null(model.ToolName);
        Assert.False(model.RawData.ContainsKey("tool_name"));
        Assert.Null(model.ToolkitName);
        Assert.False(model.RawData.ContainsKey("toolkit_name"));
        Assert.Null(model.ToolkitVersion);
        Assert.False(model.RawData.ContainsKey("toolkit_version"));
        Assert.Null(model.UpdatedAt);
        Assert.False(model.RawData.ContainsKey("updated_at"));
        Assert.Null(model.UserID);
        Assert.False(model.RawData.ContainsKey("user_id"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new ToolExecution { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new ToolExecution
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            CreatedAt = null,
            ExecutionStatus = null,
            ExecutionType = null,
            FinishedAt = null,
            RunAt = null,
            StartedAt = null,
            ToolName = null,
            ToolkitName = null,
            ToolkitVersion = null,
            UpdatedAt = null,
            UserID = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.CreatedAt);
        Assert.False(model.RawData.ContainsKey("created_at"));
        Assert.Null(model.ExecutionStatus);
        Assert.False(model.RawData.ContainsKey("execution_status"));
        Assert.Null(model.ExecutionType);
        Assert.False(model.RawData.ContainsKey("execution_type"));
        Assert.Null(model.FinishedAt);
        Assert.False(model.RawData.ContainsKey("finished_at"));
        Assert.Null(model.RunAt);
        Assert.False(model.RawData.ContainsKey("run_at"));
        Assert.Null(model.StartedAt);
        Assert.False(model.RawData.ContainsKey("started_at"));
        Assert.Null(model.ToolName);
        Assert.False(model.RawData.ContainsKey("tool_name"));
        Assert.Null(model.ToolkitName);
        Assert.False(model.RawData.ContainsKey("toolkit_name"));
        Assert.Null(model.ToolkitVersion);
        Assert.False(model.RawData.ContainsKey("toolkit_version"));
        Assert.Null(model.UpdatedAt);
        Assert.False(model.RawData.ContainsKey("updated_at"));
        Assert.Null(model.UserID);
        Assert.False(model.RawData.ContainsKey("user_id"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new ToolExecution
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            CreatedAt = null,
            ExecutionStatus = null,
            ExecutionType = null,
            FinishedAt = null,
            RunAt = null,
            StartedAt = null,
            ToolName = null,
            ToolkitName = null,
            ToolkitVersion = null,
            UpdatedAt = null,
            UserID = null,
        };

        model.Validate();
    }
}
