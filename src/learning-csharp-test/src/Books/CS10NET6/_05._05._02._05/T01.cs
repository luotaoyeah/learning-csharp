using Luotao.Lib.Books.CS10NET6._05;

namespace Luotao.Test.Books.CS10NET6._05._05._02._05;

/// <summary>
/// 5.5.2.5. deconstructing types
/// </summary>
public class T01
{
    [Fact]
    public void _01()
    {
        var (name, planet) = new Person("luotao", "Mars");
        Assert.Equal("luotao", name);
        Assert.Equal("Mars", planet);
    }
}
