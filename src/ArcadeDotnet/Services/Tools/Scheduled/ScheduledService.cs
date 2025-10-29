using System.Net.Http;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Tools.Scheduled;

namespace ArcadeDotnet.Services.Tools.Scheduled;

public sealed class ScheduledService : IScheduledService
{
    readonly IArcadeClient _client;

    public ScheduledService(IArcadeClient client)
    {
        _client = client;
    }

    public async Task<ScheduledListPageResponse> List(ScheduledListParams? parameters = null)
    {
        parameters ??= new();

        HttpRequest<ScheduledListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<ScheduledListPageResponse>().ConfigureAwait(false);
    }

    public async Task<ScheduledGetResponse> Get(ScheduledGetParams parameters)
    {
        HttpRequest<ScheduledGetParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<ScheduledGetResponse>().ConfigureAwait(false);
    }
}
