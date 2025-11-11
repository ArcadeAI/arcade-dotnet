using System;
using ArcadeDotnet.Core;
using ArcadeDotnet.Services.Admin;

namespace ArcadeDotnet.Services;

public sealed class AdminService : IAdminService
{
    public IAdminService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new AdminService(this._client.WithOptions(modifier));
    }

    readonly IArcadeClient _client;

    public AdminService(IArcadeClient client)
    {
        _client = client;
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
