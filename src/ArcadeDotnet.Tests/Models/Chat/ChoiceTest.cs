using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Models;
using ArcadeDotnet.Models.Chat;

namespace ArcadeDotnet.Tests.Models.Chat;

public class ChoiceTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Choice
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
        };

        string expectedFinishReason = "finish_reason";
        long expectedIndex = 0;
        JsonElement expectedLogprobs = JsonSerializer.Deserialize<JsonElement>("{}");
        ChatMessage expectedMessage = new()
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
        };
        List<AuthorizationResponse> expectedToolAuthorizations =
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
        ];
        List<ChatMessage> expectedToolMessages =
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
        ];

        Assert.Equal(expectedFinishReason, model.FinishReason);
        Assert.Equal(expectedIndex, model.Index);
        Assert.NotNull(model.Logprobs);
        Assert.True(JsonElement.DeepEquals(expectedLogprobs, model.Logprobs.Value));
        Assert.Equal(expectedMessage, model.Message);
        Assert.NotNull(model.ToolAuthorizations);
        Assert.Equal(expectedToolAuthorizations.Count, model.ToolAuthorizations.Count);
        for (int i = 0; i < expectedToolAuthorizations.Count; i++)
        {
            Assert.Equal(expectedToolAuthorizations[i], model.ToolAuthorizations[i]);
        }
        Assert.NotNull(model.ToolMessages);
        Assert.Equal(expectedToolMessages.Count, model.ToolMessages.Count);
        for (int i = 0; i < expectedToolMessages.Count; i++)
        {
            Assert.Equal(expectedToolMessages[i], model.ToolMessages[i]);
        }
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Choice
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
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Choice>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Choice
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
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Choice>(element);
        Assert.NotNull(deserialized);

        string expectedFinishReason = "finish_reason";
        long expectedIndex = 0;
        JsonElement expectedLogprobs = JsonSerializer.Deserialize<JsonElement>("{}");
        ChatMessage expectedMessage = new()
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
        };
        List<AuthorizationResponse> expectedToolAuthorizations =
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
        ];
        List<ChatMessage> expectedToolMessages =
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
        ];

        Assert.Equal(expectedFinishReason, deserialized.FinishReason);
        Assert.Equal(expectedIndex, deserialized.Index);
        Assert.NotNull(deserialized.Logprobs);
        Assert.True(JsonElement.DeepEquals(expectedLogprobs, deserialized.Logprobs.Value));
        Assert.Equal(expectedMessage, deserialized.Message);
        Assert.NotNull(deserialized.ToolAuthorizations);
        Assert.Equal(expectedToolAuthorizations.Count, deserialized.ToolAuthorizations.Count);
        for (int i = 0; i < expectedToolAuthorizations.Count; i++)
        {
            Assert.Equal(expectedToolAuthorizations[i], deserialized.ToolAuthorizations[i]);
        }
        Assert.NotNull(deserialized.ToolMessages);
        Assert.Equal(expectedToolMessages.Count, deserialized.ToolMessages.Count);
        for (int i = 0; i < expectedToolMessages.Count; i++)
        {
            Assert.Equal(expectedToolMessages[i], deserialized.ToolMessages[i]);
        }
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Choice
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
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Choice { };

        Assert.Null(model.FinishReason);
        Assert.False(model.RawData.ContainsKey("finish_reason"));
        Assert.Null(model.Index);
        Assert.False(model.RawData.ContainsKey("index"));
        Assert.Null(model.Logprobs);
        Assert.False(model.RawData.ContainsKey("logprobs"));
        Assert.Null(model.Message);
        Assert.False(model.RawData.ContainsKey("message"));
        Assert.Null(model.ToolAuthorizations);
        Assert.False(model.RawData.ContainsKey("tool_authorizations"));
        Assert.Null(model.ToolMessages);
        Assert.False(model.RawData.ContainsKey("tool_messages"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Choice { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Choice
        {
            // Null should be interpreted as omitted for these properties
            FinishReason = null,
            Index = null,
            Logprobs = null,
            Message = null,
            ToolAuthorizations = null,
            ToolMessages = null,
        };

        Assert.Null(model.FinishReason);
        Assert.False(model.RawData.ContainsKey("finish_reason"));
        Assert.Null(model.Index);
        Assert.False(model.RawData.ContainsKey("index"));
        Assert.Null(model.Logprobs);
        Assert.False(model.RawData.ContainsKey("logprobs"));
        Assert.Null(model.Message);
        Assert.False(model.RawData.ContainsKey("message"));
        Assert.Null(model.ToolAuthorizations);
        Assert.False(model.RawData.ContainsKey("tool_authorizations"));
        Assert.Null(model.ToolMessages);
        Assert.False(model.RawData.ContainsKey("tool_messages"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Choice
        {
            // Null should be interpreted as omitted for these properties
            FinishReason = null,
            Index = null,
            Logprobs = null,
            Message = null,
            ToolAuthorizations = null,
            ToolMessages = null,
        };

        model.Validate();
    }
}
