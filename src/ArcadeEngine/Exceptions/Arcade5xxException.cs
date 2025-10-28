using System.Net.Http;

namespace ArcadeEngine.Exceptions;

public class Arcade5xxException : ArcadeApiException
{
    public Arcade5xxException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
