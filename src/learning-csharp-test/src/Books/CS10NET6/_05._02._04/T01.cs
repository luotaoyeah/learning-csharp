using Luotao.Lib.Books.CS10NET6._05;

namespace Luotao.Test.Books.CS10NET6._05._02._04;

/// <summary>
/// 5.2.4. instantiating a class
/// </summary>
public class T01
{
    [Fact]
    public void _01()
    {
        Person person = new();
        Assert.Equal("Luotao.Lib.Books.CS10NET6._05.Person", person.ToString());
    }
}
