using System;
using System.Net.Http;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models;
using ArcadeDotnet.Models.Tools;
using ArcadeDotnet.Services.Tools.Formatted;
using ArcadeDotnet.Services.Tools.Scheduled;

namespace ArcadeDotnet.Services.Tools;

public sealed class ToolService : IToolService
{
    private readonly IArcadeClient _client;

    /// <summary>
    /// Gets the scheduled tools service.
    /// </summary>
    public IScheduledService Scheduled { get; }

    /// <summary>
    /// Gets the formatted tools service.
    /// </summary>
    public IFormattedService Formatted { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ToolService"/> class.
    /// </summary>
    /// <param name="client">The Arcade client instance.</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="client"/> is null.</exception>
    public ToolService(IArcadeClient client)
    {
        ArgumentNullException.ThrowIfNull(client);
        _client = client;
        Scheduled = new ScheduledService(client);
        Formatted = new FormattedService(client);
    }

    public async Task<ToolListPageResponse> List(ToolListParams? parameters = null)
    {
        parameters ??= new();
        var request = new ArcadeRequest<ToolListParams>(HttpMethod.Get, parameters);
        using var response = await _client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<ToolListPageResponse>().ConfigureAwait(false);
    }

    public async Task<AuthorizationResponse> Authorize(ToolAuthorizeParams parameters)
    {
        var request = new ArcadeRequest<ToolAuthorizeParams>(HttpMethod.Post, parameters);
        using var response = await _client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<AuthorizationResponse>().ConfigureAwait(false);
    }

    public async Task<ExecuteToolResponse> Execute(ToolExecuteParams parameters)
    {
        var request = new ArcadeRequest<ToolExecuteParams>(HttpMethod.Post, parameters);
        using var response = await _client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<ExecuteToolResponse>().ConfigureAwait(false);
    }

    public async Task<ToolDefinition> Get(ToolGetParams parameters)
    {
        var request = new ArcadeRequest<ToolGetParams>(HttpMethod.Get, parameters);
        using var response = await _client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<ToolDefinition>().ConfigureAwait(false);
    }
}
