using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Tools;

/// <summary>
/// Executes a tool by name and arguments
/// </summary>
public sealed record class ToolExecuteParams : ParamsBase
{
    readonly FreezableDictionary<string, JsonElement> _rawBodyData = [];
    public IReadOnlyDictionary<string, JsonElement> RawBodyData
    {
        get { return this._rawBodyData.Freeze(); }
    }

    public required string ToolName
    {
        get { return JsonModel.GetNotNullClass<string>(this.RawBodyData, "tool_name"); }
        init { JsonModel.Set(this._rawBodyData, "tool_name", value); }
    }

    /// <summary>
    /// Whether to include the error stacktrace in the response. If not provided,
    /// the error stacktrace is not included.
    /// </summary>
    public bool? IncludeErrorStacktrace
    {
        get
        {
            return JsonModel.GetNullableStruct<bool>(this.RawBodyData, "include_error_stacktrace");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "include_error_stacktrace", value);
        }
    }

    /// <summary>
    /// JSON input to the tool, if any
    /// </summary>
    public IReadOnlyDictionary<string, JsonElement>? Input
    {
        get
        {
            return JsonModel.GetNullableClass<Dictionary<string, JsonElement>>(
                this.RawBodyData,
                "input"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "input", value);
        }
    }

    /// <summary>
    /// The time at which the tool should be run (optional). If not provided, the
    /// tool is run immediately. Format ISO 8601: YYYY-MM-DDTHH:MM:SS
    /// </summary>
    public string? RunAt
    {
        get { return JsonModel.GetNullableClass<string>(this.RawBodyData, "run_at"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "run_at", value);
        }
    }

    /// <summary>
    /// The tool version to use (optional). If not provided, any version is used
    /// </summary>
    public string? ToolVersion
    {
        get { return JsonModel.GetNullableClass<string>(this.RawBodyData, "tool_version"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "tool_version", value);
        }
    }

    public string? UserID
    {
        get { return JsonModel.GetNullableClass<string>(this.RawBodyData, "user_id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawBodyData, "user_id", value);
        }
    }

    public ToolExecuteParams() { }

    public ToolExecuteParams(ToolExecuteParams toolExecuteParams)
        : base(toolExecuteParams)
    {
        this._rawBodyData = [.. toolExecuteParams._rawBodyData];
    }

    public ToolExecuteParams(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData,
        IReadOnlyDictionary<string, JsonElement> rawBodyData
    )
    {
        this._rawHeaderData = [.. rawHeaderData];
        this._rawQueryData = [.. rawQueryData];
        this._rawBodyData = [.. rawBodyData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ToolExecuteParams(
        FrozenDictionary<string, JsonElement> rawHeaderData,
        FrozenDictionary<string, JsonElement> rawQueryData,
        FrozenDictionary<string, JsonElement> rawBodyData
    )
    {
        this._rawHeaderData = [.. rawHeaderData];
        this._rawQueryData = [.. rawQueryData];
        this._rawBodyData = [.. rawBodyData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="IFromRawJson.FromRawUnchecked"/>
    public static ToolExecuteParams FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData,
        IReadOnlyDictionary<string, JsonElement> rawBodyData
    )
    {
        return new(
            FrozenDictionary.ToFrozenDictionary(rawHeaderData),
            FrozenDictionary.ToFrozenDictionary(rawQueryData),
            FrozenDictionary.ToFrozenDictionary(rawBodyData)
        );
    }

    public override Uri Url(ClientOptions options)
    {
        return new UriBuilder(options.BaseUrl.ToString().TrimEnd('/') + "/v1/tools/execute")
        {
            Query = this.QueryString(options),
        }.Uri;
    }

    internal override HttpContent? BodyContent()
    {
        return new StringContent(
            JsonSerializer.Serialize(this.RawBodyData),
            Encoding.UTF8,
            "application/json"
        );
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
