using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using ArcadeDotnet.Models.Admin.AuthProviders;

namespace ArcadeDotnet.Services.Admin;

/// <inheritdoc/>
public sealed class AuthProviderService : IAuthProviderService
{
    readonly Lazy<IAuthProviderServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IAuthProviderServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly IArcadeClient _client;

    /// <inheritdoc/>
    public IAuthProviderService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new AuthProviderService(this._client.WithOptions(modifier));
    }

    public AuthProviderService(IArcadeClient client)
    {
        _client = client;

        _withRawResponse = new(() =>
            new AuthProviderServiceWithRawResponse(client.WithRawResponse)
        );
    }

    /// <inheritdoc/>
    public async Task<AuthProviderResponse> Create(
        AuthProviderCreateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Create(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<AuthProviderListResponse> List(
        AuthProviderListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.List(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<AuthProviderResponse> Delete(
        AuthProviderDeleteParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Delete(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<AuthProviderResponse> Delete(
        string id,
        AuthProviderDeleteParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Delete(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<AuthProviderResponse> Get(
        AuthProviderGetParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Get(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<AuthProviderResponse> Get(
        string id,
        AuthProviderGetParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Get(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<AuthProviderResponse> Patch(
        AuthProviderPatchParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Patch(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<AuthProviderResponse> Patch(
        string id,
        AuthProviderPatchParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Patch(parameters with { ID = id }, cancellationToken);
    }
}

/// <inheritdoc/>
public sealed class AuthProviderServiceWithRawResponse : IAuthProviderServiceWithRawResponse
{
    readonly IArcadeClientWithRawResponse _client;

    /// <inheritdoc/>
    public IAuthProviderServiceWithRawResponse WithOptions(
        Func<ClientOptions, ClientOptions> modifier
    )
    {
        return new AuthProviderServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public AuthProviderServiceWithRawResponse(IArcadeClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<AuthProviderResponse>> Create(
        AuthProviderCreateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<AuthProviderCreateParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var authProviderResponse = await response
                    .Deserialize<AuthProviderResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    authProviderResponse.Validate();
                }
                return authProviderResponse;
            }
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<AuthProviderListResponse>> List(
        AuthProviderListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<AuthProviderListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var authProviders = await response
                    .Deserialize<AuthProviderListResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    authProviders.Validate();
                }
                return authProviders;
            }
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<AuthProviderResponse>> Delete(
        AuthProviderDeleteParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new ArcadeInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<AuthProviderDeleteParams> request = new()
        {
            Method = HttpMethod.Delete,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var authProviderResponse = await response
                    .Deserialize<AuthProviderResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    authProviderResponse.Validate();
                }
                return authProviderResponse;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<AuthProviderResponse>> Delete(
        string id,
        AuthProviderDeleteParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Delete(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<AuthProviderResponse>> Get(
        AuthProviderGetParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new ArcadeInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<AuthProviderGetParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var authProviderResponse = await response
                    .Deserialize<AuthProviderResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    authProviderResponse.Validate();
                }
                return authProviderResponse;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<AuthProviderResponse>> Get(
        string id,
        AuthProviderGetParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Get(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<AuthProviderResponse>> Patch(
        AuthProviderPatchParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new ArcadeInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<AuthProviderPatchParams> request = new()
        {
            Method = ArcadeClient.PatchMethod,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var authProviderResponse = await response
                    .Deserialize<AuthProviderResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    authProviderResponse.Validate();
                }
                return authProviderResponse;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<AuthProviderResponse>> Patch(
        string id,
        AuthProviderPatchParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Patch(parameters with { ID = id }, cancellationToken);
    }
}
