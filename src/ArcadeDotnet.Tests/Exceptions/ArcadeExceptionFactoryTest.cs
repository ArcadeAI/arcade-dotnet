using System;
using System.Net;
using ArcadeDotnet.Exceptions;

namespace ArcadeDotnet.Tests.Exceptions;

public class ArcadeExceptionFactoryTest
{
    [Theory]
    [InlineData(400, typeof(ArcadeBadRequestException))]
    [InlineData(401, typeof(ArcadeUnauthorizedException))]
    [InlineData(403, typeof(ArcadeForbiddenException))]
    [InlineData(404, typeof(ArcadeNotFoundException))]
    [InlineData(422, typeof(ArcadeUnprocessableEntityException))]
    [InlineData(429, typeof(ArcadeRateLimitException))]
    public void CreateApiException_WithSpecificStatusCodes_ShouldReturnCorrectExceptionType(
        int statusCode, 
        Type expectedType)
    {
        // Arrange
        var httpStatusCode = (HttpStatusCode)statusCode;
        var responseBody = "test error response";

        // Act
        var exception = ArcadeExceptionFactory.CreateApiException(httpStatusCode, responseBody);

        // Assert
        Assert.IsType(expectedType, exception);
        Assert.Equal(httpStatusCode, exception.StatusCode);
        Assert.Equal(responseBody, exception.ResponseBody);
    }

    [Theory]
    [InlineData(405)] // Method Not Allowed
    [InlineData(409)] // Conflict
    [InlineData(418)] // I'm a teapot
    [InlineData(451)] // Unavailable For Legal Reasons
    public void CreateApiException_WithOther4xxCodes_ShouldReturnArcade4xxException(int statusCode)
    {
        // Arrange
        var httpStatusCode = (HttpStatusCode)statusCode;

        // Act
        var exception = ArcadeExceptionFactory.CreateApiException(httpStatusCode, "error");

        // Assert
        Assert.IsType<Arcade4xxException>(exception);
        Assert.Equal(httpStatusCode, exception.StatusCode);
    }

    [Theory]
    [InlineData(500)] // Internal Server Error
    [InlineData(502)] // Bad Gateway
    [InlineData(503)] // Service Unavailable
    [InlineData(504)] // Gateway Timeout
    public void CreateApiException_With5xxCodes_ShouldReturnArcade5xxException(int statusCode)
    {
        // Arrange
        var httpStatusCode = (HttpStatusCode)statusCode;

        // Act
        var exception = ArcadeExceptionFactory.CreateApiException(httpStatusCode, "server error");

        // Assert
        Assert.IsType<Arcade5xxException>(exception);
        Assert.Equal(httpStatusCode, exception.StatusCode);
    }

    [Theory]
    [InlineData(200)] // OK (shouldn't normally create exception for this)
    [InlineData(204)] // No Content
    [InlineData(300)] // Multiple Choices
    [InlineData(600)] // Non-standard
    public void CreateApiException_WithUnexpectedCodes_ShouldReturnUnexpectedStatusCodeException(
        int statusCode)
    {
        // Arrange
        var httpStatusCode = (HttpStatusCode)statusCode;

        // Act
        var exception = ArcadeExceptionFactory.CreateApiException(httpStatusCode, "unexpected");

        // Assert
        Assert.IsType<ArcadeUnexpectedStatusCodeException>(exception);
        Assert.Equal(httpStatusCode, exception.StatusCode);
    }

    [Fact]
    public void CreateApiException_ShouldIncludeResponseBodyInException()
    {
        // Arrange
        var responseBody = "Detailed error message from API";

        // Act
        var exception = ArcadeExceptionFactory.CreateApiException(HttpStatusCode.BadRequest, responseBody);

        // Assert
        Assert.Equal(responseBody, exception.ResponseBody);
        Assert.Contains(responseBody, exception.Message);
    }

    [Fact]
    public void CreateApiException_WithEmptyResponseBody_ShouldStillWork()
    {
        // Arrange & Act
        var exception = ArcadeExceptionFactory.CreateApiException(HttpStatusCode.NotFound, string.Empty);

        // Assert
        Assert.NotNull(exception);
        Assert.Equal(string.Empty, exception.ResponseBody);
    }
}

