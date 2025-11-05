using System;
using ArcadeDotnet.Core;
using ArcadeDotnet.Services.Admin.AuthProviders;
using ArcadeDotnet.Services.Admin.Secrets;
using ArcadeDotnet.Services.Admin.UserConnections;

namespace ArcadeDotnet.Services.Admin;

public interface IAdminService
{
    IAdminService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    IUserConnectionService UserConnections { get; }

    IAuthProviderService AuthProviders { get; }

    ISecretService Secrets { get; }
}
