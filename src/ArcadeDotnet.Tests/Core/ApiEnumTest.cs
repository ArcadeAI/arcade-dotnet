using System;
using System.Text.Json;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using ArcadeDotnet.Models.AuthorizationResponseProperties;

namespace ArcadeDotnet.Tests.Core;

public class ApiEnumTest
{
    [Theory]
    [InlineData("not_started", Status.NotStarted)]
    [InlineData("pending", Status.Pending)]
    [InlineData("completed", Status.Completed)]
    [InlineData("failed", Status.Failed)]
    public void ApiEnum_ShouldConvertFromStringToEnum(string rawValue, Status expectedEnum)
    {
        // Arrange
        var json = JsonSerializer.SerializeToElement(rawValue);
        var apiEnum = new ApiEnum<string, Status>(json);

        // Act
        var enumValue = apiEnum.Value();
        var rawResult = apiEnum.Raw();

        // Assert
        Assert.Equal(expectedEnum, enumValue);
        Assert.Equal(rawValue, rawResult);
    }

    [Fact]
    public void ApiEnum_ImplicitConversionToRaw_ShouldWork()
    {
        // Arrange
        var json = JsonSerializer.SerializeToElement("pending");
        ApiEnum<string, Status> apiEnum = new(json);

        // Act
        string raw = apiEnum; // Implicit conversion

        // Assert
        Assert.Equal("pending", raw);
    }

    [Fact]
    public void ApiEnum_ImplicitConversionToEnum_ShouldWork()
    {
        // Arrange
        var json = JsonSerializer.SerializeToElement("completed");
        ApiEnum<string, Status> apiEnum = new(json);

        // Act
        Status status = apiEnum; // Implicit conversion

        // Assert
        Assert.Equal(Status.Completed, status);
    }

    [Fact]
    public void ApiEnum_ImplicitConversionFromRaw_ShouldWork()
    {
        // Act
        ApiEnum<string, Status> apiEnum = "failed";

        // Assert
        Assert.Equal(Status.Failed, apiEnum.Value());
        Assert.Equal("failed", apiEnum.Raw());
    }

    [Fact]
    public void ApiEnum_ImplicitConversionFromEnum_ShouldWork()
    {
        // Act
        ApiEnum<string, Status> apiEnum = Status.Pending;

        // Assert
        Assert.Equal(Status.Pending, apiEnum.Value());
    }

    [Fact]
    public void Validate_WithValidEnumValue_ShouldNotThrow()
    {
        // Arrange
        ApiEnum<string, Status> apiEnum = Status.Completed;

        // Act & Assert
        apiEnum.Validate(); // Should not throw
    }

    [Fact]
    public void Validate_WithInvalidEnumValue_ShouldThrow()
    {
        // Arrange - Create an invalid enum value using a valid string that maps to undefined enum
        var json = JsonSerializer.SerializeToElement("invalid_status_value");
        var apiEnum = new ApiEnum<string, Status>(json);

        // Act & Assert
        var exception = Assert.Throws<ArcadeInvalidDataException>(() => apiEnum.Validate());
        Assert.Contains("not a valid member", exception.Message);
    }

    [Fact]
    public void Raw_WithNullJson_ShouldThrowArcadeInvalidDataException()
    {
        // Arrange
        var json = JsonSerializer.SerializeToElement<string>(null);
        var apiEnum = new ApiEnum<string, Status>(json);

        // Act & Assert
        var exception = Assert.Throws<ArcadeInvalidDataException>(() => apiEnum.Raw());
        Assert.Contains("Failed to deserialize", exception.Message);
    }
}

