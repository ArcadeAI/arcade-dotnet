using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Exceptions;

namespace ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderResponseProperties.Oauth2Properties.ClientSecretProperties;

[JsonConverter(typeof(BindingConverter))]
public enum Binding
{
    Static,
    Tenant,
    Project,
    Account,
}

sealed class BindingConverter
    : JsonConverter<global::ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderResponseProperties.Oauth2Properties.ClientSecretProperties.Binding>
{
    public override global::ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderResponseProperties.Oauth2Properties.ClientSecretProperties.Binding Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "static" => Binding.Static,
            "tenant" => Binding.Tenant,
            "project" => Binding.Project,
            "account" => Binding.Account,
            _ =>
                (global::ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderResponseProperties.Oauth2Properties.ClientSecretProperties.Binding)(
                    -1
                ),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        global::ArcadeDotnet.Models.Admin.AuthProviders.AuthProviderResponseProperties.Oauth2Properties.ClientSecretProperties.Binding value,
        JsonSerializerOptions options
    )
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
