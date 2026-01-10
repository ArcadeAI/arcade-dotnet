using System;
using ArcadeDotnet.Core;
using ArcadeDotnet.Services.Admin;

namespace ArcadeDotnet.Services;

/// <inheritdoc/>
public sealed class AdminService : IAdminService
{
    readonly Lazy<IAdminServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IAdminServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly IArcadeClient _client;

    /// <inheritdoc/>
    public IAdminService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new AdminService(this._client.WithOptions(modifier));
    }

    public AdminService(IArcadeClient client)
    {
        _client = client;

        _withRawResponse = new(() => new AdminServiceWithRawResponse(client.WithRawResponse));
        _userConnections = new(() => new UserConnectionService(client));
        _authProviders = new(() => new AuthProviderService(client));
        _secrets = new(() => new SecretService(client));
    }

    readonly Lazy<IUserConnectionService> _userConnections;
    public IUserConnectionService UserConnections
    {
        get { return _userConnections.Value; }
    }

    readonly Lazy<IAuthProviderService> _authProviders;
    public IAuthProviderService AuthProviders
    {
        get { return _authProviders.Value; }
    }

    readonly Lazy<ISecretService> _secrets;
    public ISecretService Secrets
    {
        get { return _secrets.Value; }
    }
}

/// <inheritdoc/>
public sealed class AdminServiceWithRawResponse : IAdminServiceWithRawResponse
{
    readonly IArcadeClientWithRawResponse _client;

    /// <inheritdoc/>
    public IAdminServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new AdminServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public AdminServiceWithRawResponse(IArcadeClientWithRawResponse client)
    {
        _client = client;

        _userConnections = new(() => new UserConnectionServiceWithRawResponse(client));
        _authProviders = new(() => new AuthProviderServiceWithRawResponse(client));
        _secrets = new(() => new SecretServiceWithRawResponse(client));
    }

    readonly Lazy<IUserConnectionServiceWithRawResponse> _userConnections;
    public IUserConnectionServiceWithRawResponse UserConnections
    {
        get { return _userConnections.Value; }
    }

    readonly Lazy<IAuthProviderServiceWithRawResponse> _authProviders;
    public IAuthProviderServiceWithRawResponse AuthProviders
    {
        get { return _authProviders.Value; }
    }

    readonly Lazy<ISecretServiceWithRawResponse> _secrets;
    public ISecretServiceWithRawResponse Secrets
    {
        get { return _secrets.Value; }
    }
}
