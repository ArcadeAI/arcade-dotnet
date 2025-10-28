using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeEngine.Core;

namespace ArcadeEngine.Models.Admin.Secrets;

[JsonConverter(typeof(ModelConverter<SecretListResponse>))]
public sealed record class SecretListResponse : ModelBase, IFromRaw<SecretListResponse>
{
    public List<SecretResponse>? Items
    {
        get
        {
            if (!this.Properties.TryGetValue("items", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<List<SecretResponse>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["items"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public long? Limit
    {
        get
        {
            if (!this.Properties.TryGetValue("limit", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["limit"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public long? Offset
    {
        get
        {
            if (!this.Properties.TryGetValue("offset", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["offset"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public long? PageCount
    {
        get
        {
            if (!this.Properties.TryGetValue("page_count", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["page_count"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public long? TotalCount
    {
        get
        {
            if (!this.Properties.TryGetValue("total_count", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["total_count"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        foreach (var item in this.Items ?? [])
        {
            item.Validate();
        }
        _ = this.Limit;
        _ = this.Offset;
        _ = this.PageCount;
        _ = this.TotalCount;
    }

    public SecretListResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    SecretListResponse(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static SecretListResponse FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
