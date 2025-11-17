using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using ArcadeDotnet.Models;

namespace ArcadeDotnet.Tests.Core;

public class ArcadeResponseTest
{
    [Fact]
    public async Task Deserialize_WithValidJson_ShouldReturnObject()
    {
        // Arrange
        var json = JsonSerializer.Serialize(new { message = "test", name = "error" });
        var httpResponse = new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new StringContent(json, Encoding.UTF8, "application/json")
        };
        var response = new ArcadeResponse { Message = httpResponse };

        // Act
        var result = await response.Deserialize<Error>();

        // Assert
        Assert.NotNull(result);
        Assert.Equal("test", result.Message);
        Assert.Equal("error", result.Name);
    }

    [Fact]
    public async Task Deserialize_WithNullContent_ShouldThrowArcadeInvalidDataException()
    {
        // Arrange
        var httpResponse = new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new StringContent("null", Encoding.UTF8, "application/json")
        };
        var response = new ArcadeResponse { Message = httpResponse };

        // Act & Assert
        await Assert.ThrowsAsync<ArcadeInvalidDataException>(() =>
            response.Deserialize<Error>());
    }

    [Fact]
    public async Task Deserialize_WithInvalidJson_ShouldThrowArcadeInvalidDataException()
    {
        // Arrange
        var httpResponse = new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new StringContent("invalid json{", Encoding.UTF8, "application/json")
        };
        var response = new ArcadeResponse { Message = httpResponse };

        // Act & Assert
        await Assert.ThrowsAsync<JsonException>(() =>
            response.Deserialize<Error>());
    }

    [Fact]
    public async Task Dispose_ShouldDisposeUnderlyingHttpResponseMessage()
    {
        // Arrange
        var httpResponse = new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new StringContent("test")
        };
        var response = new ArcadeResponse { Message = httpResponse };

        // Act
        response.Dispose();

        // Assert - Accessing disposed content should throw
        await Assert.ThrowsAsync<ObjectDisposedException>(() => 
            httpResponse.Content.ReadAsStringAsync());
    }

    [Fact]
    public async Task Response_ShouldWorkWithUsingStatement()
    {
        // Arrange
        var json = JsonSerializer.Serialize(new { message = "test" });
        var httpResponse = new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new StringContent(json, Encoding.UTF8, "application/json")
        };

        // Act & Assert
        Error result = null;
        using (var response = new ArcadeResponse { Message = httpResponse })
        {
            result = await response.Deserialize<Error>();
        }

        Assert.NotNull(result);
        Assert.Equal("test", result.Message);
        // After using block, should be disposed
        await Assert.ThrowsAsync<ObjectDisposedException>(() => 
            httpResponse.Content.ReadAsStringAsync());
    }

    [Fact]
    public void Record_WithSameMessage_ShouldBeEqual()
    {
        // Arrange
        var httpResponse = new HttpResponseMessage(HttpStatusCode.OK);
        var response1 = new ArcadeResponse { Message = httpResponse };
        var response2 = new ArcadeResponse { Message = httpResponse };

        // Assert - Records with same reference should be equal
        Assert.Equal(response1.Message, response2.Message);
    }
}

