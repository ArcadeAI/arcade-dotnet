using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using ArcadeDotnet.Models.Tools.Scheduled;

namespace ArcadeDotnet.Services.Tools;

/// <inheritdoc/>
public sealed class ScheduledService : IScheduledService
{
    readonly Lazy<IScheduledServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IScheduledServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly IArcadeClient _client;

    /// <inheritdoc/>
    public IScheduledService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ScheduledService(this._client.WithOptions(modifier));
    }

    public ScheduledService(IArcadeClient client)
    {
        _client = client;

        _withRawResponse = new(() => new ScheduledServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<ScheduledListPage> List(
        ScheduledListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.List(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<ScheduledGetResponse> Get(
        ScheduledGetParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Get(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<ScheduledGetResponse> Get(
        string id,
        ScheduledGetParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Get(parameters with { ID = id }, cancellationToken);
    }
}

/// <inheritdoc/>
public sealed class ScheduledServiceWithRawResponse : IScheduledServiceWithRawResponse
{
    readonly IArcadeClientWithRawResponse _client;

    /// <inheritdoc/>
    public IScheduledServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ScheduledServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public ScheduledServiceWithRawResponse(IArcadeClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<ScheduledListPage>> List(
        ScheduledListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<ScheduledListParams> request = new()
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
                    .Deserialize<ScheduledListPageResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    page.Validate();
                }
                return new ScheduledListPage(this, parameters, page);
            }
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<ScheduledGetResponse>> Get(
        ScheduledGetParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new ArcadeInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<ScheduledGetParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var scheduled = await response
                    .Deserialize<ScheduledGetResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    scheduled.Validate();
                }
                return scheduled;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<ScheduledGetResponse>> Get(
        string id,
        ScheduledGetParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Get(parameters with { ID = id }, cancellationToken);
    }
}
