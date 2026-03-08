using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Tools;
using ArcadeDotnet.Models.Workers;

namespace ArcadeDotnet.Tests.Models.Workers;

public class WorkerToolsPageResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new WorkerToolsPageResponse
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
                    Metadata = new()
                    {
                        Behavior = new()
                        {
                            Destructive = true,
                            Idempotent = true,
                            OpenWorld = true,
                            Operations = ["string"],
                            ReadOnly = true,
                        },
                        Classification = new() { ServiceDomains = ["string"] },
                        Extras = new Dictionary<string, JsonElement>()
                        {
                            { "foo", JsonSerializer.SerializeToElement("bar") },
                        },
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
                Metadata = new()
                {
                    Behavior = new()
                    {
                        Destructive = true,
                        Idempotent = true,
                        OpenWorld = true,
                        Operations = ["string"],
                        ReadOnly = true,
                    },
                    Classification = new() { ServiceDomains = ["string"] },
                    Extras = new Dictionary<string, JsonElement>()
                    {
                        { "foo", JsonSerializer.SerializeToElement("bar") },
                    },
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

        Assert.NotNull(model.Items);
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
        var model = new WorkerToolsPageResponse
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
                    Metadata = new()
                    {
                        Behavior = new()
                        {
                            Destructive = true,
                            Idempotent = true,
                            OpenWorld = true,
                            Operations = ["string"],
                            ReadOnly = true,
                        },
                        Classification = new() { ServiceDomains = ["string"] },
                        Extras = new Dictionary<string, JsonElement>()
                        {
                            { "foo", JsonSerializer.SerializeToElement("bar") },
                        },
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

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<WorkerToolsPageResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new WorkerToolsPageResponse
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
                    Metadata = new()
                    {
                        Behavior = new()
                        {
                            Destructive = true,
                            Idempotent = true,
                            OpenWorld = true,
                            Operations = ["string"],
                            ReadOnly = true,
                        },
                        Classification = new() { ServiceDomains = ["string"] },
                        Extras = new Dictionary<string, JsonElement>()
                        {
                            { "foo", JsonSerializer.SerializeToElement("bar") },
                        },
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

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<WorkerToolsPageResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

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
                Metadata = new()
                {
                    Behavior = new()
                    {
                        Destructive = true,
                        Idempotent = true,
                        OpenWorld = true,
                        Operations = ["string"],
                        ReadOnly = true,
                    },
                    Classification = new() { ServiceDomains = ["string"] },
                    Extras = new Dictionary<string, JsonElement>()
                    {
                        { "foo", JsonSerializer.SerializeToElement("bar") },
                    },
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

        Assert.NotNull(deserialized.Items);
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
        var model = new WorkerToolsPageResponse
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
                    Metadata = new()
                    {
                        Behavior = new()
                        {
                            Destructive = true,
                            Idempotent = true,
                            OpenWorld = true,
                            Operations = ["string"],
                            ReadOnly = true,
                        },
                        Classification = new() { ServiceDomains = ["string"] },
                        Extras = new Dictionary<string, JsonElement>()
                        {
                            { "foo", JsonSerializer.SerializeToElement("bar") },
                        },
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

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new WorkerToolsPageResponse { };

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
        var model = new WorkerToolsPageResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new WorkerToolsPageResponse
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
        var model = new WorkerToolsPageResponse
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

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new WorkerToolsPageResponse
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
                    Metadata = new()
                    {
                        Behavior = new()
                        {
                            Destructive = true,
                            Idempotent = true,
                            OpenWorld = true,
                            Operations = ["string"],
                            ReadOnly = true,
                        },
                        Classification = new() { ServiceDomains = ["string"] },
                        Extras = new Dictionary<string, JsonElement>()
                        {
                            { "foo", JsonSerializer.SerializeToElement("bar") },
                        },
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

        WorkerToolsPageResponse copied = new(model);

        Assert.Equal(model, copied);
    }
}
