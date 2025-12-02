using ArcadeDotnet.Models.Auth;

namespace ArcadeDotnet.Tests.Models.Auth;

public class ConfirmUserResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ConfirmUserResponse { AuthID = "auth_id", NextUri = "next_uri" };

        string expectedAuthID = "auth_id";
        string expectedNextUri = "next_uri";

        Assert.Equal(expectedAuthID, model.AuthID);
        Assert.Equal(expectedNextUri, model.NextUri);
    }
}
