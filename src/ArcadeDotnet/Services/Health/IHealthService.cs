using System.Threading.Tasks;
using ArcadeDotnet.Models.Health;

namespace ArcadeDotnet.Services.Health;

public interface IHealthService
{
    /// <summary>
    /// Check if Arcade Engine is healthy
    /// </summary>
    Task<HealthSchema> Check(HealthCheckParams? parameters = null);
}
