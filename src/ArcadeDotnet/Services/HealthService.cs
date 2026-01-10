using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Health;

namespace ArcadeDotnet.Services;

/// <inheritdoc/>
public sealed class HealthService : IHealthService
{
    readonly Lazy<IHealthServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IHealthServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly IArcadeClient _client;

    /// <inheritdoc/>
    public IHealthService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new HealthService(this._client.WithOptions(modifier));
    }

    public HealthService(IArcadeClient client)
    {
        _client = client;

        _withRawResponse = new(() => new HealthServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<HealthSchema> Check(
        HealthCheckParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Check(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }
}

/// <inheritdoc/>
public sealed class HealthServiceWithRawResponse : IHealthServiceWithRawResponse
{
    readonly IArcadeClientWithRawResponse _client;

    /// <inheritdoc/>
    public IHealthServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new HealthServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public HealthServiceWithRawResponse(IArcadeClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<HealthSchema>> Check(
        HealthCheckParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<HealthCheckParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var healthSchema = await response
                    .Deserialize<HealthSchema>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    healthSchema.Validate();
                }
                return healthSchema;
            }
        );
    }
}
