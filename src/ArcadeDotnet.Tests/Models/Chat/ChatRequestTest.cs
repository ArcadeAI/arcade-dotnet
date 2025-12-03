using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Chat;

namespace ArcadeDotnet.Tests.Models.Chat;

public class ChatRequestTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ChatRequest
        {
            FrequencyPenalty = 0,
            LogitBias = new Dictionary<string, long>() { { "foo", 0 } },
            Logprobs = true,
            MaxTokens = 0,
            Messages =
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
            Model = "model",
            N = 0,
            ParallelToolCalls = true,
            PresencePenalty = 0,
            ResponseFormat = new() { Type = ResponseFormatType.JsonObject },
            Seed = 0,
            Stop = ["string"],
            Stream = true,
            StreamOptions = new() { IncludeUsage = true },
            Temperature = 0,
            ToolChoice = JsonSerializer.Deserialize<JsonElement>("{}"),
            Tools = JsonSerializer.Deserialize<JsonElement>("{}"),
            TopLogprobs = 0,
            TopP = 0,
            User = "user",
        };

        double expectedFrequencyPenalty = 0;
        Dictionary<string, long> expectedLogitBias = new() { { "foo", 0 } };
        bool expectedLogprobs = true;
        long expectedMaxTokens = 0;
        List<ChatMessage> expectedMessages =
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
        string expectedModel = "model";
        long expectedN = 0;
        bool expectedParallelToolCalls = true;
        double expectedPresencePenalty = 0;
        ResponseFormat expectedResponseFormat = new() { Type = ResponseFormatType.JsonObject };
        long expectedSeed = 0;
        List<string> expectedStop = ["string"];
        bool expectedStream = true;
        StreamOptions expectedStreamOptions = new() { IncludeUsage = true };
        double expectedTemperature = 0;
        JsonElement expectedToolChoice = JsonSerializer.Deserialize<JsonElement>("{}");
        JsonElement expectedTools = JsonSerializer.Deserialize<JsonElement>("{}");
        long expectedTopLogprobs = 0;
        double expectedTopP = 0;
        string expectedUser = "user";

        Assert.Equal(expectedFrequencyPenalty, model.FrequencyPenalty);
        Assert.Equal(expectedLogitBias.Count, model.LogitBias.Count);
        foreach (var item in expectedLogitBias)
        {
            Assert.True(model.LogitBias.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.LogitBias[item.Key]);
        }
        Assert.Equal(expectedLogprobs, model.Logprobs);
        Assert.Equal(expectedMaxTokens, model.MaxTokens);
        Assert.Equal(expectedMessages.Count, model.Messages.Count);
        for (int i = 0; i < expectedMessages.Count; i++)
        {
            Assert.Equal(expectedMessages[i], model.Messages[i]);
        }
        Assert.Equal(expectedModel, model.Model);
        Assert.Equal(expectedN, model.N);
        Assert.Equal(expectedParallelToolCalls, model.ParallelToolCalls);
        Assert.Equal(expectedPresencePenalty, model.PresencePenalty);
        Assert.Equal(expectedResponseFormat, model.ResponseFormat);
        Assert.Equal(expectedSeed, model.Seed);
        Assert.Equal(expectedStop.Count, model.Stop.Count);
        for (int i = 0; i < expectedStop.Count; i++)
        {
            Assert.Equal(expectedStop[i], model.Stop[i]);
        }
        Assert.Equal(expectedStream, model.Stream);
        Assert.Equal(expectedStreamOptions, model.StreamOptions);
        Assert.Equal(expectedTemperature, model.Temperature);
        Assert.True(
            model.ToolChoice.HasValue
                && JsonElement.DeepEquals(expectedToolChoice, model.ToolChoice.Value)
        );
        Assert.True(
            model.Tools.HasValue && JsonElement.DeepEquals(expectedTools, model.Tools.Value)
        );
        Assert.Equal(expectedTopLogprobs, model.TopLogprobs);
        Assert.Equal(expectedTopP, model.TopP);
        Assert.Equal(expectedUser, model.User);
    }
}

public class ResponseFormatTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ResponseFormat { Type = ResponseFormatType.JsonObject };

        ApiEnum<string, ResponseFormatType> expectedType = ResponseFormatType.JsonObject;

        Assert.Equal(expectedType, model.Type);
    }
}

public class StreamOptionsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new StreamOptions { IncludeUsage = true };

        bool expectedIncludeUsage = true;

        Assert.Equal(expectedIncludeUsage, model.IncludeUsage);
    }
}
