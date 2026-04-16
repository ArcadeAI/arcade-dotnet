using System;
using ArcadeDotnet.Models.Admin.UserConnections;

namespace ArcadeDotnet.Tests.Models.Admin.UserConnections;

public class UserConnectionListParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new UserConnectionListParams
        {
            Limit = 0,
            Offset = 0,
            ProviderID = "provider_id",
            UserID = "user_id",
        };

        long expectedLimit = 0;
        long expectedOffset = 0;
        string expectedProviderID = "provider_id";
        string expectedUserID = "user_id";

        Assert.Equal(expectedLimit, parameters.Limit);
        Assert.Equal(expectedOffset, parameters.Offset);
        Assert.Equal(expectedProviderID, parameters.ProviderID);
        Assert.Equal(expectedUserID, parameters.UserID);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new UserConnectionListParams { };

        Assert.Null(parameters.Limit);
        Assert.False(parameters.RawQueryData.ContainsKey("limit"));
        Assert.Null(parameters.Offset);
        Assert.False(parameters.RawQueryData.ContainsKey("offset"));
        Assert.Null(parameters.ProviderID);
        Assert.False(parameters.RawQueryData.ContainsKey("provider_id"));
        Assert.Null(parameters.UserID);
        Assert.False(parameters.RawQueryData.ContainsKey("user_id"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new UserConnectionListParams
        {
            // Null should be interpreted as omitted for these properties
            Limit = null,
            Offset = null,
            ProviderID = null,
            UserID = null,
        };

        Assert.Null(parameters.Limit);
        Assert.False(parameters.RawQueryData.ContainsKey("limit"));
        Assert.Null(parameters.Offset);
        Assert.False(parameters.RawQueryData.ContainsKey("offset"));
        Assert.Null(parameters.ProviderID);
        Assert.False(parameters.RawQueryData.ContainsKey("provider_id"));
        Assert.Null(parameters.UserID);
        Assert.False(parameters.RawQueryData.ContainsKey("user_id"));
    }

    [Fact]
    public void Url_Works()
    {
        UserConnectionListParams parameters = new()
        {
            Limit = 0,
            Offset = 0,
            ProviderID = "provider_id",
            UserID = "user_id",
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.True(
            TestBase.UrisEqual(
                new Uri(
                    "https://api.arcade.dev/v1/admin/user_connections?limit=0&offset=0&provider_id=provider_id&user_id=user_id"
                ),
                url
            )
        );
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var parameters = new UserConnectionListParams
        {
            Limit = 0,
            Offset = 0,
            ProviderID = "provider_id",
            UserID = "user_id",
        };

        UserConnectionListParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}
