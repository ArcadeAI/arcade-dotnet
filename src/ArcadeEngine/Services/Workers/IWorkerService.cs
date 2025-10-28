using System.Threading.Tasks;
using ArcadeEngine.Models.Workers;

namespace ArcadeEngine.Services.Workers;

public interface IWorkerService
{
    /// <summary>
    /// Create a worker
    /// </summary>
    Task<WorkerResponse> Create(WorkerCreateParams parameters);

    /// <summary>
    /// Update a worker
    /// </summary>
    Task<WorkerResponse> Update(WorkerUpdateParams parameters);

    /// <summary>
    /// List all workers with their definitions
    /// </summary>
    Task<WorkerListPageResponse> List(WorkerListParams? parameters = null);

    /// <summary>
    /// Delete a worker
    /// </summary>
    Task Delete(WorkerDeleteParams parameters);

    /// <summary>
    /// Get a worker by ID
    /// </summary>
    Task<WorkerResponse> Get(WorkerGetParams parameters);

    /// <summary>
    /// Get the health of a worker
    /// </summary>
    Task<WorkerHealthResponse> Health(WorkerHealthParams parameters);

    /// <summary>
    /// Returns a page of tools
    /// </summary>
    Task<WorkerToolsPageResponse> Tools(WorkerToolsParams parameters);
}
