using System;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models;
using ArcadeDotnet.Models.Tools;
using ArcadeDotnet.Services.Tools.Formatted;
using ArcadeDotnet.Services.Tools.Scheduled;

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
    Task<ToolListPageResponse> List(ToolListParams? parameters = null);

    /// <summary>
    /// Authorizes a user for a specific tool by name
    /// </summary>
    Task<AuthorizationResponse> Authorize(ToolAuthorizeParams parameters);

    /// <summary>
    /// Executes a tool by name and arguments
    /// </summary>
    Task<ExecuteToolResponse> Execute(ToolExecuteParams parameters);

    /// <summary>
    /// Returns the arcade tool specification for a specific tool
    /// </summary>
    Task<ToolDefinition> Get(ToolGetParams parameters);
}
