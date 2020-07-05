using Luotao.Lib.Books.CS10NET6._05;

namespace Luotao.Test.Books.CS10NET6._05._04._04;

/// <summary>
/// 5.4.4. making a field read-only
/// </summary>
public class T01
{
    [Fact]
    public void _01()
    {
        Assert.Equal("Earth", new Person().HomePlanet);
    }
}
