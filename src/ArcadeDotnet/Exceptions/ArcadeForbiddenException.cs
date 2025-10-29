using System.Net.Http;

namespace ArcadeDotnet.Exceptions;

public class ArcadeForbiddenException : Arcade4xxException
{
    public ArcadeForbiddenException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
