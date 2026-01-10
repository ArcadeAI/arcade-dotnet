using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using ArcadeDotnet.Models.Admin.UserConnections;

namespace ArcadeDotnet.Services.Admin;

/// <inheritdoc/>
public sealed class UserConnectionService : IUserConnectionService
{
    readonly Lazy<IUserConnectionServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IUserConnectionServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly IArcadeClient _client;

    /// <inheritdoc/>
    public IUserConnectionService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new UserConnectionService(this._client.WithOptions(modifier));
    }

    public UserConnectionService(IArcadeClient client)
    {
        _client = client;

        _withRawResponse = new(() =>
            new UserConnectionServiceWithRawResponse(client.WithRawResponse)
        );
    }

    /// <inheritdoc/>
    public async Task<UserConnectionListPage> List(
        UserConnectionListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.List(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task Delete(
        UserConnectionDeleteParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Delete(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task Delete(
        string id,
        UserConnectionDeleteParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        await this.Delete(parameters with { ID = id }, cancellationToken).ConfigureAwait(false);
    }
}

/// <inheritdoc/>
public sealed class UserConnectionServiceWithRawResponse : IUserConnectionServiceWithRawResponse
{
    readonly IArcadeClientWithRawResponse _client;

    /// <inheritdoc/>
    public IUserConnectionServiceWithRawResponse WithOptions(
        Func<ClientOptions, ClientOptions> modifier
    )
    {
        return new UserConnectionServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public UserConnectionServiceWithRawResponse(IArcadeClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<UserConnectionListPage>> List(
        UserConnectionListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<UserConnectionListParams> request = new()
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
                    .Deserialize<UserConnectionListPageResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    page.Validate();
                }
                return new UserConnectionListPage(this, parameters, page);
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse> Delete(
        UserConnectionDeleteParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new ArcadeInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<UserConnectionDeleteParams> request = new()
        {
            Method = HttpMethod.Delete,
            Params = parameters,
        };
        return this._client.Execute(request, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<HttpResponse> Delete(
        string id,
        UserConnectionDeleteParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Delete(parameters with { ID = id }, cancellationToken);
    }
}
