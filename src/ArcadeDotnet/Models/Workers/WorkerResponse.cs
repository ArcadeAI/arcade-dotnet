using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using System = System;

namespace ArcadeDotnet.Models.Workers;

[JsonConverter(typeof(ModelConverter<WorkerResponse, WorkerResponseFromRaw>))]
public sealed record class WorkerResponse : ModelBase
{
    public string? ID
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "id", value);
        }
    }

    public Binding? Binding
    {
        get { return ModelBase.GetNullableClass<Binding>(this.RawData, "binding"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "binding", value);
        }
    }

    public bool? Enabled
    {
        get { return ModelBase.GetNullableStruct<bool>(this.RawData, "enabled"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "enabled", value);
        }
    }

    public WorkerResponseHTTP? HTTP
    {
        get { return ModelBase.GetNullableClass<WorkerResponseHTTP>(this.RawData, "http"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "http", value);
        }
    }

    public bool? Managed
    {
        get { return ModelBase.GetNullableStruct<bool>(this.RawData, "managed"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "managed", value);
        }
    }

    public WorkerResponseMcp? Mcp
    {
        get { return ModelBase.GetNullableClass<WorkerResponseMcp>(this.RawData, "mcp"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "mcp", value);
        }
    }

    public Requirements? Requirements
    {
        get { return ModelBase.GetNullableClass<Requirements>(this.RawData, "requirements"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "requirements", value);
        }
    }

    public ApiEnum<string, WorkerResponseType>? Type
    {
        get
        {
            return ModelBase.GetNullableClass<ApiEnum<string, WorkerResponseType>>(
                this.RawData,
                "type"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "type", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        this.Binding?.Validate();
        _ = this.Enabled;
        this.HTTP?.Validate();
        _ = this.Managed;
        this.Mcp?.Validate();
        this.Requirements?.Validate();
        this.Type?.Validate();
    }

    public WorkerResponse() { }

    public WorkerResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WorkerResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="WorkerResponseFromRaw.FromRawUnchecked"/>
    public static WorkerResponse FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class WorkerResponseFromRaw : IFromRaw<WorkerResponse>
{
    /// <inheritdoc/>
    public WorkerResponse FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        WorkerResponse.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ModelConverter<Binding, BindingFromRaw>))]
