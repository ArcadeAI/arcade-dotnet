using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;

namespace ArcadeDotnet.Models;

[JsonConverter(typeof(ModelConverter<AuthorizationContext, AuthorizationContextFromRaw>))]
public sealed record class AuthorizationContext : ModelBase
{
    public string? Token
    {
        get { return ModelBase.GetNullableClass<string>(this.RawData, "token"); }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "token", value);
        }
    }

    public IReadOnlyDictionary<string, JsonElement>? UserInfo
    {
        get
        {
            return ModelBase.GetNullableClass<Dictionary<string, JsonElement>>(
                this.RawData,
                "user_info"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            ModelBase.Set(this._rawData, "user_info", value);
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
        this._rawData = [.. rawData];
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AuthorizationContext(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = [.. rawData];
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

class AuthorizationContextFromRaw : IFromRaw<AuthorizationContext>
{
    /// <inheritdoc/>
    public AuthorizationContext FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AuthorizationContext.FromRawUnchecked(rawData);
}
