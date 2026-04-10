using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using ArcadeDotnet.Models.Workers;

namespace ArcadeDotnet.Tests.Models.Workers;

public class WorkerResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new WorkerResponse
        {
            ID = "id",
            Binding = new() { ID = "id", Type = Type.Static },
            Enabled = true,
            Http = new()
            {
                Retry = 0,
                Secret = new()
                {
                    Binding = SecretBinding.Static,
                    Editable = true,
                    Exists = true,
                    Value = "value",
                },
                Timeout = 0,
                Uri = "uri",
            },
            Managed = true,
            Mcp = new()
            {
                ExternalID = "external_id",
                Headers = new Dictionary<string, string>() { { "foo", "string" } },
                Oauth2 = new()
                {
                    AuthorizationUrl = "authorization_url",
                    ClientID = "client_id",
                    ClientSecret = new()
                    {
                        Binding = ClientSecretBinding.Static,
                        Editable = true,
                        Exists = true,
                        Value = "value",
                    },
                    ExternalID = "external_id",
                    RedirectUri = "redirect_uri",
                    SupportedScopes = ["string"],
                },
                RedirectUri = "redirect_uri",
                Retry = 0,
                Secrets = new Dictionary<string, SecretsItem>()
                {
                    {
                        "foo",
                        new()
                        {
                            Binding = SecretsItemBinding.Static,
                            Editable = true,
                            Exists = true,
                            Value = "value",
                        }
                    },
                },
                Timeout = 0,
                Uri = "uri",
            },
            Requirements = new()
            {
                Authorization = new()
                {
                    Met = true,
                    Oauth2 = new() { Met = true },
                },
                Met = true,
            },
            Type = WorkerResponseType.Http,
        };

        string expectedID = "id";
        Binding expectedBinding = new() { ID = "id", Type = Type.Static };
        bool expectedEnabled = true;
        WorkerResponseHttp expectedHttp = new()
        {
            Retry = 0,
            Secret = new()
            {
                Binding = SecretBinding.Static,
                Editable = true,
                Exists = true,
                Value = "value",
            },
            Timeout = 0,
            Uri = "uri",
        };
        bool expectedManaged = true;
        WorkerResponseMcp expectedMcp = new()
        {
            ExternalID = "external_id",
            Headers = new Dictionary<string, string>() { { "foo", "string" } },
            Oauth2 = new()
            {
                AuthorizationUrl = "authorization_url",
                ClientID = "client_id",
                ClientSecret = new()
                {
                    Binding = ClientSecretBinding.Static,
                    Editable = true,
                    Exists = true,
                    Value = "value",
                },
                ExternalID = "external_id",
                RedirectUri = "redirect_uri",
                SupportedScopes = ["string"],
            },
            RedirectUri = "redirect_uri",
            Retry = 0,
            Secrets = new Dictionary<string, SecretsItem>()
            {
                {
                    "foo",
                    new()
                    {
                        Binding = SecretsItemBinding.Static,
                        Editable = true,
                        Exists = true,
                        Value = "value",
                    }
                },
            },
            Timeout = 0,
            Uri = "uri",
        };
        Requirements expectedRequirements = new()
        {
            Authorization = new()
            {
                Met = true,
                Oauth2 = new() { Met = true },
            },
            Met = true,
        };
        ApiEnum<string, WorkerResponseType> expectedType = WorkerResponseType.Http;

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedBinding, model.Binding);
        Assert.Equal(expectedEnabled, model.Enabled);
        Assert.Equal(expectedHttp, model.Http);
        Assert.Equal(expectedManaged, model.Managed);
        Assert.Equal(expectedMcp, model.Mcp);
        Assert.Equal(expectedRequirements, model.Requirements);
        Assert.Equal(expectedType, model.Type);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new WorkerResponse
        {
            ID = "id",
            Binding = new() { ID = "id", Type = Type.Static },
            Enabled = true,
            Http = new()
            {
                Retry = 0,
                Secret = new()
                {
                    Binding = SecretBinding.Static,
                    Editable = true,
                    Exists = true,
                    Value = "value",
                },
                Timeout = 0,
                Uri = "uri",
            },
            Managed = true,
            Mcp = new()
            {
                ExternalID = "external_id",
                Headers = new Dictionary<string, string>() { { "foo", "string" } },
                Oauth2 = new()
                {
                    AuthorizationUrl = "authorization_url",
                    ClientID = "client_id",
                    ClientSecret = new()
                    {
                        Binding = ClientSecretBinding.Static,
                        Editable = true,
                        Exists = true,
                        Value = "value",
                    },
                    ExternalID = "external_id",
                    RedirectUri = "redirect_uri",
                    SupportedScopes = ["string"],
                },
                RedirectUri = "redirect_uri",
                Retry = 0,
                Secrets = new Dictionary<string, SecretsItem>()
                {
                    {
                        "foo",
                        new()
                        {
                            Binding = SecretsItemBinding.Static,
                            Editable = true,
                            Exists = true,
                            Value = "value",
                        }
                    },
                },
                Timeout = 0,
                Uri = "uri",
            },
            Requirements = new()
            {
                Authorization = new()
                {
                    Met = true,
                    Oauth2 = new() { Met = true },
                },
                Met = true,
            },
            Type = WorkerResponseType.Http,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<WorkerResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new WorkerResponse
        {
            ID = "id",
            Binding = new() { ID = "id", Type = Type.Static },
            Enabled = true,
            Http = new()
            {
                Retry = 0,
                Secret = new()
                {
                    Binding = SecretBinding.Static,
                    Editable = true,
                    Exists = true,
                    Value = "value",
                },
                Timeout = 0,
                Uri = "uri",
            },
            Managed = true,
            Mcp = new()
            {
                ExternalID = "external_id",
                Headers = new Dictionary<string, string>() { { "foo", "string" } },
                Oauth2 = new()
                {
                    AuthorizationUrl = "authorization_url",
                    ClientID = "client_id",
                    ClientSecret = new()
                    {
                        Binding = ClientSecretBinding.Static,
                        Editable = true,
                        Exists = true,
                        Value = "value",
                    },
                    ExternalID = "external_id",
                    RedirectUri = "redirect_uri",
                    SupportedScopes = ["string"],
                },
                RedirectUri = "redirect_uri",
                Retry = 0,
                Secrets = new Dictionary<string, SecretsItem>()
                {
                    {
                        "foo",
                        new()
                        {
                            Binding = SecretsItemBinding.Static,
                            Editable = true,
                            Exists = true,
                            Value = "value",
                        }
                    },
                },
                Timeout = 0,
                Uri = "uri",
            },
            Requirements = new()
            {
                Authorization = new()
                {
                    Met = true,
                    Oauth2 = new() { Met = true },
                },
                Met = true,
            },
            Type = WorkerResponseType.Http,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<WorkerResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "id";
        Binding expectedBinding = new() { ID = "id", Type = Type.Static };
        bool expectedEnabled = true;
        WorkerResponseHttp expectedHttp = new()
        {
            Retry = 0,
            Secret = new()
            {
                Binding = SecretBinding.Static,
                Editable = true,
                Exists = true,
                Value = "value",
            },
            Timeout = 0,
            Uri = "uri",
        };
        bool expectedManaged = true;
        WorkerResponseMcp expectedMcp = new()
        {
            ExternalID = "external_id",
            Headers = new Dictionary<string, string>() { { "foo", "string" } },
            Oauth2 = new()
            {
                AuthorizationUrl = "authorization_url",
                ClientID = "client_id",
                ClientSecret = new()
                {
                    Binding = ClientSecretBinding.Static,
                    Editable = true,
                    Exists = true,
                    Value = "value",
                },
                ExternalID = "external_id",
                RedirectUri = "redirect_uri",
                SupportedScopes = ["string"],
            },
            RedirectUri = "redirect_uri",
            Retry = 0,
            Secrets = new Dictionary<string, SecretsItem>()
            {
                {
                    "foo",
                    new()
                    {
                        Binding = SecretsItemBinding.Static,
                        Editable = true,
                        Exists = true,
                        Value = "value",
                    }
                },
            },
            Timeout = 0,
            Uri = "uri",
        };
        Requirements expectedRequirements = new()
        {
            Authorization = new()
            {
                Met = true,
                Oauth2 = new() { Met = true },
            },
            Met = true,
        };
        ApiEnum<string, WorkerResponseType> expectedType = WorkerResponseType.Http;

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedBinding, deserialized.Binding);
        Assert.Equal(expectedEnabled, deserialized.Enabled);
        Assert.Equal(expectedHttp, deserialized.Http);
        Assert.Equal(expectedManaged, deserialized.Managed);
        Assert.Equal(expectedMcp, deserialized.Mcp);
        Assert.Equal(expectedRequirements, deserialized.Requirements);
        Assert.Equal(expectedType, deserialized.Type);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new WorkerResponse
        {
            ID = "id",
            Binding = new() { ID = "id", Type = Type.Static },
            Enabled = true,
            Http = new()
            {
                Retry = 0,
                Secret = new()
                {
                    Binding = SecretBinding.Static,
                    Editable = true,
                    Exists = true,
                    Value = "value",
                },
                Timeout = 0,
                Uri = "uri",
            },
            Managed = true,
            Mcp = new()
            {
                ExternalID = "external_id",
                Headers = new Dictionary<string, string>() { { "foo", "string" } },
                Oauth2 = new()
                {
                    AuthorizationUrl = "authorization_url",
                    ClientID = "client_id",
                    ClientSecret = new()
                    {
                        Binding = ClientSecretBinding.Static,
                        Editable = true,
                        Exists = true,
                        Value = "value",
                    },
                    ExternalID = "external_id",
                    RedirectUri = "redirect_uri",
                    SupportedScopes = ["string"],
                },
                RedirectUri = "redirect_uri",
                Retry = 0,
                Secrets = new Dictionary<string, SecretsItem>()
                {
                    {
                        "foo",
                        new()
                        {
                            Binding = SecretsItemBinding.Static,
                            Editable = true,
                            Exists = true,
                            Value = "value",
                        }
                    },
                },
                Timeout = 0,
                Uri = "uri",
            },
            Requirements = new()
            {
                Authorization = new()
                {
                    Met = true,
                    Oauth2 = new() { Met = true },
                },
                Met = true,
            },
            Type = WorkerResponseType.Http,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new WorkerResponse { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Binding);
        Assert.False(model.RawData.ContainsKey("binding"));
        Assert.Null(model.Enabled);
        Assert.False(model.RawData.ContainsKey("enabled"));
        Assert.Null(model.Http);
        Assert.False(model.RawData.ContainsKey("http"));
        Assert.Null(model.Managed);
        Assert.False(model.RawData.ContainsKey("managed"));
        Assert.Null(model.Mcp);
        Assert.False(model.RawData.ContainsKey("mcp"));
        Assert.Null(model.Requirements);
        Assert.False(model.RawData.ContainsKey("requirements"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new WorkerResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new WorkerResponse
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Binding = null,
            Enabled = null,
            Http = null,
            Managed = null,
            Mcp = null,
            Requirements = null,
            Type = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Binding);
        Assert.False(model.RawData.ContainsKey("binding"));
        Assert.Null(model.Enabled);
        Assert.False(model.RawData.ContainsKey("enabled"));
        Assert.Null(model.Http);
        Assert.False(model.RawData.ContainsKey("http"));
        Assert.Null(model.Managed);
        Assert.False(model.RawData.ContainsKey("managed"));
        Assert.Null(model.Mcp);
        Assert.False(model.RawData.ContainsKey("mcp"));
        Assert.Null(model.Requirements);
        Assert.False(model.RawData.ContainsKey("requirements"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new WorkerResponse
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Binding = null,
            Enabled = null,
            Http = null,
            Managed = null,
            Mcp = null,
            Requirements = null,
            Type = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new WorkerResponse
        {
            ID = "id",
            Binding = new() { ID = "id", Type = Type.Static },
            Enabled = true,
            Http = new()
            {
                Retry = 0,
                Secret = new()
                {
                    Binding = SecretBinding.Static,
                    Editable = true,
                    Exists = true,
                    Value = "value",
                },
                Timeout = 0,
                Uri = "uri",
            },
            Managed = true,
            Mcp = new()
            {
                ExternalID = "external_id",
                Headers = new Dictionary<string, string>() { { "foo", "string" } },
                Oauth2 = new()
                {
                    AuthorizationUrl = "authorization_url",
                    ClientID = "client_id",
                    ClientSecret = new()
                    {
                        Binding = ClientSecretBinding.Static,
                        Editable = true,
                        Exists = true,
                        Value = "value",
                    },
                    ExternalID = "external_id",
                    RedirectUri = "redirect_uri",
                    SupportedScopes = ["string"],
                },
                RedirectUri = "redirect_uri",
                Retry = 0,
                Secrets = new Dictionary<string, SecretsItem>()
                {
                    {
                        "foo",
                        new()
                        {
                            Binding = SecretsItemBinding.Static,
                            Editable = true,
                            Exists = true,
                            Value = "value",
                        }
                    },
                },
                Timeout = 0,
                Uri = "uri",
            },
            Requirements = new()
            {
                Authorization = new()
                {
                    Met = true,
                    Oauth2 = new() { Met = true },
                },
                Met = true,
            },
            Type = WorkerResponseType.Http,
        };

        WorkerResponse copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class BindingTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Binding { ID = "id", Type = Type.Static };

        string expectedID = "id";
        ApiEnum<string, Type> expectedType = Type.Static;

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedType, model.Type);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Binding { ID = "id", Type = Type.Static };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Binding>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Binding { ID = "id", Type = Type.Static };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Binding>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "id";
        ApiEnum<string, Type> expectedType = Type.Static;

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedType, deserialized.Type);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Binding { ID = "id", Type = Type.Static };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Binding { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Binding { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Binding
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Type = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Binding
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Type = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Binding { ID = "id", Type = Type.Static };

        Binding copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class TypeTest : TestBase
{
    [Theory]
    [InlineData(Type.Static)]
    [InlineData(Type.Tenant)]
    [InlineData(Type.Project)]
    [InlineData(Type.Account)]
    public void Validation_Works(Type rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Type> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Type>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Type.Static)]
    [InlineData(Type.Tenant)]
    [InlineData(Type.Project)]
    [InlineData(Type.Account)]
    public void SerializationRoundtrip_Works(Type rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Type> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Type>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Type>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Type>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class WorkerResponseHttpTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new WorkerResponseHttp
        {
            Retry = 0,
            Secret = new()
            {
                Binding = SecretBinding.Static,
                Editable = true,
                Exists = true,
                Value = "value",
            },
            Timeout = 0,
            Uri = "uri",
        };

        long expectedRetry = 0;
        Secret expectedSecret = new()
        {
            Binding = SecretBinding.Static,
            Editable = true,
            Exists = true,
            Value = "value",
        };
        long expectedTimeout = 0;
        string expectedUri = "uri";

        Assert.Equal(expectedRetry, model.Retry);
        Assert.Equal(expectedSecret, model.Secret);
        Assert.Equal(expectedTimeout, model.Timeout);
        Assert.Equal(expectedUri, model.Uri);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new WorkerResponseHttp
        {
            Retry = 0,
            Secret = new()
            {
                Binding = SecretBinding.Static,
                Editable = true,
                Exists = true,
                Value = "value",
            },
            Timeout = 0,
            Uri = "uri",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<WorkerResponseHttp>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new WorkerResponseHttp
        {
            Retry = 0,
            Secret = new()
            {
                Binding = SecretBinding.Static,
                Editable = true,
                Exists = true,
                Value = "value",
            },
            Timeout = 0,
            Uri = "uri",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<WorkerResponseHttp>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        long expectedRetry = 0;
        Secret expectedSecret = new()
        {
            Binding = SecretBinding.Static,
            Editable = true,
            Exists = true,
            Value = "value",
        };
        long expectedTimeout = 0;
        string expectedUri = "uri";

        Assert.Equal(expectedRetry, deserialized.Retry);
        Assert.Equal(expectedSecret, deserialized.Secret);
        Assert.Equal(expectedTimeout, deserialized.Timeout);
        Assert.Equal(expectedUri, deserialized.Uri);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new WorkerResponseHttp
        {
            Retry = 0,
            Secret = new()
            {
                Binding = SecretBinding.Static,
                Editable = true,
                Exists = true,
                Value = "value",
            },
            Timeout = 0,
            Uri = "uri",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new WorkerResponseHttp { };

        Assert.Null(model.Retry);
        Assert.False(model.RawData.ContainsKey("retry"));
        Assert.Null(model.Secret);
        Assert.False(model.RawData.ContainsKey("secret"));
        Assert.Null(model.Timeout);
        Assert.False(model.RawData.ContainsKey("timeout"));
        Assert.Null(model.Uri);
        Assert.False(model.RawData.ContainsKey("uri"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new WorkerResponseHttp { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new WorkerResponseHttp
        {
            // Null should be interpreted as omitted for these properties
            Retry = null,
            Secret = null,
            Timeout = null,
            Uri = null,
        };

        Assert.Null(model.Retry);
        Assert.False(model.RawData.ContainsKey("retry"));
        Assert.Null(model.Secret);
        Assert.False(model.RawData.ContainsKey("secret"));
        Assert.Null(model.Timeout);
        Assert.False(model.RawData.ContainsKey("timeout"));
        Assert.Null(model.Uri);
        Assert.False(model.RawData.ContainsKey("uri"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new WorkerResponseHttp
        {
            // Null should be interpreted as omitted for these properties
            Retry = null,
            Secret = null,
            Timeout = null,
            Uri = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new WorkerResponseHttp
        {
            Retry = 0,
            Secret = new()
            {
                Binding = SecretBinding.Static,
                Editable = true,
                Exists = true,
                Value = "value",
            },
            Timeout = 0,
            Uri = "uri",
        };

        WorkerResponseHttp copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class SecretTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Secret
        {
            Binding = SecretBinding.Static,
            Editable = true,
            Exists = true,
            Value = "value",
        };

        ApiEnum<string, SecretBinding> expectedBinding = SecretBinding.Static;
        bool expectedEditable = true;
        bool expectedExists = true;
        string expectedValue = "value";

        Assert.Equal(expectedBinding, model.Binding);
        Assert.Equal(expectedEditable, model.Editable);
        Assert.Equal(expectedExists, model.Exists);
        Assert.Equal(expectedValue, model.Value);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Secret
        {
            Binding = SecretBinding.Static,
            Editable = true,
            Exists = true,
            Value = "value",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Secret>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Secret
        {
            Binding = SecretBinding.Static,
            Editable = true,
            Exists = true,
            Value = "value",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Secret>(element, ModelBase.SerializerOptions);
        Assert.NotNull(deserialized);

        ApiEnum<string, SecretBinding> expectedBinding = SecretBinding.Static;
        bool expectedEditable = true;
        bool expectedExists = true;
        string expectedValue = "value";

        Assert.Equal(expectedBinding, deserialized.Binding);
        Assert.Equal(expectedEditable, deserialized.Editable);
        Assert.Equal(expectedExists, deserialized.Exists);
        Assert.Equal(expectedValue, deserialized.Value);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Secret
        {
            Binding = SecretBinding.Static,
            Editable = true,
            Exists = true,
            Value = "value",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Secret { };

        Assert.Null(model.Binding);
        Assert.False(model.RawData.ContainsKey("binding"));
        Assert.Null(model.Editable);
        Assert.False(model.RawData.ContainsKey("editable"));
        Assert.Null(model.Exists);
        Assert.False(model.RawData.ContainsKey("exists"));
        Assert.Null(model.Value);
        Assert.False(model.RawData.ContainsKey("value"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Secret { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Secret
        {
            // Null should be interpreted as omitted for these properties
            Binding = null,
            Editable = null,
            Exists = null,
            Value = null,
        };

        Assert.Null(model.Binding);
        Assert.False(model.RawData.ContainsKey("binding"));
        Assert.Null(model.Editable);
        Assert.False(model.RawData.ContainsKey("editable"));
        Assert.Null(model.Exists);
        Assert.False(model.RawData.ContainsKey("exists"));
        Assert.Null(model.Value);
        Assert.False(model.RawData.ContainsKey("value"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Secret
        {
            // Null should be interpreted as omitted for these properties
            Binding = null,
            Editable = null,
            Exists = null,
            Value = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Secret
        {
            Binding = SecretBinding.Static,
            Editable = true,
            Exists = true,
            Value = "value",
        };

        Secret copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class SecretBindingTest : TestBase
{
    [Theory]
    [InlineData(SecretBinding.Static)]
    [InlineData(SecretBinding.Tenant)]
    [InlineData(SecretBinding.Project)]
    [InlineData(SecretBinding.Account)]
    public void Validation_Works(SecretBinding rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, SecretBinding> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, SecretBinding>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(SecretBinding.Static)]
    [InlineData(SecretBinding.Tenant)]
    [InlineData(SecretBinding.Project)]
    [InlineData(SecretBinding.Account)]
    public void SerializationRoundtrip_Works(SecretBinding rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, SecretBinding> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, SecretBinding>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, SecretBinding>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, SecretBinding>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class WorkerResponseMcpTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new WorkerResponseMcp
        {
            ExternalID = "external_id",
            Headers = new Dictionary<string, string>() { { "foo", "string" } },
            Oauth2 = new()
            {
                AuthorizationUrl = "authorization_url",
                ClientID = "client_id",
                ClientSecret = new()
                {
                    Binding = ClientSecretBinding.Static,
                    Editable = true,
                    Exists = true,
                    Value = "value",
                },
                ExternalID = "external_id",
                RedirectUri = "redirect_uri",
                SupportedScopes = ["string"],
            },
            RedirectUri = "redirect_uri",
            Retry = 0,
            Secrets = new Dictionary<string, SecretsItem>()
            {
                {
                    "foo",
                    new()
                    {
                        Binding = SecretsItemBinding.Static,
                        Editable = true,
                        Exists = true,
                        Value = "value",
                    }
                },
            },
            Timeout = 0,
            Uri = "uri",
        };

        string expectedExternalID = "external_id";
        Dictionary<string, string> expectedHeaders = new() { { "foo", "string" } };
        WorkerResponseMcpOauth2 expectedOauth2 = new()
        {
            AuthorizationUrl = "authorization_url",
            ClientID = "client_id",
            ClientSecret = new()
            {
                Binding = ClientSecretBinding.Static,
                Editable = true,
                Exists = true,
                Value = "value",
            },
            ExternalID = "external_id",
            RedirectUri = "redirect_uri",
            SupportedScopes = ["string"],
        };
        string expectedRedirectUri = "redirect_uri";
        long expectedRetry = 0;
        Dictionary<string, SecretsItem> expectedSecrets = new()
        {
            {
                "foo",
                new()
                {
                    Binding = SecretsItemBinding.Static,
                    Editable = true,
                    Exists = true,
                    Value = "value",
                }
            },
        };
        long expectedTimeout = 0;
        string expectedUri = "uri";

        Assert.Equal(expectedExternalID, model.ExternalID);
        Assert.NotNull(model.Headers);
        Assert.Equal(expectedHeaders.Count, model.Headers.Count);
        foreach (var item in expectedHeaders)
        {
            Assert.True(model.Headers.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.Headers[item.Key]);
        }
        Assert.Equal(expectedOauth2, model.Oauth2);
        Assert.Equal(expectedRedirectUri, model.RedirectUri);
        Assert.Equal(expectedRetry, model.Retry);
        Assert.NotNull(model.Secrets);
        Assert.Equal(expectedSecrets.Count, model.Secrets.Count);
        foreach (var item in expectedSecrets)
        {
            Assert.True(model.Secrets.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.Secrets[item.Key]);
        }
        Assert.Equal(expectedTimeout, model.Timeout);
        Assert.Equal(expectedUri, model.Uri);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new WorkerResponseMcp
        {
            ExternalID = "external_id",
            Headers = new Dictionary<string, string>() { { "foo", "string" } },
            Oauth2 = new()
            {
                AuthorizationUrl = "authorization_url",
                ClientID = "client_id",
                ClientSecret = new()
                {
                    Binding = ClientSecretBinding.Static,
                    Editable = true,
                    Exists = true,
                    Value = "value",
                },
                ExternalID = "external_id",
                RedirectUri = "redirect_uri",
                SupportedScopes = ["string"],
            },
            RedirectUri = "redirect_uri",
            Retry = 0,
            Secrets = new Dictionary<string, SecretsItem>()
            {
                {
                    "foo",
                    new()
                    {
                        Binding = SecretsItemBinding.Static,
                        Editable = true,
                        Exists = true,
                        Value = "value",
                    }
                },
            },
            Timeout = 0,
            Uri = "uri",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<WorkerResponseMcp>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new WorkerResponseMcp
        {
            ExternalID = "external_id",
            Headers = new Dictionary<string, string>() { { "foo", "string" } },
            Oauth2 = new()
            {
                AuthorizationUrl = "authorization_url",
                ClientID = "client_id",
                ClientSecret = new()
                {
                    Binding = ClientSecretBinding.Static,
                    Editable = true,
                    Exists = true,
                    Value = "value",
                },
                ExternalID = "external_id",
                RedirectUri = "redirect_uri",
                SupportedScopes = ["string"],
            },
            RedirectUri = "redirect_uri",
            Retry = 0,
            Secrets = new Dictionary<string, SecretsItem>()
            {
                {
                    "foo",
                    new()
                    {
                        Binding = SecretsItemBinding.Static,
                        Editable = true,
                        Exists = true,
                        Value = "value",
                    }
                },
            },
            Timeout = 0,
            Uri = "uri",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<WorkerResponseMcp>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedExternalID = "external_id";
        Dictionary<string, string> expectedHeaders = new() { { "foo", "string" } };
        WorkerResponseMcpOauth2 expectedOauth2 = new()
        {
            AuthorizationUrl = "authorization_url",
            ClientID = "client_id",
            ClientSecret = new()
            {
                Binding = ClientSecretBinding.Static,
                Editable = true,
                Exists = true,
                Value = "value",
            },
            ExternalID = "external_id",
            RedirectUri = "redirect_uri",
            SupportedScopes = ["string"],
        };
        string expectedRedirectUri = "redirect_uri";
        long expectedRetry = 0;
        Dictionary<string, SecretsItem> expectedSecrets = new()
        {
            {
                "foo",
                new()
                {
                    Binding = SecretsItemBinding.Static,
                    Editable = true,
                    Exists = true,
                    Value = "value",
                }
            },
        };
        long expectedTimeout = 0;
        string expectedUri = "uri";

        Assert.Equal(expectedExternalID, deserialized.ExternalID);
        Assert.NotNull(deserialized.Headers);
        Assert.Equal(expectedHeaders.Count, deserialized.Headers.Count);
        foreach (var item in expectedHeaders)
        {
            Assert.True(deserialized.Headers.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.Headers[item.Key]);
        }
        Assert.Equal(expectedOauth2, deserialized.Oauth2);
        Assert.Equal(expectedRedirectUri, deserialized.RedirectUri);
        Assert.Equal(expectedRetry, deserialized.Retry);
        Assert.NotNull(deserialized.Secrets);
        Assert.Equal(expectedSecrets.Count, deserialized.Secrets.Count);
        foreach (var item in expectedSecrets)
        {
            Assert.True(deserialized.Secrets.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.Secrets[item.Key]);
        }
        Assert.Equal(expectedTimeout, deserialized.Timeout);
        Assert.Equal(expectedUri, deserialized.Uri);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new WorkerResponseMcp
        {
            ExternalID = "external_id",
            Headers = new Dictionary<string, string>() { { "foo", "string" } },
            Oauth2 = new()
            {
                AuthorizationUrl = "authorization_url",
                ClientID = "client_id",
                ClientSecret = new()
                {
                    Binding = ClientSecretBinding.Static,
                    Editable = true,
                    Exists = true,
                    Value = "value",
                },
                ExternalID = "external_id",
                RedirectUri = "redirect_uri",
                SupportedScopes = ["string"],
            },
            RedirectUri = "redirect_uri",
            Retry = 0,
            Secrets = new Dictionary<string, SecretsItem>()
            {
                {
                    "foo",
                    new()
                    {
                        Binding = SecretsItemBinding.Static,
                        Editable = true,
                        Exists = true,
                        Value = "value",
                    }
                },
            },
            Timeout = 0,
            Uri = "uri",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new WorkerResponseMcp { };

        Assert.Null(model.ExternalID);
        Assert.False(model.RawData.ContainsKey("external_id"));
        Assert.Null(model.Headers);
        Assert.False(model.RawData.ContainsKey("headers"));
        Assert.Null(model.Oauth2);
        Assert.False(model.RawData.ContainsKey("oauth2"));
        Assert.Null(model.RedirectUri);
        Assert.False(model.RawData.ContainsKey("redirect_uri"));
        Assert.Null(model.Retry);
        Assert.False(model.RawData.ContainsKey("retry"));
        Assert.Null(model.Secrets);
        Assert.False(model.RawData.ContainsKey("secrets"));
        Assert.Null(model.Timeout);
        Assert.False(model.RawData.ContainsKey("timeout"));
        Assert.Null(model.Uri);
        Assert.False(model.RawData.ContainsKey("uri"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new WorkerResponseMcp { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new WorkerResponseMcp
        {
            // Null should be interpreted as omitted for these properties
            ExternalID = null,
            Headers = null,
            Oauth2 = null,
            RedirectUri = null,
            Retry = null,
            Secrets = null,
            Timeout = null,
            Uri = null,
        };

        Assert.Null(model.ExternalID);
        Assert.False(model.RawData.ContainsKey("external_id"));
        Assert.Null(model.Headers);
        Assert.False(model.RawData.ContainsKey("headers"));
        Assert.Null(model.Oauth2);
        Assert.False(model.RawData.ContainsKey("oauth2"));
        Assert.Null(model.RedirectUri);
        Assert.False(model.RawData.ContainsKey("redirect_uri"));
        Assert.Null(model.Retry);
        Assert.False(model.RawData.ContainsKey("retry"));
        Assert.Null(model.Secrets);
        Assert.False(model.RawData.ContainsKey("secrets"));
        Assert.Null(model.Timeout);
        Assert.False(model.RawData.ContainsKey("timeout"));
        Assert.Null(model.Uri);
        Assert.False(model.RawData.ContainsKey("uri"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new WorkerResponseMcp
        {
            // Null should be interpreted as omitted for these properties
            ExternalID = null,
            Headers = null,
            Oauth2 = null,
            RedirectUri = null,
            Retry = null,
            Secrets = null,
            Timeout = null,
            Uri = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new WorkerResponseMcp
        {
            ExternalID = "external_id",
            Headers = new Dictionary<string, string>() { { "foo", "string" } },
            Oauth2 = new()
            {
                AuthorizationUrl = "authorization_url",
                ClientID = "client_id",
                ClientSecret = new()
                {
                    Binding = ClientSecretBinding.Static,
                    Editable = true,
                    Exists = true,
                    Value = "value",
                },
                ExternalID = "external_id",
                RedirectUri = "redirect_uri",
                SupportedScopes = ["string"],
            },
            RedirectUri = "redirect_uri",
            Retry = 0,
            Secrets = new Dictionary<string, SecretsItem>()
            {
                {
                    "foo",
                    new()
                    {
                        Binding = SecretsItemBinding.Static,
                        Editable = true,
                        Exists = true,
                        Value = "value",
                    }
                },
            },
            Timeout = 0,
            Uri = "uri",
        };

        WorkerResponseMcp copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class WorkerResponseMcpOauth2Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new WorkerResponseMcpOauth2
        {
            AuthorizationUrl = "authorization_url",
            ClientID = "client_id",
            ClientSecret = new()
            {
                Binding = ClientSecretBinding.Static,
                Editable = true,
                Exists = true,
                Value = "value",
            },
            ExternalID = "external_id",
            RedirectUri = "redirect_uri",
            SupportedScopes = ["string"],
        };

        string expectedAuthorizationUrl = "authorization_url";
        string expectedClientID = "client_id";
        ClientSecret expectedClientSecret = new()
        {
            Binding = ClientSecretBinding.Static,
            Editable = true,
            Exists = true,
            Value = "value",
        };
        string expectedExternalID = "external_id";
        string expectedRedirectUri = "redirect_uri";
        List<string> expectedSupportedScopes = ["string"];

        Assert.Equal(expectedAuthorizationUrl, model.AuthorizationUrl);
        Assert.Equal(expectedClientID, model.ClientID);
        Assert.Equal(expectedClientSecret, model.ClientSecret);
        Assert.Equal(expectedExternalID, model.ExternalID);
        Assert.Equal(expectedRedirectUri, model.RedirectUri);
        Assert.NotNull(model.SupportedScopes);
        Assert.Equal(expectedSupportedScopes.Count, model.SupportedScopes.Count);
        for (int i = 0; i < expectedSupportedScopes.Count; i++)
        {
            Assert.Equal(expectedSupportedScopes[i], model.SupportedScopes[i]);
        }
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new WorkerResponseMcpOauth2
        {
            AuthorizationUrl = "authorization_url",
            ClientID = "client_id",
            ClientSecret = new()
            {
                Binding = ClientSecretBinding.Static,
                Editable = true,
                Exists = true,
                Value = "value",
            },
            ExternalID = "external_id",
            RedirectUri = "redirect_uri",
            SupportedScopes = ["string"],
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<WorkerResponseMcpOauth2>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new WorkerResponseMcpOauth2
        {
            AuthorizationUrl = "authorization_url",
            ClientID = "client_id",
            ClientSecret = new()
            {
                Binding = ClientSecretBinding.Static,
                Editable = true,
                Exists = true,
                Value = "value",
            },
            ExternalID = "external_id",
            RedirectUri = "redirect_uri",
            SupportedScopes = ["string"],
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<WorkerResponseMcpOauth2>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedAuthorizationUrl = "authorization_url";
        string expectedClientID = "client_id";
        ClientSecret expectedClientSecret = new()
        {
            Binding = ClientSecretBinding.Static,
            Editable = true,
            Exists = true,
            Value = "value",
        };
        string expectedExternalID = "external_id";
        string expectedRedirectUri = "redirect_uri";
        List<string> expectedSupportedScopes = ["string"];

        Assert.Equal(expectedAuthorizationUrl, deserialized.AuthorizationUrl);
        Assert.Equal(expectedClientID, deserialized.ClientID);
        Assert.Equal(expectedClientSecret, deserialized.ClientSecret);
        Assert.Equal(expectedExternalID, deserialized.ExternalID);
        Assert.Equal(expectedRedirectUri, deserialized.RedirectUri);
        Assert.NotNull(deserialized.SupportedScopes);
        Assert.Equal(expectedSupportedScopes.Count, deserialized.SupportedScopes.Count);
        for (int i = 0; i < expectedSupportedScopes.Count; i++)
        {
            Assert.Equal(expectedSupportedScopes[i], deserialized.SupportedScopes[i]);
        }
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new WorkerResponseMcpOauth2
        {
            AuthorizationUrl = "authorization_url",
            ClientID = "client_id",
            ClientSecret = new()
            {
                Binding = ClientSecretBinding.Static,
                Editable = true,
                Exists = true,
                Value = "value",
            },
            ExternalID = "external_id",
            RedirectUri = "redirect_uri",
            SupportedScopes = ["string"],
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new WorkerResponseMcpOauth2 { };

        Assert.Null(model.AuthorizationUrl);
        Assert.False(model.RawData.ContainsKey("authorization_url"));
        Assert.Null(model.ClientID);
        Assert.False(model.RawData.ContainsKey("client_id"));
        Assert.Null(model.ClientSecret);
        Assert.False(model.RawData.ContainsKey("client_secret"));
        Assert.Null(model.ExternalID);
        Assert.False(model.RawData.ContainsKey("external_id"));
        Assert.Null(model.RedirectUri);
        Assert.False(model.RawData.ContainsKey("redirect_uri"));
        Assert.Null(model.SupportedScopes);
        Assert.False(model.RawData.ContainsKey("supported_scopes"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new WorkerResponseMcpOauth2 { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new WorkerResponseMcpOauth2
        {
            // Null should be interpreted as omitted for these properties
            AuthorizationUrl = null,
            ClientID = null,
            ClientSecret = null,
            ExternalID = null,
            RedirectUri = null,
            SupportedScopes = null,
        };

        Assert.Null(model.AuthorizationUrl);
        Assert.False(model.RawData.ContainsKey("authorization_url"));
        Assert.Null(model.ClientID);
        Assert.False(model.RawData.ContainsKey("client_id"));
        Assert.Null(model.ClientSecret);
        Assert.False(model.RawData.ContainsKey("client_secret"));
        Assert.Null(model.ExternalID);
        Assert.False(model.RawData.ContainsKey("external_id"));
        Assert.Null(model.RedirectUri);
        Assert.False(model.RawData.ContainsKey("redirect_uri"));
        Assert.Null(model.SupportedScopes);
        Assert.False(model.RawData.ContainsKey("supported_scopes"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new WorkerResponseMcpOauth2
        {
            // Null should be interpreted as omitted for these properties
            AuthorizationUrl = null,
            ClientID = null,
            ClientSecret = null,
            ExternalID = null,
            RedirectUri = null,
            SupportedScopes = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new WorkerResponseMcpOauth2
        {
            AuthorizationUrl = "authorization_url",
            ClientID = "client_id",
            ClientSecret = new()
            {
                Binding = ClientSecretBinding.Static,
                Editable = true,
                Exists = true,
                Value = "value",
            },
            ExternalID = "external_id",
            RedirectUri = "redirect_uri",
            SupportedScopes = ["string"],
        };

        WorkerResponseMcpOauth2 copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class ClientSecretTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ClientSecret
        {
            Binding = ClientSecretBinding.Static,
            Editable = true,
            Exists = true,
            Value = "value",
        };

        ApiEnum<string, ClientSecretBinding> expectedBinding = ClientSecretBinding.Static;
        bool expectedEditable = true;
        bool expectedExists = true;
        string expectedValue = "value";

        Assert.Equal(expectedBinding, model.Binding);
        Assert.Equal(expectedEditable, model.Editable);
        Assert.Equal(expectedExists, model.Exists);
        Assert.Equal(expectedValue, model.Value);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new ClientSecret
        {
            Binding = ClientSecretBinding.Static,
            Editable = true,
            Exists = true,
            Value = "value",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ClientSecret>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ClientSecret
        {
            Binding = ClientSecretBinding.Static,
            Editable = true,
            Exists = true,
            Value = "value",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ClientSecret>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        ApiEnum<string, ClientSecretBinding> expectedBinding = ClientSecretBinding.Static;
        bool expectedEditable = true;
        bool expectedExists = true;
        string expectedValue = "value";

        Assert.Equal(expectedBinding, deserialized.Binding);
        Assert.Equal(expectedEditable, deserialized.Editable);
        Assert.Equal(expectedExists, deserialized.Exists);
        Assert.Equal(expectedValue, deserialized.Value);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new ClientSecret
        {
            Binding = ClientSecretBinding.Static,
            Editable = true,
            Exists = true,
            Value = "value",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new ClientSecret { };

        Assert.Null(model.Binding);
        Assert.False(model.RawData.ContainsKey("binding"));
        Assert.Null(model.Editable);
        Assert.False(model.RawData.ContainsKey("editable"));
        Assert.Null(model.Exists);
        Assert.False(model.RawData.ContainsKey("exists"));
        Assert.Null(model.Value);
        Assert.False(model.RawData.ContainsKey("value"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new ClientSecret { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new ClientSecret
        {
            // Null should be interpreted as omitted for these properties
            Binding = null,
            Editable = null,
            Exists = null,
            Value = null,
        };

        Assert.Null(model.Binding);
        Assert.False(model.RawData.ContainsKey("binding"));
        Assert.Null(model.Editable);
        Assert.False(model.RawData.ContainsKey("editable"));
        Assert.Null(model.Exists);
        Assert.False(model.RawData.ContainsKey("exists"));
        Assert.Null(model.Value);
        Assert.False(model.RawData.ContainsKey("value"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new ClientSecret
        {
            // Null should be interpreted as omitted for these properties
            Binding = null,
            Editable = null,
            Exists = null,
            Value = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new ClientSecret
        {
            Binding = ClientSecretBinding.Static,
            Editable = true,
            Exists = true,
            Value = "value",
        };

        ClientSecret copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class ClientSecretBindingTest : TestBase
{
    [Theory]
    [InlineData(ClientSecretBinding.Static)]
    [InlineData(ClientSecretBinding.Tenant)]
    [InlineData(ClientSecretBinding.Project)]
    [InlineData(ClientSecretBinding.Account)]
    public void Validation_Works(ClientSecretBinding rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ClientSecretBinding> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, ClientSecretBinding>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(ClientSecretBinding.Static)]
    [InlineData(ClientSecretBinding.Tenant)]
    [InlineData(ClientSecretBinding.Project)]
    [InlineData(ClientSecretBinding.Account)]
    public void SerializationRoundtrip_Works(ClientSecretBinding rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ClientSecretBinding> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, ClientSecretBinding>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, ClientSecretBinding>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, ClientSecretBinding>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class SecretsItemTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new SecretsItem
        {
            Binding = SecretsItemBinding.Static,
            Editable = true,
            Exists = true,
            Value = "value",
        };

        ApiEnum<string, SecretsItemBinding> expectedBinding = SecretsItemBinding.Static;
        bool expectedEditable = true;
        bool expectedExists = true;
        string expectedValue = "value";

        Assert.Equal(expectedBinding, model.Binding);
        Assert.Equal(expectedEditable, model.Editable);
        Assert.Equal(expectedExists, model.Exists);
        Assert.Equal(expectedValue, model.Value);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new SecretsItem
        {
            Binding = SecretsItemBinding.Static,
            Editable = true,
            Exists = true,
            Value = "value",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<SecretsItem>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new SecretsItem
        {
            Binding = SecretsItemBinding.Static,
            Editable = true,
            Exists = true,
            Value = "value",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<SecretsItem>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        ApiEnum<string, SecretsItemBinding> expectedBinding = SecretsItemBinding.Static;
        bool expectedEditable = true;
        bool expectedExists = true;
        string expectedValue = "value";

        Assert.Equal(expectedBinding, deserialized.Binding);
        Assert.Equal(expectedEditable, deserialized.Editable);
        Assert.Equal(expectedExists, deserialized.Exists);
        Assert.Equal(expectedValue, deserialized.Value);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new SecretsItem
        {
            Binding = SecretsItemBinding.Static,
            Editable = true,
            Exists = true,
            Value = "value",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new SecretsItem { };

        Assert.Null(model.Binding);
        Assert.False(model.RawData.ContainsKey("binding"));
        Assert.Null(model.Editable);
        Assert.False(model.RawData.ContainsKey("editable"));
        Assert.Null(model.Exists);
        Assert.False(model.RawData.ContainsKey("exists"));
        Assert.Null(model.Value);
        Assert.False(model.RawData.ContainsKey("value"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new SecretsItem { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new SecretsItem
        {
            // Null should be interpreted as omitted for these properties
            Binding = null,
            Editable = null,
            Exists = null,
            Value = null,
        };

        Assert.Null(model.Binding);
        Assert.False(model.RawData.ContainsKey("binding"));
        Assert.Null(model.Editable);
        Assert.False(model.RawData.ContainsKey("editable"));
        Assert.Null(model.Exists);
        Assert.False(model.RawData.ContainsKey("exists"));
        Assert.Null(model.Value);
        Assert.False(model.RawData.ContainsKey("value"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new SecretsItem
        {
            // Null should be interpreted as omitted for these properties
            Binding = null,
            Editable = null,
            Exists = null,
            Value = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new SecretsItem
        {
            Binding = SecretsItemBinding.Static,
            Editable = true,
            Exists = true,
            Value = "value",
        };

        SecretsItem copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class SecretsItemBindingTest : TestBase
{
    [Theory]
    [InlineData(SecretsItemBinding.Static)]
    [InlineData(SecretsItemBinding.Tenant)]
    [InlineData(SecretsItemBinding.Project)]
    [InlineData(SecretsItemBinding.Account)]
    public void Validation_Works(SecretsItemBinding rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, SecretsItemBinding> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, SecretsItemBinding>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(SecretsItemBinding.Static)]
    [InlineData(SecretsItemBinding.Tenant)]
    [InlineData(SecretsItemBinding.Project)]
    [InlineData(SecretsItemBinding.Account)]
    public void SerializationRoundtrip_Works(SecretsItemBinding rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, SecretsItemBinding> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, SecretsItemBinding>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, SecretsItemBinding>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, SecretsItemBinding>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
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
                Met = true,
                Oauth2 = new() { Met = true },
            },
            Met = true,
        };

        Authorization expectedAuthorization = new()
        {
            Met = true,
            Oauth2 = new() { Met = true },
        };
        bool expectedMet = true;

        Assert.Equal(expectedAuthorization, model.Authorization);
        Assert.Equal(expectedMet, model.Met);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Requirements
        {
            Authorization = new()
            {
                Met = true,
                Oauth2 = new() { Met = true },
            },
            Met = true,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Requirements>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Requirements
        {
            Authorization = new()
            {
                Met = true,
                Oauth2 = new() { Met = true },
            },
            Met = true,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Requirements>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        Authorization expectedAuthorization = new()
        {
            Met = true,
            Oauth2 = new() { Met = true },
        };
        bool expectedMet = true;

        Assert.Equal(expectedAuthorization, deserialized.Authorization);
        Assert.Equal(expectedMet, deserialized.Met);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Requirements
        {
            Authorization = new()
            {
                Met = true,
                Oauth2 = new() { Met = true },
            },
            Met = true,
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
        };

        Assert.Null(model.Authorization);
        Assert.False(model.RawData.ContainsKey("authorization"));
        Assert.Null(model.Met);
        Assert.False(model.RawData.ContainsKey("met"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Requirements
        {
            // Null should be interpreted as omitted for these properties
            Authorization = null,
            Met = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Requirements
        {
            Authorization = new()
            {
                Met = true,
                Oauth2 = new() { Met = true },
            },
            Met = true,
        };

        Requirements copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class AuthorizationTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Authorization
        {
            Met = true,
            Oauth2 = new() { Met = true },
        };

        bool expectedMet = true;
        AuthorizationOauth2 expectedOauth2 = new() { Met = true };

        Assert.Equal(expectedMet, model.Met);
        Assert.Equal(expectedOauth2, model.Oauth2);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Authorization
        {
            Met = true,
            Oauth2 = new() { Met = true },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Authorization>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Authorization
        {
            Met = true,
            Oauth2 = new() { Met = true },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Authorization>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        bool expectedMet = true;
        AuthorizationOauth2 expectedOauth2 = new() { Met = true };

        Assert.Equal(expectedMet, deserialized.Met);
        Assert.Equal(expectedOauth2, deserialized.Oauth2);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Authorization
        {
            Met = true,
            Oauth2 = new() { Met = true },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Authorization { };

        Assert.Null(model.Met);
        Assert.False(model.RawData.ContainsKey("met"));
        Assert.Null(model.Oauth2);
        Assert.False(model.RawData.ContainsKey("oauth2"));
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
            Met = null,
            Oauth2 = null,
        };

        Assert.Null(model.Met);
        Assert.False(model.RawData.ContainsKey("met"));
        Assert.Null(model.Oauth2);
        Assert.False(model.RawData.ContainsKey("oauth2"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Authorization
        {
            // Null should be interpreted as omitted for these properties
            Met = null,
            Oauth2 = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Authorization
        {
            Met = true,
            Oauth2 = new() { Met = true },
        };

        Authorization copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class AuthorizationOauth2Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthorizationOauth2 { Met = true };

        bool expectedMet = true;

        Assert.Equal(expectedMet, model.Met);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AuthorizationOauth2 { Met = true };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AuthorizationOauth2>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AuthorizationOauth2 { Met = true };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AuthorizationOauth2>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        bool expectedMet = true;

        Assert.Equal(expectedMet, deserialized.Met);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AuthorizationOauth2 { Met = true };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthorizationOauth2 { };

        Assert.Null(model.Met);
        Assert.False(model.RawData.ContainsKey("met"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AuthorizationOauth2 { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthorizationOauth2
        {
            // Null should be interpreted as omitted for these properties
            Met = null,
        };

        Assert.Null(model.Met);
        Assert.False(model.RawData.ContainsKey("met"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new AuthorizationOauth2
        {
            // Null should be interpreted as omitted for these properties
            Met = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new AuthorizationOauth2 { Met = true };

        AuthorizationOauth2 copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class WorkerResponseTypeTest : TestBase
{
    [Theory]
    [InlineData(WorkerResponseType.Http)]
    [InlineData(WorkerResponseType.Mcp)]
    [InlineData(WorkerResponseType.Unknown)]
    public void Validation_Works(WorkerResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, WorkerResponseType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, WorkerResponseType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(WorkerResponseType.Http)]
    [InlineData(WorkerResponseType.Mcp)]
    [InlineData(WorkerResponseType.Unknown)]
    public void SerializationRoundtrip_Works(WorkerResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, WorkerResponseType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, WorkerResponseType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, WorkerResponseType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, WorkerResponseType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
