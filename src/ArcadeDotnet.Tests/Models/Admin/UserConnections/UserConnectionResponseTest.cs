using System.Collections.Generic;
using System.Text.Json;
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
        Assert.True(JsonElement.DeepEquals(expectedProviderUserInfo, model.ProviderUserInfo));
        Assert.Equal(expectedScopes.Count, model.Scopes.Count);
        for (int i = 0; i < expectedScopes.Count; i++)
        {
            Assert.Equal(expectedScopes[i], model.Scopes[i]);
        }
        Assert.Equal(expectedUserID, model.UserID);
    }
}
