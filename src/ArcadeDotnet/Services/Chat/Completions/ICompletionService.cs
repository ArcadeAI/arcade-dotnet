using System;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using Chat = ArcadeDotnet.Models.Chat;
using Completions = ArcadeDotnet.Models.Chat.Completions;

namespace ArcadeDotnet.Services.Chat.Completions;

public interface ICompletionService
{
    ICompletionService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Interact with language models via OpenAI's chat completions API
    /// </summary>
    Task<Chat::ChatResponse> Create(
        Completions::CompletionCreateParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
