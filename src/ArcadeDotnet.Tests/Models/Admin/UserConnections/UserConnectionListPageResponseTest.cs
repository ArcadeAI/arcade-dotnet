using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Models.Admin.UserConnections;

namespace ArcadeDotnet.Tests.Models.Admin.UserConnections;

public class UserConnectionListPageResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new UserConnectionListPageResponse
        {
            Items =
            [
                new()
                {
                    ID = "id",
                    ConnectionID = "connection_id",
                    ConnectionStatus = "connection_status",
                    ProviderDescription = "provider_description",
                    ProviderID = "provider_id",
                    ProviderType = "provider_type",
                    ProviderUserInfo = JsonSerializer.Deserialize<JsonElement>("{}"),
                    Scopes = ["string"],
                    UserID = "user_id",
                },
            ],
            Limit = 0,
            Offset = 0,
            PageCount = 0,
            TotalCount = 0,
        };

        List<UserConnectionResponse> expectedItems =
        [
            new()
            {
                ID = "id",
                ConnectionID = "connection_id",
                ConnectionStatus = "connection_status",
                ProviderDescription = "provider_description",
                ProviderID = "provider_id",
                ProviderType = "provider_type",
                ProviderUserInfo = JsonSerializer.Deserialize<JsonElement>("{}"),
                Scopes = ["string"],
                UserID = "user_id",
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
