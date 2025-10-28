using System;
using System.Net.Http;
using ArcadeEngine.Core;

namespace ArcadeEngine.Models.Admin.Secrets;

/// <summary>
/// List all secrets that are visible to the caller
/// </summary>
public sealed record class SecretListParams : ParamsBase
{
    public override Uri Url(IArcadeClient client)
    {
        return new UriBuilder(client.BaseUrl.ToString().TrimEnd('/') + "/v1/admin/secrets")
        {
            Query = this.QueryString(client),
        }.Uri;
    }

    internal override void AddHeadersToRequest(HttpRequestMessage request, IArcadeClient client)
    {
        ParamsBase.AddDefaultHeaders(request, client);
        foreach (var item in this.HeaderProperties)
        {
            ParamsBase.AddHeaderElementToRequest(request, item.Key, item.Value);
        }
    }
}
