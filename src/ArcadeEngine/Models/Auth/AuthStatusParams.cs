using System;
using System.Net.Http;
using System.Text.Json;
using ArcadeEngine.Core;
using ArcadeEngine.Exceptions;

namespace ArcadeEngine.Models.Auth;

/// <summary>
/// Checks the status of an ongoing authorization process for a specific tool. If
/// 'wait' param is present, does not respond until either the auth status becomes
/// completed or the timeout is reached.
/// </summary>
public sealed record class AuthStatusParams : ParamsBase
{
    /// <summary>
    /// Authorization ID
    /// </summary>
    public required string ID
    {
        get
        {
            if (!this.QueryProperties.TryGetValue("id", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'id' cannot be null",
                    new ArgumentOutOfRangeException("id", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'id' cannot be null",
                    new ArgumentNullException("id")
                );
        }
        set
        {
            this.QueryProperties["id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    /// <summary>
    /// Timeout in seconds (max 59)
    /// </summary>
    public long? Wait
    {
        get
        {
            if (!this.QueryProperties.TryGetValue("wait", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.QueryProperties["wait"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override Uri Url(IArcadeClient client)
    {
        return new UriBuilder(client.BaseUrl.ToString().TrimEnd('/') + "/v1/auth/status")
        {
            Query = this.QueryString(client),
        }.Uri;
    }

    internal override void AddHeadersToRequest(HttpRequestMessage request, IArcadeClient client)
    {
        ParamsBase.AddDefaultHeaders(request, client);
        foreach (var item in this.HeaderProperties)
        {
            ParamsBase.AddHeaderElementToRequest(request, item.Key, item.Value);
        }
    }
}
