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
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IScheduledServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IScheduledService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a page of scheduled tool executions
    /// </summary>
    Task<ScheduledListPage> List(
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

/// <summary>
/// A view of <see cref="IScheduledService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IScheduledServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IScheduledServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for `get /v1/scheduled_tools`, but is otherwise the
    /// same as <see cref="IScheduledService.List(ScheduledListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<ScheduledListPage>> List(
        ScheduledListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `get /v1/scheduled_tools/{id}`, but is otherwise the
    /// same as <see cref="IScheduledService.Get(ScheduledGetParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<ScheduledGetResponse>> Get(
        ScheduledGetParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Get(ScheduledGetParams, CancellationToken)"/>
    Task<HttpResponse<ScheduledGetResponse>> Get(
        string id,
        ScheduledGetParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
