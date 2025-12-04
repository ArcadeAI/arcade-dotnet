using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using ArcadeDotnet.Models.Tools.Formatted;

namespace ArcadeDotnet.Services.Tools;

/// <inheritdoc/>
public sealed class FormattedService : IFormattedService
{
    /// <inheritdoc/>
    public IFormattedService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new FormattedService(this._client.WithOptions(modifier));
    }

    readonly IArcadeClient _client;

    public FormattedService(IArcadeClient client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<FormattedListPageResponse> List(
        FormattedListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<FormattedListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        var page = await response
            .Deserialize<FormattedListPageResponse>(cancellationToken)
            .ConfigureAwait(false);
        if (this._client.ResponseValidation)
        {
            page.Validate();
        }
        return page;
    }

    /// <inheritdoc/>
    public async Task<JsonElement> Get(
        FormattedGetParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.Name == null)
        {
            throw new ArcadeInvalidDataException("'parameters.Name' cannot be null");
        }

        HttpRequest<FormattedGetParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        using var response = await this
            ._client.Execute(request, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize<JsonElement>(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<JsonElement> Get(
        string name,
        FormattedGetParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return await this.Get(parameters with { Name = name }, cancellationToken);
    }
}
