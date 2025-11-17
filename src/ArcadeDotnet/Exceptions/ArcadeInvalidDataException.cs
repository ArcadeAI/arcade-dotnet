using System;

namespace ArcadeDotnet.Exceptions;

/// <summary>
/// Exception thrown when invalid data is encountered.
/// </summary>
[Serializable]
public sealed class ArcadeInvalidDataException : ArcadeException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ArcadeInvalidDataException"/> class.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <param name="innerException">The exception that is the cause of the current exception, or null if no inner exception is specified.</param>
    public ArcadeInvalidDataException(string message, Exception? innerException = null)
        : base(message, innerException) { }
}
