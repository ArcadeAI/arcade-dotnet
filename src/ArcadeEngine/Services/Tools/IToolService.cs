using System.Threading.Tasks;
using ArcadeEngine.Models;
using ArcadeEngine.Models.Tools;
using ArcadeEngine.Services.Tools.Formatted;
using ArcadeEngine.Services.Tools.Scheduled;

namespace ArcadeEngine.Services.Tools;

public interface IToolService
{
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
