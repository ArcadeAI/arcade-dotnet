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
}
