namespace Luotao.LearningCsharp.Test.Books.PROCN2021._02._02._01;

/// <summary>
/// 2.2.1. nullable value types
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
        int? i01 = null;
        Nullable<int> i02 = null;

        Assert.False(i01.HasValue);
        Assert.Throws<InvalidOperationException>(
            () => testOutputHelper.WriteLine("{0}", i01.Value)
        );
    }
}
