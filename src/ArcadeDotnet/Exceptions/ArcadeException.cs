using System;
using System.Net.Http;

namespace ArcadeDotnet.Exceptions;

public class ArcadeException : Exception
{
    public ArcadeException(string message, Exception? innerException = null)
        : base(message, innerException) { }

    protected ArcadeException(HttpRequestException? innerException)
        : base(null, innerException) { }
}
