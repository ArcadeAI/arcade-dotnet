using System.Text.Json;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using ArcadeDotnet.Models.Tools;

namespace ArcadeDotnet.Tests.Models.Tools;

public class ToolGetParamsIncludeFormatTest : TestBase
{
    [Theory]
    [InlineData(ToolGetParamsIncludeFormat.Arcade)]
    [InlineData(ToolGetParamsIncludeFormat.OpenAI)]
    [InlineData(ToolGetParamsIncludeFormat.Anthropic)]
    public void Validation_Works(ToolGetParamsIncludeFormat rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ToolGetParamsIncludeFormat> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, ToolGetParamsIncludeFormat>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(ToolGetParamsIncludeFormat.Arcade)]
    [InlineData(ToolGetParamsIncludeFormat.OpenAI)]
    [InlineData(ToolGetParamsIncludeFormat.Anthropic)]
    public void SerializationRoundtrip_Works(ToolGetParamsIncludeFormat rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ToolGetParamsIncludeFormat> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, ToolGetParamsIncludeFormat>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, ToolGetParamsIncludeFormat>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, ToolGetParamsIncludeFormat>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
