using System.Text.Json;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Health;

namespace ArcadeDotnet.Tests.Models.Health;

public class HealthSchemaTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new HealthSchema { Healthy = true, Reason = "reason" };

        bool expectedHealthy = true;
        string expectedReason = "reason";

        Assert.Equal(expectedHealthy, model.Healthy);
        Assert.Equal(expectedReason, model.Reason);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new HealthSchema { Healthy = true, Reason = "reason" };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<HealthSchema>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new HealthSchema { Healthy = true, Reason = "reason" };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<HealthSchema>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        bool expectedHealthy = true;
        string expectedReason = "reason";

        Assert.Equal(expectedHealthy, deserialized.Healthy);
        Assert.Equal(expectedReason, deserialized.Reason);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new HealthSchema { Healthy = true, Reason = "reason" };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new HealthSchema { };

        Assert.Null(model.Healthy);
        Assert.False(model.RawData.ContainsKey("healthy"));
        Assert.Null(model.Reason);
        Assert.False(model.RawData.ContainsKey("reason"));
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
            Reason = null,
        };

        Assert.Null(model.Healthy);
        Assert.False(model.RawData.ContainsKey("healthy"));
        Assert.Null(model.Reason);
        Assert.False(model.RawData.ContainsKey("reason"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new HealthSchema
        {
            // Null should be interpreted as omitted for these properties
            Healthy = null,
            Reason = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new HealthSchema { Healthy = true, Reason = "reason" };

        HealthSchema copied = new(model);

        Assert.Equal(model, copied);
    }
}
