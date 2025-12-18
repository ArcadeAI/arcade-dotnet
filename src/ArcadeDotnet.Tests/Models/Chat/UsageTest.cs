using System.Text.Json;
using ArcadeDotnet.Models.Chat;

namespace ArcadeDotnet.Tests.Models.Chat;

public class UsageTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Usage
        {
            CompletionTokens = 0,
            PromptTokens = 0,
            TotalTokens = 0,
        };

        long expectedCompletionTokens = 0;
        long expectedPromptTokens = 0;
        long expectedTotalTokens = 0;

        Assert.Equal(expectedCompletionTokens, model.CompletionTokens);
        Assert.Equal(expectedPromptTokens, model.PromptTokens);
        Assert.Equal(expectedTotalTokens, model.TotalTokens);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Usage
        {
            CompletionTokens = 0,
            PromptTokens = 0,
            TotalTokens = 0,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Usage>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Usage
        {
            CompletionTokens = 0,
            PromptTokens = 0,
            TotalTokens = 0,
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Usage>(element);
        Assert.NotNull(deserialized);

        long expectedCompletionTokens = 0;
        long expectedPromptTokens = 0;
        long expectedTotalTokens = 0;

        Assert.Equal(expectedCompletionTokens, deserialized.CompletionTokens);
        Assert.Equal(expectedPromptTokens, deserialized.PromptTokens);
        Assert.Equal(expectedTotalTokens, deserialized.TotalTokens);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Usage
        {
            CompletionTokens = 0,
            PromptTokens = 0,
            TotalTokens = 0,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Usage { };

        Assert.Null(model.CompletionTokens);
        Assert.False(model.RawData.ContainsKey("completion_tokens"));
        Assert.Null(model.PromptTokens);
        Assert.False(model.RawData.ContainsKey("prompt_tokens"));
        Assert.Null(model.TotalTokens);
        Assert.False(model.RawData.ContainsKey("total_tokens"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Usage { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Usage
        {
            // Null should be interpreted as omitted for these properties
            CompletionTokens = null,
            PromptTokens = null,
            TotalTokens = null,
        };

        Assert.Null(model.CompletionTokens);
        Assert.False(model.RawData.ContainsKey("completion_tokens"));
        Assert.Null(model.PromptTokens);
        Assert.False(model.RawData.ContainsKey("prompt_tokens"));
        Assert.Null(model.TotalTokens);
        Assert.False(model.RawData.ContainsKey("total_tokens"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Usage
        {
            // Null should be interpreted as omitted for these properties
            CompletionTokens = null,
            PromptTokens = null,
            TotalTokens = null,
        };

        model.Validate();
    }
}
