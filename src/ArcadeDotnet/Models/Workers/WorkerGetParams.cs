using System;
using System.Net.Http;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Workers;

/// <summary>
/// Get a worker by ID
/// </summary>
public sealed record class WorkerGetParams : ParamsBase
{
    public required string ID;

    public override Uri Url(IArcadeClient client)
    {
        return new UriBuilder(
            client.BaseUrl.ToString().TrimEnd('/') + string.Format("/v1/workers/{0}", this.ID)
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
