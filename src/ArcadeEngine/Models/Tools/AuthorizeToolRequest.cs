using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeEngine.Core;
using ArcadeEngine.Exceptions;

namespace ArcadeEngine.Models.Tools;

[JsonConverter(typeof(ModelConverter<AuthorizeToolRequest>))]
public sealed record class AuthorizeToolRequest : ModelBase, IFromRaw<AuthorizeToolRequest>
{
    public required string ToolName
    {
        get
        {
            if (!this.Properties.TryGetValue("tool_name", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'tool_name' cannot be null",
                    new ArgumentOutOfRangeException("tool_name", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'tool_name' cannot be null",
                    new ArgumentNullException("tool_name")
                );
        }
        set
        {
            this.Properties["tool_name"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    /// <summary>
    /// Optional: if provided, the user will be redirected to this URI after authorization
    /// </summary>
    public string? NextUri
    {
        get
        {
            if (!this.Properties.TryGetValue("next_uri", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["next_uri"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    /// <summary>
    /// Optional: if not provided, any version is used
    /// </summary>
    public string? ToolVersion
    {
        get
        {
            if (!this.Properties.TryGetValue("tool_version", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["tool_version"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    /// <summary>
    /// Required only when calling with an API key
    /// </summary>
    public string? UserID
    {
        get
        {
            if (!this.Properties.TryGetValue("user_id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["user_id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
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

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthorizeToolRequest(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static AuthorizeToolRequest FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }

    [SetsRequiredMembers]
    public AuthorizeToolRequest(string toolName)
        : this()
    {
        this.ToolName = toolName;
    }
}
