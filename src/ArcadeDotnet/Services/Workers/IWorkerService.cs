using System;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using Workers = ArcadeDotnet.Models.Workers;

namespace ArcadeDotnet.Services.Workers;

public interface IWorkerService
{
    IWorkerService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Create a worker
    /// </summary>
    Task<Workers::WorkerResponse> Create(Workers::WorkerCreateParams parameters);

    /// <summary>
    /// Update a worker
    /// </summary>
    Task<Workers::WorkerResponse> Update(Workers::WorkerUpdateParams parameters);

    /// <summary>
    /// List all workers with their definitions
    /// </summary>
    Task<Workers::WorkerListPageResponse> List(Workers::WorkerListParams? parameters = null);

    /// <summary>
    /// Delete a worker
    /// </summary>
    Task Delete(Workers::WorkerDeleteParams parameters);

    /// <summary>
    /// Get a worker by ID
    /// </summary>
    Task<Workers::WorkerResponse> Get(Workers::WorkerGetParams parameters);

    /// <summary>
    /// Get the health of a worker
    /// </summary>
    Task<Workers::WorkerHealthResponse> Health(Workers::WorkerHealthParams parameters);

    /// <summary>
    /// Returns a page of tools
    /// </summary>
    Task<Workers::WorkerToolsPageResponse> Tools(Workers::WorkerToolsParams parameters);
}
