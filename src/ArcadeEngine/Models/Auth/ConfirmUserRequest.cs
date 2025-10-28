using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeEngine.Core;
using ArcadeEngine.Exceptions;

namespace ArcadeEngine.Models.Auth;

[JsonConverter(typeof(ModelConverter<ConfirmUserRequest>))]
public sealed record class ConfirmUserRequest : ModelBase, IFromRaw<ConfirmUserRequest>
{
    public required string FlowID
    {
        get
        {
            if (!this.Properties.TryGetValue("flow_id", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'flow_id' cannot be null",
                    new ArgumentOutOfRangeException("flow_id", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'flow_id' cannot be null",
                    new ArgumentNullException("flow_id")
                );
        }
        set
        {
            this.Properties["flow_id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required string UserID
    {
        get
        {
            if (!this.Properties.TryGetValue("user_id", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'user_id' cannot be null",
                    new ArgumentOutOfRangeException("user_id", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'user_id' cannot be null",
                    new ArgumentNullException("user_id")
                );
        }
        set
        {
            this.Properties["user_id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.FlowID;
        _ = this.UserID;
    }

    public ConfirmUserRequest() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ConfirmUserRequest(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static ConfirmUserRequest FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
