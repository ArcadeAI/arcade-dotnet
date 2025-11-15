using System;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Health;

namespace ArcadeDotnet.Services;

public interface IHealthService
{
    IHealthService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Check if Arcade Engine is healthy
    /// </summary>
    Task<HealthSchema> Check(
        HealthCheckParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
