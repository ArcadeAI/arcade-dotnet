using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using Secrets = ArcadeDotnet.Models.Admin.Secrets;

namespace ArcadeDotnet.Services.Admin.Secrets;

public sealed class SecretService : ISecretService
{
    public ISecretService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new SecretService(this._client.WithOptions(modifier));
    }

    readonly IArcadeClient _client;

    public SecretService(IArcadeClient client)
    {
        _client = client;
    }

    public async Task<Secrets::SecretListResponse> List(
        Secrets::SecretListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<Secrets::SecretListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var secrets = await response
            .Deserialize<Secrets::SecretListResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            secrets.Validate();
        }
        return secrets;
    }

    public async Task Delete(
        Secrets::SecretDeleteParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<Secrets::SecretDeleteParams> request = new()
        {
            Method = HttpMethod.Delete,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
    }
}
