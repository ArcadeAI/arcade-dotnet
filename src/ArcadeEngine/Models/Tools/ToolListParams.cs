using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using ArcadeEngine.Core;
using ArcadeEngine.Models.Tools.ToolListParamsProperties;

namespace ArcadeEngine.Models.Tools;

/// <summary>
/// Returns a page of tools from the engine configuration, optionally filtered by toolkit
/// </summary>
public sealed record class ToolListParams : ParamsBase
{
    /// <summary>
    /// Comma separated tool formats that will be included in the response.
    /// </summary>
    public List<ApiEnum<string, IncludeFormat>>? IncludeFormat
    {
        get
        {
            if (!this.QueryProperties.TryGetValue("include_format", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<List<ApiEnum<string, IncludeFormat>>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.QueryProperties["include_format"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    /// <summary>
    /// Number of items to return (default: 25, max: 100)
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
    /// Offset from the start of the list (default: 0)
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

    /// <summary>
    /// Toolkit name
    /// </summary>
    public string? Toolkit
    {
        get
        {
            if (!this.QueryProperties.TryGetValue("toolkit", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.QueryProperties["toolkit"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    /// <summary>
    /// User ID
    /// </summary>
    public string? UserID
    {
        get
        {
            if (!this.QueryProperties.TryGetValue("user_id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.QueryProperties["user_id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override Uri Url(IArcadeClient client)
    {
        return new UriBuilder(client.BaseUrl.ToString().TrimEnd('/') + "/v1/tools")
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
