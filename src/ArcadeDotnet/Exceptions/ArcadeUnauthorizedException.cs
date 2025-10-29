using System.Net.Http;

namespace ArcadeDotnet.Exceptions;

public class ArcadeUnauthorizedException : Arcade4xxException
{
    public ArcadeUnauthorizedException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
