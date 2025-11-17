using System;
using System.Net.Http;
using ArcadeDotnet.Exceptions;

namespace ArcadeDotnet.Tests;

public class ArcadeClientTest
{
    [Fact]
    public void Constructor_Parameterless_ShouldReadFromEnvironment()
    {
        // Arrange
        Environment.SetEnvironmentVariable("ARCADE_API_KEY", "env-key");
        Environment.SetEnvironmentVariable("ARCADE_BASE_URL", "https://custom.api.com");

        try
        {
            // Act
            var client = new ArcadeClient();

            // Assert
            Assert.Equal("env-key", client.APIKey);
            Assert.Equal("https://custom.api.com/", client.BaseUrl.ToString());
        }
        finally
        {
            Environment.SetEnvironmentVariable("ARCADE_API_KEY", null);
            Environment.SetEnvironmentVariable("ARCADE_BASE_URL", null);
        }
    }

    [Fact]
    public void Constructor_Parameterless_WithoutApiKey_ShouldThrow()
    {
        // Arrange
        Environment.SetEnvironmentVariable("ARCADE_API_KEY", null);

        // Act & Assert
        var exception = Assert.Throws<ArcadeInvalidDataException>(() => new ArcadeClient());
        Assert.Contains("API key is required", exception.Message);
    }

    [Fact]
    public void Constructor_WithOptions_ShouldUseProvidedValues()
    {
        // Arrange
        var httpClient = new HttpClient();
        var options = new ArcadeClientOptions
        {
            ApiKey = "options-key",
            BaseUrl = new Uri("https://options.api.com"),
            HttpClient = httpClient
        };

        // Act
        var client = new ArcadeClient(options);

        // Assert
        Assert.Equal("options-key", client.APIKey);
        Assert.Equal("https://options.api.com/", client.BaseUrl.ToString());
    }

    [Fact]
    public void Constructor_WithNullApiKey_ShouldThrow()
    {
        // Arrange
        var options = new ArcadeClientOptions
        {
            ApiKey = null,
            HttpClient = new HttpClient()
        };

        // Act & Assert
        Assert.Throws<ArcadeInvalidDataException>(() => new ArcadeClient(options));
    }

    [Fact]
    public void Constructor_WithEmptyApiKey_ShouldWork()
    {
        // Arrange - Empty string is technically valid (API will reject it)
        var options = new ArcadeClientOptions
        {
            ApiKey = "",
            HttpClient = new HttpClient()
        };

        // Act - Should not throw, API will handle validation
        var client = new ArcadeClient(options);

        // Assert
        Assert.Equal("", client.APIKey);
    }

    [Fact]
    public void Constructor_WithoutBaseUrl_ShouldUseDefault()
    {
        // Arrange
        var options = new ArcadeClientOptions
        {
            ApiKey = "test-key",
            HttpClient = new HttpClient()
        };

        // Act
        var client = new ArcadeClient(options);

        // Assert
        Assert.Equal(ArcadeClientOptions.DefaultBaseUrl, client.BaseUrl.ToString().TrimEnd('/'));
    }

    [Fact]
    public void Constructor_WithoutHttpClient_ShouldCreateNew()
    {
        // Arrange
        var options = new ArcadeClientOptions
        {
            ApiKey = "test-key"
        };

        // Act
        var client = new ArcadeClient(options);

        // Assert - Should not throw, services should be initialized
        Assert.NotNull(client.Admin);
        Assert.NotNull(client.Auth);
        Assert.NotNull(client.Chat);
        Assert.NotNull(client.Tools);
        Assert.NotNull(client.Workers);
    }

    [Fact]
    public void Services_ShouldBeInitializedAndAccessible()
    {
        // Arrange
        var client = new ArcadeClient(new ArcadeClientOptions
        {
            ApiKey = "test-key",
            HttpClient = new HttpClient()
        });

        // Act & Assert - All services should be available
        Assert.NotNull(client.Admin);
        Assert.NotNull(client.Auth);
        Assert.NotNull(client.Chat);
        Assert.NotNull(client.Tools);
        Assert.NotNull(client.Workers);
        
        // Nested services
        Assert.NotNull(client.Admin.UserConnections);
        Assert.NotNull(client.Admin.AuthProviders);
        Assert.NotNull(client.Admin.Secrets);
        Assert.NotNull(client.Chat.Completions);
        Assert.NotNull(client.Tools.Scheduled);
        Assert.NotNull(client.Tools.Formatted);
    }

    [Fact]
    public void Client_ShouldNotExposeHttpClient()
    {
        // Assert - HttpClient should not be on public interface
        var type = typeof(ArcadeClient);
        var property = type.GetProperty("HttpClient", 
            System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
        
        Assert.Null(property); // Should not be publicly accessible
    }

    [Fact]
    public void Client_ShouldNotHaveHealthService()
    {
        // Assert - Health should not be on interface
        var interfaceType = typeof(IArcadeClient);
        var healthProperty = interfaceType.GetProperty("Health");
        
        Assert.Null(healthProperty); // Health removed from main client
    }
}

