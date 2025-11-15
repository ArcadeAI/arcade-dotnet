using System;
using ArcadeDotnet.Core;
using ArcadeDotnet.Services.Admin;

namespace ArcadeDotnet.Services;

public interface IAdminService
{
    IAdminService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    IUserConnectionService UserConnections { get; }

    IAuthProviderService AuthProviders { get; }

    ISecretService Secrets { get; }
}
