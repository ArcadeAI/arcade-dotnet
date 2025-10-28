using System;
using System.Net.Http;
using System.Threading.Tasks;
using ArcadeEngine.Core;
using ArcadeEngine.Services.Admin;
using ArcadeEngine.Services.Auth;
using ArcadeEngine.Services.Chat;
using ArcadeEngine.Services.Health;
using ArcadeEngine.Services.Tools;
using ArcadeEngine.Services.Workers;

namespace ArcadeEngine;

public interface IArcadeClient
{
    HttpClient HttpClient { get; init; }

    Uri BaseUrl { get; init; }

    /// <summary>
    /// API key used for authorization in header
    /// </summary>
    string APIKey { get; init; }

    IAdminService Admin { get; }

    IAuthService Auth { get; }

    IHealthService Health { get; }

    IChatService Chat { get; }

    IToolService Tools { get; }

    IWorkerService Workers { get; }

    Task<HttpResponse> Execute<T>(HttpRequest<T> request)
        where T : ParamsBase;
}
