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
/// Returns a page of tools from the engine configuration, optionally filtered by toolkit
/// </summary>
public sealed record class ToolListParams : ParamsBase
{
    /// <summary>
    /// Include all versions of each tool
    /// </summary>
    public bool? IncludeAllVersions
    {
        get { return this._rawQueryData.GetNullableStruct<bool>("include_all_versions"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("include_all_versions", value);
        }
    }

    /// <summary>
    /// Comma separated tool formats that will be included in the response.
    /// </summary>
    public IReadOnlyList<ApiEnum<string, IncludeFormat>>? IncludeFormat
    {
        get
        {
            return this._rawQueryData.GetNullableStruct<
                ImmutableArray<ApiEnum<string, IncludeFormat>>
            >("include_format");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set<ImmutableArray<ApiEnum<string, IncludeFormat>>?>(
                "include_format",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Number of items to return (default: 25, max: 100)
    /// </summary>
    public long? Limit
    {
        get { return this._rawQueryData.GetNullableStruct<long>("limit"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("limit", value);
        }
    }

    /// <summary>
    /// Offset from the start of the list (default: 0)
    /// </summary>
    public long? Offset
    {
        get { return this._rawQueryData.GetNullableStruct<long>("offset"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("offset", value);
        }
    }

    /// <summary>
    /// Toolkit name
    /// </summary>
    public string? Toolkit
    {
        get { return this._rawQueryData.GetNullableClass<string>("toolkit"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("toolkit", value);
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

    public ToolListParams() { }

    public ToolListParams(ToolListParams toolListParams)
        : base(toolListParams) { }

    public ToolListParams(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData
    )
    {
        this._rawHeaderData = new(rawHeaderData);
        this._rawQueryData = new(rawQueryData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ToolListParams(
        FrozenDictionary<string, JsonElement> rawHeaderData,
        FrozenDictionary<string, JsonElement> rawQueryData
    )
    {
        this._rawHeaderData = new(rawHeaderData);
        this._rawQueryData = new(rawQueryData);
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
