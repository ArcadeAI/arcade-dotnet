using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Exceptions;
using ArcadeDotnet.Models;
using ArcadeDotnet.Models.Admin.AuthProviders;
using Chat = ArcadeDotnet.Models.Chat;
using Completions = ArcadeDotnet.Models.Chat.Completions;
using Secrets = ArcadeDotnet.Models.Admin.Secrets;
using Tools = ArcadeDotnet.Models.Tools;
using Workers = ArcadeDotnet.Models.Workers;

namespace ArcadeDotnet.Core;

/// <summary>
/// The base class for all API objects with properties.
///
/// <para>API objects such as enums and unions do not inherit from this class.</para>
/// </summary>
public abstract record class ModelBase
{
    private protected FreezableDictionary<string, JsonElement> _rawData = [];

    protected ModelBase(ModelBase modelBase)
    {
        this._rawData = [.. modelBase._rawData];
    }

    /// <summary>
    /// The backing JSON properties of the instance.
    /// </summary>
    public IReadOnlyDictionary<string, JsonElement> RawData
    {
        get { return this._rawData.Freeze(); }
    }

    internal static readonly JsonSerializerOptions SerializerOptions = new()
    {
        Converters =
        {
            new ApiEnumConverter<string, Status>(),
            new ApiEnumConverter<
                string,
                AuthProviderCreateRequestOauth2AuthorizeRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderCreateRequestOauth2AuthorizeRequestResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderCreateRequestOauth2RefreshRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderCreateRequestOauth2RefreshRequestResponseContentType
            >(),
            new ApiEnumConverter<string, AuthProviderCreateRequestOauth2ScopeDelimiter>(),
            new ApiEnumConverter<
                string,
                AuthProviderCreateRequestOauth2TokenIntrospectionRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderCreateRequestOauth2TokenIntrospectionRequestResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderCreateRequestOauth2TokenRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderCreateRequestOauth2TokenRequestResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderCreateRequestOauth2UserInfoRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderCreateRequestOauth2UserInfoRequestResponseContentType
            >(),
            new ApiEnumConverter<string, Type>(),
            new ApiEnumConverter<string, ClientSecretBinding>(),
            new ApiEnumConverter<
                string,
                AuthProviderUpdateRequestOauth2AuthorizeRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderUpdateRequestOauth2AuthorizeRequestResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderUpdateRequestOauth2RefreshRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderUpdateRequestOauth2RefreshRequestResponseContentType
            >(),
            new ApiEnumConverter<string, AuthProviderUpdateRequestOauth2ScopeDelimiter>(),
            new ApiEnumConverter<
                string,
                AuthProviderUpdateRequestOauth2TokenRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderUpdateRequestOauth2TokenRequestResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderUpdateRequestOauth2UserInfoRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderUpdateRequestOauth2UserInfoRequestResponseContentType
            >(),
            new ApiEnumConverter<string, RequestContentType>(),
            new ApiEnumConverter<string, ResponseContentType>(),
            new ApiEnumConverter<string, RefreshRequestRequestContentType>(),
            new ApiEnumConverter<string, RefreshRequestResponseContentType>(),
            new ApiEnumConverter<string, ScopeDelimiter>(),
            new ApiEnumConverter<string, TokenIntrospectionRequestRequestContentType>(),
            new ApiEnumConverter<string, TokenIntrospectionRequestResponseContentType>(),
            new ApiEnumConverter<string, TokenRequestRequestContentType>(),
            new ApiEnumConverter<string, TokenRequestResponseContentType>(),
            new ApiEnumConverter<string, UserInfoRequestRequestContentType>(),
            new ApiEnumConverter<string, UserInfoRequestResponseContentType>(),
            new ApiEnumConverter<
                string,
                AuthProviderPatchParamsOauth2AuthorizeRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderPatchParamsOauth2AuthorizeRequestResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderPatchParamsOauth2RefreshRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderPatchParamsOauth2RefreshRequestResponseContentType
            >(),
            new ApiEnumConverter<string, AuthProviderPatchParamsOauth2ScopeDelimiter>(),
            new ApiEnumConverter<
                string,
                AuthProviderPatchParamsOauth2TokenRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderPatchParamsOauth2TokenRequestResponseContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderPatchParamsOauth2UserInfoRequestRequestContentType
            >(),
            new ApiEnumConverter<
                string,
                AuthProviderPatchParamsOauth2UserInfoRequestResponseContentType
            >(),
            new ApiEnumConverter<string, Secrets::Type>(),
            new ApiEnumConverter<string, Chat::Type>(),
            new ApiEnumConverter<string, Chat::ResponseFormatType>(),
            new ApiEnumConverter<string, Completions::Type>(),
            new ApiEnumConverter<string, Tools::Kind>(),
            new ApiEnumConverter<string, Tools::Status>(),
            new ApiEnumConverter<string, Tools::TokenStatus>(),
            new ApiEnumConverter<string, Tools::ToolExecutionAttemptOutputErrorKind>(),
            new ApiEnumConverter<string, Tools::IncludeFormat>(),
            new ApiEnumConverter<string, Tools::ToolGetParamsIncludeFormat>(),
            new ApiEnumConverter<string, Workers::Type>(),
            new ApiEnumConverter<string, Workers::SecretBinding>(),
            new ApiEnumConverter<string, Workers::ClientSecretBinding>(),
            new ApiEnumConverter<string, Workers::SecretsItemBinding>(),
            new ApiEnumConverter<string, Workers::WorkerResponseType>(),
        },
    };

