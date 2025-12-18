using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Models.Tools;

namespace ArcadeDotnet.Tests.Models.Tools;

public class ValueSchemaTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ValueSchema
        {
            ValType = "val_type",
            Enum = ["string"],
            InnerValType = "inner_val_type",
        };

        string expectedValType = "val_type";
        List<string> expectedEnum = ["string"];
        string expectedInnerValType = "inner_val_type";

        Assert.Equal(expectedValType, model.ValType);
        Assert.NotNull(model.Enum);
        Assert.Equal(expectedEnum.Count, model.Enum.Count);
        for (int i = 0; i < expectedEnum.Count; i++)
        {
            Assert.Equal(expectedEnum[i], model.Enum[i]);
        }
        Assert.Equal(expectedInnerValType, model.InnerValType);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new ValueSchema
        {
            ValType = "val_type",
            Enum = ["string"],
            InnerValType = "inner_val_type",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ValueSchema>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ValueSchema
        {
            ValType = "val_type",
            Enum = ["string"],
            InnerValType = "inner_val_type",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ValueSchema>(element);
        Assert.NotNull(deserialized);

        string expectedValType = "val_type";
        List<string> expectedEnum = ["string"];
        string expectedInnerValType = "inner_val_type";

        Assert.Equal(expectedValType, deserialized.ValType);
        Assert.NotNull(deserialized.Enum);
        Assert.Equal(expectedEnum.Count, deserialized.Enum.Count);
        for (int i = 0; i < expectedEnum.Count; i++)
        {
            Assert.Equal(expectedEnum[i], deserialized.Enum[i]);
        }
        Assert.Equal(expectedInnerValType, deserialized.InnerValType);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new ValueSchema
        {
            ValType = "val_type",
            Enum = ["string"],
            InnerValType = "inner_val_type",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new ValueSchema { ValType = "val_type" };

        Assert.Null(model.Enum);
        Assert.False(model.RawData.ContainsKey("enum"));
        Assert.Null(model.InnerValType);
        Assert.False(model.RawData.ContainsKey("inner_val_type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new ValueSchema { ValType = "val_type" };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new ValueSchema
        {
            ValType = "val_type",

            // Null should be interpreted as omitted for these properties
            Enum = null,
            InnerValType = null,
        };

        Assert.Null(model.Enum);
        Assert.False(model.RawData.ContainsKey("enum"));
        Assert.Null(model.InnerValType);
        Assert.False(model.RawData.ContainsKey("inner_val_type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new ValueSchema
        {
            ValType = "val_type",

            // Null should be interpreted as omitted for these properties
            Enum = null,
            InnerValType = null,
        };

        model.Validate();
    }
}
