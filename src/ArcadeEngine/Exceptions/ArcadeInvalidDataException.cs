using System;

namespace ArcadeEngine.Exceptions;

public class ArcadeInvalidDataException : ArcadeException
{
    public ArcadeInvalidDataException(string message, Exception? innerException = null)
        : base(message, innerException) { }
}
