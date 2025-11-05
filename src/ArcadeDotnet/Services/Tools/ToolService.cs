using System;
using System.Net.Http;
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

    public async Task<ToolListPageResponse> List(ToolListParams? parameters = null)
    {
        parameters ??= new();

        HttpRequest<ToolListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        var page = await response.Deserialize<ToolListPageResponse>().ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            page.Validate();
        }
        return page;
    }

    public async Task<AuthorizationResponse> Authorize(ToolAuthorizeParams parameters)
    {
        HttpRequest<ToolAuthorizeParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        var authorizationResponse = await response
            .Deserialize<AuthorizationResponse>()
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            authorizationResponse.Validate();
        }
        return authorizationResponse;
    }

    public async Task<ExecuteToolResponse> Execute(ToolExecuteParams parameters)
    {
        HttpRequest<ToolExecuteParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        var executeToolResponse = await response
            .Deserialize<ExecuteToolResponse>()
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            executeToolResponse.Validate();
        }
        return executeToolResponse;
    }

    public async Task<ToolDefinition> Get(ToolGetParams parameters)
    {
        HttpRequest<ToolGetParams> request = new() { Method = HttpMethod.Get, Params = parameters };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        var toolDefinition = await response.Deserialize<ToolDefinition>().ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            toolDefinition.Validate();
        }
        return toolDefinition;
    }
}
