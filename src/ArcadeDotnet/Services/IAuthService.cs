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
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IAuthServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
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
    /// Checks the status of an ongoing authorization process for a specific tool. If
    /// 'wait' param is present, does not respond until either the auth status becomes
    /// completed or the timeout is reached.
    /// </summary>
    Task<AuthorizationResponse> Status(
        AuthStatusParams parameters,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="IAuthService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IAuthServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IAuthServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for <c>post /v1/auth/authorize</c>, but is otherwise the
    /// same as <see cref="IAuthService.Authorize(AuthAuthorizeParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<AuthorizationResponse>> Authorize(
        AuthAuthorizeParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for <c>post /v1/auth/confirm_user</c>, but is otherwise the
    /// same as <see cref="IAuthService.ConfirmUser(AuthConfirmUserParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<ConfirmUserResponse>> ConfirmUser(
        AuthConfirmUserParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for <c>get /v1/auth/status</c>, but is otherwise the
    /// same as <see cref="IAuthService.Status(AuthStatusParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<AuthorizationResponse>> Status(
        AuthStatusParams parameters,
        CancellationToken cancellationToken = default
    );
}
