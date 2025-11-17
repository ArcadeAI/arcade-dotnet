using System;
using System.Net.Http;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Admin.AuthProviders;

namespace ArcadeDotnet.Services.Admin.AuthProviders;

public sealed class AuthProviderService : IAuthProviderService
{
    private readonly IArcadeClient _client;

    /// <summary>
    /// Initializes a new instance of the <see cref="AuthProviderService"/> class.
    /// </summary>
    /// <param name="client">The Arcade client instance.</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="client"/> is null.</exception>
    public AuthProviderService(IArcadeClient client)
    {
        ArgumentNullException.ThrowIfNull(client);
        _client = client;
    }

    public async Task<AuthProviderResponse> Create(AuthProviderCreateParams parameters)
    {
        var request = new ArcadeRequest<AuthProviderCreateParams>(HttpMethod.Post, parameters);
        using var response = await _client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<AuthProviderResponse>().ConfigureAwait(false);
    }

    public async Task<AuthProviderListResponse> List(AuthProviderListParams? parameters = null)
    {
        parameters ??= new();
        var request = new ArcadeRequest<AuthProviderListParams>(HttpMethod.Get, parameters);
        using var response = await _client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<AuthProviderListResponse>().ConfigureAwait(false);
    }

    public async Task<AuthProviderResponse> Delete(AuthProviderDeleteParams parameters)
    {
        var request = new ArcadeRequest<AuthProviderDeleteParams>(HttpMethod.Delete, parameters);
        using var response = await _client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<AuthProviderResponse>().ConfigureAwait(false);
    }

    public async Task<AuthProviderResponse> Get(AuthProviderGetParams parameters)
    {
        var request = new ArcadeRequest<AuthProviderGetParams>(HttpMethod.Get, parameters);
        using var response = await _client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<AuthProviderResponse>().ConfigureAwait(false);
    }

    public async Task<AuthProviderResponse> Patch(AuthProviderPatchParams parameters)
    {
        var request = new ArcadeRequest<AuthProviderPatchParams>(HttpMethod.Patch, parameters);
        using var response = await _client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<AuthProviderResponse>().ConfigureAwait(false);
    }
}
