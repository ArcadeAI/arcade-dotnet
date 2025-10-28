using System.Net.Http;

namespace ArcadeEngine.Exceptions;

public class ArcadeBadRequestException : Arcade4xxException
{
    public ArcadeBadRequestException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
