using System.Net.Http;

namespace ArcadeDotnet.Exceptions;

/// <summary>
/// Exception thrown when the API returns a 404 Not Found status code.
/// </summary>
public sealed class ArcadeNotFoundException : Arcade4xxException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ArcadeNotFoundException"/> class.
    /// </summary>
    /// <param name="innerException">The HTTP request exception that is the cause of the current exception, or null if no inner exception is specified.</param>
    public ArcadeNotFoundException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
