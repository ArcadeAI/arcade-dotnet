using System.Net.Http;

namespace ArcadeEngine.Exceptions;

public class ArcadeUnprocessableEntityException : Arcade4xxException
{
    public ArcadeUnprocessableEntityException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
