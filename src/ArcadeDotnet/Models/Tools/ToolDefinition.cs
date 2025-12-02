using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;

namespace ArcadeDotnet.Models.Tools;

[JsonConverter(typeof(ModelConverter<ToolDefinition, ToolDefinitionFromRaw>))]
public sealed record class ToolDefinition : ModelBase
{
    public required string FullyQualifiedName
    {
        get { return ModelBase.GetNotNullClass<string>(this.RawData, "fully_qualified_name"); }
        init { ModelBase.Set(this._rawData, "fully_qualified_name", value); }
    }

    public required Input Input
    {
        get { return ModelBase.GetNotNullClass<Input>(this.RawData, "input"); }
        init { ModelBase.Set(this._rawData, "input", value); }
    }

    public required string Name
    {
        get { return ModelBase.GetNotNullClass<string>(this.RawData, "name"); }
        init { ModelBase.Set(this._rawData, "name", value); }
    }

    public required string QualifiedName
    {
        get { return ModelBase.GetNotNullClass<string>(this.RawData, "qualified_name"); }
        init { ModelBase.Set(this._rawData, "qualified_name", value); }
    }

    public required Toolkit Toolkit
    {
        get { return ModelBase.GetNotNullClass<Toolkit>(this.RawData, "toolkit"); }
        init { ModelBase.Set(this._rawData, "toolkit", value); }
    }

    public string? Description
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "description"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "description", value);
        }
    }

    public IReadOnlyDictionary<string, JsonElement>? FormattedSchema
    {
        get
        {
            return ModelBase.GetNullableClass<Dictionary<string, JsonElement>>(
                this.RawData,
                "formatted_schema"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "formatted_schema", value);
        }
    }

    public ToolDefinitionOutput? Output
    {
        get { return ModelBase.GetNullableClass<ToolDefinitionOutput>(this.RawData, "output"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "output", value);
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

    public override void Validate()
    {
        _ = this.FullyQualifiedName;
        this.Input.Validate();
        _ = this.Name;
        _ = this.QualifiedName;
        this.Toolkit.Validate();
        _ = this.Description;
        _ = this.FormattedSchema;
        this.Output?.Validate();
        this.Requirements?.Validate();
    }

    public ToolDefinition() { }

    public ToolDefinition(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ToolDefinition(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    public static ToolDefinition FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ToolDefinitionFromRaw : IFromRaw<ToolDefinition>
{
    public ToolDefinition FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        ToolDefinition.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ModelConverter<Input, InputFromRaw>))]
public sealed record class Input : ModelBase
{
    public IReadOnlyList<Parameter>? Parameters
    {
        get { return ModelBase.GetNullableClass<List<Parameter>>(this.RawData, "parameters"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "parameters", value);
        }
    }

    public override void Validate()
    {
        foreach (var item in this.Parameters ?? [])
        {
            item.Validate();
        }
    }

    public Input() { }

    public Input(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Input(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    public static Input FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class InputFromRaw : IFromRaw<Input>
{
    public Input FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Input.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ModelConverter<Parameter, ParameterFromRaw>))]
public sealed record class Parameter : ModelBase
{
    public required string Name
    {
        get { return ModelBase.GetNotNullClass<string>(this.RawData, "name"); }
        init { ModelBase.Set(this._rawData, "name", value); }
    }

    public required ValueSchema ValueSchema
    {
        get { return ModelBase.GetNotNullClass<ValueSchema>(this.RawData, "value_schema"); }
        init { ModelBase.Set(this._rawData, "value_schema", value); }
    }

    public string? Description
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "description"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "description", value);
        }
    }

    public bool? Inferrable
    {
        get { return ModelBase.GetNullableStruct<bool>(this.RawData, "inferrable"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "inferrable", value);
        }
    }

    public bool? Required
    {
        get { return ModelBase.GetNullableStruct<bool>(this.RawData, "required"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "required", value);
        }
    }

    public override void Validate()
    {
        _ = this.Name;
        this.ValueSchema.Validate();
        _ = this.Description;
        _ = this.Inferrable;
        _ = this.Required;
    }

    public Parameter() { }

    public Parameter(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Parameter(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    public static Parameter FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ParameterFromRaw : IFromRaw<Parameter>
{
    public Parameter FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Parameter.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ModelConverter<Toolkit, ToolkitFromRaw>))]
public sealed record class Toolkit : ModelBase
{
    public required string Name
    {
        get { return ModelBase.GetNotNullClass<string>(this.RawData, "name"); }
        init { ModelBase.Set(this._rawData, "name", value); }
    }

    public string? Description
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "description"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "description", value);
        }
    }

    public string? Version
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "version"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "version", value);
        }
    }

    public override void Validate()
    {
        _ = this.Name;
        _ = this.Description;
        _ = this.Version;
    }

    public Toolkit() { }

    public Toolkit(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Toolkit(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    public static Toolkit FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public Toolkit(string name)
        : this()
    {
        this.Name = name;
    }
}

class ToolkitFromRaw : IFromRaw<Toolkit>
{
    public Toolkit FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Toolkit.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ModelConverter<ToolDefinitionOutput, ToolDefinitionOutputFromRaw>))]
