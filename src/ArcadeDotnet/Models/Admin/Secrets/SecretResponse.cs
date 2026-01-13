using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using System = System;

namespace ArcadeDotnet.Models.Admin.Secrets;

[JsonConverter(typeof(JsonModelConverter<SecretResponse, SecretResponseFromRaw>))]
public sealed record class SecretResponse : JsonModel
{
    public string? ID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("id", value);
        }
    }

    public Binding? Binding
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<Binding>("binding");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("binding", value);
        }
    }

    public string? CreatedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("created_at");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("created_at", value);
        }
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

    public string? Hint
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("hint");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("hint", value);
        }
    }

    public string? Key
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("key");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("key", value);
        }
    }

    public string? LastAccessedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("last_accessed_at");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("last_accessed_at", value);
        }
    }

    public string? UpdatedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("updated_at");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("updated_at", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        this.Binding?.Validate();
        _ = this.CreatedAt;
        _ = this.Description;
        _ = this.Hint;
        _ = this.Key;
        _ = this.LastAccessedAt;
        _ = this.UpdatedAt;
    }

    public SecretResponse() { }

    public SecretResponse(SecretResponse secretResponse)
        : base(secretResponse) { }

    public SecretResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    SecretResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="SecretResponseFromRaw.FromRawUnchecked"/>
    public static SecretResponse FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class SecretResponseFromRaw : IFromRawJson<SecretResponse>
{
    /// <inheritdoc/>
    public SecretResponse FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        SecretResponse.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Binding, BindingFromRaw>))]
public sealed record class Binding : JsonModel
{
    public string? ID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("id", value);
        }
    }

    public ApiEnum<string, global::ArcadeDotnet.Models.Admin.Secrets.Type>? Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, global::ArcadeDotnet.Models.Admin.Secrets.Type>
            >("type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("type", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        this.Type?.Validate();
    }

    public Binding() { }

    public Binding(Binding binding)
        : base(binding) { }

    public Binding(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Binding(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="BindingFromRaw.FromRawUnchecked"/>
    public static Binding FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class BindingFromRaw : IFromRawJson<Binding>
{
    /// <inheritdoc/>
    public Binding FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Binding.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(TypeConverter))]
public enum Type
{
    Static,
    Tenant,
    Project,
    Account,
}

sealed class TypeConverter : JsonConverter<global::ArcadeDotnet.Models.Admin.Secrets.Type>
{
    public override global::ArcadeDotnet.Models.Admin.Secrets.Type Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "static" => global::ArcadeDotnet.Models.Admin.Secrets.Type.Static,
            "tenant" => global::ArcadeDotnet.Models.Admin.Secrets.Type.Tenant,
            "project" => global::ArcadeDotnet.Models.Admin.Secrets.Type.Project,
            "account" => global::ArcadeDotnet.Models.Admin.Secrets.Type.Account,
            _ => (global::ArcadeDotnet.Models.Admin.Secrets.Type)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        global::ArcadeDotnet.Models.Admin.Secrets.Type value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                global::ArcadeDotnet.Models.Admin.Secrets.Type.Static => "static",
                global::ArcadeDotnet.Models.Admin.Secrets.Type.Tenant => "tenant",
                global::ArcadeDotnet.Models.Admin.Secrets.Type.Project => "project",
                global::ArcadeDotnet.Models.Admin.Secrets.Type.Account => "account",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
