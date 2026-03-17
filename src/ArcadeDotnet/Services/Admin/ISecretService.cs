using System;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Admin.Secrets;

namespace ArcadeDotnet.Services.Admin;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface ISecretService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    ISecretServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    ISecretService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Create or update a secret
    /// </summary>
    Task<SecretResponse> Create(
        SecretCreateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Create(SecretCreateParams, CancellationToken)"/>
    Task<SecretResponse> Create(
        string secretKey,
        SecretCreateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List all secrets that are visible to the caller
    /// </summary>
    Task<SecretListResponse> List(
        SecretListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a secret by its ID
    /// </summary>
    Task Delete(SecretDeleteParams parameters, CancellationToken cancellationToken = default);

    /// <inheritdoc cref="Delete(SecretDeleteParams, CancellationToken)"/>
    Task Delete(
        string secretID,
        SecretDeleteParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="ISecretService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface ISecretServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    ISecretServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for <c>post /v1/admin/secrets/{secret_key}</c>, but is otherwise the
    /// same as <see cref="ISecretService.Create(SecretCreateParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<SecretResponse>> Create(
        SecretCreateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Create(SecretCreateParams, CancellationToken)"/>
    Task<HttpResponse<SecretResponse>> Create(
        string secretKey,
        SecretCreateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for <c>get /v1/admin/secrets</c>, but is otherwise the
    /// same as <see cref="ISecretService.List(SecretListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<SecretListResponse>> List(
        SecretListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for <c>delete /v1/admin/secrets/{secret_id}</c>, but is otherwise the
    /// same as <see cref="ISecretService.Delete(SecretDeleteParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse> Delete(
        SecretDeleteParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Delete(SecretDeleteParams, CancellationToken)"/>
    Task<HttpResponse> Delete(
        string secretID,
        SecretDeleteParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
