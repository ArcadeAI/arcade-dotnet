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

public sealed class ArcadeClient : IArcadeClient
{
    public HttpClient HttpClient { get; init; } = new();

    Lazy<Uri> _baseUrl = new(() =>
        new Uri(Environment.GetEnvironmentVariable("ARCADE_BASE_URL") ?? "https://api.arcade.dev")
    );
    public Uri BaseUrl
    {
        get { return _baseUrl.Value; }
        init { _baseUrl = new(() => value); }
    }

    Lazy<string> _apiKey = new(() =>
        Environment.GetEnvironmentVariable("ARCADE_API_KEY")
        ?? throw new ArcadeInvalidDataException(
            string.Format("{0} cannot be null", nameof(APIKey)),
            new ArgumentNullException(nameof(APIKey))
        )
    );
    public string APIKey
    {
        get { return _apiKey.Value; }
        init { _apiKey = new(() => value); }
    }

    readonly Lazy<IAdminService> _admin;
    public IAdminService Admin
    {
        get { return _admin.Value; }
    }

    readonly Lazy<IAuthService> _auth;
    public IAuthService Auth
    {
        get { return _auth.Value; }
    }

    readonly Lazy<IHealthService> _health;
    public IHealthService Health
    {
        get { return _health.Value; }
    }

    readonly Lazy<IChatService> _chat;
    public IChatService Chat
    {
        get { return _chat.Value; }
    }

    readonly Lazy<IToolService> _tools;
    public IToolService Tools
    {
        get { return _tools.Value; }
    }

    readonly Lazy<IWorkerService> _workers;
    public IWorkerService Workers
    {
        get { return _workers.Value; }
    }

    public async Task<HttpResponse> Execute<T>(HttpRequest<T> request)
        where T : ParamsBase
    {
        using HttpRequestMessage requestMessage = new(request.Method, request.Params.Url(this))
        {
            Content = request.Params.BodyContent(),
        };
        request.Params.AddHeadersToRequest(requestMessage, this);
        HttpResponseMessage responseMessage;
        try
        {
            responseMessage = await this
                .HttpClient.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead)
                .ConfigureAwait(false);
        }
        catch (HttpRequestException e1)
        {
            throw new ArcadeIOException("I/O exception", e1);
        }
        if (!responseMessage.IsSuccessStatusCode)
        {
            try
            {
                throw ArcadeExceptionFactory.CreateApiException(
                    responseMessage.StatusCode,
                    await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false)
                );
            }
            catch (HttpRequestException e)
            {
                throw new ArcadeIOException("I/O Exception", e);
            }
            finally
            {
                responseMessage.Dispose();
            }
        }
        return new() { Message = responseMessage };
    }

    public ArcadeClient()
    {
        _admin = new(() => new AdminService(this));
        _auth = new(() => new AuthService(this));
        _health = new(() => new HealthService(this));
        _chat = new(() => new ChatService(this));
        _tools = new(() => new ToolService(this));
        _workers = new(() => new WorkerService(this));
    }
}
