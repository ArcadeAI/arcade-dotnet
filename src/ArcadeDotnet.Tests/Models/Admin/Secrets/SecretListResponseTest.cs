using System.Collections.Generic;
using ArcadeDotnet.Models.Admin.Secrets;

namespace ArcadeDotnet.Tests.Models.Admin.Secrets;

public class SecretListResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new SecretListResponse
        {
            Items =
            [
                new()
                {
                    ID = "id",
                    Binding = new() { ID = "id", Type = Type.Static },
                    CreatedAt = "created_at",
                    Description = "description",
                    Hint = "hint",
                    Key = "key",
                    LastAccessedAt = "last_accessed_at",
                    UpdatedAt = "updated_at",
                },
            ],
            Limit = 0,
            Offset = 0,
            PageCount = 0,
            TotalCount = 0,
        };

        List<SecretResponse> expectedItems =
        [
            new()
            {
                ID = "id",
                Binding = new() { ID = "id", Type = Type.Static },
                CreatedAt = "created_at",
                Description = "description",
                Hint = "hint",
                Key = "key",
                LastAccessedAt = "last_accessed_at",
                UpdatedAt = "updated_at",
            },
        ];
        long expectedLimit = 0;
        long expectedOffset = 0;
        long expectedPageCount = 0;
        long expectedTotalCount = 0;

        Assert.Equal(expectedItems.Count, model.Items.Count);
        for (int i = 0; i < expectedItems.Count; i++)
        {
            Assert.Equal(expectedItems[i], model.Items[i]);
        }
        Assert.Equal(expectedLimit, model.Limit);
        Assert.Equal(expectedOffset, model.Offset);
        Assert.Equal(expectedPageCount, model.PageCount);
        Assert.Equal(expectedTotalCount, model.TotalCount);
    }
}
