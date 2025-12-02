using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;

namespace ArcadeDotnet.Models.Tools;

/// <summary>
/// Returns the arcade tool specification for a specific tool
/// </summary>
public sealed record class ToolGetParams : ParamsBase
{
    public string? Name { get; init; }

    /// <summary>
    /// Comma separated tool formats that will be included in the response.
    /// </summary>
    public IReadOnlyList<ApiEnum<string, IncludeFormatModel>>? IncludeFormat
    {
        get
        {
            return ModelBase.GetNullableClass<List<ApiEnum<string, IncludeFormatModel>>>(
                this.RawQueryData,
                "include_format"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawQueryData, "include_format", value);
        }
    }

    /// <summary>
    /// User ID
    /// </summary>
    public string? UserID
    {
        get { return ModelBase.GetNullableClass<string>(this.RawQueryData, "user_id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawQueryData, "user_id", value);
        }
    }

    public ToolGetParams() { }

    public ToolGetParams(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData
    )
    {
        this._rawHeaderData = [.. rawHeaderData];
        this._rawQueryData = [.. rawQueryData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ToolGetParams(
        FrozenDictionary<string, JsonElement> rawHeaderData,
        FrozenDictionary<string, JsonElement> rawQueryData
    )
    {
        this._rawHeaderData = [.. rawHeaderData];
        this._rawQueryData = [.. rawQueryData];
    }
#pragma warning restore CS8618

    public static ToolGetParams FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData
    )
    {
        return new(
            FrozenDictionary.ToFrozenDictionary(rawHeaderData),
            FrozenDictionary.ToFrozenDictionary(rawQueryData)
        );
    }

    public override Uri Url(ClientOptions options)
    {
        return new UriBuilder(
            options.BaseUrl.ToString().TrimEnd('/') + string.Format("/v1/tools/{0}", this.Name)
        )
        {
            Query = this.QueryString(options),
        }.Uri;
    }

    internal override void AddHeadersToRequest(HttpRequestMessage request, ClientOptions options)
    {
        ParamsBase.AddDefaultHeaders(request, options);
        foreach (var item in this.RawHeaderData)
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
        Type typeToConvert,
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
