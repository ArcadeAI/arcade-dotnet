using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Admin.AuthProviders;

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

    public async Task<AuthProviderResponse> Create(
        AuthProviderCreateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<AuthProviderCreateParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var authProviderResponse = await response
            .Deserialize<AuthProviderResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            authProviderResponse.Validate();
        }
        return authProviderResponse;
    }

    public async Task<AuthProviderListResponse> List(
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
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var authProviders = await response
            .Deserialize<AuthProviderListResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            authProviders.Validate();
        }
        return authProviders;
    }

    public async Task<AuthProviderResponse> Delete(
        AuthProviderDeleteParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<AuthProviderDeleteParams> request = new()
        {
            Method = HttpMethod.Delete,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var authProviderResponse = await response
            .Deserialize<AuthProviderResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            authProviderResponse.Validate();
        }
        return authProviderResponse;
    }

    public async Task<AuthProviderResponse> Get(
        AuthProviderGetParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<AuthProviderGetParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var authProviderResponse = await response
            .Deserialize<AuthProviderResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            authProviderResponse.Validate();
        }
        return authProviderResponse;
    }

    public async Task<AuthProviderResponse> Patch(
        AuthProviderPatchParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<AuthProviderPatchParams> request = new()
        {
            Method = HttpMethod.Patch,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var authProviderResponse = await response
            .Deserialize<AuthProviderResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            authProviderResponse.Validate();
        }
        return authProviderResponse;
    }
}
