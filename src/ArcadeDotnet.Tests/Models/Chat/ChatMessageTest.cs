using System.Collections.Generic;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Chat;

namespace ArcadeDotnet.Tests.Models.Chat;

public class ChatMessageTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ChatMessage
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

        string expectedContent = "content";
        string expectedRole = "role";
        string expectedName = "name";
        string expectedToolCallID = "tool_call_id";
        List<ToolCall> expectedToolCalls =
        [
            new()
            {
                ID = "id",
                Function = new() { Arguments = "arguments", Name = "name" },
                Type = Type.Function,
            },
        ];

        Assert.Equal(expectedContent, model.Content);
        Assert.Equal(expectedRole, model.Role);
        Assert.Equal(expectedName, model.Name);
        Assert.Equal(expectedToolCallID, model.ToolCallID);
        Assert.Equal(expectedToolCalls.Count, model.ToolCalls.Count);
        for (int i = 0; i < expectedToolCalls.Count; i++)
        {
            Assert.Equal(expectedToolCalls[i], model.ToolCalls[i]);
        }
    }
}

public class ToolCallTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ToolCall
        {
            ID = "id",
            Function = new() { Arguments = "arguments", Name = "name" },
            Type = Type.Function,
        };

        string expectedID = "id";
        Function expectedFunction = new() { Arguments = "arguments", Name = "name" };
        ApiEnum<string, Type> expectedType = Type.Function;

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedFunction, model.Function);
        Assert.Equal(expectedType, model.Type);
    }
}

public class FunctionTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Function { Arguments = "arguments", Name = "name" };

        string expectedArguments = "arguments";
        string expectedName = "name";

        Assert.Equal(expectedArguments, model.Arguments);
        Assert.Equal(expectedName, model.Name);
    }
}
