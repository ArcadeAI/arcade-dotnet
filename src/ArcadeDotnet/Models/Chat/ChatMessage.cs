using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using ArcadeDotnet.Models.Chat.ChatMessageProperties;

namespace ArcadeDotnet.Models.Chat;

[JsonConverter(typeof(ModelConverter<ChatMessage>))]
public sealed record class ChatMessage : ModelBase, IFromRaw<ChatMessage>
{
    /// <summary>
    /// The content of the message.
    /// </summary>
    public required string Content
    {
        get
        {
            if (!this.Properties.TryGetValue("content", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'content' cannot be null",
                    new ArgumentOutOfRangeException("content", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'content' cannot be null",
                    new ArgumentNullException("content")
                );
        }
        set
        {
            this.Properties["content"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    /// <summary>
    /// The role of the author of this message. One of system, user, tool, or assistant.
    /// </summary>
    public required string Role
    {
        get
        {
            if (!this.Properties.TryGetValue("role", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'role' cannot be null",
                    new ArgumentOutOfRangeException("role", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'role' cannot be null",
                    new ArgumentNullException("role")
                );
        }
        set
        {
            this.Properties["role"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    /// <summary>
    /// tool Name
    /// </summary>
    public string? Name
    {
        get
        {
            if (!this.Properties.TryGetValue("name", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["name"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    /// <summary>
    /// tool_call_id
    /// </summary>
    public string? ToolCallID
    {
        get
        {
            if (!this.Properties.TryGetValue("tool_call_id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["tool_call_id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    /// <summary>
    /// tool calls if any
    /// </summary>
    public List<ToolCall>? ToolCalls
    {
        get
        {
            if (!this.Properties.TryGetValue("tool_calls", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<List<ToolCall>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["tool_calls"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.Content;
        _ = this.Role;
        _ = this.Name;
        _ = this.ToolCallID;
        foreach (var item in this.ToolCalls ?? [])
        {
            item.Validate();
        }
    }

    public ChatMessage() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ChatMessage(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static ChatMessage FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
