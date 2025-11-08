using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using AuthProviders = ArcadeDotnet.Models.Admin.AuthProviders;

namespace ArcadeDotnet.Services.Admin.AuthProviders;

public sealed class AuthProviderService : IAuthProviderService
{
    public IAuthProviderService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new AuthProviderService(this._client.WithOptions(modifier));
    }

    readonly IArcadeClient _client;

    public AuthProviderService(IArcadeClient client)
    {
        _client = client;
    }

    public async Task<AuthProviders::AuthProviderResponse> Create(
        AuthProviders::AuthProviderCreateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<AuthProviders::AuthProviderCreateParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var authProviderResponse = await response
            .Deserialize<AuthProviders::AuthProviderResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            authProviderResponse.Validate();
        }
        return authProviderResponse;
    }

    public async Task<AuthProviders::AuthProviderListResponse> List(
        AuthProviders::AuthProviderListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<AuthProviders::AuthProviderListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var authProviders = await response
            .Deserialize<AuthProviders::AuthProviderListResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            authProviders.Validate();
        }
        return authProviders;
    }

    public async Task<AuthProviders::AuthProviderResponse> Delete(
        AuthProviders::AuthProviderDeleteParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<AuthProviders::AuthProviderDeleteParams> request = new()
        {
            Method = HttpMethod.Delete,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var authProviderResponse = await response
            .Deserialize<AuthProviders::AuthProviderResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            authProviderResponse.Validate();
        }
        return authProviderResponse;
    }

    public async Task<AuthProviders::AuthProviderResponse> Get(
        AuthProviders::AuthProviderGetParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<AuthProviders::AuthProviderGetParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var authProviderResponse = await response
            .Deserialize<AuthProviders::AuthProviderResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            authProviderResponse.Validate();
        }
        return authProviderResponse;
    }

    public async Task<AuthProviders::AuthProviderResponse> Patch(
        AuthProviders::AuthProviderPatchParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<AuthProviders::AuthProviderPatchParams> request = new()
        {
            Method = HttpMethod.Patch,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var authProviderResponse = await response
            .Deserialize<AuthProviders::AuthProviderResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            authProviderResponse.Validate();
        }
        return authProviderResponse;
    }
}
