using System;
using ArcadeDotnet.Services.Chat.Completions;

namespace ArcadeDotnet.Services.Chat;

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
