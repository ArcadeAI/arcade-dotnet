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
    /// <inheritdoc/>
    public ISecretService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new SecretService(this._client.WithOptions(modifier));
    }

    readonly IArcadeClient _client;

    public SecretService(IArcadeClient client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<SecretResponse> Create(
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
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var secretResponse = await response
            .Deserialize<SecretResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            secretResponse.Validate();
        }
        return secretResponse;
    }

    /// <inheritdoc/>
    public async Task<SecretResponse> Create(
        string secretKey,
        SecretCreateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        return await this.Create(parameters with { SecretKey = secretKey }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<SecretListResponse> List(
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
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var secrets = await response
            .Deserialize<SecretListResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            secrets.Validate();
        }
        return secrets;
    }

    /// <inheritdoc/>
    public async Task Delete(
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
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task Delete(
        string secretID,
        SecretDeleteParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        await this.Delete(parameters with { SecretID = secretID }, cancellationToken);
    }
}
