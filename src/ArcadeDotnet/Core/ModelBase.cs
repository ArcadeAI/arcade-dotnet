using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Models;
using ArcadeDotnet.Models.Admin.Secrets;
using AuthProviders = ArcadeDotnet.Models.Admin.AuthProviders;
using Chat = ArcadeDotnet.Models.Chat;
using Completions = ArcadeDotnet.Models.Chat.Completions;
using Tools = ArcadeDotnet.Models.Tools;
using Workers = ArcadeDotnet.Models.Workers;

namespace ArcadeDotnet.Core;

public abstract record class ModelBase
{
    public Dictionary<string, JsonElement> Properties { get; set; } = [];

    internal static readonly JsonSerializerOptions SerializerOptions = new()
    {
        Converters =
        {
            new ApiEnumConverter<string, Status>(),
            new ApiEnumConverter<string, AuthProviders::RequestContentType8>(),
            new ApiEnumConverter<string, AuthProviders::ResponseContentType8>(),
            new ApiEnumConverter<string, AuthProviders::RequestContentType9>(),
            new ApiEnumConverter<string, AuthProviders::ResponseContentType9>(),
            new ApiEnumConverter<string, AuthProviders::ScopeDelimiter1>(),
            new ApiEnumConverter<string, AuthProviders::RequestContentType10>(),
            new ApiEnumConverter<string, AuthProviders::ResponseContentType10>(),
            new ApiEnumConverter<string, AuthProviders::RequestContentType11>(),
            new ApiEnumConverter<string, AuthProviders::ResponseContentType11>(),
            new ApiEnumConverter<string, AuthProviders::RequestContentType12>(),
            new ApiEnumConverter<string, AuthProviders::ResponseContentType12>(),
            new ApiEnumConverter<string, AuthProviders::Type>(),
            new ApiEnumConverter<string, AuthProviders::BindingModel>(),
            new ApiEnumConverter<string, AuthProviders::RequestContentType13>(),
            new ApiEnumConverter<string, AuthProviders::ResponseContentType13>(),
            new ApiEnumConverter<string, AuthProviders::RequestContentType14>(),
            new ApiEnumConverter<string, AuthProviders::ResponseContentType14>(),
            new ApiEnumConverter<string, AuthProviders::ScopeDelimiter2>(),
            new ApiEnumConverter<string, AuthProviders::RequestContentType15>(),
            new ApiEnumConverter<string, AuthProviders::ResponseContentType15>(),
            new ApiEnumConverter<string, AuthProviders::RequestContentType16>(),
            new ApiEnumConverter<string, AuthProviders::ResponseContentType16>(),
            new ApiEnumConverter<string, AuthProviders::RequestContentType>(),
            new ApiEnumConverter<string, AuthProviders::ResponseContentType>(),
            new ApiEnumConverter<string, AuthProviders::RequestContentTypeModel>(),
            new ApiEnumConverter<string, AuthProviders::ResponseContentTypeModel>(),
            new ApiEnumConverter<string, AuthProviders::ScopeDelimiter>(),
            new ApiEnumConverter<string, AuthProviders::RequestContentType1>(),
            new ApiEnumConverter<string, AuthProviders::ResponseContentType1>(),
            new ApiEnumConverter<string, AuthProviders::RequestContentType2>(),
            new ApiEnumConverter<string, AuthProviders::ResponseContentType2>(),
            new ApiEnumConverter<string, AuthProviders::RequestContentType3>(),
            new ApiEnumConverter<string, AuthProviders::ResponseContentType3>(),
            new ApiEnumConverter<string, AuthProviders::RequestContentType4>(),
            new ApiEnumConverter<string, AuthProviders::ResponseContentType4>(),
            new ApiEnumConverter<string, AuthProviders::RequestContentType5>(),
            new ApiEnumConverter<string, AuthProviders::ResponseContentType5>(),
            new ApiEnumConverter<string, AuthProviders::ScopeDelimiterModel>(),
            new ApiEnumConverter<string, AuthProviders::RequestContentType6>(),
            new ApiEnumConverter<string, AuthProviders::ResponseContentType6>(),
            new ApiEnumConverter<string, AuthProviders::RequestContentType7>(),
            new ApiEnumConverter<string, AuthProviders::ResponseContentType7>(),
            new ApiEnumConverter<string, Type>(),
            new ApiEnumConverter<string, Chat::Type>(),
            new ApiEnumConverter<string, Chat::TypeModel>(),
            new ApiEnumConverter<string, Completions::Type>(),
            new ApiEnumConverter<string, Tools::Kind>(),
            new ApiEnumConverter<string, Tools::Status>(),
            new ApiEnumConverter<string, Tools::TokenStatus>(),
            new ApiEnumConverter<string, Tools::KindModel>(),
            new ApiEnumConverter<string, Tools::IncludeFormat>(),
            new ApiEnumConverter<string, Tools::IncludeFormatModel>(),
            new ApiEnumConverter<string, Workers::Type>(),
            new ApiEnumConverter<string, Workers::BindingModel>(),
            new ApiEnumConverter<string, Workers::Binding1>(),
            new ApiEnumConverter<string, Workers::Binding2>(),
            new ApiEnumConverter<string, Workers::TypeModel>(),
        },
    };

    static readonly JsonSerializerOptions _toStringSerializerOptions = new(SerializerOptions)
    {
        WriteIndented = true,
    };

    public sealed override string? ToString()
    {
        return JsonSerializer.Serialize(this.Properties, _toStringSerializerOptions);
    }

    public abstract void Validate();
}

interface IFromRaw<T>
{
    static abstract T FromRawUnchecked(Dictionary<string, JsonElement> properties);
}
