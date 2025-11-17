using System;
using System.Net.Http;

namespace ArcadeDotnet;

/// <summary>
/// Factory for creating ArcadeClient instances with convenient defaults.
/// </summary>
public static class ArcadeClientFactory
{
    private static readonly Lazy<HttpClient> _sharedHttpClient = new(() => new HttpClient());

    /// <summary>
    /// Creates a client using environment variables and a shared HttpClient.
    /// </summary>
    /// <returns>A new <see cref="ArcadeClient"/>.</returns>
    public static ArcadeClient Create()
    {
        return new ArcadeClient(new ArcadeClientOptions
        {
            ApiKey = Environment.GetEnvironmentVariable(ArcadeClientOptions.ApiKeyEnvironmentVariable),
            BaseUrl = ArcadeClientOptions.TryParseBaseUrl(Environment.GetEnvironmentVariable(ArcadeClientOptions.BaseUrlEnvironmentVariable)),
            HttpClient = _sharedHttpClient.Value
        });
    }

    /// <summary>
    /// Creates a client with the specified API key and a shared HttpClient.
    /// </summary>
    /// <param name="apiKey">The API key.</param>
    /// <returns>A new <see cref="ArcadeClient"/>.</returns>
    public static ArcadeClient Create(string apiKey)
    {
        return new ArcadeClient(new ArcadeClientOptions
        {
            ApiKey = apiKey,
            HttpClient = _sharedHttpClient.Value
        });
    }

}
