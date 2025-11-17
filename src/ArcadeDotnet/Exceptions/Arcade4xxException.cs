using System.Net.Http;

namespace ArcadeDotnet.Exceptions;

/// <summary>
/// Exception thrown when the API returns a 4xx client error status code.
/// </summary>
public class Arcade4xxException : ArcadeApiException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Arcade4xxException"/> class.
    /// </summary>
    /// <param name="innerException">The HTTP request exception that is the cause of the current exception, or null if no inner exception is specified.</param>
    public Arcade4xxException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
