using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Core;
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
}
