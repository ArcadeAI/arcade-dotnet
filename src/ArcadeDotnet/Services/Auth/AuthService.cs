using System.Net.Http;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models;
using ArcadeDotnet.Models.Auth;

namespace ArcadeDotnet.Services.Auth;

public sealed class AuthService : IAuthService
{
    readonly IArcadeClient _client;

    public AuthService(IArcadeClient client)
    {
        _client = client;
    }

    public async Task<AuthorizationResponse> Authorize(AuthAuthorizeParams parameters)
    {
        HttpRequest<AuthAuthorizeParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<AuthorizationResponse>().ConfigureAwait(false);
    }

    public async Task<ConfirmUserResponse> ConfirmUser(AuthConfirmUserParams parameters)
    {
        HttpRequest<AuthConfirmUserParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<ConfirmUserResponse>().ConfigureAwait(false);
    }

    public async Task<AuthorizationResponse> Status(AuthStatusParams parameters)
    {
        HttpRequest<AuthStatusParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<AuthorizationResponse>().ConfigureAwait(false);
    }
}
