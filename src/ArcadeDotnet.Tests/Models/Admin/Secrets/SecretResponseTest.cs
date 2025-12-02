using ArcadeDotnet.Core;
using ArcadeDotnet.Models.Admin.Secrets;

namespace ArcadeDotnet.Tests.Models.Admin.Secrets;

public class SecretResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new SecretResponse
        {
            ID = "id",
            Binding = new() { ID = "id", Type = Type.Static },
            CreatedAt = "created_at",
            Description = "description",
            Hint = "hint",
            Key = "key",
            LastAccessedAt = "last_accessed_at",
            UpdatedAt = "updated_at",
        };

        string expectedID = "id";
        Binding expectedBinding = new() { ID = "id", Type = Type.Static };
        string expectedCreatedAt = "created_at";
        string expectedDescription = "description";
        string expectedHint = "hint";
        string expectedKey = "key";
        string expectedLastAccessedAt = "last_accessed_at";
        string expectedUpdatedAt = "updated_at";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedBinding, model.Binding);
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedHint, model.Hint);
        Assert.Equal(expectedKey, model.Key);
        Assert.Equal(expectedLastAccessedAt, model.LastAccessedAt);
        Assert.Equal(expectedUpdatedAt, model.UpdatedAt);
    }
}

public class BindingTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Binding { ID = "id", Type = Type.Static };

        string expectedID = "id";
        ApiEnum<string, Type> expectedType = Type.Static;

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedType, model.Type);
    }
}
