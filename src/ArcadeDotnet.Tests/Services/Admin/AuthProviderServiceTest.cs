using System.Threading.Tasks;

namespace ArcadeDotnet.Tests.Services.Admin;

public class AuthProviderServiceTest : TestBase
{
    [Fact]
    public async Task Create_Works()
    {
        var authProviderResponse = await this.client.Admin.AuthProviders.Create(
            new() { ID = "id" },
            TestContext.Current.CancellationToken
        );
        authProviderResponse.Validate();
    }

    [Fact]
    public async Task List_Works()
    {
        var authProviders = await this.client.Admin.AuthProviders.List(
            new(),
            TestContext.Current.CancellationToken
        );
        authProviders.Validate();
    }

    [Fact]
    public async Task Delete_Works()
    {
        var authProviderResponse = await this.client.Admin.AuthProviders.Delete(
            "id",
            new(),
            TestContext.Current.CancellationToken
        );
        authProviderResponse.Validate();
    }

    [Fact]
    public async Task Get_Works()
    {
        var authProviderResponse = await this.client.Admin.AuthProviders.Get(
            "id",
            new(),
            TestContext.Current.CancellationToken
        );
        authProviderResponse.Validate();
    }

    [Fact]
    public async Task Patch_Works()
    {
        var authProviderResponse = await this.client.Admin.AuthProviders.Patch(
            "id",
            new(),
            TestContext.Current.CancellationToken
        );
        authProviderResponse.Validate();
    }
}
