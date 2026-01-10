using System;
using ArcadeDotnet.Core;
using ArcadeDotnet.Services.Chat;

namespace ArcadeDotnet.Services;

/// <inheritdoc/>
public sealed class ChatService : IChatService
{
    readonly Lazy<IChatServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IChatServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly IArcadeClient _client;

    /// <inheritdoc/>
    public IChatService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ChatService(this._client.WithOptions(modifier));
    }

    public ChatService(IArcadeClient client)
    {
        _client = client;

        _withRawResponse = new(() => new ChatServiceWithRawResponse(client.WithRawResponse));
        _completions = new(() => new CompletionService(client));
    }

    readonly Lazy<ICompletionService> _completions;
    public ICompletionService Completions
    {
        get { return _completions.Value; }
    }
}

/// <inheritdoc/>
public sealed class ChatServiceWithRawResponse : IChatServiceWithRawResponse
{
    readonly IArcadeClientWithRawResponse _client;

    /// <inheritdoc/>
    public IChatServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ChatServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public ChatServiceWithRawResponse(IArcadeClientWithRawResponse client)
    {
        _client = client;

        _completions = new(() => new CompletionServiceWithRawResponse(client));
    }

    readonly Lazy<ICompletionServiceWithRawResponse> _completions;
    public ICompletionServiceWithRawResponse Completions
    {
        get { return _completions.Value; }
    }
}
