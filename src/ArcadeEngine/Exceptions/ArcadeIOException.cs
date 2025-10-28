using System;
using System.Net.Http;

namespace ArcadeEngine.Exceptions;

public class ArcadeIOException : ArcadeException
{
    public new HttpRequestException InnerException
    {
        get
        {
            if (base.InnerException == null)
            {
                throw new ArgumentNullException();
            }
            return (HttpRequestException)base.InnerException;
        }
    }

    public ArcadeIOException(string message, HttpRequestException? innerException = null)
        : base(message, innerException) { }
}
