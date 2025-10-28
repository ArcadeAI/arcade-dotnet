using System;
using System.Net.Http;
using ArcadeEngine.Core;

namespace ArcadeEngine.Models.Workers;

/// <summary>
/// Get the health of a worker
/// </summary>
public sealed record class WorkerHealthParams : ParamsBase
{
    public required string ID;

    public override Uri Url(IArcadeClient client)
    {
        return new UriBuilder(
            client.BaseUrl.ToString().TrimEnd('/')
                + string.Format("/v1/workers/{0}/health", this.ID)
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
