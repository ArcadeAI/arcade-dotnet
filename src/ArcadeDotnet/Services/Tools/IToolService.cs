using System;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models;
using ArcadeDotnet.Services.Tools.Formatted;
using ArcadeDotnet.Services.Tools.Scheduled;
using Tools = ArcadeDotnet.Models.Tools;

namespace ArcadeDotnet.Services.Tools;

public interface IToolService
{
    IToolService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    IScheduledService Scheduled { get; }

    IFormattedService Formatted { get; }

    /// <summary>
    /// Returns a page of tools from the engine configuration, optionally filtered
    /// by toolkit
    /// </summary>
    Task<Tools::ToolListPageResponse> List(
        Tools::ToolListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Authorizes a user for a specific tool by name
    /// </summary>
    Task<AuthorizationResponse> Authorize(
        Tools::ToolAuthorizeParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Executes a tool by name and arguments
    /// </summary>
    Task<Tools::ExecuteToolResponse> Execute(
        Tools::ToolExecuteParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns the arcade tool specification for a specific tool
    /// </summary>
    Task<Tools::ToolDefinition> Get(
        Tools::ToolGetParams parameters,
        CancellationToken cancellationToken = default
    );
}
