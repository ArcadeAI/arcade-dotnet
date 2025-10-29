using System;

namespace ArcadeDotnet.Exceptions;

public class ArcadeInvalidDataException : ArcadeException
{
    public ArcadeInvalidDataException(string message, Exception? innerException = null)
        : base(message, innerException) { }
}
