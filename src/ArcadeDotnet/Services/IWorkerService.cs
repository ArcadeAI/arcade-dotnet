using System;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Workers;

namespace ArcadeDotnet.Services;

public interface IWorkerService
{
    IWorkerService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Create a worker
    /// </summary>
    Task<WorkerResponse> Create(
        WorkerCreateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a worker
    /// </summary>
    Task<WorkerResponse> Update(
        WorkerUpdateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List all workers with their definitions
    /// </summary>
    Task<WorkerListPageResponse> List(
        WorkerListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a worker
    /// </summary>
    Task Delete(WorkerDeleteParams parameters, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a worker by ID
    /// </summary>
    Task<WorkerResponse> Get(
        WorkerGetParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get the health of a worker
    /// </summary>
    Task<WorkerHealthResponse> Health(
        WorkerHealthParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a page of tools
    /// </summary>
    Task<WorkerToolsPageResponse> Tools(
        WorkerToolsParams parameters,
        CancellationToken cancellationToken = default
    );
}
