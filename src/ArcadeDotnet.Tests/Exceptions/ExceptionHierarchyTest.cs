using System;
using ArcadeDotnet.Exceptions;

namespace ArcadeDotnet.Tests.Exceptions;

public class ExceptionHierarchyTest
{
    [Theory]
    [InlineData(400, typeof(ArcadeBadRequestException))]
    [InlineData(401, typeof(ArcadeUnauthorizedException))]
    [InlineData(403, typeof(ArcadeForbiddenException))]
    [InlineData(404, typeof(ArcadeNotFoundException))]
    public void All4xxExceptions_ShouldInheritFromArcade4xxException(int statusCode, Type exceptionType)
    {
        // Arrange
        var exception = ArcadeExceptionFactory.CreateApiException(
            (System.Net.HttpStatusCode)statusCode, 
            "test");

        // Assert
        Assert.IsAssignableFrom<Arcade4xxException>(exception);
        Assert.IsType(exceptionType, exception);
    }

    [Theory]
    [InlineData(500)]
    [InlineData(502)]
    [InlineData(503)]
    public void All5xxExceptions_ShouldInheritFromArcadeApiException(int statusCode)
    {
        // Arrange
        var exception = ArcadeExceptionFactory.CreateApiException(
            (System.Net.HttpStatusCode)statusCode, 
            "test");

        // Assert
        Assert.IsAssignableFrom<ArcadeApiException>(exception);
        Assert.IsType<Arcade5xxException>(exception);
    }

    [Fact]
    public void AllExceptions_ShouldInheritFromArcadeException()
    {
        // Assert
        Assert.IsAssignableFrom<ArcadeException>(new ArcadeIOException("test"));
        Assert.IsAssignableFrom<ArcadeException>(new ArcadeInvalidDataException("test"));
    }

    [Theory]
    [InlineData(typeof(ArcadeBadRequestException))]
    [InlineData(typeof(ArcadeUnauthorizedException))]
    [InlineData(typeof(ArcadeForbiddenException))]
    [InlineData(typeof(ArcadeNotFoundException))]
    [InlineData(typeof(ArcadeUnprocessableEntityException))]
    [InlineData(typeof(ArcadeRateLimitException))]
    [InlineData(typeof(Arcade5xxException))]
    [InlineData(typeof(ArcadeUnexpectedStatusCodeException))]
    [InlineData(typeof(ArcadeInvalidDataException))]
    [InlineData(typeof(ArcadeIOException))]
    public void LeafExceptions_ShouldBeSealed(Type exceptionType)
    {
        // Assert - All leaf exception classes should be sealed
        Assert.True(exceptionType.IsSealed, $"{exceptionType.Name} should be sealed");
    }
}

