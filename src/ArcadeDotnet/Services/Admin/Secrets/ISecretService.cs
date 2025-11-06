using System;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using Secrets = ArcadeDotnet.Models.Admin.Secrets;

namespace ArcadeDotnet.Services.Admin.Secrets;

public interface ISecretService
{
    ISecretService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// List all secrets that are visible to the caller
    /// </summary>
    Task<Secrets::SecretListResponse> List(Secrets::SecretListParams? parameters = null);

    /// <summary>
    /// Delete a secret by its ID
    /// </summary>
    Task Delete(Secrets::SecretDeleteParams parameters);
}
