using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Tools.Formatted;

namespace ArcadeDotnet.Services.Tools.Formatted;

public sealed class FormattedService : IFormattedService
{
    readonly IArcadeClient _client;

    public FormattedService(IArcadeClient client)
    {
        _client = client;
    }

    public async Task<FormattedListPageResponse> List(FormattedListParams? parameters = null)
    {
        parameters ??= new();

        HttpRequest<FormattedListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        var page = await response.Deserialize<FormattedListPageResponse>().ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            page.Validate();
        }
        return page;
    }

    public async Task<JsonElement> Get(FormattedGetParams parameters)
    {
        HttpRequest<FormattedGetParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this._client.Execute(request).ConfigureAwait(false);
        return await response.Deserialize<JsonElement>().ConfigureAwait(false);
    }
}
