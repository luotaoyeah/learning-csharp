namespace Luotao.LearningCsharp.Test.Books.PROCN2021._02._04;

/// <summary>
/// 2.4.4. pattern matching with the switch statement
/// </summary>
public class _04
{
    private readonly ITestOutputHelper testOutputHelper;

    public _04(ITestOutputHelper testOutputHelper)
    {
        this.testOutputHelper = testOutputHelper;
    }

    /// <summary>
    /// </summary>
    [Fact]
    public void _01()
    {
        void SwitchWithPatternMatching(object? o)
        {
            switch (o)
            {
                // const pattern
                case null: break;

                // type pattern / relational pattern
                case int i when i < 9: break;

                // type pattern
                // 未定义变量
                case int: break;

                // type pattern
                // 定义了变量
                case double d: break;
            }
        }
    }
}
