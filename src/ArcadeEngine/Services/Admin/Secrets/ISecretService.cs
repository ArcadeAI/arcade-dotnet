using System.Threading.Tasks;
using ArcadeEngine.Models.Admin.Secrets;

namespace ArcadeEngine.Services.Admin.Secrets;

public interface ISecretService
{
    /// <summary>
    /// List all secrets that are visible to the caller
    /// </summary>
    Task<SecretListResponse> List(SecretListParams? parameters = null);

    /// <summary>
    /// Delete a secret by its ID
    /// </summary>
    Task Delete(SecretDeleteParams parameters);
}
