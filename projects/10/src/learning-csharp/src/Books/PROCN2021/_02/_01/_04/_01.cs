namespace Luotao.LearningCsharp.Test.Books.PROCN2021._02._01._04;

/// <summary>
/// 2.1.4. understanding variable scope
/// </summary>
public class _01
{
    private readonly ITestOutputHelper testOutputHelper;

    public _01(ITestOutputHelper testOutputHelper)
    {
        this.testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void _02()
    {
        {
            // CS0136
            // 同一个作用域内, 变量不能同名
            // int i = 1;
        }

        int i = 2;
    }
}
