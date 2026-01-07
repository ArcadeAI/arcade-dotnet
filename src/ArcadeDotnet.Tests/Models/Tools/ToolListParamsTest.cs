using System;
using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using ArcadeDotnet.Models.Tools;

namespace ArcadeDotnet.Tests.Models.Tools;

public class ToolListParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new ToolListParams
        {
            IncludeAllVersions = true,
            IncludeFormat = [IncludeFormat.Arcade],
            Limit = 0,
            Offset = 0,
            Toolkit = "toolkit",
            UserID = "user_id",
        };

        bool expectedIncludeAllVersions = true;
        List<ApiEnum<string, IncludeFormat>> expectedIncludeFormat = [IncludeFormat.Arcade];
        long expectedLimit = 0;
        long expectedOffset = 0;
        string expectedToolkit = "toolkit";
        string expectedUserID = "user_id";

        Assert.Equal(expectedIncludeAllVersions, parameters.IncludeAllVersions);
        Assert.NotNull(parameters.IncludeFormat);
        Assert.Equal(expectedIncludeFormat.Count, parameters.IncludeFormat.Count);
        for (int i = 0; i < expectedIncludeFormat.Count; i++)
        {
            Assert.Equal(expectedIncludeFormat[i], parameters.IncludeFormat[i]);
        }
        Assert.Equal(expectedLimit, parameters.Limit);
        Assert.Equal(expectedOffset, parameters.Offset);
        Assert.Equal(expectedToolkit, parameters.Toolkit);
        Assert.Equal(expectedUserID, parameters.UserID);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new ToolListParams { };

        Assert.Null(parameters.IncludeAllVersions);
        Assert.False(parameters.RawQueryData.ContainsKey("include_all_versions"));
        Assert.Null(parameters.IncludeFormat);
        Assert.False(parameters.RawQueryData.ContainsKey("include_format"));
        Assert.Null(parameters.Limit);
        Assert.False(parameters.RawQueryData.ContainsKey("limit"));
        Assert.Null(parameters.Offset);
        Assert.False(parameters.RawQueryData.ContainsKey("offset"));
        Assert.Null(parameters.Toolkit);
        Assert.False(parameters.RawQueryData.ContainsKey("toolkit"));
        Assert.Null(parameters.UserID);
        Assert.False(parameters.RawQueryData.ContainsKey("user_id"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new ToolListParams
        {
            // Null should be interpreted as omitted for these properties
            IncludeAllVersions = null,
            IncludeFormat = null,
            Limit = null,
            Offset = null,
            Toolkit = null,
            UserID = null,
        };

        Assert.Null(parameters.IncludeAllVersions);
        Assert.False(parameters.RawQueryData.ContainsKey("include_all_versions"));
        Assert.Null(parameters.IncludeFormat);
        Assert.False(parameters.RawQueryData.ContainsKey("include_format"));
        Assert.Null(parameters.Limit);
        Assert.False(parameters.RawQueryData.ContainsKey("limit"));
        Assert.Null(parameters.Offset);
        Assert.False(parameters.RawQueryData.ContainsKey("offset"));
        Assert.Null(parameters.Toolkit);
        Assert.False(parameters.RawQueryData.ContainsKey("toolkit"));
        Assert.Null(parameters.UserID);
        Assert.False(parameters.RawQueryData.ContainsKey("user_id"));
    }

    [Fact]
    public void Url_Works()
    {
        ToolListParams parameters = new()
        {
            IncludeAllVersions = true,
            IncludeFormat = [IncludeFormat.Arcade],
            Limit = 0,
            Offset = 0,
            Toolkit = "toolkit",
            UserID = "user_id",
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(
            new Uri(
                "https://api.arcade.dev/v1/tools?include_all_versions=true&include_format=arcade&limit=0&offset=0&toolkit=toolkit&user_id=user_id"
            ),
            url
        );
    }
}

public class IncludeFormatTest : TestBase
{
    [Theory]
    [InlineData(IncludeFormat.Arcade)]
    [InlineData(IncludeFormat.OpenAI)]
    [InlineData(IncludeFormat.Anthropic)]
    public void Validation_Works(IncludeFormat rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, IncludeFormat> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, IncludeFormat>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(IncludeFormat.Arcade)]
    [InlineData(IncludeFormat.OpenAI)]
    [InlineData(IncludeFormat.Anthropic)]
    public void SerializationRoundtrip_Works(IncludeFormat rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, IncludeFormat> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, IncludeFormat>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, IncludeFormat>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, IncludeFormat>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
