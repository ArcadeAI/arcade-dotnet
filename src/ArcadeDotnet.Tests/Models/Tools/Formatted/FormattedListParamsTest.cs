using System;
using ArcadeDotnet.Models.Tools.Formatted;

namespace ArcadeDotnet.Tests.Models.Tools.Formatted;

public class FormattedListParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new FormattedListParams
        {
            Format = "format",
            IncludeAllVersions = true,
            Limit = 0,
            Offset = 0,
            Toolkit = "toolkit",
            UserID = "user_id",
        };

        string expectedFormat = "format";
        bool expectedIncludeAllVersions = true;
        long expectedLimit = 0;
        long expectedOffset = 0;
        string expectedToolkit = "toolkit";
        string expectedUserID = "user_id";

        Assert.Equal(expectedFormat, parameters.Format);
        Assert.Equal(expectedIncludeAllVersions, parameters.IncludeAllVersions);
        Assert.Equal(expectedLimit, parameters.Limit);
        Assert.Equal(expectedOffset, parameters.Offset);
        Assert.Equal(expectedToolkit, parameters.Toolkit);
        Assert.Equal(expectedUserID, parameters.UserID);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new FormattedListParams { };

        Assert.Null(parameters.Format);
        Assert.False(parameters.RawQueryData.ContainsKey("format"));
        Assert.Null(parameters.IncludeAllVersions);
        Assert.False(parameters.RawQueryData.ContainsKey("include_all_versions"));
        Assert.Null(parameters.Limit);
        Assert.False(parameters.RawQueryData.ContainsKey("limit"));
        Assert.Null(parameters.Offset);
        Assert.False(parameters.RawQueryData.ContainsKey("offset"));
        Assert.Null(parameters.Toolkit);
        Assert.False(parameters.RawQueryData.ContainsKey("toolkit"));
        Assert.Null(parameters.UserID);
        Assert.False(parameters.RawQueryData.ContainsKey("user_id"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new FormattedListParams
        {
            // Null should be interpreted as omitted for these properties
            Format = null,
            IncludeAllVersions = null,
            Limit = null,
            Offset = null,
            Toolkit = null,
            UserID = null,
        };

        Assert.Null(parameters.Format);
        Assert.False(parameters.RawQueryData.ContainsKey("format"));
        Assert.Null(parameters.IncludeAllVersions);
        Assert.False(parameters.RawQueryData.ContainsKey("include_all_versions"));
        Assert.Null(parameters.Limit);
        Assert.False(parameters.RawQueryData.ContainsKey("limit"));
        Assert.Null(parameters.Offset);
        Assert.False(parameters.RawQueryData.ContainsKey("offset"));
        Assert.Null(parameters.Toolkit);
        Assert.False(parameters.RawQueryData.ContainsKey("toolkit"));
        Assert.Null(parameters.UserID);
        Assert.False(parameters.RawQueryData.ContainsKey("user_id"));
    }

    [Fact]
    public void Url_Works()
    {
        FormattedListParams parameters = new()
        {
            Format = "format",
            IncludeAllVersions = true,
            Limit = 0,
            Offset = 0,
            Toolkit = "toolkit",
            UserID = "user_id",
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(
            new Uri(
                "https://api.arcade.dev/v1/formatted_tools?format=format&include_all_versions=true&limit=0&offset=0&toolkit=toolkit&user_id=user_id"
            ),
            url
        );
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var parameters = new FormattedListParams
        {
            Format = "format",
            IncludeAllVersions = true,
            Limit = 0,
            Offset = 0,
            Toolkit = "toolkit",
            UserID = "user_id",
        };

        FormattedListParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}
