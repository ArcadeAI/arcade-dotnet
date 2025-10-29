using System.Net.Http;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Admin.AuthProviders;

namespace ArcadeDotnet.Services.Admin.AuthProviders;

public sealed class AuthProviderService : IAuthProviderService
{
    readonly IArcadeClient _client;

    public AuthProviderService(IArcadeClient client)
    {
        _client = client;
    }

    public async Task<AuthProviderResponse> Create(AuthProviderCreateParams parameters)
    {
        HttpRequest<AuthProviderCreateParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<AuthProviderResponse>().ConfigureAwait(false);
    }

    public async Task<AuthProviderListResponse> List(AuthProviderListParams? parameters = null)
    {
        parameters ??= new();

        HttpRequest<AuthProviderListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<AuthProviderListResponse>().ConfigureAwait(false);
    }

    public async Task<AuthProviderResponse> Delete(AuthProviderDeleteParams parameters)
    {
        HttpRequest<AuthProviderDeleteParams> request = new()
        {
            Method = HttpMethod.Delete,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<AuthProviderResponse>().ConfigureAwait(false);
    }

    public async Task<AuthProviderResponse> Get(AuthProviderGetParams parameters)
    {
        HttpRequest<AuthProviderGetParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<AuthProviderResponse>().ConfigureAwait(false);
    }

    public async Task<AuthProviderResponse> Patch(AuthProviderPatchParams parameters)
    {
        HttpRequest<AuthProviderPatchParams> request = new()
        {
            Method = HttpMethod.Patch,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<AuthProviderResponse>().ConfigureAwait(false);
    }
}
