using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Chat;
using ArcadeDotnet.Models.Chat.Completions;

namespace ArcadeDotnet.Services.Chat;

/// <inheritdoc/>
public sealed class CompletionService : ICompletionService
{
    readonly Lazy<ICompletionServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public ICompletionServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly IArcadeClient _client;

    /// <inheritdoc/>
    public ICompletionService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new CompletionService(this._client.WithOptions(modifier));
    }

    public CompletionService(IArcadeClient client)
    {
        _client = client;

        _withRawResponse = new(() => new CompletionServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<ChatResponse> Create(
        CompletionCreateParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Create(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }
}

/// <inheritdoc/>
public sealed class CompletionServiceWithRawResponse : ICompletionServiceWithRawResponse
{
    readonly IArcadeClientWithRawResponse _client;

    /// <inheritdoc/>
    public ICompletionServiceWithRawResponse WithOptions(
        Func<ClientOptions, ClientOptions> modifier
    )
    {
        return new CompletionServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public CompletionServiceWithRawResponse(IArcadeClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<ChatResponse>> Create(
        CompletionCreateParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<CompletionCreateParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var chatResponse = await response
                    .Deserialize<ChatResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    chatResponse.Validate();
                }
                return chatResponse;
            }
        );
    }
}
