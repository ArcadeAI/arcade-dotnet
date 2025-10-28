using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeEngine.Core;
using ArcadeEngine.Exceptions;
using ArcadeEngine.Models.Workers.CreateWorkerRequestProperties;

namespace ArcadeEngine.Models.Workers;

[JsonConverter(typeof(ModelConverter<CreateWorkerRequest>))]
public sealed record class CreateWorkerRequest : ModelBase, IFromRaw<CreateWorkerRequest>
{
    public required string ID
    {
        get
        {
            if (!this.Properties.TryGetValue("id", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'id' cannot be null",
                    new ArgumentOutOfRangeException("id", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'id' cannot be null",
                    new ArgumentNullException("id")
                );
        }
        set
        {
            this.Properties["id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public bool? Enabled
    {
        get
        {
            if (!this.Properties.TryGetValue("enabled", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["enabled"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public HTTP? HTTP
    {
        get
        {
            if (!this.Properties.TryGetValue("http", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<HTTP?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["http"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Mcp? Mcp
    {
        get
        {
            if (!this.Properties.TryGetValue("mcp", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Mcp?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["mcp"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Type
    {
        get
        {
            if (!this.Properties.TryGetValue("type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
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
        _ = this.Enabled;
        this.HTTP?.Validate();
        this.Mcp?.Validate();
        _ = this.Type;
    }

    public CreateWorkerRequest() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CreateWorkerRequest(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static CreateWorkerRequest FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }

    [SetsRequiredMembers]
    public CreateWorkerRequest(string id)
        : this()
    {
        this.ID = id;
    }
}
