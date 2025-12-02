using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Models;
using ArcadeDotnet.Models.Tools.Scheduled;
using Tools = ArcadeDotnet.Models.Tools;

namespace ArcadeDotnet.Tests.Models.Tools.Scheduled;

public class ScheduledGetResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ScheduledGetResponse
        {
            ID = "id",
            Attempts =
            [
                new()
                {
                    ID = "id",
                    FinishedAt = "finished_at",
                    Output = new()
                    {
                        Authorization = new()
                        {
                            ID = "id",
                            Context = new()
                            {
                                Token = "token",
                                UserInfo = new Dictionary<string, JsonElement>()
                                {
                                    { "foo", JsonSerializer.SerializeToElement("bar") },
                                },
                            },
                            ProviderID = "provider_id",
                            Scopes = ["string"],
                            Status = Status.NotStarted,
                            URL = "url",
                            UserID = "user_id",
                        },
                        Error = new()
                        {
                            CanRetry = true,
                            Kind = Tools::ToolExecutionAttemptOutputErrorKind.ToolkitLoadFailed,
                            Message = "message",
                            AdditionalPromptContent = "additional_prompt_content",
                            DeveloperMessage = "developer_message",
                            Extra = new Dictionary<string, JsonElement>()
                            {
                                { "foo", JsonSerializer.SerializeToElement("bar") },
                            },
                            RetryAfterMs = 0,
                            Stacktrace = "stacktrace",
                            StatusCode = 0,
                        },
                        Logs =
                        [
                            new()
                            {
                                Level = "level",
                                Message = "message",
                                Subtype = "subtype",
                            },
                        ],
                        Value = JsonSerializer.Deserialize<JsonElement>("{}"),
                    },
                    StartedAt = "started_at",
                    Success = true,
                    SystemErrorMessage = "system_error_message",
                },
            ],
            CreatedAt = "created_at",
            ExecutionStatus = "execution_status",
            ExecutionType = "execution_type",
            FinishedAt = "finished_at",
            Input = new Dictionary<string, JsonElement>()
            {
                { "foo", JsonSerializer.SerializeToElement("bar") },
            },
            RunAt = "run_at",
            StartedAt = "started_at",
            ToolName = "tool_name",
            ToolkitName = "toolkit_name",
            ToolkitVersion = "toolkit_version",
            UpdatedAt = "updated_at",
            UserID = "user_id",
        };

        string expectedID = "id";
        List<Tools::ToolExecutionAttempt> expectedAttempts =
        [
            new()
            {
                ID = "id",
                FinishedAt = "finished_at",
                Output = new()
                {
                    Authorization = new()
                    {
                        ID = "id",
                        Context = new()
                        {
                            Token = "token",
                            UserInfo = new Dictionary<string, JsonElement>()
                            {
                                { "foo", JsonSerializer.SerializeToElement("bar") },
                            },
                        },
                        ProviderID = "provider_id",
                        Scopes = ["string"],
                        Status = Status.NotStarted,
                        URL = "url",
                        UserID = "user_id",
                    },
                    Error = new()
                    {
                        CanRetry = true,
                        Kind = Tools::ToolExecutionAttemptOutputErrorKind.ToolkitLoadFailed,
                        Message = "message",
                        AdditionalPromptContent = "additional_prompt_content",
                        DeveloperMessage = "developer_message",
                        Extra = new Dictionary<string, JsonElement>()
                        {
                            { "foo", JsonSerializer.SerializeToElement("bar") },
                        },
                        RetryAfterMs = 0,
                        Stacktrace = "stacktrace",
                        StatusCode = 0,
                    },
                    Logs =
                    [
                        new()
                        {
                            Level = "level",
                            Message = "message",
                            Subtype = "subtype",
                        },
                    ],
                    Value = JsonSerializer.Deserialize<JsonElement>("{}"),
                },
                StartedAt = "started_at",
                Success = true,
                SystemErrorMessage = "system_error_message",
            },
        ];
        string expectedCreatedAt = "created_at";
        string expectedExecutionStatus = "execution_status";
        string expectedExecutionType = "execution_type";
        string expectedFinishedAt = "finished_at";
        Dictionary<string, JsonElement> expectedInput = new()
        {
            { "foo", JsonSerializer.SerializeToElement("bar") },
        };
        string expectedRunAt = "run_at";
        string expectedStartedAt = "started_at";
        string expectedToolName = "tool_name";
        string expectedToolkitName = "toolkit_name";
        string expectedToolkitVersion = "toolkit_version";
        string expectedUpdatedAt = "updated_at";
        string expectedUserID = "user_id";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedAttempts.Count, model.Attempts.Count);
        for (int i = 0; i < expectedAttempts.Count; i++)
        {
            Assert.Equal(expectedAttempts[i], model.Attempts[i]);
        }
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
        Assert.Equal(expectedExecutionStatus, model.ExecutionStatus);
        Assert.Equal(expectedExecutionType, model.ExecutionType);
        Assert.Equal(expectedFinishedAt, model.FinishedAt);
        Assert.Equal(expectedInput.Count, model.Input.Count);
        foreach (var item in expectedInput)
        {
            Assert.True(model.Input.TryGetValue(item.Key, out var value));

            Assert.True(JsonElement.DeepEquals(value, model.Input[item.Key]));
        }
        Assert.Equal(expectedRunAt, model.RunAt);
        Assert.Equal(expectedStartedAt, model.StartedAt);
        Assert.Equal(expectedToolName, model.ToolName);
        Assert.Equal(expectedToolkitName, model.ToolkitName);
        Assert.Equal(expectedToolkitVersion, model.ToolkitVersion);
        Assert.Equal(expectedUpdatedAt, model.UpdatedAt);
        Assert.Equal(expectedUserID, model.UserID);
    }
}
