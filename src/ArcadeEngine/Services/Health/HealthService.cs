using System.Net.Http;
using System.Threading.Tasks;
using ArcadeEngine.Core;
using ArcadeEngine.Models.Health;

namespace ArcadeEngine.Services.Health;

public sealed class HealthService : IHealthService
{
    readonly IArcadeClient _client;

    public HealthService(IArcadeClient client)
    {
        _client = client;
    }

    public async Task<HealthSchema> Check(HealthCheckParams? parameters = null)
    {
        parameters ??= new();

        HttpRequest<HealthCheckParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<HealthSchema>().ConfigureAwait(false);
    }
}
