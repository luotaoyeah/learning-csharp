using Xunit;
using Xunit.Abstractions;

namespace LuotaoYeah.Test.Books.C9N5._05._04._06
{
    /// <summary>
    ///     5.4.6 controlling how parameters are passed
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
            var x = 6;
            var y = 6;
            var z = 6;

            Assert.Equal(6, x);
            Assert.Equal(6, y);
            Assert.Equal(6, z);

            C01.F01(x, ref y, out z);

            Assert.Equal(6, x);
            Assert.Equal(9, y);
            Assert.Equal(9, z);
        }
    }

    public class C01
    {
        public static void F01(int x, ref int y, out int z)
        {
            x = 9;
            y = 9;
            z = 9;
        }
    }
}
