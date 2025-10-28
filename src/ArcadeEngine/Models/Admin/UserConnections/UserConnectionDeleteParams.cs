using System;
using System.Net.Http;
using ArcadeEngine.Core;

namespace ArcadeEngine.Models.Admin.UserConnections;

/// <summary>
/// Delete a user/auth provider connection
/// </summary>
public sealed record class UserConnectionDeleteParams : ParamsBase
{
    public required string ID;

    public override Uri Url(IArcadeClient client)
    {
        return new UriBuilder(
            client.BaseUrl.ToString().TrimEnd('/')
                + string.Format("/v1/admin/user_connections/{0}", this.ID)
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
