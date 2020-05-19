using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.ICS7._20._01
{
    /// <summary>
    ///     20.1 what is LINQ ?
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///     LINQ 的全称为 Language Integrated Query，发音跟 link 一样，
        /// </summary>
        [Fact]
        public void _01()
        {
            int[] arr01 = { 1, 2, 3 };

            // 使用 LINQ 表达式
            IEnumerable<int> query01 =
                from i in arr01
                where i < 3
                select i;

            foreach (var i in query01) testOutputHelper.WriteLine(i.ToString());

            IEnumerable<int> query02 = arr01.Where(i => i < 3).Select(i => i);
            foreach (var i in query02) testOutputHelper.WriteLine(i.ToString());
        }
    }
}
