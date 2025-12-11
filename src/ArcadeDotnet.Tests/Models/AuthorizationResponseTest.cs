using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using ArcadeDotnet.Models;

namespace ArcadeDotnet.Tests.Models;

public class AuthorizationResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthorizationResponse
        {
            ID = "id",
            Context = new()
            {
                Token = "token",
                UserInfo = new Dictionary<string, JsonElement>()
                {
                    { "foo", JsonSerializer.SerializeToElement("bar") },
                },
            },
            ProviderID = "provider_id",
            Scopes = ["string"],
            Status = Status.NotStarted,
            URL = "url",
            UserID = "user_id",
        };

        string expectedID = "id";
        AuthorizationContext expectedContext = new()
        {
            Token = "token",
            UserInfo = new Dictionary<string, JsonElement>()
            {
                { "foo", JsonSerializer.SerializeToElement("bar") },
            },
        };
        string expectedProviderID = "provider_id";
        List<string> expectedScopes = ["string"];
        ApiEnum<string, Status> expectedStatus = Status.NotStarted;
        string expectedURL = "url";
        string expectedUserID = "user_id";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedContext, model.Context);
        Assert.Equal(expectedProviderID, model.ProviderID);
        Assert.Equal(expectedScopes.Count, model.Scopes.Count);
        for (int i = 0; i < expectedScopes.Count; i++)
        {
            Assert.Equal(expectedScopes[i], model.Scopes[i]);
        }
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedURL, model.URL);
        Assert.Equal(expectedUserID, model.UserID);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AuthorizationResponse
        {
            ID = "id",
            Context = new()
            {
                Token = "token",
                UserInfo = new Dictionary<string, JsonElement>()
                {
                    { "foo", JsonSerializer.SerializeToElement("bar") },
                },
            },
            ProviderID = "provider_id",
            Scopes = ["string"],
            Status = Status.NotStarted,
            URL = "url",
            UserID = "user_id",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthorizationResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AuthorizationResponse
        {
            ID = "id",
            Context = new()
            {
                Token = "token",
                UserInfo = new Dictionary<string, JsonElement>()
                {
                    { "foo", JsonSerializer.SerializeToElement("bar") },
                },
            },
            ProviderID = "provider_id",
            Scopes = ["string"],
            Status = Status.NotStarted,
            URL = "url",
            UserID = "user_id",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthorizationResponse>(json);
        Assert.NotNull(deserialized);

        string expectedID = "id";
        AuthorizationContext expectedContext = new()
        {
            Token = "token",
            UserInfo = new Dictionary<string, JsonElement>()
            {
                { "foo", JsonSerializer.SerializeToElement("bar") },
            },
        };
        string expectedProviderID = "provider_id";
        List<string> expectedScopes = ["string"];
        ApiEnum<string, Status> expectedStatus = Status.NotStarted;
        string expectedURL = "url";
        string expectedUserID = "user_id";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedContext, deserialized.Context);
        Assert.Equal(expectedProviderID, deserialized.ProviderID);
        Assert.Equal(expectedScopes.Count, deserialized.Scopes.Count);
        for (int i = 0; i < expectedScopes.Count; i++)
        {
            Assert.Equal(expectedScopes[i], deserialized.Scopes[i]);
        }
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedURL, deserialized.URL);
        Assert.Equal(expectedUserID, deserialized.UserID);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AuthorizationResponse
        {
            ID = "id",
            Context = new()
            {
                Token = "token",
                UserInfo = new Dictionary<string, JsonElement>()
                {
                    { "foo", JsonSerializer.SerializeToElement("bar") },
                },
            },
            ProviderID = "provider_id",
            Scopes = ["string"],
            Status = Status.NotStarted,
            URL = "url",
            UserID = "user_id",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthorizationResponse { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Context);
        Assert.False(model.RawData.ContainsKey("context"));
        Assert.Null(model.ProviderID);
        Assert.False(model.RawData.ContainsKey("provider_id"));
        Assert.Null(model.Scopes);
        Assert.False(model.RawData.ContainsKey("scopes"));
        Assert.Null(model.Status);
        Assert.False(model.RawData.ContainsKey("status"));
        Assert.Null(model.URL);
        Assert.False(model.RawData.ContainsKey("url"));
        Assert.Null(model.UserID);
        Assert.False(model.RawData.ContainsKey("user_id"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AuthorizationResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthorizationResponse
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Context = null,
            ProviderID = null,
            Scopes = null,
            Status = null,
            URL = null,
            UserID = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Context);
        Assert.False(model.RawData.ContainsKey("context"));
        Assert.Null(model.ProviderID);
        Assert.False(model.RawData.ContainsKey("provider_id"));
        Assert.Null(model.Scopes);
        Assert.False(model.RawData.ContainsKey("scopes"));
        Assert.Null(model.Status);
        Assert.False(model.RawData.ContainsKey("status"));
        Assert.Null(model.URL);
        Assert.False(model.RawData.ContainsKey("url"));
        Assert.Null(model.UserID);
        Assert.False(model.RawData.ContainsKey("user_id"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new AuthorizationResponse
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Context = null,
            ProviderID = null,
            Scopes = null,
            Status = null,
            URL = null,
            UserID = null,
        };

        model.Validate();
    }
}

public class StatusTest : TestBase
{
    [Theory]
    [InlineData(Status.NotStarted)]
    [InlineData(Status.Pending)]
    [InlineData(Status.Completed)]
    [InlineData(Status.Failed)]
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
    [InlineData(Status.NotStarted)]
    [InlineData(Status.Pending)]
    [InlineData(Status.Completed)]
    [InlineData(Status.Failed)]
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
