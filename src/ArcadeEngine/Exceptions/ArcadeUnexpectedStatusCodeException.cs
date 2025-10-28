using System.Net.Http;

namespace ArcadeEngine.Exceptions;

public class ArcadeUnexpectedStatusCodeException : ArcadeApiException
{
    public ArcadeUnexpectedStatusCodeException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
