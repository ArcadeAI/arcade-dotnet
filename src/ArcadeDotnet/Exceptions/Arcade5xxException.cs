using System.Net.Http;

namespace ArcadeDotnet.Exceptions;

/// <summary>
/// Exception thrown when the API returns a 5xx server error status code.
/// </summary>
public sealed class Arcade5xxException : ArcadeApiException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Arcade5xxException"/> class.
    /// </summary>
    /// <param name="innerException">The HTTP request exception that is the cause of the current exception, or null if no inner exception is specified.</param>
    public Arcade5xxException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
