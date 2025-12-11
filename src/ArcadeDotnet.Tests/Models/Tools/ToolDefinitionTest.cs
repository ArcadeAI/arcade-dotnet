using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using ArcadeDotnet.Models.Tools;

namespace ArcadeDotnet.Tests.Models.Tools;

public class ToolDefinitionTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ToolDefinition
        {
            FullyQualifiedName = "fully_qualified_name",
            Input = new()
            {
                Parameters =
                [
                    new()
                    {
                        Name = "name",
                        ValueSchema = new()
                        {
                            ValType = "val_type",
                            Enum = ["string"],
                            InnerValType = "inner_val_type",
                        },
                        Description = "description",
                        Inferrable = true,
                        Required = true,
                    },
                ],
            },
            Name = "name",
            QualifiedName = "qualified_name",
            Toolkit = new()
            {
                Name = "name",
                Description = "description",
                Version = "version",
            },
            Description = "description",
            FormattedSchema = new Dictionary<string, JsonElement>()
            {
                { "foo", JsonSerializer.SerializeToElement("bar") },
            },
            Output = new()
            {
                AvailableModes = ["string"],
                Description = "description",
                ValueSchema = new()
                {
                    ValType = "val_type",
                    Enum = ["string"],
                    InnerValType = "inner_val_type",
                },
            },
            Requirements = new()
            {
                Authorization = new()
                {
                    ID = "id",
                    Oauth2 = new() { Scopes = ["string"] },
                    ProviderID = "provider_id",
                    ProviderType = "provider_type",
                    Status = Status.Active,
                    StatusReason = "status_reason",
                    TokenStatus = TokenStatus.NotStarted,
                },
                Met = true,
                Secrets =
                [
                    new()
                    {
                        Key = "key",
                        Met = true,
                        StatusReason = "status_reason",
                    },
                ],
            },
        };

        string expectedFullyQualifiedName = "fully_qualified_name";
        Input expectedInput = new()
        {
            Parameters =
            [
                new()
                {
                    Name = "name",
                    ValueSchema = new()
                    {
                        ValType = "val_type",
                        Enum = ["string"],
                        InnerValType = "inner_val_type",
                    },
                    Description = "description",
                    Inferrable = true,
                    Required = true,
                },
            ],
        };
        string expectedName = "name";
        string expectedQualifiedName = "qualified_name";
        Toolkit expectedToolkit = new()
        {
            Name = "name",
            Description = "description",
            Version = "version",
        };
        string expectedDescription = "description";
        Dictionary<string, JsonElement> expectedFormattedSchema = new()
        {
            { "foo", JsonSerializer.SerializeToElement("bar") },
        };
        ToolDefinitionOutput expectedOutput = new()
        {
            AvailableModes = ["string"],
            Description = "description",
            ValueSchema = new()
            {
                ValType = "val_type",
                Enum = ["string"],
                InnerValType = "inner_val_type",
            },
        };
        Requirements expectedRequirements = new()
        {
            Authorization = new()
            {
                ID = "id",
                Oauth2 = new() { Scopes = ["string"] },
                ProviderID = "provider_id",
                ProviderType = "provider_type",
                Status = Status.Active,
                StatusReason = "status_reason",
                TokenStatus = TokenStatus.NotStarted,
            },
            Met = true,
            Secrets =
            [
                new()
                {
                    Key = "key",
                    Met = true,
                    StatusReason = "status_reason",
                },
            ],
        };

        Assert.Equal(expectedFullyQualifiedName, model.FullyQualifiedName);
        Assert.Equal(expectedInput, model.Input);
        Assert.Equal(expectedName, model.Name);
        Assert.Equal(expectedQualifiedName, model.QualifiedName);
        Assert.Equal(expectedToolkit, model.Toolkit);
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedFormattedSchema.Count, model.FormattedSchema.Count);
        foreach (var item in expectedFormattedSchema)
        {
            Assert.True(model.FormattedSchema.TryGetValue(item.Key, out var value));

            Assert.True(JsonElement.DeepEquals(value, model.FormattedSchema[item.Key]));
        }
        Assert.Equal(expectedOutput, model.Output);
        Assert.Equal(expectedRequirements, model.Requirements);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new ToolDefinition
        {
            FullyQualifiedName = "fully_qualified_name",
            Input = new()
            {
                Parameters =
                [
                    new()
                    {
                        Name = "name",
                        ValueSchema = new()
                        {
                            ValType = "val_type",
                            Enum = ["string"],
                            InnerValType = "inner_val_type",
                        },
                        Description = "description",
                        Inferrable = true,
                        Required = true,
                    },
                ],
            },
            Name = "name",
            QualifiedName = "qualified_name",
            Toolkit = new()
            {
                Name = "name",
                Description = "description",
                Version = "version",
            },
            Description = "description",
            FormattedSchema = new Dictionary<string, JsonElement>()
            {
                { "foo", JsonSerializer.SerializeToElement("bar") },
            },
            Output = new()
            {
                AvailableModes = ["string"],
                Description = "description",
                ValueSchema = new()
                {
                    ValType = "val_type",
                    Enum = ["string"],
                    InnerValType = "inner_val_type",
                },
            },
            Requirements = new()
            {
                Authorization = new()
                {
                    ID = "id",
                    Oauth2 = new() { Scopes = ["string"] },
                    ProviderID = "provider_id",
                    ProviderType = "provider_type",
                    Status = Status.Active,
                    StatusReason = "status_reason",
                    TokenStatus = TokenStatus.NotStarted,
                },
                Met = true,
                Secrets =
                [
                    new()
                    {
                        Key = "key",
                        Met = true,
                        StatusReason = "status_reason",
                    },
                ],
            },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ToolDefinition>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ToolDefinition
        {
            FullyQualifiedName = "fully_qualified_name",
            Input = new()
            {
                Parameters =
                [
                    new()
                    {
                        Name = "name",
                        ValueSchema = new()
                        {
                            ValType = "val_type",
                            Enum = ["string"],
                            InnerValType = "inner_val_type",
                        },
                        Description = "description",
                        Inferrable = true,
                        Required = true,
                    },
                ],
            },
            Name = "name",
            QualifiedName = "qualified_name",
            Toolkit = new()
            {
                Name = "name",
                Description = "description",
                Version = "version",
            },
            Description = "description",
            FormattedSchema = new Dictionary<string, JsonElement>()
            {
                { "foo", JsonSerializer.SerializeToElement("bar") },
            },
            Output = new()
            {
                AvailableModes = ["string"],
                Description = "description",
                ValueSchema = new()
                {
                    ValType = "val_type",
                    Enum = ["string"],
                    InnerValType = "inner_val_type",
                },
            },
            Requirements = new()
            {
                Authorization = new()
                {
                    ID = "id",
                    Oauth2 = new() { Scopes = ["string"] },
                    ProviderID = "provider_id",
                    ProviderType = "provider_type",
                    Status = Status.Active,
                    StatusReason = "status_reason",
                    TokenStatus = TokenStatus.NotStarted,
                },
                Met = true,
                Secrets =
                [
                    new()
                    {
                        Key = "key",
                        Met = true,
                        StatusReason = "status_reason",
                    },
                ],
            },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ToolDefinition>(json);
        Assert.NotNull(deserialized);

        string expectedFullyQualifiedName = "fully_qualified_name";
        Input expectedInput = new()
        {
            Parameters =
            [
                new()
                {
                    Name = "name",
                    ValueSchema = new()
                    {
                        ValType = "val_type",
                        Enum = ["string"],
                        InnerValType = "inner_val_type",
                    },
                    Description = "description",
                    Inferrable = true,
                    Required = true,
                },
            ],
        };
        string expectedName = "name";
        string expectedQualifiedName = "qualified_name";
        Toolkit expectedToolkit = new()
        {
            Name = "name",
            Description = "description",
            Version = "version",
        };
        string expectedDescription = "description";
        Dictionary<string, JsonElement> expectedFormattedSchema = new()
        {
            { "foo", JsonSerializer.SerializeToElement("bar") },
        };
        ToolDefinitionOutput expectedOutput = new()
        {
            AvailableModes = ["string"],
            Description = "description",
            ValueSchema = new()
            {
                ValType = "val_type",
                Enum = ["string"],
                InnerValType = "inner_val_type",
            },
        };
        Requirements expectedRequirements = new()
        {
            Authorization = new()
            {
                ID = "id",
                Oauth2 = new() { Scopes = ["string"] },
                ProviderID = "provider_id",
                ProviderType = "provider_type",
                Status = Status.Active,
                StatusReason = "status_reason",
                TokenStatus = TokenStatus.NotStarted,
            },
            Met = true,
            Secrets =
            [
                new()
                {
                    Key = "key",
                    Met = true,
                    StatusReason = "status_reason",
                },
            ],
        };

        Assert.Equal(expectedFullyQualifiedName, deserialized.FullyQualifiedName);
        Assert.Equal(expectedInput, deserialized.Input);
        Assert.Equal(expectedName, deserialized.Name);
        Assert.Equal(expectedQualifiedName, deserialized.QualifiedName);
        Assert.Equal(expectedToolkit, deserialized.Toolkit);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedFormattedSchema.Count, deserialized.FormattedSchema.Count);
        foreach (var item in expectedFormattedSchema)
        {
            Assert.True(deserialized.FormattedSchema.TryGetValue(item.Key, out var value));

            Assert.True(JsonElement.DeepEquals(value, deserialized.FormattedSchema[item.Key]));
        }
        Assert.Equal(expectedOutput, deserialized.Output);
        Assert.Equal(expectedRequirements, deserialized.Requirements);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new ToolDefinition
        {
            FullyQualifiedName = "fully_qualified_name",
            Input = new()
            {
                Parameters =
                [
                    new()
                    {
                        Name = "name",
                        ValueSchema = new()
                        {
                            ValType = "val_type",
                            Enum = ["string"],
                            InnerValType = "inner_val_type",
                        },
                        Description = "description",
                        Inferrable = true,
                        Required = true,
                    },
                ],
            },
            Name = "name",
            QualifiedName = "qualified_name",
            Toolkit = new()
            {
                Name = "name",
                Description = "description",
                Version = "version",
            },
            Description = "description",
            FormattedSchema = new Dictionary<string, JsonElement>()
            {
                { "foo", JsonSerializer.SerializeToElement("bar") },
            },
            Output = new()
            {
                AvailableModes = ["string"],
                Description = "description",
                ValueSchema = new()
                {
                    ValType = "val_type",
                    Enum = ["string"],
                    InnerValType = "inner_val_type",
                },
            },
            Requirements = new()
            {
                Authorization = new()
                {
                    ID = "id",
                    Oauth2 = new() { Scopes = ["string"] },
                    ProviderID = "provider_id",
                    ProviderType = "provider_type",
                    Status = Status.Active,
                    StatusReason = "status_reason",
                    TokenStatus = TokenStatus.NotStarted,
                },
                Met = true,
                Secrets =
                [
                    new()
                    {
                        Key = "key",
                        Met = true,
                        StatusReason = "status_reason",
                    },
                ],
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new ToolDefinition
        {
            FullyQualifiedName = "fully_qualified_name",
            Input = new()
            {
                Parameters =
                [
                    new()
                    {
                        Name = "name",
                        ValueSchema = new()
                        {
                            ValType = "val_type",
                            Enum = ["string"],
                            InnerValType = "inner_val_type",
                        },
                        Description = "description",
                        Inferrable = true,
                        Required = true,
                    },
                ],
            },
            Name = "name",
            QualifiedName = "qualified_name",
            Toolkit = new()
            {
                Name = "name",
                Description = "description",
                Version = "version",
            },
        };

        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.FormattedSchema);
        Assert.False(model.RawData.ContainsKey("formatted_schema"));
        Assert.Null(model.Output);
        Assert.False(model.RawData.ContainsKey("output"));
        Assert.Null(model.Requirements);
        Assert.False(model.RawData.ContainsKey("requirements"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new ToolDefinition
        {
            FullyQualifiedName = "fully_qualified_name",
            Input = new()
            {
                Parameters =
                [
                    new()
                    {
                        Name = "name",
                        ValueSchema = new()
                        {
                            ValType = "val_type",
                            Enum = ["string"],
                            InnerValType = "inner_val_type",
                        },
                        Description = "description",
                        Inferrable = true,
                        Required = true,
                    },
                ],
            },
            Name = "name",
            QualifiedName = "qualified_name",
            Toolkit = new()
            {
                Name = "name",
                Description = "description",
                Version = "version",
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new ToolDefinition
        {
            FullyQualifiedName = "fully_qualified_name",
            Input = new()
            {
                Parameters =
                [
                    new()
                    {
                        Name = "name",
                        ValueSchema = new()
                        {
                            ValType = "val_type",
                            Enum = ["string"],
                            InnerValType = "inner_val_type",
                        },
                        Description = "description",
                        Inferrable = true,
                        Required = true,
                    },
                ],
            },
            Name = "name",
            QualifiedName = "qualified_name",
            Toolkit = new()
            {
                Name = "name",
                Description = "description",
                Version = "version",
            },

            // Null should be interpreted as omitted for these properties
            Description = null,
            FormattedSchema = null,
            Output = null,
            Requirements = null,
        };

        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.FormattedSchema);
        Assert.False(model.RawData.ContainsKey("formatted_schema"));
        Assert.Null(model.Output);
        Assert.False(model.RawData.ContainsKey("output"));
        Assert.Null(model.Requirements);
        Assert.False(model.RawData.ContainsKey("requirements"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new ToolDefinition
        {
            FullyQualifiedName = "fully_qualified_name",
            Input = new()
            {
                Parameters =
                [
                    new()
                    {
                        Name = "name",
                        ValueSchema = new()
                        {
                            ValType = "val_type",
                            Enum = ["string"],
                            InnerValType = "inner_val_type",
                        },
                        Description = "description",
                        Inferrable = true,
                        Required = true,
                    },
                ],
            },
            Name = "name",
            QualifiedName = "qualified_name",
            Toolkit = new()
            {
                Name = "name",
                Description = "description",
                Version = "version",
            },

            // Null should be interpreted as omitted for these properties
            Description = null,
            FormattedSchema = null,
            Output = null,
            Requirements = null,
        };

        model.Validate();
    }
}

public class InputTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Input
        {
            Parameters =
            [
                new()
                {
                    Name = "name",
                    ValueSchema = new()
                    {
                        ValType = "val_type",
                        Enum = ["string"],
                        InnerValType = "inner_val_type",
                    },
                    Description = "description",
                    Inferrable = true,
                    Required = true,
                },
            ],
        };

        List<Parameter> expectedParameters =
        [
            new()
            {
                Name = "name",
                ValueSchema = new()
                {
                    ValType = "val_type",
                    Enum = ["string"],
                    InnerValType = "inner_val_type",
                },
                Description = "description",
                Inferrable = true,
                Required = true,
            },
        ];

        Assert.Equal(expectedParameters.Count, model.Parameters.Count);
        for (int i = 0; i < expectedParameters.Count; i++)
        {
            Assert.Equal(expectedParameters[i], model.Parameters[i]);
        }
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Input
        {
            Parameters =
            [
                new()
                {
                    Name = "name",
                    ValueSchema = new()
                    {
                        ValType = "val_type",
                        Enum = ["string"],
                        InnerValType = "inner_val_type",
                    },
                    Description = "description",
                    Inferrable = true,
                    Required = true,
                },
            ],
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Input>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Input
        {
            Parameters =
            [
                new()
                {
                    Name = "name",
                    ValueSchema = new()
                    {
                        ValType = "val_type",
                        Enum = ["string"],
                        InnerValType = "inner_val_type",
                    },
                    Description = "description",
                    Inferrable = true,
                    Required = true,
                },
            ],
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Input>(json);
        Assert.NotNull(deserialized);

        List<Parameter> expectedParameters =
        [
            new()
            {
                Name = "name",
                ValueSchema = new()
                {
                    ValType = "val_type",
                    Enum = ["string"],
                    InnerValType = "inner_val_type",
                },
                Description = "description",
                Inferrable = true,
                Required = true,
            },
        ];

        Assert.Equal(expectedParameters.Count, deserialized.Parameters.Count);
        for (int i = 0; i < expectedParameters.Count; i++)
        {
            Assert.Equal(expectedParameters[i], deserialized.Parameters[i]);
        }
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Input
        {
            Parameters =
            [
                new()
                {
                    Name = "name",
                    ValueSchema = new()
                    {
                        ValType = "val_type",
                        Enum = ["string"],
                        InnerValType = "inner_val_type",
                    },
                    Description = "description",
                    Inferrable = true,
                    Required = true,
                },
            ],
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Input { };

        Assert.Null(model.Parameters);
        Assert.False(model.RawData.ContainsKey("parameters"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Input { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Input
        {
            // Null should be interpreted as omitted for these properties
            Parameters = null,
        };

        Assert.Null(model.Parameters);
        Assert.False(model.RawData.ContainsKey("parameters"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Input
        {
            // Null should be interpreted as omitted for these properties
            Parameters = null,
        };

        model.Validate();
    }
}

public class ParameterTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Parameter
        {
            Name = "name",
            ValueSchema = new()
            {
                ValType = "val_type",
                Enum = ["string"],
                InnerValType = "inner_val_type",
            },
            Description = "description",
            Inferrable = true,
            Required = true,
        };

        string expectedName = "name";
        ValueSchema expectedValueSchema = new()
        {
            ValType = "val_type",
            Enum = ["string"],
            InnerValType = "inner_val_type",
        };
        string expectedDescription = "description";
        bool expectedInferrable = true;
        bool expectedRequired = true;

        Assert.Equal(expectedName, model.Name);
        Assert.Equal(expectedValueSchema, model.ValueSchema);
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedInferrable, model.Inferrable);
        Assert.Equal(expectedRequired, model.Required);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Parameter
        {
            Name = "name",
            ValueSchema = new()
            {
                ValType = "val_type",
                Enum = ["string"],
                InnerValType = "inner_val_type",
            },
            Description = "description",
            Inferrable = true,
            Required = true,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Parameter>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Parameter
        {
            Name = "name",
            ValueSchema = new()
            {
                ValType = "val_type",
                Enum = ["string"],
                InnerValType = "inner_val_type",
            },
            Description = "description",
            Inferrable = true,
            Required = true,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Parameter>(json);
        Assert.NotNull(deserialized);

        string expectedName = "name";
        ValueSchema expectedValueSchema = new()
        {
            ValType = "val_type",
            Enum = ["string"],
            InnerValType = "inner_val_type",
        };
        string expectedDescription = "description";
        bool expectedInferrable = true;
        bool expectedRequired = true;

        Assert.Equal(expectedName, deserialized.Name);
        Assert.Equal(expectedValueSchema, deserialized.ValueSchema);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedInferrable, deserialized.Inferrable);
        Assert.Equal(expectedRequired, deserialized.Required);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Parameter
        {
            Name = "name",
            ValueSchema = new()
            {
                ValType = "val_type",
                Enum = ["string"],
                InnerValType = "inner_val_type",
            },
            Description = "description",
            Inferrable = true,
            Required = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Parameter
        {
            Name = "name",
            ValueSchema = new()
            {
                ValType = "val_type",
                Enum = ["string"],
                InnerValType = "inner_val_type",
            },
        };

        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Inferrable);
        Assert.False(model.RawData.ContainsKey("inferrable"));
        Assert.Null(model.Required);
        Assert.False(model.RawData.ContainsKey("required"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Parameter
        {
            Name = "name",
            ValueSchema = new()
            {
                ValType = "val_type",
                Enum = ["string"],
                InnerValType = "inner_val_type",
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Parameter
        {
            Name = "name",
            ValueSchema = new()
            {
                ValType = "val_type",
                Enum = ["string"],
                InnerValType = "inner_val_type",
            },

            // Null should be interpreted as omitted for these properties
            Description = null,
            Inferrable = null,
            Required = null,
        };

        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Inferrable);
        Assert.False(model.RawData.ContainsKey("inferrable"));
        Assert.Null(model.Required);
        Assert.False(model.RawData.ContainsKey("required"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Parameter
        {
            Name = "name",
            ValueSchema = new()
            {
                ValType = "val_type",
                Enum = ["string"],
                InnerValType = "inner_val_type",
            },

            // Null should be interpreted as omitted for these properties
            Description = null,
            Inferrable = null,
            Required = null,
        };

        model.Validate();
    }
}

public class ToolkitTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Toolkit
        {
            Name = "name",
            Description = "description",
            Version = "version",
        };

        string expectedName = "name";
        string expectedDescription = "description";
        string expectedVersion = "version";

        Assert.Equal(expectedName, model.Name);
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedVersion, model.Version);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Toolkit
        {
            Name = "name",
            Description = "description",
            Version = "version",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Toolkit>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Toolkit
        {
            Name = "name",
            Description = "description",
            Version = "version",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Toolkit>(json);
        Assert.NotNull(deserialized);

        string expectedName = "name";
        string expectedDescription = "description";
        string expectedVersion = "version";

        Assert.Equal(expectedName, deserialized.Name);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedVersion, deserialized.Version);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Toolkit
        {
            Name = "name",
            Description = "description",
            Version = "version",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Toolkit { Name = "name" };

        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Version);
        Assert.False(model.RawData.ContainsKey("version"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Toolkit { Name = "name" };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Toolkit
        {
            Name = "name",

            // Null should be interpreted as omitted for these properties
            Description = null,
            Version = null,
        };

        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Version);
        Assert.False(model.RawData.ContainsKey("version"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Toolkit
        {
            Name = "name",

            // Null should be interpreted as omitted for these properties
            Description = null,
            Version = null,
        };

        model.Validate();
    }
}

public class ToolDefinitionOutputTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ToolDefinitionOutput
        {
            AvailableModes = ["string"],
            Description = "description",
            ValueSchema = new()
            {
                ValType = "val_type",
                Enum = ["string"],
                InnerValType = "inner_val_type",
            },
        };

        List<string> expectedAvailableModes = ["string"];
        string expectedDescription = "description";
        ValueSchema expectedValueSchema = new()
        {
            ValType = "val_type",
            Enum = ["string"],
            InnerValType = "inner_val_type",
        };

        Assert.Equal(expectedAvailableModes.Count, model.AvailableModes.Count);
        for (int i = 0; i < expectedAvailableModes.Count; i++)
        {
            Assert.Equal(expectedAvailableModes[i], model.AvailableModes[i]);
        }
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedValueSchema, model.ValueSchema);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new ToolDefinitionOutput
        {
            AvailableModes = ["string"],
            Description = "description",
            ValueSchema = new()
            {
                ValType = "val_type",
                Enum = ["string"],
                InnerValType = "inner_val_type",
            },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ToolDefinitionOutput>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ToolDefinitionOutput
        {
            AvailableModes = ["string"],
            Description = "description",
            ValueSchema = new()
            {
                ValType = "val_type",
                Enum = ["string"],
                InnerValType = "inner_val_type",
            },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ToolDefinitionOutput>(json);
        Assert.NotNull(deserialized);

        List<string> expectedAvailableModes = ["string"];
        string expectedDescription = "description";
        ValueSchema expectedValueSchema = new()
        {
            ValType = "val_type",
            Enum = ["string"],
            InnerValType = "inner_val_type",
        };

        Assert.Equal(expectedAvailableModes.Count, deserialized.AvailableModes.Count);
        for (int i = 0; i < expectedAvailableModes.Count; i++)
        {
            Assert.Equal(expectedAvailableModes[i], deserialized.AvailableModes[i]);
        }
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedValueSchema, deserialized.ValueSchema);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new ToolDefinitionOutput
        {
            AvailableModes = ["string"],
            Description = "description",
            ValueSchema = new()
            {
                ValType = "val_type",
                Enum = ["string"],
                InnerValType = "inner_val_type",
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new ToolDefinitionOutput { };

        Assert.Null(model.AvailableModes);
        Assert.False(model.RawData.ContainsKey("available_modes"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.ValueSchema);
        Assert.False(model.RawData.ContainsKey("value_schema"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new ToolDefinitionOutput { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new ToolDefinitionOutput
        {
            // Null should be interpreted as omitted for these properties
            AvailableModes = null,
            Description = null,
            ValueSchema = null,
        };

        Assert.Null(model.AvailableModes);
        Assert.False(model.RawData.ContainsKey("available_modes"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.ValueSchema);
        Assert.False(model.RawData.ContainsKey("value_schema"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new ToolDefinitionOutput
        {
            // Null should be interpreted as omitted for these properties
            AvailableModes = null,
            Description = null,
            ValueSchema = null,
        };

        model.Validate();
    }
}

public class RequirementsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Requirements
        {
            Authorization = new()
            {
                ID = "id",
                Oauth2 = new() { Scopes = ["string"] },
                ProviderID = "provider_id",
                ProviderType = "provider_type",
                Status = Status.Active,
                StatusReason = "status_reason",
                TokenStatus = TokenStatus.NotStarted,
            },
            Met = true,
            Secrets =
            [
                new()
                {
                    Key = "key",
                    Met = true,
                    StatusReason = "status_reason",
                },
            ],
        };

        Authorization expectedAuthorization = new()
        {
            ID = "id",
            Oauth2 = new() { Scopes = ["string"] },
            ProviderID = "provider_id",
            ProviderType = "provider_type",
            Status = Status.Active,
            StatusReason = "status_reason",
            TokenStatus = TokenStatus.NotStarted,
        };
        bool expectedMet = true;
        List<Secret> expectedSecrets =
        [
            new()
            {
                Key = "key",
                Met = true,
                StatusReason = "status_reason",
            },
        ];

        Assert.Equal(expectedAuthorization, model.Authorization);
        Assert.Equal(expectedMet, model.Met);
        Assert.Equal(expectedSecrets.Count, model.Secrets.Count);
        for (int i = 0; i < expectedSecrets.Count; i++)
        {
            Assert.Equal(expectedSecrets[i], model.Secrets[i]);
        }
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Requirements
        {
            Authorization = new()
            {
                ID = "id",
                Oauth2 = new() { Scopes = ["string"] },
                ProviderID = "provider_id",
                ProviderType = "provider_type",
                Status = Status.Active,
                StatusReason = "status_reason",
                TokenStatus = TokenStatus.NotStarted,
            },
            Met = true,
            Secrets =
            [
                new()
                {
                    Key = "key",
                    Met = true,
                    StatusReason = "status_reason",
                },
            ],
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Requirements>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Requirements
        {
            Authorization = new()
            {
                ID = "id",
                Oauth2 = new() { Scopes = ["string"] },
                ProviderID = "provider_id",
                ProviderType = "provider_type",
                Status = Status.Active,
                StatusReason = "status_reason",
                TokenStatus = TokenStatus.NotStarted,
            },
            Met = true,
            Secrets =
            [
                new()
                {
                    Key = "key",
                    Met = true,
                    StatusReason = "status_reason",
                },
            ],
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Requirements>(json);
        Assert.NotNull(deserialized);

        Authorization expectedAuthorization = new()
        {
            ID = "id",
            Oauth2 = new() { Scopes = ["string"] },
            ProviderID = "provider_id",
            ProviderType = "provider_type",
            Status = Status.Active,
            StatusReason = "status_reason",
            TokenStatus = TokenStatus.NotStarted,
        };
        bool expectedMet = true;
        List<Secret> expectedSecrets =
        [
            new()
            {
                Key = "key",
                Met = true,
                StatusReason = "status_reason",
            },
        ];

        Assert.Equal(expectedAuthorization, deserialized.Authorization);
        Assert.Equal(expectedMet, deserialized.Met);
        Assert.Equal(expectedSecrets.Count, deserialized.Secrets.Count);
        for (int i = 0; i < expectedSecrets.Count; i++)
        {
            Assert.Equal(expectedSecrets[i], deserialized.Secrets[i]);
        }
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Requirements
        {
            Authorization = new()
            {
                ID = "id",
                Oauth2 = new() { Scopes = ["string"] },
                ProviderID = "provider_id",
                ProviderType = "provider_type",
                Status = Status.Active,
                StatusReason = "status_reason",
                TokenStatus = TokenStatus.NotStarted,
            },
            Met = true,
            Secrets =
            [
                new()
                {
                    Key = "key",
                    Met = true,
                    StatusReason = "status_reason",
                },
            ],
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Requirements { };

        Assert.Null(model.Authorization);
        Assert.False(model.RawData.ContainsKey("authorization"));
        Assert.Null(model.Met);
        Assert.False(model.RawData.ContainsKey("met"));
        Assert.Null(model.Secrets);
        Assert.False(model.RawData.ContainsKey("secrets"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Requirements { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Requirements
        {
            // Null should be interpreted as omitted for these properties
            Authorization = null,
            Met = null,
            Secrets = null,
        };

        Assert.Null(model.Authorization);
        Assert.False(model.RawData.ContainsKey("authorization"));
        Assert.Null(model.Met);
        Assert.False(model.RawData.ContainsKey("met"));
        Assert.Null(model.Secrets);
        Assert.False(model.RawData.ContainsKey("secrets"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Requirements
        {
            // Null should be interpreted as omitted for these properties
            Authorization = null,
            Met = null,
            Secrets = null,
        };

        model.Validate();
    }
}

public class AuthorizationTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Authorization
        {
            ID = "id",
            Oauth2 = new() { Scopes = ["string"] },
            ProviderID = "provider_id",
            ProviderType = "provider_type",
            Status = Status.Active,
            StatusReason = "status_reason",
            TokenStatus = TokenStatus.NotStarted,
        };

        string expectedID = "id";
        Oauth2 expectedOauth2 = new() { Scopes = ["string"] };
        string expectedProviderID = "provider_id";
        string expectedProviderType = "provider_type";
        ApiEnum<string, Status> expectedStatus = Status.Active;
        string expectedStatusReason = "status_reason";
        ApiEnum<string, TokenStatus> expectedTokenStatus = TokenStatus.NotStarted;

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedOauth2, model.Oauth2);
        Assert.Equal(expectedProviderID, model.ProviderID);
        Assert.Equal(expectedProviderType, model.ProviderType);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedStatusReason, model.StatusReason);
        Assert.Equal(expectedTokenStatus, model.TokenStatus);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Authorization
        {
            ID = "id",
            Oauth2 = new() { Scopes = ["string"] },
            ProviderID = "provider_id",
            ProviderType = "provider_type",
            Status = Status.Active,
            StatusReason = "status_reason",
            TokenStatus = TokenStatus.NotStarted,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Authorization>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Authorization
        {
            ID = "id",
            Oauth2 = new() { Scopes = ["string"] },
            ProviderID = "provider_id",
            ProviderType = "provider_type",
            Status = Status.Active,
            StatusReason = "status_reason",
            TokenStatus = TokenStatus.NotStarted,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Authorization>(json);
        Assert.NotNull(deserialized);

        string expectedID = "id";
        Oauth2 expectedOauth2 = new() { Scopes = ["string"] };
        string expectedProviderID = "provider_id";
        string expectedProviderType = "provider_type";
        ApiEnum<string, Status> expectedStatus = Status.Active;
        string expectedStatusReason = "status_reason";
        ApiEnum<string, TokenStatus> expectedTokenStatus = TokenStatus.NotStarted;

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedOauth2, deserialized.Oauth2);
        Assert.Equal(expectedProviderID, deserialized.ProviderID);
        Assert.Equal(expectedProviderType, deserialized.ProviderType);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedStatusReason, deserialized.StatusReason);
        Assert.Equal(expectedTokenStatus, deserialized.TokenStatus);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Authorization
        {
            ID = "id",
            Oauth2 = new() { Scopes = ["string"] },
            ProviderID = "provider_id",
            ProviderType = "provider_type",
            Status = Status.Active,
            StatusReason = "status_reason",
            TokenStatus = TokenStatus.NotStarted,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Authorization { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Oauth2);
        Assert.False(model.RawData.ContainsKey("oauth2"));
        Assert.Null(model.ProviderID);
        Assert.False(model.RawData.ContainsKey("provider_id"));
        Assert.Null(model.ProviderType);
        Assert.False(model.RawData.ContainsKey("provider_type"));
        Assert.Null(model.Status);
        Assert.False(model.RawData.ContainsKey("status"));
        Assert.Null(model.StatusReason);
        Assert.False(model.RawData.ContainsKey("status_reason"));
        Assert.Null(model.TokenStatus);
        Assert.False(model.RawData.ContainsKey("token_status"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Authorization { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Authorization
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Oauth2 = null,
            ProviderID = null,
            ProviderType = null,
            Status = null,
            StatusReason = null,
            TokenStatus = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Oauth2);
        Assert.False(model.RawData.ContainsKey("oauth2"));
        Assert.Null(model.ProviderID);
        Assert.False(model.RawData.ContainsKey("provider_id"));
        Assert.Null(model.ProviderType);
        Assert.False(model.RawData.ContainsKey("provider_type"));
        Assert.Null(model.Status);
        Assert.False(model.RawData.ContainsKey("status"));
        Assert.Null(model.StatusReason);
        Assert.False(model.RawData.ContainsKey("status_reason"));
        Assert.Null(model.TokenStatus);
        Assert.False(model.RawData.ContainsKey("token_status"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Authorization
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Oauth2 = null,
            ProviderID = null,
            ProviderType = null,
            Status = null,
            StatusReason = null,
            TokenStatus = null,
        };

        model.Validate();
    }
}

public class Oauth2Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Oauth2 { Scopes = ["string"] };

        List<string> expectedScopes = ["string"];

        Assert.Equal(expectedScopes.Count, model.Scopes.Count);
        for (int i = 0; i < expectedScopes.Count; i++)
        {
            Assert.Equal(expectedScopes[i], model.Scopes[i]);
        }
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Oauth2 { Scopes = ["string"] };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Oauth2>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Oauth2 { Scopes = ["string"] };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Oauth2>(json);
        Assert.NotNull(deserialized);

        List<string> expectedScopes = ["string"];

        Assert.Equal(expectedScopes.Count, deserialized.Scopes.Count);
        for (int i = 0; i < expectedScopes.Count; i++)
        {
            Assert.Equal(expectedScopes[i], deserialized.Scopes[i]);
        }
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Oauth2 { Scopes = ["string"] };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Oauth2 { };

        Assert.Null(model.Scopes);
        Assert.False(model.RawData.ContainsKey("scopes"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Oauth2 { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Oauth2
        {
            // Null should be interpreted as omitted for these properties
            Scopes = null,
        };

        Assert.Null(model.Scopes);
        Assert.False(model.RawData.ContainsKey("scopes"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Oauth2
        {
            // Null should be interpreted as omitted for these properties
            Scopes = null,
        };

        model.Validate();
    }
}

public class StatusTest : TestBase
{
    [Theory]
    [InlineData(Status.Active)]
    [InlineData(Status.Inactive)]
    public void Validation_Works(Status rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Status> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Status>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Status.Active)]
    [InlineData(Status.Inactive)]
    public void SerializationRoundtrip_Works(Status rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Status> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Status>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Status>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Status>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class TokenStatusTest : TestBase
{
    [Theory]
    [InlineData(TokenStatus.NotStarted)]
    [InlineData(TokenStatus.Pending)]
    [InlineData(TokenStatus.Completed)]
    [InlineData(TokenStatus.Failed)]
    public void Validation_Works(TokenStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, TokenStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, TokenStatus>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(TokenStatus.NotStarted)]
    [InlineData(TokenStatus.Pending)]
    [InlineData(TokenStatus.Completed)]
    [InlineData(TokenStatus.Failed)]
    public void SerializationRoundtrip_Works(TokenStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, TokenStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, TokenStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, TokenStatus>>(
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, TokenStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class SecretTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Secret
        {
            Key = "key",
            Met = true,
            StatusReason = "status_reason",
        };

        string expectedKey = "key";
        bool expectedMet = true;
        string expectedStatusReason = "status_reason";

        Assert.Equal(expectedKey, model.Key);
        Assert.Equal(expectedMet, model.Met);
        Assert.Equal(expectedStatusReason, model.StatusReason);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Secret
        {
            Key = "key",
            Met = true,
            StatusReason = "status_reason",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Secret>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Secret
        {
            Key = "key",
            Met = true,
            StatusReason = "status_reason",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Secret>(json);
        Assert.NotNull(deserialized);

        string expectedKey = "key";
        bool expectedMet = true;
        string expectedStatusReason = "status_reason";

        Assert.Equal(expectedKey, deserialized.Key);
        Assert.Equal(expectedMet, deserialized.Met);
        Assert.Equal(expectedStatusReason, deserialized.StatusReason);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Secret
        {
            Key = "key",
            Met = true,
            StatusReason = "status_reason",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Secret { Key = "key" };

        Assert.Null(model.Met);
        Assert.False(model.RawData.ContainsKey("met"));
        Assert.Null(model.StatusReason);
        Assert.False(model.RawData.ContainsKey("status_reason"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Secret { Key = "key" };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Secret
        {
            Key = "key",

            // Null should be interpreted as omitted for these properties
            Met = null,
            StatusReason = null,
        };

        Assert.Null(model.Met);
        Assert.False(model.RawData.ContainsKey("met"));
        Assert.Null(model.StatusReason);
        Assert.False(model.RawData.ContainsKey("status_reason"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Secret
        {
            Key = "key",

            // Null should be interpreted as omitted for these properties
            Met = null,
            StatusReason = null,
        };

        model.Validate();
    }
}
