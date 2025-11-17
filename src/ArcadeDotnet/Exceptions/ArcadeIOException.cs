using System;
using System.Net.Http;

namespace ArcadeDotnet.Exceptions;

/// <summary>
/// Exception thrown when an I/O error occurs during an API request.
/// </summary>
[Serializable]
public sealed class ArcadeIOException : ArcadeException
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
    /// Initializes a new instance of the <see cref="ArcadeIOException"/> class.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <param name="innerException">The HTTP request exception that is the cause of the current exception, or null if no inner exception is specified.</param>
    public ArcadeIOException(string message, HttpRequestException? innerException = null)
        : base(message, innerException) { }
}
