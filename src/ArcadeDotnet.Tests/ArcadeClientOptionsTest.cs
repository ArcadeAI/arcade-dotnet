using System;
using System.Net.Http;

namespace ArcadeDotnet.Tests;

public class ArcadeClientOptionsTest
{
    [Fact]
    public void Options_WithAllProperties_ShouldSetCorrectly()
    {
        // Arrange & Act
        var options = new ArcadeClientOptions
        {
            ApiKey = "test-key",
            BaseUrl = new Uri("https://test.api.com"),
            HttpClient = new HttpClient()
        };

        // Assert
        Assert.Equal("test-key", options.ApiKey);
        Assert.Equal("https://test.api.com/", options.BaseUrl!.ToString());
        Assert.NotNull(options.HttpClient);
    }

    [Fact]
    public void Options_WithMinimalProperties_ShouldAllowNulls()
    {
        // Arrange & Act
        var options = new ArcadeClientOptions
        {
            ApiKey = "test-key"
        };

        // Assert
        Assert.Equal("test-key", options.ApiKey);
        Assert.Null(options.BaseUrl);
        Assert.Null(options.HttpClient);
    }

    [Theory]
    [InlineData("ARCADE_API_KEY")]
    [InlineData("ARCADE_BASE_URL")]
    public void Constants_ShouldMatchExpectedValues(string expected)
    {
        // Assert
        Assert.Contains(expected, new[] 
        { 
            ArcadeClientOptions.ApiKeyEnvironmentVariable,
            ArcadeClientOptions.BaseUrlEnvironmentVariable 
        });
    }

    [Fact]
    public void DefaultBaseUrl_ShouldBeArcadeProduction()
    {
        // Assert
        Assert.Equal("https://api.arcade.dev", ArcadeClientOptions.DefaultBaseUrl);
    }

    [Fact]
    public void Options_AsRecord_ShouldSupportWithExpression()
    {
        // Arrange
        var original = new ArcadeClientOptions
        {
            ApiKey = "original-key",
            BaseUrl = new Uri("https://original.com")
        };

        // Act
        var modified = original with { ApiKey = "new-key" };

        // Assert
        Assert.Equal("new-key", modified.ApiKey);
        Assert.Equal(original.BaseUrl, modified.BaseUrl); // Unchanged
    }
}

