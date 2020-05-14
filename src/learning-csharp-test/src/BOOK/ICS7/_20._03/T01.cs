using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.ICS7._20._03
{
    /// <summary>
    /// 20.3 method syntax and query syntax 
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        /// LINQ 的写法有两种语法形式：method syntax 和 query syntax，它们可以混合使用，
        /// </summary>
        [Fact]
        public void _01()
        {
            int[] numbers = { 2, 5, 28, 31, 17, 16, 42 };

            //----------------------------------------------------------------------------------------------------
            // query syntax
            //----------------------------------------------------------------------------------------------------
            IEnumerable<int> query01 =
                from n in numbers
                where n < 20
                select n;

            //----------------------------------------------------------------------------------------------------
            // method syntax
            //----------------------------------------------------------------------------------------------------
            IEnumerable<int> query02 = numbers.Where((i) => i < 20);

            int count =
            (
                from n in numbers
                where n < 20
                select n
            ).Count();
            Assert.Equal(4, count);
        }
    }
}
