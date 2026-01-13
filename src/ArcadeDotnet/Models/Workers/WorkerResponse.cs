using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using System = System;

namespace ArcadeDotnet.Models.Workers;

[JsonConverter(typeof(JsonModelConverter<WorkerResponse, WorkerResponseFromRaw>))]
public sealed record class WorkerResponse : JsonModel
{
    public string? ID
    {
        get { return this._rawData.GetNullableClass<string>("id"); }
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
        get { return this._rawData.GetNullableClass<Binding>("binding"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("binding", value);
        }
    }

    public bool? Enabled
    {
        get { return this._rawData.GetNullableStruct<bool>("enabled"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("enabled", value);
        }
    }

    public WorkerResponseHttp? Http
    {
        get { return this._rawData.GetNullableClass<WorkerResponseHttp>("http"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("http", value);
        }
    }

    public bool? Managed
    {
        get { return this._rawData.GetNullableStruct<bool>("managed"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("managed", value);
        }
    }

    public WorkerResponseMcp? Mcp
    {
        get { return this._rawData.GetNullableClass<WorkerResponseMcp>("mcp"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("mcp", value);
        }
    }

    public Requirements? Requirements
    {
        get { return this._rawData.GetNullableClass<Requirements>("requirements"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("requirements", value);
        }
    }

    public ApiEnum<string, WorkerResponseType>? Type
    {
        get { return this._rawData.GetNullableClass<ApiEnum<string, WorkerResponseType>>("type"); }
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
        this.Binding?.Validate();
        _ = this.Enabled;
        this.Http?.Validate();
        _ = this.Managed;
        this.Mcp?.Validate();
        this.Requirements?.Validate();
        this.Type?.Validate();
    }

    public WorkerResponse() { }

    public WorkerResponse(WorkerResponse workerResponse)
        : base(workerResponse) { }

    public WorkerResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WorkerResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="WorkerResponseFromRaw.FromRawUnchecked"/>
    public static WorkerResponse FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class WorkerResponseFromRaw : IFromRawJson<WorkerResponse>
{
    /// <inheritdoc/>
    public WorkerResponse FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        WorkerResponse.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Binding, BindingFromRaw>))]
public sealed record class Binding : JsonModel
{
    public string? ID
    {
        get { return this._rawData.GetNullableClass<string>("id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("id", value);
        }
    }

    public ApiEnum<string, global::ArcadeDotnet.Models.Workers.Type>? Type
    {
        get
        {
            return this._rawData.GetNullableClass<
                ApiEnum<string, global::ArcadeDotnet.Models.Workers.Type>
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

[JsonConverter(typeof(JsonModelConverter<WorkerResponseHttp, WorkerResponseHttpFromRaw>))]
public sealed record class WorkerResponseHttp : JsonModel
{
    public long? Retry
    {
        get { return this._rawData.GetNullableStruct<long>("retry"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("retry", value);
        }
    }

    public Secret? Secret
    {
        get { return this._rawData.GetNullableClass<Secret>("secret"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("secret", value);
        }
    }

    public long? Timeout
    {
        get { return this._rawData.GetNullableStruct<long>("timeout"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("timeout", value);
        }
    }

    public string? Uri
    {
        get { return this._rawData.GetNullableClass<string>("uri"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("uri", value);
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

    public WorkerResponseHttp() { }

    public WorkerResponseHttp(WorkerResponseHttp workerResponseHttp)
        : base(workerResponseHttp) { }

    public WorkerResponseHttp(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WorkerResponseHttp(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="WorkerResponseHttpFromRaw.FromRawUnchecked"/>
    public static WorkerResponseHttp FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class WorkerResponseHttpFromRaw : IFromRawJson<WorkerResponseHttp>
{
    /// <inheritdoc/>
    public WorkerResponseHttp FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        WorkerResponseHttp.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Secret, SecretFromRaw>))]
public sealed record class Secret : JsonModel
{
    public ApiEnum<string, SecretBinding>? Binding
    {
        get { return this._rawData.GetNullableClass<ApiEnum<string, SecretBinding>>("binding"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("binding", value);
        }
    }

    public bool? Editable
    {
        get { return this._rawData.GetNullableStruct<bool>("editable"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("editable", value);
        }
    }

    public bool? Exists
    {
        get { return this._rawData.GetNullableStruct<bool>("exists"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("exists", value);
        }
    }

    public string? Hint
    {
        get { return this._rawData.GetNullableClass<string>("hint"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("hint", value);
        }
    }

    public string? Value
    {
        get { return this._rawData.GetNullableClass<string>("value"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("value", value);
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

    public Secret(Secret secret)
        : base(secret) { }

    public Secret(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Secret(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="SecretFromRaw.FromRawUnchecked"/>
    public static Secret FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class SecretFromRaw : IFromRawJson<Secret>
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

[JsonConverter(typeof(JsonModelConverter<WorkerResponseMcp, WorkerResponseMcpFromRaw>))]
public sealed record class WorkerResponseMcp : JsonModel
{
    public IReadOnlyDictionary<string, string>? Headers
    {
        get { return this._rawData.GetNullableClass<FrozenDictionary<string, string>>("headers"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<FrozenDictionary<string, string>?>(
                "headers",
                value == null ? null : FrozenDictionary.ToFrozenDictionary(value)
            );
        }
    }

    public WorkerResponseMcpOauth2? Oauth2
    {
        get { return this._rawData.GetNullableClass<WorkerResponseMcpOauth2>("oauth2"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("oauth2", value);
        }
    }

    public long? Retry
    {
        get { return this._rawData.GetNullableStruct<long>("retry"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("retry", value);
        }
    }

    public IReadOnlyDictionary<string, SecretsItem>? Secrets
    {
        get
        {
            return this._rawData.GetNullableClass<FrozenDictionary<string, SecretsItem>>("secrets");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<FrozenDictionary<string, SecretsItem>?>(
                "secrets",
                value == null ? null : FrozenDictionary.ToFrozenDictionary(value)
            );
        }
    }

    public long? Timeout
    {
        get { return this._rawData.GetNullableStruct<long>("timeout"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("timeout", value);
        }
    }

    public string? Uri
    {
        get { return this._rawData.GetNullableClass<string>("uri"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("uri", value);
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

    public WorkerResponseMcp(WorkerResponseMcp workerResponseMcp)
        : base(workerResponseMcp) { }

    public WorkerResponseMcp(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WorkerResponseMcp(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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

class WorkerResponseMcpFromRaw : IFromRawJson<WorkerResponseMcp>
{
    /// <inheritdoc/>
    public WorkerResponseMcp FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        WorkerResponseMcp.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<WorkerResponseMcpOauth2, WorkerResponseMcpOauth2FromRaw>))]
public sealed record class WorkerResponseMcpOauth2 : JsonModel
{
    public string? AuthorizationUrl
    {
        get { return this._rawData.GetNullableClass<string>("authorization_url"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("authorization_url", value);
        }
    }

    public string? ClientID
    {
        get { return this._rawData.GetNullableClass<string>("client_id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("client_id", value);
        }
    }

    public ClientSecret? ClientSecret
    {
        get { return this._rawData.GetNullableClass<ClientSecret>("client_secret"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("client_secret", value);
        }
    }

    public string? RedirectUri
    {
        get { return this._rawData.GetNullableClass<string>("redirect_uri"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("redirect_uri", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.AuthorizationUrl;
        _ = this.ClientID;
        this.ClientSecret?.Validate();
        _ = this.RedirectUri;
    }

    public WorkerResponseMcpOauth2() { }

    public WorkerResponseMcpOauth2(WorkerResponseMcpOauth2 workerResponseMcpOauth2)
        : base(workerResponseMcpOauth2) { }

    public WorkerResponseMcpOauth2(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WorkerResponseMcpOauth2(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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

class WorkerResponseMcpOauth2FromRaw : IFromRawJson<WorkerResponseMcpOauth2>
{
    /// <inheritdoc/>
    public WorkerResponseMcpOauth2 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => WorkerResponseMcpOauth2.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<ClientSecret, ClientSecretFromRaw>))]
public sealed record class ClientSecret : JsonModel
{
    public ApiEnum<string, ClientSecretBinding>? Binding
    {
        get
        {
            return this._rawData.GetNullableClass<ApiEnum<string, ClientSecretBinding>>("binding");
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

    public bool? Editable
    {
        get { return this._rawData.GetNullableStruct<bool>("editable"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("editable", value);
        }
    }

    public bool? Exists
    {
        get { return this._rawData.GetNullableStruct<bool>("exists"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("exists", value);
        }
    }

    public string? Hint
    {
        get { return this._rawData.GetNullableClass<string>("hint"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("hint", value);
        }
    }

    public string? Value
    {
        get { return this._rawData.GetNullableClass<string>("value"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("value", value);
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

    public ClientSecret(ClientSecret clientSecret)
        : base(clientSecret) { }

    public ClientSecret(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ClientSecret(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ClientSecretFromRaw.FromRawUnchecked"/>
    public static ClientSecret FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ClientSecretFromRaw : IFromRawJson<ClientSecret>
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

[JsonConverter(typeof(JsonModelConverter<SecretsItem, SecretsItemFromRaw>))]
public sealed record class SecretsItem : JsonModel
{
    public ApiEnum<string, SecretsItemBinding>? Binding
    {
        get
        {
            return this._rawData.GetNullableClass<ApiEnum<string, SecretsItemBinding>>("binding");
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

    public bool? Editable
    {
        get { return this._rawData.GetNullableStruct<bool>("editable"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("editable", value);
        }
    }

    public bool? Exists
    {
        get { return this._rawData.GetNullableStruct<bool>("exists"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("exists", value);
        }
    }

    public string? Hint
    {
        get { return this._rawData.GetNullableClass<string>("hint"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("hint", value);
        }
    }

    public string? Value
    {
        get { return this._rawData.GetNullableClass<string>("value"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("value", value);
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

    public SecretsItem(SecretsItem secretsItem)
        : base(secretsItem) { }

    public SecretsItem(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    SecretsItem(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="SecretsItemFromRaw.FromRawUnchecked"/>
    public static SecretsItem FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class SecretsItemFromRaw : IFromRawJson<SecretsItem>
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

[JsonConverter(typeof(JsonModelConverter<Requirements, RequirementsFromRaw>))]
public sealed record class Requirements : JsonModel
{
    public Authorization? Authorization
    {
        get { return this._rawData.GetNullableClass<Authorization>("authorization"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("authorization", value);
        }
    }

    public bool? Met
    {
        get { return this._rawData.GetNullableStruct<bool>("met"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("met", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        this.Authorization?.Validate();
        _ = this.Met;
    }

    public Requirements() { }

    public Requirements(Requirements requirements)
        : base(requirements) { }

    public Requirements(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Requirements(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="RequirementsFromRaw.FromRawUnchecked"/>
    public static Requirements FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class RequirementsFromRaw : IFromRawJson<Requirements>
{
    /// <inheritdoc/>
    public Requirements FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Requirements.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Authorization, AuthorizationFromRaw>))]
public sealed record class Authorization : JsonModel
{
    public bool? Met
    {
        get { return this._rawData.GetNullableStruct<bool>("met"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("met", value);
        }
    }

    public AuthorizationOauth2? Oauth2
    {
        get { return this._rawData.GetNullableClass<AuthorizationOauth2>("oauth2"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("oauth2", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Met;
        this.Oauth2?.Validate();
    }

    public Authorization() { }

    public Authorization(Authorization authorization)
        : base(authorization) { }

    public Authorization(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Authorization(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthorizationFromRaw.FromRawUnchecked"/>
    public static Authorization FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthorizationFromRaw : IFromRawJson<Authorization>
{
    /// <inheritdoc/>
    public Authorization FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Authorization.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<AuthorizationOauth2, AuthorizationOauth2FromRaw>))]
public sealed record class AuthorizationOauth2 : JsonModel
{
    public bool? Met
    {
        get { return this._rawData.GetNullableStruct<bool>("met"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("met", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Met;
    }

    public AuthorizationOauth2() { }

    public AuthorizationOauth2(AuthorizationOauth2 authorizationOauth2)
        : base(authorizationOauth2) { }

    public AuthorizationOauth2(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthorizationOauth2(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
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

class AuthorizationOauth2FromRaw : IFromRawJson<AuthorizationOauth2>
{
    /// <inheritdoc/>
    public AuthorizationOauth2 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        AuthorizationOauth2.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(WorkerResponseTypeConverter))]
public enum WorkerResponseType
{
    Http,
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
            "http" => WorkerResponseType.Http,
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
                WorkerResponseType.Http => "http",
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
