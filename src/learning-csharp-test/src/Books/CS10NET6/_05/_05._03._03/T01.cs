using Luotao.Lib.Books.CS10NET6._05;

namespace Luotao.Test.Books.CS10NET6._05._03._03;

/// <summary>
/// 5.3.3 setting and outputting field values
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
        Person person = new();
        person.Name = "luotao";
        person.DateOfBirth = new DateTime(1990, 1, 1);

        testOutputHelper.WriteLine("{0} was born on {1:yyyy-MM-dd}", person.Name, person.DateOfBirth);
    }

    [Fact]
    public void _02()
    {
        Person person = new()
        {
            Name = "luotao",
            DateOfBirth = new DateTime(1990, 1, 1)
        };

        testOutputHelper.WriteLine($"{person.Name} was born on {person.DateOfBirth:yyyy-MM-dd}");
    }
}
