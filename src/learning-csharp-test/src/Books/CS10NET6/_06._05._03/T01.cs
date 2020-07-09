using Luotao.Lib.Books.CS10NET6._06;

namespace Luotao.Test.Books.CS10NET6._06._05._03;

/// <summary>
/// 6.5.3. comparing objects using a separate class
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
        Person[] persons =
        {
            new() { Name = "C" },
            new() { Name = "A" },
            new() { Name = "D" },
            new() { Name = "B" },
        };

        foreach (var person in persons)
        {
            testOutputHelper.WriteLine(person.Name);
        }

        testOutputHelper.WriteLine("----------");

        Array.Sort(persons);

        foreach (var person in persons)
        {
            testOutputHelper.WriteLine(person.Name);
        }

        testOutputHelper.WriteLine("----------");

        // 指定用哪个 comparer 去比较
        Array.Sort(persons, new PersonComparer());

        foreach (var person in persons)
        {
            testOutputHelper.WriteLine(person.Name);
        }
    }
}
