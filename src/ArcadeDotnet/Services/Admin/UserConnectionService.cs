using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Admin.UserConnections;

namespace ArcadeDotnet.Services.Admin;

public sealed class UserConnectionService : IUserConnectionService
{
    public IUserConnectionService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new UserConnectionService(this._client.WithOptions(modifier));
    }

    readonly IArcadeClient _client;

    public UserConnectionService(IArcadeClient client)
    {
        _client = client;
    }

    public async Task<UserConnectionListPageResponse> List(
        UserConnectionListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<UserConnectionListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var page = await response
            .Deserialize<UserConnectionListPageResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            page.Validate();
        }
        return page;
    }

    public async Task Delete(
        UserConnectionDeleteParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<UserConnectionDeleteParams> request = new()
        {
            Method = HttpMethod.Delete,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
    }
}
