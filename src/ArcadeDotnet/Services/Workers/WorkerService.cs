using System.Net.Http;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Workers;

namespace ArcadeDotnet.Services.Workers;

public sealed class WorkerService : IWorkerService
{
    readonly IArcadeClient _client;

    public WorkerService(IArcadeClient client)
    {
        _client = client;
    }

    public async Task<WorkerResponse> Create(WorkerCreateParams parameters)
    {
        HttpRequest<WorkerCreateParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<WorkerResponse>().ConfigureAwait(false);
    }

    public async Task<WorkerResponse> Update(WorkerUpdateParams parameters)
    {
        HttpRequest<WorkerUpdateParams> request = new()
        {
            Method = HttpMethod.Patch,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<WorkerResponse>().ConfigureAwait(false);
    }

    public async Task<WorkerListPageResponse> List(WorkerListParams? parameters = null)
    {
        parameters ??= new();

        HttpRequest<WorkerListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<WorkerListPageResponse>().ConfigureAwait(false);
    }

    public async Task Delete(WorkerDeleteParams parameters)
    {
        HttpRequest<WorkerDeleteParams> request = new()
        {
            Method = HttpMethod.Delete,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        return;
    }

    public async Task<WorkerResponse> Get(WorkerGetParams parameters)
    {
        HttpRequest<WorkerGetParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<WorkerResponse>().ConfigureAwait(false);
    }

    public async Task<WorkerHealthResponse> Health(WorkerHealthParams parameters)
    {
        HttpRequest<WorkerHealthParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<WorkerHealthResponse>().ConfigureAwait(false);
    }

    public async Task<WorkerToolsPageResponse> Tools(WorkerToolsParams parameters)
    {
        HttpRequest<WorkerToolsParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<WorkerToolsPageResponse>().ConfigureAwait(false);
    }
}
