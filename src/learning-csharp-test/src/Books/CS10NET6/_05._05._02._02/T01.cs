namespace Luotao.Test.Books.CS10NET6._05._05._02._02;

/// <summary>
/// 5.5.2.2. naming the fields of a tuple
/// </summary>
public class T01
{
    [Fact]
    public void _01()
    {
        (string Name, int Number) fruit = C01.GetFruit();
        Assert.Equal("Apples", fruit.Name);
        Assert.Equal(5, fruit.Number);

        //----------------------------------------------------------------------------------------------------
        // 此时默认的字段名 Item1/Item2... 依然是可用的.
        //----------------------------------------------------------------------------------------------------
        Assert.Equal("Apples", fruit.Item1);
        Assert.Equal(5, fruit.Item2);
    }
}

public class C01
{
    /// <summary>
    /// 可以指定 tuple 类型的字段名, 而不是用默认的 Item1/Item2/...
    /// </summary>
    /// <returns></returns>
    public static (string Name, int Number) GetFruit()
    {
        return (Name: "Apples", Number: 5);
    }
}
