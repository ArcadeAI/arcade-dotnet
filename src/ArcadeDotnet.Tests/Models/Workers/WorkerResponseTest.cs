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
            HTTP = new()
            {
                Retry = 0,
                Secret = new()
                {
                    Binding = SecretBinding.Static,
                    Editable = true,
                    Exists = true,
                    Hint = "hint",
                    Value = "value",
                },
                Timeout = 0,
                Uri = "uri",
            },
            Managed = true,
            Mcp = new()
            {
                Headers = new Dictionary<string, string>() { { "foo", "string" } },
                Oauth2 = new()
                {
                    AuthorizationURL = "authorization_url",
                    ClientID = "client_id",
                    ClientSecret = new()
                    {
                        Binding = ClientSecretBinding.Static,
                        Editable = true,
                        Exists = true,
                        Hint = "hint",
                        Value = "value",
                    },
                    RedirectUri = "redirect_uri",
                },
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
                            Hint = "hint",
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
            Type = WorkerResponseType.HTTP,
        };

        string expectedID = "id";
        Binding expectedBinding = new() { ID = "id", Type = Type.Static };
        bool expectedEnabled = true;
        WorkerResponseHTTP expectedHTTP = new()
        {
            Retry = 0,
            Secret = new()
            {
                Binding = SecretBinding.Static,
                Editable = true,
                Exists = true,
                Hint = "hint",
                Value = "value",
            },
            Timeout = 0,
            Uri = "uri",
        };
        bool expectedManaged = true;
        WorkerResponseMcp expectedMcp = new()
        {
            Headers = new Dictionary<string, string>() { { "foo", "string" } },
            Oauth2 = new()
            {
                AuthorizationURL = "authorization_url",
                ClientID = "client_id",
                ClientSecret = new()
                {
                    Binding = ClientSecretBinding.Static,
                    Editable = true,
                    Exists = true,
                    Hint = "hint",
                    Value = "value",
                },
                RedirectUri = "redirect_uri",
            },
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
                        Hint = "hint",
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
        ApiEnum<string, WorkerResponseType> expectedType = WorkerResponseType.HTTP;

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedBinding, model.Binding);
        Assert.Equal(expectedEnabled, model.Enabled);
        Assert.Equal(expectedHTTP, model.HTTP);
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
            HTTP = new()
            {
                Retry = 0,
                Secret = new()
                {
                    Binding = SecretBinding.Static,
                    Editable = true,
                    Exists = true,
                    Hint = "hint",
                    Value = "value",
                },
                Timeout = 0,
                Uri = "uri",
            },
            Managed = true,
            Mcp = new()
            {
                Headers = new Dictionary<string, string>() { { "foo", "string" } },
                Oauth2 = new()
                {
                    AuthorizationURL = "authorization_url",
                    ClientID = "client_id",
                    ClientSecret = new()
                    {
                        Binding = ClientSecretBinding.Static,
                        Editable = true,
                        Exists = true,
                        Hint = "hint",
                        Value = "value",
                    },
                    RedirectUri = "redirect_uri",
                },
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
                            Hint = "hint",
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
            Type = WorkerResponseType.HTTP,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<WorkerResponse>(json);

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
            HTTP = new()
            {
                Retry = 0,
                Secret = new()
                {
                    Binding = SecretBinding.Static,
                    Editable = true,
                    Exists = true,
                    Hint = "hint",
                    Value = "value",
                },
                Timeout = 0,
                Uri = "uri",
            },
            Managed = true,
            Mcp = new()
            {
                Headers = new Dictionary<string, string>() { { "foo", "string" } },
                Oauth2 = new()
                {
                    AuthorizationURL = "authorization_url",
                    ClientID = "client_id",
                    ClientSecret = new()
                    {
                        Binding = ClientSecretBinding.Static,
                        Editable = true,
                        Exists = true,
                        Hint = "hint",
                        Value = "value",
                    },
                    RedirectUri = "redirect_uri",
                },
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
                            Hint = "hint",
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
            Type = WorkerResponseType.HTTP,
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<WorkerResponse>(element);
        Assert.NotNull(deserialized);

        string expectedID = "id";
        Binding expectedBinding = new() { ID = "id", Type = Type.Static };
        bool expectedEnabled = true;
        WorkerResponseHTTP expectedHTTP = new()
        {
            Retry = 0,
            Secret = new()
            {
                Binding = SecretBinding.Static,
                Editable = true,
                Exists = true,
                Hint = "hint",
                Value = "value",
            },
            Timeout = 0,
            Uri = "uri",
        };
        bool expectedManaged = true;
        WorkerResponseMcp expectedMcp = new()
        {
            Headers = new Dictionary<string, string>() { { "foo", "string" } },
            Oauth2 = new()
            {
                AuthorizationURL = "authorization_url",
                ClientID = "client_id",
                ClientSecret = new()
                {
                    Binding = ClientSecretBinding.Static,
                    Editable = true,
                    Exists = true,
                    Hint = "hint",
                    Value = "value",
                },
                RedirectUri = "redirect_uri",
            },
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
                        Hint = "hint",
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
        ApiEnum<string, WorkerResponseType> expectedType = WorkerResponseType.HTTP;

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedBinding, deserialized.Binding);
        Assert.Equal(expectedEnabled, deserialized.Enabled);
        Assert.Equal(expectedHTTP, deserialized.HTTP);
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
            HTTP = new()
            {
                Retry = 0,
                Secret = new()
                {
                    Binding = SecretBinding.Static,
                    Editable = true,
                    Exists = true,
                    Hint = "hint",
                    Value = "value",
                },
                Timeout = 0,
                Uri = "uri",
            },
            Managed = true,
            Mcp = new()
            {
                Headers = new Dictionary<string, string>() { { "foo", "string" } },
                Oauth2 = new()
                {
                    AuthorizationURL = "authorization_url",
                    ClientID = "client_id",
                    ClientSecret = new()
                    {
                        Binding = ClientSecretBinding.Static,
                        Editable = true,
                        Exists = true,
                        Hint = "hint",
                        Value = "value",
                    },
                    RedirectUri = "redirect_uri",
                },
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
                            Hint = "hint",
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
            Type = WorkerResponseType.HTTP,
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
        Assert.Null(model.HTTP);
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
            HTTP = null,
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
        Assert.Null(model.HTTP);
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
            HTTP = null,
            Managed = null,
            Mcp = null,
            Requirements = null,
            Type = null,
        };

        model.Validate();
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

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Binding>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Binding { ID = "id", Type = Type.Static };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Binding>(element);
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
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
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
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
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

public class WorkerResponseHTTPTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new WorkerResponseHTTP
        {
            Retry = 0,
            Secret = new()
            {
                Binding = SecretBinding.Static,
                Editable = true,
                Exists = true,
                Hint = "hint",
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
            Hint = "hint",
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
        var model = new WorkerResponseHTTP
        {
            Retry = 0,
            Secret = new()
            {
                Binding = SecretBinding.Static,
                Editable = true,
                Exists = true,
                Hint = "hint",
                Value = "value",
            },
            Timeout = 0,
            Uri = "uri",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<WorkerResponseHTTP>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new WorkerResponseHTTP
        {
            Retry = 0,
            Secret = new()
            {
                Binding = SecretBinding.Static,
                Editable = true,
                Exists = true,
                Hint = "hint",
                Value = "value",
            },
            Timeout = 0,
            Uri = "uri",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<WorkerResponseHTTP>(element);
        Assert.NotNull(deserialized);

        long expectedRetry = 0;
        Secret expectedSecret = new()
        {
            Binding = SecretBinding.Static,
            Editable = true,
            Exists = true,
            Hint = "hint",
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
        var model = new WorkerResponseHTTP
        {
            Retry = 0,
            Secret = new()
            {
                Binding = SecretBinding.Static,
                Editable = true,
                Exists = true,
                Hint = "hint",
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
        var model = new WorkerResponseHTTP { };

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
        var model = new WorkerResponseHTTP { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new WorkerResponseHTTP
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
        var model = new WorkerResponseHTTP
        {
            // Null should be interpreted as omitted for these properties
            Retry = null,
            Secret = null,
            Timeout = null,
            Uri = null,
        };

        model.Validate();
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
            Hint = "hint",
            Value = "value",
        };

        ApiEnum<string, SecretBinding> expectedBinding = SecretBinding.Static;
        bool expectedEditable = true;
        bool expectedExists = true;
        string expectedHint = "hint";
        string expectedValue = "value";

        Assert.Equal(expectedBinding, model.Binding);
        Assert.Equal(expectedEditable, model.Editable);
        Assert.Equal(expectedExists, model.Exists);
        Assert.Equal(expectedHint, model.Hint);
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
            Hint = "hint",
            Value = "value",
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
            Binding = SecretBinding.Static,
            Editable = true,
            Exists = true,
            Hint = "hint",
            Value = "value",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Secret>(element);
        Assert.NotNull(deserialized);

        ApiEnum<string, SecretBinding> expectedBinding = SecretBinding.Static;
        bool expectedEditable = true;
        bool expectedExists = true;
        string expectedHint = "hint";
        string expectedValue = "value";

        Assert.Equal(expectedBinding, deserialized.Binding);
        Assert.Equal(expectedEditable, deserialized.Editable);
        Assert.Equal(expectedExists, deserialized.Exists);
        Assert.Equal(expectedHint, deserialized.Hint);
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
            Hint = "hint",
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
        Assert.Null(model.Hint);
        Assert.False(model.RawData.ContainsKey("hint"));
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
            Hint = null,
            Value = null,
        };

        Assert.Null(model.Binding);
        Assert.False(model.RawData.ContainsKey("binding"));
        Assert.Null(model.Editable);
        Assert.False(model.RawData.ContainsKey("editable"));
        Assert.Null(model.Exists);
        Assert.False(model.RawData.ContainsKey("exists"));
        Assert.Null(model.Hint);
        Assert.False(model.RawData.ContainsKey("hint"));
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
            Hint = null,
            Value = null,
        };

        model.Validate();
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
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
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
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
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
            Headers = new Dictionary<string, string>() { { "foo", "string" } },
            Oauth2 = new()
            {
                AuthorizationURL = "authorization_url",
                ClientID = "client_id",
                ClientSecret = new()
                {
                    Binding = ClientSecretBinding.Static,
                    Editable = true,
                    Exists = true,
                    Hint = "hint",
                    Value = "value",
                },
                RedirectUri = "redirect_uri",
            },
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
                        Hint = "hint",
                        Value = "value",
                    }
                },
            },
            Timeout = 0,
            Uri = "uri",
        };

        Dictionary<string, string> expectedHeaders = new() { { "foo", "string" } };
        WorkerResponseMcpOauth2 expectedOauth2 = new()
        {
            AuthorizationURL = "authorization_url",
            ClientID = "client_id",
            ClientSecret = new()
            {
                Binding = ClientSecretBinding.Static,
                Editable = true,
                Exists = true,
                Hint = "hint",
                Value = "value",
            },
            RedirectUri = "redirect_uri",
        };
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
                    Hint = "hint",
                    Value = "value",
                }
            },
        };
        long expectedTimeout = 0;
        string expectedUri = "uri";

        Assert.Equal(expectedHeaders.Count, model.Headers.Count);
        foreach (var item in expectedHeaders)
        {
            Assert.True(model.Headers.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.Headers[item.Key]);
        }
        Assert.Equal(expectedOauth2, model.Oauth2);
        Assert.Equal(expectedRetry, model.Retry);
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
            Headers = new Dictionary<string, string>() { { "foo", "string" } },
            Oauth2 = new()
            {
                AuthorizationURL = "authorization_url",
                ClientID = "client_id",
                ClientSecret = new()
                {
                    Binding = ClientSecretBinding.Static,
                    Editable = true,
                    Exists = true,
                    Hint = "hint",
                    Value = "value",
                },
                RedirectUri = "redirect_uri",
            },
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
                        Hint = "hint",
                        Value = "value",
                    }
                },
            },
            Timeout = 0,
            Uri = "uri",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<WorkerResponseMcp>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new WorkerResponseMcp
        {
            Headers = new Dictionary<string, string>() { { "foo", "string" } },
            Oauth2 = new()
            {
                AuthorizationURL = "authorization_url",
                ClientID = "client_id",
                ClientSecret = new()
                {
                    Binding = ClientSecretBinding.Static,
                    Editable = true,
                    Exists = true,
                    Hint = "hint",
                    Value = "value",
                },
                RedirectUri = "redirect_uri",
            },
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
                        Hint = "hint",
                        Value = "value",
                    }
                },
            },
            Timeout = 0,
            Uri = "uri",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<WorkerResponseMcp>(element);
        Assert.NotNull(deserialized);

        Dictionary<string, string> expectedHeaders = new() { { "foo", "string" } };
        WorkerResponseMcpOauth2 expectedOauth2 = new()
        {
            AuthorizationURL = "authorization_url",
            ClientID = "client_id",
            ClientSecret = new()
            {
                Binding = ClientSecretBinding.Static,
                Editable = true,
                Exists = true,
                Hint = "hint",
                Value = "value",
            },
            RedirectUri = "redirect_uri",
        };
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
                    Hint = "hint",
                    Value = "value",
                }
            },
        };
        long expectedTimeout = 0;
        string expectedUri = "uri";

        Assert.Equal(expectedHeaders.Count, deserialized.Headers.Count);
        foreach (var item in expectedHeaders)
        {
            Assert.True(deserialized.Headers.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.Headers[item.Key]);
        }
        Assert.Equal(expectedOauth2, deserialized.Oauth2);
        Assert.Equal(expectedRetry, deserialized.Retry);
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
            Headers = new Dictionary<string, string>() { { "foo", "string" } },
            Oauth2 = new()
            {
                AuthorizationURL = "authorization_url",
                ClientID = "client_id",
                ClientSecret = new()
                {
                    Binding = ClientSecretBinding.Static,
                    Editable = true,
                    Exists = true,
                    Hint = "hint",
                    Value = "value",
                },
                RedirectUri = "redirect_uri",
            },
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
                        Hint = "hint",
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

        Assert.Null(model.Headers);
        Assert.False(model.RawData.ContainsKey("headers"));
        Assert.Null(model.Oauth2);
        Assert.False(model.RawData.ContainsKey("oauth2"));
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
            Headers = null,
            Oauth2 = null,
            Retry = null,
            Secrets = null,
            Timeout = null,
            Uri = null,
        };

        Assert.Null(model.Headers);
        Assert.False(model.RawData.ContainsKey("headers"));
        Assert.Null(model.Oauth2);
        Assert.False(model.RawData.ContainsKey("oauth2"));
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
            Headers = null,
            Oauth2 = null,
            Retry = null,
            Secrets = null,
            Timeout = null,
            Uri = null,
        };

        model.Validate();
    }
}

