using System;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Chat;
using ArcadeDotnet.Models.Chat.Completions;

namespace ArcadeDotnet.Services.Chat.Completions;

public interface ICompletionService
{
    ICompletionService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Interact with language models via OpenAI's chat completions API
    /// </summary>
    Task<ChatResponse> Create(
        CompletionCreateParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
