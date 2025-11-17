using System;
using System.Net.Http;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Workers;

namespace ArcadeDotnet.Services.Workers;

public sealed class WorkerService : IWorkerService
{
    private readonly IArcadeClient _client;

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkerService"/> class.
    /// </summary>
    /// <param name="client">The Arcade client instance.</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="client"/> is null.</exception>
    public WorkerService(IArcadeClient client)
    {
        ArgumentNullException.ThrowIfNull(client);
        _client = client;
    }

    public async Task<WorkerResponse> Create(WorkerCreateParams parameters)
    {
        var request = new ArcadeRequest<WorkerCreateParams>(HttpMethod.Post, parameters);
        using var response = await _client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<WorkerResponse>().ConfigureAwait(false);
    }

    public async Task<WorkerResponse> Update(WorkerUpdateParams parameters)
    {
        var request = new ArcadeRequest<WorkerUpdateParams>(HttpMethod.Patch, parameters);
        using var response = await _client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<WorkerResponse>().ConfigureAwait(false);
    }

    public async Task<WorkerListPageResponse> List(WorkerListParams? parameters = null)
    {
        parameters ??= new();
        var request = new ArcadeRequest<WorkerListParams>(HttpMethod.Get, parameters);
        using var response = await _client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<WorkerListPageResponse>().ConfigureAwait(false);
    }

    public async Task Delete(WorkerDeleteParams parameters)
    {
        var request = new ArcadeRequest<WorkerDeleteParams>(HttpMethod.Delete, parameters);
        using var response = await _client.Execute(request).ConfigureAwait(false);
    }

    public async Task<WorkerResponse> Get(WorkerGetParams parameters)
    {
        var request = new ArcadeRequest<WorkerGetParams>(HttpMethod.Get, parameters);
        using var response = await _client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<WorkerResponse>().ConfigureAwait(false);
    }

    public async Task<WorkerHealthResponse> Health(WorkerHealthParams parameters)
    {
        var request = new ArcadeRequest<WorkerHealthParams>(HttpMethod.Get, parameters);
        using var response = await _client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<WorkerHealthResponse>().ConfigureAwait(false);
    }

    public async Task<WorkerToolsPageResponse> Tools(WorkerToolsParams parameters)
    {
        var request = new ArcadeRequest<WorkerToolsParams>(HttpMethod.Get, parameters);
        using var response = await _client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<WorkerToolsPageResponse>().ConfigureAwait(false);
    }
}
