using System;
using System.Net.Http;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Admin.AuthProviders;

/// <summary>
/// List a page of auth providers that are available to the caller
/// </summary>
public sealed record class AuthProviderListParams : ParamsBase
{
    public override Uri Url(IArcadeClient client)
    {
        return new UriBuilder(client.BaseUrl.ToString().TrimEnd('/') + "/v1/admin/auth_providers")
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
