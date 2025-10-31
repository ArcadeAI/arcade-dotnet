using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Exceptions;
using System = System;

namespace ArcadeDotnet.Models.Workers.WorkerResponseProperties.BindingProperties;

[JsonConverter(
    typeof(global::ArcadeDotnet.Models.Workers.WorkerResponseProperties.BindingProperties.TypeConverter)
)]
public enum Type
{
    Static,
    Tenant,
    Project,
    Account,
}

sealed class TypeConverter
    : JsonConverter<global::ArcadeDotnet.Models.Workers.WorkerResponseProperties.BindingProperties.Type>
{
    public override global::ArcadeDotnet.Models.Workers.WorkerResponseProperties.BindingProperties.Type Read(
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
            _ =>
                (global::ArcadeDotnet.Models.Workers.WorkerResponseProperties.BindingProperties.Type)(
                    -1
                ),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        global::ArcadeDotnet.Models.Workers.WorkerResponseProperties.BindingProperties.Type value,
        JsonSerializerOptions options
    )
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
