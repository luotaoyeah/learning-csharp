using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace LuotaoYeah.Test.Books.ICS7._20._05._04._01
{
    /// <summary>
    ///     20.5.4.1 the from clause
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///     当一个 query expression 中包含多个 from clause 时，类似于嵌套的循环，
        /// </summary>
        [Fact]
        public void _01()
        {
            int[] arr01 = { 3, 4, 5, 6 };
            int[] arr02 = { 6, 7, 8, 9 };

            var query =
                from a in arr01
                from b in arr02
                select new { a, b };

            foreach (var o in query) testOutputHelper.WriteLine($"{o.a} {o.b}");
        }
    }
}
