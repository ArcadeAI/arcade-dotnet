using System;
using ArcadeDotnet.Core;
using ArcadeDotnet.Services.Chat;

namespace ArcadeDotnet.Services;

public sealed class ChatService : IChatService
{
    public IChatService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ChatService(this._client.WithOptions(modifier));
    }

    readonly IArcadeClient _client;

    public ChatService(IArcadeClient client)
    {
        _client = client;
        _completions = new(() => new CompletionService(client));
    }

    readonly Lazy<ICompletionService> _completions;
    public ICompletionService Completions
    {
        get { return _completions.Value; }
    }
}
