using Luotao.Lib.Books.CS10NET6._05;

namespace Luotao.Test.Books.CS10NET6._05._04;

/// <summary>
/// 5.4. storing multiple values using collections
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
        person.Children.Add(new Person { Name = "luotao" });
        person.Children.Add(new() { Name = "owen" });

        Assert.Equal(2, person.Children.Count);

        foreach (Person child in person.Children)
        {
            testOutputHelper.WriteLine(child.Name);
        }
    }
}
