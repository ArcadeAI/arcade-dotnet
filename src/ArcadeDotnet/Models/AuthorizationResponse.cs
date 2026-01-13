using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;

namespace ArcadeDotnet.Models;

[JsonConverter(typeof(JsonModelConverter<AuthorizationResponse, AuthorizationResponseFromRaw>))]
public sealed record class AuthorizationResponse : JsonModel
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

    public AuthorizationContext? Context
    {
        get { return this._rawData.GetNullableClass<AuthorizationContext>("context"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("context", value);
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

    public ApiEnum<string, Status>? Status
    {
        get { return this._rawData.GetNullableClass<ApiEnum<string, Status>>("status"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("status", value);
        }
    }

    public string? Url
    {
        get { return this._rawData.GetNullableClass<string>("url"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("url", value);
        }
    }

    public string? UserID
    {
        get { return this._rawData.GetNullableClass<string>("user_id"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("user_id", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        this.Context?.Validate();
        _ = this.ProviderID;
        _ = this.Scopes;
        this.Status?.Validate();
        _ = this.Url;
        _ = this.UserID;
    }

    public AuthorizationResponse() { }

    public AuthorizationResponse(AuthorizationResponse authorizationResponse)
        : base(authorizationResponse) { }

    public AuthorizationResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthorizationResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthorizationResponseFromRaw.FromRawUnchecked"/>
    public static AuthorizationResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthorizationResponseFromRaw : IFromRawJson<AuthorizationResponse>
{
    /// <inheritdoc/>
    public AuthorizationResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthorizationResponse.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(StatusConverter))]
public enum Status
{
    NotStarted,
    Pending,
    Completed,
    Failed,
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
            "not_started" => Status.NotStarted,
            "pending" => Status.Pending,
            "completed" => Status.Completed,
            "failed" => Status.Failed,
            _ => (Status)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, Status value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Status.NotStarted => "not_started",
                Status.Pending => "pending",
                Status.Completed => "completed",
                Status.Failed => "failed",
                _ => throw new ArcadeInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
