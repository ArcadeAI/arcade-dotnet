using System.Text.Json;
using ArcadeDotnet.Models.Workers;

namespace ArcadeDotnet.Tests.Models.Workers;

public class WorkerHealthResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new WorkerHealthResponse
        {
            ID = "id",
            Enabled = true,
            Healthy = true,
            Message = "message",
        };

        string expectedID = "id";
        bool expectedEnabled = true;
        bool expectedHealthy = true;
        string expectedMessage = "message";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedEnabled, model.Enabled);
        Assert.Equal(expectedHealthy, model.Healthy);
        Assert.Equal(expectedMessage, model.Message);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new WorkerHealthResponse
        {
            ID = "id",
            Enabled = true,
            Healthy = true,
            Message = "message",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<WorkerHealthResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new WorkerHealthResponse
        {
            ID = "id",
            Enabled = true,
            Healthy = true,
            Message = "message",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<WorkerHealthResponse>(json);
        Assert.NotNull(deserialized);

        string expectedID = "id";
        bool expectedEnabled = true;
        bool expectedHealthy = true;
        string expectedMessage = "message";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedEnabled, deserialized.Enabled);
        Assert.Equal(expectedHealthy, deserialized.Healthy);
        Assert.Equal(expectedMessage, deserialized.Message);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new WorkerHealthResponse
        {
            ID = "id",
            Enabled = true,
            Healthy = true,
            Message = "message",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new WorkerHealthResponse { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Enabled);
        Assert.False(model.RawData.ContainsKey("enabled"));
        Assert.Null(model.Healthy);
        Assert.False(model.RawData.ContainsKey("healthy"));
        Assert.Null(model.Message);
        Assert.False(model.RawData.ContainsKey("message"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new WorkerHealthResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new WorkerHealthResponse
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Enabled = null,
            Healthy = null,
            Message = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Enabled);
        Assert.False(model.RawData.ContainsKey("enabled"));
        Assert.Null(model.Healthy);
        Assert.False(model.RawData.ContainsKey("healthy"));
        Assert.Null(model.Message);
        Assert.False(model.RawData.ContainsKey("message"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new WorkerHealthResponse
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Enabled = null,
            Healthy = null,
            Message = null,
        };

        model.Validate();
    }
}
