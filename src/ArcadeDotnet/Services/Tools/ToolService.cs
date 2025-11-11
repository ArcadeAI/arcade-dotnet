using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models;
using ArcadeDotnet.Models.Tools;
using ArcadeDotnet.Services.Tools.Formatted;
using ArcadeDotnet.Services.Tools.Scheduled;

namespace ArcadeDotnet.Services.Tools;

public sealed class ToolService : IToolService
{
    public IToolService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ToolService(this._client.WithOptions(modifier));
    }

    readonly IArcadeClient _client;

    public ToolService(IArcadeClient client)
    {
        _client = client;
        _scheduled = new(() => new ScheduledService(client));
        _formatted = new(() => new FormattedService(client));
    }

    readonly Lazy<IScheduledService> _scheduled;
    public IScheduledService Scheduled
    {
        get { return _scheduled.Value; }
    }

    readonly Lazy<IFormattedService> _formatted;
    public IFormattedService Formatted
    {
        get { return _formatted.Value; }
    }

    public async Task<ToolListPageResponse> List(
        ToolListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<ToolListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var page = await response
            .Deserialize<ToolListPageResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            page.Validate();
        }
        return page;
    }

    public async Task<AuthorizationResponse> Authorize(
        ToolAuthorizeParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<ToolAuthorizeParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var authorizationResponse = await response
            .Deserialize<AuthorizationResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            authorizationResponse.Validate();
        }
        return authorizationResponse;
    }

    public async Task<ExecuteToolResponse> Execute(
        ToolExecuteParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<ToolExecuteParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var executeToolResponse = await response
            .Deserialize<ExecuteToolResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            executeToolResponse.Validate();
        }
        return executeToolResponse;
    }

    public async Task<ToolDefinition> Get(
        ToolGetParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<ToolGetParams> request = new() { Method = HttpMethod.Get, Params = parameters };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var toolDefinition = await response
            .Deserialize<ToolDefinition>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            toolDefinition.Validate();
        }
        return toolDefinition;
    }
}
