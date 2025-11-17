using System.Net.Http;

namespace ArcadeDotnet.Exceptions;

/// <summary>
/// Exception thrown when the API returns a 429 Too Many Requests status code.
/// </summary>
public sealed class ArcadeRateLimitException : Arcade4xxException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ArcadeRateLimitException"/> class.
    /// </summary>
    /// <param name="innerException">The HTTP request exception that is the cause of the current exception, or null if no inner exception is specified.</param>
    public ArcadeRateLimitException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
