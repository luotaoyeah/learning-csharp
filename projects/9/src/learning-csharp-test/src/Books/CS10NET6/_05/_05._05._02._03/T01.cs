namespace Luotao.Test.Books.CS10NET6._05._05._02._03;

/// <summary>
/// 5.5.2.3. inferring tuple names
/// </summary>
public class T01
{
    [Fact]
    public void _01()
    {
        var thing01 = ("Apples", 5);
        Assert.Equal("Apples", thing01.Item1);
        Assert.Equal(5, thing01.Item2);

        //----------------------------------------------------------------------------------------------------
        // 如果使用另外一个对象的属性来构造一个 tuple, 则可以从这个对象的属性名来推断出 tuple 类型的字段名.
        //----------------------------------------------------------------------------------------------------
        var c01 = new C01 { Name = "Apples", Count = 5 };
        var thing02 = (c01.Name, c01.Count);
        Assert.Equal("Apples", thing02.Name);
        Assert.Equal(5, thing02.Count);

        //----------------------------------------------------------------------------------------------------
        // 此时默认的字段名 Item1/Item2... 依然是可用的.
        //----------------------------------------------------------------------------------------------------
        Assert.Equal("Apples", thing02.Item1);
        Assert.Equal(5, thing02.Item2);
    }
}

public class C01
{
    public int Count;
    public string? Name;
}
