using System;
using System.Net.Http;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models;
using ArcadeDotnet.Models.Auth;

namespace ArcadeDotnet.Services.Auth;

/// <summary>
/// Service for handling authentication and authorization operations.
/// </summary>
public sealed class AuthService : IAuthService
{
    private readonly IArcadeClient _client;

    /// <summary>
    /// Initializes a new instance of the <see cref="AuthService"/> class.
    /// </summary>
    /// <param name="client">The Arcade client instance.</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="client"/> is null.</exception>
    public AuthService(IArcadeClient client)
    {
        ArgumentNullException.ThrowIfNull(client);
        _client = client;
    }

    /// <summary>
    /// Starts the authorization process.
    /// </summary>
    /// <param name="parameters">The authorization parameters.</param>
    /// <returns>The authorization response.</returns>
    public async Task<AuthorizationResponse> Authorize(AuthAuthorizeParams parameters)
    {
        var request = new ArcadeRequest<AuthAuthorizeParams>(HttpMethod.Post, parameters);
        using var response = await _client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<AuthorizationResponse>().ConfigureAwait(false);
    }

    /// <summary>
    /// Confirms a user's details during authorization.
    /// </summary>
    /// <param name="parameters">The confirmation parameters.</param>
    /// <returns>The confirmation response.</returns>
    public async Task<ConfirmUserResponse> ConfirmUser(AuthConfirmUserParams parameters)
    {
        var request = new ArcadeRequest<AuthConfirmUserParams>(HttpMethod.Post, parameters);
        using var response = await _client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<ConfirmUserResponse>().ConfigureAwait(false);
    }

    /// <summary>
    /// Checks the authorization status.
    /// </summary>
    /// <param name="parameters">The status parameters.</param>
    /// <returns>The authorization status.</returns>
    public async Task<AuthorizationResponse> Status(AuthStatusParams parameters)
    {
        var request = new ArcadeRequest<AuthStatusParams>(HttpMethod.Get, parameters);
        using var response = await _client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<AuthorizationResponse>().ConfigureAwait(false);
    }
}
