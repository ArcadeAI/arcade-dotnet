using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Tools.ToolGetParamsProperties;

namespace ArcadeDotnet.Models.Tools;

/// <summary>
/// Returns the arcade tool specification for a specific tool
/// </summary>
public sealed record class ToolGetParams : ParamsBase
{
    public required string Name;

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
        return new UriBuilder(
            client.BaseUrl.ToString().TrimEnd('/') + string.Format("/v1/tools/{0}", this.Name)
        )
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
