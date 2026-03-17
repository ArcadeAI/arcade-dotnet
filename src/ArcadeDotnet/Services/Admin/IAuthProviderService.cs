using System;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Admin.AuthProviders;

namespace ArcadeDotnet.Services.Admin;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IAuthProviderService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IAuthProviderServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
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

    /// <inheritdoc cref="Delete(AuthProviderDeleteParams, CancellationToken)"/>
    Task<AuthProviderResponse> Delete(
        string id,
        AuthProviderDeleteParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get the details of a specific auth provider
    /// </summary>
    Task<AuthProviderResponse> Get(
        AuthProviderGetParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Get(AuthProviderGetParams, CancellationToken)"/>
    Task<AuthProviderResponse> Get(
        string id,
        AuthProviderGetParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Patch an existing auth provider
    /// </summary>
    Task<AuthProviderResponse> Patch(
        AuthProviderPatchParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Patch(AuthProviderPatchParams, CancellationToken)"/>
    Task<AuthProviderResponse> Patch(
        string id,
        AuthProviderPatchParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="IAuthProviderService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IAuthProviderServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IAuthProviderServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for <c>post /v1/admin/auth_providers</c>, but is otherwise the
    /// same as <see cref="IAuthProviderService.Create(AuthProviderCreateParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<AuthProviderResponse>> Create(
        AuthProviderCreateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for <c>get /v1/admin/auth_providers</c>, but is otherwise the
    /// same as <see cref="IAuthProviderService.List(AuthProviderListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<AuthProviderListResponse>> List(
        AuthProviderListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for <c>delete /v1/admin/auth_providers/{id}</c>, but is otherwise the
    /// same as <see cref="IAuthProviderService.Delete(AuthProviderDeleteParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<AuthProviderResponse>> Delete(
        AuthProviderDeleteParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Delete(AuthProviderDeleteParams, CancellationToken)"/>
    Task<HttpResponse<AuthProviderResponse>> Delete(
        string id,
        AuthProviderDeleteParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for <c>get /v1/admin/auth_providers/{id}</c>, but is otherwise the
    /// same as <see cref="IAuthProviderService.Get(AuthProviderGetParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<AuthProviderResponse>> Get(
        AuthProviderGetParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Get(AuthProviderGetParams, CancellationToken)"/>
    Task<HttpResponse<AuthProviderResponse>> Get(
        string id,
        AuthProviderGetParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for <c>patch /v1/admin/auth_providers/{id}</c>, but is otherwise the
    /// same as <see cref="IAuthProviderService.Patch(AuthProviderPatchParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<AuthProviderResponse>> Patch(
        AuthProviderPatchParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Patch(AuthProviderPatchParams, CancellationToken)"/>
    Task<HttpResponse<AuthProviderResponse>> Patch(
        string id,
        AuthProviderPatchParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
