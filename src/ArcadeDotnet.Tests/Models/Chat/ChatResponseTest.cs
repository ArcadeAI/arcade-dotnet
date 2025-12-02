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
                            URL = "url",
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
                        URL = "url",
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
}
