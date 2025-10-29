using System.Net.Http;

namespace ArcadeDotnet.Exceptions;

public class Arcade5xxException : ArcadeApiException
{
    public Arcade5xxException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
