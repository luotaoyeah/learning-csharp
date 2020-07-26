using Luotao.Lib.Books.CS10NET6._05;

namespace Luotao.Test.Books.CS10NET6._05._05._02;

/// <summary>
/// 5.5.2. combining multiple returned values using tuples
/// </summary>
public class T01
{
    private readonly ITestOutputHelper testOutputHelper;

    public T01(ITestOutputHelper testOutputHelper)
    {
        this.testOutputHelper = testOutputHelper;
    }

    /// <summary>
    /// 使用 Item1, Item2, ... 访问 tuple 的各个元素.
    /// </summary>
    [Fact]
    public void _01()
    {
        (string, int) fruit = new Person().GetFruit();
        Assert.Equal("Apples", fruit.Item1);
        Assert.Equal(5, fruit.Item2);
    }
}
