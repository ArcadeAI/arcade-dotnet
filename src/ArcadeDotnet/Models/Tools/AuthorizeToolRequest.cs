using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Tools;

[JsonConverter(typeof(JsonModelConverter<AuthorizeToolRequest, AuthorizeToolRequestFromRaw>))]
public sealed record class AuthorizeToolRequest : JsonModel
{
    public required string ToolName
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("tool_name");
        }
        init { this._rawData.Set("tool_name", value); }
    }

    /// <summary>
    /// Optional: if provided, the user will be redirected to this URI after authorization
    /// </summary>
    public string? NextUri
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("next_uri");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("next_uri", value);
        }
    }

    /// <summary>
    /// Optional: if not provided, any version is used
    /// </summary>
    public string? ToolVersion
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("tool_version");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("tool_version", value);
        }
    }

    /// <summary>
    /// Required only when calling with an API key
    /// </summary>
    public string? UserID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("user_id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("user_id", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ToolName;
        _ = this.NextUri;
        _ = this.ToolVersion;
        _ = this.UserID;
    }

    public AuthorizeToolRequest() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AuthorizeToolRequest(AuthorizeToolRequest authorizeToolRequest)
        : base(authorizeToolRequest) { }
#pragma warning restore CS8618

    public AuthorizeToolRequest(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthorizeToolRequest(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthorizeToolRequestFromRaw.FromRawUnchecked"/>
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

class AuthorizeToolRequestFromRaw : IFromRawJson<AuthorizeToolRequest>
{
    /// <inheritdoc/>
    public AuthorizeToolRequest FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthorizeToolRequest.FromRawUnchecked(rawData);
}
