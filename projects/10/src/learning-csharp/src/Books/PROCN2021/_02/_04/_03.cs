namespace Luotao.LearningCsharp.Test.Books.PROCN2021._02._04;

/// <summary>
/// 2.4.3. the switch statement
/// </summary>
public class _03
{
    private readonly ITestOutputHelper testOutputHelper;

    public _03(ITestOutputHelper testOutputHelper)
    {
        this.testOutputHelper = testOutputHelper;
    }

    /// <summary>
    /// </summary>
    [Fact]
    public void _01()
    {
        int i01 = 6;

        switch (i01)
        {
            // 若 case 下面有代码, 则必须有 break,
            case 0:
                testOutputHelper.WriteLine("0");
                break;

            case 6:
                testOutputHelper.WriteLine("6");
                goto case 0;

            case 9: break;

            default: break;
        }
    }
}
