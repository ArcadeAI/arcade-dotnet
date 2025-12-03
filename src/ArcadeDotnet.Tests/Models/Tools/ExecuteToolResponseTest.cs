using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models;
using Tools = ArcadeDotnet.Models.Tools;

namespace ArcadeDotnet.Tests.Models.Tools;

public class ExecuteToolResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Tools::ExecuteToolResponse
        {
            ID = "id",
            Duration = 0,
            ExecutionID = "execution_id",
            ExecutionType = "execution_type",
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
                    Kind = Tools::Kind.ToolkitLoadFailed,
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
            RunAt = "run_at",
            Status = "status",
            Success = true,
        };

        string expectedID = "id";
        double expectedDuration = 0;
        string expectedExecutionID = "execution_id";
        string expectedExecutionType = "execution_type";
        string expectedFinishedAt = "finished_at";
        Tools::Output expectedOutput = new()
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
                Kind = Tools::Kind.ToolkitLoadFailed,
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
        };
        string expectedRunAt = "run_at";
        string expectedStatus = "status";
        bool expectedSuccess = true;

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedDuration, model.Duration);
        Assert.Equal(expectedExecutionID, model.ExecutionID);
        Assert.Equal(expectedExecutionType, model.ExecutionType);
        Assert.Equal(expectedFinishedAt, model.FinishedAt);
        Assert.Equal(expectedOutput, model.Output);
        Assert.Equal(expectedRunAt, model.RunAt);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedSuccess, model.Success);
    }
}

public class OutputTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Tools::Output
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
                Kind = Tools::Kind.ToolkitLoadFailed,
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
        };

        AuthorizationResponse expectedAuthorization = new()
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
        };
        Tools::Error expectedError = new()
        {
            CanRetry = true,
            Kind = Tools::Kind.ToolkitLoadFailed,
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
        };
        List<Tools::Log> expectedLogs =
        [
            new()
            {
                Level = "level",
                Message = "message",
                Subtype = "subtype",
            },
        ];
        JsonElement expectedValue = JsonSerializer.Deserialize<JsonElement>("{}");

        Assert.Equal(expectedAuthorization, model.Authorization);
        Assert.Equal(expectedError, model.Error);
        Assert.Equal(expectedLogs.Count, model.Logs.Count);
        for (int i = 0; i < expectedLogs.Count; i++)
        {
            Assert.Equal(expectedLogs[i], model.Logs[i]);
        }
        Assert.True(
            model.Value.HasValue && JsonElement.DeepEquals(expectedValue, model.Value.Value)
        );
    }
}

public class ErrorTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Tools::Error
        {
            CanRetry = true,
            Kind = Tools::Kind.ToolkitLoadFailed,
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
        };

        bool expectedCanRetry = true;
        ApiEnum<string, Tools::Kind> expectedKind = Tools::Kind.ToolkitLoadFailed;
        string expectedMessage = "message";
        string expectedAdditionalPromptContent = "additional_prompt_content";
        string expectedDeveloperMessage = "developer_message";
        Dictionary<string, JsonElement> expectedExtra = new()
        {
            { "foo", JsonSerializer.SerializeToElement("bar") },
        };
        long expectedRetryAfterMs = 0;
        string expectedStacktrace = "stacktrace";
        long expectedStatusCode = 0;

        Assert.Equal(expectedCanRetry, model.CanRetry);
        Assert.Equal(expectedKind, model.Kind);
        Assert.Equal(expectedMessage, model.Message);
        Assert.Equal(expectedAdditionalPromptContent, model.AdditionalPromptContent);
        Assert.Equal(expectedDeveloperMessage, model.DeveloperMessage);
        Assert.Equal(expectedExtra.Count, model.Extra.Count);
        foreach (var item in expectedExtra)
        {
            Assert.True(model.Extra.TryGetValue(item.Key, out var value));

            Assert.True(JsonElement.DeepEquals(value, model.Extra[item.Key]));
        }
        Assert.Equal(expectedRetryAfterMs, model.RetryAfterMs);
        Assert.Equal(expectedStacktrace, model.Stacktrace);
        Assert.Equal(expectedStatusCode, model.StatusCode);
    }
}

public class LogTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Tools::Log
        {
            Level = "level",
            Message = "message",
            Subtype = "subtype",
        };

        string expectedLevel = "level";
        string expectedMessage = "message";
        string expectedSubtype = "subtype";

        Assert.Equal(expectedLevel, model.Level);
        Assert.Equal(expectedMessage, model.Message);
        Assert.Equal(expectedSubtype, model.Subtype);
    }
}
