namespace Luotao.Test.Books.CS10NET6._05._05._02._04;

/// <summary>
/// 5.5.2.4. deconstructing tuples
/// </summary>
public class T01
{
    [Fact]
    public void _01()
    {
        //----------------------------------------------------------------------------------------------------
        // 没有解构, 通过 Item1/Item2... 访问字段.
        //----------------------------------------------------------------------------------------------------
        var person01 = C01.GetPerson();
        Assert.Equal("luotao", person01.Item1);
        Assert.Equal(18, person01.Item2);

        //----------------------------------------------------------------------------------------------------
        // 没有解构, 显式指定 tuple 的类型.
        //----------------------------------------------------------------------------------------------------
        (string, int) person02 = C01.GetPerson();
        Assert.Equal("luotao", person02.Item1);
        Assert.Equal(18, person02.Item2);

        //----------------------------------------------------------------------------------------------------
        // 没有解构, 显式指定 tuple 的类型, 并且指定 tuple 的字段名.
        //----------------------------------------------------------------------------------------------------
        (string name03, int age03) person03 = C01.GetPerson();
        Assert.Equal("luotao", person03.name03);
        Assert.Equal(18, person03.age03);

        //----------------------------------------------------------------------------------------------------
        // 解构, 将 tuple 的字段解构到单独的变量中.
        //----------------------------------------------------------------------------------------------------
        (string name04, int age04) = C01.GetPerson();
        Assert.Equal("luotao", name04);
        Assert.Equal(18, age04);

        //----------------------------------------------------------------------------------------------------
        // 解构, 将 tuple 的字段解构到单独的变量中.
        //----------------------------------------------------------------------------------------------------
        var (name05, age05) = C01.GetPerson();
        Assert.Equal("luotao", name05);
        Assert.Equal(18, age05);

        //----------------------------------------------------------------------------------------------------
        // 解构, 将 tuple 的字段解构到已经存在的变量中.
        //----------------------------------------------------------------------------------------------------
        string name06;
        int age06;
        (name06, age06) = C01.GetPerson();
        Assert.Equal("luotao", name06);
        Assert.Equal(18, age06);
    }
}

public class C01
{
    public static (string, int) GetPerson()
    {
        return ("luotao", 18);
    }
}
