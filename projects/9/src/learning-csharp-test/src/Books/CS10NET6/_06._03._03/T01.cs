using Luotao.Lib.Books.CS10NET6._06;

namespace Luotao.Test.Books.CS10NET6._06._03._03;

/// <summary>
/// 6.3.3. defining and handling events
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

        // 监听一个事件
        person.Shout += (sender, args) => { testOutputHelper.WriteLine(((Person?)sender)?.AngerLevel.ToString()); };

        person.Poke();
        person.Poke();
        person.Poke();
        person.Poke();
    }
}
