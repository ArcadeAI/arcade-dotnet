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
        get { return this._rawData.GetNotNullClass<string>("val_type"); }
        init { this._rawData.Set("val_type", value); }
    }

    public IReadOnlyList<string>? Enum
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<string>>("enum"); }
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

    public string? InnerValType
    {
        get { return this._rawData.GetNullableClass<string>("inner_val_type"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("inner_val_type", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ValType;
        _ = this.Enum;
        _ = this.InnerValType;
    }

    public ValueSchema() { }

    public ValueSchema(ValueSchema valueSchema)
        : base(valueSchema) { }

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