    static readonly JsonSerializerOptions _toStringSerializerOptions = new(SerializerOptions)
    {
        WriteIndented = true,
    };

    internal static void Set<T>(IDictionary<string, JsonElement> dictionary, string key, T value)
    {
        dictionary[key] = JsonSerializer.SerializeToElement(value, SerializerOptions);
    }

    internal static T GetNotNullClass<T>(
        IReadOnlyDictionary<string, JsonElement> dictionary,
        string key
    )
        where T : class
    {
        if (!dictionary.TryGetValue(key, out JsonElement element))
        {
            throw new ArcadeInvalidDataException($"'{key}' cannot be absent");
        }

        try
        {
            return JsonSerializer.Deserialize<T>(element, SerializerOptions)
                ?? throw new ArcadeInvalidDataException($"'{key}' cannot be null");
        }
        catch (JsonException e)
        {
            throw new ArcadeInvalidDataException(
                $"'{key}' must be of type {typeof(T).FullName}",
                e
            );
        }
    }

    internal static T GetNotNullStruct<T>(
        IReadOnlyDictionary<string, JsonElement> dictionary,
        string key
    )
        where T : struct
    {
        if (!dictionary.TryGetValue(key, out JsonElement element))
        {
            throw new ArcadeInvalidDataException($"'{key}' cannot be absent");
        }

        try
        {
            return JsonSerializer.Deserialize<T?>(element, SerializerOptions)
                ?? throw new ArcadeInvalidDataException($"'{key}' cannot be null");
        }
        catch (JsonException e)
        {
            throw new ArcadeInvalidDataException(
                $"'{key}' must be of type {typeof(T).FullName}",
                e
            );
        }
    }

    internal static T? GetNullableClass<T>(
        IReadOnlyDictionary<string, JsonElement> dictionary,
        string key
    )
        where T : class
    {
        if (!dictionary.TryGetValue(key, out JsonElement element))
        {
            return null;
        }

        try
        {
            return JsonSerializer.Deserialize<T?>(element, SerializerOptions);
        }
        catch (JsonException e)
        {
            throw new ArcadeInvalidDataException(
                $"'{key}' must be of type {typeof(T).FullName}",
                e
            );
        }
    }

    internal static T? GetNullableStruct<T>(
        IReadOnlyDictionary<string, JsonElement> dictionary,
        string key
    )
        where T : struct
    {
        if (!dictionary.TryGetValue(key, out JsonElement element))
        {
            return null;
        }

        try
        {
            return JsonSerializer.Deserialize<T?>(element, SerializerOptions);
        }
        catch (JsonException e)
        {
            throw new ArcadeInvalidDataException(
                $"'{key}' must be of type {typeof(T).FullName}",
                e
            );
        }
    }

    public sealed override string? ToString()
    {
        return JsonSerializer.Serialize(this.RawData, _toStringSerializerOptions);
    }

    public virtual bool Equals(ModelBase? other)
    {
        if (other == null || this.RawData.Count != other.RawData.Count)
        {
            return false;
        }

        foreach (var item in this.RawData)
        {
            if (!other.RawData.TryGetValue(item.Key, out var otherValue))
            {
                return false;
            }

            if (!JsonElement.DeepEquals(item.Value, otherValue))
            {
                return false;
            }
        }

        return true;
    }

    public override int GetHashCode()
    {
        return 0;
    }

    /// <summary>
    /// Validates that all required fields are set and that each field's value is of the expected type.
    ///
    /// <para>This is useful for instances constructed from raw JSON data (e.g. deserialized from an API response).</para>
    ///
    /// <exception cref="ArcadeInvalidDataException">
    /// Thrown when the instance does not pass validation.
    /// </exception>
    /// </summary>
    public abstract void Validate();
}

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
///
/// <para>NOTE: This interface is in the style of a factory instance instead of using
/// abstract static methods because .NET Standard 2.0 doesn't support abstract static methods.</para>
/// </summary>
interface IFromRaw<T>
{
    /// <summary>
    /// Returns an instance constructed from the given raw JSON properties.
    ///
    /// <para>Required field and type mismatches are not checked. In these cases accessing
    /// the relevant properties of the constructed instance may throw.</para>
    ///
    /// <para>This method is useful for constructing an instance from already serialized
    /// data or for sending arbitrary data to the API (e.g. for undocumented or not
    /// yet supported properties or values).</para>
    /// </summary>
    T FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData);
}
