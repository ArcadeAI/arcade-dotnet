using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Models.Tools.Formatted;

namespace ArcadeDotnet.Tests.Models.Tools.Formatted;

public class FormattedListPageResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new FormattedListPageResponse
        {
            Items = [JsonSerializer.Deserialize<JsonElement>("{}")],
            Limit = 0,
            Offset = 0,
            PageCount = 0,
            TotalCount = 0,
        };

        List<JsonElement> expectedItems = [JsonSerializer.Deserialize<JsonElement>("{}")];
        long expectedLimit = 0;
        long expectedOffset = 0;
        long expectedPageCount = 0;
        long expectedTotalCount = 0;

        Assert.Equal(expectedItems.Count, model.Items.Count);
        for (int i = 0; i < expectedItems.Count; i++)
        {
            Assert.True(JsonElement.DeepEquals(expectedItems[i], model.Items[i]));
        }
        Assert.Equal(expectedLimit, model.Limit);
        Assert.Equal(expectedOffset, model.Offset);
        Assert.Equal(expectedPageCount, model.PageCount);
        Assert.Equal(expectedTotalCount, model.TotalCount);
    }
}
