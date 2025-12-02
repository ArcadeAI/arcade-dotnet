using System.Collections.Generic;
using ArcadeDotnet.Models.Tools;
using ArcadeDotnet.Models.Tools.Scheduled;

namespace ArcadeDotnet.Tests.Models.Tools.Scheduled;

public class ScheduledListPageResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ScheduledListPageResponse
        {
            Items =
            [
                new()
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
                },
            ],
            Limit = 0,
            Offset = 0,
            PageCount = 0,
            TotalCount = 0,
        };

        List<ToolExecution> expectedItems =
        [
            new()
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
            },
        ];
        long expectedLimit = 0;
        long expectedOffset = 0;
        long expectedPageCount = 0;
        long expectedTotalCount = 0;

        Assert.Equal(expectedItems.Count, model.Items.Count);
        for (int i = 0; i < expectedItems.Count; i++)
        {
            Assert.Equal(expectedItems[i], model.Items[i]);
        }
        Assert.Equal(expectedLimit, model.Limit);
        Assert.Equal(expectedOffset, model.Offset);
        Assert.Equal(expectedPageCount, model.PageCount);
        Assert.Equal(expectedTotalCount, model.TotalCount);
    }
}
