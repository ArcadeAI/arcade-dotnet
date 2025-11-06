using System.Net.Http;
using ArcadeDotnet.Core;
using System = System;

namespace ArcadeDotnet.Models.Admin.Secrets;

/// <summary>
/// List all secrets that are visible to the caller
/// </summary>
public sealed record class SecretListParams : ParamsBase
{
    public override System::Uri Url(IArcadeClient client)
    {
        return new System::UriBuilder(client.BaseUrl.ToString().TrimEnd('/') + "/v1/admin/secrets")
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
