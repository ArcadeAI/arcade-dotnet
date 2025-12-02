using ArcadeDotnet.Models.Auth;

namespace ArcadeDotnet.Tests.Models.Auth;

public class ConfirmUserRequestTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ConfirmUserRequest { FlowID = "flow_id", UserID = "user_id" };

        string expectedFlowID = "flow_id";
        string expectedUserID = "user_id";

        Assert.Equal(expectedFlowID, model.FlowID);
        Assert.Equal(expectedUserID, model.UserID);
    }
}
