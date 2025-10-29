using System.Net.Http;

namespace ArcadeDotnet.Exceptions;

public class ArcadeUnexpectedStatusCodeException : ArcadeApiException
{
    public ArcadeUnexpectedStatusCodeException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
