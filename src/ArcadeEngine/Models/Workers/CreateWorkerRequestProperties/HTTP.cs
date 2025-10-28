using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeEngine.Core;
using ArcadeEngine.Exceptions;

namespace ArcadeEngine.Models.Workers.CreateWorkerRequestProperties;

[JsonConverter(typeof(ModelConverter<HTTP>))]
public sealed record class HTTP : ModelBase, IFromRaw<HTTP>
{
    public required long Retry
    {
        get
        {
            if (!this.Properties.TryGetValue("retry", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'retry' cannot be null",
                    new ArgumentOutOfRangeException("retry", "Missing required argument")
                );

            return JsonSerializer.Deserialize<long>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["retry"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required string Secret
    {
        get
        {
            if (!this.Properties.TryGetValue("secret", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'secret' cannot be null",
                    new ArgumentOutOfRangeException("secret", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'secret' cannot be null",
                    new ArgumentNullException("secret")
                );
        }
        set
        {
            this.Properties["secret"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required long Timeout
    {
        get
        {
            if (!this.Properties.TryGetValue("timeout", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'timeout' cannot be null",
                    new ArgumentOutOfRangeException("timeout", "Missing required argument")
                );

            return JsonSerializer.Deserialize<long>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["timeout"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required string Uri
    {
        get
        {
            if (!this.Properties.TryGetValue("uri", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'uri' cannot be null",
                    new ArgumentOutOfRangeException("uri", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'uri' cannot be null",
                    new ArgumentNullException("uri")
                );
        }
        set
        {
            this.Properties["uri"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.Retry;
        _ = this.Secret;
        _ = this.Timeout;
        _ = this.Uri;
    }

    public HTTP() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    HTTP(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static HTTP FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
