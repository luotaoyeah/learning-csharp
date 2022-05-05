namespace Luotao.LearningCsharp.Test.Books.PROCN2021._02._02;

/// <summary>
/// 2.2.1. nullable value types
/// </summary>
public class T01
{
    private readonly ITestOutputHelper testOutputHelper;

    public T01(ITestOutputHelper testOutputHelper)
    {
        this.testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void _02()
    {
        int? i01 = null;
#pragma warning disable CS0219
        Nullable<int> i02 = null;
#pragma warning restore CS0219

        Assert.False(i01.HasValue);
        Assert.Throws<InvalidOperationException>(
#pragma warning disable CS8629
            () => testOutputHelper.WriteLine("{0}", i01.Value)
#pragma warning restore CS8629
        );
    }
}
