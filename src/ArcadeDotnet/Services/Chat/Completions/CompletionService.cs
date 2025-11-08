using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using Chat = ArcadeDotnet.Models.Chat;
using Completions = ArcadeDotnet.Models.Chat.Completions;

namespace ArcadeDotnet.Services.Chat.Completions;

public sealed class CompletionService : ICompletionService
{
    public ICompletionService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new CompletionService(this._client.WithOptions(modifier));
    }

    readonly IArcadeClient _client;

    public CompletionService(IArcadeClient client)
    {
        _client = client;
    }

    public async Task<Chat::ChatResponse> Create(
        Completions::CompletionCreateParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<Completions::CompletionCreateParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var chatResponse = await response
            .Deserialize<Chat::ChatResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            chatResponse.Validate();
        }
        return chatResponse;
    }
}
