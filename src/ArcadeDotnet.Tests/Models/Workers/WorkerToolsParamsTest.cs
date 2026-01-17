using System;
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

    [Fact]
    public void Url_Works()
    {
        WorkerToolsParams parameters = new()
        {
            ID = "id",
            Limit = 0,
            Offset = 0,
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(new Uri("https://api.arcade.dev/v1/workers/id/tools?limit=0&offset=0"), url);
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var parameters = new WorkerToolsParams
        {
            ID = "id",
            Limit = 0,
            Offset = 0,
        };

        WorkerToolsParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}
