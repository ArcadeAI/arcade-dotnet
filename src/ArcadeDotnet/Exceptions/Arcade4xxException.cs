using System.Net.Http;

namespace ArcadeDotnet.Exceptions;

public class Arcade4xxException : ArcadeApiException
{
    public Arcade4xxException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
