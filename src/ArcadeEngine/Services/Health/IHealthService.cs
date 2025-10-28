using System.Threading.Tasks;
using ArcadeEngine.Models.Health;

namespace ArcadeEngine.Services.Health;

public interface IHealthService
{
    /// <summary>
    /// Check if Arcade Engine is healthy
    /// </summary>
    Task<HealthSchema> Check(HealthCheckParams? parameters = null);
}
