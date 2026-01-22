using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Chat;

[JsonConverter(typeof(JsonModelConverter<Choice, ChoiceFromRaw>))]
public sealed record class Choice : JsonModel
{
    public string? FinishReason
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("finish_reason");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("finish_reason", value);
        }
    }

    public long? Index
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<long>("index");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("index", value);
        }
    }

    public JsonElement? Logprobs
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<JsonElement>("logprobs");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("logprobs", value);
        }
    }

    public ChatMessage? Message
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ChatMessage>("message");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("message", value);
        }
    }

    public IReadOnlyList<AuthorizationResponse>? ToolAuthorizations
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<AuthorizationResponse>>(
                "tool_authorizations"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<AuthorizationResponse>?>(
                "tool_authorizations",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public IReadOnlyList<ChatMessage>? ToolMessages
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<ChatMessage>>("tool_messages");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<ChatMessage>?>(
                "tool_messages",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.FinishReason;
        _ = this.Index;
        _ = this.Logprobs;
        this.Message?.Validate();
        foreach (var item in this.ToolAuthorizations ?? [])
        {
            item.Validate();
        }
        foreach (var item in this.ToolMessages ?? [])
        {
            item.Validate();
        }
    }

    public Choice() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Choice(Choice choice)
        : base(choice) { }
#pragma warning restore CS8618

    public Choice(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Choice(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ChoiceFromRaw.FromRawUnchecked"/>
    public static Choice FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ChoiceFromRaw : IFromRawJson<Choice>
{
    /// <inheritdoc/>
    public Choice FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Choice.FromRawUnchecked(rawData);
}
