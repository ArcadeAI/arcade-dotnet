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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("fully_qualified_name");
        }
        init { this._rawData.Set("fully_qualified_name", value); }
    }

    public required Input Input
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<Input>("input");
        }
        init { this._rawData.Set("input", value); }
    }

    public required string Name
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("name");
        }
        init { this._rawData.Set("name", value); }
    }

    public required string QualifiedName
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("qualified_name");
        }
        init { this._rawData.Set("qualified_name", value); }
    }

    public required Toolkit Toolkit
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<Toolkit>("toolkit");
        }
        init { this._rawData.Set("toolkit", value); }
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

    public IReadOnlyDictionary<string, JsonElement>? FormattedSchema
    {
        get
        {
            this._rawData.Freeze();
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

    /// <summary>
    /// IndexState reports whether this tool is available through tool search yet
    /// ("indexed" or "pending"). Populated only when tool search is active for the
    /// org and Condex is reachable; otherwise omitted, so existing callers are unaffected.
    /// The handler derives and injects this value — see the tool-listing enrichment path.
    /// </summary>
    public string? IndexState
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("index_state");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("index_state", value);
        }
    }

    /// <summary>
    /// LastIndexedAt is the tool's last successful index-write time, set only when
    /// IndexState is "indexed" and Condex reported a timestamp.
    /// </summary>
    public string? LastIndexedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("last_indexed_at");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("last_indexed_at", value);
        }
    }

    public Metadata? Metadata
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<Metadata>("metadata");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("metadata", value);
        }
    }

    public ToolDefinitionOutput? Output
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ToolDefinitionOutput>("output");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<Requirements>("requirements");
        }
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
        _ = this.IndexState;
        _ = this.LastIndexedAt;
        this.Metadata?.Validate();
        this.Output?.Validate();
        this.Requirements?.Validate();
    }

    public ToolDefinition() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public ToolDefinition(ToolDefinition toolDefinition)
        : base(toolDefinition) { }
#pragma warning restore CS8618

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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<Parameter>>("parameters");
        }
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

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Input(Input input)
        : base(input) { }
#pragma warning restore CS8618

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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("name");
        }
        init { this._rawData.Set("name", value); }
    }

    public required ValueSchema ValueSchema
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ValueSchema>("value_schema");
        }
        init { this._rawData.Set("value_schema", value); }
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

    public bool? Inferrable
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("inferrable");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("required");
        }
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

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Parameter(Parameter parameter)
        : base(parameter) { }
#pragma warning restore CS8618

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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("name");
        }
        init { this._rawData.Set("name", value); }
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

    public string? Version
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("version");
        }
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

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Toolkit(Toolkit toolkit)
        : base(toolkit) { }
#pragma warning restore CS8618

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

[JsonConverter(typeof(JsonModelConverter<Metadata, MetadataFromRaw>))]
public sealed record class Metadata : JsonModel
{
    public Behavior? Behavior
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<Behavior>("behavior");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("behavior", value);
        }
    }

    public Classification? Classification
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<Classification>("classification");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("classification", value);
        }
    }

    public IReadOnlyDictionary<string, JsonElement>? Extras
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<FrozenDictionary<string, JsonElement>>("extras");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<FrozenDictionary<string, JsonElement>?>(
                "extras",
                value == null ? null : FrozenDictionary.ToFrozenDictionary(value)
            );
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        this.Behavior?.Validate();
        this.Classification?.Validate();
        _ = this.Extras;
    }

    public Metadata() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Metadata(Metadata metadata)
        : base(metadata) { }
#pragma warning restore CS8618

    public Metadata(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Metadata(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="MetadataFromRaw.FromRawUnchecked"/>
    public static Metadata FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class MetadataFromRaw : IFromRawJson<Metadata>
{
    /// <inheritdoc/>
    public Metadata FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Metadata.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Behavior, BehaviorFromRaw>))]
public sealed record class Behavior : JsonModel
{
    public bool? Destructive
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("destructive");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("destructive", value);
        }
    }

    public bool? Idempotent
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("idempotent");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("idempotent", value);
        }
    }

    public bool? OpenWorld
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("open_world");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("open_world", value);
        }
    }

    public IReadOnlyList<string>? Operations
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>("operations");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "operations",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public bool? ReadOnly
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("read_only");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("read_only", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Destructive;
        _ = this.Idempotent;
        _ = this.OpenWorld;
        _ = this.Operations;
        _ = this.ReadOnly;
    }

    public Behavior() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Behavior(Behavior behavior)
        : base(behavior) { }
#pragma warning restore CS8618

    public Behavior(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Behavior(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="BehaviorFromRaw.FromRawUnchecked"/>
    public static Behavior FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class BehaviorFromRaw : IFromRawJson<Behavior>
{
    /// <inheritdoc/>
    public Behavior FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Behavior.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Classification, ClassificationFromRaw>))]
public sealed record class Classification : JsonModel
{
    public IReadOnlyList<string>? ServiceDomains
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>("service_domains");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<string>?>(
                "service_domains",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ServiceDomains;
    }

    public Classification() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Classification(Classification classification)
        : base(classification) { }
#pragma warning restore CS8618

    public Classification(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Classification(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ClassificationFromRaw.FromRawUnchecked"/>
    public static Classification FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ClassificationFromRaw : IFromRawJson<Classification>
{
    /// <inheritdoc/>
    public Classification FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Classification.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<ToolDefinitionOutput, ToolDefinitionOutputFromRaw>))]
public sealed record class ToolDefinitionOutput : JsonModel
{
    public IReadOnlyList<string>? AvailableModes
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>("available_modes");
        }
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

    public ValueSchema? ValueSchema
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ValueSchema>("value_schema");
        }
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

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public ToolDefinitionOutput(ToolDefinitionOutput toolDefinitionOutput)
        : base(toolDefinitionOutput) { }
#pragma warning restore CS8618

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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<Authorization>("authorization");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("met");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<Secret>>("secrets");
        }
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

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Requirements(Requirements requirements)
        : base(requirements) { }
#pragma warning restore CS8618

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

    public Oauth2? Oauth2
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<Oauth2>("oauth2");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("provider_id");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("provider_type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("provider_type", value);
        }
    }

    public ApiEnum<string, Status>? Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ApiEnum<string, Status>>("status");
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("status_reason");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ApiEnum<string, TokenStatus>>("token_status");
        }
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

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Authorization(Authorization authorization)
        : base(authorization) { }
#pragma warning restore CS8618

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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>("scopes");
        }
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

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Oauth2(Oauth2 oauth2)
        : base(oauth2) { }
#pragma warning restore CS8618

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

[JsonConverter(typeof(StatusConverter))]
public enum Status
{
    Active,
    Inactive,
}

sealed class StatusConverter : JsonConverter<Status>
{
    public override Status Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "active" => Status.Active,
            "inactive" => Status.Inactive,
            _ => (Status)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, Status value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Status.Active => "active",
                Status.Inactive => "inactive",
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("key");
        }
        init { this._rawData.Set("key", value); }
    }

    public bool? Met
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("met");
        }
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
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("status_reason");
        }
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

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Secret(Secret secret)
        : base(secret) { }
#pragma warning restore CS8618

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
