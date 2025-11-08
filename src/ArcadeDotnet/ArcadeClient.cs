using System;
using System.Net.Http;
using System.Threading;
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
    readonly ClientOptions _options;

    public HttpClient HttpClient
    {
        get { return this._options.HttpClient; }
        init { this._options.HttpClient = value; }
    }

    public Uri BaseUrl
    {
        get { return this._options.BaseUrl; }
        init { this._options.BaseUrl = value; }
    }

    public bool ResponseValidation
    {
        get { return this._options.ResponseValidation; }
        init { this._options.ResponseValidation = value; }
    }

    public TimeSpan Timeout
    {
        get { return this._options.Timeout; }
        init { this._options.Timeout = value; }
    }

    public string APIKey
    {
        get { return this._options.APIKey; }
        init { this._options.APIKey = value; }
    }

    public IArcadeClient WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ArcadeClient(modifier(this._options));
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

    public async Task<HttpResponse> Execute<T>(
        HttpRequest<T> request,
        CancellationToken cancellationToken = default
    )
        where T : ParamsBase
    {
        using HttpRequestMessage requestMessage = new(request.Method, request.Params.Url(this))
        {
            Content = request.Params.BodyContent(),
        };
        request.Params.AddHeadersToRequest(requestMessage, this);
        using CancellationTokenSource timeoutCts = new(this.Timeout);
        using var cts = CancellationTokenSource.CreateLinkedTokenSource(
            timeoutCts.Token,
            cancellationToken
        );
        HttpResponseMessage responseMessage;
        try
        {
            responseMessage = await this
                .HttpClient.SendAsync(
                    requestMessage,
                    HttpCompletionOption.ResponseHeadersRead,
                    cts.Token
                )
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
                    await responseMessage.Content.ReadAsStringAsync(cts.Token).ConfigureAwait(false)
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
        return new() { Message = responseMessage, CancellationToken = cts.Token };
    }

    public ArcadeClient()
    {
        _options = new();

        _admin = new(() => new AdminService(this));
        _auth = new(() => new AuthService(this));
        _health = new(() => new HealthService(this));
        _chat = new(() => new ChatService(this));
        _tools = new(() => new ToolService(this));
        _workers = new(() => new WorkerService(this));
    }

    public ArcadeClient(ClientOptions options)
        : this()
    {
        _options = options;
    }
}
