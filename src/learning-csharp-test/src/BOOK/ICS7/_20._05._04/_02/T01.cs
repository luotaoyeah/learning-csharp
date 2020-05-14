using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.ICS7._20._05._04._02
{
    /// <summary>
    /// 20.5.4.2 the let clause
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        /// let 子句用来定义一个临时的变量，这个临时的变量可以被其他的子句使用，
        /// </summary>
        [Fact]
        public void _01()
        {
            int[] arr01 = { 3, 4, 5, 6 };
            int[] arr02 = { 6, 7, 8, 9 };

            var query =
                from a in arr01
                from b in arr02
                let sum = a + b
                where sum == 12
                select new { a, b, sum };

            foreach (var o in query)
            {
                testOutputHelper.WriteLine($"{o.a} + {o.b} = {o.sum}");
            }
        }
    }
}
