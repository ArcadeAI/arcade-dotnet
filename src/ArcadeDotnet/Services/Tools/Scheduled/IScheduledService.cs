using System;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Tools.Scheduled;

namespace ArcadeDotnet.Services.Tools.Scheduled;

public interface IScheduledService
{
    IScheduledService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a page of scheduled tool executions
    /// </summary>
    Task<ScheduledListPageResponse> List(ScheduledListParams? parameters = null);

    /// <summary>
    /// Returns the details for a specific scheduled tool execution
    /// </summary>
    Task<ScheduledGetResponse> Get(ScheduledGetParams parameters);
}
