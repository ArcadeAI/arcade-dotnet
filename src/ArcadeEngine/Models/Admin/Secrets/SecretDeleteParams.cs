using System;
using System.Net.Http;
using ArcadeEngine.Core;

namespace ArcadeEngine.Models.Admin.Secrets;

/// <summary>
/// Delete a secret by its ID
/// </summary>
public sealed record class SecretDeleteParams : ParamsBase
{
    public required string SecretID;

    public override Uri Url(IArcadeClient client)
    {
        return new UriBuilder(
            client.BaseUrl.ToString().TrimEnd('/')
                + string.Format("/v1/admin/secrets/{0}", this.SecretID)
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
