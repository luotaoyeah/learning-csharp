using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.ICS7._20._05._05
{
    /// <summary>
    ///     20.5.5 the orderby clause
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///     使用 orderby 子句进行排序，
        ///     使用 ascending/descending 指定正序/逆序，
        /// </summary>
        [Fact]
        public void _01()
        {
            var arr01 = new[]
            {
                new { Name = "a", Age = 20 },
                new { Name = "b", Age = 19 },
                new { Name = "c", Age = 19 },
                new { Name = "b", Age = 17 }
            };

            var query =
                from n in arr01
                orderby n.Age, n.Name descending
                select n;

            foreach (var n in query) testOutputHelper.WriteLine($"{n.Age}, {n.Name}");
        }
    }
}
