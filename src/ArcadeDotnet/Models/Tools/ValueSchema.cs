using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Tools;

[JsonConverter(typeof(ModelConverter<ValueSchema, ValueSchemaFromRaw>))]
public sealed record class ValueSchema : ModelBase
{
    public required string ValType
    {
        get { return ModelBase.GetNotNullClass<string>(this.RawData, "val_type"); }
        init { ModelBase.Set(this._rawData, "val_type", value); }
    }

    public IReadOnlyList<string>? Enum
    {
        get { return ModelBase.GetNullableClass<List<string>>(this.RawData, "enum"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "enum", value);
        }
    }

    public string? InnerValType
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "inner_val_type"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "inner_val_type", value);
        }
    }

    public override void Validate()
    {
        _ = this.ValType;
        _ = this.Enum;
        _ = this.InnerValType;
    }

    public ValueSchema() { }

    public ValueSchema(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ValueSchema(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

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

class ValueSchemaFromRaw : IFromRaw<ValueSchema>
{
    public ValueSchema FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        ValueSchema.FromRawUnchecked(rawData);
}