public sealed record class ToolDefinitionOutput : ModelBase
{
    public IReadOnlyList<string>? AvailableModes
    {
        get { return ModelBase.GetNullableClass<List<string>>(this.RawData, "available_modes"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "available_modes", value);
        }
    }

    public string? Description
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "description"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "description", value);
        }
    }

    public ValueSchema? ValueSchema
    {
        get { return ModelBase.GetNullableClass<ValueSchema>(this.RawData, "value_schema"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "value_schema", value);
        }
    }

    public override void Validate()
    {
        _ = this.AvailableModes;
        _ = this.Description;
        this.ValueSchema?.Validate();
    }

    public ToolDefinitionOutput() { }

    public ToolDefinitionOutput(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ToolDefinitionOutput(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    public static ToolDefinitionOutput FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ToolDefinitionOutputFromRaw : IFromRaw<ToolDefinitionOutput>
{
    public ToolDefinitionOutput FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => ToolDefinitionOutput.FromRawUnchecked(rawData);
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

    public IReadOnlyList<Secret>? Secrets
    {
        get { return ModelBase.GetNullableClass<List<Secret>>(this.RawData, "secrets"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "secrets", value);
        }
    }

    public override void Validate()
    {
        this.Authorization?.Validate();
        _ = this.Met;
        foreach (var item in this.Secrets ?? [])
        {
            item.Validate();
        }
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

    public Oauth2? Oauth2
    {
        get { return ModelBase.GetNullableClass<Oauth2>(this.RawData, "oauth2"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "oauth2", value);
        }
    }

    public string? ProviderID
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "provider_id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "provider_id", value);
        }
    }

    public string? ProviderType
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "provider_type"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "provider_type", value);
        }
    }

    public ApiEnum<string, global::ArcadeDotnet.Models.Tools.Status>? Status
    {
        get
        {
            return ModelBase.GetNullableClass<
                ApiEnum<string, global::ArcadeDotnet.Models.Tools.Status>
            >(this.RawData, "status");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "status", value);
        }
    }

    public string? StatusReason
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "status_reason"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "status_reason", value);
        }
    }

    public ApiEnum<string, TokenStatus>? TokenStatus
    {
        get
        {
            return ModelBase.GetNullableClass<ApiEnum<string, TokenStatus>>(
                this.RawData,
                "token_status"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "token_status", value);
        }
    }

    public override void Validate()
    {
        _ = this.ID;
        this.Oauth2?.Validate();
        _ = this.ProviderID;
        _ = this.ProviderType;
        this.Status?.Validate();
        _ = this.StatusReason;
        this.TokenStatus?.Validate();
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

[JsonConverter(typeof(ModelConverter<Oauth2, Oauth2FromRaw>))]
public sealed record class Oauth2 : ModelBase
{
    public IReadOnlyList<string>? Scopes
    {
        get { return ModelBase.GetNullableClass<List<string>>(this.RawData, "scopes"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "scopes", value);
        }
    }

    public override void Validate()
    {
        _ = this.Scopes;
    }

    public Oauth2() { }

    public Oauth2(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Oauth2(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
    }
#pragma warning restore CS8618

    public static Oauth2 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class Oauth2FromRaw : IFromRaw<Oauth2>
{
    public Oauth2 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Oauth2.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(global::ArcadeDotnet.Models.Tools.StatusConverter))]
public enum Status
{
    Active,
    Inactive,
}

sealed class StatusConverter : JsonConverter<global::ArcadeDotnet.Models.Tools.Status>
{
    public override global::ArcadeDotnet.Models.Tools.Status Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "active" => global::ArcadeDotnet.Models.Tools.Status.Active,
            "inactive" => global::ArcadeDotnet.Models.Tools.Status.Inactive,
            _ => (global::ArcadeDotnet.Models.Tools.Status)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        global::ArcadeDotnet.Models.Tools.Status value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                global::ArcadeDotnet.Models.Tools.Status.Active => "active",
                global::ArcadeDotnet.Models.Tools.Status.Inactive => "inactive",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(TokenStatusConverter))]
public enum TokenStatus
{
    NotStarted,
    Pending,
    Completed,
    Failed,
}

sealed class TokenStatusConverter : JsonConverter<TokenStatus>
{
    public override TokenStatus Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "not_started" => TokenStatus.NotStarted,
            "pending" => TokenStatus.Pending,
            "completed" => TokenStatus.Completed,
            "failed" => TokenStatus.Failed,
            _ => (TokenStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        TokenStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                TokenStatus.NotStarted => "not_started",
                TokenStatus.Pending => "pending",
                TokenStatus.Completed => "completed",
                TokenStatus.Failed => "failed",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(ModelConverter<Secret, SecretFromRaw>))]
public sealed record class Secret : ModelBase
{
    public required string Key
    {
        get { return ModelBase.GetNotNullClass<string>(this.RawData, "key"); }
        init { ModelBase.Set(this._rawData, "key", value); }
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

    public string? StatusReason
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "status_reason"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "status_reason", value);
        }
    }

    public override void Validate()
    {
        _ = this.Key;
        _ = this.Met;
        _ = this.StatusReason;
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

    [SetsRequiredMembers]
    public Secret(string key)
        : this()
    {
        this.Key = key;
    }
}

class SecretFromRaw : IFromRaw<Secret>
{
    public Secret FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Secret.FromRawUnchecked(rawData);
}
