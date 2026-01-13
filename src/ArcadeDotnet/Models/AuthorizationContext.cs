using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models;

[JsonConverter(typeof(JsonModelConverter<AuthorizationContext, AuthorizationContextFromRaw>))]
public sealed record class AuthorizationContext : JsonModel
{
    public string? Token
    {
        get { return this._rawData.GetNullableClass<string>("token"); }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("token", value);
        }
    }

    public IReadOnlyDictionary<string, JsonElement>? UserInfo
    {
        get
        {
            return this._rawData.GetNullableClass<FrozenDictionary<string, JsonElement>>(
                "user_info"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<FrozenDictionary<string, JsonElement>?>(
                "user_info",
                value == null ? null : FrozenDictionary.ToFrozenDictionary(value)
            );
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Token;
        _ = this.UserInfo;
    }

    public AuthorizationContext() { }

    public AuthorizationContext(AuthorizationContext authorizationContext)
        : base(authorizationContext) { }

    public AuthorizationContext(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthorizationContext(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AuthorizationContextFromRaw.FromRawUnchecked"/>
    public static AuthorizationContext FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AuthorizationContextFromRaw : IFromRawJson<AuthorizationContext>
{
    /// <inheritdoc/>
    public AuthorizationContext FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthorizationContext.FromRawUnchecked(rawData);
}
