using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Tools.Formatted;

namespace ArcadeDotnet.Services.Tools.Formatted;

public sealed class FormattedService : IFormattedService
{
    private readonly IArcadeClient _client;

    /// <summary>
    /// Initializes a new instance of the <see cref="FormattedService"/> class.
    /// </summary>
    /// <param name="client">The Arcade client instance.</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="client"/> is null.</exception>
    public FormattedService(IArcadeClient client)
    {
        ArgumentNullException.ThrowIfNull(client);
        _client = client;
    }

    public async Task<FormattedListPageResponse> List(FormattedListParams? parameters = null)
    {
        parameters ??= new();
        var request = new ArcadeRequest<FormattedListParams>(HttpMethod.Get, parameters);
        using var response = await _client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<FormattedListPageResponse>().ConfigureAwait(false);
    }

    public async Task<JsonElement> Get(FormattedGetParams parameters)
    {
        var request = new ArcadeRequest<FormattedGetParams>(HttpMethod.Get, parameters);
        using var response = await _client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<JsonElement>().ConfigureAwait(false);
    }
}
