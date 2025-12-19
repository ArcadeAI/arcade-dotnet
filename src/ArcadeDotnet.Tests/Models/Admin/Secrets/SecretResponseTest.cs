using System.Text.Json;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using ArcadeDotnet.Models.Admin.Secrets;

namespace ArcadeDotnet.Tests.Models.Admin.Secrets;

public class SecretResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new SecretResponse
        {
            ID = "id",
            Binding = new() { ID = "id", Type = Type.Static },
            CreatedAt = "created_at",
            Description = "description",
            Hint = "hint",
            Key = "key",
            LastAccessedAt = "last_accessed_at",
            UpdatedAt = "updated_at",
        };

        string expectedID = "id";
        Binding expectedBinding = new() { ID = "id", Type = Type.Static };
        string expectedCreatedAt = "created_at";
        string expectedDescription = "description";
        string expectedHint = "hint";
        string expectedKey = "key";
        string expectedLastAccessedAt = "last_accessed_at";
        string expectedUpdatedAt = "updated_at";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedBinding, model.Binding);
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedHint, model.Hint);
        Assert.Equal(expectedKey, model.Key);
        Assert.Equal(expectedLastAccessedAt, model.LastAccessedAt);
        Assert.Equal(expectedUpdatedAt, model.UpdatedAt);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new SecretResponse
        {
            ID = "id",
            Binding = new() { ID = "id", Type = Type.Static },
            CreatedAt = "created_at",
            Description = "description",
            Hint = "hint",
            Key = "key",
            LastAccessedAt = "last_accessed_at",
            UpdatedAt = "updated_at",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<SecretResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new SecretResponse
        {
            ID = "id",
            Binding = new() { ID = "id", Type = Type.Static },
            CreatedAt = "created_at",
            Description = "description",
            Hint = "hint",
            Key = "key",
            LastAccessedAt = "last_accessed_at",
            UpdatedAt = "updated_at",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<SecretResponse>(element);
        Assert.NotNull(deserialized);

        string expectedID = "id";
        Binding expectedBinding = new() { ID = "id", Type = Type.Static };
        string expectedCreatedAt = "created_at";
        string expectedDescription = "description";
        string expectedHint = "hint";
        string expectedKey = "key";
        string expectedLastAccessedAt = "last_accessed_at";
        string expectedUpdatedAt = "updated_at";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedBinding, deserialized.Binding);
        Assert.Equal(expectedCreatedAt, deserialized.CreatedAt);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedHint, deserialized.Hint);
        Assert.Equal(expectedKey, deserialized.Key);
        Assert.Equal(expectedLastAccessedAt, deserialized.LastAccessedAt);
        Assert.Equal(expectedUpdatedAt, deserialized.UpdatedAt);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new SecretResponse
        {
            ID = "id",
            Binding = new() { ID = "id", Type = Type.Static },
            CreatedAt = "created_at",
            Description = "description",
            Hint = "hint",
            Key = "key",
            LastAccessedAt = "last_accessed_at",
            UpdatedAt = "updated_at",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new SecretResponse { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Binding);
        Assert.False(model.RawData.ContainsKey("binding"));
        Assert.Null(model.CreatedAt);
        Assert.False(model.RawData.ContainsKey("created_at"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Hint);
        Assert.False(model.RawData.ContainsKey("hint"));
        Assert.Null(model.Key);
        Assert.False(model.RawData.ContainsKey("key"));
        Assert.Null(model.LastAccessedAt);
        Assert.False(model.RawData.ContainsKey("last_accessed_at"));
        Assert.Null(model.UpdatedAt);
        Assert.False(model.RawData.ContainsKey("updated_at"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new SecretResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new SecretResponse
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Binding = null,
            CreatedAt = null,
            Description = null,
            Hint = null,
            Key = null,
            LastAccessedAt = null,
            UpdatedAt = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Binding);
        Assert.False(model.RawData.ContainsKey("binding"));
        Assert.Null(model.CreatedAt);
        Assert.False(model.RawData.ContainsKey("created_at"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Hint);
        Assert.False(model.RawData.ContainsKey("hint"));
        Assert.Null(model.Key);
        Assert.False(model.RawData.ContainsKey("key"));
        Assert.Null(model.LastAccessedAt);
        Assert.False(model.RawData.ContainsKey("last_accessed_at"));
        Assert.Null(model.UpdatedAt);
        Assert.False(model.RawData.ContainsKey("updated_at"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new SecretResponse
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Binding = null,
            CreatedAt = null,
            Description = null,
            Hint = null,
            Key = null,
            LastAccessedAt = null,
            UpdatedAt = null,
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
