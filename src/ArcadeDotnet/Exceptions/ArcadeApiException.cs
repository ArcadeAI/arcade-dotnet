using System;
using System.Net;
using System.Net.Http;

namespace ArcadeDotnet.Exceptions;

/// <summary>
/// Exception thrown when the API returns an error status code.
/// </summary>
[Serializable]
public class ArcadeApiException : ArcadeException
{
    /// <summary>
    /// Gets the HTTP request exception that caused this exception.
    /// </summary>
    /// <value>
    /// The <see cref="HttpRequestException"/> that is the cause of the current exception.
    /// </value>
    /// <exception cref="InvalidOperationException">Thrown when the inner exception is null.</exception>
    public new HttpRequestException InnerException
    {
        get
        {
            if (base.InnerException == null)
            {
                throw new InvalidOperationException("InnerException is null");
            }
            return (HttpRequestException)base.InnerException;
        }
    }

    /// <summary>
    /// Gets the HTTP status code returned by the API.
    /// </summary>
    /// <value>
    /// The <see cref="HttpStatusCode"/> returned by the API.
    /// </value>
    public required HttpStatusCode StatusCode { get; init; }

    /// <summary>
    /// Gets the response body returned by the API.
    /// </summary>
    /// <value>
    /// The response body as a string, which may contain error details from the API.
    /// </value>
    public required string ResponseBody { get; init; }

    /// <summary>
    /// Gets a message that describes the current exception.
    /// </summary>
    /// <value>
    /// A string containing the HTTP status code and response body.
    /// </value>
    public override string Message => $"Status Code: {StatusCode}\n{ResponseBody}";

    /// <summary>
    /// Initializes a new instance of the <see cref="ArcadeApiException"/> class.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <param name="innerException">The HTTP request exception that is the cause of the current exception, or null if no inner exception is specified.</param>
    public ArcadeApiException(string message, HttpRequestException? innerException = null)
        : base(message, innerException) { }

    internal ArcadeApiException(HttpRequestException? innerException)
        : base(innerException) { }
}
