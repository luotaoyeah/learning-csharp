namespace Luotao.Test.Books.CS10NET6._05._05._06;

/// <summary>
/// 5.5.6. controlling how parameters are passed
/// </summary>
public class T01
{
    [Fact]
    public void _01()
    {
        var x = 6;
        var y = 6;
        var z = 6;

        Assert.Equal(6, x);
        Assert.Equal(6, y);
        Assert.Equal(6, z);

        // 调用方法时, 也需要声明 ref/out 关键字
        C01.F01(x, ref y, out z);

        Assert.Equal(6, x);
        Assert.Equal(9, y);
        Assert.Equal(9, z);
    }
}

public class C01
{
    /// <summary>
    /// 三种传参方式:
    ///   1. by value (传的是 value/reference 的复制)
    ///   2. by reference (相当于传的是变量的别名)
    ///   3. out parameter (out 也是 by reference)
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    public static void F01(int a, ref int b, out int c)
    {
        a = 9;
        b = 9;
        c = 9;
    }
}
