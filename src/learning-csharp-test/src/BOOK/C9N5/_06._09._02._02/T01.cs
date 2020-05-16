using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.C9N5._06._09._02._02
{
    /// <summary>
    ///     6.9.2.2 Using extension methods to reuse functionality
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void _01()
        {
            Assert.Equal(9, string.Empty.F01());
        }
    }

    /// <summary>
    ///     扩展方法(extension method).
    /// </summary>
    public static class C01
    {
        public static int F01(this string str)
        {
            return 9;
        }
    }
}
