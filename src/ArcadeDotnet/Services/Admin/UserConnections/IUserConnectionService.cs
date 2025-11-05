using System;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Admin.UserConnections;

namespace ArcadeDotnet.Services.Admin.UserConnections;

public interface IUserConnectionService
{
    IUserConnectionService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// List all auth connections
    /// </summary>
    Task<UserConnectionListPageResponse> List(UserConnectionListParams? parameters = null);

    /// <summary>
    /// Delete a user/auth provider connection
    /// </summary>
    Task Delete(UserConnectionDeleteParams parameters);
}
