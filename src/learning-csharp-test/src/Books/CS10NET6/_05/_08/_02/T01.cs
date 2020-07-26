namespace Luotao.Test.Books.CS10NET6._05._08._02;

/// <summary>
/// 5.8.2. understanding records
/// </summary>
public class T01
{
    [Fact]
    public void _01()
    {
        var car01 = new ImmutableVehicle
        {
            Color = "Red",
            Wheels = 4,
        };

        // 在不修改原对象的基础上, 使用 with 创建一个新的对象, 并更改某些属性的值
        var car02 = car01 with { Color = "Blue" };
        Assert.Equal("Blue", car02.Color);
    }
}
