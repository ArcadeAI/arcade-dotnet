using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Health;

[JsonConverter(typeof(ModelConverter<HealthSchema, HealthSchemaFromRaw>))]
public sealed record class HealthSchema : ModelBase
{
    public bool? Healthy
    {
        get { return ModelBase.GetNullableStruct<bool>(this.RawData, "healthy"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "healthy", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Healthy;
    }

    public HealthSchema() { }

    public HealthSchema(HealthSchema healthSchema)
        : base(healthSchema) { }

    public HealthSchema(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    HealthSchema(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="HealthSchemaFromRaw.FromRawUnchecked"/>
    public static HealthSchema FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class HealthSchemaFromRaw : IFromRaw<HealthSchema>
{
    /// <inheritdoc/>
    public HealthSchema FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        HealthSchema.FromRawUnchecked(rawData);
}
