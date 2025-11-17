using System;
using System.Net.Http;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Chat;
using ArcadeDotnet.Models.Chat.Completions;

namespace ArcadeDotnet.Services.Chat.Completions;

public sealed class CompletionService : ICompletionService
{
    private readonly IArcadeClient _client;

    /// <summary>
    /// Initializes a new instance of the <see cref="CompletionService"/> class.
    /// </summary>
    /// <param name="client">The Arcade client instance.</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="client"/> is null.</exception>
    public CompletionService(IArcadeClient client)
    {
        ArgumentNullException.ThrowIfNull(client);
        _client = client;
    }

    public async Task<ChatResponse> Create(CompletionCreateParams? parameters = null)
    {
        parameters ??= new();
        var request = new ArcadeRequest<CompletionCreateParams>(HttpMethod.Post, parameters);
        using var response = await _client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<ChatResponse>().ConfigureAwait(false);
    }
}
