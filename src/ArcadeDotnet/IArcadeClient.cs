using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Services.Admin;
using ArcadeDotnet.Services.Auth;
using ArcadeDotnet.Services.Chat;
using ArcadeDotnet.Services.Health;
using ArcadeDotnet.Services.Tools;
using ArcadeDotnet.Services.Workers;

namespace ArcadeDotnet;

public interface IArcadeClient
{
    HttpClient HttpClient { get; init; }

    Uri BaseUrl { get; init; }

    bool ResponseValidation { get; init; }

    int MaxRetries { get; init; }

    TimeSpan Timeout { get; init; }

    /// <summary>
    /// API key used for authorization in header
    /// </summary>
    string APIKey { get; init; }

    IArcadeClient WithOptions(Func<ClientOptions, ClientOptions> modifier);

    IAdminService Admin { get; }

    IAuthService Auth { get; }

    IHealthService Health { get; }

    IChatService Chat { get; }

    IToolService Tools { get; }

    IWorkerService Workers { get; }

    Task<HttpResponse> Execute<T>(
        HttpRequest<T> request,
        CancellationToken cancellationToken = default
    )
        where T : ParamsBase;
}
