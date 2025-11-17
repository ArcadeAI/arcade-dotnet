using System;
using ArcadeDotnet.Services.Chat.Completions;

namespace ArcadeDotnet.Services.Chat;

public sealed class ChatService : IChatService
{
    /// <summary>
    /// Gets the completions service.
    /// </summary>
    public ICompletionService Completions { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ChatService"/> class.
    /// </summary>
    /// <param name="client">The Arcade client instance.</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="client"/> is null.</exception>
    public ChatService(IArcadeClient client)
    {
        ArgumentNullException.ThrowIfNull(client);
        Completions = new CompletionService(client);
    }
}
