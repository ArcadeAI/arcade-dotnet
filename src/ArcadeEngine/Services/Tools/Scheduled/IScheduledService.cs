using System.Threading.Tasks;
using ArcadeEngine.Models.Tools.Scheduled;

namespace ArcadeEngine.Services.Tools.Scheduled;

public interface IScheduledService
{
    /// <summary>
    /// Returns a page of scheduled tool executions
    /// </summary>
    Task<ScheduledListPageResponse> List(ScheduledListParams? parameters = null);

    /// <summary>
    /// Returns the details for a specific scheduled tool execution
    /// </summary>
    Task<ScheduledGetResponse> Get(ScheduledGetParams parameters);
}
