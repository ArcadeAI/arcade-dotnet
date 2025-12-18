using System.Collections.Generic;
using System.Text.Json;
using ArcadeDotnet.Models.Auth;

namespace ArcadeDotnet.Tests.Models.Auth;

public class AuthRequestTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthRequest
        {
            AuthRequirement = new()
            {
                ID = "id",
                Oauth2 = new() { Scopes = ["string"] },
                ProviderID = "provider_id",
                ProviderType = "provider_type",
            },
            UserID = "user_id",
            NextUri = "next_uri",
        };

        AuthRequestAuthRequirement expectedAuthRequirement = new()
        {
            ID = "id",
            Oauth2 = new() { Scopes = ["string"] },
            ProviderID = "provider_id",
            ProviderType = "provider_type",
        };
        string expectedUserID = "user_id";
        string expectedNextUri = "next_uri";

        Assert.Equal(expectedAuthRequirement, model.AuthRequirement);
        Assert.Equal(expectedUserID, model.UserID);
        Assert.Equal(expectedNextUri, model.NextUri);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AuthRequest
        {
            AuthRequirement = new()
            {
                ID = "id",
                Oauth2 = new() { Scopes = ["string"] },
                ProviderID = "provider_id",
                ProviderType = "provider_type",
            },
            UserID = "user_id",
            NextUri = "next_uri",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthRequest>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AuthRequest
        {
            AuthRequirement = new()
            {
                ID = "id",
                Oauth2 = new() { Scopes = ["string"] },
                ProviderID = "provider_id",
                ProviderType = "provider_type",
            },
            UserID = "user_id",
            NextUri = "next_uri",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthRequest>(element);
        Assert.NotNull(deserialized);

        AuthRequestAuthRequirement expectedAuthRequirement = new()
        {
            ID = "id",
            Oauth2 = new() { Scopes = ["string"] },
            ProviderID = "provider_id",
            ProviderType = "provider_type",
        };
        string expectedUserID = "user_id";
        string expectedNextUri = "next_uri";

        Assert.Equal(expectedAuthRequirement, deserialized.AuthRequirement);
        Assert.Equal(expectedUserID, deserialized.UserID);
        Assert.Equal(expectedNextUri, deserialized.NextUri);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AuthRequest
        {
            AuthRequirement = new()
            {
                ID = "id",
                Oauth2 = new() { Scopes = ["string"] },
                ProviderID = "provider_id",
                ProviderType = "provider_type",
            },
            UserID = "user_id",
            NextUri = "next_uri",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthRequest
        {
            AuthRequirement = new()
            {
                ID = "id",
                Oauth2 = new() { Scopes = ["string"] },
                ProviderID = "provider_id",
                ProviderType = "provider_type",
            },
            UserID = "user_id",
        };

        Assert.Null(model.NextUri);
        Assert.False(model.RawData.ContainsKey("next_uri"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AuthRequest
        {
            AuthRequirement = new()
            {
                ID = "id",
                Oauth2 = new() { Scopes = ["string"] },
                ProviderID = "provider_id",
                ProviderType = "provider_type",
            },
            UserID = "user_id",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthRequest
        {
            AuthRequirement = new()
            {
                ID = "id",
                Oauth2 = new() { Scopes = ["string"] },
                ProviderID = "provider_id",
                ProviderType = "provider_type",
            },
            UserID = "user_id",

            // Null should be interpreted as omitted for these properties
            NextUri = null,
        };

        Assert.Null(model.NextUri);
        Assert.False(model.RawData.ContainsKey("next_uri"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new AuthRequest
        {
            AuthRequirement = new()
            {
                ID = "id",
                Oauth2 = new() { Scopes = ["string"] },
                ProviderID = "provider_id",
                ProviderType = "provider_type",
            },
            UserID = "user_id",

            // Null should be interpreted as omitted for these properties
            NextUri = null,
        };

        model.Validate();
    }
}

public class AuthRequestAuthRequirementTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthRequestAuthRequirement
        {
            ID = "id",
            Oauth2 = new() { Scopes = ["string"] },
            ProviderID = "provider_id",
            ProviderType = "provider_type",
        };

        string expectedID = "id";
        AuthRequestAuthRequirementOauth2 expectedOauth2 = new() { Scopes = ["string"] };
        string expectedProviderID = "provider_id";
        string expectedProviderType = "provider_type";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedOauth2, model.Oauth2);
        Assert.Equal(expectedProviderID, model.ProviderID);
        Assert.Equal(expectedProviderType, model.ProviderType);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AuthRequestAuthRequirement
        {
            ID = "id",
            Oauth2 = new() { Scopes = ["string"] },
            ProviderID = "provider_id",
            ProviderType = "provider_type",
        };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthRequestAuthRequirement>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AuthRequestAuthRequirement
        {
            ID = "id",
            Oauth2 = new() { Scopes = ["string"] },
            ProviderID = "provider_id",
            ProviderType = "provider_type",
        };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthRequestAuthRequirement>(element);
        Assert.NotNull(deserialized);

        string expectedID = "id";
        AuthRequestAuthRequirementOauth2 expectedOauth2 = new() { Scopes = ["string"] };
        string expectedProviderID = "provider_id";
        string expectedProviderType = "provider_type";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedOauth2, deserialized.Oauth2);
        Assert.Equal(expectedProviderID, deserialized.ProviderID);
        Assert.Equal(expectedProviderType, deserialized.ProviderType);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AuthRequestAuthRequirement
        {
            ID = "id",
            Oauth2 = new() { Scopes = ["string"] },
            ProviderID = "provider_id",
            ProviderType = "provider_type",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthRequestAuthRequirement { };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Oauth2);
        Assert.False(model.RawData.ContainsKey("oauth2"));
        Assert.Null(model.ProviderID);
        Assert.False(model.RawData.ContainsKey("provider_id"));
        Assert.Null(model.ProviderType);
        Assert.False(model.RawData.ContainsKey("provider_type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AuthRequestAuthRequirement { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthRequestAuthRequirement
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Oauth2 = null,
            ProviderID = null,
            ProviderType = null,
        };

        Assert.Null(model.ID);
        Assert.False(model.RawData.ContainsKey("id"));
        Assert.Null(model.Oauth2);
        Assert.False(model.RawData.ContainsKey("oauth2"));
        Assert.Null(model.ProviderID);
        Assert.False(model.RawData.ContainsKey("provider_id"));
        Assert.Null(model.ProviderType);
        Assert.False(model.RawData.ContainsKey("provider_type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new AuthRequestAuthRequirement
        {
            // Null should be interpreted as omitted for these properties
            ID = null,
            Oauth2 = null,
            ProviderID = null,
            ProviderType = null,
        };

        model.Validate();
    }
}

public class AuthRequestAuthRequirementOauth2Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AuthRequestAuthRequirementOauth2 { Scopes = ["string"] };

        List<string> expectedScopes = ["string"];

        Assert.NotNull(model.Scopes);
        Assert.Equal(expectedScopes.Count, model.Scopes.Count);
        for (int i = 0; i < expectedScopes.Count; i++)
        {
            Assert.Equal(expectedScopes[i], model.Scopes[i]);
        }
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AuthRequestAuthRequirementOauth2 { Scopes = ["string"] };

        string json = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthRequestAuthRequirementOauth2>(json);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AuthRequestAuthRequirementOauth2 { Scopes = ["string"] };

        string element = JsonSerializer.Serialize(model);
        var deserialized = JsonSerializer.Deserialize<AuthRequestAuthRequirementOauth2>(element);
        Assert.NotNull(deserialized);

        List<string> expectedScopes = ["string"];

        Assert.NotNull(deserialized.Scopes);
        Assert.Equal(expectedScopes.Count, deserialized.Scopes.Count);
        for (int i = 0; i < expectedScopes.Count; i++)
        {
            Assert.Equal(expectedScopes[i], deserialized.Scopes[i]);
        }
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AuthRequestAuthRequirementOauth2 { Scopes = ["string"] };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AuthRequestAuthRequirementOauth2 { };

        Assert.Null(model.Scopes);
        Assert.False(model.RawData.ContainsKey("scopes"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AuthRequestAuthRequirementOauth2 { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AuthRequestAuthRequirementOauth2
        {
            // Null should be interpreted as omitted for these properties
            Scopes = null,
        };

        Assert.Null(model.Scopes);
        Assert.False(model.RawData.ContainsKey("scopes"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new AuthRequestAuthRequirementOauth2
        {
            // Null should be interpreted as omitted for these properties
            Scopes = null,
        };

        model.Validate();
    }
}
