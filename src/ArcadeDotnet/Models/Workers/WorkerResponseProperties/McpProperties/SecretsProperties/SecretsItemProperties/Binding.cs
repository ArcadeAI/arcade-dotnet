using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Exceptions;
using System = System;

namespace ArcadeDotnet.Models.Workers.WorkerResponseProperties.McpProperties.SecretsProperties.SecretsItemProperties;

[JsonConverter(typeof(BindingConverter))]
public enum Binding
{
    Static,
    Tenant,
    Project,
    Account,
}

sealed class BindingConverter : JsonConverter<Binding>
{
    public override Binding Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "static" => Binding.Static,
            "tenant" => Binding.Tenant,
            "project" => Binding.Project,
            "account" => Binding.Account,
            _ => (Binding)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, Binding value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Binding.Static => "static",
                Binding.Tenant => "tenant",
                Binding.Project => "project",
                Binding.Account => "account",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
