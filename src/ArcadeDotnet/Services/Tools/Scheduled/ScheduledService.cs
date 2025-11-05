using System;
using System.Net.Http;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Tools.Scheduled;

namespace ArcadeDotnet.Services.Tools.Scheduled;

public sealed class ScheduledService : IScheduledService
{
    public IScheduledService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ScheduledService(this._client.WithOptions(modifier));
    }

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
        var page = await response.Deserialize<ScheduledListPageResponse>().ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            page.Validate();
        }
        return page;
    }

    public async Task<ScheduledGetResponse> Get(ScheduledGetParams parameters)
    {
        HttpRequest<ScheduledGetParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        var scheduled = await response.Deserialize<ScheduledGetResponse>().ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            scheduled.Validate();
        }
        return scheduled;
    }
}
