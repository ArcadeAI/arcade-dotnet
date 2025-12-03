using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models;
using Tools = ArcadeDotnet.Models.Tools;

namespace ArcadeDotnet.Tests.Models.Tools;

public class ToolExecutionAttemptTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Tools::ToolExecutionAttempt
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
        };

        string expectedID = "id";
        string expectedFinishedAt = "finished_at";
        Tools::ToolExecutionAttemptOutput expectedOutput = new()
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
        };
        string expectedStartedAt = "started_at";
        bool expectedSuccess = true;
        string expectedSystemErrorMessage = "system_error_message";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedFinishedAt, model.FinishedAt);
        Assert.Equal(expectedOutput, model.Output);
        Assert.Equal(expectedStartedAt, model.StartedAt);
        Assert.Equal(expectedSuccess, model.Success);
        Assert.Equal(expectedSystemErrorMessage, model.SystemErrorMessage);
    }
}

public class ToolExecutionAttemptOutputTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Tools::ToolExecutionAttemptOutput
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
        Tools::ToolExecutionAttemptOutputError expectedError = new()
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
        };
        List<Tools::LogModel> expectedLogs =
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

public class ToolExecutionAttemptOutputErrorTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Tools::ToolExecutionAttemptOutputError
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
        };

        bool expectedCanRetry = true;
        ApiEnum<string, Tools::ToolExecutionAttemptOutputErrorKind> expectedKind =
            Tools::ToolExecutionAttemptOutputErrorKind.ToolkitLoadFailed;
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

public class LogModelTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Tools::LogModel
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
