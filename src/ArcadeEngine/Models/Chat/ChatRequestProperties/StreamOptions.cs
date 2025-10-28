using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeEngine.Core;

namespace ArcadeEngine.Models.Chat.ChatRequestProperties;

/// <summary>
/// Options for streaming response. Only set this when you set stream: true.
/// </summary>
[JsonConverter(typeof(ModelConverter<StreamOptions>))]
public sealed record class StreamOptions : ModelBase, IFromRaw<StreamOptions>
{
    /// <summary>
    /// If set, an additional chunk will be streamed before the data: [DONE] message.
    /// The usage field on this chunk shows the token usage statistics for the entire
    /// request, and the choices field will always be an empty array. All other chunks
    /// will also include a usage field, but with a null value.
    /// </summary>
    public bool? IncludeUsage
    {
        get
        {
            if (!this.Properties.TryGetValue("include_usage", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["include_usage"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.IncludeUsage;
    }

    public StreamOptions() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    StreamOptions(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static StreamOptions FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
