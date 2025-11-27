using System;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Tools.Scheduled;

namespace ArcadeDotnet.Services.Tools;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IScheduledService
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IScheduledService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a page of scheduled tool executions
    /// </summary>
    Task<ScheduledListPageResponse> List(
        ScheduledListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns the details for a specific scheduled tool execution
    /// </summary>
    Task<ScheduledGetResponse> Get(
        ScheduledGetParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Get(ScheduledGetParams, CancellationToken)"/>
    Task<ScheduledGetResponse> Get(
        string id,
        ScheduledGetParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
