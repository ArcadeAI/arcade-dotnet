using System;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Admin.AuthProviders;

namespace ArcadeDotnet.Services.Admin;

public interface IAuthProviderService
{
    IAuthProviderService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Create a new auth provider
    /// </summary>
    Task<AuthProviderResponse> Create(
        AuthProviderCreateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List a page of auth providers that are available to the caller
    /// </summary>
    Task<AuthProviderListResponse> List(
        AuthProviderListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a specific auth provider
    /// </summary>
    Task<AuthProviderResponse> Delete(
        AuthProviderDeleteParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get the details of a specific auth provider
    /// </summary>
    Task<AuthProviderResponse> Get(
        AuthProviderGetParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Patch an existing auth provider
    /// </summary>
    Task<AuthProviderResponse> Patch(
        AuthProviderPatchParams parameters,
        CancellationToken cancellationToken = default
    );
}
