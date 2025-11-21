using System;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models;
using ArcadeDotnet.Models.Auth;

namespace ArcadeDotnet.Services;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IAuthService
{
    IAuthService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Starts the authorization process for given authorization requirements
    /// </summary>
    Task<AuthorizationResponse> Authorize(
        AuthAuthorizeParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Confirms a user's details during an authorization flow
    /// </summary>
    Task<ConfirmUserResponse> ConfirmUser(
        AuthConfirmUserParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Checks the status of an ongoing authorization process for a specific tool.
    /// If 'wait' param is present, does not respond until either the auth status
    /// becomes completed or the timeout is reached.
    /// </summary>
    Task<AuthorizationResponse> Status(
        AuthStatusParams parameters,
        CancellationToken cancellationToken = default
    );
}
