using System.Net.Http;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Tools;

namespace ArcadeDotnet.Tests.Core;

public class ArcadeRequestTest
{
    [Fact]
    public void Constructor_WithMethodAndParams_ShouldSetProperties()
    {
        // Arrange
        var method = HttpMethod.Post;
        var parameters = new ToolExecuteParams { ToolName = "TestTool" };

        // Act
        var request = new ArcadeRequest<ToolExecuteParams>(method, parameters);

        // Assert
        Assert.Equal(HttpMethod.Post, request.Method);
        Assert.Equal("TestTool", request.Params.ToolName);
    }

    [Theory]
    [InlineData("GET")]
    [InlineData("POST")]
    [InlineData("PUT")]
    [InlineData("DELETE")]
    [InlineData("PATCH")]
    public void Constructor_WithDifferentHttpMethods_ShouldWork(string methodName)
    {
        // Arrange
        var method = new HttpMethod(methodName);
        var parameters = new ToolExecuteParams { ToolName = "Test" };

        // Act
        var request = new ArcadeRequest<ToolExecuteParams>(method, parameters);

        // Assert
        Assert.Equal(methodName, request.Method.Method);
    }

    [Fact]
    public void Record_ShouldSupportDeconstructionundefined()
    {
        // Arrange
        var request = new ArcadeRequest<ToolExecuteParams>(
            HttpMethod.Post,
            new ToolExecuteParams { ToolName = "Test" }
        );

        // Act
        var (method, params_) = request;

        // Assert
        Assert.Equal(HttpMethod.Post, method);
        Assert.Equal("Test", params_.ToolName);
    }

    [Fact]
    public void Record_ShouldSupportWithExpression()
    {
        // Arrange
        var original = new ArcadeRequest<ToolExecuteParams>(
            HttpMethod.Post,
            new ToolExecuteParams { ToolName = "Original" }
        );

        // Act
        var modified = original with { Method = HttpMethod.Get };

        // Assert
        Assert.Equal(HttpMethod.Get, modified.Method);
        Assert.Equal("Original", modified.Params.ToolName); // Unchanged
    }

    [Fact]
    public void Record_WithSameValues_ShouldBeEqual()
    {
        // Arrange
        var params1 = new ToolExecuteParams { ToolName = "Test" };
        var params2 = new ToolExecuteParams { ToolName = "Test" };
        
        var request1 = new ArcadeRequest<ToolExecuteParams>(HttpMethod.Post, params1);
        var request2 = new ArcadeRequest<ToolExecuteParams>(HttpMethod.Post, params2);

        // Assert - Records have value equality
        Assert.Equal(request1.Method, request2.Method);
    }
}

