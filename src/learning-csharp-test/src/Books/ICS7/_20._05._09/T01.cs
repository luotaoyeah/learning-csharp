using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.ICS7._20._05._09
{
    /// <summary>
    ///     20.5.9 query continuation: the into clause
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///     into 子句给中间的某个结果集合指定一个 name，让它可以在其他地方使用，
        /// </summary>
        [Fact]
        public void _01()
        {
            int[] arr01 = { 3, 4, 5, 6 };
            int[] arr02 = { 4, 5, 6, 7 };

            var query =
                from i in arr01
                join j in arr02 on i equals j into temp
                from x in temp
                select x;

            foreach (var i in query) testOutputHelper.WriteLine(i.ToString());
        }
    }
}
