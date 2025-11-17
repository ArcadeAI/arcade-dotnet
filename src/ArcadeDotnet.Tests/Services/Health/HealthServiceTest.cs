using System.Threading.Tasks;

namespace ArcadeDotnet.Tests.Services.Health;

public class HealthServiceTest : TestBase
{
    // Health service removed from main client - it's for ops/monitoring, not business logic
    // If needed, health checks can be done directly via HTTP GET to /v1/health
}
