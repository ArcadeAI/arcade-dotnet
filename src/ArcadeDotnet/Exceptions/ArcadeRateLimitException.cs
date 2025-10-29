using System.Net.Http;

namespace ArcadeDotnet.Exceptions;

public class ArcadeRateLimitException : Arcade4xxException
{
    public ArcadeRateLimitException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
