using System;
using ArcadeDotnet.Services.Admin.AuthProviders;
using ArcadeDotnet.Services.Admin.Secrets;
using ArcadeDotnet.Services.Admin.UserConnections;

namespace ArcadeDotnet.Services.Admin;

public sealed class AdminService : IAdminService
{
    /// <summary>
    /// Gets the user connections service.
    /// </summary>
    public IUserConnectionService UserConnections { get; }

    /// <summary>
    /// Gets the auth providers service.
    /// </summary>
    public IAuthProviderService AuthProviders { get; }

    /// <summary>
    /// Gets the secrets service.
    /// </summary>
    public ISecretService Secrets { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="AdminService"/> class.
    /// </summary>
    /// <param name="client">The Arcade client instance.</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="client"/> is null.</exception>
    public AdminService(IArcadeClient client)
    {
        ArgumentNullException.ThrowIfNull(client);
        UserConnections = new UserConnectionService(client);
        AuthProviders = new AuthProviderService(client);
        Secrets = new SecretService(client);
    }
}
