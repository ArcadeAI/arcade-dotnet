using System;
using System.Net.Http;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Services.Admin;
using ArcadeDotnet.Services.Auth;
using ArcadeDotnet.Services.Chat;
using ArcadeDotnet.Services.Tools;
using ArcadeDotnet.Services.Workers;

namespace ArcadeDotnet;

/// <summary>
/// Interface for the Arcade API client.
/// </summary>
public interface IArcadeClient
{
    /// <summary>
    /// Gets the base URL for the API.
    /// </summary>
    Uri BaseUrl { get; }

    /// <summary>
    /// Gets the API key used for authorization.
    /// </summary>
    string APIKey { get; }

    IAdminService Admin { get; }

    IAuthService Auth { get; }


    IChatService Chat { get; }

    IToolService Tools { get; }

    IWorkerService Workers { get; }

    /// <summary>
    /// Executes an API request and returns the response.
    /// </summary>
    /// <typeparam name="TParams">The type of parameters.</typeparam>
    /// <param name="request">The request to execute.</param>
    /// <returns>The API response.</returns>
    /// <exception cref="ArcadeIOException">Thrown when an I/O error occurs.</exception>
    /// <exception cref="ArcadeApiException">Thrown when the API returns an error.</exception>
    Task<ArcadeResponse> Execute<TParams>(ArcadeRequest<TParams> request)
        where TParams : ParamsBase;
}
