using System.Net.Http;

namespace ArcadeEngine.Exceptions;

public class ArcadeForbiddenException : Arcade4xxException
{
    public ArcadeForbiddenException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
