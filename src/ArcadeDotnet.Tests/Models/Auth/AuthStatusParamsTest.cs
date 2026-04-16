using System;
using ArcadeDotnet.Models.Auth;

namespace ArcadeDotnet.Tests.Models.Auth;

public class AuthStatusParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new AuthStatusParams { ID = "id", Wait = 0 };

        string expectedID = "id";
        long expectedWait = 0;

        Assert.Equal(expectedID, parameters.ID);
        Assert.Equal(expectedWait, parameters.Wait);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new AuthStatusParams { ID = "id" };

        Assert.Null(parameters.Wait);
        Assert.False(parameters.RawQueryData.ContainsKey("wait"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new AuthStatusParams
        {
            ID = "id",

            // Null should be interpreted as omitted for these properties
            Wait = null,
        };

        Assert.Null(parameters.Wait);
        Assert.False(parameters.RawQueryData.ContainsKey("wait"));
    }

    [Fact]
    public void Url_Works()
    {
        AuthStatusParams parameters = new() { ID = "id", Wait = 0 };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.True(
            TestBase.UrisEqual(new Uri("https://api.arcade.dev/v1/auth/status?id=id&wait=0"), url)
        );
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var parameters = new AuthStatusParams { ID = "id", Wait = 0 };

        AuthStatusParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}
