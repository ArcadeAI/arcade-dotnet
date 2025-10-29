using System;
using System.Net.Http;
using System.Text.Json;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Admin.UserConnections.UserConnectionListParamsProperties;

namespace ArcadeDotnet.Models.Admin.UserConnections;

/// <summary>
/// List all auth connections
/// </summary>
public sealed record class UserConnectionListParams : ParamsBase
{
    /// <summary>
    /// Page size
    /// </summary>
    public long? Limit
    {
        get
        {
            if (!this.QueryProperties.TryGetValue("limit", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.QueryProperties["limit"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    /// <summary>
    /// Page offset
    /// </summary>
    public long? Offset
    {
        get
        {
            if (!this.QueryProperties.TryGetValue("offset", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.QueryProperties["offset"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Provider? Provider
    {
        get
        {
            if (!this.QueryProperties.TryGetValue("provider", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Provider?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.QueryProperties["provider"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public User? User
    {
        get
        {
            if (!this.QueryProperties.TryGetValue("user", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<User?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.QueryProperties["user"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override Uri Url(IArcadeClient client)
    {
        return new UriBuilder(client.BaseUrl.ToString().TrimEnd('/') + "/v1/admin/user_connections")
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
