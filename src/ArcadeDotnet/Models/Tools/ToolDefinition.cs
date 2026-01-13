using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;

namespace ArcadeDotnet.Models.Tools;

[JsonConverter(typeof(JsonModelConverter<ToolDefinition, ToolDefinitionFromRaw>))]
public sealed record class ToolDefinition : JsonModel
{
    public required string FullyQualifiedName
    {
        get { return this._rawData.GetNotNullClass<string>("fully_qualified_name"); }
        init { this._rawData.Set("fully_qualified_name", value); }
    }

    public required Input Input
    {
        get { return this._rawData.GetNotNullClass<Input>("input"); }
        init { this._rawData.Set("input", value); }
    }

    public required string Name
    {
        get { return this._rawData.GetNotNullClass<string>("name"); }
        init { this._rawData.Set("name", value); }
    }

    public required string QualifiedName
    {
        get { return this._rawData.GetNotNullClass<string>("qualified_name"); }
        init { this._rawData.Set("qualified_name", value); }
    }

    public required Toolkit Toolkit
    {
        get { return this._rawData.GetNotNullClass<Toolkit>("toolkit"); }
        init { this._rawData.Set("toolkit", value); }
    }

    public string? Description
    {
        get { return this._rawData.GetNullableClass<string>("description"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("description", value);
        }
    }

    public IReadOnlyDictionary<string, JsonElement>? FormattedSchema
    {
        get
        {
            return this._rawData.GetNullableClass<FrozenDictionary<string, JsonElement>>(
                "formatted_schema"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<FrozenDictionary<string, JsonElement>?>(
                "formatted_schema",
                value == null ? null : FrozenDictionary.ToFrozenDictionary(value)
            );
        }
    }

    public ToolDefinitionOutput? Output
    {
        get { return this._rawData.GetNullableClass<ToolDefinitionOutput>("output"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("output", value);
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

    /// <inheritdoc/>
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

    public ToolDefinition(ToolDefinition toolDefinition)
        : base(toolDefinition) { }

    public ToolDefinition(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ToolDefinition(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ToolDefinitionFromRaw.FromRawUnchecked"/>
    public static ToolDefinition FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ToolDefinitionFromRaw : IFromRawJson<ToolDefinition>
{
    /// <inheritdoc/>
    public ToolDefinition FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        ToolDefinition.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Input, InputFromRaw>))]
public sealed record class Input : JsonModel
{
    public IReadOnlyList<Parameter>? Parameters
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<Parameter>>("parameters"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<Parameter>?>(
                "parameters",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        foreach (var item in this.Parameters ?? [])
        {
            item.Validate();
        }
    }

    public Input() { }

    public Input(Input input)
        : base(input) { }

    public Input(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Input(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="InputFromRaw.FromRawUnchecked"/>
    public static Input FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class InputFromRaw : IFromRawJson<Input>
{
    /// <inheritdoc/>
    public Input FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Input.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Parameter, ParameterFromRaw>))]
public sealed record class Parameter : JsonModel
{
    public required string Name
    {
        get { return this._rawData.GetNotNullClass<string>("name"); }
        init { this._rawData.Set("name", value); }
    }

    public required ValueSchema ValueSchema
    {
        get { return this._rawData.GetNotNullClass<ValueSchema>("value_schema"); }
        init { this._rawData.Set("value_schema", value); }
    }

    public string? Description
    {
        get { return this._rawData.GetNullableClass<string>("description"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("description", value);
        }
    }

    public bool? Inferrable
    {
        get { return this._rawData.GetNullableStruct<bool>("inferrable"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("inferrable", value);
        }
    }

    public bool? Required
    {
        get { return this._rawData.GetNullableStruct<bool>("required"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("required", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Name;
        this.ValueSchema.Validate();
        _ = this.Description;
        _ = this.Inferrable;
        _ = this.Required;
    }

    public Parameter() { }

    public Parameter(Parameter parameter)
        : base(parameter) { }

    public Parameter(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Parameter(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ParameterFromRaw.FromRawUnchecked"/>
    public static Parameter FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ParameterFromRaw : IFromRawJson<Parameter>
{
    /// <inheritdoc/>
    public Parameter FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Parameter.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Toolkit, ToolkitFromRaw>))]
public sealed record class Toolkit : JsonModel
{
    public required string Name
    {
        get { return this._rawData.GetNotNullClass<string>("name"); }
        init { this._rawData.Set("name", value); }
    }

    public string? Description
    {
        get { return this._rawData.GetNullableClass<string>("description"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("description", value);
        }
    }

    public string? Version
    {
        get { return this._rawData.GetNullableClass<string>("version"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("version", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Name;
        _ = this.Description;
        _ = this.Version;
    }

    public Toolkit() { }

    public Toolkit(Toolkit toolkit)
        : base(toolkit) { }

    public Toolkit(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Toolkit(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ToolkitFromRaw.FromRawUnchecked"/>
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

class ToolkitFromRaw : IFromRawJson<Toolkit>
{
    /// <inheritdoc/>
    public Toolkit FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Toolkit.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<ToolDefinitionOutput, ToolDefinitionOutputFromRaw>))]
public sealed record class ToolDefinitionOutput : JsonModel
{
    public IReadOnlyList<string>? AvailableModes
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<string>>("available_modes"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "available_modes",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public string? Description
    {
        get { return this._rawData.GetNullableClass<string>("description"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("description", value);
        }
    }

    public ValueSchema? ValueSchema
    {
        get { return this._rawData.GetNullableClass<ValueSchema>("value_schema"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("value_schema", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.AvailableModes;
        _ = this.Description;
        this.ValueSchema?.Validate();
    }

    public ToolDefinitionOutput() { }

    public ToolDefinitionOutput(ToolDefinitionOutput toolDefinitionOutput)
        : base(toolDefinitionOutput) { }

    public ToolDefinitionOutput(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ToolDefinitionOutput(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ToolDefinitionOutputFromRaw.FromRawUnchecked"/>
    public static ToolDefinitionOutput FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ToolDefinitionOutputFromRaw : IFromRawJson<ToolDefinitionOutput>
{
    /// <inheritdoc/>
    public ToolDefinitionOutput FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => ToolDefinitionOutput.FromRawUnchecked(rawData);
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

    public IReadOnlyList<Secret>? Secrets
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<Secret>>("secrets"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<Secret>?>(
                "secrets",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <inheritdoc/>
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

    public Oauth2? Oauth2
    {
        get { return this._rawData.GetNullableClass<Oauth2>("oauth2"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("oauth2", value);
        }
    }

    public string? ProviderID
    {
        get { return this._rawData.GetNullableClass<string>("provider_id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("provider_id", value);
        }
    }

    public string? ProviderType
    {
        get { return this._rawData.GetNullableClass<string>("provider_type"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("provider_type", value);
        }
    }

    public ApiEnum<string, global::ArcadeDotnet.Models.Tools.Status>? Status
    {
        get
        {
            return this._rawData.GetNullableClass<
                ApiEnum<string, global::ArcadeDotnet.Models.Tools.Status>
            >("status");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("status", value);
        }
    }

    public string? StatusReason
    {
        get { return this._rawData.GetNullableClass<string>("status_reason"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("status_reason", value);
        }
    }

    public ApiEnum<string, TokenStatus>? TokenStatus
    {
        get { return this._rawData.GetNullableClass<ApiEnum<string, TokenStatus>>("token_status"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("token_status", value);
        }
    }

    /// <inheritdoc/>
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

[JsonConverter(typeof(JsonModelConverter<Oauth2, Oauth2FromRaw>))]
public sealed record class Oauth2 : JsonModel
{
    public IReadOnlyList<string>? Scopes
    {
        get { return this._rawData.GetNullableStruct<ImmutableArray<string>>("scopes"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "scopes",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Scopes;
    }

    public Oauth2() { }

    public Oauth2(Oauth2 oauth2)
        : base(oauth2) { }

    public Oauth2(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Oauth2(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="Oauth2FromRaw.FromRawUnchecked"/>
    public static Oauth2 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class Oauth2FromRaw : IFromRawJson<Oauth2>
{
    /// <inheritdoc/>
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

[JsonConverter(typeof(JsonModelConverter<Secret, SecretFromRaw>))]
public sealed record class Secret : JsonModel
{
    public required string Key
    {
        get { return this._rawData.GetNotNullClass<string>("key"); }
        init { this._rawData.Set("key", value); }
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

    public string? StatusReason
    {
        get { return this._rawData.GetNullableClass<string>("status_reason"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("status_reason", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Key;
        _ = this.Met;
        _ = this.StatusReason;
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

    [SetsRequiredMembers]
    public Secret(string key)
        : this()
    {
        this.Key = key;
    }
}

class SecretFromRaw : IFromRawJson<Secret>
{
    /// <inheritdoc/>
    public Secret FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Secret.FromRawUnchecked(rawData);
}
