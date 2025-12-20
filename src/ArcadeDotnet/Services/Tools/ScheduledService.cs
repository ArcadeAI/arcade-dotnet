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
    /// <inheritdoc/>
    public IScheduledService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ScheduledService(this._client.WithOptions(modifier));
    }

    readonly IArcadeClient _client;

    public ScheduledService(IArcadeClient client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<ScheduledListPage> List(
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
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var page = await response
            .Deserialize<ScheduledListPageResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            page.Validate();
        }
        return new ScheduledListPage(this, parameters, page);
    }

    /// <inheritdoc/>
    public async Task<ScheduledGetResponse> Get(
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
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var scheduled = await response
            .Deserialize<ScheduledGetResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            scheduled.Validate();
        }
        return scheduled;
    }

    /// <inheritdoc/>
    public async Task<ScheduledGetResponse> Get(
        string id,
        ScheduledGetParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return await this.Get(parameters with { ID = id }, cancellationToken);
    }
}
