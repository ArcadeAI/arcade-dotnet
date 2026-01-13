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
    readonly Lazy<IWorkerServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IWorkerServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly IArcadeClient _client;

    /// <inheritdoc/>
    public IWorkerService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new WorkerService(this._client.WithOptions(modifier));
    }

    public WorkerService(IArcadeClient client)
    {
        _client = client;

        _withRawResponse = new(() => new WorkerServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<WorkerResponse> Create(
        WorkerCreateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Create(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<WorkerResponse> Update(
        WorkerUpdateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Update(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<WorkerResponse> Update(
        string id,
        WorkerUpdateParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Update(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<WorkerListPage> List(
        WorkerListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.List(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task Delete(WorkerDeleteParams parameters, CancellationToken cancellationToken = default)
    {
        return this.WithRawResponse.Delete(parameters, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task Delete(
        string id,
        WorkerDeleteParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        await this.Delete(parameters with { ID = id }, cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<WorkerResponse> Get(
        WorkerGetParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Get(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<WorkerResponse> Get(
        string id,
        WorkerGetParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Get(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<WorkerHealthResponse> Health(
        WorkerHealthParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Health(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<WorkerHealthResponse> Health(
        string id,
        WorkerHealthParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Health(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<WorkerToolsPage> Tools(
        WorkerToolsParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Tools(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<WorkerToolsPage> Tools(
        string id,
        WorkerToolsParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Tools(parameters with { ID = id }, cancellationToken);
    }
}

/// <inheritdoc/>
public sealed class WorkerServiceWithRawResponse : IWorkerServiceWithRawResponse
{
    readonly IArcadeClientWithRawResponse _client;

    /// <inheritdoc/>
    public IWorkerServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new WorkerServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public WorkerServiceWithRawResponse(IArcadeClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<WorkerResponse>> Create(
        WorkerCreateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<WorkerCreateParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var workerResponse = await response
                    .Deserialize<WorkerResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    workerResponse.Validate();
                }
                return workerResponse;
            }
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<WorkerResponse>> Update(
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
            Method = ArcadeClientWithRawResponse.PatchMethod,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var workerResponse = await response
                    .Deserialize<WorkerResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    workerResponse.Validate();
                }
                return workerResponse;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<WorkerResponse>> Update(
        string id,
        WorkerUpdateParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Update(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<WorkerListPage>> List(
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
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var page = await response
                    .Deserialize<WorkerListPageResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    page.Validate();
                }
                return new WorkerListPage(this, parameters, page);
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse> Delete(
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
        return this._client.Execute(request, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<HttpResponse> Delete(
        string id,
        WorkerDeleteParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Delete(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<WorkerResponse>> Get(
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
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var workerResponse = await response
                    .Deserialize<WorkerResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    workerResponse.Validate();
                }
                return workerResponse;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<WorkerResponse>> Get(
        string id,
        WorkerGetParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Get(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<WorkerHealthResponse>> Health(
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
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var workerHealthResponse = await response
                    .Deserialize<WorkerHealthResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    workerHealthResponse.Validate();
                }
                return workerHealthResponse;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<WorkerHealthResponse>> Health(
        string id,
        WorkerHealthParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Health(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<WorkerToolsPage>> Tools(
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
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var page = await response
                    .Deserialize<WorkerToolsPageResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    page.Validate();
                }
                return new WorkerToolsPage(this, parameters, page);
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<WorkerToolsPage>> Tools(
        string id,
        WorkerToolsParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Tools(parameters with { ID = id }, cancellationToken);
    }
}
