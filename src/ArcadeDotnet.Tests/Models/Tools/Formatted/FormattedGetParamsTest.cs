using System;
using ArcadeDotnet.Models.Tools.Formatted;

namespace ArcadeDotnet.Tests.Models.Tools.Formatted;

public class FormattedGetParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new FormattedGetParams
        {
            Name = "name",
            Format = "format",
            UserID = "user_id",
        };

        string expectedName = "name";
        string expectedFormat = "format";
        string expectedUserID = "user_id";

        Assert.Equal(expectedName, parameters.Name);
        Assert.Equal(expectedFormat, parameters.Format);
        Assert.Equal(expectedUserID, parameters.UserID);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new FormattedGetParams { Name = "name" };

        Assert.Null(parameters.Format);
        Assert.False(parameters.RawQueryData.ContainsKey("format"));
        Assert.Null(parameters.UserID);
        Assert.False(parameters.RawQueryData.ContainsKey("user_id"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new FormattedGetParams
        {
            Name = "name",

            // Null should be interpreted as omitted for these properties
            Format = null,
            UserID = null,
        };

        Assert.Null(parameters.Format);
        Assert.False(parameters.RawQueryData.ContainsKey("format"));
        Assert.Null(parameters.UserID);
        Assert.False(parameters.RawQueryData.ContainsKey("user_id"));
    }

    [Fact]
    public void Url_Works()
    {
        FormattedGetParams parameters = new()
        {
            Name = "name",
            Format = "format",
            UserID = "user_id",
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(
            new Uri("https://api.arcade.dev/v1/formatted_tools/name?format=format&user_id=user_id"),
            url
        );
    }
}