public class WorkerResponseMcpOauth2Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new WorkerResponseMcpOauth2
        {
            AuthorizationURL = "authorization_url",
            ClientID = "client_id",
            ClientSecret = new()
            {
                Binding = ClientSecretBinding.Static,
                Editable = true,
                Exists = true,
                Hint = "hint",
                Value = "value",
            },
            RedirectUri = "redirect_uri",
        };

        string expectedAuthorizationURL = "authorization_url";
        string expectedClientID = "client_id";
        ClientSecret expectedClientSecret = new()
        {
            Binding = ClientSecretBinding.Static,
            Editable = true,
            Exists = true,
            Hint = "hint",
            Value = "value",
        };
        string expectedRedirectUri = "redirect_uri";

        Assert.Equal(expectedAuthorizationURL, model.AuthorizationURL);
        Assert.Equal(expectedClientID, model.ClientID);
        Assert.Equal(expectedClientSecret, model.ClientSecret);
        Assert.Equal(expectedRedirectUri, model.RedirectUri);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new WorkerResponseMcpOauth2
        {
            AuthorizationURL = "authorization_url",
            ClientID = "client_id",
            ClientSecret = new()
            {
                Binding = ClientSecretBinding.Static,
                Editable = true,
                Exists = true,
                Hint = "hint",
                Value = "value",
            },
            RedirectUri = "redirect_uri",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<WorkerResponseMcpOauth2>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new WorkerResponseMcpOauth2
        {
            AuthorizationURL = "authorization_url",
            ClientID = "client_id",
            ClientSecret = new()
            {
                Binding = ClientSecretBinding.Static,
                Editable = true,
                Exists = true,
                Hint = "hint",
                Value = "value",
            },
            RedirectUri = "redirect_uri",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<WorkerResponseMcpOauth2>(element);
        Assert.NotNull(deserialized);

        string expectedAuthorizationURL = "authorization_url";
        string expectedClientID = "client_id";
        ClientSecret expectedClientSecret = new()
        {
            Binding = ClientSecretBinding.Static,
            Editable = true,
            Exists = true,
            Hint = "hint",
            Value = "value",
        };
        string expectedRedirectUri = "redirect_uri";

        Assert.Equal(expectedAuthorizationURL, deserialized.AuthorizationURL);
        Assert.Equal(expectedClientID, deserialized.ClientID);
        Assert.Equal(expectedClientSecret, deserialized.ClientSecret);
        Assert.Equal(expectedRedirectUri, deserialized.RedirectUri);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new WorkerResponseMcpOauth2
        {
            AuthorizationURL = "authorization_url",
            ClientID = "client_id",
            ClientSecret = new()
            {
                Binding = ClientSecretBinding.Static,
                Editable = true,
                Exists = true,
                Hint = "hint",
                Value = "value",
            },
            RedirectUri = "redirect_uri",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new WorkerResponseMcpOauth2 { };

        Assert.Null(model.AuthorizationURL);
        Assert.False(model.RawData.ContainsKey("authorization_url"));
        Assert.Null(model.ClientID);
        Assert.False(model.RawData.ContainsKey("client_id"));
        Assert.Null(model.ClientSecret);
        Assert.False(model.RawData.ContainsKey("client_secret"));
        Assert.Null(model.RedirectUri);
        Assert.False(model.RawData.ContainsKey("redirect_uri"));
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
            AuthorizationURL = null,
            ClientID = null,
            ClientSecret = null,
            RedirectUri = null,
        };

        Assert.Null(model.AuthorizationURL);
        Assert.False(model.RawData.ContainsKey("authorization_url"));
        Assert.Null(model.ClientID);
        Assert.False(model.RawData.ContainsKey("client_id"));
        Assert.Null(model.ClientSecret);
        Assert.False(model.RawData.ContainsKey("client_secret"));
        Assert.Null(model.RedirectUri);
        Assert.False(model.RawData.ContainsKey("redirect_uri"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new WorkerResponseMcpOauth2
        {
            // Null should be interpreted as omitted for these properties
            AuthorizationURL = null,
            ClientID = null,
            ClientSecret = null,
            RedirectUri = null,
        };

        model.Validate();
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
            Hint = "hint",
            Value = "value",
        };

        ApiEnum<string, ClientSecretBinding> expectedBinding = ClientSecretBinding.Static;
        bool expectedEditable = true;
        bool expectedExists = true;
        string expectedHint = "hint";
        string expectedValue = "value";

        Assert.Equal(expectedBinding, model.Binding);
        Assert.Equal(expectedEditable, model.Editable);
        Assert.Equal(expectedExists, model.Exists);
        Assert.Equal(expectedHint, model.Hint);
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
            Hint = "hint",
            Value = "value",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ClientSecret>(json);

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
            Hint = "hint",
            Value = "value",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ClientSecret>(element);
        Assert.NotNull(deserialized);

        ApiEnum<string, ClientSecretBinding> expectedBinding = ClientSecretBinding.Static;
        bool expectedEditable = true;
        bool expectedExists = true;
        string expectedHint = "hint";
        string expectedValue = "value";

        Assert.Equal(expectedBinding, deserialized.Binding);
        Assert.Equal(expectedEditable, deserialized.Editable);
        Assert.Equal(expectedExists, deserialized.Exists);
        Assert.Equal(expectedHint, deserialized.Hint);
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
            Hint = "hint",
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
        Assert.Null(model.Hint);
        Assert.False(model.RawData.ContainsKey("hint"));
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
            Hint = null,
            Value = null,
        };

        Assert.Null(model.Binding);
        Assert.False(model.RawData.ContainsKey("binding"));
        Assert.Null(model.Editable);
        Assert.False(model.RawData.ContainsKey("editable"));
        Assert.Null(model.Exists);
        Assert.False(model.RawData.ContainsKey("exists"));
        Assert.Null(model.Hint);
        Assert.False(model.RawData.ContainsKey("hint"));
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
            Hint = null,
            Value = null,
        };

        model.Validate();
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
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
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
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
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
            Hint = "hint",
            Value = "value",
        };

        ApiEnum<string, SecretsItemBinding> expectedBinding = SecretsItemBinding.Static;
        bool expectedEditable = true;
        bool expectedExists = true;
        string expectedHint = "hint";
        string expectedValue = "value";

        Assert.Equal(expectedBinding, model.Binding);
        Assert.Equal(expectedEditable, model.Editable);
        Assert.Equal(expectedExists, model.Exists);
        Assert.Equal(expectedHint, model.Hint);
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
            Hint = "hint",
            Value = "value",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<SecretsItem>(json);

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
            Hint = "hint",
            Value = "value",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<SecretsItem>(element);
        Assert.NotNull(deserialized);

        ApiEnum<string, SecretsItemBinding> expectedBinding = SecretsItemBinding.Static;
        bool expectedEditable = true;
        bool expectedExists = true;
        string expectedHint = "hint";
        string expectedValue = "value";

        Assert.Equal(expectedBinding, deserialized.Binding);
        Assert.Equal(expectedEditable, deserialized.Editable);
        Assert.Equal(expectedExists, deserialized.Exists);
        Assert.Equal(expectedHint, deserialized.Hint);
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
            Hint = "hint",
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
        Assert.Null(model.Hint);
        Assert.False(model.RawData.ContainsKey("hint"));
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
            Hint = null,
            Value = null,
        };

        Assert.Null(model.Binding);
        Assert.False(model.RawData.ContainsKey("binding"));
        Assert.Null(model.Editable);
        Assert.False(model.RawData.ContainsKey("editable"));
        Assert.Null(model.Exists);
        Assert.False(model.RawData.ContainsKey("exists"));
        Assert.Null(model.Hint);
        Assert.False(model.RawData.ContainsKey("hint"));
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
            Hint = null,
            Value = null,
        };

        model.Validate();
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
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
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
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
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
                Met = true,
                Oauth2 = new() { Met = true },
            },
            Met = true,
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Requirements>(element);
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

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Authorization>(json);

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

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<Authorization>(element);
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

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthorizationOauth2>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AuthorizationOauth2 { Met = true };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthorizationOauth2>(element);
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
}

public class WorkerResponseTypeTest : TestBase
{
    [Theory]
    [InlineData(WorkerResponseType.HTTP)]
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
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
            ModelBase.SerializerOptions
        );
        Assert.Throws<ArcadeInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(WorkerResponseType.HTTP)]
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
            JsonSerializer.Deserialize<JsonElement>("\"invalid value\""),
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
