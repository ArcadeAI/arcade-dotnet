using System.Collections.Generic;
using ArcadeDotnet.Models.Auth;

namespace ArcadeDotnet.Tests.Models.Auth;

public class AuthRequirementTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthRequirement
        {
            ID = "id",
            Oauth2 = new() { Scopes = ["string"] },
            ProviderID = "provider_id",
            ProviderType = "provider_type",
        };

        string expectedID = "id";
        Oauth2 expectedOauth2 = new() { Scopes = ["string"] };
        string expectedProviderID = "provider_id";
        string expectedProviderType = "provider_type";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedOauth2, model.Oauth2);
        Assert.Equal(expectedProviderID, model.ProviderID);
        Assert.Equal(expectedProviderType, model.ProviderType);
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
