using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using System = System;

namespace ArcadeDotnet.Models.Tools;

/// <summary>
/// Returns the arcade tool specification for a specific tool
/// </summary>
public sealed record class ToolGetParams : ParamsBase
{
    public required string Name { get; init; }

    /// <summary>
    /// Comma separated tool formats that will be included in the response.
    /// </summary>
    public List<ApiEnum<string, IncludeFormatModel>>? IncludeFormat
    {
        get
        {
            if (!this._queryProperties.TryGetValue("include_format", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<List<ApiEnum<string, IncludeFormatModel>>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            this._queryProperties["include_format"] = JsonSerializer.SerializeToElement(
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
            if (!this._queryProperties.TryGetValue("user_id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            this._queryProperties["user_id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public ToolGetParams() { }

    public ToolGetParams(
        IReadOnlyDictionary<string, JsonElement> headerProperties,
        IReadOnlyDictionary<string, JsonElement> queryProperties
    )
    {
        this._headerProperties = [.. headerProperties];
        this._queryProperties = [.. queryProperties];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ToolGetParams(
        FrozenDictionary<string, JsonElement> headerProperties,
        FrozenDictionary<string, JsonElement> queryProperties
    )
    {
        this._headerProperties = [.. headerProperties];
        this._queryProperties = [.. queryProperties];
    }
#pragma warning restore CS8618

    public static ToolGetParams FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> headerProperties,
        IReadOnlyDictionary<string, JsonElement> queryProperties
    )
    {
        return new(
            FrozenDictionary.ToFrozenDictionary(headerProperties),
            FrozenDictionary.ToFrozenDictionary(queryProperties)
        );
    }

    public override System::Uri Url(IArcadeClient client)
    {
        return new System::UriBuilder(
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

[JsonConverter(typeof(IncludeFormatModelConverter))]
public enum IncludeFormatModel
{
    Arcade,
    OpenAI,
    Anthropic,
}

sealed class IncludeFormatModelConverter : JsonConverter<IncludeFormatModel>
{
    public override IncludeFormatModel Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "arcade" => IncludeFormatModel.Arcade,
            "openai" => IncludeFormatModel.OpenAI,
            "anthropic" => IncludeFormatModel.Anthropic,
            _ => (IncludeFormatModel)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        IncludeFormatModel value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                IncludeFormatModel.Arcade => "arcade",
                IncludeFormatModel.OpenAI => "openai",
                IncludeFormatModel.Anthropic => "anthropic",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
