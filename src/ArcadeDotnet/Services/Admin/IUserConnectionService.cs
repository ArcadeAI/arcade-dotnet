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
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IUserConnectionServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IUserConnectionService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// List all auth connections
    /// </summary>
    Task<UserConnectionListPage> List(
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

    /// <inheritdoc cref="Delete(UserConnectionDeleteParams, CancellationToken)"/>
    Task Delete(
        string id,
        UserConnectionDeleteParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="IUserConnectionService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IUserConnectionServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IUserConnectionServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for <c>get /v1/admin/user_connections</c>, but is otherwise the
    /// same as <see cref="IUserConnectionService.List(UserConnectionListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<UserConnectionListPage>> List(
        UserConnectionListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for <c>delete /v1/admin/user_connections/{id}</c>, but is otherwise the
    /// same as <see cref="IUserConnectionService.Delete(UserConnectionDeleteParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse> Delete(
        UserConnectionDeleteParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Delete(UserConnectionDeleteParams, CancellationToken)"/>
    Task<HttpResponse> Delete(
        string id,
        UserConnectionDeleteParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
