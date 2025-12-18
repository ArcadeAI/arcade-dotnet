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
/// Returns a page of tools from the engine configuration, optionally filtered by toolkit
/// </summary>
public sealed record class ToolListParams : ParamsBase
{
    /// <summary>
    /// Include all versions of each tool
    /// </summary>
    public bool? IncludeAllVersions
    {
        get { return JsonModel.GetNullableStruct<bool>(this.RawQueryData, "include_all_versions"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawQueryData, "include_all_versions", value);
        }
    }

    /// <summary>
    /// Comma separated tool formats that will be included in the response.
    /// </summary>
    public IReadOnlyList<ApiEnum<string, IncludeFormat>>? IncludeFormat
    {
        get
        {
            return JsonModel.GetNullableClass<List<ApiEnum<string, IncludeFormat>>>(
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

            JsonModel.Set(this._rawQueryData, "include_format", value);
        }
    }

    /// <summary>
    /// Number of items to return (default: 25, max: 100)
    /// </summary>
    public long? Limit
    {
        get { return JsonModel.GetNullableStruct<long>(this.RawQueryData, "limit"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawQueryData, "limit", value);
        }
    }

    /// <summary>
    /// Offset from the start of the list (default: 0)
    /// </summary>
    public long? Offset
    {
        get { return JsonModel.GetNullableStruct<long>(this.RawQueryData, "offset"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawQueryData, "offset", value);
        }
    }

    /// <summary>
    /// Toolkit name
    /// </summary>
    public string? Toolkit
    {
        get { return JsonModel.GetNullableClass<string>(this.RawQueryData, "toolkit"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawQueryData, "toolkit", value);
        }
    }

    /// <summary>
    /// User ID
    /// </summary>
    public string? UserID
    {
        get { return JsonModel.GetNullableClass<string>(this.RawQueryData, "user_id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawQueryData, "user_id", value);
        }
    }

    public ToolListParams() { }

    public ToolListParams(ToolListParams toolListParams)
        : base(toolListParams) { }

    public ToolListParams(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData
    )
    {
        this._rawHeaderData = [.. rawHeaderData];
        this._rawQueryData = [.. rawQueryData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ToolListParams(
        FrozenDictionary<string, JsonElement> rawHeaderData,
        FrozenDictionary<string, JsonElement> rawQueryData
    )
    {
        this._rawHeaderData = [.. rawHeaderData];
        this._rawQueryData = [.. rawQueryData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="IFromRawJson.FromRawUnchecked"/>
    public static ToolListParams FromRawUnchecked(
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
        return new UriBuilder(options.BaseUrl.ToString().TrimEnd('/') + "/v1/tools")
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

[JsonConverter(typeof(IncludeFormatConverter))]
public enum IncludeFormat
{
    Arcade,
    OpenAI,
    Anthropic,
}

sealed class IncludeFormatConverter : JsonConverter<IncludeFormat>
{
    public override IncludeFormat Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "arcade" => IncludeFormat.Arcade,
            "openai" => IncludeFormat.OpenAI,
            "anthropic" => IncludeFormat.Anthropic,
            _ => (IncludeFormat)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        IncludeFormat value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                IncludeFormat.Arcade => "arcade",
                IncludeFormat.OpenAI => "openai",
                IncludeFormat.Anthropic => "anthropic",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
