using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models;

[JsonConverter(typeof(ModelConverter<AuthorizationContext>))]
public sealed record class AuthorizationContext : ModelBase, IFromRaw<AuthorizationContext>
{
    public string? Token
    {
        get
        {
            if (!this.Properties.TryGetValue("token", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["token"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Dictionary<string, JsonElement>? UserInfo
    {
        get
        {
            if (!this.Properties.TryGetValue("user_info", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Dictionary<string, JsonElement>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["user_info"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.Token;
        _ = this.UserInfo;
    }

    public AuthorizationContext() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthorizationContext(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static AuthorizationContext FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
