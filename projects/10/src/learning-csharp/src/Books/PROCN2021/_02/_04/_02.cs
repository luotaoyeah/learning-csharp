namespace Luotao.LearningCsharp.Test.Books.PROCN2021._02._04;

/// <summary>
/// 2.4.2. pattern matching with the is operator
/// </summary>
public class _02
{
    private readonly ITestOutputHelper testOutputHelper;

    public _02(ITestOutputHelper testOutputHelper)
    {
        this.testOutputHelper = testOutputHelper;
    }

    /// <summary>
    /// pattern matching 可以用在 if / switch statement / switch expression,
    /// pattern matching 的类型包括 const pattern / type pattern / ...
    /// </summary>
    [Fact]
    public void _01()
    {
        void Fn01(object? o)
        {
            // const pattern
            if (o is null)
            {
            }

            if (o is not null)
            {
            }

            // type pattern
            if (o is byte b)
            {
                testOutputHelper.WriteLine(nameof(b));
            }
        }
    }
}
