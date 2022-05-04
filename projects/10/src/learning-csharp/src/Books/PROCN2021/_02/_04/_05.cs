namespace Luotao.LearningCsharp.Test.Books.PROCN2021._02._04;

/// <summary>
/// 2.4.5. the switch expression
/// </summary>
public class _05
{
    private readonly ITestOutputHelper testOutputHelper;

    public _05(ITestOutputHelper testOutputHelper)
    {
        this.testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void _01()
    {
        bool b = true;

        string str = b switch
        {
            true => "true",
            false => "false"
        };

        Assert.Equal(str, "true");
    }

    /// <summary>
    /// pattern combinator.
    /// </summary>
    [Fact]
    public void _02()
    {
        // 使用 or / and / not 组合多个 pattern
        string Fn01(int? i)
        {
            return i switch
            {
                0 => "0",
                1 or 2 => "1,2",
                > 3 and < 6 => "(3, 6)",
                null => "null",
                not null => "not null",
            };
        }
    }
}
