using System.Collections.Generic;
using ArcadeDotnet.Models.Auth;

namespace ArcadeDotnet.Tests.Models.Auth;

public class AuthRequestTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthRequest
        {
            AuthRequirement = new()
            {
                ID = "id",
                Oauth2 = new() { Scopes = ["string"] },
                ProviderID = "provider_id",
                ProviderType = "provider_type",
            },
            UserID = "user_id",
            NextUri = "next_uri",
        };

        AuthRequestAuthRequirement expectedAuthRequirement = new()
        {
            ID = "id",
            Oauth2 = new() { Scopes = ["string"] },
            ProviderID = "provider_id",
            ProviderType = "provider_type",
        };
        string expectedUserID = "user_id";
        string expectedNextUri = "next_uri";

        Assert.Equal(expectedAuthRequirement, model.AuthRequirement);
        Assert.Equal(expectedUserID, model.UserID);
        Assert.Equal(expectedNextUri, model.NextUri);
    }
}

public class AuthRequestAuthRequirementTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthRequestAuthRequirement
        {
            ID = "id",
            Oauth2 = new() { Scopes = ["string"] },
            ProviderID = "provider_id",
            ProviderType = "provider_type",
        };

        string expectedID = "id";
        AuthRequestAuthRequirementOauth2 expectedOauth2 = new() { Scopes = ["string"] };
        string expectedProviderID = "provider_id";
        string expectedProviderType = "provider_type";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedOauth2, model.Oauth2);
        Assert.Equal(expectedProviderID, model.ProviderID);
        Assert.Equal(expectedProviderType, model.ProviderType);
    }
}

public class AuthRequestAuthRequirementOauth2Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthRequestAuthRequirementOauth2 { Scopes = ["string"] };

        List<string> expectedScopes = ["string"];

        Assert.Equal(expectedScopes.Count, model.Scopes.Count);
        for (int i = 0; i < expectedScopes.Count; i++)
        {
            Assert.Equal(expectedScopes[i], model.Scopes[i]);
        }
    }
}
