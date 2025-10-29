using System.Threading.Tasks;
using ArcadeDotnet.Models.Admin.UserConnections;

namespace ArcadeDotnet.Services.Admin.UserConnections;

public interface IUserConnectionService
{
    /// <summary>
    /// List all auth connections
    /// </summary>
    Task<UserConnectionListPageResponse> List(UserConnectionListParams? parameters = null);

    /// <summary>
    /// Delete a user/auth provider connection
    /// </summary>
    Task Delete(UserConnectionDeleteParams parameters);
}
