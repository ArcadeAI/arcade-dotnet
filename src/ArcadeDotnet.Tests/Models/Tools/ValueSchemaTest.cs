using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Core;
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
            Description = "description",
            Enum = ["string"],
            InnerProperties = JsonSerializer.Deserialize<JsonElement>("{}"),
            InnerRequiredKeys = ["string"],
            InnerValType = "inner_val_type",
            Items = new()
            {
                ValType = "val_type",
                Description = "description",
                Enum = ["string"],
                InnerProperties = JsonSerializer.Deserialize<JsonElement>("{}"),
                InnerRequiredKeys = ["string"],
                InnerValType = "inner_val_type",
                Items = new()
                {
                    ValType = "val_type",
                    Description = "description",
                    Enum = ["string"],
                    InnerProperties = JsonSerializer.Deserialize<JsonElement>("{}"),
                    InnerRequiredKeys = ["string"],
                    InnerValType = "inner_val_type",
                    Nullable = true,
                    Properties = JsonSerializer.Deserialize<JsonElement>("{}"),
                    RequiredKeys = ["string"],
                },
                Nullable = true,
                Properties = JsonSerializer.Deserialize<JsonElement>("{}"),
                RequiredKeys = ["string"],
            },
            Nullable = true,
            Properties = JsonSerializer.Deserialize<JsonElement>("{}"),
            RequiredKeys = ["string"],
        };

        string expectedValType = "val_type";
        string expectedDescription = "description";
        List<string> expectedEnum = ["string"];
        JsonElement expectedInnerProperties = JsonSerializer.Deserialize<JsonElement>("{}");
        List<string> expectedInnerRequiredKeys = ["string"];
        string expectedInnerValType = "inner_val_type";
        ValueSchema expectedItems = new()
        {
            ValType = "val_type",
            Description = "description",
            Enum = ["string"],
            InnerProperties = JsonSerializer.Deserialize<JsonElement>("{}"),
            InnerRequiredKeys = ["string"],
            InnerValType = "inner_val_type",
            Items = new()
            {
                ValType = "val_type",
                Description = "description",
                Enum = ["string"],
                InnerProperties = JsonSerializer.Deserialize<JsonElement>("{}"),
                InnerRequiredKeys = ["string"],
                InnerValType = "inner_val_type",
                Nullable = true,
                Properties = JsonSerializer.Deserialize<JsonElement>("{}"),
                RequiredKeys = ["string"],
            },
            Nullable = true,
            Properties = JsonSerializer.Deserialize<JsonElement>("{}"),
            RequiredKeys = ["string"],
        };
        bool expectedNullable = true;
        JsonElement expectedProperties = JsonSerializer.Deserialize<JsonElement>("{}");
        List<string> expectedRequiredKeys = ["string"];

        Assert.Equal(expectedValType, model.ValType);
        Assert.Equal(expectedDescription, model.Description);
        Assert.NotNull(model.Enum);
        Assert.Equal(expectedEnum.Count, model.Enum.Count);
        for (int i = 0; i < expectedEnum.Count; i++)
        {
            Assert.Equal(expectedEnum[i], model.Enum[i]);
        }
        Assert.NotNull(model.InnerProperties);
        Assert.True(JsonElement.DeepEquals(expectedInnerProperties, model.InnerProperties.Value));
        Assert.NotNull(model.InnerRequiredKeys);
        Assert.Equal(expectedInnerRequiredKeys.Count, model.InnerRequiredKeys.Count);
        for (int i = 0; i < expectedInnerRequiredKeys.Count; i++)
        {
            Assert.Equal(expectedInnerRequiredKeys[i], model.InnerRequiredKeys[i]);
        }
        Assert.Equal(expectedInnerValType, model.InnerValType);
        Assert.Equal(expectedItems, model.Items);
        Assert.Equal(expectedNullable, model.Nullable);
        Assert.NotNull(model.Properties);
        Assert.True(JsonElement.DeepEquals(expectedProperties, model.Properties.Value));
        Assert.NotNull(model.RequiredKeys);
        Assert.Equal(expectedRequiredKeys.Count, model.RequiredKeys.Count);
        for (int i = 0; i < expectedRequiredKeys.Count; i++)
        {
            Assert.Equal(expectedRequiredKeys[i], model.RequiredKeys[i]);
        }
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new ValueSchema
        {
            ValType = "val_type",
            Description = "description",
            Enum = ["string"],
            InnerProperties = JsonSerializer.Deserialize<JsonElement>("{}"),
            InnerRequiredKeys = ["string"],
            InnerValType = "inner_val_type",
            Items = new()
            {
                ValType = "val_type",
                Description = "description",
                Enum = ["string"],
                InnerProperties = JsonSerializer.Deserialize<JsonElement>("{}"),
                InnerRequiredKeys = ["string"],
                InnerValType = "inner_val_type",
                Items = new()
                {
                    ValType = "val_type",
                    Description = "description",
                    Enum = ["string"],
                    InnerProperties = JsonSerializer.Deserialize<JsonElement>("{}"),
                    InnerRequiredKeys = ["string"],
                    InnerValType = "inner_val_type",
                    Nullable = true,
                    Properties = JsonSerializer.Deserialize<JsonElement>("{}"),
                    RequiredKeys = ["string"],
                },
                Nullable = true,
                Properties = JsonSerializer.Deserialize<JsonElement>("{}"),
                RequiredKeys = ["string"],
            },
            Nullable = true,
            Properties = JsonSerializer.Deserialize<JsonElement>("{}"),
            RequiredKeys = ["string"],
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ValueSchema>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ValueSchema
        {
            ValType = "val_type",
            Description = "description",
            Enum = ["string"],
            InnerProperties = JsonSerializer.Deserialize<JsonElement>("{}"),
            InnerRequiredKeys = ["string"],
            InnerValType = "inner_val_type",
            Items = new()
            {
                ValType = "val_type",
                Description = "description",
                Enum = ["string"],
                InnerProperties = JsonSerializer.Deserialize<JsonElement>("{}"),
                InnerRequiredKeys = ["string"],
                InnerValType = "inner_val_type",
                Items = new()
                {
                    ValType = "val_type",
                    Description = "description",
                    Enum = ["string"],
                    InnerProperties = JsonSerializer.Deserialize<JsonElement>("{}"),
                    InnerRequiredKeys = ["string"],
                    InnerValType = "inner_val_type",
                    Nullable = true,
                    Properties = JsonSerializer.Deserialize<JsonElement>("{}"),
                    RequiredKeys = ["string"],
                },
                Nullable = true,
                Properties = JsonSerializer.Deserialize<JsonElement>("{}"),
                RequiredKeys = ["string"],
            },
            Nullable = true,
            Properties = JsonSerializer.Deserialize<JsonElement>("{}"),
            RequiredKeys = ["string"],
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ValueSchema>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedValType = "val_type";
        string expectedDescription = "description";
        List<string> expectedEnum = ["string"];
        JsonElement expectedInnerProperties = JsonSerializer.Deserialize<JsonElement>("{}");
        List<string> expectedInnerRequiredKeys = ["string"];
        string expectedInnerValType = "inner_val_type";
        ValueSchema expectedItems = new()
        {
            ValType = "val_type",
            Description = "description",
            Enum = ["string"],
            InnerProperties = JsonSerializer.Deserialize<JsonElement>("{}"),
            InnerRequiredKeys = ["string"],
            InnerValType = "inner_val_type",
            Items = new()
            {
                ValType = "val_type",
                Description = "description",
                Enum = ["string"],
                InnerProperties = JsonSerializer.Deserialize<JsonElement>("{}"),
                InnerRequiredKeys = ["string"],
                InnerValType = "inner_val_type",
                Nullable = true,
                Properties = JsonSerializer.Deserialize<JsonElement>("{}"),
                RequiredKeys = ["string"],
            },
            Nullable = true,
            Properties = JsonSerializer.Deserialize<JsonElement>("{}"),
            RequiredKeys = ["string"],
        };
        bool expectedNullable = true;
        JsonElement expectedProperties = JsonSerializer.Deserialize<JsonElement>("{}");
        List<string> expectedRequiredKeys = ["string"];

        Assert.Equal(expectedValType, deserialized.ValType);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.NotNull(deserialized.Enum);
        Assert.Equal(expectedEnum.Count, deserialized.Enum.Count);
        for (int i = 0; i < expectedEnum.Count; i++)
        {
            Assert.Equal(expectedEnum[i], deserialized.Enum[i]);
        }
        Assert.NotNull(deserialized.InnerProperties);
        Assert.True(
            JsonElement.DeepEquals(expectedInnerProperties, deserialized.InnerProperties.Value)
        );
        Assert.NotNull(deserialized.InnerRequiredKeys);
        Assert.Equal(expectedInnerRequiredKeys.Count, deserialized.InnerRequiredKeys.Count);
        for (int i = 0; i < expectedInnerRequiredKeys.Count; i++)
        {
            Assert.Equal(expectedInnerRequiredKeys[i], deserialized.InnerRequiredKeys[i]);
        }
        Assert.Equal(expectedInnerValType, deserialized.InnerValType);
        Assert.Equal(expectedItems, deserialized.Items);
        Assert.Equal(expectedNullable, deserialized.Nullable);
        Assert.NotNull(deserialized.Properties);
        Assert.True(JsonElement.DeepEquals(expectedProperties, deserialized.Properties.Value));
        Assert.NotNull(deserialized.RequiredKeys);
        Assert.Equal(expectedRequiredKeys.Count, deserialized.RequiredKeys.Count);
        for (int i = 0; i < expectedRequiredKeys.Count; i++)
        {
            Assert.Equal(expectedRequiredKeys[i], deserialized.RequiredKeys[i]);
        }
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new ValueSchema
        {
            ValType = "val_type",
            Description = "description",
            Enum = ["string"],
            InnerProperties = JsonSerializer.Deserialize<JsonElement>("{}"),
            InnerRequiredKeys = ["string"],
            InnerValType = "inner_val_type",
            Items = new()
            {
                ValType = "val_type",
                Description = "description",
                Enum = ["string"],
                InnerProperties = JsonSerializer.Deserialize<JsonElement>("{}"),
                InnerRequiredKeys = ["string"],
                InnerValType = "inner_val_type",
                Items = new()
                {
                    ValType = "val_type",
                    Description = "description",
                    Enum = ["string"],
                    InnerProperties = JsonSerializer.Deserialize<JsonElement>("{}"),
                    InnerRequiredKeys = ["string"],
                    InnerValType = "inner_val_type",
                    Nullable = true,
                    Properties = JsonSerializer.Deserialize<JsonElement>("{}"),
                    RequiredKeys = ["string"],
                },
                Nullable = true,
                Properties = JsonSerializer.Deserialize<JsonElement>("{}"),
                RequiredKeys = ["string"],
            },
            Nullable = true,
            Properties = JsonSerializer.Deserialize<JsonElement>("{}"),
            RequiredKeys = ["string"],
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new ValueSchema { ValType = "val_type" };

        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Enum);
        Assert.False(model.RawData.ContainsKey("enum"));
        Assert.Null(model.InnerProperties);
        Assert.False(model.RawData.ContainsKey("inner_properties"));
        Assert.Null(model.InnerRequiredKeys);
        Assert.False(model.RawData.ContainsKey("inner_required_keys"));
        Assert.Null(model.InnerValType);
        Assert.False(model.RawData.ContainsKey("inner_val_type"));
        Assert.Null(model.Items);
        Assert.False(model.RawData.ContainsKey("items"));
        Assert.Null(model.Nullable);
        Assert.False(model.RawData.ContainsKey("nullable"));
        Assert.Null(model.Properties);
        Assert.False(model.RawData.ContainsKey("properties"));
        Assert.Null(model.RequiredKeys);
        Assert.False(model.RawData.ContainsKey("required_keys"));
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
            Description = null,
            Enum = null,
            InnerProperties = null,
            InnerRequiredKeys = null,
            InnerValType = null,
            Items = null,
            Nullable = null,
            Properties = null,
            RequiredKeys = null,
        };

        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Enum);
        Assert.False(model.RawData.ContainsKey("enum"));
        Assert.Null(model.InnerProperties);
        Assert.False(model.RawData.ContainsKey("inner_properties"));
        Assert.Null(model.InnerRequiredKeys);
        Assert.False(model.RawData.ContainsKey("inner_required_keys"));
        Assert.Null(model.InnerValType);
        Assert.False(model.RawData.ContainsKey("inner_val_type"));
        Assert.Null(model.Items);
        Assert.False(model.RawData.ContainsKey("items"));
        Assert.Null(model.Nullable);
        Assert.False(model.RawData.ContainsKey("nullable"));
        Assert.Null(model.Properties);
        Assert.False(model.RawData.ContainsKey("properties"));
        Assert.Null(model.RequiredKeys);
        Assert.False(model.RawData.ContainsKey("required_keys"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new ValueSchema
        {
            ValType = "val_type",

            // Null should be interpreted as omitted for these properties
            Description = null,
            Enum = null,
            InnerProperties = null,
            InnerRequiredKeys = null,
            InnerValType = null,
            Items = null,
            Nullable = null,
            Properties = null,
            RequiredKeys = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new ValueSchema
        {
            ValType = "val_type",
            Description = "description",
            Enum = ["string"],
            InnerProperties = JsonSerializer.Deserialize<JsonElement>("{}"),
            InnerRequiredKeys = ["string"],
            InnerValType = "inner_val_type",
            Items = new()
            {
                ValType = "val_type",
                Description = "description",
                Enum = ["string"],
                InnerProperties = JsonSerializer.Deserialize<JsonElement>("{}"),
                InnerRequiredKeys = ["string"],
                InnerValType = "inner_val_type",
                Items = new()
                {
                    ValType = "val_type",
                    Description = "description",
                    Enum = ["string"],
                    InnerProperties = JsonSerializer.Deserialize<JsonElement>("{}"),
                    InnerRequiredKeys = ["string"],
                    InnerValType = "inner_val_type",
                    Nullable = true,
                    Properties = JsonSerializer.Deserialize<JsonElement>("{}"),
                    RequiredKeys = ["string"],
                },
                Nullable = true,
                Properties = JsonSerializer.Deserialize<JsonElement>("{}"),
                RequiredKeys = ["string"],
            },
            Nullable = true,
            Properties = JsonSerializer.Deserialize<JsonElement>("{}"),
            RequiredKeys = ["string"],
        };

        ValueSchema copied = new(model);

        Assert.Equal(model, copied);
    }
}
