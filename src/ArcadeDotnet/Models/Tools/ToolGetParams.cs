using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
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
    public IReadOnlyList<ApiEnum<string, ToolGetParamsIncludeFormat>>? IncludeFormat
    {
        get
        {
            return this._rawQueryData.GetNullableStruct<
                ImmutableArray<ApiEnum<string, ToolGetParamsIncludeFormat>>
            >("include_format");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set<ImmutableArray<ApiEnum<string, ToolGetParamsIncludeFormat>>?>(
                "include_format",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// User ID
    /// </summary>
    public string? UserID
    {
        get { return this._rawQueryData.GetNullableClass<string>("user_id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("user_id", value);
        }
    }

    public ToolGetParams() { }

    public ToolGetParams(ToolGetParams toolGetParams)
        : base(toolGetParams)
    {
        this.Name = toolGetParams.Name;
    }

    public ToolGetParams(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData
    )
    {
        this._rawHeaderData = new(rawHeaderData);
        this._rawQueryData = new(rawQueryData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ToolGetParams(
        FrozenDictionary<string, JsonElement> rawHeaderData,
        FrozenDictionary<string, JsonElement> rawQueryData
    )
    {
        this._rawHeaderData = new(rawHeaderData);
        this._rawQueryData = new(rawQueryData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="IFromRawJson.FromRawUnchecked"/>
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

[JsonConverter(typeof(ToolGetParamsIncludeFormatConverter))]
public enum ToolGetParamsIncludeFormat
{
    Arcade,
    OpenAI,
    Anthropic,
}

sealed class ToolGetParamsIncludeFormatConverter : JsonConverter<ToolGetParamsIncludeFormat>
{
    public override ToolGetParamsIncludeFormat Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "arcade" => ToolGetParamsIncludeFormat.Arcade,
            "openai" => ToolGetParamsIncludeFormat.OpenAI,
            "anthropic" => ToolGetParamsIncludeFormat.Anthropic,
            _ => (ToolGetParamsIncludeFormat)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        ToolGetParamsIncludeFormat value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                ToolGetParamsIncludeFormat.Arcade => "arcade",
                ToolGetParamsIncludeFormat.OpenAI => "openai",
                ToolGetParamsIncludeFormat.Anthropic => "anthropic",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
