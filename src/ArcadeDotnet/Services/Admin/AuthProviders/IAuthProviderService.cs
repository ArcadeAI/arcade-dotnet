using System;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using AuthProviders = ArcadeDotnet.Models.Admin.AuthProviders;

namespace ArcadeDotnet.Services.Admin.AuthProviders;

public interface IAuthProviderService
{
    IAuthProviderService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Create a new auth provider
    /// </summary>
    Task<AuthProviders::AuthProviderResponse> Create(
        AuthProviders::AuthProviderCreateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List a page of auth providers that are available to the caller
    /// </summary>
    Task<AuthProviders::AuthProviderListResponse> List(
        AuthProviders::AuthProviderListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a specific auth provider
    /// </summary>
    Task<AuthProviders::AuthProviderResponse> Delete(
        AuthProviders::AuthProviderDeleteParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get the details of a specific auth provider
    /// </summary>
    Task<AuthProviders::AuthProviderResponse> Get(
        AuthProviders::AuthProviderGetParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Patch an existing auth provider
    /// </summary>
    Task<AuthProviders::AuthProviderResponse> Patch(
        AuthProviders::AuthProviderPatchParams parameters,
        CancellationToken cancellationToken = default
    );
}
