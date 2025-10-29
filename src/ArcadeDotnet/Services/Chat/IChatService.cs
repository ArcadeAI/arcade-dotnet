using ArcadeDotnet.Services.Chat.Completions;

namespace ArcadeDotnet.Services.Chat;

public interface IChatService
{
    ICompletionService Completions { get; }
}
