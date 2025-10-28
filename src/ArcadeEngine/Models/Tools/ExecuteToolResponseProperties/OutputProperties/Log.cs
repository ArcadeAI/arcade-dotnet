using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeEngine.Core;
using ArcadeEngine.Exceptions;

namespace ArcadeEngine.Models.Tools.ExecuteToolResponseProperties.OutputProperties;

[JsonConverter(typeof(ModelConverter<Log>))]
public sealed record class Log : ModelBase, IFromRaw<Log>
{
    public required string Level
    {
        get
        {
            if (!this.Properties.TryGetValue("level", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'level' cannot be null",
                    new ArgumentOutOfRangeException("level", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'level' cannot be null",
                    new ArgumentNullException("level")
                );
        }
        set
        {
            this.Properties["level"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required string Message
    {
        get
        {
            if (!this.Properties.TryGetValue("message", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'message' cannot be null",
                    new ArgumentOutOfRangeException("message", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'message' cannot be null",
                    new ArgumentNullException("message")
                );
        }
        set
        {
            this.Properties["message"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Subtype
    {
        get
        {
            if (!this.Properties.TryGetValue("subtype", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["subtype"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.Level;
        _ = this.Message;
        _ = this.Subtype;
    }

    public Log() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Log(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static Log FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
