using System;
using ArcadeDotnet.Models.Tools.Scheduled;

namespace ArcadeDotnet.Tests.Models.Tools.Scheduled;

public class ScheduledGetParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new ScheduledGetParams { ID = "id" };

        string expectedID = "id";

        Assert.Equal(expectedID, parameters.ID);
    }

    [Fact]
    public void Url_Works()
    {
        ScheduledGetParams parameters = new() { ID = "id" };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(new Uri("https://api.arcade.dev/v1/scheduled_tools/id"), url);
    }
}
