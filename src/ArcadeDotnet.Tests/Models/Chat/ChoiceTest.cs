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
                URL = "url",
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
        Assert.True(
            model.Logprobs.HasValue
                && JsonElement.DeepEquals(expectedLogprobs, model.Logprobs.Value)
        );
        Assert.Equal(expectedMessage, model.Message);
        Assert.Equal(expectedToolAuthorizations.Count, model.ToolAuthorizations.Count);
        for (int i = 0; i < expectedToolAuthorizations.Count; i++)
        {
            Assert.Equal(expectedToolAuthorizations[i], model.ToolAuthorizations[i]);
        }
        Assert.Equal(expectedToolMessages.Count, model.ToolMessages.Count);
        for (int i = 0; i < expectedToolMessages.Count; i++)
        {
            Assert.Equal(expectedToolMessages[i], model.ToolMessages[i]);
        }
    }
}
