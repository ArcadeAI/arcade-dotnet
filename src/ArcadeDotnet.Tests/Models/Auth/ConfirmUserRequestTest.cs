using System.Text.Json;
using ArcadeDotnet.Core;
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

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ConfirmUserRequest>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ConfirmUserRequest { FlowID = "flow_id", UserID = "user_id" };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ConfirmUserRequest>(
            element,
            ModelBase.SerializerOptions
        );
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

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new ConfirmUserRequest { FlowID = "flow_id", UserID = "user_id" };

        ConfirmUserRequest copied = new(model);

        Assert.Equal(model, copied);
    }
}
