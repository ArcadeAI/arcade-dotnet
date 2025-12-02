using System.Collections.Generic;
using ArcadeDotnet.Models.Tools;

namespace ArcadeDotnet.Tests.Models.Tools;

public class ValueSchemaTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ValueSchema
        {
            ValType = "val_type",
            Enum = ["string"],
            InnerValType = "inner_val_type",
        };

        string expectedValType = "val_type";
        List<string> expectedEnum = ["string"];
        string expectedInnerValType = "inner_val_type";

        Assert.Equal(expectedValType, model.ValType);
        Assert.Equal(expectedEnum.Count, model.Enum.Count);
        for (int i = 0; i < expectedEnum.Count; i++)
        {
            Assert.Equal(expectedEnum[i], model.Enum[i]);
        }
        Assert.Equal(expectedInnerValType, model.InnerValType);
    }
}
