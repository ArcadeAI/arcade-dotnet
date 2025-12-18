using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using System = System;

namespace ArcadeDotnet.Models.Chat;

[JsonConverter(typeof(JsonModelConverter<ChatMessage, ChatMessageFromRaw>))]
public sealed record class ChatMessage : JsonModel
{
    /// <summary>
    /// The content of the message.
    /// </summary>
    public required string Content
    {
        get { return JsonModel.GetNotNullClass<string>(this.RawData, "content"); }
        init { JsonModel.Set(this._rawData, "content", value); }
    }

    /// <summary>
    /// The role of the author of this message. One of system, user, tool, or assistant.
    /// </summary>
    public required string Role
    {
        get { return JsonModel.GetNotNullClass<string>(this.RawData, "role"); }
        init { JsonModel.Set(this._rawData, "role", value); }
    }

    /// <summary>
    /// tool Name
    /// </summary>
    public string? Name
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "name"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "name", value);
        }
    }

    /// <summary>
    /// tool_call_id
    /// </summary>
    public string? ToolCallID
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "tool_call_id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "tool_call_id", value);
        }
    }

    /// <summary>
    /// tool calls if any
    /// </summary>
    public IReadOnlyList<ToolCall>? ToolCalls
    {
        get { return JsonModel.GetNullableClass<List<ToolCall>>(this.RawData, "tool_calls"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "tool_calls", value);
        }
    }

    /// <inheritdoc/>
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

    public ChatMessage(ChatMessage chatMessage)
        : base(chatMessage) { }

    public ChatMessage(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ChatMessage(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ChatMessageFromRaw.FromRawUnchecked"/>
    public static ChatMessage FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ChatMessageFromRaw : IFromRawJson<ChatMessage>
{
    /// <inheritdoc/>
    public ChatMessage FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        ChatMessage.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<ToolCall, ToolCallFromRaw>))]
public sealed record class ToolCall : JsonModel
{
    public string? ID
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "id", value);
        }
    }

    public Function? Function
    {
        get { return JsonModel.GetNullableClass<Function>(this.RawData, "function"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "function", value);
        }
    }

    public ApiEnum<string, global::ArcadeDotnet.Models.Chat.Type>? Type
    {
        get
        {
            return JsonModel.GetNullableClass<
                ApiEnum<string, global::ArcadeDotnet.Models.Chat.Type>
            >(this.RawData, "type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "type", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        this.Function?.Validate();
        this.Type?.Validate();
    }

    public ToolCall() { }

    public ToolCall(ToolCall toolCall)
        : base(toolCall) { }

    public ToolCall(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ToolCall(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ToolCallFromRaw.FromRawUnchecked"/>
    public static ToolCall FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ToolCallFromRaw : IFromRawJson<ToolCall>
{
    /// <inheritdoc/>
    public ToolCall FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        ToolCall.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Function, FunctionFromRaw>))]
public sealed record class Function : JsonModel
{
    public string? Arguments
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "arguments"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "arguments", value);
        }
    }

    public string? Name
    {
        get { return JsonModel.GetNullableClass<string>(this.RawData, "name"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "name", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Arguments;
        _ = this.Name;
    }

    public Function() { }

    public Function(Function function)
        : base(function) { }

    public Function(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Function(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="FunctionFromRaw.FromRawUnchecked"/>
    public static Function FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class FunctionFromRaw : IFromRawJson<Function>
{
    /// <inheritdoc/>
    public Function FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Function.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(TypeConverter))]
public enum Type
{
    Function,
}

sealed class TypeConverter : JsonConverter<global::ArcadeDotnet.Models.Chat.Type>
{
    public override global::ArcadeDotnet.Models.Chat.Type Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "function" => global::ArcadeDotnet.Models.Chat.Type.Function,
            _ => (global::ArcadeDotnet.Models.Chat.Type)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        global::ArcadeDotnet.Models.Chat.Type value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                global::ArcadeDotnet.Models.Chat.Type.Function => "function",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
