using System;
using ArcadeDotnet.Models.Admin.UserConnections;

namespace ArcadeDotnet.Tests.Models.Admin.UserConnections;

public class UserConnectionDeleteParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new UserConnectionDeleteParams { ID = "id" };

        string expectedID = "id";

        Assert.Equal(expectedID, parameters.ID);
    }

    [Fact]
    public void Url_Works()
    {
        UserConnectionDeleteParams parameters = new() { ID = "id" };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(new Uri("https://api.arcade.dev/v1/admin/user_connections/id"), url);
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var parameters = new UserConnectionDeleteParams { ID = "id" };

        UserConnectionDeleteParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}
