using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models.Health;

[JsonConverter(typeof(JsonModelConverter<HealthSchema, HealthSchemaFromRaw>))]
public sealed record class HealthSchema : JsonModel
{
    public bool? Healthy
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("healthy");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("healthy", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Healthy;
    }

    public HealthSchema() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public HealthSchema(HealthSchema healthSchema)
        : base(healthSchema) { }
#pragma warning restore CS8618

    public HealthSchema(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    HealthSchema(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="HealthSchemaFromRaw.FromRawUnchecked"/>
    public static HealthSchema FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class HealthSchemaFromRaw : IFromRawJson<HealthSchema>
{
    /// <inheritdoc/>
    public HealthSchema FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        HealthSchema.FromRawUnchecked(rawData);
}
