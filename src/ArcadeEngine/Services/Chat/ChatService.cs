using System;
using ArcadeEngine.Services.Chat.Completions;

namespace ArcadeEngine.Services.Chat;

public sealed class ChatService : IChatService
{
    public ChatService(IArcadeClient client)
    {
        _completions = new(() => new CompletionService(client));
    }

    readonly Lazy<ICompletionService> _completions;
    public ICompletionService Completions
    {
        get { return _completions.Value; }
    }
}
