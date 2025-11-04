using System.Net.Http;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Admin.UserConnections;

namespace ArcadeDotnet.Services.Admin.UserConnections;

public sealed class UserConnectionService : IUserConnectionService
{
    readonly IArcadeClient _client;

    public UserConnectionService(IArcadeClient client)
    {
        _client = client;
    }

    public async Task<UserConnectionListPageResponse> List(
        UserConnectionListParams? parameters = null
    )
    {
        parameters ??= new();

        HttpRequest<UserConnectionListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        var page = await response
            .Deserialize<UserConnectionListPageResponse>()
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            page.Validate();
        }
        return page;
    }

    public async Task Delete(UserConnectionDeleteParams parameters)
    {
        HttpRequest<UserConnectionDeleteParams> request = new()
        {
            Method = HttpMethod.Delete,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
    }
}
