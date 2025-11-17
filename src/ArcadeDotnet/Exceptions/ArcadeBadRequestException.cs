using System.Net.Http;

namespace ArcadeDotnet.Exceptions;

/// <summary>
/// Exception thrown when the API returns a 400 Bad Request status code.
/// </summary>
public sealed class ArcadeBadRequestException : Arcade4xxException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ArcadeBadRequestException"/> class.
    /// </summary>
    /// <param name="innerException">The HTTP request exception that is the cause of the current exception, or null if no inner exception is specified.</param>
    public ArcadeBadRequestException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
