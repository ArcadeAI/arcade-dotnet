using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using Workers = ArcadeDotnet.Models.Workers;

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

    public async Task<Workers::WorkerResponse> Create(
        Workers::WorkerCreateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<Workers::WorkerCreateParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var workerResponse = await response
            .Deserialize<Workers::WorkerResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            workerResponse.Validate();
        }
        return workerResponse;
    }

    public async Task<Workers::WorkerResponse> Update(
        Workers::WorkerUpdateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<Workers::WorkerUpdateParams> request = new()
        {
            Method = HttpMethod.Patch,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var workerResponse = await response
            .Deserialize<Workers::WorkerResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            workerResponse.Validate();
        }
        return workerResponse;
    }

    public async Task<Workers::WorkerListPageResponse> List(
        Workers::WorkerListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<Workers::WorkerListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var page = await response
            .Deserialize<Workers::WorkerListPageResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            page.Validate();
        }
        return page;
    }

    public async Task Delete(
        Workers::WorkerDeleteParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<Workers::WorkerDeleteParams> request = new()
        {
            Method = HttpMethod.Delete,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Workers::WorkerResponse> Get(
        Workers::WorkerGetParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<Workers::WorkerGetParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var workerResponse = await response
            .Deserialize<Workers::WorkerResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            workerResponse.Validate();
        }
        return workerResponse;
    }

    public async Task<Workers::WorkerHealthResponse> Health(
        Workers::WorkerHealthParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<Workers::WorkerHealthParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var workerHealthResponse = await response
            .Deserialize<Workers::WorkerHealthResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            workerHealthResponse.Validate();
        }
        return workerHealthResponse;
    }

    public async Task<Workers::WorkerToolsPageResponse> Tools(
        Workers::WorkerToolsParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<Workers::WorkerToolsParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var page = await response
            .Deserialize<Workers::WorkerToolsPageResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            page.Validate();
        }
        return page;
    }
}
