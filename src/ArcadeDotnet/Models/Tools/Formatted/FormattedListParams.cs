using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text.Json;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Tools.Formatted;

/// <summary>
/// Returns a page of tools from the engine configuration, optionally filtered by
/// toolkit, formatted for a specific provider
/// </summary>
public sealed record class FormattedListParams : ParamsBase
{
    /// <summary>
    /// Provider format
    /// </summary>
    public string? Format
    {
        get { return this._rawQueryData.GetNullableClass<string>("format"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("format", value);
        }
    }

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

    public FormattedListParams() { }

    public FormattedListParams(FormattedListParams formattedListParams)
        : base(formattedListParams) { }

    public FormattedListParams(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData
    )
    {
        this._rawHeaderData = new(rawHeaderData);
        this._rawQueryData = new(rawQueryData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    FormattedListParams(
        FrozenDictionary<string, JsonElement> rawHeaderData,
        FrozenDictionary<string, JsonElement> rawQueryData
    )
    {
        this._rawHeaderData = new(rawHeaderData);
        this._rawQueryData = new(rawQueryData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="IFromRawJson.FromRawUnchecked"/>
    public static FormattedListParams FromRawUnchecked(
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
        return new UriBuilder(options.BaseUrl.ToString().TrimEnd('/') + "/v1/formatted_tools")
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
