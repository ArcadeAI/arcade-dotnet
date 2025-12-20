using ArcadeDotnet.Models.Auth;

namespace ArcadeDotnet.Tests.Models.Auth;

public class AuthConfirmUserParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new AuthConfirmUserParams { FlowID = "flow_id", UserID = "user_id" };

        string expectedFlowID = "flow_id";
        string expectedUserID = "user_id";

        Assert.Equal(expectedFlowID, parameters.FlowID);
        Assert.Equal(expectedUserID, parameters.UserID);
    }
}
