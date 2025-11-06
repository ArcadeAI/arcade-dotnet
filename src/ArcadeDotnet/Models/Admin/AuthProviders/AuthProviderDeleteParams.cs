using System.Net.Http;
using ArcadeDotnet.Core;
using System = System;

namespace ArcadeDotnet.Models.Admin.AuthProviders;

/// <summary>
/// Delete a specific auth provider
/// </summary>
public sealed record class AuthProviderDeleteParams : ParamsBase
{
    public required string ID;

    public override System::Uri Url(IArcadeClient client)
    {
        return new System::UriBuilder(
            client.BaseUrl.ToString().TrimEnd('/')
                + string.Format("/v1/admin/auth_providers/{0}", this.ID)
        )
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
