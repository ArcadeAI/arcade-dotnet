using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Models.Workers;

namespace ArcadeDotnet.Tests.Models.Workers;

public class WorkerListPageResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new WorkerListPageResponse
        {
            Items =
            [
                new()
                {
                    ID = "id",
                    Binding = new() { ID = "id", Type = Type.Static },
                    Enabled = true,
                    HTTP = new()
                    {
                        Retry = 0,
                        Secret = new()
                        {
                            Binding = SecretBinding.Static,
                            Editable = true,
                            Exists = true,
                            Hint = "hint",
                            Value = "value",
                        },
                        Timeout = 0,
                        Uri = "uri",
                    },
                    Managed = true,
                    Mcp = new()
                    {
                        Headers = new Dictionary<string, string>() { { "foo", "string" } },
                        Oauth2 = new()
                        {
                            AuthorizationURL = "authorization_url",
                            ClientID = "client_id",
                            ClientSecret = new()
                            {
                                Binding = ClientSecretBinding.Static,
                                Editable = true,
                                Exists = true,
                                Hint = "hint",
                                Value = "value",
                            },
                            RedirectUri = "redirect_uri",
                        },
                        Retry = 0,
                        Secrets = new Dictionary<string, SecretsItem>()
                        {
                            {
                                "foo",
                                new()
                                {
                                    Binding = SecretsItemBinding.Static,
                                    Editable = true,
                                    Exists = true,
                                    Hint = "hint",
                                    Value = "value",
                                }
                            },
                        },
                        Timeout = 0,
                        Uri = "uri",
                    },
                    Requirements = new()
                    {
                        Authorization = new()
                        {
                            Met = true,
                            Oauth2 = new() { Met = true },
                        },
                        Met = true,
                    },
                    Type = WorkerResponseType.HTTP,
                },
            ],
            Limit = 0,
            Offset = 0,
            PageCount = 0,
            TotalCount = 0,
        };

        List<WorkerResponse> expectedItems =
        [
            new()
            {
                ID = "id",
                Binding = new() { ID = "id", Type = Type.Static },
                Enabled = true,
                HTTP = new()
                {
                    Retry = 0,
                    Secret = new()
                    {
                        Binding = SecretBinding.Static,
                        Editable = true,
                        Exists = true,
                        Hint = "hint",
                        Value = "value",
                    },
                    Timeout = 0,
                    Uri = "uri",
                },
                Managed = true,
                Mcp = new()
                {
                    Headers = new Dictionary<string, string>() { { "foo", "string" } },
                    Oauth2 = new()
                    {
                        AuthorizationURL = "authorization_url",
                        ClientID = "client_id",
                        ClientSecret = new()
                        {
                            Binding = ClientSecretBinding.Static,
                            Editable = true,
                            Exists = true,
                            Hint = "hint",
                            Value = "value",
                        },
                        RedirectUri = "redirect_uri",
                    },
                    Retry = 0,
                    Secrets = new Dictionary<string, SecretsItem>()
                    {
                        {
                            "foo",
                            new()
                            {
                                Binding = SecretsItemBinding.Static,
                                Editable = true,
                                Exists = true,
                                Hint = "hint",
                                Value = "value",
                            }
                        },
                    },
                    Timeout = 0,
                    Uri = "uri",
                },
                Requirements = new()
                {
                    Authorization = new()
                    {
                        Met = true,
                        Oauth2 = new() { Met = true },
                    },
                    Met = true,
                },
                Type = WorkerResponseType.HTTP,
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
        var model = new WorkerListPageResponse
        {
            Items =
            [
                new()
                {
                    ID = "id",
                    Binding = new() { ID = "id", Type = Type.Static },
                    Enabled = true,
                    HTTP = new()
                    {
                        Retry = 0,
                        Secret = new()
                        {
                            Binding = SecretBinding.Static,
                            Editable = true,
                            Exists = true,
                            Hint = "hint",
                            Value = "value",
                        },
                        Timeout = 0,
                        Uri = "uri",
                    },
                    Managed = true,
                    Mcp = new()
                    {
                        Headers = new Dictionary<string, string>() { { "foo", "string" } },
                        Oauth2 = new()
                        {
                            AuthorizationURL = "authorization_url",
                            ClientID = "client_id",
                            ClientSecret = new()
                            {
                                Binding = ClientSecretBinding.Static,
                                Editable = true,
                                Exists = true,
                                Hint = "hint",
                                Value = "value",
                            },
                            RedirectUri = "redirect_uri",
                        },
                        Retry = 0,
                        Secrets = new Dictionary<string, SecretsItem>()
                        {
                            {
                                "foo",
                                new()
                                {
                                    Binding = SecretsItemBinding.Static,
                                    Editable = true,
                                    Exists = true,
                                    Hint = "hint",
                                    Value = "value",
                                }
                            },
                        },
                        Timeout = 0,
                        Uri = "uri",
                    },
                    Requirements = new()
                    {
                        Authorization = new()
                        {
                            Met = true,
                            Oauth2 = new() { Met = true },
                        },
                        Met = true,
                    },
                    Type = WorkerResponseType.HTTP,
                },
            ],
            Limit = 0,
            Offset = 0,
            PageCount = 0,
            TotalCount = 0,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<WorkerListPageResponse>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new WorkerListPageResponse
        {
            Items =
            [
                new()
                {
                    ID = "id",
                    Binding = new() { ID = "id", Type = Type.Static },
                    Enabled = true,
                    HTTP = new()
                    {
                        Retry = 0,
                        Secret = new()
                        {
                            Binding = SecretBinding.Static,
                            Editable = true,
                            Exists = true,
                            Hint = "hint",
                            Value = "value",
                        },
                        Timeout = 0,
                        Uri = "uri",
                    },
                    Managed = true,
                    Mcp = new()
                    {
                        Headers = new Dictionary<string, string>() { { "foo", "string" } },
                        Oauth2 = new()
                        {
                            AuthorizationURL = "authorization_url",
                            ClientID = "client_id",
                            ClientSecret = new()
                            {
                                Binding = ClientSecretBinding.Static,
                                Editable = true,
                                Exists = true,
                                Hint = "hint",
                                Value = "value",
                            },
                            RedirectUri = "redirect_uri",
                        },
                        Retry = 0,
                        Secrets = new Dictionary<string, SecretsItem>()
                        {
                            {
                                "foo",
                                new()
                                {
                                    Binding = SecretsItemBinding.Static,
                                    Editable = true,
                                    Exists = true,
                                    Hint = "hint",
                                    Value = "value",
                                }
                            },
                        },
                        Timeout = 0,
                        Uri = "uri",
                    },
                    Requirements = new()
                    {
                        Authorization = new()
                        {
                            Met = true,
                            Oauth2 = new() { Met = true },
                        },
                        Met = true,
                    },
                    Type = WorkerResponseType.HTTP,
                },
            ],
            Limit = 0,
            Offset = 0,
            PageCount = 0,
            TotalCount = 0,
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<WorkerListPageResponse>(json);
        Assert.NotNull(deserialized);

        List<WorkerResponse> expectedItems =
        [
            new()
            {
                ID = "id",
                Binding = new() { ID = "id", Type = Type.Static },
                Enabled = true,
                HTTP = new()
                {
                    Retry = 0,
                    Secret = new()
                    {
                        Binding = SecretBinding.Static,
                        Editable = true,
                        Exists = true,
                        Hint = "hint",
                        Value = "value",
                    },
                    Timeout = 0,
                    Uri = "uri",
                },
                Managed = true,
                Mcp = new()
                {
                    Headers = new Dictionary<string, string>() { { "foo", "string" } },
                    Oauth2 = new()
                    {
                        AuthorizationURL = "authorization_url",
                        ClientID = "client_id",
                        ClientSecret = new()
                        {
                            Binding = ClientSecretBinding.Static,
                            Editable = true,
                            Exists = true,
                            Hint = "hint",
                            Value = "value",
                        },
                        RedirectUri = "redirect_uri",
                    },
                    Retry = 0,
                    Secrets = new Dictionary<string, SecretsItem>()
                    {
                        {
                            "foo",
                            new()
                            {
                                Binding = SecretsItemBinding.Static,
                                Editable = true,
                                Exists = true,
                                Hint = "hint",
                                Value = "value",
                            }
                        },
                    },
                    Timeout = 0,
                    Uri = "uri",
                },
                Requirements = new()
                {
                    Authorization = new()
                    {
                        Met = true,
                        Oauth2 = new() { Met = true },
                    },
                    Met = true,
                },
                Type = WorkerResponseType.HTTP,
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
        var model = new WorkerListPageResponse
        {
            Items =
            [
                new()
                {
                    ID = "id",
                    Binding = new() { ID = "id", Type = Type.Static },
                    Enabled = true,
                    HTTP = new()
                    {
                        Retry = 0,
                        Secret = new()
                        {
                            Binding = SecretBinding.Static,
                            Editable = true,
                            Exists = true,
                            Hint = "hint",
                            Value = "value",
                        },
                        Timeout = 0,
                        Uri = "uri",
                    },
                    Managed = true,
                    Mcp = new()
                    {
                        Headers = new Dictionary<string, string>() { { "foo", "string" } },
                        Oauth2 = new()
                        {
                            AuthorizationURL = "authorization_url",
                            ClientID = "client_id",
                            ClientSecret = new()
                            {
                                Binding = ClientSecretBinding.Static,
                                Editable = true,
                                Exists = true,
                                Hint = "hint",
                                Value = "value",
                            },
                            RedirectUri = "redirect_uri",
                        },
                        Retry = 0,
                        Secrets = new Dictionary<string, SecretsItem>()
                        {
                            {
                                "foo",
                                new()
                                {
                                    Binding = SecretsItemBinding.Static,
                                    Editable = true,
                                    Exists = true,
                                    Hint = "hint",
                                    Value = "value",
                                }
                            },
                        },
                        Timeout = 0,
                        Uri = "uri",
                    },
                    Requirements = new()
                    {
                        Authorization = new()
                        {
                            Met = true,
                            Oauth2 = new() { Met = true },
                        },
                        Met = true,
                    },
                    Type = WorkerResponseType.HTTP,
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
        var model = new WorkerListPageResponse { };

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
        var model = new WorkerListPageResponse { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new WorkerListPageResponse
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
        var model = new WorkerListPageResponse
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
