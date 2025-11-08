using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Health;

namespace ArcadeDotnet.Services.Health;

public sealed class HealthService : IHealthService
{
    public IHealthService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new HealthService(this._client.WithOptions(modifier));
    }

    readonly IArcadeClient _client;

    public HealthService(IArcadeClient client)
    {
        _client = client;
    }

    public async Task<HealthSchema> Check(
        HealthCheckParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<HealthCheckParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var healthSchema = await response
            .Deserialize<HealthSchema>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            healthSchema.Validate();
        }
        return healthSchema;
    }
}
