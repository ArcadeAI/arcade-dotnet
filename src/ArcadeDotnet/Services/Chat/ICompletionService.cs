using System;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Chat;
using ArcadeDotnet.Models.Chat.Completions;

namespace ArcadeDotnet.Services.Chat;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface ICompletionService
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    ICompletionService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Interact with language models via OpenAI's chat completions API
    /// </summary>
    Task<ChatResponse> Create(
        CompletionCreateParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
