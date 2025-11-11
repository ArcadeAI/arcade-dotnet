using System;
using ArcadeDotnet.Core;
using ArcadeDotnet.Services.Chat;

namespace ArcadeDotnet.Services;

public interface IChatService
{
    IChatService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    ICompletionService Completions { get; }
}
