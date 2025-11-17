using System;
using System.Net.Http;
using System.Threading.Tasks;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using ArcadeDotnet.Services.Admin;
using ArcadeDotnet.Services.Auth;
using ArcadeDotnet.Services.Chat;
using ArcadeDotnet.Services.Health;
using ArcadeDotnet.Services.Tools;
using ArcadeDotnet.Services.Workers;

namespace ArcadeDotnet;

/// <summary>
/// The main client for interacting with the Arcade API.
/// </summary>
/// <remarks>
/// Implements <see cref="IDisposable"/> for proper resource management.
/// When using dependency injection, register as a singleton.
/// </remarks>
public sealed class ArcadeClient : IArcadeClient, IDisposable
{
    private readonly bool _ownsHttpClient;
    private readonly HttpClient _httpClient;

    /// <summary>
    /// Gets the HttpClient instance used for making HTTP requests.
    /// </summary>
    public HttpClient HttpClient => _httpClient;

    /// <summary>
    /// Gets the base URL for the API.
    /// </summary>
    public Uri BaseUrl { get; }

    /// <summary>
    /// Gets the API key used for authorization.
    /// </summary>
    public string APIKey { get; }

    /// <summary>
    /// Gets the admin service for administrative operations.
    /// </summary>
    public IAdminService Admin { get; }

    /// <summary>
    /// Gets the authentication service.
    /// </summary>
    public IAuthService Auth { get; }

    /// <summary>
    /// Gets the health check service.
    /// </summary>
    public IHealthService Health { get; }

    /// <summary>
    /// Gets the chat service.
    /// </summary>
    public IChatService Chat { get; }

    /// <summary>
    /// Gets the tool service.
    /// </summary>
    public IToolService Tools { get; }

    /// <summary>
    /// Gets the worker service.
    /// </summary>
    public IWorkerService Workers { get; }

    /// <summary>
    /// Executes an API request and returns the response.
    /// </summary>
    /// <typeparam name="TParams">The type of parameters.</typeparam>
    /// <param name="request">The request to execute.</param>
    /// <returns>The API response.</returns>
    /// <exception cref="ArcadeIOException">Thrown when an I/O error occurs.</exception>
    /// <exception cref="ArcadeApiException">Thrown when the API returns an error.</exception>
    public async Task<ArcadeResponse> Execute<TParams>(ArcadeRequest<TParams> request)
        where TParams : ParamsBase
    {
        ArgumentNullException.ThrowIfNull(request);
        ArgumentNullException.ThrowIfNull(request.Params);

        using HttpRequestMessage requestMessage = new(request.Method, request.Params.Url(this))
        {
            Content = request.Params.BodyContent(),
        };
        request.Params.AddHeadersToRequest(requestMessage, this);

        HttpResponseMessage responseMessage;
        try
        {
            responseMessage = await HttpClient
                .SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead)
                .ConfigureAwait(false);
        }
        catch (HttpRequestException ex)
        {
            throw new ArcadeIOException("I/O exception occurred during HTTP request", ex);
        }

        if (!responseMessage.IsSuccessStatusCode)
        {
            try
            {
                var responseBody = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
                throw ArcadeExceptionFactory.CreateApiException(responseMessage.StatusCode, responseBody);
            }
            catch (HttpRequestException ex)
            {
                throw new ArcadeIOException("I/O exception occurred while reading error response", ex);
            }
            finally
            {
                responseMessage.Dispose();
            }
        }

        return new ArcadeResponse { Message = responseMessage };
    }

    /// <summary>
    /// Initializes a new instance using configuration from environment variables.
    /// </summary>
    public ArcadeClient() : this(ArcadeClientOptions.FromEnvironment())
    {
    }

    /// <summary>
    /// Initializes a new instance with the specified options.
    /// </summary>
    /// <param name="options">The configuration options.</param>
    /// <exception cref="ArgumentNullException">Thrown when options is null.</exception>
    /// <exception cref="ArcadeInvalidDataException">Thrown when required configuration is missing.</exception>
    public ArcadeClient(ArcadeClientOptions options)
    {
        ArgumentNullException.ThrowIfNull(options);

        // Configure base URL
        BaseUrl = options.BaseUrl 
            ?? new Uri(ArcadeClientOptions.DefaultBaseUrl);

        // Configure API key (required)
        APIKey = options.ApiKey 
            ?? throw new ArcadeInvalidDataException(
                $"API key is required. Set via {nameof(ArcadeClientOptions)}.{nameof(ArcadeClientOptions.ApiKey)} " +
                $"or {ArcadeClientOptions.ApiKeyEnvironmentVariable} environment variable.");

        // Configure HttpClient
        if (options.HttpClient != null)
        {
            _httpClient = options.HttpClient;
            _ownsHttpClient = false;
        }
        else
        {
            _httpClient = new HttpClient();
            _ownsHttpClient = true;
        }

        // Initialize services
        Admin = new AdminService(this);
        Auth = new AuthService(this);
        Health = new HealthService(this);
        Chat = new ChatService(this);
        Tools = new ToolService(this);
        Workers = new WorkerService(this);
    }

    /// <summary>
    /// Disposes resources.
    /// </summary>
    public void Dispose()
    {
        if (_ownsHttpClient)
        {
            _httpClient.Dispose();
        }
    }
}
