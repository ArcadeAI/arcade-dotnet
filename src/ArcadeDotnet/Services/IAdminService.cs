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
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IAdminServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IAdminService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    IUserConnectionService UserConnections { get; }

    IAuthProviderService AuthProviders { get; }

    ISecretService Secrets { get; }
}

/// <summary>
/// A view of <see cref="IAdminService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IAdminServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IAdminServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    IUserConnectionServiceWithRawResponse UserConnections { get; }

    IAuthProviderServiceWithRawResponse AuthProviders { get; }

    ISecretServiceWithRawResponse Secrets { get; }
}
