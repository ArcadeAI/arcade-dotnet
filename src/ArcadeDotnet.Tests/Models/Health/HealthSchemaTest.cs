using System.Text.Json;
using ArcadeDotnet.Models.Health;

namespace ArcadeDotnet.Tests.Models.Health;

public class HealthSchemaTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new HealthSchema { Healthy = true };

        bool expectedHealthy = true;

        Assert.Equal(expectedHealthy, model.Healthy);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new HealthSchema { Healthy = true };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<HealthSchema>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new HealthSchema { Healthy = true };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<HealthSchema>(element);
        Assert.NotNull(deserialized);

        bool expectedHealthy = true;

        Assert.Equal(expectedHealthy, deserialized.Healthy);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new HealthSchema { Healthy = true };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new HealthSchema { };

        Assert.Null(model.Healthy);
        Assert.False(model.RawData.ContainsKey("healthy"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new HealthSchema { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new HealthSchema
        {
            // Null should be interpreted as omitted for these properties
            Healthy = null,
        };

        Assert.Null(model.Healthy);
        Assert.False(model.RawData.ContainsKey("healthy"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new HealthSchema
        {
            // Null should be interpreted as omitted for these properties
            Healthy = null,
        };

        model.Validate();
    }
}
