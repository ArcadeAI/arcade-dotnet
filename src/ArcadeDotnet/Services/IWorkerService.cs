using System;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Workers;

namespace ArcadeDotnet.Services;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IWorkerService
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
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

    /// <inheritdoc cref="Update(WorkerUpdateParams, CancellationToken)"/>
    Task<WorkerResponse> Update(
        string id,
        WorkerUpdateParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List all workers with their definitions
    /// </summary>
    Task<WorkerListPage> List(
        WorkerListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a worker
    /// </summary>
    Task Delete(WorkerDeleteParams parameters, CancellationToken cancellationToken = default);

    /// <inheritdoc cref="Delete(WorkerDeleteParams, CancellationToken)"/>
    Task Delete(
        string id,
        WorkerDeleteParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get a worker by ID
    /// </summary>
    Task<WorkerResponse> Get(
        WorkerGetParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Get(WorkerGetParams, CancellationToken)"/>
    Task<WorkerResponse> Get(
        string id,
        WorkerGetParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get the health of a worker
    /// </summary>
    Task<WorkerHealthResponse> Health(
        WorkerHealthParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Health(WorkerHealthParams, CancellationToken)"/>
    Task<WorkerHealthResponse> Health(
        string id,
        WorkerHealthParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a page of tools
    /// </summary>
    Task<WorkerToolsPage> Tools(
        WorkerToolsParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Tools(WorkerToolsParams, CancellationToken)"/>
    Task<WorkerToolsPage> Tools(
        string id,
        WorkerToolsParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
