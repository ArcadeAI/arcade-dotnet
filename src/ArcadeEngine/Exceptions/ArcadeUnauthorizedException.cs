using System.Net.Http;

namespace ArcadeEngine.Exceptions;

public class ArcadeUnauthorizedException : Arcade4xxException
{
    public ArcadeUnauthorizedException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
