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

    [Fact]
    public void SerializationRoundtrip_Works()
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

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Tools::ToolExecutionAttempt>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
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

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Tools::ToolExecutionAttempt>(json);
        Assert.NotNull(deserialized);

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

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedFinishedAt, deserialized.FinishedAt);
        Assert.Equal(expectedOutput, deserialized.Output);
        Assert.Equal(expectedStartedAt, deserialized.StartedAt);
        Assert.Equal(expectedSuccess, deserialized.Success);
        Assert.Equal(expectedSystemErrorMessage, deserialized.SystemErrorMessage);
    }

    [Fact]
    public void Validation_Works()
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

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Tools::ToolExecutionAttempt { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.FinishedAt);
        Assert.False(model.RawData.ContainsKey("finished_at"));
        Assert.Null(model.Output);
        Assert.False(model.RawData.ContainsKey("output"));
        Assert.Null(model.StartedAt);
        Assert.False(model.RawData.ContainsKey("started_at"));
        Assert.Null(model.Success);
        Assert.False(model.RawData.ContainsKey("success"));
        Assert.Null(model.SystemErrorMessage);
        Assert.False(model.RawData.ContainsKey("system_error_message"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Tools::ToolExecutionAttempt { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Tools::ToolExecutionAttempt
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            FinishedAt = null,
            Output = null,
            StartedAt = null,
            Success = null,
            SystemErrorMessage = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.FinishedAt);
        Assert.False(model.RawData.ContainsKey("finished_at"));
        Assert.Null(model.Output);
        Assert.False(model.RawData.ContainsKey("output"));
        Assert.Null(model.StartedAt);
        Assert.False(model.RawData.ContainsKey("started_at"));
        Assert.Null(model.Success);
        Assert.False(model.RawData.ContainsKey("success"));
        Assert.Null(model.SystemErrorMessage);
        Assert.False(model.RawData.ContainsKey("system_error_message"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Tools::ToolExecutionAttempt
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            FinishedAt = null,
            Output = null,
            StartedAt = null,
            Success = null,
            SystemErrorMessage = null,
        };

        model.Validate();
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

    [Fact]
    public void SerializationRoundtrip_Works()
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

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Tools::ToolExecutionAttemptOutput>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
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

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Tools::ToolExecutionAttemptOutput>(json);
        Assert.NotNull(deserialized);

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

        Assert.Equal(expectedAuthorization, deserialized.Authorization);
        Assert.Equal(expectedError, deserialized.Error);
        Assert.Equal(expectedLogs.Count, deserialized.Logs.Count);
        for (int i = 0; i < expectedLogs.Count; i++)
        {
            Assert.Equal(expectedLogs[i], deserialized.Logs[i]);
        }
        Assert.True(
            deserialized.Value.HasValue
                && JsonElement.DeepEquals(expectedValue, deserialized.Value.Value)
        );
    }

    [Fact]
    public void Validation_Works()
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

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Tools::ToolExecutionAttemptOutput { };

        Assert.Null(model.Authorization);
        Assert.False(model.RawData.ContainsKey("authorization"));
        Assert.Null(model.Error);
        Assert.False(model.RawData.ContainsKey("error"));
        Assert.Null(model.Logs);
        Assert.False(model.RawData.ContainsKey("logs"));
        Assert.Null(model.Value);
        Assert.False(model.RawData.ContainsKey("value"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Tools::ToolExecutionAttemptOutput { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Tools::ToolExecutionAttemptOutput
        {
            // Null should be interpreted as omitted for these properties
            Authorization = null,
            Error = null,
            Logs = null,
            Value = null,
        };

        Assert.Null(model.Authorization);
        Assert.False(model.RawData.ContainsKey("authorization"));
        Assert.Null(model.Error);
        Assert.False(model.RawData.ContainsKey("error"));
        Assert.Null(model.Logs);
        Assert.False(model.RawData.ContainsKey("logs"));
        Assert.Null(model.Value);
        Assert.False(model.RawData.ContainsKey("value"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Tools::ToolExecutionAttemptOutput
        {
            // Null should be interpreted as omitted for these properties
            Authorization = null,
            Error = null,
            Logs = null,
            Value = null,
        };

        model.Validate();
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

    [Fact]
    public void SerializationRoundtrip_Works()
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

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Tools::ToolExecutionAttemptOutputError>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
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

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Tools::ToolExecutionAttemptOutputError>(json);
        Assert.NotNull(deserialized);

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

        Assert.Equal(expectedCanRetry, deserialized.CanRetry);
        Assert.Equal(expectedKind, deserialized.Kind);
        Assert.Equal(expectedMessage, deserialized.Message);
        Assert.Equal(expectedAdditionalPromptContent, deserialized.AdditionalPromptContent);
        Assert.Equal(expectedDeveloperMessage, deserialized.DeveloperMessage);
        Assert.Equal(expectedExtra.Count, deserialized.Extra.Count);
        foreach (var item in expectedExtra)
        {
            Assert.True(deserialized.Extra.TryGetValue(item.Key, out var value));

            Assert.True(JsonElement.DeepEquals(value, deserialized.Extra[item.Key]));
        }
        Assert.Equal(expectedRetryAfterMs, deserialized.RetryAfterMs);
        Assert.Equal(expectedStacktrace, deserialized.Stacktrace);
        Assert.Equal(expectedStatusCode, deserialized.StatusCode);
    }

    [Fact]
    public void Validation_Works()
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

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Tools::ToolExecutionAttemptOutputError
        {
            CanRetry = true,
            Kind = Tools::ToolExecutionAttemptOutputErrorKind.ToolkitLoadFailed,
            Message = "message",
        };

        Assert.Null(model.AdditionalPromptContent);
        Assert.False(model.RawData.ContainsKey("additional_prompt_content"));
        Assert.Null(model.DeveloperMessage);
        Assert.False(model.RawData.ContainsKey("developer_message"));
        Assert.Null(model.Extra);
        Assert.False(model.RawData.ContainsKey("extra"));
        Assert.Null(model.RetryAfterMs);
        Assert.False(model.RawData.ContainsKey("retry_after_ms"));
        Assert.Null(model.Stacktrace);
        Assert.False(model.RawData.ContainsKey("stacktrace"));
        Assert.Null(model.StatusCode);
        Assert.False(model.RawData.ContainsKey("status_code"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Tools::ToolExecutionAttemptOutputError
        {
            CanRetry = true,
            Kind = Tools::ToolExecutionAttemptOutputErrorKind.ToolkitLoadFailed,
            Message = "message",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Tools::ToolExecutionAttemptOutputError
        {
            CanRetry = true,
            Kind = Tools::ToolExecutionAttemptOutputErrorKind.ToolkitLoadFailed,
            Message = "message",

            // Null should be interpreted as omitted for these properties
            AdditionalPromptContent = null,
            DeveloperMessage = null,
            Extra = null,
            RetryAfterMs = null,
            Stacktrace = null,
            StatusCode = null,
        };

        Assert.Null(model.AdditionalPromptContent);
        Assert.False(model.RawData.ContainsKey("additional_prompt_content"));
        Assert.Null(model.DeveloperMessage);
        Assert.False(model.RawData.ContainsKey("developer_message"));
        Assert.Null(model.Extra);
        Assert.False(model.RawData.ContainsKey("extra"));
        Assert.Null(model.RetryAfterMs);
        Assert.False(model.RawData.ContainsKey("retry_after_ms"));
        Assert.Null(model.Stacktrace);
        Assert.False(model.RawData.ContainsKey("stacktrace"));
        Assert.Null(model.StatusCode);
        Assert.False(model.RawData.ContainsKey("status_code"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Tools::ToolExecutionAttemptOutputError
        {
            CanRetry = true,
            Kind = Tools::ToolExecutionAttemptOutputErrorKind.ToolkitLoadFailed,
            Message = "message",

            // Null should be interpreted as omitted for these properties
            AdditionalPromptContent = null,
            DeveloperMessage = null,
            Extra = null,
            RetryAfterMs = null,
            Stacktrace = null,
            StatusCode = null,
        };

        model.Validate();
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

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Tools::LogModel
        {
            Level = "level",
            Message = "message",
            Subtype = "subtype",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Tools::LogModel>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Tools::LogModel
        {
            Level = "level",
            Message = "message",
            Subtype = "subtype",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Tools::LogModel>(json);
        Assert.NotNull(deserialized);

        string expectedLevel = "level";
        string expectedMessage = "message";
        string expectedSubtype = "subtype";

        Assert.Equal(expectedLevel, deserialized.Level);
        Assert.Equal(expectedMessage, deserialized.Message);
        Assert.Equal(expectedSubtype, deserialized.Subtype);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Tools::LogModel
        {
            Level = "level",
            Message = "message",
            Subtype = "subtype",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Tools::LogModel { Level = "level", Message = "message" };

        Assert.Null(model.Subtype);
        Assert.False(model.RawData.ContainsKey("subtype"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Tools::LogModel { Level = "level", Message = "message" };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Tools::LogModel
        {
            Level = "level",
            Message = "message",

            // Null should be interpreted as omitted for these properties
            Subtype = null,
        };

        Assert.Null(model.Subtype);
        Assert.False(model.RawData.ContainsKey("subtype"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Tools::LogModel
        {
            Level = "level",
            Message = "message",

            // Null should be interpreted as omitted for these properties
            Subtype = null,
        };

        model.Validate();
    }
}