public sealed record class Binding : ModelBase
{
    public string? ID
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "id", value);
        }
    }

    public ApiEnum<string, global::ArcadeDotnet.Models.Workers.Type>? Type
    {
        get
        {
            return ModelBase.GetNullableClass<
                ApiEnum<string, global::ArcadeDotnet.Models.Workers.Type>
            >(this.RawData, "type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "type", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        this.Type?.Validate();
    }

    public Binding() { }

    public Binding(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Binding(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="BindingFromRaw.FromRawUnchecked"/>
    public static Binding FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class BindingFromRaw : IFromRaw<Binding>
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

sealed class TypeConverter : JsonConverter<global::ArcadeDotnet.Models.Workers.Type>
{
    public override global::ArcadeDotnet.Models.Workers.Type Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "static" => global::ArcadeDotnet.Models.Workers.Type.Static,
            "tenant" => global::ArcadeDotnet.Models.Workers.Type.Tenant,
            "project" => global::ArcadeDotnet.Models.Workers.Type.Project,
            "account" => global::ArcadeDotnet.Models.Workers.Type.Account,
            _ => (global::ArcadeDotnet.Models.Workers.Type)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        global::ArcadeDotnet.Models.Workers.Type value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                global::ArcadeDotnet.Models.Workers.Type.Static => "static",
                global::ArcadeDotnet.Models.Workers.Type.Tenant => "tenant",
                global::ArcadeDotnet.Models.Workers.Type.Project => "project",
                global::ArcadeDotnet.Models.Workers.Type.Account => "account",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(ModelConverter<WorkerResponseHTTP, WorkerResponseHTTPFromRaw>))]
public sealed record class WorkerResponseHTTP : ModelBase
{
    public long? Retry
    {
        get { return ModelBase.GetNullableStruct<long>(this.RawData, "retry"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "retry", value);
        }
    }

    public Secret? Secret
    {
        get { return ModelBase.GetNullableClass<Secret>(this.RawData, "secret"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "secret", value);
        }
    }

    public long? Timeout
    {
        get { return ModelBase.GetNullableStruct<long>(this.RawData, "timeout"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "timeout", value);
        }
    }

    public string? Uri
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "uri"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "uri", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Retry;
        this.Secret?.Validate();
        _ = this.Timeout;
        _ = this.Uri;
    }

    public WorkerResponseHTTP() { }

    public WorkerResponseHTTP(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WorkerResponseHTTP(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="WorkerResponseHTTPFromRaw.FromRawUnchecked"/>
    public static WorkerResponseHTTP FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class WorkerResponseHTTPFromRaw : IFromRaw<WorkerResponseHTTP>
{
    /// <inheritdoc/>
    public WorkerResponseHTTP FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        WorkerResponseHTTP.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ModelConverter<Secret, SecretFromRaw>))]
public sealed record class Secret : ModelBase
{
    public ApiEnum<string, SecretBinding>? Binding
    {
        get
        {
            return ModelBase.GetNullableClass<ApiEnum<string, SecretBinding>>(
                this.RawData,
                "binding"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "binding", value);
        }
    }

    public bool? Editable
    {
        get { return ModelBase.GetNullableStruct<bool>(this.RawData, "editable"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "editable", value);
        }
    }

    public bool? Exists
    {
        get { return ModelBase.GetNullableStruct<bool>(this.RawData, "exists"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "exists", value);
        }
    }

    public string? Hint
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "hint"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "hint", value);
        }
    }

    public string? Value
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "value"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "value", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        this.Binding?.Validate();
        _ = this.Editable;
        _ = this.Exists;
        _ = this.Hint;
        _ = this.Value;
    }

    public Secret() { }

    public Secret(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Secret(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="SecretFromRaw.FromRawUnchecked"/>
    public static Secret FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class SecretFromRaw : IFromRaw<Secret>
{
    /// <inheritdoc/>
    public Secret FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Secret.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(SecretBindingConverter))]
public enum SecretBinding
{
    Static,
    Tenant,
    Project,
    Account,
}

sealed class SecretBindingConverter : JsonConverter<SecretBinding>
{
    public override SecretBinding Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "static" => SecretBinding.Static,
            "tenant" => SecretBinding.Tenant,
            "project" => SecretBinding.Project,
            "account" => SecretBinding.Account,
            _ => (SecretBinding)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        SecretBinding value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                SecretBinding.Static => "static",
                SecretBinding.Tenant => "tenant",
                SecretBinding.Project => "project",
                SecretBinding.Account => "account",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(ModelConverter<WorkerResponseMcp, WorkerResponseMcpFromRaw>))]
public sealed record class WorkerResponseMcp : ModelBase
{
    public IReadOnlyDictionary<string, string>? Headers
    {
        get
        {
            return ModelBase.GetNullableClass<Dictionary<string, string>>(this.RawData, "headers");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "headers", value);
        }
    }

    public WorkerResponseMcpOauth2? Oauth2
    {
        get { return ModelBase.GetNullableClass<WorkerResponseMcpOauth2>(this.RawData, "oauth2"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "oauth2", value);
        }
    }

    public long? Retry
    {
        get { return ModelBase.GetNullableStruct<long>(this.RawData, "retry"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "retry", value);
        }
    }

    public IReadOnlyDictionary<string, SecretsItem>? Secrets
    {
        get
        {
            return ModelBase.GetNullableClass<Dictionary<string, SecretsItem>>(
                this.RawData,
                "secrets"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "secrets", value);
        }
    }

    public long? Timeout
    {
        get { return ModelBase.GetNullableStruct<long>(this.RawData, "timeout"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "timeout", value);
        }
    }

    public string? Uri
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "uri"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "uri", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Headers;
        this.Oauth2?.Validate();
        _ = this.Retry;
        if (this.Secrets != null)
        {
            foreach (var item in this.Secrets.Values)
            {
                item.Validate();
            }
        }
        _ = this.Timeout;
        _ = this.Uri;
    }

    public WorkerResponseMcp() { }

    public WorkerResponseMcp(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WorkerResponseMcp(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="WorkerResponseMcpFromRaw.FromRawUnchecked"/>
    public static WorkerResponseMcp FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class WorkerResponseMcpFromRaw : IFromRaw<WorkerResponseMcp>
{
    /// <inheritdoc/>
    public WorkerResponseMcp FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        WorkerResponseMcp.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ModelConverter<WorkerResponseMcpOauth2, WorkerResponseMcpOauth2FromRaw>))]
