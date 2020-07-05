using Luotao.Lib.Books.CS10NET6._05;

namespace Luotao.Test.Books.CS10NET6._05._04._05;

/// <summary>
/// 5.4.5. initializing fields with constructors
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
        var person = new Person();
        Assert.Equal("Unknown", person.Name);
        testOutputHelper.WriteLine(person.Instantiated.ToString("HH:mm:ss"));
    }

    [Fact]
    public void _02()
    {
        var person = new Person("luotao", homePlanet: "Mars");
        Assert.Equal("luotao", person.Name);
        testOutputHelper.WriteLine(person.Instantiated.ToString("HH:mm:ss"));
    }
}
