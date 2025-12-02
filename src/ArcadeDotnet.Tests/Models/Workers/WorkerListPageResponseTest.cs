using System.Collections.Generic;
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
}
