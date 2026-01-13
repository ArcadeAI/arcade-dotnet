using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using ArcadeDotnet.Models.Admin.Secrets;

namespace ArcadeDotnet.Services.Admin;

/// <inheritdoc/>
public sealed class SecretService : ISecretService
{
    readonly Lazy<ISecretServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public ISecretServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly IArcadeClient _client;

    /// <inheritdoc/>
    public ISecretService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new SecretService(this._client.WithOptions(modifier));
    }

    public SecretService(IArcadeClient client)
    {
        _client = client;

        _withRawResponse = new(() => new SecretServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<SecretResponse> Create(
        SecretCreateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Create(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<SecretResponse> Create(
        string secretKey,
        SecretCreateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        return this.Create(parameters with { SecretKey = secretKey }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<SecretListResponse> List(
        SecretListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.List(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task Delete(SecretDeleteParams parameters, CancellationToken cancellationToken = default)
    {
        return this.WithRawResponse.Delete(parameters, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task Delete(
        string secretID,
        SecretDeleteParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        await this.Delete(parameters with { SecretID = secretID }, cancellationToken)
            .ConfigureAwait(false);
    }
}

/// <inheritdoc/>
public sealed class SecretServiceWithRawResponse : ISecretServiceWithRawResponse
{
    readonly IArcadeClientWithRawResponse _client;

    /// <inheritdoc/>
    public ISecretServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new SecretServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public SecretServiceWithRawResponse(IArcadeClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<SecretResponse>> Create(
        SecretCreateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.SecretKey == null)
        {
            throw new ArcadeInvalidDataException("'parameters.SecretKey' cannot be null");
        }

        HttpRequest<SecretCreateParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var secretResponse = await response
                    .Deserialize<SecretResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    secretResponse.Validate();
                }
                return secretResponse;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<SecretResponse>> Create(
        string secretKey,
        SecretCreateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        return this.Create(parameters with { SecretKey = secretKey }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<SecretListResponse>> List(
        SecretListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<SecretListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var secrets = await response
                    .Deserialize<SecretListResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    secrets.Validate();
                }
                return secrets;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse> Delete(
        SecretDeleteParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.SecretID == null)
        {
            throw new ArcadeInvalidDataException("'parameters.SecretID' cannot be null");
        }

        HttpRequest<SecretDeleteParams> request = new()
        {
            Method = HttpMethod.Delete,
            Params = parameters,
        };
        return this._client.Execute(request, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<HttpResponse> Delete(
        string secretID,
        SecretDeleteParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Delete(parameters with { SecretID = secretID }, cancellationToken);
    }
}
