using System;
using System.Net.Http;

namespace ArcadeDotnet.Exceptions;

/// <summary>
/// Base exception for all Arcade API exceptions.
/// </summary>
[Serializable]
public class ArcadeException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ArcadeException"/> class.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <param name="innerException">The exception that is the cause of the current exception, or null if no inner exception is specified.</param>
    public ArcadeException(string message, Exception? innerException = null)
        : base(message, innerException) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="ArcadeException"/> class with an HTTP request exception.
    /// </summary>
    /// <param name="innerException">The HTTP request exception that is the cause of the current exception.</param>
    protected ArcadeException(HttpRequestException? innerException)
        : base(null, innerException) { }
}
