using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models;
using ArcadeDotnet.Models.Auth;

namespace ArcadeDotnet.Services;

public sealed class AuthService : IAuthService
{
    public IAuthService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new AuthService(this._client.WithOptions(modifier));
    }

    readonly IArcadeClient _client;

    public AuthService(IArcadeClient client)
    {
        _client = client;
    }

    public async Task<AuthorizationResponse> Authorize(
        AuthAuthorizeParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<AuthAuthorizeParams> request = new()
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

    public async Task<ConfirmUserResponse> ConfirmUser(
        AuthConfirmUserParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<AuthConfirmUserParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var confirmUserResponse = await response
            .Deserialize<ConfirmUserResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            confirmUserResponse.Validate();
        }
        return confirmUserResponse;
    }

    public async Task<AuthorizationResponse> Status(
        AuthStatusParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<AuthStatusParams> request = new()
        {
            Method = HttpMethod.Get,
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
}
