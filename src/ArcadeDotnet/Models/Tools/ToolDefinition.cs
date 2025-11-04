using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using ArcadeDotnet.Models.Tools.ToolDefinitionProperties;

namespace ArcadeDotnet.Models.Tools;

[JsonConverter(typeof(ModelConverter<ToolDefinition>))]
public sealed record class ToolDefinition : ModelBase, IFromRaw<ToolDefinition>
{
    public required string FullyQualifiedName
    {
        get
        {
            if (!this.Properties.TryGetValue("fully_qualified_name", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'fully_qualified_name' cannot be null",
                    new ArgumentOutOfRangeException(
                        "fully_qualified_name",
                        "Missing required argument"
                    )
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'fully_qualified_name' cannot be null",
                    new ArgumentNullException("fully_qualified_name")
                );
        }
        set
        {
            this.Properties["fully_qualified_name"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required Input Input
    {
        get
        {
            if (!this.Properties.TryGetValue("input", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'input' cannot be null",
                    new ArgumentOutOfRangeException("input", "Missing required argument")
                );

            return JsonSerializer.Deserialize<Input>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'input' cannot be null",
                    new ArgumentNullException("input")
                );
        }
        set
        {
            this.Properties["input"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

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

    public required string QualifiedName
    {
        get
        {
            if (!this.Properties.TryGetValue("qualified_name", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'qualified_name' cannot be null",
                    new ArgumentOutOfRangeException("qualified_name", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'qualified_name' cannot be null",
                    new ArgumentNullException("qualified_name")
                );
        }
        set
        {
            this.Properties["qualified_name"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required Toolkit Toolkit
    {
        get
        {
            if (!this.Properties.TryGetValue("toolkit", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'toolkit' cannot be null",
                    new ArgumentOutOfRangeException("toolkit", "Missing required argument")
                );

            return JsonSerializer.Deserialize<Toolkit>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'toolkit' cannot be null",
                    new ArgumentNullException("toolkit")
                );
        }
        set
        {
            this.Properties["toolkit"] = JsonSerializer.SerializeToElement(
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

    public Dictionary<string, JsonElement>? FormattedSchema
    {
        get
        {
            if (!this.Properties.TryGetValue("formatted_schema", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Dictionary<string, JsonElement>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["formatted_schema"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Output? Output
    {
        get
        {
            if (!this.Properties.TryGetValue("output", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Output?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["output"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Requirements? Requirements
    {
        get
        {
            if (!this.Properties.TryGetValue("requirements", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Requirements?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["requirements"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.FullyQualifiedName;
        this.Input.Validate();
        _ = this.Name;
        _ = this.QualifiedName;
        this.Toolkit.Validate();
        _ = this.Description;
        _ = this.FormattedSchema;
        this.Output?.Validate();
        this.Requirements?.Validate();
    }

    public ToolDefinition() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ToolDefinition(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static ToolDefinition FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
