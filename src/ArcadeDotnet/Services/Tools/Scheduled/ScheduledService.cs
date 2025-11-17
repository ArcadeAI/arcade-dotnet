using System;
using System.Net.Http;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Tools.Scheduled;

namespace ArcadeDotnet.Services.Tools.Scheduled;

public sealed class ScheduledService : IScheduledService
{
    private readonly IArcadeClient _client;

    /// <summary>
    /// Initializes a new instance of the <see cref="ScheduledService"/> class.
    /// </summary>
    /// <param name="client">The Arcade client instance.</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="client"/> is null.</exception>
    public ScheduledService(IArcadeClient client)
    {
        ArgumentNullException.ThrowIfNull(client);
        _client = client;
    }

    public async Task<ScheduledListPageResponse> List(ScheduledListParams? parameters = null)
    {
        parameters ??= new();
        var request = new ArcadeRequest<ScheduledListParams>(HttpMethod.Get, parameters);
        using var response = await _client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<ScheduledListPageResponse>().ConfigureAwait(false);
    }

    public async Task<ScheduledGetResponse> Get(ScheduledGetParams parameters)
    {
        var request = new ArcadeRequest<ScheduledGetParams>(HttpMethod.Get, parameters);
        using var response = await _client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<ScheduledGetResponse>().ConfigureAwait(false);
    }
}
