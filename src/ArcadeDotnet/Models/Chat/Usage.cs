using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Chat;

[JsonConverter(typeof(JsonModelConverter<Usage, UsageFromRaw>))]
public sealed record class Usage : JsonModel
{
    public long? CompletionTokens
    {
        get { return JsonModel.GetNullableStruct<long>(this.RawData, "completion_tokens"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "completion_tokens", value);
        }
    }

    public long? PromptTokens
    {
        get { return JsonModel.GetNullableStruct<long>(this.RawData, "prompt_tokens"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "prompt_tokens", value);
        }
    }

    public long? TotalTokens
    {
        get { return JsonModel.GetNullableStruct<long>(this.RawData, "total_tokens"); }
        init
        {
            if (value == null)
            {
                return;
            }

            JsonModel.Set(this._rawData, "total_tokens", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.CompletionTokens;
        _ = this.PromptTokens;
        _ = this.TotalTokens;
    }

    public Usage() { }

    public Usage(Usage usage)
        : base(usage) { }

    public Usage(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Usage(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="UsageFromRaw.FromRawUnchecked"/>
    public static Usage FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class UsageFromRaw : IFromRawJson<Usage>
{
    /// <inheritdoc/>
    public Usage FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Usage.FromRawUnchecked(rawData);
}
