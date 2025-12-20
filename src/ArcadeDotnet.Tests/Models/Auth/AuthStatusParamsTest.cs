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
}
