using System.Threading.Tasks;

namespace ArcadeDotnet.Tests.Services.Admin.AuthProviders;

public class AuthProviderServiceTest : TestBase
{
    [Fact]
    public async Task Create_Works()
    {
        var authProviderResponse = await this.Client.Admin.AuthProviders.Create(
            new() { ID = "id" }
        );
        authProviderResponse.Validate();
    }

    [Fact]
    public async Task List_Works()
    {
        var authProviders = await this.Client.Admin.AuthProviders.List();
        authProviders.Validate();
    }

    [Fact]
    public async Task Delete_Works()
    {
        var authProviderResponse = await this.Client.Admin.AuthProviders.Delete(
            new() { ID = "id" }
        );
        authProviderResponse.Validate();
    }

    [Fact]
    public async Task Get_Works()
    {
        var authProviderResponse = await this.Client.Admin.AuthProviders.Get(new() { ID = "id" });
        authProviderResponse.Validate();
    }

    [Fact]
    public async Task Patch_Works()
    {
        var authProviderResponse = await this.Client.Admin.AuthProviders.Patch(new() { ID = "id" });
        authProviderResponse.Validate();
    }
}
