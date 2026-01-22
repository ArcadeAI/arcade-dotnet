using System;
using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using Chat = ArcadeDotnet.Models.Chat;
using Completions = ArcadeDotnet.Models.Chat.Completions;

namespace ArcadeDotnet.Tests.Models.Chat.Completions;

public class CompletionCreateParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new Completions::CompletionCreateParams
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
                            Type = Chat::Type.Function,
                        },
                    ],
                },
            ],
            Model = "model",
            N = 0,
            ParallelToolCalls = true,
            PresencePenalty = 0,
            ResponseFormat = new() { Type = Completions::Type.JsonObject },
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
        List<Chat::ChatMessage> expectedMessages =
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
                        Type = Chat::Type.Function,
                    },
                ],
            },
        ];
        string expectedModel = "model";
        long expectedN = 0;
        bool expectedParallelToolCalls = true;
        double expectedPresencePenalty = 0;
        Completions::ResponseFormat expectedResponseFormat = new()
        {
            Type = Completions::Type.JsonObject,
        };
        long expectedSeed = 0;
        List<string> expectedStop = ["string"];
        bool expectedStream = true;
        Completions::StreamOptions expectedStreamOptions = new() { IncludeUsage = true };
        double expectedTemperature = 0;
        JsonElement expectedToolChoice = JsonSerializer.Deserialize<JsonElement>("{}");
        JsonElement expectedTools = JsonSerializer.Deserialize<JsonElement>("{}");
        long expectedTopLogprobs = 0;
        double expectedTopP = 0;
        string expectedUser = "user";

        Assert.Equal(expectedFrequencyPenalty, parameters.FrequencyPenalty);
        Assert.NotNull(parameters.LogitBias);
        Assert.Equal(expectedLogitBias.Count, parameters.LogitBias.Count);
        foreach (var item in expectedLogitBias)
        {
            Assert.True(parameters.LogitBias.TryGetValue(item.Key, out var value));

            Assert.Equal(value, parameters.LogitBias[item.Key]);
        }
        Assert.Equal(expectedLogprobs, parameters.Logprobs);
        Assert.Equal(expectedMaxTokens, parameters.MaxTokens);
        Assert.NotNull(parameters.Messages);
        Assert.Equal(expectedMessages.Count, parameters.Messages.Count);
        for (int i = 0; i < expectedMessages.Count; i++)
        {
            Assert.Equal(expectedMessages[i], parameters.Messages[i]);
        }
        Assert.Equal(expectedModel, parameters.Model);
        Assert.Equal(expectedN, parameters.N);
        Assert.Equal(expectedParallelToolCalls, parameters.ParallelToolCalls);
        Assert.Equal(expectedPresencePenalty, parameters.PresencePenalty);
        Assert.Equal(expectedResponseFormat, parameters.ResponseFormat);
        Assert.Equal(expectedSeed, parameters.Seed);
        Assert.NotNull(parameters.Stop);
        Assert.Equal(expectedStop.Count, parameters.Stop.Count);
        for (int i = 0; i < expectedStop.Count; i++)
        {
            Assert.Equal(expectedStop[i], parameters.Stop[i]);
        }
        Assert.Equal(expectedStream, parameters.Stream);
        Assert.Equal(expectedStreamOptions, parameters.StreamOptions);
        Assert.Equal(expectedTemperature, parameters.Temperature);
        Assert.NotNull(parameters.ToolChoice);
        Assert.True(JsonElement.DeepEquals(expectedToolChoice, parameters.ToolChoice.Value));
        Assert.NotNull(parameters.Tools);
        Assert.True(JsonElement.DeepEquals(expectedTools, parameters.Tools.Value));
        Assert.Equal(expectedTopLogprobs, parameters.TopLogprobs);
        Assert.Equal(expectedTopP, parameters.TopP);
        Assert.Equal(expectedUser, parameters.User);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new Completions::CompletionCreateParams { };

        Assert.Null(parameters.FrequencyPenalty);
        Assert.False(parameters.RawBodyData.ContainsKey("frequency_penalty"));
        Assert.Null(parameters.LogitBias);
        Assert.False(parameters.RawBodyData.ContainsKey("logit_bias"));
        Assert.Null(parameters.Logprobs);
        Assert.False(parameters.RawBodyData.ContainsKey("logprobs"));
        Assert.Null(parameters.MaxTokens);
        Assert.False(parameters.RawBodyData.ContainsKey("max_tokens"));
        Assert.Null(parameters.Messages);
        Assert.False(parameters.RawBodyData.ContainsKey("messages"));
        Assert.Null(parameters.Model);
        Assert.False(parameters.RawBodyData.ContainsKey("model"));
        Assert.Null(parameters.N);
        Assert.False(parameters.RawBodyData.ContainsKey("n"));
        Assert.Null(parameters.ParallelToolCalls);
        Assert.False(parameters.RawBodyData.ContainsKey("parallel_tool_calls"));
        Assert.Null(parameters.PresencePenalty);
        Assert.False(parameters.RawBodyData.ContainsKey("presence_penalty"));
        Assert.Null(parameters.ResponseFormat);
        Assert.False(parameters.RawBodyData.ContainsKey("response_format"));
        Assert.Null(parameters.Seed);
        Assert.False(parameters.RawBodyData.ContainsKey("seed"));
        Assert.Null(parameters.Stop);
        Assert.False(parameters.RawBodyData.ContainsKey("stop"));
        Assert.Null(parameters.Stream);
        Assert.False(parameters.RawBodyData.ContainsKey("stream"));
        Assert.Null(parameters.StreamOptions);
        Assert.False(parameters.RawBodyData.ContainsKey("stream_options"));
        Assert.Null(parameters.Temperature);
        Assert.False(parameters.RawBodyData.ContainsKey("temperature"));
        Assert.Null(parameters.ToolChoice);
        Assert.False(parameters.RawBodyData.ContainsKey("tool_choice"));
        Assert.Null(parameters.Tools);
        Assert.False(parameters.RawBodyData.ContainsKey("tools"));
        Assert.Null(parameters.TopLogprobs);
        Assert.False(parameters.RawBodyData.ContainsKey("top_logprobs"));
        Assert.Null(parameters.TopP);
        Assert.False(parameters.RawBodyData.ContainsKey("top_p"));
        Assert.Null(parameters.User);
        Assert.False(parameters.RawBodyData.ContainsKey("user"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new Completions::CompletionCreateParams
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

        Assert.Null(parameters.FrequencyPenalty);
        Assert.False(parameters.RawBodyData.ContainsKey("frequency_penalty"));
        Assert.Null(parameters.LogitBias);
        Assert.False(parameters.RawBodyData.ContainsKey("logit_bias"));
        Assert.Null(parameters.Logprobs);
        Assert.False(parameters.RawBodyData.ContainsKey("logprobs"));
        Assert.Null(parameters.MaxTokens);
        Assert.False(parameters.RawBodyData.ContainsKey("max_tokens"));
        Assert.Null(parameters.Messages);
        Assert.False(parameters.RawBodyData.ContainsKey("messages"));
        Assert.Null(parameters.Model);
        Assert.False(parameters.RawBodyData.ContainsKey("model"));
        Assert.Null(parameters.N);
        Assert.False(parameters.RawBodyData.ContainsKey("n"));
        Assert.Null(parameters.ParallelToolCalls);
        Assert.False(parameters.RawBodyData.ContainsKey("parallel_tool_calls"));
        Assert.Null(parameters.PresencePenalty);
        Assert.False(parameters.RawBodyData.ContainsKey("presence_penalty"));
        Assert.Null(parameters.ResponseFormat);
        Assert.False(parameters.RawBodyData.ContainsKey("response_format"));
        Assert.Null(parameters.Seed);
        Assert.False(parameters.RawBodyData.ContainsKey("seed"));
        Assert.Null(parameters.Stop);
        Assert.False(parameters.RawBodyData.ContainsKey("stop"));
        Assert.Null(parameters.Stream);
        Assert.False(parameters.RawBodyData.ContainsKey("stream"));
        Assert.Null(parameters.StreamOptions);
        Assert.False(parameters.RawBodyData.ContainsKey("stream_options"));
        Assert.Null(parameters.Temperature);
        Assert.False(parameters.RawBodyData.ContainsKey("temperature"));
        Assert.Null(parameters.ToolChoice);
        Assert.False(parameters.RawBodyData.ContainsKey("tool_choice"));
        Assert.Null(parameters.Tools);
        Assert.False(parameters.RawBodyData.ContainsKey("tools"));
        Assert.Null(parameters.TopLogprobs);
        Assert.False(parameters.RawBodyData.ContainsKey("top_logprobs"));
        Assert.Null(parameters.TopP);
        Assert.False(parameters.RawBodyData.ContainsKey("top_p"));
        Assert.Null(parameters.User);
        Assert.False(parameters.RawBodyData.ContainsKey("user"));
    }

    [Fact]
    public void Url_Works()
    {
        Completions::CompletionCreateParams parameters = new();

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(new Uri("https://api.arcade.dev/v1/chat/completions"), url);
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var parameters = new Completions::CompletionCreateParams
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
                            Type = Chat::Type.Function,
                        },
                    ],
                },
            ],
            Model = "model",
            N = 0,
            ParallelToolCalls = true,
            PresencePenalty = 0,
            ResponseFormat = new() { Type = Completions::Type.JsonObject },
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

        Completions::CompletionCreateParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}

