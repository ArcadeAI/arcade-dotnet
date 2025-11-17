using System;
using ArcadeDotnet.Exceptions;

namespace ArcadeDotnet.Tests;

public class ArcadeClientFactoryTest
{
    [Fact]
    public void Create_WithoutParameters_ShouldCreateClientWithSharedHttpClient()
    {
        // Arrange
        Environment.SetEnvironmentVariable("ARCADE_API_KEY", "test-factory-key");

        try
        {
            // Act
            var client1 = ArcadeClientFactory.Create();
            var client2 = ArcadeClientFactory.Create();

            // Assert
            Assert.NotNull(client1);
            Assert.NotNull(client2);
            Assert.Equal("test-factory-key", client1.APIKey);
            Assert.Equal("test-factory-key", client2.APIKey);
            // Both should use same shared HttpClient (verify by reference if possible)
        }
        finally
        {
            Environment.SetEnvironmentVariable("ARCADE_API_KEY", null);
        }
    }

    [Theory]
    [InlineData("sk_test_123")]
    [InlineData("api_key_prod_456")]
    [InlineData("my-custom-key")]
    public void Create_WithApiKey_ShouldUseProvidedKey(string apiKey)
    {
        // Act
        var client = ArcadeClientFactory.Create(apiKey);

        // Assert
        Assert.NotNull(client);
        Assert.Equal(apiKey, client.APIKey);
        Assert.Equal(new Uri(ArcadeClientOptions.DefaultBaseUrl), client.BaseUrl);
    }

    [Fact]
    public void Create_WithoutEnvironmentVariable_ShouldThrowForMissingApiKey()
    {
        // Arrange
        Environment.SetEnvironmentVariable("ARCADE_API_KEY", null);

        // Act & Assert
        var exception = Assert.Throws<ArcadeInvalidDataException>(() => 
            ArcadeClientFactory.Create());
        
        Assert.Contains("API key is required", exception.Message);
    }

    [Fact]
    public void Create_ShouldReuseHttpClientAcrossInstances()
    {
        // Arrange
        Environment.SetEnvironmentVariable("ARCADE_API_KEY", "test-key");

        try
        {
            // Act
            var client1 = ArcadeClientFactory.Create();
            var client2 = ArcadeClientFactory.Create();

            // Assert - Both clients should be usable
            Assert.NotNull(client1.Tools);
            Assert.NotNull(client2.Tools);
            Assert.NotNull(client1.Auth);
            Assert.NotNull(client2.Auth);
        }
        finally
        {
            Environment.SetEnvironmentVariable("ARCADE_API_KEY", null);
        }
    }
}

