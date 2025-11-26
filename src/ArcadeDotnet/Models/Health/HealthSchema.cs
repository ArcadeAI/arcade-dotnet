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
        get
        {
            if (!this._rawData.TryGetValue("healthy", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["healthy"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.Healthy;
    }

    public HealthSchema() { }

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

    public static HealthSchema FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class HealthSchemaFromRaw : IFromRaw<HealthSchema>
{
    public HealthSchema FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        HealthSchema.FromRawUnchecked(rawData);
}
