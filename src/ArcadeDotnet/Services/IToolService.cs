using System;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models;
using ArcadeDotnet.Models.Tools;
using ArcadeDotnet.Services.Tools;

namespace ArcadeDotnet.Services;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IToolService
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IToolService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    IScheduledService Scheduled { get; }

    IFormattedService Formatted { get; }

    /// <summary>
    /// Returns a page of tools from the engine configuration, optionally filtered
    /// by toolkit
    /// </summary>
    Task<ToolListPageResponse> List(
        ToolListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Authorizes a user for a specific tool by name
    /// </summary>
    Task<AuthorizationResponse> Authorize(
        ToolAuthorizeParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Executes a tool by name and arguments
    /// </summary>
    Task<ExecuteToolResponse> Execute(
        ToolExecuteParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns the arcade tool specification for a specific tool
    /// </summary>
    Task<ToolDefinition> Get(
        ToolGetParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Get(ToolGetParams, CancellationToken)"/>
    Task<ToolDefinition> Get(
        string name,
        ToolGetParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
