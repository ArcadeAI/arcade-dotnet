using System.Text.Json;
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

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new ConfirmUserRequest { FlowID = "flow_id", UserID = "user_id" };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ConfirmUserRequest>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ConfirmUserRequest { FlowID = "flow_id", UserID = "user_id" };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ConfirmUserRequest>(element);
        Assert.NotNull(deserialized);

        string expectedFlowID = "flow_id";
        string expectedUserID = "user_id";

        Assert.Equal(expectedFlowID, deserialized.FlowID);
        Assert.Equal(expectedUserID, deserialized.UserID);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new ConfirmUserRequest { FlowID = "flow_id", UserID = "user_id" };

        model.Validate();
    }
}
