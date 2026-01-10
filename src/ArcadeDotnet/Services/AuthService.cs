using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models;
using ArcadeDotnet.Models.Auth;

namespace ArcadeDotnet.Services;

/// <inheritdoc/>
public sealed class AuthService : IAuthService
{
    readonly Lazy<IAuthServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IAuthServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly IArcadeClient _client;

    /// <inheritdoc/>
    public IAuthService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new AuthService(this._client.WithOptions(modifier));
    }

    public AuthService(IArcadeClient client)
    {
        _client = client;

        _withRawResponse = new(() => new AuthServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<AuthorizationResponse> Authorize(
        AuthAuthorizeParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Authorize(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<ConfirmUserResponse> ConfirmUser(
        AuthConfirmUserParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.ConfirmUser(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<AuthorizationResponse> Status(
        AuthStatusParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Status(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }
}

/// <inheritdoc/>
public sealed class AuthServiceWithRawResponse : IAuthServiceWithRawResponse
{
    readonly IArcadeClientWithRawResponse _client;

    /// <inheritdoc/>
    public IAuthServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new AuthServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public AuthServiceWithRawResponse(IArcadeClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<AuthorizationResponse>> Authorize(
        AuthAuthorizeParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<AuthAuthorizeParams> request = new()
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
    public async Task<HttpResponse<ConfirmUserResponse>> ConfirmUser(
        AuthConfirmUserParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<AuthConfirmUserParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var confirmUserResponse = await response
                    .Deserialize<ConfirmUserResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    confirmUserResponse.Validate();
                }
                return confirmUserResponse;
            }
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<AuthorizationResponse>> Status(
        AuthStatusParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<AuthStatusParams> request = new()
        {
            Method = HttpMethod.Get,
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
}
