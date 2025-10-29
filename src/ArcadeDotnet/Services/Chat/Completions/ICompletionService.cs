using System.Threading.Tasks;
using ArcadeDotnet.Models.Chat;
using ArcadeDotnet.Models.Chat.Completions;

namespace ArcadeDotnet.Services.Chat.Completions;

public interface ICompletionService
{
    /// <summary>
    /// Interact with language models via OpenAI's chat completions API
    /// </summary>
    Task<ChatResponse> Create(CompletionCreateParams? parameters = null);
}
