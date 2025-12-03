using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Models;

namespace ArcadeDotnet.Tests.Models;

public class AuthorizationContextTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthorizationContext
        {
            Token = "token",
            UserInfo = new Dictionary<string, JsonElement>()
            {
                { "foo", JsonSerializer.SerializeToElement("bar") },
            },
        };

        string expectedToken = "token";
        Dictionary<string, JsonElement> expectedUserInfo = new()
        {
            { "foo", JsonSerializer.SerializeToElement("bar") },
        };

        Assert.Equal(expectedToken, model.Token);
        Assert.Equal(expectedUserInfo.Count, model.UserInfo.Count);
        foreach (var item in expectedUserInfo)
        {
            Assert.True(model.UserInfo.TryGetValue(item.Key, out var value));

            Assert.True(JsonElement.DeepEquals(value, model.UserInfo[item.Key]));
        }
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AuthorizationContext
        {
            Token = "token",
            UserInfo = new Dictionary<string, JsonElement>()
            {
                { "foo", JsonSerializer.SerializeToElement("bar") },
            },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthorizationContext>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AuthorizationContext
        {
            Token = "token",
            UserInfo = new Dictionary<string, JsonElement>()
            {
                { "foo", JsonSerializer.SerializeToElement("bar") },
            },
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthorizationContext>(json);
        Assert.NotNull(deserialized);

        string expectedToken = "token";
        Dictionary<string, JsonElement> expectedUserInfo = new()
        {
            { "foo", JsonSerializer.SerializeToElement("bar") },
        };

        Assert.Equal(expectedToken, deserialized.Token);
        Assert.Equal(expectedUserInfo.Count, deserialized.UserInfo.Count);
        foreach (var item in expectedUserInfo)
        {
            Assert.True(deserialized.UserInfo.TryGetValue(item.Key, out var value));

            Assert.True(JsonElement.DeepEquals(value, deserialized.UserInfo[item.Key]));
        }
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AuthorizationContext
        {
            Token = "token",
            UserInfo = new Dictionary<string, JsonElement>()
            {
                { "foo", JsonSerializer.SerializeToElement("bar") },
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthorizationContext { };

        Assert.Null(model.Token);
        Assert.False(model.RawData.ContainsKey("token"));
        Assert.Null(model.UserInfo);
        Assert.False(model.RawData.ContainsKey("user_info"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AuthorizationContext { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthorizationContext
        {
            // Null should be interpreted as omitted for these properties
            Token = null,
            UserInfo = null,
        };

        Assert.Null(model.Token);
        Assert.False(model.RawData.ContainsKey("token"));
        Assert.Null(model.UserInfo);
        Assert.False(model.RawData.ContainsKey("user_info"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new AuthorizationContext
        {
            // Null should be interpreted as omitted for these properties
            Token = null,
            UserInfo = null,
        };

        model.Validate();
    }
}
