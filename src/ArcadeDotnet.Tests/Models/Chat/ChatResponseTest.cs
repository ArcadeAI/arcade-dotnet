using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Models;
using ArcadeDotnet.Models.Chat;

namespace ArcadeDotnet.Tests.Models.Chat;

public class ChatResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ChatResponse
        {
            ID = "id",
            Choices =
            [
                new()
                {
                    FinishReason = "finish_reason",
                    Index = 0,
                    Logprobs = JsonSerializer.Deserialize<JsonElement>("{}"),
                    Message = new()
                    {
                        Content = "content",
                        Role = "role",
                        Name = "name",
                        ToolCallID = "tool_call_id",
                        ToolCalls =
                        [
                            new()
                            {
                                ID = "id",
                                Function = new() { Arguments = "arguments", Name = "name" },
                                Type = Type.Function,
                            },
                        ],
                    },
                    ToolAuthorizations =
                    [
                        new()
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
                            Url = "url",
                            UserID = "user_id",
                        },
                    ],
                    ToolMessages =
                    [
                        new()
                        {
                            Content = "content",
                            Role = "role",
                            Name = "name",
                            ToolCallID = "tool_call_id",
                            ToolCalls =
                            [
                                new()
                                {
                                    ID = "id",
                                    Function = new() { Arguments = "arguments", Name = "name" },
                                    Type = Type.Function,
                                },
                            ],
                        },
                    ],
                },
            ],
            Created = 0,
            Model = "model",
            Object = "object",
            SystemFingerprint = "system_fingerprint",
            Usage = new()
            {
                CompletionTokens = 0,
                PromptTokens = 0,
                TotalTokens = 0,
            },
        };

        string expectedID = "id";
        List<Choice> expectedChoices =
        [
            new()
            {
                FinishReason = "finish_reason",
                Index = 0,
                Logprobs = JsonSerializer.Deserialize<JsonElement>("{}"),
                Message = new()
                {
                    Content = "content",
                    Role = "role",
                    Name = "name",
                    ToolCallID = "tool_call_id",
                    ToolCalls =
                    [
                        new()
                        {
                            ID = "id",
                            Function = new() { Arguments = "arguments", Name = "name" },
                            Type = Type.Function,
                        },
                    ],
                },
                ToolAuthorizations =
                [
                    new()
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
                        Url = "url",
                        UserID = "user_id",
                    },
                ],
                ToolMessages =
                [
                    new()
                    {
                        Content = "content",
                        Role = "role",
                        Name = "name",
                        ToolCallID = "tool_call_id",
                        ToolCalls =
                        [
                            new()
                            {
                                ID = "id",
                                Function = new() { Arguments = "arguments", Name = "name" },
                                Type = Type.Function,
                            },
                        ],
                    },
                ],
            },
        ];
        long expectedCreated = 0;
        string expectedModel = "model";
        string expectedObject = "object";
        string expectedSystemFingerprint = "system_fingerprint";
        Usage expectedUsage = new()
        {
            CompletionTokens = 0,
            PromptTokens = 0,
            TotalTokens = 0,
        };

        Assert.Equal(expectedID, model.ID);
        Assert.NotNull(model.Choices);
        Assert.Equal(expectedChoices.Count, model.Choices.Count);
        for (int i = 0; i < expectedChoices.Count; i++)
        {
            Assert.Equal(expectedChoices[i], model.Choices[i]);
        }
        Assert.Equal(expectedCreated, model.Created);
        Assert.Equal(expectedModel, model.Model);
        Assert.Equal(expectedObject, model.Object);
        Assert.Equal(expectedSystemFingerprint, model.SystemFingerprint);
        Assert.Equal(expectedUsage, model.Usage);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new ChatResponse
        {
            ID = "id",
            Choices =
            [
                new()
                {
                    FinishReason = "finish_reason",
                    Index = 0,
                    Logprobs = JsonSerializer.Deserialize<JsonElement>("{}"),
                    Message = new()
                    {
                        Content = "content",
                        Role = "role",
                        Name = "name",
                        ToolCallID = "tool_call_id",
                        ToolCalls =
                        [
                            new()
                            {
                                ID = "id",
                                Function = new() { Arguments = "arguments", Name = "name" },
                                Type = Type.Function,
                            },
                        ],
                    },
                    ToolAuthorizations =
                    [
                        new()
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
                            Url = "url",
                            UserID = "user_id",
                        },
                    ],
                    ToolMessages =
                    [
                        new()
                        {
                            Content = "content",
                            Role = "role",
                            Name = "name",
                            ToolCallID = "tool_call_id",
                            ToolCalls =
                            [
                                new()
                                {
                                    ID = "id",
                                    Function = new() { Arguments = "arguments", Name = "name" },
                                    Type = Type.Function,
                                },
                            ],
                        },
                    ],
                },
            ],
            Created = 0,
            Model = "model",
            Object = "object",
            SystemFingerprint = "system_fingerprint",
            Usage = new()
            {
                CompletionTokens = 0,
                PromptTokens = 0,
                TotalTokens = 0,
            },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ChatResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ChatResponse
        {
            ID = "id",
            Choices =
            [
                new()
                {
                    FinishReason = "finish_reason",
                    Index = 0,
                    Logprobs = JsonSerializer.Deserialize<JsonElement>("{}"),
                    Message = new()
                    {
                        Content = "content",
                        Role = "role",
                        Name = "name",
                        ToolCallID = "tool_call_id",
                        ToolCalls =
                        [
                            new()
                            {
                                ID = "id",
                                Function = new() { Arguments = "arguments", Name = "name" },
                                Type = Type.Function,
                            },
                        ],
                    },
                    ToolAuthorizations =
                    [
                        new()
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
                            Url = "url",
                            UserID = "user_id",
                        },
                    ],
                    ToolMessages =
                    [
                        new()
                        {
                            Content = "content",
                            Role = "role",
                            Name = "name",
                            ToolCallID = "tool_call_id",
                            ToolCalls =
                            [
                                new()
                                {
                                    ID = "id",
                                    Function = new() { Arguments = "arguments", Name = "name" },
                                    Type = Type.Function,
                                },
                            ],
                        },
                    ],
                },
            ],
            Created = 0,
            Model = "model",
            Object = "object",
            SystemFingerprint = "system_fingerprint",
            Usage = new()
            {
                CompletionTokens = 0,
                PromptTokens = 0,
                TotalTokens = 0,
            },
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ChatResponse>(element);
        Assert.NotNull(deserialized);

        string expectedID = "id";
        List<Choice> expectedChoices =
        [
            new()
            {
                FinishReason = "finish_reason",
                Index = 0,
                Logprobs = JsonSerializer.Deserialize<JsonElement>("{}"),
                Message = new()
                {
                    Content = "content",
                    Role = "role",
                    Name = "name",
                    ToolCallID = "tool_call_id",
                    ToolCalls =
                    [
                        new()
                        {
                            ID = "id",
                            Function = new() { Arguments = "arguments", Name = "name" },
                            Type = Type.Function,
                        },
                    ],
                },
                ToolAuthorizations =
                [
                    new()
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
                        Url = "url",
                        UserID = "user_id",
                    },
                ],
                ToolMessages =
                [
                    new()
                    {
                        Content = "content",
                        Role = "role",
                        Name = "name",
                        ToolCallID = "tool_call_id",
                        ToolCalls =
                        [
                            new()
                            {
                                ID = "id",
                                Function = new() { Arguments = "arguments", Name = "name" },
                                Type = Type.Function,
                            },
                        ],
                    },
                ],
            },
        ];
        long expectedCreated = 0;
        string expectedModel = "model";
        string expectedObject = "object";
        string expectedSystemFingerprint = "system_fingerprint";
        Usage expectedUsage = new()
        {
            CompletionTokens = 0,
            PromptTokens = 0,
            TotalTokens = 0,
        };

        Assert.Equal(expectedID, deserialized.ID);
        Assert.NotNull(deserialized.Choices);
        Assert.Equal(expectedChoices.Count, deserialized.Choices.Count);
        for (int i = 0; i < expectedChoices.Count; i++)
        {
            Assert.Equal(expectedChoices[i], deserialized.Choices[i]);
        }
        Assert.Equal(expectedCreated, deserialized.Created);
        Assert.Equal(expectedModel, deserialized.Model);
        Assert.Equal(expectedObject, deserialized.Object);
        Assert.Equal(expectedSystemFingerprint, deserialized.SystemFingerprint);
        Assert.Equal(expectedUsage, deserialized.Usage);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new ChatResponse
        {
            ID = "id",
            Choices =
            [
                new()
                {
                    FinishReason = "finish_reason",
                    Index = 0,
                    Logprobs = JsonSerializer.Deserialize<JsonElement>("{}"),
                    Message = new()
                    {
                        Content = "content",
                        Role = "role",
                        Name = "name",
                        ToolCallID = "tool_call_id",
                        ToolCalls =
                        [
                            new()
                            {
                                ID = "id",
                                Function = new() { Arguments = "arguments", Name = "name" },
                                Type = Type.Function,
                            },
                        ],
                    },
                    ToolAuthorizations =
                    [
                        new()
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
                            Url = "url",
                            UserID = "user_id",
                        },
                    ],
                    ToolMessages =
                    [
                        new()
                        {
                            Content = "content",
                            Role = "role",
                            Name = "name",
                            ToolCallID = "tool_call_id",
                            ToolCalls =
                            [
                                new()
                                {
                                    ID = "id",
                                    Function = new() { Arguments = "arguments", Name = "name" },
                                    Type = Type.Function,
                                },
                            ],
                        },
                    ],
                },
            ],
            Created = 0,
            Model = "model",
            Object = "object",
            SystemFingerprint = "system_fingerprint",
            Usage = new()
            {
                CompletionTokens = 0,
                PromptTokens = 0,
                TotalTokens = 0,
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new ChatResponse { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Choices);
        Assert.False(model.RawData.ContainsKey("choices"));
        Assert.Null(model.Created);
        Assert.False(model.RawData.ContainsKey("created"));
        Assert.Null(model.Model);
        Assert.False(model.RawData.ContainsKey("model"));
        Assert.Null(model.Object);
        Assert.False(model.RawData.ContainsKey("object"));
        Assert.Null(model.SystemFingerprint);
        Assert.False(model.RawData.ContainsKey("system_fingerprint"));
        Assert.Null(model.Usage);
        Assert.False(model.RawData.ContainsKey("usage"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new ChatResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new ChatResponse
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Choices = null,
            Created = null,
            Model = null,
            Object = null,
            SystemFingerprint = null,
            Usage = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Choices);
        Assert.False(model.RawData.ContainsKey("choices"));
        Assert.Null(model.Created);
        Assert.False(model.RawData.ContainsKey("created"));
        Assert.Null(model.Model);
        Assert.False(model.RawData.ContainsKey("model"));
        Assert.Null(model.Object);
        Assert.False(model.RawData.ContainsKey("object"));
        Assert.Null(model.SystemFingerprint);
        Assert.False(model.RawData.ContainsKey("system_fingerprint"));
        Assert.Null(model.Usage);
        Assert.False(model.RawData.ContainsKey("usage"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new ChatResponse
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Choices = null,
            Created = null,
            Model = null,
            Object = null,
            SystemFingerprint = null,
            Usage = null,
        };

        model.Validate();
    }
}
