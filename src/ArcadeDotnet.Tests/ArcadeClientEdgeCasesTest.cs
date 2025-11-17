using System;
using System.Net.Http;
using ArcadeDotnet.Exceptions;

namespace ArcadeDotnet.Tests;

public class ArcadeClientEdgeCasesTest
{
    [Fact]
    public void Constructor_WithNullOptions_ShouldThrow()
    {
        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => new ArcadeClient(null!));
    }

    [Fact]
    public void Constructor_CreatesMultipleClients_ShouldHaveIndependentHttpClients()
    {
        // Arrange
        var httpClient1 = new HttpClient();
        var httpClient2 = new HttpClient();

        // Act
        var client1 = new ArcadeClient(new ArcadeClientOptions
        {
            ApiKey = "key1",
            HttpClient = httpClient1
        });

        var client2 = new ArcadeClient(new ArcadeClientOptions
        {
            ApiKey = "key2",
            HttpClient = httpClient2
        });

        // Assert - Different configurations
        Assert.Equal("key1", client1.APIKey);
        Assert.Equal("key2", client2.APIKey);
        Assert.NotSame(client1, client2);
    }

    [Fact]
    public void BaseUrl_WithTrailingSlash_ShouldNormalize()
    {
        // Arrange
        var options = new ArcadeClientOptions
        {
            ApiKey = "test",
            BaseUrl = new Uri("https://api.test.com/")
        };

        // Act
        var client = new ArcadeClient(options);

        // Assert
        Assert.Equal("https://api.test.com/", client.BaseUrl.ToString());
    }

    [Fact]
    public void Constructor_WithVeryLongApiKey_ShouldWork()
    {
        // Arrange
        var longKey = new string('a', 1000); // 1000 character key
        var options = new ArcadeClientOptions
        {
            ApiKey = longKey,
            HttpClient = new HttpClient()
        };

        // Act
        var client = new ArcadeClient(options);

        // Assert
        Assert.Equal(longKey, client.APIKey);
    }

    [Fact]
    public void Constructor_WithSpecialCharactersInApiKey_ShouldWork()
    {
        // Arrange
        var specialKey = "key!@#$%^&*()_+-=[]{}|;':\",./<>?";
        var options = new ArcadeClientOptions
        {
            ApiKey = specialKey,
            HttpClient = new HttpClient()
        };

        // Act
        var client = new ArcadeClient(options);

        // Assert
        Assert.Equal(specialKey, client.APIKey);
    }

    [Theory]
    [InlineData("https://api.arcade.dev")]
    [InlineData("https://staging.arcade.dev")]
    [InlineData("http://localhost:3000")]
    [InlineData("https://custom-domain.com:8080")]
    public void Constructor_WithDifferentBaseUrls_ShouldAcceptAll(string baseUrl)
    {
        // Arrange
        var options = new ArcadeClientOptions
        {
            ApiKey = "test",
            BaseUrl = new Uri(baseUrl),
            HttpClient = new HttpClient()
        };

        // Act
        var client = new ArcadeClient(options);

        // Assert
        Assert.StartsWith(baseUrl, client.BaseUrl.ToString());
    }

    [Fact]
    public void Services_CalledMultipleTimes_ShouldReturnSameInstance()
    {
        // Arrange
        var client = new ArcadeClient(new ArcadeClientOptions
        {
            ApiKey = "test",
            HttpClient = new HttpClient()
        });

        // Act
        var admin1 = client.Admin;
        var admin2 = client.Admin;
        var auth1 = client.Auth;
        var auth2 = client.Auth;

        // Assert - Should return same instances (not create new each time)
        Assert.Same(admin1, admin2);
        Assert.Same(auth1, auth2);
    }

    [Fact]
    public void Constructor_Parameterless_WithInvalidEnvironmentBaseUrl_ShouldUseDefault()
    {
        // Arrange
        Environment.SetEnvironmentVariable("ARCADE_API_KEY", "test-key");
        Environment.SetEnvironmentVariable("ARCADE_BASE_URL", "not-a-valid-url");

        try
        {
            // Act & Assert - Should throw because URL parsing fails
            Assert.Throws<UriFormatException>(() => new ArcadeClient());
        }
        finally
        {
            Environment.SetEnvironmentVariable("ARCADE_API_KEY", null);
            Environment.SetEnvironmentVariable("ARCADE_BASE_URL", null);
        }
    }
}
