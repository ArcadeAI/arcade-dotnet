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
    /// </summary>
    public HttpClient? HttpClient { get; init; }

    /// <summary>
    /// Creates options from environment variables.
    /// </summary>
    /// <returns>A new <see cref="ArcadeClientOptions"/> instance.</returns>
    public static ArcadeClientOptions FromEnvironment() => new()
    {
        ApiKey = Environment.GetEnvironmentVariable(ApiKeyEnvironmentVariable),
        BaseUrl = TryParseBaseUrl(Environment.GetEnvironmentVariable(BaseUrlEnvironmentVariable))
    };

    /// <summary>
    /// Creates options with the specified API key.
    /// </summary>
    /// <param name="apiKey">The API key.</param>
    /// <returns>A new <see cref="ArcadeClientOptions"/> instance.</returns>
    public static ArcadeClientOptions WithApiKey(string apiKey) => new()
    {
        ApiKey = apiKey
    };

    private static Uri? TryParseBaseUrl(string? url) =>
        string.IsNullOrEmpty(url) ? null : new Uri(url);
}

