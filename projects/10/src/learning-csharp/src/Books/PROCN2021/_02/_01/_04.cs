namespace Luotao.LearningCsharp.Test.Books.PROCN2021._02._01;

/// <summary>
/// 2.1.4. understanding variable scope
/// </summary>
public class _04
{
    private readonly ITestOutputHelper testOutputHelper;

    public _04(ITestOutputHelper testOutputHelper)
    {
        this.testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void _01()
    {
        {
            // CS0136
            // 同一个作用域内, 变量不能同名
            // int i = 1;
        }

        int i = 2;
    }
}
