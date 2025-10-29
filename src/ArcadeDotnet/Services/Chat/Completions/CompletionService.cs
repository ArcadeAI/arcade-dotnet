using System.Net.Http;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Chat;
using ArcadeDotnet.Models.Chat.Completions;

namespace ArcadeDotnet.Services.Chat.Completions;

public sealed class CompletionService : ICompletionService
{
    readonly IArcadeClient _client;

    public CompletionService(IArcadeClient client)
    {
        _client = client;
    }

    public async Task<ChatResponse> Create(CompletionCreateParams? parameters = null)
    {
        parameters ??= new();

        HttpRequest<CompletionCreateParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<ChatResponse>().ConfigureAwait(false);
    }
}
