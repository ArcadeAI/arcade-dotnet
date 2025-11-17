using System;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using ArcadeDotnet.Extensions;

namespace ArcadeDotnet.Tests.Extensions;

public class ServiceCollectionExtensionsTest
{
    [Fact]
    public void AddArcadeClient_WithApiKey_ShouldRegisterClient()
    {
        var services = new ServiceCollection();
        services.AddArcadeClient("test-api-key");
        var provider = services.BuildServiceProvider();
        var client = provider.GetService<IArcadeClient>();

        Assert.NotNull(client);
        Assert.Equal("test-api-key", client.APIKey);
    }

    [Fact]
    public void AddArcadeClient_WithEnvironmentVariables_ShouldUseEnvironmentVars()
    {
        Environment.SetEnvironmentVariable("ARCADE_API_KEY", "env-api-key");
        var services = new ServiceCollection();

        try
        {
            services.AddArcadeClient();
            var provider = services.BuildServiceProvider();
            var client = provider.GetService<IArcadeClient>();

            Assert.NotNull(client);
            Assert.Equal("env-api-key", client.APIKey);
        }
        finally
        {
            Environment.SetEnvironmentVariable("ARCADE_API_KEY", null);
        }
    }

    [Fact]
    public void AddArcadeClient_ShouldUseSingletonLifetime()
    {
        var services = new ServiceCollection();
        services.AddArcadeClient("test-key");
        var provider = services.BuildServiceProvider();

        var client1 = provider.GetService<IArcadeClient>();
        var client2 = provider.GetService<IArcadeClient>();

        Assert.Same(client1, client2);
    }

    [Fact]
    public void AddArcadeClient_ShouldUseHttpClientFactory()
    {
        var services = new ServiceCollection();
        services.AddArcadeClient("test-key");
        var provider = services.BuildServiceProvider();

        var factory = provider.GetService<IHttpClientFactory>();
        var client = provider.GetService<IArcadeClient>();

        Assert.NotNull(factory);
        Assert.NotNull(client);
    }

    [Fact]
    public void AddArcadeClient_WithCustomBaseUrl_ShouldUseCustomUrl()
    {
        var services = new ServiceCollection();
        var customUrl = new Uri("https://custom.api.dev");

        services.AddArcadeClient("test-key", customUrl);
        var provider = services.BuildServiceProvider();
        var client = provider.GetService<IArcadeClient>();

        Assert.NotNull(client);
        Assert.Equal(customUrl, client.BaseUrl);
    }
}
