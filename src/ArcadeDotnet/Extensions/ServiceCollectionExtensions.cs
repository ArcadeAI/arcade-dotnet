using System;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;

namespace ArcadeDotnet.Extensions;

/// <summary>
/// Extension methods for configuring ArcadeClient in dependency injection containers.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds ArcadeClient services to the dependency injection container.
    /// </summary>
    public static IServiceCollection AddArcadeClient(
        this IServiceCollection services,
        string apiKey,
        Uri? baseUrl = null)
    {
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(apiKey);

        services.AddHttpClient("ArcadeClient", client =>
        {
            client.BaseAddress = baseUrl ?? new Uri(ArcadeClientOptions.DefaultBaseUrl);
            client.DefaultRequestHeaders.UserAgent.ParseAdd("arcade-dotnet/0.2.0");
        });
        
        services.AddSingleton<IArcadeClient>(sp =>
        {
            var httpClientFactory = sp.GetRequiredService<IHttpClientFactory>();
            return new ArcadeClient(new ArcadeClientOptions
            {
                ApiKey = apiKey,
                BaseUrl = baseUrl,
                HttpClientFactory = httpClientFactory
            });
        });

        return services;
    }

    /// <summary>
    /// Adds ArcadeClient services using environment variables.
    /// </summary>
    public static IServiceCollection AddArcadeClient(this IServiceCollection services)
    {
        ArgumentNullException.ThrowIfNull(services);

        var baseUrl = ArcadeClientOptions.TryParseBaseUrl(
            Environment.GetEnvironmentVariable(ArcadeClientOptions.BaseUrlEnvironmentVariable));

        services.AddHttpClient("ArcadeClient", client =>
        {
            client.BaseAddress = baseUrl ?? new Uri(ArcadeClientOptions.DefaultBaseUrl);
            client.DefaultRequestHeaders.UserAgent.ParseAdd("arcade-dotnet/0.2.0");
        });
        
        services.AddSingleton<IArcadeClient>(sp =>
        {
            var httpClientFactory = sp.GetRequiredService<IHttpClientFactory>();
            return new ArcadeClient(new ArcadeClientOptions
            {
                ApiKey = Environment.GetEnvironmentVariable(ArcadeClientOptions.ApiKeyEnvironmentVariable),
                BaseUrl = baseUrl,
                HttpClientFactory = httpClientFactory
            });
        });

        return services;
    }
}