public sealed record class WorkerResponseMcpOauth2 : ModelBase
{
    public string? AuthorizationURL
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "authorization_url"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "authorization_url", value);
        }
    }

    public string? ClientID
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "client_id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "client_id", value);
        }
    }

    public ClientSecret? ClientSecret
    {
        get { return ModelBase.GetNullableClass<ClientSecret>(this.RawData, "client_secret"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "client_secret", value);
        }
    }

    public string? RedirectUri
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "redirect_uri"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "redirect_uri", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.AuthorizationURL;
        _ = this.ClientID;
        this.ClientSecret?.Validate();
        _ = this.RedirectUri;
    }

    public WorkerResponseMcpOauth2() { }

    public WorkerResponseMcpOauth2(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WorkerResponseMcpOauth2(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="WorkerResponseMcpOauth2FromRaw.FromRawUnchecked"/>
    public static WorkerResponseMcpOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class WorkerResponseMcpOauth2FromRaw : IFromRaw<WorkerResponseMcpOauth2>
{
    /// <inheritdoc/>
    public WorkerResponseMcpOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => WorkerResponseMcpOauth2.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ModelConverter<ClientSecret, ClientSecretFromRaw>))]
public sealed record class ClientSecret : ModelBase
{
    public ApiEnum<string, ClientSecretBinding>? Binding
    {
        get
        {
            return ModelBase.GetNullableClass<ApiEnum<string, ClientSecretBinding>>(
                this.RawData,
                "binding"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "binding", value);
        }
    }

    public bool? Editable
    {
        get { return ModelBase.GetNullableStruct<bool>(this.RawData, "editable"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "editable", value);
        }
    }

    public bool? Exists
    {
        get { return ModelBase.GetNullableStruct<bool>(this.RawData, "exists"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "exists", value);
        }
    }

    public string? Hint
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "hint"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "hint", value);
        }
    }

    public string? Value
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "value"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "value", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        this.Binding?.Validate();
        _ = this.Editable;
        _ = this.Exists;
        _ = this.Hint;
        _ = this.Value;
    }

    public ClientSecret() { }

    public ClientSecret(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ClientSecret(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ClientSecretFromRaw.FromRawUnchecked"/>
    public static ClientSecret FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ClientSecretFromRaw : IFromRaw<ClientSecret>
{
    /// <inheritdoc/>
    public ClientSecret FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        ClientSecret.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ClientSecretBindingConverter))]
public enum ClientSecretBinding
{
    Static,
    Tenant,
    Project,
    Account,
}

sealed class ClientSecretBindingConverter : JsonConverter<ClientSecretBinding>
{
    public override ClientSecretBinding Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "static" => ClientSecretBinding.Static,
            "tenant" => ClientSecretBinding.Tenant,
            "project" => ClientSecretBinding.Project,
            "account" => ClientSecretBinding.Account,
            _ => (ClientSecretBinding)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        ClientSecretBinding value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                ClientSecretBinding.Static => "static",
                ClientSecretBinding.Tenant => "tenant",
                ClientSecretBinding.Project => "project",
                ClientSecretBinding.Account => "account",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(ModelConverter<SecretsItem, SecretsItemFromRaw>))]
public sealed record class SecretsItem : ModelBase
{
    public ApiEnum<string, SecretsItemBinding>? Binding
    {
        get
        {
            return ModelBase.GetNullableClass<ApiEnum<string, SecretsItemBinding>>(
                this.RawData,
                "binding"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "binding", value);
        }
    }

    public bool? Editable
    {
        get { return ModelBase.GetNullableStruct<bool>(this.RawData, "editable"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "editable", value);
        }
    }

    public bool? Exists
    {
        get { return ModelBase.GetNullableStruct<bool>(this.RawData, "exists"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "exists", value);
        }
    }

