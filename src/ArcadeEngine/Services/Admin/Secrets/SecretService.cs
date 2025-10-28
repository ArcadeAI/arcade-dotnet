using System.Net.Http;
using System.Threading.Tasks;
using ArcadeEngine.Core;
using ArcadeEngine.Models.Admin.Secrets;

namespace ArcadeEngine.Services.Admin.Secrets;

public sealed class SecretService : ISecretService
{
    readonly IArcadeClient _client;

    public SecretService(IArcadeClient client)
    {
        _client = client;
    }

    public async Task<SecretListResponse> List(SecretListParams? parameters = null)
    {
        parameters ??= new();

        HttpRequest<SecretListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<SecretListResponse>().ConfigureAwait(false);
    }

    public async Task Delete(SecretDeleteParams parameters)
    {
        HttpRequest<SecretDeleteParams> request = new()
        {
            Method = HttpMethod.Delete,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        return;
    }
}
