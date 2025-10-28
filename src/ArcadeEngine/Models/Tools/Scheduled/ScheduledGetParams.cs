using System;
using System.Net.Http;
using ArcadeEngine.Core;

namespace ArcadeEngine.Models.Tools.Scheduled;

/// <summary>
/// Returns the details for a specific scheduled tool execution
/// </summary>
public sealed record class ScheduledGetParams : ParamsBase
{
    public required string ID;

    public override Uri Url(IArcadeClient client)
    {
        return new UriBuilder(
            client.BaseUrl.ToString().TrimEnd('/')
                + string.Format("/v1/scheduled_tools/{0}", this.ID)
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