    public string? Hint
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "hint"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "hint", value);
        }
    }

    public string? Value
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "value"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "value", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        this.Binding?.Validate();
        _ = this.Editable;
        _ = this.Exists;
        _ = this.Hint;
        _ = this.Value;
    }

    public SecretsItem() { }

    public SecretsItem(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    SecretsItem(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="SecretsItemFromRaw.FromRawUnchecked"/>
    public static SecretsItem FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class SecretsItemFromRaw : IFromRaw<SecretsItem>
{
    /// <inheritdoc/>
    public SecretsItem FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        SecretsItem.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(SecretsItemBindingConverter))]
public enum SecretsItemBinding
{
    Static,
    Tenant,
    Project,
    Account,
}

sealed class SecretsItemBindingConverter : JsonConverter<SecretsItemBinding>
{
    public override SecretsItemBinding Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "static" => SecretsItemBinding.Static,
            "tenant" => SecretsItemBinding.Tenant,
            "project" => SecretsItemBinding.Project,
            "account" => SecretsItemBinding.Account,
            _ => (SecretsItemBinding)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        SecretsItemBinding value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                SecretsItemBinding.Static => "static",
                SecretsItemBinding.Tenant => "tenant",
                SecretsItemBinding.Project => "project",
                SecretsItemBinding.Account => "account",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(ModelConverter<Requirements, RequirementsFromRaw>))]
public sealed record class Requirements : ModelBase
{
    public Authorization? Authorization
    {
        get { return ModelBase.GetNullableClass<Authorization>(this.RawData, "authorization"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "authorization", value);
        }
    }

    public bool? Met
    {
        get { return ModelBase.GetNullableStruct<bool>(this.RawData, "met"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "met", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        this.Authorization?.Validate();
        _ = this.Met;
    }

    public Requirements() { }

    public Requirements(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Requirements(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="RequirementsFromRaw.FromRawUnchecked"/>
    public static Requirements FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class RequirementsFromRaw : IFromRaw<Requirements>
{
    /// <inheritdoc/>
    public Requirements FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Requirements.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ModelConverter<Authorization, AuthorizationFromRaw>))]
public sealed record class Authorization : ModelBase
{
    public bool? Met
    {
        get { return ModelBase.GetNullableStruct<bool>(this.RawData, "met"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "met", value);
        }
    }

    public AuthorizationOauth2? Oauth2
    {
        get { return ModelBase.GetNullableClass<AuthorizationOauth2>(this.RawData, "oauth2"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "oauth2", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Met;
        this.Oauth2?.Validate();
    }

    public Authorization() { }

    public Authorization(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Authorization(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthorizationFromRaw.FromRawUnchecked"/>
    public static Authorization FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthorizationFromRaw : IFromRaw<Authorization>
{
    /// <inheritdoc/>
    public Authorization FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Authorization.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ModelConverter<AuthorizationOauth2, AuthorizationOauth2FromRaw>))]
public sealed record class AuthorizationOauth2 : ModelBase
{
    public bool? Met
    {
        get { return ModelBase.GetNullableStruct<bool>(this.RawData, "met"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "met", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Met;
    }

    public AuthorizationOauth2() { }

    public AuthorizationOauth2(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthorizationOauth2(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthorizationOauth2FromRaw.FromRawUnchecked"/>
    public static AuthorizationOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthorizationOauth2FromRaw : IFromRaw<AuthorizationOauth2>
{
    /// <inheritdoc/>
    public AuthorizationOauth2 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        AuthorizationOauth2.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(WorkerResponseTypeConverter))]
public enum WorkerResponseType
{
    HTTP,
    Mcp,
    Unknown,
}

sealed class WorkerResponseTypeConverter : JsonConverter<WorkerResponseType>
{
    public override WorkerResponseType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "http" => WorkerResponseType.HTTP,
            "mcp" => WorkerResponseType.Mcp,
            "unknown" => WorkerResponseType.Unknown,
            _ => (WorkerResponseType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        WorkerResponseType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                WorkerResponseType.HTTP => "http",
                WorkerResponseType.Mcp => "mcp",
                WorkerResponseType.Unknown => "unknown",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
