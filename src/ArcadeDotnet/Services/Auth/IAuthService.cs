using System.Threading.Tasks;
using ArcadeDotnet.Models;
using ArcadeDotnet.Models.Auth;

namespace ArcadeDotnet.Services.Auth;

public interface IAuthService
{
    /// <summary>
    /// Starts the authorization process for given authorization requirements
    /// </summary>
    Task<AuthorizationResponse> Authorize(AuthAuthorizeParams parameters);

    /// <summary>
    /// Confirms a user's details during an authorization flow
    /// </summary>
    Task<ConfirmUserResponse> ConfirmUser(AuthConfirmUserParams parameters);

    /// <summary>
    /// Checks the status of an ongoing authorization process for a specific tool.
    /// If 'wait' param is present, does not respond until either the auth status
    /// becomes completed or the timeout is reached.
    /// </summary>
    Task<AuthorizationResponse> Status(AuthStatusParams parameters);
}
