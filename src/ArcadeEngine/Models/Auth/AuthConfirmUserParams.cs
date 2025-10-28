using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using ArcadeEngine.Core;
using ArcadeEngine.Exceptions;

namespace ArcadeEngine.Models.Auth;

/// <summary>
/// Confirms a user's details during an authorization flow
/// </summary>
public sealed record class AuthConfirmUserParams : ParamsBase
{
    public Dictionary<string, JsonElement> BodyProperties { get; set; } = [];

    public required string FlowID
    {
        get
        {
            if (!this.BodyProperties.TryGetValue("flow_id", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'flow_id' cannot be null",
                    new ArgumentOutOfRangeException("flow_id", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'flow_id' cannot be null",
                    new ArgumentNullException("flow_id")
                );
        }
        set
        {
            this.BodyProperties["flow_id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required string UserID
    {
        get
        {
            if (!this.BodyProperties.TryGetValue("user_id", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'user_id' cannot be null",
                    new ArgumentOutOfRangeException("user_id", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'user_id' cannot be null",
                    new ArgumentNullException("user_id")
                );
        }
        set
        {
            this.BodyProperties["user_id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override Uri Url(IArcadeClient client)
    {
        return new UriBuilder(client.BaseUrl.ToString().TrimEnd('/') + "/v1/auth/confirm_user")
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
