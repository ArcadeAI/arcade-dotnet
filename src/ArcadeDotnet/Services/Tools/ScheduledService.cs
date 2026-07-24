using System;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Services.Tools;

/// <inheritdoc/>
public sealed class ScheduledService : IScheduledService
{
    readonly Lazy<IScheduledServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IScheduledServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly IArcadeClient _client;

    /// <inheritdoc/>
    public IScheduledService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ScheduledService(this._client.WithOptions(modifier));
    }

    public ScheduledService(IArcadeClient client)
    {
        _client = client;

        _withRawResponse = new(() => new ScheduledServiceWithRawResponse(client.WithRawResponse));
    }
}

/// <inheritdoc/>
public sealed class ScheduledServiceWithRawResponse : IScheduledServiceWithRawResponse
{
    readonly IArcadeClientWithRawResponse _client;

    /// <inheritdoc/>
    public IScheduledServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ScheduledServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public ScheduledServiceWithRawResponse(IArcadeClientWithRawResponse client)
    {
        _client = client;
    }
}
