using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Workers;

namespace ArcadeDotnet.Services.Workers;

public sealed class WorkerService : IWorkerService
{
    public IWorkerService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new WorkerService(this._client.WithOptions(modifier));
    }

    readonly IArcadeClient _client;

    public WorkerService(IArcadeClient client)
    {
        _client = client;
    }

    public async Task<WorkerResponse> Create(
        WorkerCreateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<WorkerCreateParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var workerResponse = await response
            .Deserialize<WorkerResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            workerResponse.Validate();
        }
        return workerResponse;
    }

    public async Task<WorkerResponse> Update(
        WorkerUpdateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<WorkerUpdateParams> request = new()
        {
            Method = HttpMethod.Patch,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var workerResponse = await response
            .Deserialize<WorkerResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            workerResponse.Validate();
        }
        return workerResponse;
    }

    public async Task<WorkerListPageResponse> List(
        WorkerListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<WorkerListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var page = await response
            .Deserialize<WorkerListPageResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            page.Validate();
        }
        return page;
    }

    public async Task Delete(
        WorkerDeleteParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<WorkerDeleteParams> request = new()
        {
            Method = HttpMethod.Delete,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<WorkerResponse> Get(
        WorkerGetParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<WorkerGetParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var workerResponse = await response
            .Deserialize<WorkerResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            workerResponse.Validate();
        }
        return workerResponse;
    }

    public async Task<WorkerHealthResponse> Health(
        WorkerHealthParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<WorkerHealthParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var workerHealthResponse = await response
            .Deserialize<WorkerHealthResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            workerHealthResponse.Validate();
        }
        return workerHealthResponse;
    }

    public async Task<WorkerToolsPageResponse> Tools(
        WorkerToolsParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<WorkerToolsParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var page = await response
            .Deserialize<WorkerToolsPageResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            page.Validate();
        }
        return page;
    }
}
