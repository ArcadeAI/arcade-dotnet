using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Admin.UserConnections;

namespace ArcadeDotnet.Tests.Models.Admin.UserConnections;

public class UserConnectionResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new UserConnectionResponse
        {
            ID = "id",
            ConnectionID = "connection_id",
            ConnectionStatus = "connection_status",
            ProviderDescription = "provider_description",
            ProviderID = "provider_id",
            ProviderType = "provider_type",
            ProviderUserInfo = JsonSerializer.Deserialize<JsonElement>("{}"),
            Scopes = ["string"],
            UserID = "user_id",
        };

        string expectedID = "id";
        string expectedConnectionID = "connection_id";
        string expectedConnectionStatus = "connection_status";
        string expectedProviderDescription = "provider_description";
        string expectedProviderID = "provider_id";
        string expectedProviderType = "provider_type";
        JsonElement expectedProviderUserInfo = JsonSerializer.Deserialize<JsonElement>("{}");
        List<string> expectedScopes = ["string"];
        string expectedUserID = "user_id";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedConnectionID, model.ConnectionID);
        Assert.Equal(expectedConnectionStatus, model.ConnectionStatus);
        Assert.Equal(expectedProviderDescription, model.ProviderDescription);
        Assert.Equal(expectedProviderID, model.ProviderID);
        Assert.Equal(expectedProviderType, model.ProviderType);
        Assert.NotNull(model.ProviderUserInfo);
        Assert.True(JsonElement.DeepEquals(expectedProviderUserInfo, model.ProviderUserInfo.Value));
        Assert.NotNull(model.Scopes);
        Assert.Equal(expectedScopes.Count, model.Scopes.Count);
        for (int i = 0; i < expectedScopes.Count; i++)
        {
            Assert.Equal(expectedScopes[i], model.Scopes[i]);
        }
        Assert.Equal(expectedUserID, model.UserID);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new UserConnectionResponse
        {
            ID = "id",
            ConnectionID = "connection_id",
            ConnectionStatus = "connection_status",
            ProviderDescription = "provider_description",
            ProviderID = "provider_id",
            ProviderType = "provider_type",
            ProviderUserInfo = JsonSerializer.Deserialize<JsonElement>("{}"),
            Scopes = ["string"],
            UserID = "user_id",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<UserConnectionResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new UserConnectionResponse
        {
            ID = "id",
            ConnectionID = "connection_id",
            ConnectionStatus = "connection_status",
            ProviderDescription = "provider_description",
            ProviderID = "provider_id",
            ProviderType = "provider_type",
            ProviderUserInfo = JsonSerializer.Deserialize<JsonElement>("{}"),
            Scopes = ["string"],
            UserID = "user_id",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<UserConnectionResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "id";
        string expectedConnectionID = "connection_id";
        string expectedConnectionStatus = "connection_status";
        string expectedProviderDescription = "provider_description";
        string expectedProviderID = "provider_id";
        string expectedProviderType = "provider_type";
        JsonElement expectedProviderUserInfo = JsonSerializer.Deserialize<JsonElement>("{}");
        List<string> expectedScopes = ["string"];
        string expectedUserID = "user_id";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedConnectionID, deserialized.ConnectionID);
        Assert.Equal(expectedConnectionStatus, deserialized.ConnectionStatus);
        Assert.Equal(expectedProviderDescription, deserialized.ProviderDescription);
        Assert.Equal(expectedProviderID, deserialized.ProviderID);
        Assert.Equal(expectedProviderType, deserialized.ProviderType);
        Assert.NotNull(deserialized.ProviderUserInfo);
        Assert.True(
            JsonElement.DeepEquals(expectedProviderUserInfo, deserialized.ProviderUserInfo.Value)
        );
        Assert.NotNull(deserialized.Scopes);
        Assert.Equal(expectedScopes.Count, deserialized.Scopes.Count);
        for (int i = 0; i < expectedScopes.Count; i++)
        {
            Assert.Equal(expectedScopes[i], deserialized.Scopes[i]);
        }
        Assert.Equal(expectedUserID, deserialized.UserID);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new UserConnectionResponse
        {
            ID = "id",
            ConnectionID = "connection_id",
            ConnectionStatus = "connection_status",
            ProviderDescription = "provider_description",
            ProviderID = "provider_id",
            ProviderType = "provider_type",
            ProviderUserInfo = JsonSerializer.Deserialize<JsonElement>("{}"),
            Scopes = ["string"],
            UserID = "user_id",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new UserConnectionResponse { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.ConnectionID);
        Assert.False(model.RawData.ContainsKey("connection_id"));
        Assert.Null(model.ConnectionStatus);
        Assert.False(model.RawData.ContainsKey("connection_status"));
        Assert.Null(model.ProviderDescription);
        Assert.False(model.RawData.ContainsKey("provider_description"));
        Assert.Null(model.ProviderID);
        Assert.False(model.RawData.ContainsKey("provider_id"));
        Assert.Null(model.ProviderType);
        Assert.False(model.RawData.ContainsKey("provider_type"));
        Assert.Null(model.ProviderUserInfo);
        Assert.False(model.RawData.ContainsKey("provider_user_info"));
        Assert.Null(model.Scopes);
        Assert.False(model.RawData.ContainsKey("scopes"));
        Assert.Null(model.UserID);
        Assert.False(model.RawData.ContainsKey("user_id"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new UserConnectionResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new UserConnectionResponse
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            ConnectionID = null,
            ConnectionStatus = null,
            ProviderDescription = null,
            ProviderID = null,
            ProviderType = null,
            ProviderUserInfo = null,
            Scopes = null,
            UserID = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.ConnectionID);
        Assert.False(model.RawData.ContainsKey("connection_id"));
        Assert.Null(model.ConnectionStatus);
        Assert.False(model.RawData.ContainsKey("connection_status"));
        Assert.Null(model.ProviderDescription);
        Assert.False(model.RawData.ContainsKey("provider_description"));
        Assert.Null(model.ProviderID);
        Assert.False(model.RawData.ContainsKey("provider_id"));
        Assert.Null(model.ProviderType);
        Assert.False(model.RawData.ContainsKey("provider_type"));
        Assert.Null(model.ProviderUserInfo);
        Assert.False(model.RawData.ContainsKey("provider_user_info"));
        Assert.Null(model.Scopes);
        Assert.False(model.RawData.ContainsKey("scopes"));
        Assert.Null(model.UserID);
        Assert.False(model.RawData.ContainsKey("user_id"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new UserConnectionResponse
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            ConnectionID = null,
            ConnectionStatus = null,
            ProviderDescription = null,
            ProviderID = null,
            ProviderType = null,
            ProviderUserInfo = null,
            Scopes = null,
            UserID = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new UserConnectionResponse
        {
            ID = "id",
            ConnectionID = "connection_id",
            ConnectionStatus = "connection_status",
            ProviderDescription = "provider_description",
            ProviderID = "provider_id",
            ProviderType = "provider_type",
            ProviderUserInfo = JsonSerializer.Deserialize<JsonElement>("{}"),
            Scopes = ["string"],
            UserID = "user_id",
        };

        UserConnectionResponse copied = new(model);

        Assert.Equal(model, copied);
    }
}
