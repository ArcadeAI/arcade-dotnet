using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Admin.UserConnections.UserConnectionListParamsProperties;

[JsonConverter(typeof(ModelConverter<User>))]
public sealed record class User : ModelBase, IFromRaw<User>
{
    /// <summary>
    /// User ID
    /// </summary>
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

    public override void Validate()
    {
        _ = this.ID;
    }

    public User() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    User(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static User FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
