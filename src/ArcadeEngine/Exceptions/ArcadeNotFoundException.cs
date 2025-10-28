using System.Net.Http;

namespace ArcadeEngine.Exceptions;

public class ArcadeNotFoundException : Arcade4xxException
{
    public ArcadeNotFoundException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
