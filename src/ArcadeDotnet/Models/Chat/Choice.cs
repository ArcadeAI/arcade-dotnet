using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Chat;

[JsonConverter(typeof(ModelConverter<Choice, ChoiceFromRaw>))]
public sealed record class Choice : ModelBase
{
    public string? FinishReason
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "finish_reason"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "finish_reason", value);
        }
    }

    public long? Index
    {
        get { return ModelBase.GetNullableStruct<long>(this.RawData, "index"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "index", value);
        }
    }

    public JsonElement? Logprobs
    {
        get { return ModelBase.GetNullableStruct<JsonElement>(this.RawData, "logprobs"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "logprobs", value);
        }
    }

    public ChatMessage? Message
    {
        get { return ModelBase.GetNullableClass<ChatMessage>(this.RawData, "message"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "message", value);
        }
    }

    public IReadOnlyList<AuthorizationResponse>? ToolAuthorizations
    {
        get
        {
            return ModelBase.GetNullableClass<List<AuthorizationResponse>>(
                this.RawData,
                "tool_authorizations"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "tool_authorizations", value);
        }
    }

    public IReadOnlyList<ChatMessage>? ToolMessages
    {
        get { return ModelBase.GetNullableClass<List<ChatMessage>>(this.RawData, "tool_messages"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "tool_messages", value);
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

    public Choice(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Choice(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ChoiceFromRaw.FromRawUnchecked"/>
    public static Choice FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ChoiceFromRaw : IFromRaw<Choice>
{
    /// <inheritdoc/>
    public Choice FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Choice.FromRawUnchecked(rawData);
}
