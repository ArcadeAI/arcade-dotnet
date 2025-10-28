using ArcadeEngine.Services.Admin.AuthProviders;
using ArcadeEngine.Services.Admin.Secrets;
using ArcadeEngine.Services.Admin.UserConnections;

namespace ArcadeEngine.Services.Admin;

public interface IAdminService
{
    IUserConnectionService UserConnections { get; }

    IAuthProviderService AuthProviders { get; }

    ISecretService Secrets { get; }
}
