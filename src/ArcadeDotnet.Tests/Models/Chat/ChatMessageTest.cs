using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
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
        Assert.NotNull(model.ToolCalls);
        Assert.Equal(expectedToolCalls.Count, model.ToolCalls.Count);
        for (int i = 0; i < expectedToolCalls.Count; i++)
        {
            Assert.Equal(expectedToolCalls[i], model.ToolCalls[i]);
        }
    }

    [Fact]
    public void SerializationRoundtrip_Works()
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

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ChatMessage>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
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

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ChatMessage>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

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

        Assert.Equal(expectedContent, deserialized.Content);
        Assert.Equal(expectedRole, deserialized.Role);
        Assert.Equal(expectedName, deserialized.Name);
        Assert.Equal(expectedToolCallID, deserialized.ToolCallID);
        Assert.NotNull(deserialized.ToolCalls);
        Assert.Equal(expectedToolCalls.Count, deserialized.ToolCalls.Count);
        for (int i = 0; i < expectedToolCalls.Count; i++)
        {
            Assert.Equal(expectedToolCalls[i], deserialized.ToolCalls[i]);
        }
    }

    [Fact]
    public void Validation_Works()
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

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new ChatMessage { Content = "content", Role = "role" };

        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
        Assert.Null(model.ToolCallID);
        Assert.False(model.RawData.ContainsKey("tool_call_id"));
        Assert.Null(model.ToolCalls);
        Assert.False(model.RawData.ContainsKey("tool_calls"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new ChatMessage { Content = "content", Role = "role" };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new ChatMessage
        {
            Content = "content",
            Role = "role",

            // Null should be interpreted as omitted for these properties
            Name = null,
            ToolCallID = null,
            ToolCalls = null,
        };

        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
        Assert.Null(model.ToolCallID);
        Assert.False(model.RawData.ContainsKey("tool_call_id"));
        Assert.Null(model.ToolCalls);
        Assert.False(model.RawData.ContainsKey("tool_calls"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new ChatMessage
        {
            Content = "content",
            Role = "role",

            // Null should be interpreted as omitted for these properties
            Name = null,
            ToolCallID = null,
            ToolCalls = null,
        };

        model.Validate();
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

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new ToolCall
        {
            ID = "id",
            Function = new() { Arguments = "arguments", Name = "name" },
            Type = Type.Function,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ToolCall>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ToolCall
        {
            ID = "id",
            Function = new() { Arguments = "arguments", Name = "name" },
            Type = Type.Function,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ToolCall>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "id";
        Function expectedFunction = new() { Arguments = "arguments", Name = "name" };
        ApiEnum<string, Type> expectedType = Type.Function;

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedFunction, deserialized.Function);
        Assert.Equal(expectedType, deserialized.Type);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new ToolCall
        {
            ID = "id",
            Function = new() { Arguments = "arguments", Name = "name" },
            Type = Type.Function,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new ToolCall { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Function);
        Assert.False(model.RawData.ContainsKey("function"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new ToolCall { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new ToolCall
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Function = null,
            Type = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Function);
        Assert.False(model.RawData.ContainsKey("function"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new ToolCall
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Function = null,
            Type = null,
        };

        model.Validate();
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

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Function { Arguments = "arguments", Name = "name" };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Function>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Function { Arguments = "arguments", Name = "name" };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Function>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedArguments = "arguments";
        string expectedName = "name";

        Assert.Equal(expectedArguments, deserialized.Arguments);
        Assert.Equal(expectedName, deserialized.Name);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Function { Arguments = "arguments", Name = "name" };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Function { };

        Assert.Null(model.Arguments);
        Assert.False(model.RawData.ContainsKey("arguments"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Function { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Function
        {
            // Null should be interpreted as omitted for these properties
            Arguments = null,
            Name = null,
        };

        Assert.Null(model.Arguments);
        Assert.False(model.RawData.ContainsKey("arguments"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Function
        {
            // Null should be interpreted as omitted for these properties
            Arguments = null,
            Name = null,
        };

        model.Validate();
    }
}

public class TypeTest : TestBase
{
    [Theory]
    [InlineData(Type.Function)]
    public void Validation_Works(Type rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Type> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Type>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Type.Function)]
    public void SerializationRoundtrip_Works(Type rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Type> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Type>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Type>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Type>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
