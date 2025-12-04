using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Chat;

[JsonConverter(typeof(ModelConverter<ChatResponse, ChatResponseFromRaw>))]
public sealed record class ChatResponse : ModelBase
{
    public string? ID
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "id", value);
        }
    }

    public IReadOnlyList<Choice>? Choices
    {
        get { return ModelBase.GetNullableClass<List<Choice>>(this.RawData, "choices"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "choices", value);
        }
    }

    public long? Created
    {
        get { return ModelBase.GetNullableStruct<long>(this.RawData, "created"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "created", value);
        }
    }

    public string? Model
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "model"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "model", value);
        }
    }

    public string? Object
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "object"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "object", value);
        }
    }

    public string? SystemFingerprint
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "system_fingerprint"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "system_fingerprint", value);
        }
    }

    public Usage? Usage
    {
        get { return ModelBase.GetNullableClass<Usage>(this.RawData, "usage"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "usage", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        foreach (var item in this.Choices ?? [])
        {
            item.Validate();
        }
        _ = this.Created;
        _ = this.Model;
        _ = this.Object;
        _ = this.SystemFingerprint;
        this.Usage?.Validate();
    }

    public ChatResponse() { }

    public ChatResponse(ChatResponse chatResponse)
        : base(chatResponse) { }

    public ChatResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ChatResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ChatResponseFromRaw.FromRawUnchecked"/>
    public static ChatResponse FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ChatResponseFromRaw : IFromRaw<ChatResponse>
{
    /// <inheritdoc/>
    public ChatResponse FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        ChatResponse.FromRawUnchecked(rawData);
}
