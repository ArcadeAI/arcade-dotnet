using System.Text.Json;
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

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new ConfirmUserResponse { AuthID = "auth_id", NextUri = "next_uri" };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ConfirmUserResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ConfirmUserResponse { AuthID = "auth_id", NextUri = "next_uri" };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<ConfirmUserResponse>(element);
        Assert.NotNull(deserialized);

        string expectedAuthID = "auth_id";
        string expectedNextUri = "next_uri";

        Assert.Equal(expectedAuthID, deserialized.AuthID);
        Assert.Equal(expectedNextUri, deserialized.NextUri);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new ConfirmUserResponse { AuthID = "auth_id", NextUri = "next_uri" };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new ConfirmUserResponse { AuthID = "auth_id" };

        Assert.Null(model.NextUri);
        Assert.False(model.RawData.ContainsKey("next_uri"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new ConfirmUserResponse { AuthID = "auth_id" };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new ConfirmUserResponse
        {
            AuthID = "auth_id",

            // Null should be interpreted as omitted for these properties
            NextUri = null,
        };

        Assert.Null(model.NextUri);
        Assert.False(model.RawData.ContainsKey("next_uri"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new ConfirmUserResponse
        {
            AuthID = "auth_id",

            // Null should be interpreted as omitted for these properties
            NextUri = null,
        };

        model.Validate();
    }
}
