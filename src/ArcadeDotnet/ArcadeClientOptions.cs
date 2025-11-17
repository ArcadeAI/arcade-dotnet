using System;
using System.Net.Http;

namespace ArcadeDotnet;

/// <summary>
/// Configuration options for the Arcade API client.
/// </summary>
public sealed record ArcadeClientOptions
{
    /// <summary>
    /// Environment variable name for the API key.
    /// </summary>
    public const string ApiKeyEnvironmentVariable = "ARCADE_API_KEY";

    /// <summary>
    /// Environment variable name for the base URL.
    /// </summary>
    public const string BaseUrlEnvironmentVariable = "ARCADE_BASE_URL";

    /// <summary>
    /// Default base URL for the Arcade API.
    /// </summary>
    public const string DefaultBaseUrl = "https://api.arcade.dev";

    /// <summary>
    /// Gets the API key for authentication.
    /// </summary>
    public string? ApiKey { get; init; }

    /// <summary>
    /// Gets the base URL for the API.
    /// </summary>
    public Uri? BaseUrl { get; init; }

    /// <summary>
    /// Gets the HttpClient instance to use for requests.
    /// If not provided, ArcadeClient will use a shared instance (not recommended for production).
    /// </summary>
    public HttpClient? HttpClient { get; init; }

    /// <summary>
    /// Gets the IHttpClientFactory to use for creating HttpClient instances.
    /// </summary>
    public IHttpClientFactory? HttpClientFactory { get; init; }

    /// <summary>
    /// Gets the named HttpClient name to use with IHttpClientFactory.
    /// </summary>
    public string HttpClientName { get; init; } = "ArcadeClient";

    internal static Uri? TryParseBaseUrl(string? url)
    {
        if (string.IsNullOrEmpty(url))
            return null;
        
        try
        {
            return new Uri(url);
        }
        catch (UriFormatException)
        {
            return null;
        }
    }
}

