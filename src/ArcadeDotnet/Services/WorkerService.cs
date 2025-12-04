using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using ArcadeDotnet.Models.Workers;

namespace ArcadeDotnet.Services;

/// <inheritdoc/>
public sealed class WorkerService : IWorkerService
{
    /// <inheritdoc/>
    public IWorkerService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new WorkerService(this._client.WithOptions(modifier));
    }

    readonly IArcadeClient _client;

    public WorkerService(IArcadeClient client)
    {
        _client = client;
    }

    /// <inheritdoc/>
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

    /// <inheritdoc/>
    public async Task<WorkerResponse> Update(
        WorkerUpdateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new ArcadeInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<WorkerUpdateParams> request = new()
        {
            Method = ArcadeClient.PatchMethod,
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

    /// <inheritdoc/>
    public async Task<WorkerResponse> Update(
        string id,
        WorkerUpdateParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return await this.Update(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
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

    /// <inheritdoc/>
    public async Task Delete(
        WorkerDeleteParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new ArcadeInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<WorkerDeleteParams> request = new()
        {
            Method = HttpMethod.Delete,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task Delete(
        string id,
        WorkerDeleteParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        await this.Delete(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<WorkerResponse> Get(
        WorkerGetParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new ArcadeInvalidDataException("'parameters.ID' cannot be null");
        }

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

    /// <inheritdoc/>
    public async Task<WorkerResponse> Get(
        string id,
        WorkerGetParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return await this.Get(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<WorkerHealthResponse> Health(
        WorkerHealthParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new ArcadeInvalidDataException("'parameters.ID' cannot be null");
        }

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

    /// <inheritdoc/>
    public async Task<WorkerHealthResponse> Health(
        string id,
        WorkerHealthParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return await this.Health(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<WorkerToolsPageResponse> Tools(
        WorkerToolsParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new ArcadeInvalidDataException("'parameters.ID' cannot be null");
        }

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

    /// <inheritdoc/>
    public async Task<WorkerToolsPageResponse> Tools(
        string id,
        WorkerToolsParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return await this.Tools(parameters with { ID = id }, cancellationToken);
    }
}
