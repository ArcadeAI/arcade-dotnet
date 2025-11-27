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
        get
        {
            if (!this._rawData.TryGetValue("id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Binding? Binding
    {
        get
        {
            if (!this._rawData.TryGetValue("binding", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Binding?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["binding"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public bool? Enabled
    {
        get
        {
            if (!this._rawData.TryGetValue("enabled", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["enabled"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public WorkerResponseHTTP? HTTP
    {
        get
        {
            if (!this._rawData.TryGetValue("http", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<WorkerResponseHTTP?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["http"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public bool? Managed
    {
        get
        {
            if (!this._rawData.TryGetValue("managed", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["managed"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public WorkerResponseMcp? Mcp
    {
        get
        {
            if (!this._rawData.TryGetValue("mcp", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<WorkerResponseMcp?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["mcp"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Requirements? Requirements
    {
        get
        {
            if (!this._rawData.TryGetValue("requirements", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Requirements?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["requirements"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public ApiEnum<string, WorkerResponseType>? Type
    {
        get
        {
            if (!this._rawData.TryGetValue("type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<string, WorkerResponseType>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["type"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

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

    public static WorkerResponse FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class WorkerResponseFromRaw : IFromRaw<WorkerResponse>
{
    public WorkerResponse FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        WorkerResponse.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ModelConverter<Binding, BindingFromRaw>))]
public sealed record class Binding : ModelBase
{
    public string? ID
    {
        get
        {
            if (!this._rawData.TryGetValue("id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public ApiEnum<string, global::ArcadeDotnet.Models.Workers.Type>? Type
    {
        get
        {
            if (!this._rawData.TryGetValue("type", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<
                string,
                global::ArcadeDotnet.Models.Workers.Type
            >?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["type"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

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

    public static Binding FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class BindingFromRaw : IFromRaw<Binding>
{
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
        get
        {
            if (!this._rawData.TryGetValue("retry", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["retry"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Secret? Secret
    {
        get
        {
            if (!this._rawData.TryGetValue("secret", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Secret?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["secret"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public long? Timeout
    {
        get
        {
            if (!this._rawData.TryGetValue("timeout", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["timeout"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Uri
    {
        get
        {
            if (!this._rawData.TryGetValue("uri", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["uri"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

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

    public static WorkerResponseHTTP FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class WorkerResponseHTTPFromRaw : IFromRaw<WorkerResponseHTTP>
{
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
            if (!this._rawData.TryGetValue("binding", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<string, SecretBinding>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["binding"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public bool? Editable
    {
        get
        {
            if (!this._rawData.TryGetValue("editable", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["editable"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public bool? Exists
    {
        get
        {
            if (!this._rawData.TryGetValue("exists", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["exists"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Hint
    {
        get
        {
            if (!this._rawData.TryGetValue("hint", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["hint"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Value
    {
        get
        {
            if (!this._rawData.TryGetValue("value", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["value"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

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

    public static Secret FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class SecretFromRaw : IFromRaw<Secret>
{
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
            if (!this._rawData.TryGetValue("headers", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Dictionary<string, string>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["headers"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public WorkerResponseMcpOauth2? Oauth2
    {
        get
        {
            if (!this._rawData.TryGetValue("oauth2", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<WorkerResponseMcpOauth2?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["oauth2"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public long? Retry
    {
        get
        {
            if (!this._rawData.TryGetValue("retry", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["retry"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public IReadOnlyDictionary<string, SecretsItem>? Secrets
    {
        get
        {
            if (!this._rawData.TryGetValue("secrets", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Dictionary<string, SecretsItem>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["secrets"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public long? Timeout
    {
        get
        {
            if (!this._rawData.TryGetValue("timeout", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["timeout"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Uri
    {
        get
        {
            if (!this._rawData.TryGetValue("uri", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["uri"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

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

    public static WorkerResponseMcp FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class WorkerResponseMcpFromRaw : IFromRaw<WorkerResponseMcp>
{
    public WorkerResponseMcp FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        WorkerResponseMcp.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ModelConverter<WorkerResponseMcpOauth2, WorkerResponseMcpOauth2FromRaw>))]
public sealed record class WorkerResponseMcpOauth2 : ModelBase
{
    public string? AuthorizationURL
    {
        get
        {
            if (!this._rawData.TryGetValue("authorization_url", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["authorization_url"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? ClientID
    {
        get
        {
            if (!this._rawData.TryGetValue("client_id", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["client_id"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public ClientSecret? ClientSecret
    {
        get
        {
            if (!this._rawData.TryGetValue("client_secret", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ClientSecret?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["client_secret"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? RedirectUri
    {
        get
        {
            if (!this._rawData.TryGetValue("redirect_uri", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["redirect_uri"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

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

    public static WorkerResponseMcpOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class WorkerResponseMcpOauth2FromRaw : IFromRaw<WorkerResponseMcpOauth2>
{
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
            if (!this._rawData.TryGetValue("binding", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<string, ClientSecretBinding>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["binding"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public bool? Editable
    {
        get
        {
            if (!this._rawData.TryGetValue("editable", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["editable"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public bool? Exists
    {
        get
        {
            if (!this._rawData.TryGetValue("exists", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["exists"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Hint
    {
        get
        {
            if (!this._rawData.TryGetValue("hint", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["hint"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Value
    {
        get
        {
            if (!this._rawData.TryGetValue("value", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["value"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

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

    public static ClientSecret FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ClientSecretFromRaw : IFromRaw<ClientSecret>
{
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
            if (!this._rawData.TryGetValue("binding", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<ApiEnum<string, SecretsItemBinding>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["binding"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public bool? Editable
    {
        get
        {
            if (!this._rawData.TryGetValue("editable", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["editable"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public bool? Exists
    {
        get
        {
            if (!this._rawData.TryGetValue("exists", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["exists"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Hint
    {
        get
        {
            if (!this._rawData.TryGetValue("hint", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["hint"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Value
    {
        get
        {
            if (!this._rawData.TryGetValue("value", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["value"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

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

    public static SecretsItem FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class SecretsItemFromRaw : IFromRaw<SecretsItem>
{
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
        get
        {
            if (!this._rawData.TryGetValue("authorization", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Authorization?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["authorization"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public bool? Met
    {
        get
        {
            if (!this._rawData.TryGetValue("met", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["met"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

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

    public static Requirements FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class RequirementsFromRaw : IFromRaw<Requirements>
{
    public Requirements FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Requirements.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ModelConverter<Authorization, AuthorizationFromRaw>))]
public sealed record class Authorization : ModelBase
{
    public bool? Met
    {
        get
        {
            if (!this._rawData.TryGetValue("met", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["met"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public AuthorizationOauth2? Oauth2
    {
        get
        {
            if (!this._rawData.TryGetValue("oauth2", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<AuthorizationOauth2?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["oauth2"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

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

    public static Authorization FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthorizationFromRaw : IFromRaw<Authorization>
{
    public Authorization FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Authorization.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ModelConverter<AuthorizationOauth2, AuthorizationOauth2FromRaw>))]
public sealed record class AuthorizationOauth2 : ModelBase
{
    public bool? Met
    {
        get
        {
            if (!this._rawData.TryGetValue("met", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<bool?>(element, ModelBase.SerializerOptions);
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData["met"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

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

    public static AuthorizationOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthorizationOauth2FromRaw : IFromRaw<AuthorizationOauth2>
{
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
