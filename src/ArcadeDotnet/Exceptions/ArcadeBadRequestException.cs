using System.Net.Http;

namespace ArcadeDotnet.Exceptions;

public class ArcadeBadRequestException : Arcade4xxException
{
    public ArcadeBadRequestException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
