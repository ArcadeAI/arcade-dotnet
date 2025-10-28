using System;
using ArcadeEngine.Services.Admin.AuthProviders;
using ArcadeEngine.Services.Admin.Secrets;
using ArcadeEngine.Services.Admin.UserConnections;

namespace ArcadeEngine.Services.Admin;

public sealed class AdminService : IAdminService
{
    public AdminService(IArcadeClient client)
    {
        _userConnections = new(() => new UserConnectionService(client));
        _authProviders = new(() => new AuthProviderService(client));
        _secrets = new(() => new SecretService(client));
    }

    readonly Lazy<IUserConnectionService> _userConnections;
    public IUserConnectionService UserConnections
    {
        get { return _userConnections.Value; }
    }

    readonly Lazy<IAuthProviderService> _authProviders;
    public IAuthProviderService AuthProviders
    {
        get { return _authProviders.Value; }
    }

    readonly Lazy<ISecretService> _secrets;
    public ISecretService Secrets
    {
        get { return _secrets.Value; }
    }
}
