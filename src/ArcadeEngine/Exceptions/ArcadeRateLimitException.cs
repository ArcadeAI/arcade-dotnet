using System.Net.Http;

namespace ArcadeEngine.Exceptions;

public class ArcadeRateLimitException : Arcade4xxException
{
    public ArcadeRateLimitException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
