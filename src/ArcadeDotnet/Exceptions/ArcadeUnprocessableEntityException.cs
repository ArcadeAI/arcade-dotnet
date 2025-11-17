using System.Net.Http;

namespace ArcadeDotnet.Exceptions;

/// <summary>
/// Exception thrown when the API returns a 422 Unprocessable Entity status code.
/// </summary>
public sealed class ArcadeUnprocessableEntityException : Arcade4xxException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ArcadeUnprocessableEntityException"/> class.
    /// </summary>
    /// <param name="innerException">The HTTP request exception that is the cause of the current exception, or null if no inner exception is specified.</param>
    public ArcadeUnprocessableEntityException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
