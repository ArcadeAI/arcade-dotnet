using System;
using System.Net.Http;
using ArcadeDotnet.Exceptions;

namespace ArcadeDotnet.Core;

public struct ClientOptions()
{
    public static readonly int DefaultMaxRetries = 2;

    public static readonly TimeSpan DefaultTimeout = TimeSpan.FromMinutes(1);

    public HttpClient HttpClient { get; set; } = new();

    Lazy<Uri> _baseUrl = new(() =>
        new Uri(Environment.GetEnvironmentVariable("ARCADE_BASE_URL") ?? "https://api.arcade.dev")
    );
    public Uri BaseUrl
    {
        readonly get { return _baseUrl.Value; }
        set { _baseUrl = new(() => value); }
    }

    public bool ResponseValidation { get; set; } = false;

    public int? MaxRetries { get; set; }

    public TimeSpan? Timeout { get; set; }

    /// <summary>
    /// API key used for authorization in header
    /// </summary>
    Lazy<string> _apiKey = new(() =>
        Environment.GetEnvironmentVariable("ARCADE_API_KEY")
        ?? throw new ArcadeInvalidDataException(
            string.Format("{0} cannot be null", nameof(APIKey)),
            new ArgumentNullException(nameof(APIKey))
        )
    );

    /// <summary>
    /// API key used for authorization in header
    /// </summary>
    public string APIKey
    {
        readonly get { return _apiKey.Value; }
        set { _apiKey = new(() => value); }
    }
}
