using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models;

namespace ArcadeDotnet.Tests.Models;

public class ErrorTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Error
        {
            FieldErrors =
            [
                new()
                {
                    Field = "field",
                    Message = "message",
                    Param = "param",
                    Rule = "rule",
                },
            ],
            Message = "message",
            Name = "name",
        };

        List<FieldError> expectedFieldErrors =
        [
            new()
            {
                Field = "field",
                Message = "message",
                Param = "param",
                Rule = "rule",
            },
        ];
        string expectedMessage = "message";
        string expectedName = "name";

        Assert.NotNull(model.FieldErrors);
        Assert.Equal(expectedFieldErrors.Count, model.FieldErrors.Count);
        for (int i = 0; i < expectedFieldErrors.Count; i++)
        {
            Assert.Equal(expectedFieldErrors[i], model.FieldErrors[i]);
        }
        Assert.Equal(expectedMessage, model.Message);
        Assert.Equal(expectedName, model.Name);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Error
        {
            FieldErrors =
            [
                new()
                {
                    Field = "field",
                    Message = "message",
                    Param = "param",
                    Rule = "rule",
                },
            ],
            Message = "message",
            Name = "name",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Error>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Error
        {
            FieldErrors =
            [
                new()
                {
                    Field = "field",
                    Message = "message",
                    Param = "param",
                    Rule = "rule",
                },
            ],
            Message = "message",
            Name = "name",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Error>(element, ModelBase.SerializerOptions);
        Assert.NotNull(deserialized);

        List<FieldError> expectedFieldErrors =
        [
            new()
            {
                Field = "field",
                Message = "message",
                Param = "param",
                Rule = "rule",
            },
        ];
        string expectedMessage = "message";
        string expectedName = "name";

        Assert.NotNull(deserialized.FieldErrors);
        Assert.Equal(expectedFieldErrors.Count, deserialized.FieldErrors.Count);
        for (int i = 0; i < expectedFieldErrors.Count; i++)
        {
            Assert.Equal(expectedFieldErrors[i], deserialized.FieldErrors[i]);
        }
        Assert.Equal(expectedMessage, deserialized.Message);
        Assert.Equal(expectedName, deserialized.Name);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Error
        {
            FieldErrors =
            [
                new()
                {
                    Field = "field",
                    Message = "message",
                    Param = "param",
                    Rule = "rule",
                },
            ],
            Message = "message",
            Name = "name",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Error { };

        Assert.Null(model.FieldErrors);
        Assert.False(model.RawData.ContainsKey("field_errors"));
        Assert.Null(model.Message);
        Assert.False(model.RawData.ContainsKey("message"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Error { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Error
        {
            // Null should be interpreted as omitted for these properties
            FieldErrors = null,
            Message = null,
            Name = null,
        };

        Assert.Null(model.FieldErrors);
        Assert.False(model.RawData.ContainsKey("field_errors"));
        Assert.Null(model.Message);
        Assert.False(model.RawData.ContainsKey("message"));
        Assert.Null(model.Name);
        Assert.False(model.RawData.ContainsKey("name"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Error
        {
            // Null should be interpreted as omitted for these properties
            FieldErrors = null,
            Message = null,
            Name = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Error
        {
            FieldErrors =
            [
                new()
                {
                    Field = "field",
                    Message = "message",
                    Param = "param",
                    Rule = "rule",
                },
            ],
            Message = "message",
            Name = "name",
        };

        Error copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class FieldErrorTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new FieldError
        {
            Field = "field",
            Message = "message",
            Param = "param",
            Rule = "rule",
        };

        string expectedField = "field";
        string expectedMessage = "message";
        string expectedParam = "param";
        string expectedRule = "rule";

        Assert.Equal(expectedField, model.Field);
        Assert.Equal(expectedMessage, model.Message);
        Assert.Equal(expectedParam, model.Param);
        Assert.Equal(expectedRule, model.Rule);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new FieldError
        {
            Field = "field",
            Message = "message",
            Param = "param",
            Rule = "rule",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<FieldError>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new FieldError
        {
            Field = "field",
            Message = "message",
            Param = "param",
            Rule = "rule",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<FieldError>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedField = "field";
        string expectedMessage = "message";
        string expectedParam = "param";
        string expectedRule = "rule";

        Assert.Equal(expectedField, deserialized.Field);
        Assert.Equal(expectedMessage, deserialized.Message);
        Assert.Equal(expectedParam, deserialized.Param);
        Assert.Equal(expectedRule, deserialized.Rule);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new FieldError
        {
            Field = "field",
            Message = "message",
            Param = "param",
            Rule = "rule",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new FieldError { };

        Assert.Null(model.Field);
        Assert.False(model.RawData.ContainsKey("field"));
        Assert.Null(model.Message);
        Assert.False(model.RawData.ContainsKey("message"));
        Assert.Null(model.Param);
        Assert.False(model.RawData.ContainsKey("param"));
        Assert.Null(model.Rule);
        Assert.False(model.RawData.ContainsKey("rule"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new FieldError { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new FieldError
        {
            // Null should be interpreted as omitted for these properties
            Field = null,
            Message = null,
            Param = null,
            Rule = null,
        };

        Assert.Null(model.Field);
        Assert.False(model.RawData.ContainsKey("field"));
        Assert.Null(model.Message);
        Assert.False(model.RawData.ContainsKey("message"));
        Assert.Null(model.Param);
        Assert.False(model.RawData.ContainsKey("param"));
        Assert.Null(model.Rule);
        Assert.False(model.RawData.ContainsKey("rule"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new FieldError
        {
            // Null should be interpreted as omitted for these properties
            Field = null,
            Message = null,
            Param = null,
            Rule = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new FieldError
        {
            Field = "field",
            Message = "message",
            Param = "param",
            Rule = "rule",
        };

        FieldError copied = new(model);

        Assert.Equal(model, copied);
    }
}
