using ArcadeEngine.Services.Chat.Completions;

namespace ArcadeEngine.Services.Chat;

public interface IChatService
{
    ICompletionService Completions { get; }
}
