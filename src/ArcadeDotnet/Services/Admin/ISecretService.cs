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
    ISecretService WithOptions(Func<ClientOptions, ClientOptions> modifier);

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
}
