using System.Threading.Tasks;
using ArcadeEngine.Models.Admin.AuthProviders;

namespace ArcadeEngine.Services.Admin.AuthProviders;

public interface IAuthProviderService
{
    /// <summary>
    /// Create a new auth provider
    /// </summary>
    Task<AuthProviderResponse> Create(AuthProviderCreateParams parameters);

    /// <summary>
    /// List a page of auth providers that are available to the caller
    /// </summary>
    Task<AuthProviderListResponse> List(AuthProviderListParams? parameters = null);

    /// <summary>
    /// Delete a specific auth provider
    /// </summary>
    Task<AuthProviderResponse> Delete(AuthProviderDeleteParams parameters);

    /// <summary>
    /// Get the details of a specific auth provider
    /// </summary>
    Task<AuthProviderResponse> Get(AuthProviderGetParams parameters);

    /// <summary>
    /// Patch an existing auth provider
    /// </summary>
    Task<AuthProviderResponse> Patch(AuthProviderPatchParams parameters);
}
