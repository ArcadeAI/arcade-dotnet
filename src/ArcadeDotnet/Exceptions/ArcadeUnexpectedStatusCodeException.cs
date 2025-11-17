using System.Net.Http;

namespace ArcadeDotnet.Exceptions;

/// <summary>
/// Exception thrown when the API returns an unexpected HTTP status code.
/// </summary>
public sealed class ArcadeUnexpectedStatusCodeException : ArcadeApiException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ArcadeUnexpectedStatusCodeException"/> class.
    /// </summary>
    /// <param name="innerException">The HTTP request exception that is the cause of the current exception, or null if no inner exception is specified.</param>
    public ArcadeUnexpectedStatusCodeException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
