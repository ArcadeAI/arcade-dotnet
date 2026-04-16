using System;
using ArcadeDotnet.Models.Workers;

namespace ArcadeDotnet.Tests.Models.Workers;

public class WorkerDeleteParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new WorkerDeleteParams { ID = "id" };

        string expectedID = "id";

        Assert.Equal(expectedID, parameters.ID);
    }

    [Fact]
    public void Url_Works()
    {
        WorkerDeleteParams parameters = new() { ID = "id" };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.True(TestBase.UrisEqual(new Uri("https://api.arcade.dev/v1/workers/id"), url));
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var parameters = new WorkerDeleteParams { ID = "id" };

        WorkerDeleteParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}
