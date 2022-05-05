namespace Luotao.LearningCsharp.Test.Books.PROCN2021._02._01;

/// <summary>
/// 2.1.2. variables
/// </summary>
public class T02
{
    private readonly ITestOutputHelper testOutputHelper;

    public T02(ITestOutputHelper testOutputHelper)
    {
        this.testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void _01()
    {
        string s01 = new string("foo");
        string s02 = "foo";
        var s03 = "foo";
        string s04 = new("foo");
        String s05 = "foo";

        Assert.Equal(s01, s02);
        Assert.Equal(s03, s04);
        Assert.Equal(s03, s05);
    }
}
