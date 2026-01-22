using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Chat;

[JsonConverter(typeof(JsonModelConverter<ChatResponse, ChatResponseFromRaw>))]
public sealed record class ChatResponse : JsonModel
{
    public string? ID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("id", value);
        }
    }

    public IReadOnlyList<Choice>? Choices
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<Choice>>("choices");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<Choice>?>(
                "choices",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public long? Created
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<long>("created");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("created", value);
        }
    }

    public string? Model
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("model");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("model", value);
        }
    }

    public string? Object
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("object");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("object", value);
        }
    }

    public string? SystemFingerprint
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("system_fingerprint");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("system_fingerprint", value);
        }
    }

    public Usage? Usage
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<Usage>("usage");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("usage", value);
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

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public ChatResponse(ChatResponse chatResponse)
        : base(chatResponse) { }
#pragma warning restore CS8618

    public ChatResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ChatResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ChatResponseFromRaw.FromRawUnchecked"/>
    public static ChatResponse FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ChatResponseFromRaw : IFromRawJson<ChatResponse>
{
    /// <inheritdoc/>
    public ChatResponse FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        ChatResponse.FromRawUnchecked(rawData);
}
