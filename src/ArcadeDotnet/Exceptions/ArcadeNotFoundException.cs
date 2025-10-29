using System.Net.Http;

namespace ArcadeDotnet.Exceptions;

public class ArcadeNotFoundException : Arcade4xxException
{
    public ArcadeNotFoundException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
