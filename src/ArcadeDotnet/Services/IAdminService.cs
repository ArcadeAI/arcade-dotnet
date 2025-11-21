using System;
using ArcadeDotnet.Core;
using ArcadeDotnet.Services.Admin;

namespace ArcadeDotnet.Services;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IAdminService
{
    IAdminService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    IUserConnectionService UserConnections { get; }

    IAuthProviderService AuthProviders { get; }

    ISecretService Secrets { get; }
}
