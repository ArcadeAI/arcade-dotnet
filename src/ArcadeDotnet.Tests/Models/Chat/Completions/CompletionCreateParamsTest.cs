using System.Text.Json;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Chat.Completions;

namespace ArcadeDotnet.Tests.Models.Chat.Completions;

public class ResponseFormatTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ResponseFormat { Type = Type.JsonObject };

        ApiEnum<string, Type> expectedType = Type.JsonObject;

        Assert.Equal(expectedType, model.Type);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new ResponseFormat { Type = Type.JsonObject };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ResponseFormat>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ResponseFormat { Type = Type.JsonObject };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ResponseFormat>(json);
        Assert.NotNull(deserialized);

        ApiEnum<string, Type> expectedType = Type.JsonObject;

        Assert.Equal(expectedType, deserialized.Type);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new ResponseFormat { Type = Type.JsonObject };

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
