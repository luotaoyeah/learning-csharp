namespace Luotao.Test.Books.CS10NET6._05._08._02;

/// <summary>
/// 5.8.2. understanding records
/// </summary>
public class T01
{
    private readonly ITestOutputHelper testOutputHelper;

    public T01(ITestOutputHelper testOutputHelper)
    {
        this.testOutputHelper = testOutputHelper;
    }

    /// <summary>
    /// record 和 class 的一个区别:
    ///   使用 == 或者 Equals() 比较时, 只要两个 record 的属性值完全一样, 则返回 true.
    /// </summary>
    [Fact]
    public void _01()
    {
        var car01 = new ImmutableVehicle
        {
            Color = "Red",
            Wheels = 4,
        };
        var car02 = new ImmutableVehicle
        {
            Color = "Red",
            Wheels = 4,
        };

        Assert.Equal(car01, car02);
        Assert.True(car01 == car02);
        Assert.True(car01.Equals(car02));
        Assert.False(ReferenceEquals(car01, car02));
    }

    /// <summary>
    /// record 的 ToString() 方法自动被重写, 会打印对象的属性信息.
    /// </summary>
    [Fact]
    public void _02()
    {
        var car01 = new ImmutableVehicle
        {
            Color = "Red",
            Wheels = 4,
        };

        testOutputHelper.WriteLine(car01.ToString());
    }

    [Fact]
    public void _03()
    {
        var car01 = new ImmutableVehicle
        {
            Color = "Red",
            Wheels = 4,
        };

        // 在不修改原对象的基础上, 使用 with 创建一个新对象, 并更改某些属性的值
        var car03 = car01 with { Color = "Blue" };

        Assert.Equal("Blue", car03.Color);
    }
}
