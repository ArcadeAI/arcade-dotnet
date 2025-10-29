using System;
using ArcadeDotnet.Services.Admin.AuthProviders;
using ArcadeDotnet.Services.Admin.Secrets;
using ArcadeDotnet.Services.Admin.UserConnections;

namespace ArcadeDotnet.Services.Admin;

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
