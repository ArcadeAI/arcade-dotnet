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
}
