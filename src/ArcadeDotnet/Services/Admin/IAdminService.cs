using ArcadeDotnet.Services.Admin.AuthProviders;
using ArcadeDotnet.Services.Admin.Secrets;
using ArcadeDotnet.Services.Admin.UserConnections;

namespace ArcadeDotnet.Services.Admin;

public interface IAdminService
{
    IUserConnectionService UserConnections { get; }

    IAuthProviderService AuthProviders { get; }

    ISecretService Secrets { get; }
}
