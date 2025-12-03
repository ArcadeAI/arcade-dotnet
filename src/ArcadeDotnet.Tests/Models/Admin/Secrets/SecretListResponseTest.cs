using System.Collections.Generic;
using System.Text.Json;
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

    [Fact]
    public void SerializationRoundtrip_Works()
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

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<SecretListResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
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

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<SecretListResponse>(json);
        Assert.NotNull(deserialized);

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

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new SecretListResponse { };

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
        var model = new SecretListResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new SecretListResponse
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
        var model = new SecretListResponse
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
