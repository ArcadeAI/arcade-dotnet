using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using ArcadeDotnet.Models;
using ArcadeDotnet.Models.Tools;
using ArcadeDotnet.Services.Tools;

namespace ArcadeDotnet.Services;

/// <inheritdoc/>
public sealed class ToolService : IToolService
{
    readonly Lazy<IToolServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IToolServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly IArcadeClient _client;

    /// <inheritdoc/>
    public IToolService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ToolService(this._client.WithOptions(modifier));
    }

    public ToolService(IArcadeClient client)
    {
        _client = client;

        _withRawResponse = new(() => new ToolServiceWithRawResponse(client.WithRawResponse));
        _formatted = new(() => new FormattedService(client));
    }

    readonly Lazy<IFormattedService> _formatted;
    public IFormattedService Formatted
    {
        get { return _formatted.Value; }
    }

    /// <inheritdoc/>
    public async Task<ToolListPage> List(
        ToolListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.List(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<AuthorizationResponse> Authorize(
        ToolAuthorizeParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Authorize(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<ExecuteToolResponse> Execute(
        ToolExecuteParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Execute(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<ToolDefinition> Get(
        ToolGetParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Get(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<ToolDefinition> Get(
        string name,
        ToolGetParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Get(parameters with { Name = name }, cancellationToken);
    }
}

/// <inheritdoc/>
public sealed class ToolServiceWithRawResponse : IToolServiceWithRawResponse
{
    readonly IArcadeClientWithRawResponse _client;

    /// <inheritdoc/>
    public IToolServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ToolServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public ToolServiceWithRawResponse(IArcadeClientWithRawResponse client)
    {
        _client = client;

        _formatted = new(() => new FormattedServiceWithRawResponse(client));
    }

    readonly Lazy<IFormattedServiceWithRawResponse> _formatted;
    public IFormattedServiceWithRawResponse Formatted
    {
        get { return _formatted.Value; }
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<ToolListPage>> List(
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
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var page = await response
                    .Deserialize<ToolListPageResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    page.Validate();
                }
                return new ToolListPage(this, parameters, page);
            }
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<AuthorizationResponse>> Authorize(
        ToolAuthorizeParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<ToolAuthorizeParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var authorizationResponse = await response
                    .Deserialize<AuthorizationResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    authorizationResponse.Validate();
                }
                return authorizationResponse;
            }
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<ExecuteToolResponse>> Execute(
        ToolExecuteParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<ToolExecuteParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var executeToolResponse = await response
                    .Deserialize<ExecuteToolResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    executeToolResponse.Validate();
                }
                return executeToolResponse;
            }
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<ToolDefinition>> Get(
        ToolGetParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.Name == null)
        {
            throw new ArcadeInvalidDataException("'parameters.Name' cannot be null");
        }

        HttpRequest<ToolGetParams> request = new() { Method = HttpMethod.Get, Params = parameters };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var toolDefinition = await response
                    .Deserialize<ToolDefinition>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    toolDefinition.Validate();
                }
                return toolDefinition;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<ToolDefinition>> Get(
        string name,
        ToolGetParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Get(parameters with { Name = name }, cancellationToken);
    }
}
