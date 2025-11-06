using System;
using System.Net.Http;
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

    public async Task<Workers::WorkerResponse> Create(Workers::WorkerCreateParams parameters)
    {
        HttpRequest<Workers::WorkerCreateParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        var workerResponse = await response
            .Deserialize<Workers::WorkerResponse>()
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            workerResponse.Validate();
        }
        return workerResponse;
    }

    public async Task<Workers::WorkerResponse> Update(Workers::WorkerUpdateParams parameters)
    {
        HttpRequest<Workers::WorkerUpdateParams> request = new()
        {
            Method = HttpMethod.Patch,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        var workerResponse = await response
            .Deserialize<Workers::WorkerResponse>()
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            workerResponse.Validate();
        }
        return workerResponse;
    }

    public async Task<Workers::WorkerListPageResponse> List(
        Workers::WorkerListParams? parameters = null
    )
    {
        parameters ??= new();

        HttpRequest<Workers::WorkerListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        var page = await response
            .Deserialize<Workers::WorkerListPageResponse>()
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            page.Validate();
        }
        return page;
    }

    public async Task Delete(Workers::WorkerDeleteParams parameters)
    {
        HttpRequest<Workers::WorkerDeleteParams> request = new()
        {
            Method = HttpMethod.Delete,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
    }

    public async Task<Workers::WorkerResponse> Get(Workers::WorkerGetParams parameters)
    {
        HttpRequest<Workers::WorkerGetParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        var workerResponse = await response
            .Deserialize<Workers::WorkerResponse>()
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            workerResponse.Validate();
        }
        return workerResponse;
    }

    public async Task<Workers::WorkerHealthResponse> Health(Workers::WorkerHealthParams parameters)
    {
        HttpRequest<Workers::WorkerHealthParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        var workerHealthResponse = await response
            .Deserialize<Workers::WorkerHealthResponse>()
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            workerHealthResponse.Validate();
        }
        return workerHealthResponse;
    }

    public async Task<Workers::WorkerToolsPageResponse> Tools(Workers::WorkerToolsParams parameters)
    {
        HttpRequest<Workers::WorkerToolsParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        var page = await response
            .Deserialize<Workers::WorkerToolsPageResponse>()
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            page.Validate();
        }
        return page;
    }
}
