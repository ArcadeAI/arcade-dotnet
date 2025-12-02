using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Models.Tools;

namespace ArcadeDotnet.Tests.Models.Tools;

public class ToolListPageResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ToolListPageResponse
        {
            Items =
            [
                new()
                {
                    FullyQualifiedName = "fully_qualified_name",
                    Input = new()
                    {
                        Parameters =
                        [
                            new()
                            {
                                Name = "name",
                                ValueSchema = new()
                                {
                                    ValType = "val_type",
                                    Enum = ["string"],
                                    InnerValType = "inner_val_type",
                                },
                                Description = "description",
                                Inferrable = true,
                                Required = true,
                            },
                        ],
                    },
                    Name = "name",
                    QualifiedName = "qualified_name",
                    Toolkit = new()
                    {
                        Name = "name",
                        Description = "description",
                        Version = "version",
                    },
                    Description = "description",
                    FormattedSchema = new Dictionary<string, JsonElement>()
                    {
                        { "foo", JsonSerializer.SerializeToElement("bar") },
                    },
                    Output = new()
                    {
                        AvailableModes = ["string"],
                        Description = "description",
                        ValueSchema = new()
                        {
                            ValType = "val_type",
                            Enum = ["string"],
                            InnerValType = "inner_val_type",
                        },
                    },
                    Requirements = new()
                    {
                        Authorization = new()
                        {
                            ID = "id",
                            Oauth2 = new() { Scopes = ["string"] },
                            ProviderID = "provider_id",
                            ProviderType = "provider_type",
                            Status = Status.Active,
                            StatusReason = "status_reason",
                            TokenStatus = TokenStatus.NotStarted,
                        },
                        Met = true,
                        Secrets =
                        [
                            new()
                            {
                                Key = "key",
                                Met = true,
                                StatusReason = "status_reason",
                            },
                        ],
                    },
                },
            ],
            Limit = 0,
            Offset = 0,
            PageCount = 0,
            TotalCount = 0,
        };

        List<ToolDefinition> expectedItems =
        [
            new()
            {
                FullyQualifiedName = "fully_qualified_name",
                Input = new()
                {
                    Parameters =
                    [
                        new()
                        {
                            Name = "name",
                            ValueSchema = new()
                            {
                                ValType = "val_type",
                                Enum = ["string"],
                                InnerValType = "inner_val_type",
                            },
                            Description = "description",
                            Inferrable = true,
                            Required = true,
                        },
                    ],
                },
                Name = "name",
                QualifiedName = "qualified_name",
                Toolkit = new()
                {
                    Name = "name",
                    Description = "description",
                    Version = "version",
                },
                Description = "description",
                FormattedSchema = new Dictionary<string, JsonElement>()
                {
                    { "foo", JsonSerializer.SerializeToElement("bar") },
                },
                Output = new()
                {
                    AvailableModes = ["string"],
                    Description = "description",
                    ValueSchema = new()
                    {
                        ValType = "val_type",
                        Enum = ["string"],
                        InnerValType = "inner_val_type",
                    },
                },
                Requirements = new()
                {
                    Authorization = new()
                    {
                        ID = "id",
                        Oauth2 = new() { Scopes = ["string"] },
                        ProviderID = "provider_id",
                        ProviderType = "provider_type",
                        Status = Status.Active,
                        StatusReason = "status_reason",
                        TokenStatus = TokenStatus.NotStarted,
                    },
                    Met = true,
                    Secrets =
                    [
                        new()
                        {
                            Key = "key",
                            Met = true,
                            StatusReason = "status_reason",
                        },
                    ],
                },
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
