using Luotao.Lib.Books.CS10NET6._05;

namespace Luotao.Test.Books.CS10NET6._05._04._03;

/// <summary>
/// 5.4.3. making a field constant
/// </summary>
public class T01
{
    [Fact]
    public void _01()
    {
        // const field 必须通过类名访问, 因为 const field 同时也是 static 的
        Assert.Equal("Homo Sapiens", Person.Species);
    }
}
