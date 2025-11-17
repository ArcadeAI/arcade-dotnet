using System;
using System.Net.Http;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Admin.Secrets;

namespace ArcadeDotnet.Services.Admin.Secrets;

public sealed class SecretService : ISecretService
{
    private readonly IArcadeClient _client;

    /// <summary>
    /// Initializes a new instance of the <see cref="SecretService"/> class.
    /// </summary>
    /// <param name="client">The Arcade client instance.</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="client"/> is null.</exception>
    public SecretService(IArcadeClient client)
    {
        ArgumentNullException.ThrowIfNull(client);
        _client = client;
    }

    public async Task<SecretListResponse> List(SecretListParams? parameters = null)
    {
        parameters ??= new();
        var request = new ArcadeRequest<SecretListParams>(HttpMethod.Get, parameters);
        using var response = await _client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<SecretListResponse>().ConfigureAwait(false);
    }

    public async Task Delete(SecretDeleteParams parameters)
    {
        var request = new ArcadeRequest<SecretDeleteParams>(HttpMethod.Delete, parameters);
        using var response = await _client.Execute(request).ConfigureAwait(false);
    }
}
