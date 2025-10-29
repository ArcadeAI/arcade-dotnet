using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;

namespace ArcadeDotnet.Models.Tools.ToolDefinitionProperties.InputProperties;

[JsonConverter(typeof(ModelConverter<Parameter>))]
public sealed record class Parameter : ModelBase, IFromRaw<Parameter>
{
    public required string Name
    {
        get
        {
            if (!this.Properties.TryGetValue("name", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'name' cannot be null",
                    new ArgumentOutOfRangeException("name", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'name' cannot be null",
                    new ArgumentNullException("name")
                );
        }
        set
        {
            this.Properties["name"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required ValueSchema ValueSchema
    {
        get
        {
            if (!this.Properties.TryGetValue("value_schema", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'value_schema' cannot be null",
                    new ArgumentOutOfRangeException("value_schema", "Missing required argument")
                );

            return JsonSerializer.Deserialize<ValueSchema>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'value_schema' cannot be null",
                    new ArgumentNullException("value_schema")
                );
        }
        set
        {
            this.Properties["value_schema"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Description
    {
        get
        {
            if (!this.Properties.TryGetValue("description", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["description"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public bool? Inferrable
    {
        get
        {
            if (!this.Properties.TryGetValue("inferrable", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["inferrable"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public bool? Required
    {
        get
        {
            if (!this.Properties.TryGetValue("required", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["required"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.Name;
        this.ValueSchema.Validate();
        _ = this.Description;
        _ = this.Inferrable;
        _ = this.Required;
    }

    public Parameter() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Parameter(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static Parameter FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
