using System;
using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using ArcadeDotnet.Models.Tools;

namespace ArcadeDotnet.Tests.Models.Tools;

public class ToolGetParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new ToolGetParams
        {
            Name = "name",
            IncludeFormat = [ToolGetParamsIncludeFormat.Arcade],
            UserID = "user_id",
        };

        string expectedName = "name";
        List<ApiEnum<string, ToolGetParamsIncludeFormat>> expectedIncludeFormat =
        [
            ToolGetParamsIncludeFormat.Arcade,
        ];
        string expectedUserID = "user_id";

        Assert.Equal(expectedName, parameters.Name);
        Assert.NotNull(parameters.IncludeFormat);
        Assert.Equal(expectedIncludeFormat.Count, parameters.IncludeFormat.Count);
        for (int i = 0; i < expectedIncludeFormat.Count; i++)
        {
            Assert.Equal(expectedIncludeFormat[i], parameters.IncludeFormat[i]);
        }
        Assert.Equal(expectedUserID, parameters.UserID);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new ToolGetParams { Name = "name" };

        Assert.Null(parameters.IncludeFormat);
        Assert.False(parameters.RawQueryData.ContainsKey("include_format"));
        Assert.Null(parameters.UserID);
        Assert.False(parameters.RawQueryData.ContainsKey("user_id"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new ToolGetParams
        {
            Name = "name",

            // Null should be interpreted as omitted for these properties
            IncludeFormat = null,
            UserID = null,
        };

        Assert.Null(parameters.IncludeFormat);
        Assert.False(parameters.RawQueryData.ContainsKey("include_format"));
        Assert.Null(parameters.UserID);
        Assert.False(parameters.RawQueryData.ContainsKey("user_id"));
    }

    [Fact]
    public void Url_Works()
    {
        ToolGetParams parameters = new()
        {
            Name = "name",
            IncludeFormat = [ToolGetParamsIncludeFormat.Arcade],
            UserID = "user_id",
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(
            new Uri("https://api.arcade.dev/v1/tools/name?include_format=arcade&user_id=user_id"),
            url
        );
    }
}

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
