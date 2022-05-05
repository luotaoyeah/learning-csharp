namespace Luotao.LearningCsharp.Test.Books.PROCN2021._02._01;

/// <summary>
/// 2.1.4. understanding variable scope
/// </summary>
public class T04
{
    private readonly ITestOutputHelper testOutputHelper;

    public T04(ITestOutputHelper testOutputHelper)
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

#pragma warning disable CS0219
        int i = 2;
#pragma warning restore CS0219
    }
}
