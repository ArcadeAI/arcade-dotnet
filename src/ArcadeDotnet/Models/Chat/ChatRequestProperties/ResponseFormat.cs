using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Chat.ChatRequestProperties.ResponseFormatProperties;

namespace ArcadeDotnet.Models.Chat.ChatRequestProperties;

[JsonConverter(typeof(ModelConverter<ResponseFormat>))]
public sealed record class ResponseFormat : ModelBase, IFromRaw<ResponseFormat>
{
    public ApiEnum<string, Type>? Type
    {
        get
        {
            if (!this.Properties.TryGetValue("type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<string, Type>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["type"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        this.Type?.Validate();
    }

    public ResponseFormat() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ResponseFormat(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static ResponseFormat FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
