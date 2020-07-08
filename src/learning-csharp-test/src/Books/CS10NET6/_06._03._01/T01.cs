namespace Luotao.Test.Books.CS10NET6._06._03._01;

/// <summary>
/// 6.3.1. calling methods using delegates
/// </summary>
public class T01
{
    private readonly ITestOutputHelper testOutputHelper;

    public T01(ITestOutputHelper testOutputHelper)
    {
        this.testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void _01()
    {
        int F01(int x, int y)
        {
            testOutputHelper.WriteLine("F01");
            return x + y;
        }

        int F02(int x, int y)
        {
            testOutputHelper.WriteLine("F02");
            return x * y;
        }

        // 创建一个该委托类型的实例对象, 并且绑定一个方法

        // Delegate01? delegate01 = new Delegate01(F01);
        // Delegate01? delegate01 = new (F01);
        Delegate01? delegate01 = F01;

        // 使用 += 添加一个方法
        delegate01 += F02;

        // delegate 执行之后的返回值, 是它 invocation list 中最后一个方法的返回值
        int result = delegate01(3, 4);
        Assert.Equal(12, result);

        // 使用 -= 移除一个方法
        delegate01 -= F02;

        // 可以像执行一个方法一样执行 delegate,
        // 也可以调用 Invoke() 方法来执行 delegate
        Assert.Equal(7, delegate01?.Invoke(3, 4));

        // 当 delegate 中的所有方法都被移除之后, 该 delegate 就等于 null
        delegate01 -= F01;
        Assert.Null(delegate01);
    }
}
