using System;
using ArcadeDotnet.Core;
using ArcadeDotnet.Services.Chat.Completions;

namespace ArcadeDotnet.Services.Chat;

public interface IChatService
{
    IChatService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    ICompletionService Completions { get; }
}
