using ArcadeDotnet.Models.Tools.Scheduled;

namespace ArcadeDotnet.Tests.Models.Tools.Scheduled;

public class ScheduledListParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new ScheduledListParams { Limit = 0, Offset = 0 };

        long expectedLimit = 0;
        long expectedOffset = 0;

        Assert.Equal(expectedLimit, parameters.Limit);
        Assert.Equal(expectedOffset, parameters.Offset);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new ScheduledListParams { };

        Assert.Null(parameters.Limit);
        Assert.False(parameters.RawQueryData.ContainsKey("limit"));
        Assert.Null(parameters.Offset);
        Assert.False(parameters.RawQueryData.ContainsKey("offset"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new ScheduledListParams
        {
            // Null should be interpreted as omitted for these properties
            Limit = null,
            Offset = null,
        };

        Assert.Null(parameters.Limit);
        Assert.False(parameters.RawQueryData.ContainsKey("limit"));
        Assert.Null(parameters.Offset);
        Assert.False(parameters.RawQueryData.ContainsKey("offset"));
    }
}
