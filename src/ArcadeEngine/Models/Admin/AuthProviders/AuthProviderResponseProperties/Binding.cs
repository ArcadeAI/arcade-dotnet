using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeEngine.Core;
using ArcadeEngine.Models.Admin.AuthProviders.AuthProviderResponseProperties.BindingProperties;

namespace ArcadeEngine.Models.Admin.AuthProviders.AuthProviderResponseProperties;

[JsonConverter(typeof(ModelConverter<Binding>))]
public sealed record class Binding : ModelBase, IFromRaw<Binding>
{
    public string? ID
    {
        get
        {
            if (!this.Properties.TryGetValue("id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

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
        _ = this.ID;
        this.Type?.Validate();
    }

    public Binding() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Binding(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static Binding FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
