using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeEngine.Core;

namespace ArcadeEngine.Models;

[JsonConverter(typeof(ModelConverter<Error>))]
public sealed record class Error : ModelBase, IFromRaw<Error>
{
    public string? Message
    {
        get
        {
            if (!this.Properties.TryGetValue("message", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["message"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

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

    public override void Validate()
    {
        _ = this.Message;
        _ = this.Name;
    }

    public Error() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Error(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static Error FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
