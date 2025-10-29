using System.Threading.Tasks;

namespace ArcadeDotnet.Tests.Services.Auth;

public class AuthServiceTest : TestBase
{
    [Fact]
    public async Task Authorize_Works()
    {
        var authorizationResponse = await this.client.Auth.Authorize(
            new()
            {
                AuthRequirement = new()
                {
                    ID = "id",
                    Oauth2 = new() { Scopes = ["string"] },
                    ProviderID = "provider_id",
                    ProviderType = "provider_type",
                },
                UserID = "user_id",
            }
        );
        authorizationResponse.Validate();
    }

    [Fact]
    public async Task ConfirmUser_Works()
    {
        var confirmUserResponse = await this.client.Auth.ConfirmUser(
            new() { FlowID = "flow_id", UserID = "user_id" }
        );
        confirmUserResponse.Validate();
    }

    [Fact]
    public async Task Status_Works()
    {
        var authorizationResponse = await this.client.Auth.Status(new() { ID = "id" });
        authorizationResponse.Validate();
    }
}
