using System;
using System.Net.Http;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Admin.UserConnections;

namespace ArcadeDotnet.Services.Admin.UserConnections;

public sealed class UserConnectionService : IUserConnectionService
{
    private readonly IArcadeClient _client;

    /// <summary>
    /// Initializes a new instance of the <see cref="UserConnectionService"/> class.
    /// </summary>
    /// <param name="client">The Arcade client instance.</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="client"/> is null.</exception>
    public UserConnectionService(IArcadeClient client)
    {
        ArgumentNullException.ThrowIfNull(client);
        _client = client;
    }

    public async Task<UserConnectionListPageResponse> List(
        UserConnectionListParams? parameters = null
    )
    {
        parameters ??= new();
        var request = new ArcadeRequest<UserConnectionListParams>(HttpMethod.Get, parameters);
        using var response = await _client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<UserConnectionListPageResponse>().ConfigureAwait(false);
    }

    public async Task Delete(UserConnectionDeleteParams parameters)
    {
        var request = new ArcadeRequest<UserConnectionDeleteParams>(HttpMethod.Delete, parameters);
        using var response = await _client.Execute(request).ConfigureAwait(false);
    }
}
