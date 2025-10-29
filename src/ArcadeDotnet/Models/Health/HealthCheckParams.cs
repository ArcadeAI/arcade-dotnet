using System;
using System.Net.Http;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Health;

/// <summary>
/// Check if Arcade Engine is healthy
/// </summary>
public sealed record class HealthCheckParams : ParamsBase
{
    public override Uri Url(IArcadeClient client)
    {
        return new UriBuilder(client.BaseUrl.ToString().TrimEnd('/') + "/v1/health")
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
