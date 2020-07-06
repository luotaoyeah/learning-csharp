using Luotao.Lib.Books.CS10NET6._05;

namespace Luotao.Test.Books.CS10NET6._05._05._05;

/// <summary>
/// 5.5.5. passing optional parameters and naming arguments
/// </summary>
public class T01
{
    [Fact]
    public void _01()
    {
        var person = new Person();
        Assert.Equal("Run, 0, True", person.OptionalParameters());

        //----------------------------------------------------------------------------------------------------
        // 调用方法时, 可以使用 positional parameter, 即按照形参顺序传参,
        // 也可以使用 named parameter, 即指定参数名称, 这样就可以不理会形参顺序.
        //
        // 使用 named parameter 可以省略中间某个 optional parameter 并且传递后面某个 optional parameter,
        // 使用 positional parameter 则不行.
        //
        // positional parameter 和 named parameter 可以混用,
        // 此时 named parameter 必须位于所有的 posotional parameter 后面.
        //----------------------------------------------------------------------------------------------------
        Assert.Equal("Fly, 0, False", person.OptionalParameters("Fly", active: false));
    }
}