public class ResponseFormatTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Completions::ResponseFormat { Type = Completions::Type.JsonObject };

        ApiEnum<string, Completions::Type> expectedType = Completions::Type.JsonObject;

        Assert.Equal(expectedType, model.Type);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Completions::ResponseFormat { Type = Completions::Type.JsonObject };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Completions::ResponseFormat>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Completions::ResponseFormat { Type = Completions::Type.JsonObject };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Completions::ResponseFormat>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        ApiEnum<string, Completions::Type> expectedType = Completions::Type.JsonObject;

        Assert.Equal(expectedType, deserialized.Type);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Completions::ResponseFormat { Type = Completions::Type.JsonObject };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Completions::ResponseFormat { };

        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Completions::ResponseFormat { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Completions::ResponseFormat
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
        var model = new Completions::ResponseFormat
        {
            // Null should be interpreted as omitted for these properties
            Type = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Completions::ResponseFormat { Type = Completions::Type.JsonObject };

        Completions::ResponseFormat copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class TypeTest : TestBase
{
    [Theory]
    [InlineData(Completions::Type.JsonObject)]
    [InlineData(Completions::Type.Text)]
    public void Validation_Works(Completions::Type rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Completions::Type> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Completions::Type>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Completions::Type.JsonObject)]
    [InlineData(Completions::Type.Text)]
    public void SerializationRoundtrip_Works(Completions::Type rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Completions::Type> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Completions::Type>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Completions::Type>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Completions::Type>>(
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
        var model = new Completions::StreamOptions { IncludeUsage = true };

        bool expectedIncludeUsage = true;

        Assert.Equal(expectedIncludeUsage, model.IncludeUsage);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Completions::StreamOptions { IncludeUsage = true };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Completions::StreamOptions>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Completions::StreamOptions { IncludeUsage = true };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Completions::StreamOptions>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        bool expectedIncludeUsage = true;

        Assert.Equal(expectedIncludeUsage, deserialized.IncludeUsage);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Completions::StreamOptions { IncludeUsage = true };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Completions::StreamOptions { };

        Assert.Null(model.IncludeUsage);
        Assert.False(model.RawData.ContainsKey("include_usage"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Completions::StreamOptions { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Completions::StreamOptions
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
        var model = new Completions::StreamOptions
        {
            // Null should be interpreted as omitted for these properties
            IncludeUsage = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Completions::StreamOptions { IncludeUsage = true };

        Completions::StreamOptions copied = new(model);

        Assert.Equal(model, copied);
    }
}
