using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
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

    [Fact]
    public void SerializationRoundtrip_Works()
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

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ChatRequest>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
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

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ChatRequest>(json);
        Assert.NotNull(deserialized);

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

        Assert.Equal(expectedFrequencyPenalty, deserialized.FrequencyPenalty);
        Assert.Equal(expectedLogitBias.Count, deserialized.LogitBias.Count);
        foreach (var item in expectedLogitBias)
        {
            Assert.True(deserialized.LogitBias.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.LogitBias[item.Key]);
        }
        Assert.Equal(expectedLogprobs, deserialized.Logprobs);
        Assert.Equal(expectedMaxTokens, deserialized.MaxTokens);
        Assert.Equal(expectedMessages.Count, deserialized.Messages.Count);
        for (int i = 0; i < expectedMessages.Count; i++)
        {
            Assert.Equal(expectedMessages[i], deserialized.Messages[i]);
        }
        Assert.Equal(expectedModel, deserialized.Model);
        Assert.Equal(expectedN, deserialized.N);
        Assert.Equal(expectedParallelToolCalls, deserialized.ParallelToolCalls);
        Assert.Equal(expectedPresencePenalty, deserialized.PresencePenalty);
        Assert.Equal(expectedResponseFormat, deserialized.ResponseFormat);
        Assert.Equal(expectedSeed, deserialized.Seed);
        Assert.Equal(expectedStop.Count, deserialized.Stop.Count);
        for (int i = 0; i < expectedStop.Count; i++)
        {
            Assert.Equal(expectedStop[i], deserialized.Stop[i]);
        }
        Assert.Equal(expectedStream, deserialized.Stream);
        Assert.Equal(expectedStreamOptions, deserialized.StreamOptions);
        Assert.Equal(expectedTemperature, deserialized.Temperature);
        Assert.True(
            deserialized.ToolChoice.HasValue
                && JsonElement.DeepEquals(expectedToolChoice, deserialized.ToolChoice.Value)
        );
        Assert.True(
            deserialized.Tools.HasValue
                && JsonElement.DeepEquals(expectedTools, deserialized.Tools.Value)
        );
        Assert.Equal(expectedTopLogprobs, deserialized.TopLogprobs);
        Assert.Equal(expectedTopP, deserialized.TopP);
        Assert.Equal(expectedUser, deserialized.User);
    }

    [Fact]
    public void Validation_Works()
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

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new ChatRequest { };

        Assert.Null(model.FrequencyPenalty);
        Assert.False(model.RawData.ContainsKey("frequency_penalty"));
        Assert.Null(model.LogitBias);
        Assert.False(model.RawData.ContainsKey("logit_bias"));
        Assert.Null(model.Logprobs);
        Assert.False(model.RawData.ContainsKey("logprobs"));
        Assert.Null(model.MaxTokens);
        Assert.False(model.RawData.ContainsKey("max_tokens"));
        Assert.Null(model.Messages);
        Assert.False(model.RawData.ContainsKey("messages"));
        Assert.Null(model.Model);
        Assert.False(model.RawData.ContainsKey("model"));
        Assert.Null(model.N);
        Assert.False(model.RawData.ContainsKey("n"));
        Assert.Null(model.ParallelToolCalls);
        Assert.False(model.RawData.ContainsKey("parallel_tool_calls"));
        Assert.Null(model.PresencePenalty);
        Assert.False(model.RawData.ContainsKey("presence_penalty"));
        Assert.Null(model.ResponseFormat);
        Assert.False(model.RawData.ContainsKey("response_format"));
        Assert.Null(model.Seed);
        Assert.False(model.RawData.ContainsKey("seed"));
        Assert.Null(model.Stop);
        Assert.False(model.RawData.ContainsKey("stop"));
        Assert.Null(model.Stream);
        Assert.False(model.RawData.ContainsKey("stream"));
        Assert.Null(model.StreamOptions);
        Assert.False(model.RawData.ContainsKey("stream_options"));
        Assert.Null(model.Temperature);
        Assert.False(model.RawData.ContainsKey("temperature"));
        Assert.Null(model.ToolChoice);
        Assert.False(model.RawData.ContainsKey("tool_choice"));
        Assert.Null(model.Tools);
        Assert.False(model.RawData.ContainsKey("tools"));
        Assert.Null(model.TopLogprobs);
        Assert.False(model.RawData.ContainsKey("top_logprobs"));
        Assert.Null(model.TopP);
        Assert.False(model.RawData.ContainsKey("top_p"));
        Assert.Null(model.User);
        Assert.False(model.RawData.ContainsKey("user"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new ChatRequest { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new ChatRequest
        {
            // Null should be interpreted as omitted for these properties
            FrequencyPenalty = null,
            LogitBias = null,
            Logprobs = null,
            MaxTokens = null,
            Messages = null,
            Model = null,
            N = null,
            ParallelToolCalls = null,
            PresencePenalty = null,
            ResponseFormat = null,
            Seed = null,
            Stop = null,
            Stream = null,
            StreamOptions = null,
            Temperature = null,
            ToolChoice = null,
            Tools = null,
            TopLogprobs = null,
            TopP = null,
            User = null,
        };

        Assert.Null(model.FrequencyPenalty);
        Assert.False(model.RawData.ContainsKey("frequency_penalty"));
        Assert.Null(model.LogitBias);
        Assert.False(model.RawData.ContainsKey("logit_bias"));
        Assert.Null(model.Logprobs);
        Assert.False(model.RawData.ContainsKey("logprobs"));
        Assert.Null(model.MaxTokens);
        Assert.False(model.RawData.ContainsKey("max_tokens"));
        Assert.Null(model.Messages);
        Assert.False(model.RawData.ContainsKey("messages"));
        Assert.Null(model.Model);
        Assert.False(model.RawData.ContainsKey("model"));
        Assert.Null(model.N);
        Assert.False(model.RawData.ContainsKey("n"));
        Assert.Null(model.ParallelToolCalls);
        Assert.False(model.RawData.ContainsKey("parallel_tool_calls"));
        Assert.Null(model.PresencePenalty);
        Assert.False(model.RawData.ContainsKey("presence_penalty"));
        Assert.Null(model.ResponseFormat);
        Assert.False(model.RawData.ContainsKey("response_format"));
        Assert.Null(model.Seed);
        Assert.False(model.RawData.ContainsKey("seed"));
        Assert.Null(model.Stop);
        Assert.False(model.RawData.ContainsKey("stop"));
        Assert.Null(model.Stream);
        Assert.False(model.RawData.ContainsKey("stream"));
        Assert.Null(model.StreamOptions);
        Assert.False(model.RawData.ContainsKey("stream_options"));
        Assert.Null(model.Temperature);
        Assert.False(model.RawData.ContainsKey("temperature"));
        Assert.Null(model.ToolChoice);
        Assert.False(model.RawData.ContainsKey("tool_choice"));
        Assert.Null(model.Tools);
        Assert.False(model.RawData.ContainsKey("tools"));
        Assert.Null(model.TopLogprobs);
        Assert.False(model.RawData.ContainsKey("top_logprobs"));
        Assert.Null(model.TopP);
        Assert.False(model.RawData.ContainsKey("top_p"));
        Assert.Null(model.User);
        Assert.False(model.RawData.ContainsKey("user"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new ChatRequest
        {
            // Null should be interpreted as omitted for these properties
            FrequencyPenalty = null,
            LogitBias = null,
            Logprobs = null,
            MaxTokens = null,
            Messages = null,
            Model = null,
            N = null,
            ParallelToolCalls = null,
            PresencePenalty = null,
            ResponseFormat = null,
            Seed = null,
            Stop = null,
            Stream = null,
            StreamOptions = null,
            Temperature = null,
            ToolChoice = null,
            Tools = null,
            TopLogprobs = null,
            TopP = null,
            User = null,
        };

        model.Validate();
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

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new ResponseFormat { Type = ResponseFormatType.JsonObject };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ResponseFormat>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ResponseFormat { Type = ResponseFormatType.JsonObject };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ResponseFormat>(json);
        Assert.NotNull(deserialized);

        ApiEnum<string, ResponseFormatType> expectedType = ResponseFormatType.JsonObject;

        Assert.Equal(expectedType, deserialized.Type);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new ResponseFormat { Type = ResponseFormatType.JsonObject };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new ResponseFormat { };

        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new ResponseFormat { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new ResponseFormat
        {
            // Null should be interpreted as omitted for these properties
            Type = null,
        };

        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new ResponseFormat
        {
            // Null should be interpreted as omitted for these properties
            Type = null,
        };

        model.Validate();
    }
}

public class ResponseFormatTypeTest : TestBase
{
    [Theory]
    [InlineData(ResponseFormatType.JsonObject)]
    [InlineData(ResponseFormatType.Text)]
    public void Validation_Works(ResponseFormatType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ResponseFormatType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, ResponseFormatType>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(ResponseFormatType.JsonObject)]
    [InlineData(ResponseFormatType.Text)]
    public void SerializationRoundtrip_Works(ResponseFormatType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ResponseFormatType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, ResponseFormatType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, ResponseFormatType>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, ResponseFormatType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
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

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new StreamOptions { IncludeUsage = true };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<StreamOptions>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new StreamOptions { IncludeUsage = true };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<StreamOptions>(json);
        Assert.NotNull(deserialized);

        bool expectedIncludeUsage = true;

        Assert.Equal(expectedIncludeUsage, deserialized.IncludeUsage);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new StreamOptions { IncludeUsage = true };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new StreamOptions { };

        Assert.Null(model.IncludeUsage);
        Assert.False(model.RawData.ContainsKey("include_usage"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new StreamOptions { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new StreamOptions
        {
            // Null should be interpreted as omitted for these properties
            IncludeUsage = null,
        };

        Assert.Null(model.IncludeUsage);
        Assert.False(model.RawData.ContainsKey("include_usage"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new StreamOptions
        {
            // Null should be interpreted as omitted for these properties
            IncludeUsage = null,
        };

        model.Validate();
    }
}
