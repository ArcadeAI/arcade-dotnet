using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Core;
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
}
