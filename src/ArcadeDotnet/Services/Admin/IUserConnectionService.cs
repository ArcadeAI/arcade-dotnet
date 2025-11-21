using System;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Admin.UserConnections;

namespace ArcadeDotnet.Services.Admin;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IUserConnectionService
{
    IUserConnectionService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// List all auth connections
    /// </summary>
    Task<UserConnectionListPageResponse> List(
        UserConnectionListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a user/auth provider connection
    /// </summary>
    Task Delete(
        UserConnectionDeleteParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a user/auth provider connection
    /// </summary>
    Task Delete(
        string id,
        UserConnectionDeleteParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
