using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;

namespace ArcadeDotnet.Models.Tools;

[JsonConverter(typeof(ModelConverter<ValueSchema>))]
public sealed record class ValueSchema : ModelBase, IFromRaw<ValueSchema>
{
    public required string ValType
    {
        get
        {
            if (!this.Properties.TryGetValue("val_type", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'val_type' cannot be null",
                    new ArgumentOutOfRangeException("val_type", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'val_type' cannot be null",
                    new ArgumentNullException("val_type")
                );
        }
        set
        {
            this.Properties["val_type"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public List<string>? Enum
    {
        get
        {
            if (!this.Properties.TryGetValue("enum", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<List<string>?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["enum"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? InnerValType
    {
        get
        {
            if (!this.Properties.TryGetValue("inner_val_type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["inner_val_type"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.ValType;
        _ = this.Enum;
        _ = this.InnerValType;
    }

    public ValueSchema() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ValueSchema(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static ValueSchema FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }

    [SetsRequiredMembers]
    public ValueSchema(string valType)
        : this()
    {
        this.ValType = valType;
    }
}
