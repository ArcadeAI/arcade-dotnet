using System.Net;

namespace ArcadeEngine.Exceptions;

public class ArcadeExceptionFactory
{
    public static ArcadeApiException CreateApiException(
        HttpStatusCode statusCode,
        string responseBody
    )
    {
        return (int)statusCode switch
        {
            400 => new ArcadeBadRequestException()
            {
                StatusCode = statusCode,
                ResponseBody = responseBody,
            },
            401 => new ArcadeUnauthorizedException()
            {
                StatusCode = statusCode,
                ResponseBody = responseBody,
            },
            403 => new ArcadeForbiddenException()
            {
                StatusCode = statusCode,
                ResponseBody = responseBody,
            },
            404 => new ArcadeNotFoundException()
            {
                StatusCode = statusCode,
                ResponseBody = responseBody,
            },
            422 => new ArcadeUnprocessableEntityException()
            {
                StatusCode = statusCode,
                ResponseBody = responseBody,
            },
            429 => new ArcadeRateLimitException()
            {
                StatusCode = statusCode,
                ResponseBody = responseBody,
            },
            >= 400 and <= 499 => new Arcade4xxException()
            {
                StatusCode = statusCode,
                ResponseBody = responseBody,
            },
            >= 500 and <= 599 => new Arcade5xxException()
            {
                StatusCode = statusCode,
                ResponseBody = responseBody,
            },
            _ => new ArcadeUnexpectedStatusCodeException()
            {
                StatusCode = statusCode,
                ResponseBody = responseBody,
            },
        };
    }
}
