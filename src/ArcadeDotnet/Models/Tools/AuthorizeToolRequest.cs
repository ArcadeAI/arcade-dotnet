using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Tools;

[JsonConverter(typeof(ModelConverter<AuthorizeToolRequest, AuthorizeToolRequestFromRaw>))]
public sealed record class AuthorizeToolRequest : ModelBase
{
    public required string ToolName
    {
        get { return ModelBase.GetNotNullClass<string>(this.RawData, "tool_name"); }
        init { ModelBase.Set(this._rawData, "tool_name", value); }
    }

    /// <summary>
    /// Optional: if provided, the user will be redirected to this URI after authorization
    /// </summary>
    public string? NextUri
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "next_uri"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "next_uri", value);
        }
    }

    /// <summary>
    /// Optional: if not provided, any version is used
    /// </summary>
    public string? ToolVersion
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "tool_version"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "tool_version", value);
        }
    }

    /// <summary>
    /// Required only when calling with an API key
    /// </summary>
    public string? UserID
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "user_id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "user_id", value);
        }
    }

    public override void Validate()
    {
        _ = this.ToolName;
        _ = this.NextUri;
        _ = this.ToolVersion;
        _ = this.UserID;
    }

    public AuthorizeToolRequest() { }

    public AuthorizeToolRequest(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthorizeToolRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    public static AuthorizeToolRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public AuthorizeToolRequest(string toolName)
        : this()
    {
        this.ToolName = toolName;
    }
}

class AuthorizeToolRequestFromRaw : IFromRaw<AuthorizeToolRequest>
{
    public AuthorizeToolRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthorizeToolRequest.FromRawUnchecked(rawData);
}
