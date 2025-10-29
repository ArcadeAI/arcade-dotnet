using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ArcadeDotnet.Core;
using ArcadeDotnet.Exceptions;
using ArcadeDotnet.Models.Tools.ExecuteToolResponseProperties.OutputProperties.ErrorProperties;

namespace ArcadeDotnet.Models.Tools.ExecuteToolResponseProperties.OutputProperties;

[JsonConverter(typeof(ModelConverter<Error>))]
public sealed record class Error : ModelBase, IFromRaw<Error>
{
    public required bool CanRetry
    {
        get
        {
            if (!this.Properties.TryGetValue("can_retry", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'can_retry' cannot be null",
                    new ArgumentOutOfRangeException("can_retry", "Missing required argument")
                );

            return JsonSerializer.Deserialize<bool>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["can_retry"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required ApiEnum<string, Kind> Kind
    {
        get
        {
            if (!this.Properties.TryGetValue("kind", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'kind' cannot be null",
                    new ArgumentOutOfRangeException("kind", "Missing required argument")
                );

            return JsonSerializer.Deserialize<ApiEnum<string, Kind>>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["kind"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public required string Message
    {
        get
        {
            if (!this.Properties.TryGetValue("message", out JsonElement element))
                throw new ArcadeInvalidDataException(
                    "'message' cannot be null",
                    new ArgumentOutOfRangeException("message", "Missing required argument")
                );

            return JsonSerializer.Deserialize<string>(element, ModelBase.SerializerOptions)
                ?? throw new ArcadeInvalidDataException(
                    "'message' cannot be null",
                    new ArgumentNullException("message")
                );
        }
        set
        {
            this.Properties["message"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? AdditionalPromptContent
    {
        get
        {
            if (!this.Properties.TryGetValue("additional_prompt_content", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["additional_prompt_content"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? DeveloperMessage
    {
        get
        {
            if (!this.Properties.TryGetValue("developer_message", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["developer_message"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public Dictionary<string, JsonElement>? Extra
    {
        get
        {
            if (!this.Properties.TryGetValue("extra", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<Dictionary<string, JsonElement>?>(
                element,
                ModelBase.SerializerOptions
            );
        }
        set
        {
            this.Properties["extra"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public long? RetryAfterMs
    {
        get
        {
            if (!this.Properties.TryGetValue("retry_after_ms", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["retry_after_ms"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string? Stacktrace
    {
        get
        {
            if (!this.Properties.TryGetValue("stacktrace", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<string?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["stacktrace"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public long? StatusCode
    {
        get
        {
            if (!this.Properties.TryGetValue("status_code", out JsonElement element))
                return null;

            return JsonSerializer.Deserialize<long?>(element, ModelBase.SerializerOptions);
        }
        set
        {
            this.Properties["status_code"] = JsonSerializer.SerializeToElement(
                value,
                ModelBase.SerializerOptions
            );
        }
    }

    public override void Validate()
    {
        _ = this.CanRetry;
        this.Kind.Validate();
        _ = this.Message;
        _ = this.AdditionalPromptContent;
        _ = this.DeveloperMessage;
        if (this.Extra != null)
        {
            foreach (var item in this.Extra.Values)
            {
                _ = item;
            }
        }
        _ = this.RetryAfterMs;
        _ = this.Stacktrace;
        _ = this.StatusCode;
    }

    public Error() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Error(Dictionary<string, JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static Error FromRawUnchecked(Dictionary<string, JsonElement> properties)
    {
        return new(properties);
    }
}
