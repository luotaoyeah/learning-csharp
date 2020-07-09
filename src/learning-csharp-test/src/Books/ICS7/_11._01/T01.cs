namespace Luotao.Test.Books.ICS7._11._01;

/// <summary>
/// 11.1. what are structs?
/// </summary>
public class T01
{
    /// <summary>
    /// struct 和 class 的区别:
    ///   1. struct 是 value type, class 是 reference type
    ///   2. struct 是 sealed, 不能被继承
    /// </summary>
    [Fact]
    public void _01()
    {
        Point point01;
        point01.X = 10;
        point01.Y = 10;

        Assert.Equal(10, point01.X);
        Assert.Equal(10, point01.Y);

        Point point02 = new Point { X = 10, Y = 10 };
        Assert.Equal(10, point02.X);
        Assert.Equal(10, point02.Y);
    }
}
