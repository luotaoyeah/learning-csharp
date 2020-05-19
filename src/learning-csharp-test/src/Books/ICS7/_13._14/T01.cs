using LuotaoYeah.Lib.Books.ICS7._13._14;
using Xunit;
using Xunit.Abstractions;

namespace LuotaoYeah.Test.Books.ICS7._13._14
{
    /// <summary>
    ///     13.14 arrays and ref return and ref local
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
            int[] arr01 = { 5, 80 };
            ref var highest = ref C01.PointerToHighestPositive(arr01);
            Assert.Equal(80, highest);

            highest = 0;
            Assert.Equal(0, arr01[1]);
        }
    }
}
