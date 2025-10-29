using System.Net.Http;

namespace ArcadeDotnet.Exceptions;

public class ArcadeUnprocessableEntityException : Arcade4xxException
{
    public ArcadeUnprocessableEntityException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
