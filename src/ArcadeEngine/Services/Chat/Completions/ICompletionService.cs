using System.Threading.Tasks;
using ArcadeEngine.Models.Chat;
using ArcadeEngine.Models.Chat.Completions;

namespace ArcadeEngine.Services.Chat.Completions;

public interface ICompletionService
{
    /// <summary>
    /// Interact with language models via OpenAI's chat completions API
    /// </summary>
    Task<ChatResponse> Create(CompletionCreateParams? parameters = null);
}
