using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Tools;

[JsonConverter(typeof(JsonModelConverter<ValueSchema, ValueSchemaFromRaw>))]
public sealed record class ValueSchema : JsonModel
{
    public required string ValType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("val_type");
        }
        init { this._rawData.Set("val_type", value); }
    }

    public string? Description
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("description");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("description", value);
        }
    }

    public IReadOnlyList<string>? Enum
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>("enum");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "enum",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public JsonElement? InnerProperties
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<JsonElement>("inner_properties");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("inner_properties", value);
        }
    }

    public IReadOnlyList<string>? InnerRequiredKeys
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>("inner_required_keys");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "inner_required_keys",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public string? InnerValType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("inner_val_type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("inner_val_type", value);
        }
    }

    public ValueSchema? Items
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ValueSchema>("items");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("items", value);
        }
    }

    public bool? Nullable
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("nullable");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("nullable", value);
        }
    }

    public JsonElement? Properties
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<JsonElement>("properties");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("properties", value);
        }
    }

    public IReadOnlyList<string>? RequiredKeys
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>("required_keys");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "required_keys",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ValType;
        _ = this.Description;
        _ = this.Enum;
        _ = this.InnerProperties;
        _ = this.InnerRequiredKeys;
        _ = this.InnerValType;
        this.Items?.Validate();
        _ = this.Nullable;
        _ = this.Properties;
        _ = this.RequiredKeys;
    }

    public ValueSchema() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public ValueSchema(ValueSchema valueSchema)
        : base(valueSchema) { }
#pragma warning restore CS8618

    public ValueSchema(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ValueSchema(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ValueSchemaFromRaw.FromRawUnchecked"/>
    public static ValueSchema FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public ValueSchema(string valType)
        : this()
    {
        this.ValType = valType;
    }
}

class ValueSchemaFromRaw : IFromRawJson<ValueSchema>
{
    /// <inheritdoc/>
    public ValueSchema FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        ValueSchema.FromRawUnchecked(rawData);
}
