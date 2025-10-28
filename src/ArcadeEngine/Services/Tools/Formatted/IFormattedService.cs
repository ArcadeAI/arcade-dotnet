using System.Text.Json;
using System.Threading.Tasks;
using ArcadeEngine.Models.Tools.Formatted;

namespace ArcadeEngine.Services.Tools.Formatted;

public interface IFormattedService
{
    /// <summary>
    /// Returns a page of tools from the engine configuration, optionally filtered
    /// by toolkit, formatted for a specific provider
    /// </summary>
    Task<FormattedListPageResponse> List(FormattedListParams? parameters = null);

    /// <summary>
    /// Returns the formatted tool specification for a specific tool, given a provider
    /// </summary>
    Task<JsonElement> Get(FormattedGetParams parameters);
}
