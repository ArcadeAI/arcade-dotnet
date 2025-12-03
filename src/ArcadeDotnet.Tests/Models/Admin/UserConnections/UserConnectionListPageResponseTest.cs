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

    [Fact]
    public void SerializationRoundtrip_Works()
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

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<UserConnectionListPageResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
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

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<UserConnectionListPageResponse>(json);
        Assert.NotNull(deserialized);

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

        Assert.Equal(expectedItems.Count, deserialized.Items.Count);
        for (int i = 0; i < expectedItems.Count; i++)
        {
            Assert.Equal(expectedItems[i], deserialized.Items[i]);
        }
        Assert.Equal(expectedLimit, deserialized.Limit);
        Assert.Equal(expectedOffset, deserialized.Offset);
        Assert.Equal(expectedPageCount, deserialized.PageCount);
        Assert.Equal(expectedTotalCount, deserialized.TotalCount);
    }

    [Fact]
    public void Validation_Works()
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

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new UserConnectionListPageResponse { };

        Assert.Null(model.Items);
        Assert.False(model.RawData.ContainsKey("items"));
        Assert.Null(model.Limit);
        Assert.False(model.RawData.ContainsKey("limit"));
        Assert.Null(model.Offset);
        Assert.False(model.RawData.ContainsKey("offset"));
        Assert.Null(model.PageCount);
        Assert.False(model.RawData.ContainsKey("page_count"));
        Assert.Null(model.TotalCount);
        Assert.False(model.RawData.ContainsKey("total_count"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new UserConnectionListPageResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new UserConnectionListPageResponse
        {
            // Null should be interpreted as omitted for these properties
            Items = null,
            Limit = null,
            Offset = null,
            PageCount = null,
            TotalCount = null,
        };

        Assert.Null(model.Items);
        Assert.False(model.RawData.ContainsKey("items"));
        Assert.Null(model.Limit);
        Assert.False(model.RawData.ContainsKey("limit"));
        Assert.Null(model.Offset);
        Assert.False(model.RawData.ContainsKey("offset"));
        Assert.Null(model.PageCount);
        Assert.False(model.RawData.ContainsKey("page_count"));
        Assert.Null(model.TotalCount);
        Assert.False(model.RawData.ContainsKey("total_count"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new UserConnectionListPageResponse
        {
            // Null should be interpreted as omitted for these properties
            Items = null,
            Limit = null,
            Offset = null,
            PageCount = null,
            TotalCount = null,
        };

        model.Validate();
    }
}
