using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models;

[JsonConverter(typeof(JsonModelConverter<Error, ErrorFromRaw>))]
public sealed record class Error : JsonModel
{
    /// <summary>
    /// FieldErrors carries machine-actionable, per-field detail for a request-body
    /// validation failure so a client can map each failure to a specific input field.
    /// It is empty (and omitted) for every other error, keeping Message the single
    /// source of truth for those.
    /// </summary>
    public IReadOnlyList<FieldError>? FieldErrors
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<FieldError>>("field_errors");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<FieldError>?>(
                "field_errors",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public string? Message
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("message");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("message", value);
        }
    }

    public string? Name
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("name");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("name", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        foreach (var item in this.FieldErrors ?? [])
        {
            item.Validate();
        }
        _ = this.Message;
        _ = this.Name;
    }

    public Error() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Error(Error error)
        : base(error) { }
#pragma warning restore CS8618

    public Error(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Error(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ErrorFromRaw.FromRawUnchecked"/>
    public static Error FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ErrorFromRaw : IFromRawJson<Error>
{
    /// <inheritdoc/>
    public Error FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Error.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<FieldError, FieldErrorFromRaw>))]
public sealed record class FieldError : JsonModel
{
    /// <summary>
    /// Field is the json field path of the offending value, rooted at the request
    /// body with inline-embed levels flattened (e.g. "oauth2.token_request.endpoint").
    /// </summary>
    public string? Field
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("field");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("field", value);
        }
    }

    /// <summary>
    /// Message is the human-readable, per-field explanation.
    /// </summary>
    public string? Message
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("message");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("message", value);
        }
    }

    /// <summary>
    /// Param is the rule's parameter when it has one (e.g. "500" for max), omitted otherwise.
    /// </summary>
    public string? Param
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("param");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("param", value);
        }
    }

    /// <summary>
    /// Rule is the validation rule that failed (e.g. "required", "max", "url").
    /// </summary>
    public string? Rule
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("rule");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("rule", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Field;
        _ = this.Message;
        _ = this.Param;
        _ = this.Rule;
    }

    public FieldError() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public FieldError(FieldError fieldError)
        : base(fieldError) { }
#pragma warning restore CS8618

    public FieldError(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    FieldError(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="FieldErrorFromRaw.FromRawUnchecked"/>
    public static FieldError FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class FieldErrorFromRaw : IFromRawJson<FieldError>
{
    /// <inheritdoc/>
    public FieldError FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        FieldError.FromRawUnchecked(rawData);
}
