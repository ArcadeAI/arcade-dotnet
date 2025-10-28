using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeEngine.Exceptions;
using System = System;

namespace ArcadeEngine.Models.Admin.AuthProviders.AuthProviderResponseProperties.BindingProperties;

[JsonConverter(typeof(TypeConverter))]
public enum Type
{
    Static,
    Tenant,
    Project,
    Account,
}

sealed class TypeConverter : JsonConverter<Type>
{
    public override Type Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "static" => BindingProperties.Type.Static,
            "tenant" => BindingProperties.Type.Tenant,
            "project" => BindingProperties.Type.Project,
            "account" => BindingProperties.Type.Account,
            _ => (Type)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, Type value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                BindingProperties.Type.Static => "static",
                BindingProperties.Type.Tenant => "tenant",
                BindingProperties.Type.Project => "project",
                BindingProperties.Type.Account => "account",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
