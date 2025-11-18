using System;
using ArcadeDotnet.Core;
using ArcadeDotnet.Services.Chat;

namespace ArcadeDotnet.Services;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IChatService
{
    IChatService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    ICompletionService Completions { get; }
}
