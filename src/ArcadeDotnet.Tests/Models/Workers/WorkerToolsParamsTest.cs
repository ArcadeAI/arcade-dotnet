using ArcadeDotnet.Models.Workers;

namespace ArcadeDotnet.Tests.Models.Workers;

public class WorkerToolsParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new WorkerToolsParams
        {
            ID = "id",
            Limit = 0,
            Offset = 0,
        };

        string expectedID = "id";
        long expectedLimit = 0;
        long expectedOffset = 0;

        Assert.Equal(expectedID, parameters.ID);
        Assert.Equal(expectedLimit, parameters.Limit);
        Assert.Equal(expectedOffset, parameters.Offset);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new WorkerToolsParams { ID = "id" };

        Assert.Null(parameters.Limit);
        Assert.False(parameters.RawQueryData.ContainsKey("limit"));
        Assert.Null(parameters.Offset);
        Assert.False(parameters.RawQueryData.ContainsKey("offset"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new WorkerToolsParams
        {
            ID = "id",

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
