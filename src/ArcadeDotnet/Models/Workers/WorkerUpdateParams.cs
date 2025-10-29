using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Workers.WorkerUpdateParamsProperties;

namespace ArcadeDotnet.Models.Workers;

/// <summary>
/// Update a worker
/// </summary>
public sealed record class WorkerUpdateParams : ParamsBase
{
    public Dictionary<string, JsonElement> BodyProperties { get; set; } = [];

    public required string ID;

    public bool? Enabled
    {
        get
        {
            if (!this.BodyProperties.TryGetValue("enabled", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.BodyProperties["enabled"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public HTTP? HTTP
    {
        get
        {
            if (!this.BodyProperties.TryGetValue("http", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<HTTP?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.BodyProperties["http"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Mcp? Mcp
    {
        get
        {
            if (!this.BodyProperties.TryGetValue("mcp", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Mcp?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.BodyProperties["mcp"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override Uri Url(IArcadeClient client)
    {
        return new UriBuilder(
            client.BaseUrl.ToString().TrimEnd('/') + string.Format("/v1/workers/{0}", this.ID)
        )
        {
            Query = this.QueryString(client),
        }.Uri;
    }

    internal override StringContent? BodyContent()
    {
        return new(
            JsonSerializer.Serialize(this.BodyProperties),
            Encoding.UTF8,
            "application/json"
        );
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
